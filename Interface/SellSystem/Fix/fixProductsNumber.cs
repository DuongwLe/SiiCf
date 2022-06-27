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

namespace Interface.SellSystem.Fix
{
    public partial class fixProductsNumber : Form
    {
        public fixProductsNumber()
        {
            InitializeComponent();
        }

        #region Properties
        string MaSP;
        string TenSP;
        string GiaTien;
        #endregion

        private void fixProductsNumber_Load(object sender, EventArgs e)
        {
            List<string> lstBaiviet = File.ReadAllLines(@"Data\Order.txt").ToList();
            string data = lstBaiviet[Settings.Default.indexTamTinh];
            string soluong = data.Split('|')[2];
            txtSoluong.Text = soluong;
            MaSP = data.Split('|')[0];
            TenSP = data.Split('|')[1];
            GiaTien = data.Split('|')[3];
        }
        private void Load_data(string path)
        {
            File.AppendAllText(path, MaSP + '|' + TenSP + '|' + txtSoluong.Text + '|' + GiaTien + "\r\n");
        }
        private void FixData()
        {
            string temp = "Order.txt";
            List<string> lstData = File.ReadAllLines(@"Data\Order.txt").ToList();
            //int index = Settings.Default.indexFixAction;
            for (int i = 0; i < lstData.Count; i++)
            {
                string line = lstData[i];
                if (i != Settings.Default.indexTamTinh)
                {
                    File.AppendAllText(@temp, line + "\n");
                }
                else if (i == Settings.Default.indexTamTinh)
                {
                    Load_data(temp);
                }
            }
            File.Delete(@"Data\Order.txt");
            File.Move(temp, @"Data\Order.txt");

        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            FixData();
            this.Close();
        }

    }
}
