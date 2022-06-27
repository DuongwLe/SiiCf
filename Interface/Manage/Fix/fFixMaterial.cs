using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface.Manage.Fix
{
    public partial class fFixMaterial : Form
    {
        private readonly string MaNL;
        public fFixMaterial(string _maNL)
        {
            InitializeComponent();
            MaNL = _maNL;
        }

        private void fFixMaterial_Load(object sender, EventArgs e)
        {
            Functions.FillComboSii("SELECT MaDMNL,TenDMNL FROM DMNL", cboDMNL, "MaDMNL", "TenDMNL");
            cboDMNL.SelectedIndex = 0;
            loadOldData();
        }

        private void loadOldData()
        {
            cboDMNL.SelectedItem = MaNL;
            txtTenNL.Text = Functions.GetFieldValues("SELECT TenNL FROM NL WHERE MaNL = N'" + MaNL + "'");
            txtMoTa.Text = Functions.GetFieldValues("SELECT MoTa FROM NL WHERE MaNL = N'" + MaNL + "'");
            soLuongNL.Value = Convert.ToDecimal(Functions.GetFieldValues("SELECT SoLuong FROM NL WHERE MaNL = N'" + MaNL + "'"));
        }

        private void Update()
        {
            string MaDMNL = (string)cboDMNL.SelectedValue;
            if (txtTenNL.Text == "")
            {
                MessageBox.Show("Xin mời bạn nhập tên nguyên liệu!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return;
            }
            else
            {
                string sql = "UPDATE NL SET MaDMNL = '" + MaDMNL + "', TenNL = '" + txtTenNL.Text + "', MoTa = '" + txtMoTa.Text + "' WHERE MaNL = N'" + MaNL+ "'";
                Functions.RunSqlDel(sql);
            }
        }

        private void siiButton1_Click(object sender, EventArgs e)
        {
            Update();
            this.Close();
        }
    }
}
