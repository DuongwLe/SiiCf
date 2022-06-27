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
    public partial class fAccount : Form
    {
        DataTable tblAccount;
        DataTable MaterialList;
        DataTable nhanvien;
        public fAccount()
        {
            InitializeComponent();
        }
        private void LoadAccount()
        {
            string sql = "SELECT TaiKhoan, MatKhau, MaNV, MaVT FROM TaiKhoan";
            tblAccount = Functions.GetDataToTable(sql);
            dtgvAccount.DataSource = tblAccount;
            dtgvAccount.Columns[0].HeaderText = "Tên đăng nhập";
            dtgvAccount.Columns[0].Width = 250;
            dtgvAccount.Columns[1].HeaderText = "Mật khẩu";
            dtgvAccount.Columns[1].Width = 200;
            dtgvAccount.Columns[2].HeaderText = "Tên nhân viên";
            dtgvAccount.Columns[2].Width = 300;
            dtgvAccount.Columns[3].HeaderText = "Tên vai trò";
            dtgvAccount.Columns[3].Width = 300;
        }
        private void Load_MaterialList()
        {
            string loadMateriall;
            loadMateriall = " SELECT * FROM VaiTro";
            MaterialList = Functions.GetDataToTable(loadMateriall);
            //MaterialList.Columns.Add("Item", typeof(string), "MaNL + ' - ' + TenNL");
            siiComboBox2.ValueMember = "MaVT";
            siiComboBox2.DisplayMember = "TenVT";
            siiComboBox2.DataSource = MaterialList;

        }

        private void Load_NhanVien()
        {
            string loadMateriall;
            loadMateriall = " SELECT * FROM NhanVien";
            nhanvien = Functions.GetDataToTable(loadMateriall);
            //MaterialList.Columns.Add("Item", typeof(string), "MaNL + ' - ' + TenNL");
            siiComboBox1.ValueMember = "MaNV";
            siiComboBox1.DisplayMember = "TenNV";
            siiComboBox1.DataSource = nhanvien;

        }
        private void fAccount_Load(object sender, EventArgs e)
        {
            LoadAccount();
            Load_MaterialList();
            Load_NhanVien();
        }

        private void btnDMNL_Click(object sender, EventArgs e)
        {
            fStaff st = new fStaff();
            st.ShowDialog();
        }
    }
    
     
    }

