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
    public partial class fStaff : Form
    {
        DataTable tblNV;
        public fStaff()
        {
            InitializeComponent();
        }

        private void fStaff_Load(object sender, EventArgs e)
        {
            loadDMNV();
        }
        private void loadDMNV()
        {
            try
            {
                string sql2 = "SELECT TenNV, GioiTinh, NgaySinh, SDT FROM NhanVien";
                tblNV = Functions.GetDataToTable(sql2);
                dtgvStaff.DataSource = tblNV;
                dtgvStaff.Columns[0].HeaderText = "Tên nhân viên";
                dtgvStaff.Columns[0].Width = 250;
                dtgvStaff.Columns[1].HeaderText = "Giới tính";
                dtgvStaff.Columns[1].Width = 150;
                dtgvStaff.Columns[2].HeaderText = "Ngày sinh";
                dtgvStaff.Columns[2].Width = 150;
                dtgvStaff.Columns[3].HeaderText = "Số điện thoại";
                dtgvStaff.Columns[3].Width = 200;
            }
            catch
            {

            }
        }
        private void clearTextBox()
        {
            name.Text = "";
            birthday.Text = "";
            phoneNumber.Text = "";
        }
        private void siiTextBox2__TextChanged(object sender, EventArgs e)
        {

        }

        private void siiButton1_Click(object sender, EventArgs e)
        {
            if (male.Checked == true)
            {
                string insert = "INSERT INTO NhanVien(TenNV,NgaySinh,GioiTinh,SDT) VALUES ('" + name.Text + "','" + birthday.Text + "','Nam','" + phoneNumber.Text + "')";
                Functions.RunSql(insert);
                clearTextBox();
                MessageBox.Show("Thanh Cong", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            if (female.Checked == true)
            {
                string insert = "INSERT INTO NhanVien(TenNV,NgaySinh,GioiTinh,SDT) VALUES ('" + name.Text + "','" + birthday.Text + "','Nu','" + phoneNumber.Text + "')";
                Functions.RunSql(insert);
                clearTextBox();
                MessageBox.Show("Thanh Cong", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void dtgvStaff_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            name.Text = dtgvStaff.CurrentRow.Cells[0].Value.ToString();
            birthday.Text = dtgvStaff.CurrentRow.Cells[2].Value.ToString();
            phoneNumber.Text = dtgvStaff.CurrentRow.Cells[3].Value.ToString();
        }

        private void siiButton3_Click(object sender, EventArgs e)
        {
            string delete = "DELETE FROM NhanVien WHERE TenNV ='" + name.Text + "' ";
            Functions.RunSql(delete);
            clearTextBox();
            MessageBox.Show("Xóa Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void siiButton2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
