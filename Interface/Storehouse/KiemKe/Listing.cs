using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface.Storehouse.KiemKe
{
    public partial class Listing : Form
    {
        public Listing()
        {
            InitializeComponent();
        }
        DataTable loadData;
        private void LoadDTGV(int index = 0)
        {
            string sql;
            sql = "SELECT * FROM KiemKe ";
            loadData = Functions.GetDataToTable(sql);
            dataGridView1.DataSource = loadData;
            dataGridView1.Columns[0].HeaderText = "Mã Phiếu";
            dataGridView1.Columns[0].Width = 250;
            dataGridView1.Columns[1].HeaderText = "Mã Nhân Viên";
            dataGridView1.Columns[1].Width = 350;
            dataGridView1.Columns[2].HeaderText = "Ngày Kiểm Kê";
            dataGridView1.Columns[2].Width = 350;
        }



        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            fInventory fInventory = new fInventory("");
            fInventory.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Listing_Load(object sender, EventArgs e)
        {
            LoadDTGV();

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string MaKK = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            fInventory fKiemKe = new fInventory(MaKK);
            fKiemKe.ShowDialog();
        }
    }
}
