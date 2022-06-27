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
    public partial class fProducts : Form
    {
        DataTable tblDMNL;
        DataTable tblNL;
        DataTable tblCongThuc;
        public fProducts()
        {
            InitializeComponent();
        }
        #region Properties
        string value;
        int SoLuong;
        int indexCTXoa;


        #endregion

        private void fProducts_Load(object sender, EventArgs e)
        {
            LoadDMNL();
            LoadNL(value);
            Functions.FillComboSii("SELECT MaDMSP,TenDMSP FROM DMSP", cboDMSP, "MaDMSP", "TenDMSP");
            cboDMSP.SelectedIndex = 0;
        }

        private void LoadDMNL()
        {
            string sql1 = "SELECT TenDMNL FROM DMNL";
            tblDMNL = Functions.GetDataToTable(sql1);
            dtgvDMNL.DataSource = tblDMNL;
            if (dtgvDMNL.DataSource != null)
            {
                dtgvDMNL.Columns[0].HeaderText = "DMNL";
                dtgvDMNL.Columns[0].Width = 400;
            }
        }

        private void LoadNL(string value)
        {
            if((dtgvNL.DataSource == null && (dtgvDMNL.DataSource != null))){
                value = dtgvDMNL.Rows[0].Cells[0].Value.ToString();
                string sql2 = "SELECT a.TenNL, a.MaNL  FROM NL a JOIN DMNL b ON a.MaDMNL = b.MaDMNL WHERE b.TenDMNL = N'" + value + "'";
                tblNL = Functions.GetDataToTable(sql2);
                dtgvNL.DataSource = tblNL;
                dtgvNL.Columns[0].HeaderText = "Nguyên liệu";
                dtgvNL.Columns[0].Width = 400;

            }
            else if ((dtgvNL.DataSource != null && (dtgvDMNL.DataSource != null)))
            {
                string sql2 = "SELECT a.TenNL, a.MaNL FROM NL a JOIN DMNL b ON a.MaDMNL = b.MaDMNL WHERE b.TenDMNL = N'" + value + "'";
                tblNL = Functions.GetDataToTable(sql2);
                dtgvNL.DataSource = tblNL;
                dtgvNL.Columns[0].HeaderText = "Nguyên liệu";
                dtgvNL.Columns[0].Width = 400;
            }
        }

        private void dtgvDMNL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            value = dtgvDMNL.CurrentRow.Cells[0].Value.ToString();
            LoadNL(value);
        }

        private void dtgvNL_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SoLuong = Convert.ToInt32(soLuongNL.Text.ToString());
            string tenNL = dtgvNL.CurrentRow.Cells[0].Value.ToString();
            string maNL = dtgvNL.CurrentRow.Cells[1].Value.ToString();
            bool exist = false;
            if (SoLuong == 0)
            {
                MessageBox.Show("Xin mời bạn nhập số lượng sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (dtgvCongThuc.Rows.Count > 0)
                {
                    for (int i = 0; i < dtgvCongThuc.Rows.Count; i++)
                    {
                        if(dtgvCongThuc.Rows[i].Cells[2].Value != maNL)
                        {
                            if ((i == dtgvCongThuc.Rows.Count - 1) && (exist == false))
                            {
                                dtgvCongThuc.Rows.Add(tenNL, SoLuong, maNL);
                                exist = true;
                            }
                        }
                        else if (dtgvCongThuc.Rows[i].Cells[2].Value == maNL && exist == false)
                        {
                            int soluong = Convert.ToInt32(dtgvCongThuc.Rows[i].Cells[1].Value) + SoLuong;
                            dtgvCongThuc.Rows[i].Cells[1].Value = soluong;
                            exist = true;
                        }


                    }

                }
                else
                {
                    dtgvCongThuc.Rows.Add(tenNL, SoLuong, maNL);
                }
            }
        }

        private void AddNewSP()
        {
            if(txtTenSP.Text == "")
            {
                MessageBox.Show("Xin mời bạn nhập tên sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (cboDMSP.Texts == "")
            {
                MessageBox.Show("Xin mời bạn chọn danh mục sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(txtDonGia.Text == "")
            {
                MessageBox.Show("Xin mời bạn nhập đơn giá sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(dtgvCongThuc.Rows.Count == 0)
            {
                MessageBox.Show("Xin mời bạn chọn nguyên liệu cho công thức!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (MessageBox.Show("Xác nhận thêm mới sản phẩm!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    //Them mới sản phẩm
                    string Mota;
                    string MaDMSP = (string)cboDMSP.SelectedValue;
                    //if (txtMoTa.Text == null)
                    //{
                    //    Mota = "NULL";
                    //}
                    //else { Mota = txtMoTa.Text; }
                    string sql1 = "INSERT INTO SP(MaDMSP, TenSP, DonGia, MoTa) VALUES ('" + MaDMSP + "', N'" + txtTenSP.Text + "'," + Convert.ToInt32(txtDonGia.Text) + ", N'" + txtMoTa.Text + "')";
                    Functions.RunSqlDel(sql1);
                    

                    //Them cong thức
                    string maSP = Functions.GetFieldValues("SELECT TOP 1 MaSP FROM SP ORDER BY MaSP DESC");
                    for (int i = 0; i < dtgvCongThuc.Rows.Count; i++)
                    {
                        string _maNL = dtgvCongThuc.Rows[i].Cells[2].Value.ToString();
                        int _soLuongNL = Convert.ToInt32(dtgvCongThuc.Rows[i].Cells[1].Value.ToString());
                        string sql2 = "INSERT INTO CongThuc(MaSP, MaNL, SoLuongNL) VALUES ('" + maSP + "', '" + _maNL + "'," + _soLuongNL + ")";
                        Functions.RunSqlDel(sql2);
                    }
                    this.Close();
                }
                else
                {
                    return;
                }
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            AddNewSP();
        }

        private void dtgvCongThuc_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                indexCTXoa = dtgvCongThuc.CurrentRow.Index;
            }
            catch { }
        }

        private void dtgvCongThuc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                 dtgvCongThuc.Rows.RemoveAt(indexCTXoa);
            }
            catch { }
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtTenSP.Text = "";
            txtMoTa.Text = "";
            txtDonGia.Text = "";
            dtgvCongThuc.Rows.Clear();
        }

        private void siiButton3_Click(object sender, EventArgs e)
        {
            Category.fProducts ctPds = new Category.fProducts();
            ctPds.ShowDialog();
            Functions.FillComboSii("SELECT MaDMSP,TenDMSP FROM DMSP", cboDMSP, "MaDMSP", "TenDMSP");
            cboDMSP.SelectedIndex = 0;

        }
    }
}
