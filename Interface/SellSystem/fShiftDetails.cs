using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface.Properties;
using System.Windows.Forms;

namespace Interface.SellSystem
{
    public partial class fShiftDetails : Form
    {
        DataTable tblTongGG;
        DataTable tblHDBH;
        DataTable tblPTTT;

        public fShiftDetails()
        {
            InitializeComponent();
        }

        #region Properties
        string MaHDBH;
        bool active;
        #endregion

        private void fShiftDetails_Load(object sender, EventArgs e)
        {
            Tien(); 
            loadHDBH();
            
            dtgvPTTT.ClearSelection();
            dtgvPTTT.CurrentCell = null;

            if (active == true)
            {
                btnDongCa.Enabled = true;
                btnMoCa.Enabled = false;
            }
            else
            {
                btnDongCa.Enabled = false;
                btnMoCa.Enabled = true;
            }
        }

        private void Tien()
        {
            try
            {
                double tongGG = 0;
                string sqlDT = "SELECT SUM(TongTien) FROM HDBH  WHERE DAY(ThoiGian) = '" + DatePick.Value.Day + "' AND MONTH(ThoiGian) = '" + DatePick.Value.Month + "' AND YEAR(ThoiGian) = '" + DatePick.Value.Year + "'";
                lblDoanhThu.Text = Functions.GetFieldValues(sqlDT);
                string sqlTongGG = "SELECT a.TongTien, b.PhanTram FROM HDBH a JOIN MGG b ON a.MaGG = b.MaGG  WHERE DAY(a.ThoiGian) = '" + DatePick.Value.Day + "' AND MONTH(a.ThoiGian) = '" + DatePick.Value.Month + "' AND YEAR(a.ThoiGian) = '" + DatePick.Value.Year + "'";
                tblTongGG = Functions.GetDataToTable(sqlTongGG);
                foreach (DataRow item in tblTongGG.Rows)
                {
                    double _tongTien = Convert.ToDouble(item["TongTien"]);
                    double _phamTram = Convert.ToDouble(item["PhanTram"]);
                    tongGG = tongGG + (_tongTien - _tongTien * (_phamTram / 100));
                }
                string sqlTBHD = "SELECT AVG(TongTien) FROM HDBH  WHERE DAY(ThoiGian) = '" + DatePick.Value.Day + "' AND MONTH(ThoiGian) = '" + DatePick.Value.Month + "' AND YEAR(ThoiGian) = '" + DatePick.Value.Year + "'";
                lblTBHoaDon.Text = Functions.GetFieldValues(sqlTBHD);
                if (lblDoanhThu.Text == "")
                {
                    lblDoanhThu.Text = "0";
                }
                if (lblTBHoaDon.Text == "")
                {
                    lblTBHoaDon.Text = "0";
                }
                lblTongGG.Text = tongGG.ToString();
                lblChietKhau.Text = Convert.ToString(Convert.ToDouble(Functions.GetFieldValues(sqlDT)) - tongGG);
                string sqlPhieuGG = "SELECT COUNT(MaGG) FROM HDBH  WHERE DAY(ThoiGian) = '" + DatePick.Value.Day + "' AND MONTH(ThoiGian) = '" + DatePick.Value.Month + "' AND YEAR(ThoiGian) = '" + DatePick.Value.Year + "' AND MaGG != 'NULL'";
                lblPhieuGG.Text = Functions.GetFieldValues(sqlPhieuGG);
                string sqldtgvPTTT = "SELECT TenPTTT, MaPTTT FROM PTTT";
                tblPTTT = Functions.GetDataToTable(sqldtgvPTTT);

                foreach (DataRow item in tblPTTT.Rows)
                {
                    int TongTien = 0;
                    string _tenPTTT = item["TenPTTT"].ToString();
                    string _maPTTT = item["MaPTTT"].ToString();
                    string sqlPTTT = "SELECT SUM(TongTien) FROM HDBH WHERE DAY(ThoiGian) = '" + DatePick.Value.Day + "' AND MONTH(ThoiGian) = '" + DatePick.Value.Month + "' AND YEAR(ThoiGian) = '" + DatePick.Value.Year + "' AND MaPTTT = '" + _maPTTT + "'";
                    string TongTienstring = Functions.GetFieldValues(sqlPTTT);
                    if (TongTienstring == "")
                    {
                        TongTien = 0;
                        dtgvPTTT.Rows.Add(_tenPTTT, TongTien, _maPTTT);
                    }
                    else
                    {
                        TongTien = Convert.ToInt32(TongTienstring);
                        dtgvPTTT.Rows.Add(_tenPTTT, TongTien, _maPTTT);
                    }
                }

            }
            catch { }
            
        }

        private void loadHDBH()
        {
            string sql = "SELECT b.TenNV, c.TenPTTT, a.MaGG, CONVERT(CHAR(7),a.ThoiGian,108), a.TongTien, a.MaHDBH FROM HDBH a JOIN NhanVien b ON a.MaNV = b.MaNV JOIN PTTT c ON a.MaPTTT = c.MaPTTT WHERE DAY(a.ThoiGian) = '" + DatePick.Value.Day + "' AND MONTH(a.ThoiGian) = '" + DatePick.Value.Month + "' AND YEAR(a.ThoiGian) = '" + DatePick.Value.Year + "'";
            tblHDBH = Functions.GetDataToTable(sql);
            dtgvHDBH.DataSource = tblHDBH;
            dtgvHDBH.Columns[0].HeaderText = "Nhân viên";
            dtgvHDBH.Columns[0].Width = 200;
            dtgvHDBH.Columns[1].HeaderText = "PTTT";
            dtgvHDBH.Columns[1].Width = 170;
            dtgvHDBH.Columns[2].HeaderText = "Giảm giá";
            dtgvHDBH.Columns[2].Width = 150;
            dtgvHDBH.Columns[3].HeaderText = "Thời gian";
            dtgvHDBH.Columns[3].Width = 100; 
            dtgvHDBH.Columns[4].HeaderText = "Tổng tiền";

            lblSoHD.Text = tblHDBH.Rows.Count.ToString();
        }

        private void dtgvHDBH_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                MaHDBH = (string)dtgvHDBH.CurrentRow.Cells[5].Value;
            }
            catch { }
        }

        private void sửaSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fix.fFixShiftDetails fix = new Fix.fFixShiftDetails(MaHDBH);
            fix.ShowDialog();
        }

        private void DataDongCa()
        {
            string MaNV = Settings.Default.MaNV;
            string sql = "INSERT INTO BaoCaoDT(MaNV, TongTien, ThoiGian) VALUES(N'" + MaNV + "',N'" + lblTongGG.Text + "', CURRENT_TIMESTAMP)";
            Functions.RunSqlDel(sql);
        }

        private void btnDongCa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận đóng ca!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                btnMoCa.Enabled = true;
                btnDongCa.Enabled = false;
                Settings.Default.CaActive = false;
                Settings.Default.Save();
                DataDongCa();
            }

        }

        private void btnMoCa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận mở ca!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                btnDongCa.Enabled = true;
                btnMoCa.Enabled = false;
                Settings.Default.Save();
                Settings.Default.CaActive = true;
            }
        }
    }
}
