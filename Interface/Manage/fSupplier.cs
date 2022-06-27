using Interface.Storage;
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
    public partial class fSupplier : Form
    {
        List<ncc> nccList = new();
        DataTable tblNCC;
        public fSupplier()
        {
            InitializeComponent();
        }
        string maNCC;
        private void fSupplier_Load(object sender, EventArgs e)
        {
            LoadNCC();
        }

        private void LoadNCC()
        {
            string sql = "SELECT TenNCC, DiaChi, SDT FROM NCC";
            tblNCC = Functions.GetDataToTable(sql);
            dtgvNCC.DataSource = tblNCC;
            dtgvNCC.Columns[0].HeaderText = "Nhà cung cấp";
            dtgvNCC.Columns[0].Width = 200;
            dtgvNCC.Columns[1].HeaderText = "Địa chỉ";
            dtgvNCC.Columns[1].Width = 350;
            dtgvNCC.Columns[2].HeaderText = "Số điện thoại";
            dtgvNCC.Columns[2].Width = 200;
        }
        private void clearTextBox()
        {
            name.Text = "";
            address.Text = "";
            phoneNumber.Text = "";
        }
        private void Refresh(object sender, EventArgs e)
        {
            this.Controls.Clear();
            InitializeComponent();
        }
        private void siiButton1_Click(object sender, EventArgs e)
        {

            string insert = "INSERT INTO NCC(TenNCC,DiaChi,SDT) VALUES ('"+ name.Text +"','"+address.Text+"','"+phoneNumber.Text+"')";
            Functions.RunSql(insert);
            clearTextBox();
            MessageBox.Show("Thanh Cong", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            fSupplier fSupplier = new fSupplier();
            Refresh();

        }

        private void dtgvNCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            name.Text = dtgvNCC.CurrentRow.Cells[0].Value.ToString();
            address.Text = dtgvNCC.CurrentRow.Cells[1].Value.ToString();
            phoneNumber.Text = dtgvNCC.CurrentRow.Cells[2].Value.ToString();
        }

        private void siiButton2_Click(object sender, EventArgs e)
        {
           
        }

        private void siiButton3_Click(object sender, EventArgs e)
        {
            string delete = "DELETE FROM NCC WHERE TenNCC ='" +name.Text + "' ";
            Functions.RunSql(delete);
            clearTextBox();
            MessageBox.Show("Thanh Cong", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);  
        }

        private void dtgvNCC_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            maNCC = dtgvNCC.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
