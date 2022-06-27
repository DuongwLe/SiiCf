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
using Interface.Constants;

namespace Interface.SellSystem
{
    public partial class ProductsNumber : Form
    {
        private readonly string _tenSP;
        private readonly string _donGia;
        private readonly string _maSP;
        List<GioHang> GioHang = new();
        public ProductsNumber(string maSP, string tenSP,string donGia)
        {
            _tenSP = tenSP;
            _donGia = donGia;
            _maSP = maSP;
            InitializeComponent();
        }

        private void btnHuybo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if(txtSoluong.Text == "")
            {
                MessageBox.Show("Xin mời bạn nhập số lượng sản phẩm!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                string MaSP = _maSP;
                string TenSP = _tenSP;
                string GiaTien = _donGia;
                int SoLuong = Convert.ToInt32(txtSoluong.Text);
                //File.AppendAllText(@"Data\Order.txt", MaSP + '|' + TenSP + '|' + SoLuong  + '|' + GiaTien + "\r\n");
                CheckData(MaSP, SoLuong, TenSP, Convert.ToInt32(GiaTien));
                //GioHang.Add(new GioHang(TenSP, SoLuong, GiaTien));
                //fOrder cak = new fOrder(GioHang);
                //cak.ShowDialog();
                this.Close();
            }
            //fOrder.Load_ThanhToan();
        }
        private void CheckData(string MaSP, int SoLuong, string TenSP, int GiaTien)
        {
            string temp = "Order.txt";
            List<string> lstData = File.ReadAllLines(@"Data\Order.txt").ToList();
            //int index = Settings.Default.indexFixAction;
            bool exist = false;
            if(lstData.Count > 0)
            {
                for (int i = 0; i < lstData.Count; i++)
                {
                    string line = lstData[i];
                    string MaSPCheck = line.Split('|')[0];
                    int SoLuongCheck = Convert.ToInt32(line.Split('|')[2]);
                    int tong = SoLuong + SoLuongCheck;
                    if (MaSPCheck != MaSP)
                    {
                        File.AppendAllText(temp, line + "\n");
                        if ((i == lstData.Count - 1) && (exist == false))
                        {
                            File.AppendAllText(temp, MaSP + '|' + TenSP + '|' + SoLuong + '|' + GiaTien + "\r\n");
                        }
                    }
                    else if (MaSPCheck == MaSP)
                    {
                        File.AppendAllText(temp, MaSP + '|' + TenSP + '|' + tong + '|' + GiaTien + "\r\n");
                        exist = true;
                    }
                }

                File.Delete(@"Data\Order.txt");
                File.Move(temp, @"Data\Order.txt");
            }
            else
            {
                File.AppendAllText(@"Data\Order.txt", MaSP + '|' + TenSP + '|' + SoLuong + '|' + GiaTien + "\r\n");
            }
        }

        private void txtSoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;

        }

    }
}

