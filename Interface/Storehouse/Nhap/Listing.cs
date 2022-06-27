using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Interface.Storage;

namespace Interface.Storehouse.Nhap
{
    public partial class Listing : Form
    {
        DataTable loadData;
        public Listing()
        {
            InitializeComponent();
        }

        private void LoadDTGV(int index = 0)
        {
            string sql;
            sql = "SELECT * FROM HDNK ";
            loadData = Functions.GetDataToTable(sql);
            dataGridView1.DataSource = loadData;
            dataGridView1.Columns[0].HeaderText = "Mã Phiếu";
            dataGridView1.Columns[0].Width = 180;
            dataGridView1.Columns[1].HeaderText = "Mã Nhân Viên";
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].HeaderText = "Ngày Nhập";
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].HeaderText = "Tổng Tiền";
            dataGridView1.Columns[3].Width = 150;
            dataGridView1.Columns[4].HeaderText = "Ghi Chú";
            dataGridView1.Columns[4].Width = 150;
        }


        private void Listing_Load(object sender, EventArgs e)
        {
            LoadDTGV();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            fEnter fEnter = new fEnter("");
            fEnter.ShowDialog();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string MaHDNK = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            fEnter fEnter = new fEnter(MaHDNK);
            fEnter.ShowDialog();

        }
    }
}
