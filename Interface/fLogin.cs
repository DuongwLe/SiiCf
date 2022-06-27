using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Interface.Properties;


namespace Interface
{
    public partial class fLogin : Form
    {
        DataTable loadTaiKhoan;
        public fLogin()
        {
            InitializeComponent();

        }

        private void lblReset_Click(object sender, EventArgs e)
        {
            txtPassWord.Text = "";
            txtUserName.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string sql = "SELECT MaNV ,MaVT FROM TaiKhoan WHERE TaiKhoan =N'" + txtUserName.Text + "'" + "AND MatKhau = N'" + txtPassWord.Text + "'";
            loadTaiKhoan = Functions.GetDataToTable(sql);
            if (loadTaiKhoan != null)
            {
                foreach (DataRow item in loadTaiKhoan.Rows)
                {
                    string MaNV = item["MaNV"].ToString();
                    string MaVT = item["MaVT"].ToString();
                    Settings.Default.active = true;
                    Settings.Default.MaNV = MaNV;
                    Settings.Default.MaVT = MaVT;
                    Settings.Default.Save();
                }
            new Form1().Show();
            this.Hide();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng! Vui lòng thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassWord.Text = "";
                txtUserName.Text = "";
                txtUserName.Focus();
            }
        }

        private void pcbShowPass_Click(object sender, EventArgs e)
        {
            if(txtPassWord.PasswordChar == true)
            {
                txtPassWord.PasswordChar = false;
            }
            else
            {
                txtPassWord.PasswordChar = true;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtPassWord.Text = "";
            txtUserName.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExit_MouseHover(object sender, EventArgs e)
        {
            btnReset.ForeColor = Color.FromArgb(202, 168, 107);
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnReset.ForeColor = Color.FromArgb(102, 42, 22);
        }

        private void btnReset_MouseHover(object sender, EventArgs e)
        {
            btnReset.ForeColor = Color.FromArgb(202, 168, 107);
        }

        private void btnReset_MouseLeave(object sender, EventArgs e)
        {
            btnReset.ForeColor = Color.FromArgb(102, 42, 22);  
        }

        private void fLogin_Load(object sender, EventArgs e)
        {
            Functions.Connect();
            txtPassWord.PasswordChar = true;
            //if(Settings.Default.active == true)
            //{
            //    new Form1().Show();
            //    this.Hide();
            //}
            //else
            //{
            //    return;
            //}
        }

    }
}
