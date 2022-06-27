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
using System.Data.SqlClient;
using Interface.Constants;

namespace Interface.SellSystem
{
    public partial class fOrder : Form
    {
        List<LoadDMSP> LoadDMSPs = new();
        List<GioHang> GioHang = new();
        DataTable tblOrder;
        DataTable loadDMSP;
        private readonly List<GioHang> _gioHang;
        public fOrder(List<GioHang> gioHang)
        {
            _gioHang = gioHang;
            InitializeComponent();
        }
        #region Properties
        int indexTabControl;
        int indexTamTinh;
        string MaSP;
        string tabName;
        string TenSP;
        string GiaTien;
        int tongtien;
        #endregion




        private void siiButton1_Click(object sender, EventArgs e)
        {
            if (Settings.Default.CaActive == false)
            {
                MessageBox.Show("Đã đóng ca! Không thể thực hiện thanh toán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if(txtTongTien.Text == "")
            {
                MessageBox.Show("Hãy chọn đồ uống để thanh toán!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                next_ThanhToan();
                SellSystem.fPayment pm = new fPayment();
                pm.ShowDialog();
                Load_ThanhToan();

            }
        }

        private void fOrder_Load(object sender, EventArgs e)
        {
            LoadTabControl();
            LoadDTGV();          
            Load_ThanhToan();
            Load_MaGG();
            LoadActive();
        }
        private void LoadDTGV()
        {
            string sql;
            indexTabControl = Settings.Default.indexTabControl;
            if (TabOrder.TabPages == null)
            {
                return;
            }
            else
            {
                tabName = TabOrder.TabPages[indexTabControl].Text.ToString();
                TabOrder.SelectedIndex = indexTabControl;
                sql = "SELECT a.TenSP, b.TenDMSP, a.DonGia, a.MaSP FROM SP a JOIN DMSP b ON a.MaDMSP = b.MaDMSP WHERE b.TenDMSP = '" + tabName + "'";
                tblOrder = Functions.GetDataToTable(sql);

                dtgvLoaiSP.DataSource = tblOrder;
                dtgvLoaiSP.Columns[0].HeaderText = "Tên đồ uống";
                dtgvLoaiSP.Columns[1].HeaderText = "Loại sản phẩm";
                dtgvLoaiSP.Columns[2].HeaderText = "Giá Tiền";
                dtgvLoaiSP.Columns[0].Width = 300;
                dtgvLoaiSP.Columns[1].Width = 250;
                dtgvLoaiSP.Columns[2].Width = 100;
            }

        }

        private void next_ThanhToan()
        {
            Settings.Default.maGG = (string)cboMaGG.SelectedValue;
            Settings.Default.tongTien = Convert.ToInt32(txtTongTien.Text);
            Settings.Default.Save();
        }
        private void Load_MaGG()
        {
            Functions.FillCombo("SELECT MaGG,TenMGG FROM MGG", cboMaGG, "MaGG", "TenMGG");
            cboMaGG.SelectedIndex = -1;
        }
        
        private void LoadActive()
        {
            bool Active = Settings.Default.CaActive;
            if(Active == true)
            {
                lblActiveCa.Text = "Đang mở";
                lblActiveCa.ForeColor = Color.DarkGreen;
            }
            else
            {
                lblActiveCa.Text = "Đang đóng";
                lblActiveCa.ForeColor = Color.DarkRed;
            }
        }

        private void LoadTabControl()
        {
            //TabPage tabPage = new TabPage();
            //TabOrder.Controls.Add(tabPage);

            string sql = "SELECT * FROM DMSP";
            loadDMSP = Functions.GetDataToTable(sql);
            foreach (DataRow item in loadDMSP.Rows)
            {
                string _maDMSP = item["MaDMSP"].ToString();
                string _tenDMSP = item["TenDMSP"].ToString();
                TabPage tabPage = new TabPage(_tenDMSP);
                TabOrder.Controls.Add(tabPage);
            }         
        }
        
        private void TabOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexTabControl = TabOrder.SelectedIndex;
            Settings.Default.indexTabControl = indexTabControl;
            Settings.Default.Save();
            LoadDTGV();
        }


        private void dtgvLoaiSP_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MaSP = dtgvLoaiSP.CurrentRow.Cells[3].Value.ToString();
            TenSP = dtgvLoaiSP.CurrentRow.Cells[0].Value.ToString();
            GiaTien = dtgvLoaiSP.CurrentRow.Cells[2].Value.ToString();
            ProductsNumber pn = new ProductsNumber(MaSP,TenSP,GiaTien);
            pn.ShowDialog();
            Load_ThanhToan();
            
        }

        private void dtgvLoaiSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MaSP = dtgvLoaiSP.CurrentRow.Cells[3].Value.ToString();
            //TenSP = dtgvLoaiSP.CurrentRow.Cells[0].Value.ToString();
            ////GiaTien = Convert.ToInt32(dtgvLoaiSP.CurrentRow.Cells[2].Value);
            //Settings.Default.MaSP = MaSP;
            //Settings.Default.TenSP = TenSP;
            //Settings.Default.GiaTien = GiaTien;
            //Settings.Default.Save();

        }

        public void Load_ThanhToan()
        {

            int count = 1;
            tongtien = 0;
            dtgvThanhToan.Rows.Clear();
            List<string> lstData = File.ReadAllLines(@"Data\Order.txt").ToList();
            for (int i = 0; i < lstData.Count; i++)
            {
                string data = lstData[i];
                string maSP = data.Split('|')[0];
                string tenSP = data.Split('|')[1];
                int soLuong = Convert.ToInt32(data.Split('|')[2]);
                int donGia = Convert.ToInt32(data.Split('|')[3]);
                dtgvThanhToan.Rows.Add((count++).ToString(), tenSP, soLuong, donGia * soLuong, (i).ToString());
                tongtien = tongtien + (donGia * soLuong);
            }
            txtTongTien.Text = tongtien.ToString();
        }

        private void sửaSốLượngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fix.fixProductsNumber fpn = new Fix.fixProductsNumber();
            fpn.ShowDialog();
            Load_ThanhToan();
            dtgvThanhToan.CurrentCell = dtgvThanhToan.Rows[Settings.Default.indexTamTinh].Cells[0];
            dtgvThanhToan.Rows[Settings.Default.indexTamTinh].Selected = true;
        }

        private void dtgvThanhToan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Settings.Default.indexTamTinh = Convert.ToInt32(dtgvThanhToan.CurrentRow.Cells[4].Value);
            Settings.Default.Save();
        }

        private void xóaĐồUốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int index = Settings.Default.indexTamTinh;
                if (MessageBox.Show("Bạn có muốn xóa bài viết này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var file = new List<string>(File.ReadAllLines(@"Data\Order.txt"));
                    List<string> lstData = File.ReadAllLines(@"Data\Order.txt").ToList();
                    string data = lstData[Settings.Default.indexTamTinh];
                    //if (dtgvThanhToan.CurrentRow.Selected == false)
                    //{
                    //    MessageBox.Show("Mời bạn chọn dòng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //    return;
                    //}
                    file.RemoveAt(index);
                    File.WriteAllLines(@"Data\Order.txt", file.ToArray());
                    Load_ThanhToan();

                    if(dtgvThanhToan.Rows.Count == 0)
                    {
                        return;
                    }
                    else if(dtgvThanhToan.CurrentRow.Index > 0)
                    {
                        dtgvThanhToan.CurrentCell = dtgvThanhToan.Rows[Settings.Default.indexTamTinh - 1].Cells[0];
                    }
                    else
                    {
                        dtgvThanhToan.Rows[0].Selected = false;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Đã hết bài viét để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
        }
    }
}
