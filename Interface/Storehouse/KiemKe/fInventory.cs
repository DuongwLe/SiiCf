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


namespace Interface.Storehouse
{
    public partial class fInventory : Form
    {
        private readonly string MaKK;

        public fInventory(string _MaKK)
        {
            MaKK = _MaKK;
            InitializeComponent();
        }
        List<Kiemke> _KiemKe = new();
        DataTable MaterialList;
        DataTable loadDMNL;
        DataTable Data;
        private void LoadTabControl()
        {
            //TabPage tabPage = new TabPage();
            //TabOrder.Controls.Add(tabPage);

            string sql = "SELECT * FROM DMNL";
            loadDMNL = Functions.GetDataToTable(sql);
            foreach (DataRow item in loadDMNL.Rows)
            {
                string _maDMNL = item["MaDMNL"].ToString();
                string _tenDMNL = item["TenDMNL"].ToString();
                TabPage tabPage = new TabPage(_tenDMNL);
                tabControl1.Controls.Add(tabPage);
            }
        }
        private void LoadDTGV(int index = 0)
        {
            string sql;
            int indexTabControl = index;
            string tabName = tabControl1.TabPages[indexTabControl].Text.ToString();
            tabControl1.SelectedIndex = indexTabControl;
            sql = "SELECT a.TenNL, a.MaNL,a.SoLuong FROM NL a JOIN DMNL b ON a.MaDMNL = b.MaDMNL WHERE b.TenDMNL = '" + tabName + "'";
            MaterialList = Functions.GetDataToTable(sql);
            dataGridView2.DataSource = MaterialList;
            dataGridView2.Columns[0].HeaderText = "Tên Nguyên Liệu";
            dataGridView2.Columns[1].HeaderText = "Mã Nguyên Liệu";
            dataGridView2.Columns[2].HeaderText = "Số Lượng";
            dataGridView2.Columns[0].Width = 100;
            dataGridView2.Columns[1].Width = 100;
            dataGridView2.Columns[1].Width = 100;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Load_Data(string _MaKK)
        {
            string getData = "SELECT * FROM ChiTietKiemKe WHERE MaKK = '" + _MaKK + "'";
            Data = Functions.GetDataToTable(getData);
        
            foreach (DataRow item in Data.Rows)
            {
                _KiemKe.Add(new Kiemke(item["MaNL"].ToString(),
                    item["MaNL"].ToString(),
                    Convert.ToInt64(item["SoLuongHT"]),
                    Convert.ToInt64(item["SoLuongTT"]),
                    Convert.ToInt64(item["GhiChu"])));
            }
            foreach (var item in _KiemKe)
            {
               
                dataGridView1.Rows.Add( item.MaterialName, item.MaterialId, item.Expect, item.Real, item.Diff);
            }

            btnConfirm.Enabled = false;
            btn_Add.Enabled = false;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexTabControl = tabControl1.SelectedIndex;
            LoadDTGV(indexTabControl);
        }

        private void fInventory_Load(object sender, EventArgs e)
        {
            LoadTabControl();
            LoadDTGV();
            if (MaKK != "")
            {
                Load_Data(MaKK);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            materialName.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            materialId.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            expect.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            _KiemKe.Add(new Kiemke(materialName.Text, materialId.Text, Convert.ToInt64(expect.Text), Convert.ToInt64(real.Text), Convert.ToInt64(diff.Text)));
            dataGridView1.Rows.Clear();
            foreach (var item in _KiemKe)
            {
                dataGridView1.Rows.Add( item.MaterialName, item.MaterialId, item.Expect, item.Real, item.Diff);
            }
        }

        private void real__TextChanged(object sender, EventArgs e)
        {
            if(real.Text != "")
            diff.Text = (Convert.ToInt64(expect.Text) - Convert.ToInt64(real.Text)).ToString();
        }

        private void siiButton2_Click(object sender, EventArgs e)
        {
            string insert;
            insert = "INSERT INTO KiemKe(NgayKK,MaNV) VALUES ('" + DateTime.Now + "','NV0000001')";
            Functions.RunSql(insert);
            string getIDquery = "SELECT TOP 1 MaKK FROM KiemKe ORDER BY MaKK DESC";
            string MaKK = Functions.GetFieldValues(getIDquery);
            foreach (var item in _KiemKe)
            {
                string insertDetails,updateQuanlity;
                insertDetails = "INSERT INTO ChiTietKiemKe(MaKK,MaNL,SoLuongHT,SoLuongTT,GhiChu) " +
                "VALUES ('" + MaKK + "','" + item.MaterialId + "','" + item.Expect + "','" + item.Real + "','" + item.Diff + "')";
                Functions.RunSql(insertDetails);
                updateQuanlity = "UPDATE NL SET SoLuong = '" + item.Real + "' WHERE MaNL = '"+item.MaterialId+"'";
                Functions.RunSql(updateQuanlity);

            }
            MessageBox.Show("Thanh Cong", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            this.Close();
        }
    }
}
