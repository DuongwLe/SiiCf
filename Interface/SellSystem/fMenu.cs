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
    public partial class fMenu : Form
    {
        DataTable tblLoaiDoUong;
        DataTable tblDSDoUong;
        public fMenu()
        {
            InitializeComponent();
        }

        #region Propreties
        string indexMaLoaiSP;

        public object Setting { get; private set; }
        #endregion

        private void fMenu_Load(object sender, EventArgs e)
        {
            Load_LoaiDoUong();
            Save_indexMaLoaiSP();
            Load_DSDoUong();
        }

        private void Load_LoaiDoUong()
        {
            string sql1;
            sql1 = "SELECT TenLoaiSP, MaLoaiSP FROM LoaiSP";
            tblLoaiDoUong = Functions.GetDataToTable(sql1);
            dtgvLoaiDoUong.DataSource = tblLoaiDoUong;
            dtgvLoaiDoUong.Columns[0].HeaderText = "Tên loại đồ uống";
            dtgvLoaiDoUong.Columns[0].Width = 290;
        }

        private void Load_DSDoUong()
        {
            string sql2;
            sql2 = "SELECT a.TenSP,a.GiaTien,a.HinhAnh FROM SanPham a JOIN LoaiSP b ON a.MaLoaiSP = b.MaLoaiSP WHERE a.MaLoaiSP = '"+ indexMaLoaiSP +"'";
            tblDSDoUong = Functions.GetDataToTable(sql2);
            dtgvDSDoUong.DataSource = tblDSDoUong;
            dtgvDSDoUong.Columns[0].HeaderText = "Tên đồ uống";
            dtgvDSDoUong.Columns[0].Width = 350;
            dtgvDSDoUong.Columns[1].HeaderText = "Giá tiền";
            dtgvDSDoUong.Columns[1].Width = 170;
            dtgvDSDoUong.Columns[2].HeaderText = "Hình ảnh";
            dtgvDSDoUong.Columns[2].Width = 270;
        }
        private void Save_indexMaLoaiSP()
        {
            indexMaLoaiSP = dtgvLoaiDoUong.CurrentRow.Cells[1].Value.ToString();
            Settings.Default.indexMaLoaiSP = indexMaLoaiSP;
            Settings.Default.Save();
        }

        private void dtgvLoaiDoUong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Save_indexMaLoaiSP();
            Load_DSDoUong();
        }
    }
}
