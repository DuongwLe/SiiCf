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
    public partial class fEnter : Form
    {
        List<AddMaterial> EnterList = new();
        DataTable MaterialList;
        DataTable loadDMNL;
        DataTable Data;
        public readonly string MaHDNK;
        public fEnter(string _MaHDNK)
        {
            MaHDNK = _MaHDNK;
            InitializeComponent();
        }

        private void Load_MaterialList()
        {
            string loadMateriall;
            loadMateriall = " SELECT * FROM NCC";
            MaterialList = Functions.GetDataToTable(loadMateriall);
            //MaterialList.Columns.Add("Item", typeof(string), "MaNL + ' - ' + TenNL");
            comboBox1.ValueMember = "MaNCC";
            comboBox1.DisplayMember = "TenNCC";
            comboBox1.DataSource = MaterialList;
            label9.Text = DateTime.Now.ToString();

        }
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
            sql = "SELECT a.TenNL, a.MaNL FROM NL a JOIN DMNL b ON a.MaDMNL = b.MaDMNL WHERE b.TenDMNL = '" + tabName + "'";
            MaterialList = Functions.GetDataToTable(sql);
            dataGridView2.DataSource = MaterialList;
            dataGridView2.Columns[0].HeaderText = "Tên Nguyên Liệu";
            dataGridView2.Columns[1].HeaderText = "Mã Nguyên Liệu";
            dataGridView2.Columns[0].Width = 150;
            dataGridView2.Columns[1].Width = 130;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Storehouse.Nhap.Listing aa = new Nhap.Listing();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        float Amount(float price)
        {
            return Convert.ToInt16(materialId.Text) * price;
        }

        float TotalAmount()
        {
            float total = 0;
            foreach (var i in EnterList)
            {
                total = i.Amount + total;          
            }
            return total;
        }
        void clearTextBox()
        {
            materialId.Text = "";
            materialName.Text = "";
            price.Text = "";
            quanlity.Text = "";
            label6.Text = "";
        }
        private void Load_Data(string _MaHDNK)
        {
            string getData = "SELECT * FROM ChiTietHDNK WHERE MaHDNK = '" + _MaHDNK + "'";
            Data = Functions.GetDataToTable(getData);
            int index = 0;
            foreach(DataRow item in Data.Rows)
            {
                EnterList.Add(new AddMaterial(item["MaNL"].ToString(),
                    item["MaNL"].ToString(),
                    item["MaNCC"].ToString(),
                    Convert.ToInt64(item["SoLuong"]),
                    Convert.ToInt64(item["DonGia"]),
                    Convert.ToInt64(item["ThanhTien"])));
            }
            foreach (var item in EnterList)
            {
                index++;
                dataGridView1.Rows.Add(index, item.MaterialName, item.MaterialId, item.Quanlity, item.Price, item.Amount);
            }
            label11.Text = TotalAmount().ToString();
            btn_Confirm.Enabled = false;
            btn_Add.Enabled = false; 
        }

        private void fEnter_Load(object sender, EventArgs e)
        {
            Load_MaterialList();
            LoadTabControl(); LoadDTGV();
            if(MaHDNK != "")
            {
                Load_Data(MaHDNK);
            }
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            string insert;
            insert = "INSERT INTO HDNK(NgayNK,TongTien,MaNV,GhiChu) VALUES ('"+ DateTime.Now +"','"+ label11.Text +"','NV0000001','')";
            Functions.RunSql(insert);
            string getIDquery = "SELECT TOP 1 MaHDNK FROM HDNK ORDER BY MaHDNK DESC";
            string MaHDNK = Functions.GetFieldValues(getIDquery);
            foreach (var item in EnterList)
            {
                string insertDetails;
                insertDetails = "INSERT INTO ChiTietHDNK(MaHDNK,MaNL,MaNCC,SoLuong,DonGia,ThanhTien) " +
                "VALUES ('" + MaHDNK + "','"+item.MaterialId+"','"+item.NhaCungCap+"','"+ item.Quanlity +"','"+item.Price+"','"+ item.Amount+"')";
                Functions.RunSql(insertDetails);
            }
            MessageBox.Show("Thanh Cong", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            this.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexTabControl = tabControl1.SelectedIndex;
            LoadDTGV(indexTabControl);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            materialName.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            materialId.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
        }

        private void quanlity__TextChanged(object sender, EventArgs e)
        {
            if(price.Text != "" && quanlity.Text != "")
            {
                label6.Text = (Convert.ToInt64(price.Text) * Convert.ToInt64(quanlity.Text)).ToString();
            }
        }

        private void price__TextChanged(object sender, EventArgs e)
        {
            if (quanlity.Text != "" && price.Text != "")
            {
                label6.Text = (Convert.ToInt64(price.Text) * Convert.ToInt64(quanlity.Text)).ToString();
            }
            if (price.Text != "")
            {
                label6.Text = (Convert.ToInt64(price.Text) * Convert.ToInt64(quanlity.Text)).ToString();
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            EnterList.Add(new AddMaterial(materialName.Text, materialId.Text, comboBox1.SelectedValue.ToString(), Convert.ToInt64(quanlity.Text), Convert.ToInt64(price.Text), Convert.ToInt64(label6.Text))); ;
            dataGridView1.Rows.Clear();
            int index = 0;
            foreach (var item in EnterList)
            {
                index++;
                dataGridView1.Rows.Add(index, item.MaterialName, item.NhaCungCap, item.MaterialId, item.Quanlity, item.Price, item.Amount);
            }
            label11.Text = TotalAmount().ToString();
            clearTextBox();
        }
    }
}
