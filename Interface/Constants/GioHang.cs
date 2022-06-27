using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Constants
{
    public class GioHang
    {
        private string maSP;
        private string tenSP;
        private int soLuong;
        private string donGia;

        public GioHang(string maSP, string tenSP, int soLuong, string donGia)
        {
            this.maSP = maSP;
            this.tenSP = tenSP;
            this.soLuong = soLuong;
            this.donGia = donGia;
        }
        public string MaSP { get { return maSP; } set { maSP = value; } }
        public string TenSP { get { return tenSP; } set { tenSP = value; } }
        public int SoLuong { get { return soLuong; } set { soLuong = value; } }
        public string DonGia { get { return donGia; } set { donGia = value; } }

    }
}
