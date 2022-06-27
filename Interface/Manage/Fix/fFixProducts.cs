using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface.Manage.Fix
{
    public partial class fFixProducts : Form
    {
        DataTable tblCongThuc;
        DataTable tblDMNL;
        DataTable tblNL;
        private readonly string MaCongThuc;

        public fFixProducts(string maFixCongThuc)
        {
            InitializeComponent();
            MaCongThuc = maFixCongThuc;
        }

        #region Properties
        string value;
        int SoLuong;
        int indexCTXoa;


        #endregion

        private void fFixProducts_Load(object sender, EventArgs e)
        {
            Functions.FillComboSii("SELECT MaDMSP,TenDMSP FROM DMSP", cboDMSP, "MaDMSP", "TenDMSP");
            cboDMSP.SelectedIndex = 0;
            LoadOldData();
            LoadDMNL();
            LoadNL(value);
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
            if ((dtgvNL.DataSource == null && (dtgvDMNL.DataSource != null)))
            {
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
        private void dtgvDMNL_SelectionChanged(object sender, EventArgs e)
        {
            value = dtgvDMNL.CurrentRow.Cells[0].Value.ToString();
            LoadNL(value);
        }

        private void LoadOldData()
        {
            cboDMSP.SelectedItem = MaCongThuc;
            txtTenSP.Text = Functions.GetFieldValues("SELECT TenSP FROM SP WHERE MaSP = N'" + MaCongThuc + "'");
            txtDonGia.Text = Functions.GetFieldValues("SELECT DonGia FROM SP WHERE MaSP = N'" + MaCongThuc + "'");
            txtMoTa.Text = Functions.GetFieldValues("SELECT MoTa FROM SP WHERE MaSP = N'" + MaCongThuc + "'");

            string sql = "SELECT b.TenNL, a.SoLuongNL, a.MaNL FROM CongThuc a JOIN NL b ON a.MaNL = b.MaNL WHERE a.MaSP = N'" + MaCongThuc + "'";
            tblCongThuc = Functions.GetDataToTable(sql);
            foreach (DataRow item in tblCongThuc.Rows)
            {
                string _tenNL = item["TenNL"].ToString();
                string _soLuongNL = item["SoLuongNL"].ToString();
                string _maNL = item["MaNL"].ToString();
                dtgvCongThuc.Rows.Add(_tenNL, _soLuongNL, _maNL);
            }
        }

        private void dtgvCongThuc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dtgvCongThuc.Rows.RemoveAt(indexCTXoa);
            }
            catch { }
        }

        private void dtgvCongThuc_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                indexCTXoa = dtgvCongThuc.CurrentRow.Index;
            }
            catch { }
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
                        if (dtgvCongThuc.Rows[i].Cells[2].Value.ToString() != maNL)
                        {
                            if ((i == dtgvCongThuc.Rows.Count - 1) && (exist == false))
                            {
                                dtgvCongThuc.Rows.Add(tenNL, SoLuong, maNL);
                                exist = true;
                            }
                        }
                        else if (dtgvCongThuc.Rows[i].Cells[2].Value.ToString() == maNL && exist == false)
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

        private void UpDateSP()
        {
            if (txtTenSP.Text == "")
            {
                MessageBox.Show("Xin mời bạn tên sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (cboDMSP.Texts == "")
            {
                MessageBox.Show("Xin mời bạn chọn danh mục sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtDonGia.Text == "")
            {
                MessageBox.Show("Xin mời bạn nhập đơn giá sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dtgvCongThuc.Rows.Count == 0)
            {
                MessageBox.Show("Xin mời bạn chọn nguyên liệu cho công thức!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (MessageBox.Show("Xác nhận thêm mới sản phẩm!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    //Cập nhật sản phẩm
                    string Mota;
                    string MaDMSP = (string)cboDMSP.SelectedValue;
                    //if (txtMoTa.Text == null)
                    //{
                    //    Mota = "NULL";
                    //}
                    //else { Mota = txtMoTa.Text; }             
                    string sql1 = "UPDATE SP SET MaDMSP = '" + MaDMSP + "', TenSP = N'" + txtTenSP.Text + "', DonGia = " + Convert.ToInt32(txtDonGia.Text) + ", MoTa = N'" + txtMoTa.Text + "' WHERE MaSP = N'" + MaCongThuc + "'";
                    Functions.RunSqlDel(sql1);


                    //Update cong thức
                    //string maSP = Functions.GetFieldValues("SELECT TOP 1 MaSP FROM SP ORDER BY MaSP DESC");
                    string sqlDEL = "DELETE FROM CongThuc WHERE MaSP = N'" + MaCongThuc + "'";
                    Functions.RunSqlDel(sqlDEL);
                    for (int i = 0; i < dtgvCongThuc.Rows.Count; i++)
                    {
                        string _maNL = dtgvCongThuc.Rows[i].Cells[2].Value.ToString();
                        int _soLuongNL = Convert.ToInt32(dtgvCongThuc.Rows[i].Cells[1].Value.ToString());
                        string sql2 = "INSERT INTO CongThuc(MaSP, MaNL, SoLuongNL) VALUES ('" + MaCongThuc + "', '" + _maNL + "'," + _soLuongNL + ")";
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
            UpDateSP();
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
            Category.fProducts pd = new Category.fProducts();
            pd.ShowDialog();
        }
    }
}
