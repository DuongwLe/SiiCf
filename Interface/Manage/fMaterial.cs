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
    public partial class fMaterial : Form
    {
        public fMaterial()
        {
            InitializeComponent();
        }

        private void fMaterial_Load(object sender, EventArgs e)
        {
            Functions.FillComboSii("SELECT MaDMNL,TenDMNL FROM DMNL", cboDMNL, "MaDMNL", "TenDMNL");
            cboDMNL.SelectedIndex = 0;
        }

        private void AddNL()
        {
            string MaDMNL = (string)cboDMNL.SelectedValue;
            if(txtTenNL.Text == "")
            {
                MessageBox.Show("Xin mời bạn nhập tên nguyên liệu!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return;
            }
            else
            {
                string sql = "INSERT INTO NL(MaDMNL, TenNL, SoLuong, MoTa) VALUES ('" + MaDMNL + "','" + txtTenNL.Text + "', " + Convert.ToInt32(soLuongNL.Value) + ", '" + txtMoTa.Text + "')";
                Functions.RunSqlDel(sql);
            }
        }

        private void siiButton1_Click(object sender, EventArgs e)
        {
            AddNL();
            this.Close();
        }

        private void siiButton2_Click(object sender, EventArgs e)
        {
            txtTenNL.Text = "";
            txtMoTa.Text = "";
        }
    }
}
