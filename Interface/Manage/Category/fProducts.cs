using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface.Manage.Category
{
    public partial class fProducts : Form
    {
        DataTable tblDMSP;
        public fProducts()
        {
            InitializeComponent();
        }

        private void fProducts_Load(object sender, EventArgs e)
        {
            loadDMSP(); 
            dtgvLoaiSP.ClearSelection();
            dtgvLoaiSP.CurrentCell = null;
        }
        private void loadDMSP()
        {
            string sql2 = "SELECT TenDMSP, MoTa, MaDMSP FROM DMSP";
            tblDMSP = Functions.GetDataToTable(sql2);
            dtgvLoaiSP.DataSource = tblDMSP;
            dtgvLoaiSP.Columns[0].HeaderText = "Danh mục sản phẩm";
            dtgvLoaiSP.Columns[0].Width = 300;
            dtgvLoaiSP.Columns[1].HeaderText = "Mô tả";
            dtgvLoaiSP.Columns[1].Width = 400;
            dtgvLoaiSP.ClearSelection();
            dtgvLoaiSP.CurrentCell = null;
        }

        private void siiButton1_Click(object sender, EventArgs e)
        {
            if(dtgvLoaiSP.Enabled == true)
            {
                txtMoTa.Text = "";
                txtTenDMSP.Text = "";
                txtTenDMSP.Focus();
                MessageBox.Show("Mời bạn tạo mới danh mục sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtTenDMSP.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên danh mục sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (MessageBox.Show("Xác nhận thêm mới danh mục sản phẩm!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    string sql = "INSERT INTO DMSP(TenDMSP,MoTa) VALUES(N'" + txtTenDMSP.Text + "',N'" + txtMoTa.Text + "')";
                    Functions.RunSqlDel(sql);
                    loadDMSP();
                }
            }
        }

        private void dtgvLoaiSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenDMSP.Text = dtgvLoaiSP.CurrentRow.Cells["TenDMSP"].Value.ToString();
            txtMoTa.Text = dtgvLoaiSP.CurrentRow.Cells["MoTa"].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dtgvLoaiSP.Enabled == false)
            {
                dtgvLoaiSP.Enabled = true;
                MessageBox.Show("Mời bạn chọn danh mục sản phẩm cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtTenDMSP.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên danh mục sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (MessageBox.Show("Xác nhận sửa danh mục " + dtgvLoaiSP.CurrentRow.Cells["TenDMSP"].Value.ToString() + "!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)                   
                {
                    string sql = "UPDATE DMSP SET TenDMSP=N'" + txtTenDMSP.Text.ToString() + "', MoTa = N'" + txtMoTa.Text + "' WHERE MaDMSP=N'" + dtgvLoaiSP.CurrentRow.Cells["MaDMSP"].Value.ToString() + "'";
                    Functions.RunSqlDel(sql);
                    loadDMSP();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dtgvLoaiSP.Enabled == false)
            {
                dtgvLoaiSP.Enabled = true;
                MessageBox.Show("Mời bạn chọn danh mục sản phẩm cần Xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (MessageBox.Show("Xác nhận xóa danh mục " + dtgvLoaiSP.CurrentRow.Cells["TenDMSP"].Value.ToString() + "!" + "\nViệc này sẽ xóa theo những sản phẩm có trong danh mục!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string sql = "DELETE FROM SP WHERE MaDMSP = N'" + dtgvLoaiSP.CurrentRow.Cells["MaDMSP"].Value.ToString() + "'";
                Functions.RunSqlDel(sql);
                string sql2 = "DELETE FROM DMSP WHERE MaDMSP = N'" + dtgvLoaiSP.CurrentRow.Cells["MaDMSP"].Value.ToString() + "'";
                Functions.RunSqlDel(sql2);
                loadDMSP();
            }
        }
    }
}
