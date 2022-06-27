using Interface.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface.SellSystem
{
    public partial class fPayment : Form
    {
        DataTable loadCongThuc;
        DataTable tblPTTT;
        public fPayment()
        {
            InitializeComponent();

        }

        #region Properties
        string MaNV;
        string MaGG;
        string PTTT;
        int tongTien;

        #endregion

        private void fPayment_Load(object sender, EventArgs e)
        {
            load_PTTTL();
            dtgvPTTT.ClearSelection();
            dtgvPTTT.CurrentCell = null;
            txtPhaiTra.Text = Convert.ToString(Settings.Default.tongTien);
        }

        private void load_PTTTL()
        {
            string sql = "SELECT TenPTTT, MaPTTT FROM PTTT";
            tblPTTT = Functions.GetDataToTable(sql);
            dtgvPTTT.DataSource = tblPTTT;
            dtgvPTTT.Columns[0].HeaderText = "Phương thức thanh toán";
            dtgvPTTT.Columns[0].Width = 400;
        }
        private void Add_NL()
        {
            string temp = "NL.txt";
            List<string> lstData = File.ReadAllLines(@"Data\Order.txt").ToList();
            int lstNLcount = 0;
            for (int i = 0; i < lstData.Count; i++)
            {
                string line = lstData[i];
                string MaSPCheck = line.Split('|')[0];
                int SoLuongSP = Convert.ToInt32(line.Split('|')[2]);
                string sql = "SELECT MaNL, SoLuongNL FROM CongThuc WHERE MaSP = '" + MaSPCheck + "'";
                loadCongThuc = Functions.GetDataToTable(sql);
                foreach (DataRow item in loadCongThuc.Rows)
                {
                    // List<string> lstNL = File.ReadAllLines(@"Data\NL.txt").ToList();
                    string _maNL = item["MaNL"].ToString();
                    string _soLuongNL = item["SoLuongNL"].ToString();
                    //  File.AppendAllText(@"Data\NL.txt", _maNL + '|' + _soLuongNL + "\r\n");
                    int SoLuong = Convert.ToInt32(Functions.GetFieldValues(("SELECT SoLuong FROM NL WHERE  MaNL = N'" + _maNL + "'")));
                    string updateSoluong = "UPDATE NL SET SoLuong =" + (SoLuong - Convert.ToInt32(_soLuongNL) * SoLuongSP) + " WHERE MaNL = N'" + _maNL + "'";
                    Functions.RunSqlDel(updateSoluong);
                }
            }
        }
        private void Add_HDBH()
        {
            string MaNV = Settings.Default.MaNV;
            string MaPTTT = dtgvPTTT.CurrentRow.Cells[1].Value.ToString();
            string MaGG = Settings.Default.maGG;
            tongTien = Settings.Default.tongTien;
            if(MaGG == null)
            {
                string sql = "INSERT INTO HDBH(MaNV, MaPTTT, MaGG, ThoiGian, TongTien) VALUES ('" + MaNV + "', '" + MaPTTT + "', NULL , CURRENT_TIMESTAMP, " + tongTien + ")";
                Functions.RunSqlDel(sql);
            }
            else
            {
                string sql = "INSERT INTO HDBH(MaNV, MaPTTT, MaGG, ThoiGian, TongTien) VALUES ('" + MaNV + "', '" + MaPTTT + "', '" + MaGG + "', CURRENT_TIMESTAMP, " + tongTien + ")";
                Functions.RunSqlDel(sql);
            }

        }

        private void Add_ChiTietHDBH()
        {
            string maHDBH = Functions.GetFieldValues("SELECT TOP 1 MaHDBH FROM HDBH ORDER BY MaHDBH DESC");
            List<string> lstData = File.ReadAllLines(@"Data\Order.txt").ToList();
            for (int i = 0; i < lstData.Count; i++)
            {
                string data = lstData[i];
                string maSP = data.Split('|')[0];
                int soLuong = Convert.ToInt32(data.Split('|')[2]);
                int donGia = Convert.ToInt32(data.Split('|')[3]);
                string sql = "INSERT INTO ChiTietHDBH(MaHDBH, MaSP, SoLuong, ThanhTien) VALUES ('" + maHDBH + "', '" + maSP + "', " + soLuong + ", " + soLuong * donGia + ")";
                Functions.RunSqlDel(sql);
            }
        }


        private void Check_ThanhToan()
        {
            if (txtDaNhan.Text.Trim().Length == 0)
            {
                MessageBox.Show("Xin mời nhập số tiền đã nhận!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDaNhan.Focus();
                return;
            }
            else if (dtgvPTTT.SelectedRows == null)
            {
                MessageBox.Show("Xin mời chọn phương thức thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (Convert.ToInt32(txtPhaiTra.Text) > Convert.ToInt32(txtDaNhan.Text))
            {
                MessageBox.Show("Số tiền đã nhận nhỏ hơn số tiền thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (MessageBox.Show("Xác nhận thanh toán!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Add_HDBH();
                    Add_ChiTietHDBH();
                    Add_NL();
                }
                else
                {
                    return;
                }
            }
        }


        private void siiButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            Check_ThanhToan();
            File.WriteAllText(@"Data/Order.txt", string.Empty);
            File.WriteAllText(@"Data/NL.txt", string.Empty);
            this.Close();
        }

        private void txtDaNhan__TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtTienThua.Text = Convert.ToString(Convert.ToInt32(txtDaNhan.Text) - Convert.ToInt32(txtPhaiTra.Text));
            }
            catch
            {

            }
        }

        private void txtDaNhan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void fPayment_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.WriteAllText(@"Data/NL.txt", string.Empty);
        }


        //private static string NumberToMoney(string input)
        //{
        //    string getStrNumb = "";
        //    if (input.Length > 0)
        //    {

        //        foreach (char kt in input) if (char.IsDigit(kt)) getStrNumb += kt;

        //    }
        //    else
        //    {
        //        getStrNumb = "0";
        //    }
        //    return ((getStrNumb.Length > 0) ? (string.Format("{0:0,000}", decimal.Parse(getStrNumb))).Replace(',', '.') : "0");
        //}
        //private static int MoneyToNumber(string input)
        //{
        //    string kq = input.Replace(".", "");
        //    int x = Convert.ToInt32(kq);
        //    return x;
        //}
    } 
}

