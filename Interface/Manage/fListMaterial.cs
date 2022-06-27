using Interface.Properties;
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
    public partial class fListMaterial : Form
    {
        DataTable tblOrder;
        DataTable loadDMNL;

        public fListMaterial()
        {
            InitializeComponent();
        }
        #region Properties
        int indexTabControlNL;
        string MaNL;
        string tabName;
        #endregion


        private void fListMaterial_Load(object sender, EventArgs e)
        {
            LoadTabControl();
            LoadDTGV();
        }
        private void LoadTabControl()
        {
            //TabPage tabPage = new TabPage();
            //TabOrder.Controls.Add(tabPage);

            string sql = "SELECT * FROM DMNL";
            loadDMNL = Functions.GetDataToTable(sql);
            foreach (DataRow item in loadDMNL.Rows)
            {
                string _tenDMSP = item["TenDMNL"].ToString();
                TabPage tabPage = new TabPage(_tenDMSP);
                TabNL.Controls.Add(tabPage);

            }

        }
        private void LoadDTGV()
        {
            string sql;
            if (TabNL.TabPages == null)
            {
                return;
            }
            else
            {
                indexTabControlNL = Settings.Default.indexTabControlNL;
                tabName = TabNL.TabPages[indexTabControlNL].Text.ToString();
                TabNL.SelectedIndex = indexTabControlNL;
                sql = "SELECT a.TenNL, b.TenDMNL, a.SoLuong, a.MaNL FROM NL a JOIN DMNL b ON a.MaDMNL = b.MaDMNL WHERE b.TenDMNL = N'" + tabName + "'";
                tblOrder = Functions.GetDataToTable(sql);

                dtgvNL.DataSource = tblOrder;
                dtgvNL.Columns[0].HeaderText = "Tên Nguyên Liệu";
                dtgvNL.Columns[1].HeaderText = "Loại Nguyên Liệu";
                dtgvNL.Columns[2].HeaderText = "Số Lượng";
                dtgvNL.Columns[0].Width = 250;
                dtgvNL.Columns[1].Width = 250;
                dtgvNL.Columns[2].Width = 150;
            }
        }
        private void TabNL_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexTabControlNL = TabNL.SelectedIndex;
            Settings.Default.indexTabControlNL = indexTabControlNL;
            Settings.Default.Save();
            LoadDTGV();
        }

        private void btnDMNL_Click(object sender, EventArgs e)
        {
            Category.fMaterial mt = new Category.fMaterial();
            mt.ShowDialog();
        }

        private void thêmSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fMaterial mt = new fMaterial();
            mt.ShowDialog();
            LoadDTGV();
        }

        private void LoadMoTa(string MaNL)
        {
            string sql2 = "SELECT MoTa FROM NL WHERE NL = N'" + MaNL + "'";
            lsbMoTa.Items.Add(Functions.GetFieldValues(sql2));
        }

        private void dtgvNL_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                MaNL = dtgvNL.CurrentRow.Cells[3].Value.ToString();
                LoadMoTa(MaNL);
            }
            catch { }
        }

        private void sửaSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fix.fFixMaterial mt = new Fix.fFixMaterial(MaNL);
            mt.ShowDialog();
            LoadDTGV();
        }

        private void xóaSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT TenNL FROM NL WHERE MaNL = N'" + MaNL + "'";
                string name = Functions.GetFieldValues(sql);
                if (MessageBox.Show("Xác nhận xóa sản phẩm: " + name + "!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    string sqldeleteNL = "DELETE FROM NL WHERE MaNL = N'" + MaNL + "'";
                    Functions.RunSqlDel(sqldeleteNL);
                    LoadDTGV();
                    MessageBox.Show("Xóa nguyên liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    return;
                }
            }
            catch { }
        }
    }
}
