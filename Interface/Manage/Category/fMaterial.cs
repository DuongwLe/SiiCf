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
    public partial class fMaterial : Form
    {
        DataTable tblDMNL;
        public fMaterial()
        {
            InitializeComponent();
        }

        private void fMaterial_Load(object sender, EventArgs e)
        {
            loadDMNL();
            dtgvDMNL.ClearSelection();
            dtgvDMNL.CurrentCell = null;
        }
        private void loadDMNL()
        {
            string sql2 = "SELECT TenDMNL, MoTa, MaDMNL FROM DMNL";
            tblDMNL = Functions.GetDataToTable(sql2);
            dtgvDMNL.DataSource = tblDMNL;
            dtgvDMNL.Columns[0].HeaderText = "Danh mục nguyên liệu";
            dtgvDMNL.Columns[0].Width = 300;
            dtgvDMNL.Columns[1].HeaderText = "Mô tả";
            dtgvDMNL.Columns[1].Width = 400;
            dtgvDMNL.ClearSelection();
            dtgvDMNL.CurrentCell = null;
        }

        private void siiButton1_Click(object sender, EventArgs e)
        {
            if (dtgvDMNL.Enabled == true)
            {
                txtMoTa.Text = "";
                txtDMNL.Text = "";
                txtDMNL.Focus();
                MessageBox.Show("Mời bạn tạo mới danh mục nguyên liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtDMNL.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên danh mục nguyên liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (MessageBox.Show("Xác nhận thêm mới danh mục nguyên liệu!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    string sql = "INSERT INTO DMNL(TenDMNL,MoTa) VALUES(N'" + txtDMNL.Text + "',N'" + txtMoTa.Text + "')";
                    Functions.RunSqlDel(sql);
                    loadDMNL();
                }
            }
        }

        private void dtgvDMNL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDMNL.Text = dtgvDMNL.CurrentRow.Cells["TenDMNL"].Value.ToString();
            txtMoTa.Text = dtgvDMNL.CurrentRow.Cells["MoTa"].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dtgvDMNL.Enabled == false)
            {
                dtgvDMNL.Enabled = true;
                MessageBox.Show("Mời bạn chọn danh mục sản phẩm cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtDMNL.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên danh mục sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (MessageBox.Show("Xác nhận sửa danh mục " + dtgvDMNL.CurrentRow.Cells["TenDMNL"].Value.ToString() + "!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    string sql = "UPDATE DMNL SET TenDMNL=N'" + txtDMNL.Text.ToString() + "', MoTa = N'" + txtMoTa.Text + "' WHERE MaDMNL=N'" + dtgvDMNL.CurrentRow.Cells["MaDMNL"].Value.ToString() + "'";
                    Functions.RunSqlDel(sql);
                    loadDMNL();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dtgvDMNL.Enabled == false)
            {
                dtgvDMNL.Enabled = true;
                MessageBox.Show("Mời bạn chọn danh mục nguyên liệu cần Xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (MessageBox.Show("Xác nhận xóa nguyên liệu " + dtgvDMNL.CurrentRow.Cells["TenDMNL"].Value.ToString() + "!" + "\nViệc này sẽ xóa theo những sản phẩm có trong danh mục!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string sql = "DELETE FROM NL WHERE MaDMNL = N'" + dtgvDMNL.CurrentRow.Cells["MaDMNL"].Value.ToString() + "'";
                Functions.RunSqlDel(sql);
                string sql2 = "DELETE FROM DMNL WHERE MaDMNL = N'" + dtgvDMNL.CurrentRow.Cells["MaDMNL"].Value.ToString() + "'";
                Functions.RunSqlDel(sql2);
                loadDMNL();
            }
        }
    }
}
