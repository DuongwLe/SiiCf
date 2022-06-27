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
    public partial class fPaymentMethods : Form
    {
        DataTable tblPTTT;
        public fPaymentMethods()
        {
            InitializeComponent();
        }

        private void fPaymentMethods_Load(object sender, EventArgs e)
        {
            LoadPTTT();
        }
        private void LoadPTTT()
        {
            string sql = "SELECT TenPTTT, MoTa FROM PTTT";
            tblPTTT = Functions.GetDataToTable(sql);
            dtgvPTTT.DataSource = tblPTTT;
            dtgvPTTT.Columns[0].HeaderText = "Phương thức thanh toán";
            dtgvPTTT.Columns[0].Width = 250;
            dtgvPTTT.Columns[1].HeaderText = "Mô tả";
            dtgvPTTT.Columns[1].Width = 5000;
        }

        private void dtgvPTTT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPTTT.Text = dtgvPTTT.CurrentRow.Cells["TenPTTT"].Value.ToString();
            txtMoTa.Text = dtgvPTTT.CurrentRow.Cells["MoTa"].Value.ToString();
        }

        private void txtPTTT__TextChanged(object sender, EventArgs e)
        {

        }
        private void clearTextBox()
        {
            txtPTTT.Text = "";
            txtMoTa.Text = "";
        }

        private void siiButton1_Click(object sender, EventArgs e)
        {
            string insert = "INSERT INTO PTTT(TenPTTT,MoTa) VALUES ('" + txtPTTT.Text + "','" + txtMoTa.Text + "')";
            Functions.RunSql(insert);
            clearTextBox();
            MessageBox.Show("Thanh Cong", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void siiButton3_Click(object sender, EventArgs e)
        {
            string delete = "DELETE FROM PTTT WHERE TenPTTT ='" + txtPTTT.Text + "' ";
            Functions.RunSql(delete);
            MessageBox.Show("Thanh Cong", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
