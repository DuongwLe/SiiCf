using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface.SellSystem.Fix
{   
    public partial class fFixShiftDetails : Form
    {
        private readonly string MaHDBH;
        DataTable tblDMSP;
        DataTable tblSP;
        DataTable tblSPthem;
        public fFixShiftDetails(string _maHDBH)
        {
            InitializeComponent();
            MaHDBH = _maHDBH;
        }

        string value;

        private void LoadDMNL()
        {
            string sql1 = "SELECT TenDMSP FROM DMSP";
            tblDMSP = Functions.GetDataToTable(sql1);
            dtgvDMNL.DataSource = tblDMSP;
            if (dtgvDMNL.DataSource != null)
            {
                dtgvDMNL.Columns[0].HeaderText = "DMNL";
                dtgvDMNL.Columns[0].Width = 400;
            }
        }

        private void LoadNL(string value)
        {
            if ((dtgvNL.DataSource == null && (dtgvDMNL.DataSource != null)))
            {
                value = dtgvDMNL.Rows[0].Cells[0].Value.ToString();
                string sql2 = "SELECT a.TenSP, a.MaSP  FROM SP a JOIN DMSP b ON a.MaDMSP = b.MaDMSP WHERE b.TenDMSP = N'" + value + "'";
                tblSP = Functions.GetDataToTable(sql2);
                dtgvNL.DataSource = tblSP;
                dtgvNL.Columns[0].HeaderText = "Sản phẩm";
                dtgvNL.Columns[0].Width = 400;

            }
            else if ((dtgvNL.DataSource != null && (dtgvDMNL.DataSource != null)))
            {
                string sql2 = "SELECT a.TenSP, a.MaSP  FROM SP a JOIN DMSP b ON a.MaDMSP = b.MaDMSP WHERE b.TenDMSP = N'" + value + "'";
                tblSP = Functions.GetDataToTable(sql2);
                dtgvNL.DataSource = tblSP;
                dtgvNL.Columns[0].HeaderText = "Sản phẩm";
                dtgvNL.Columns[0].Width = 400;
            }
        }

        private void LoadOldData()
        {
            cboNhanVien.SelectedItem = Functions.GetFieldValues("SELECT MaNV FROM HDBH WHERE MaHDBH = N'" + MaHDBH + "'");
            cboPTTT.SelectedItem = Functions.GetFieldValues("SELECT MaPTTT FROM HDBH WHERE MaHDBH = N'" + MaHDBH + "'");
            cboMGG.SelectedItem = Functions.GetFieldValues("SELECT MaGG FROM HDBH WHERE MaHDBH = N'" + MaHDBH + "'");

            string sql = "SELECT b.TenSP, a.SoLuong, a.MaSP FROM ChiTietHDBH a JOIN SP b ON a.MaSP = b.MaSP WHERE a.MaHDBH = N'" + MaHDBH + "'";
            tblSPthem = Functions.GetDataToTable(sql);
            foreach (DataRow item in tblSPthem.Rows)
            {
                string _tenNL = item["TenSP"].ToString();
                string _soLuongNL = item["SoLuong"].ToString();
                string _maNL = item["MaSP"].ToString();
                dtgvCongThuc.Rows.Add(_tenNL, _soLuongNL, _maNL);
            }
        }

        private void fFixShiftDetails_Load(object sender, EventArgs e)
        {
            Functions.FillComboSii("SELECT MaNV,TenNV FROM NhanVien", cboNhanVien, "MaNV", "TenNV");
            cboNhanVien.SelectedIndex = 0; 
            Functions.FillComboSii("SELECT MaPTTT,TenPTTT FROM PTTT", cboPTTT, "MaPTTT", "TenPTTT");
            cboPTTT.SelectedIndex = 0; 
            Functions.FillComboSii("SELECT MaGG,TenMGG FROM MGG", cboMGG, "MaGG", "TenMGG");
            cboMGG.SelectedIndex = 0;
            LoadDMNL();
            LoadNL(value);
            LoadOldData();
        }

        private void dtgvDMNL_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                value = dtgvDMNL.CurrentRow.Cells[0].Value.ToString();
                LoadNL(value);
            }
            catch { }          
        }
    }
}
