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

namespace Interface.Manage
{
    public partial class fListProducts : Form
    {
        DataTable tblSP;
        DataTable loadDMSP;
        DataTable tblLoadCT;


        public fListProducts()
        {
            InitializeComponent();
        }
        #region Properties
        int indexTabControlSP;
        string MaCongThuc;
        string MaFixCongThuc;
        string MaSPXoa;
        string tabName;
        #endregion

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
                TabSP.Controls.Add(tabPage);

            }
        }
        private void LoadDTGV()
        {
            string sql;
            if (TabSP.TabPages == null)
            {
                return;
            }
            else
            {
                indexTabControlSP = Settings.Default.indexTabControlSP;
                tabName = TabSP.TabPages[indexTabControlSP].Text.ToString();
                TabSP.SelectedIndex = indexTabControlSP;
                sql = "SELECT a.TenSP, b.TenDMSP, a.DonGia, a.MaSP FROM SP a JOIN DMSP b ON a.MaDMSP = b.MaDMSP WHERE b.TenDMSP = '" + tabName + "'";
                tblSP = Functions.GetDataToTable(sql);

                dtgvLoaiSP.DataSource = tblSP;
                dtgvLoaiSP.Columns[0].HeaderText = "Tên đồ uống";
                dtgvLoaiSP.Columns[1].HeaderText = "Loại sản phẩm";
                dtgvLoaiSP.Columns[2].HeaderText = "Giá Tiền";
                dtgvLoaiSP.Columns[0].Width = 300;
                dtgvLoaiSP.Columns[1].Width = 250;
                dtgvLoaiSP.Columns[2].Width = 100;
            }
        }

        private void fListProducts_Load(object sender, EventArgs e)
        {
            LoadTabControl();
            LoadDTGV();
            MaCongThuc = (string)dtgvLoaiSP.CurrentRow.Cells[3].Value;
            MaFixCongThuc = (string)dtgvLoaiSP.CurrentRow.Cells[3].Value;
            LoadCongThuc(MaCongThuc);
        }




        private void TabSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexTabControlSP = TabSP.SelectedIndex;
            Settings.Default.indexTabControlSP = indexTabControlSP;
            Settings.Default.Save();
            LoadDTGV();
        }

        private void btnDMSP_Click(object sender, EventArgs e)
        {
            Category.fProducts dmsp = new Category.fProducts();
            dmsp.ShowDialog();
            LoadTabControl();
            LoadDTGV();
        }


        private void thêmSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fProducts pd = new fProducts();
            pd.ShowDialog();
            LoadTabControl();
            LoadDTGV();
        }

        private void LoadCongThuc(string MaCongThuc)
        {
            string sql = "SELECT b.TenNL, a.SoLuongNL FROM CongThuc a JOIN NL b ON a.MaNL = b.MaNL WHERE a.MaSP = N'" + MaCongThuc + "'";
            tblLoadCT = Functions.GetDataToTable(sql);
            dtgvCongThuc.DataSource = tblLoadCT;
            dtgvCongThuc.Columns[0].HeaderText = "Nguyên liệu";
            dtgvCongThuc.Columns[1].HeaderText = "Số lượng";
            dtgvCongThuc.Columns[0].Width = 300;
            dtgvCongThuc.Columns[1].Width = 150;
            string sql2 = "SELECT MoTa FROM SP WHERE MaSP = N'" + MaCongThuc + "'";
            lsbMoTa.Items.Add(Functions.GetFieldValues(sql2));
        }

        private void dtgvLoaiSP_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MaCongThuc = (string)dtgvLoaiSP.CurrentRow.Cells[3].Value;
            LoadCongThuc(MaCongThuc);
        }

        private void sửaSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fix.fFixProducts fPd = new Fix.fFixProducts(MaFixCongThuc);
            fPd.ShowDialog();
            LoadTabControl();
            LoadDTGV();
        }

        private void dtgvLoaiSP_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                MaFixCongThuc = (string)dtgvLoaiSP.CurrentRow.Cells[3].Value;
                MaSPXoa = (string)dtgvLoaiSP.CurrentRow.Cells[3].Value;
            }
            catch { }
        }

        private void xóaSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sql = "SELECT TenSP FROM SP WHERE MaSP = N'" + MaSPXoa + "'";
            string name = Functions.GetFieldValues(sql);
            if (MessageBox.Show("Xác nhận xóa sản phẩm: " + name +"!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string sqldeleteCT = "DELETE FROM CongThuc WHERE MaSP = N'" + MaSPXoa + "'";
                Functions.RunSqlDel(sqldeleteCT);
                string sqldeleteSP = "DELETE FROM SP WHERE MaSP = N'" + MaSPXoa + "'";
                Functions.RunSqlDel(sqldeleteSP);
                LoadDTGV();
                MessageBox.Show("Xóa sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                return;
            }
        }
    }
}
