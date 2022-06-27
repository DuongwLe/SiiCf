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
    public partial class fDiscount : Form
    {
        DataTable tblMGG;
        DataTable discount;
        public fDiscount()
        {
            InitializeComponent();
        }

        private void fDiscount_Load(object sender, EventArgs e)
        {
            LoadPTTT();
        }
        private void LoadPTTT()
        {
            string sql = "SELECT TenMGG, PhanTram, MoTa FROM MGG";
            tblMGG = Functions.GetDataToTable(sql);
            dtgvMGG.DataSource = tblMGG;
            dtgvMGG.Columns[0].HeaderText = "Mã giảm giá";
            dtgvMGG.Columns[0].Width = 250;
            dtgvMGG.Columns[1].HeaderText = "Phần trăm giảm";
            dtgvMGG.Columns[1].Width = 150;
            dtgvMGG.Columns[2].HeaderText = "Mô tả";
            dtgvMGG.Columns[2].Width = 3000;
        }
        private void clearTextBox()
        {
            txtTenMGG.Text = "";
            txtMoTa.Text = "";
            numbPhanTram.Text = "";
        }

        private void dtgvMGG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenMGG.Text = dtgvMGG.CurrentRow.Cells["TenMGG"].Value.ToString();
            txtMoTa.Text = dtgvMGG.CurrentRow.Cells["MoTa"].Value.ToString();
            numbPhanTram.Value = Convert.ToDecimal(dtgvMGG.CurrentRow.Cells["PhanTram"].Value.ToString());
        }

        private void siiButton1_Click(object sender, EventArgs e)
        {
            string insert = "INSERT INTO MGG(TenMGG,PhanTram,MoTa) VALUES ('" + txtTenMGG.Text + "','" + numbPhanTram.Value + "','" + txtMoTa.Text + "')";
            Functions.RunSql(insert);
            clearTextBox();
            MessageBox.Show("Thanh Cong", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void siiButton3_Click(object sender, EventArgs e)
        {
            string delete = "DELETE FROM MGG WHERE TenMGG ='" + txtTenMGG.Text + "' ";
            Functions.RunSql(delete);
            MessageBox.Show("Thanh Cong", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
