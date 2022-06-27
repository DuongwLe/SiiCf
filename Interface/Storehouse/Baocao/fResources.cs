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
    public partial class fResources : Form
    {
        public fResources()
        {
            InitializeComponent();
        }
        DataTable Data;


        private void fResources_Load(object sender, EventArgs e)
        {
            
        }

        private string status(long SoLuong)
        {
            if(SoLuong >= 1000)
            {
                return "Tồn Kho !";
            }
            if(SoLuong <= 5)
            {
                return "Sắp Hết !";
            }
            return "Ổn Định !";
        }

        private void LoadData(string fromDate, string toDate)
        {
            string query = "SELECT TenNL , MaNL , (TongHT - TongTT) AS CL,SoLuong FROM (SELECT nl.SoLuong,nl.TenNL,ct.MaNL, SUM(ct.SoLuongHT) AS TongHT, SUM(ct.SoLuongTT) AS TongTT FROM ChiTietKiemKe ct join KiemKe kk ON ct.MaKK = kk.MaKK join NL as nl ON ct.MaNL = nl.MaNL WHERE kk.NgayKK >= '" + fromDate + "' AND kk.NgayKK <= '"+ toDate + "' GROUP BY ct.MaNL,nl.TenNL,nl.SoLuong) AS TT ";
            Data = Functions.GetDataToTable(query);
            foreach (DataRow item in Data.Rows)
            {
                string TenNL = item["TenNL"].ToString();
                string MaNL = item["MaNL"].ToString();
                string ChenhLech = item["CL"].ToString();
                string SoLuong = item["SoLuong"].ToString();
                dataGridView1.Rows.Add(TenNL, MaNL, ChenhLech,SoLuong, status(Convert.ToInt64(SoLuong)));
            }
        }

        private void siiButton1_Click(object sender, EventArgs e)
        {
            LoadData(fromDate.Value.ToString("MM/dd/yyyy"), toDate.Value.ToString("MM/dd/yyyy"));
            
        }
    }
}
