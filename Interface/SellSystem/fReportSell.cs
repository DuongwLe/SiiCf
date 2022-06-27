using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using COMExcel = Microsoft.Office.Interop.Excel;
using Interface.Properties;

namespace Interface.SellSystem
{
    public partial class fReportSell : Form
    {
        DataTable tblHDBH;
        DataTable tblTongGG;
        DataTable tblPTTT;
        DataTable tblChiTietHDBH;
        DataTable tblBaoCao;
        DataTable tblThongTinDH;

        public fReportSell()
        {
            InitializeComponent();
        }
        #region properties
        string MaHDBH;
        #endregion
        private void fReportSell_Load(object sender, EventArgs e)
        {
            //DatePick.Format = DateTimePickerFormat.Custom;
            //DatePick.CustomFormat = "MM-yyyy";
            checkLoai();
            loadChiTietHDBH();
    
        }

        private void checkLoai()
        {
            if(rdoNgay.Checked == true)
            {
                loadHDBHNgay();
                TienNgay();
            }
            else if(rdoThang.Checked == true)
            {
                loadHDBHThang();
                TienThang();
            }
        }
        private void loadHDBHNgay()
        {
            string sql = "SELECT b.TenNV, c.TenPTTT, a.MaGG, CONVERT(CHAR(7),a.ThoiGian,108), a.TongTien, a.MaHDBH FROM HDBH a JOIN NhanVien b ON a.MaNV = b.MaNV JOIN PTTT c ON a.MaPTTT = c.MaPTTT WHERE DAY(a.ThoiGian) = '" + DatePick.Value.Day + "' AND MONTH(a.ThoiGian) = '" + DatePick.Value.Month + "' AND YEAR(a.ThoiGian) = '" + DatePick.Value.Year + "'";
            tblHDBH = Functions.GetDataToTable(sql);
            dtgvDSBH.DataSource = tblHDBH;
            dtgvDSBH.Columns[0].HeaderText = "Nhân viên";
            dtgvDSBH.Columns[0].Width = 200;
            dtgvDSBH.Columns[1].HeaderText = "PTTT";
            dtgvDSBH.Columns[1].Width = 170;
            dtgvDSBH.Columns[2].HeaderText = "Giảm giá";
            dtgvDSBH.Columns[2].Width = 150;
            dtgvDSBH.Columns[3].HeaderText = "Thời gian";
            dtgvDSBH.Columns[3].Width = 100;
            dtgvDSBH.Columns[4].HeaderText = "Tổng tiền";

            lblSoHD.Text = dtgvDSBH.Rows.Count.ToString();
        }

        private void loadHDBHThang()
        {
            string sql2 = "SELECT b.TenNV, a.ThoiGian, a.TongTien, a.MaBCDT FROM BaoCaoDT a JOIN NhanVien b ON a.MaNV = b.MaNV WHERE  MONTH(a.ThoiGian) = '" + DatePick.Value.Month + "' AND YEAR(a.ThoiGian) = '" + DatePick.Value.Year + "'";
            tblHDBH = Functions.GetDataToTable(sql2);
            dtgvDSBH.DataSource = tblHDBH;
            dtgvDSBH.Columns[0].HeaderText = "Nhân viên";
            dtgvDSBH.Columns[0].Width = 250;
            dtgvDSBH.Columns[1].HeaderText = "Thời gian";
            dtgvDSBH.Columns[1].Width = 270;
            dtgvDSBH.Columns[2].HeaderText = "Tổng tiền";
            dtgvDSBH.Columns[2].Width = 1500;

            lblSoHD.Text = dtgvDSBH.Rows.Count.ToString();
        }

        private void TienNgay()
        {
            try
            {
                double tongGG = 0;
                string sqlDT = "SELECT SUM(TongTien) FROM HDBH  WHERE DAY(ThoiGian) = '" + DatePick.Value.Day + "' AND MONTH(ThoiGian) = '" + DatePick.Value.Month + "' AND YEAR(ThoiGian) = '" + DatePick.Value.Year + "'";
                lblDoanhThu.Text = Functions.GetFieldValues(sqlDT);
                string sqlTongGG = "SELECT a.TongTien, b.PhanTram FROM HDBH a JOIN MGG b ON a.MaGG = b.MaGG  WHERE DAY(a.ThoiGian) = '" + DatePick.Value.Day + "' AND MONTH(a.ThoiGian) = '" + DatePick.Value.Month + "' AND YEAR(a.ThoiGian) = '" + DatePick.Value.Year + "'";
                try
                {
                    int KhongGG = Convert.ToInt32(Functions.GetFieldValues("SELECT SUM(TongTien) FROM HDBH WHERE DAY(ThoiGian) = '" + DatePick.Value.Day + "' AND MONTH(ThoiGian) = '" + DatePick.Value.Month + "' AND YEAR(ThoiGian) = '" + DatePick.Value.Year + "' AND MaGG IS NULL"));
                    tongGG = tongGG + KhongGG;
                }
                catch
                {

                }
               
                tblTongGG = Functions.GetDataToTable(sqlTongGG);
                foreach (DataRow item in tblTongGG.Rows)
                {
                    double _tongTien = Convert.ToDouble(item["TongTien"]);
                    double _phamTram = Convert.ToDouble(item["PhanTram"]);
                    tongGG = tongGG + (_tongTien - _tongTien * (_phamTram / 100));
                }
                string sqlTBHD = "SELECT AVG(TongTien) FROM HDBH  WHERE DAY(ThoiGian) = '" + DatePick.Value.Day + "' AND MONTH(ThoiGian) = '" + DatePick.Value.Month + "' AND YEAR(ThoiGian) = '" + DatePick.Value.Year + "'";
                lblTBHoaDon.Text = Functions.GetFieldValues(sqlTBHD);
                if (lblDoanhThu.Text == "")
                {
                    lblDoanhThu.Text = "0";
                }
                if (lblTBHoaDon.Text == "")
                {
                    lblTBHoaDon.Text = "0";
                }
                lblTongGG.Text = tongGG.ToString();
                lblChietKhau.Text = Convert.ToString(Convert.ToDouble(Functions.GetFieldValues(sqlDT)) - tongGG);             
                string sqlPhieuGG = "SELECT COUNT(MaGG) FROM HDBH  WHERE DAY(ThoiGian) = '" + DatePick.Value.Day + "' AND MONTH(ThoiGian) = '" + DatePick.Value.Month + "' AND YEAR(ThoiGian) = '" + DatePick.Value.Year + "' AND MaGG != 'NULL'";
                lblPhieuGG.Text = Functions.GetFieldValues(sqlPhieuGG);
                string sqldtgvPTTT = "SELECT TenPTTT, MaPTTT FROM PTTT";
                tblPTTT = Functions.GetDataToTable(sqldtgvPTTT);
                dtgvPTTT.Rows.Clear();
                foreach (DataRow item in tblPTTT.Rows)
                {
                    int TongTien = 0;
                    string _tenPTTT = item["TenPTTT"].ToString();
                    string _maPTTT = item["MaPTTT"].ToString();
                    string sqlPTTT = "SELECT SUM(TongTien) FROM HDBH WHERE DAY(ThoiGian) = '" + DatePick.Value.Day + "' AND MONTH(ThoiGian) = '" + DatePick.Value.Month + "' AND YEAR(ThoiGian) = '" + DatePick.Value.Year + "' AND MaPTTT = '" + _maPTTT + "'";
                    string TongTienstring = Functions.GetFieldValues(sqlPTTT);
                    if (TongTienstring == "")
                    {
                        TongTien = 0;
                        dtgvPTTT.Rows.Add(_tenPTTT, TongTien, _maPTTT);
                    }
                    else
                    {
                        TongTien = Convert.ToInt32(TongTienstring);
                        dtgvPTTT.Rows.Add(_tenPTTT, TongTien, _maPTTT);
                    }
                }

            }
            catch 
            {
                lblChietKhau.Text = "0";
                lblPhieuGG.Text = "0";
            }

        }
        private void TienThang()
        {
            try
            {
                double tongGG = 0;
                string sqlDT = "SELECT SUM(TongTien) FROM HDBH  WHERE MONTH(ThoiGian) = '" + DatePick.Value.Month + "' AND YEAR(ThoiGian) = '" + DatePick.Value.Year + "'";
                lblDoanhThu.Text = Functions.GetFieldValues(sqlDT);
                string sqlTongGG = "SELECT a.TongTien, b.PhanTram FROM HDBH a JOIN MGG b ON a.MaGG = b.MaGG  WHERE MONTH(ThoiGian) = '" + DatePick.Value.Month + "' AND YEAR(ThoiGian) = '" + DatePick.Value.Year + "'";
                tblTongGG = Functions.GetDataToTable(sqlTongGG);
                foreach (DataRow item in tblTongGG.Rows)
                {
                    double _tongTien = Convert.ToDouble(item["TongTien"]);
                    double _phamTram = Convert.ToDouble(item["PhanTram"]);
                    tongGG = tongGG + (_tongTien - _tongTien * (_phamTram / 100));
                }
                string sqlTBHD = "SELECT AVG(TongTien) FROM HDBH  WHERE MONTH(ThoiGian) = '" + DatePick.Value.Month + "' AND YEAR(ThoiGian) = '" + DatePick.Value.Year + "'";
                lblTBHoaDon.Text = Functions.GetFieldValues(sqlTBHD);
                if (lblDoanhThu.Text == "")
                {
                    lblDoanhThu.Text = "0";
                }
                if (lblTBHoaDon.Text == "")
                {
                    lblTBHoaDon.Text = "0";
                }
                lblTongGG.Text = tongGG.ToString();
                lblChietKhau.Text = Convert.ToString(Convert.ToDouble(Functions.GetFieldValues(sqlDT)) - tongGG);
                string sqlPhieuGG = "SELECT COUNT(MaGG) FROM HDBH  WHERE MaGG IS NOT NULL AND MONTH(ThoiGian) = '" + DatePick.Value.Month + "' AND YEAR(ThoiGian) = '" + DatePick.Value.Year + "'";
                lblPhieuGG.Text = Functions.GetFieldValues(sqlPhieuGG);
                string sqldtgvPTTT = "SELECT TenPTTT, MaPTTT FROM PTTT";
                tblPTTT = Functions.GetDataToTable(sqldtgvPTTT);
                dtgvPTTT.Rows.Clear();
                foreach (DataRow item in tblPTTT.Rows)
                {
                    int TongTien = 0;
                    string _tenPTTT = item["TenPTTT"].ToString();
                    string _maPTTT = item["MaPTTT"].ToString();
                    string sqlPTTT = "SELECT SUM(TongTien) FROM HDBH WHERE MONTH(ThoiGian) = '" + DatePick.Value.Month + "' AND YEAR(ThoiGian) = '" + DatePick.Value.Year + "'  AND MaPTTT = '" + _maPTTT + "'";
                    string TongTienstring = Functions.GetFieldValues(sqlPTTT);
                    if (TongTienstring == "")
                    {
                        TongTien = 0;
                        dtgvPTTT.Rows.Add(_tenPTTT, TongTien, _maPTTT);
                    }
                    else
                    {
                        TongTien = Convert.ToInt32(TongTienstring);
                        dtgvPTTT.Rows.Add(_tenPTTT, TongTien, _maPTTT);
                    }
                }

            }
            catch { }

        }

        private void loadChiTietHDBH()
        {
            string sql = "SELECT c.TenSP, a.SoLuong, a.MaSP FROM ChiTietHDBH a JOIN HDBH b  ON a.MaHDBH = b.MaHDBH JOIN SP c ON a.MaSP = c.MaSP WHERE a.MaHDBH = N'" + MaHDBH + "'";
            tblChiTietHDBH = Functions.GetDataToTable(sql);
            dtgvChiTietHDBH.DataSource = tblChiTietHDBH;
            dtgvChiTietHDBH.Columns[0].HeaderText = "Sản phẩm";
            dtgvChiTietHDBH.Columns[0].Width = 250;
            dtgvChiTietHDBH.Columns[1].HeaderText = "Số lượng";
            dtgvChiTietHDBH.Columns[1].Width = 170;

        }

        //private void loadChiTietHDBHThang()
        //{
        //    string sql = "SELECT ThoiGian, TongTien, MaHDBH FROM HDBH WHERE  MONTH(ThoiGian) = '" + DatePick.Value.Month + "' AND YEAR(ThoiGian) = '" + DatePick.Value.Year + "'";
        //    tblChiTietHDBH = Functions.GetDataToTable(sql);
        //    dtgvChiTietHDBH.DataSource = tblChiTietHDBH;
        //    dtgvChiTietHDBH.Columns[0].HeaderText = "Sản phẩm";
        //    dtgvChiTietHDBH.Columns[0].Width = 250;
        //    dtgvChiTietHDBH.Columns[1].HeaderText = "Số lượng";
        //    dtgvChiTietHDBH.Columns[1].Width = 170;

        //}


        private void DatePick_ValueChanged(object sender, EventArgs e)
        {
            checkLoai();
        }

        private void dtgvDSBH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (rdoNgay.Checked == true)
            {
                MaHDBH = dtgvDSBH.CurrentRow.Cells["MaHDBH"].Value.ToString();
                loadChiTietHDBH();
            }
            else if (rdoThang.Checked == true)
            {

            }

        }

        private void Excel_baoCao()
        {
            // Khởi động chương trình Excel
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
            COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
            COMExcel.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            DataTable tblThongtinHD, tblThongtinHang;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            // Định dạng chung
            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Name = "Times new roman";
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:B1"].Value = "Sii Coffee";

            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = "16A Nguyễn Bỉnh Khiêm ";

            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Điện thoại: 096.1765225";


            exRange.Range["C2:G2"].Font.Size = 16;
            exRange.Range["C2:G2"].Font.Name = "Times new roman";
            exRange.Range["C2:G2"].Font.Bold = true;
            exRange.Range["C2:G2"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C2:G2"].MergeCells = true;
            exRange.Range["C2:G2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C2:G2"].Value = "BÁO CÁO DOANH THU NGÀY";
            // Biểu diễn thông tin chung của hóa đơn bán      
            sql = "SELECT b.TenNV, c.TenPTTT, a.MaGG, CONVERT(CHAR(7),a.ThoiGian,108), a.TongTien FROM HDBH a JOIN NhanVien b ON a.MaNV = b.MaNV JOIN PTTT c ON a.MaPTTT = c.MaPTTT WHERE DAY(a.ThoiGian) = '" + DatePick.Value.Day + "' AND MONTH(a.ThoiGian) = '" + DatePick.Value.Month + "' AND YEAR(a.ThoiGian) = '" + DatePick.Value.Year + "'";
            tblThongTinDH = Functions.GetDataToTable(sql);
            //Tạo dòng tiêu đề bảng
            exRange.Range["A6:F6"].Font.Bold = true;
            exRange.Range["A6:F6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C6:F6"].ColumnWidth = 12;
            exRange.Range["A6:A6"].Value = "STT";
            exRange.Range["B6:B6"].Value = "Tên nhân viên";
            exRange.Range["C6:C6"].Value = "PTTT";
            exRange.Range["D6:D6"].Value = "Mã GG";
            exRange.Range["E6:E6"].Value = "Thời gian";
            exRange.Range["F6:F6"].Value = "Tổng tiền";
            for (hang = 0; hang <= tblThongTinDH.Rows.Count - 1; hang++)
            {
                //Điền số thứ tự vào cột 1 từ dòng 12
                exSheet.Cells[1][hang + 7] = hang + 1;
                for (cot = 0; cot <= tblThongTinDH.Columns.Count - 1; cot++)
                    //Điền thông tin hàng từ cột thứ 2, dòng 12
                    exSheet.Cells[cot + 2][hang + 7] = tblThongTinDH.Rows[hang][cot].ToString();
            }
            exRange = exSheet.Cells[cot][hang + 9];
            exRange.Font.Bold = true;
            exRange.Value2 = "Tổng tiền:";
            exRange = exSheet.Cells[cot + 1][hang + 9];
            exRange.Font.Bold = true;
            exRange.Value2 = tblThongTinDH.Rows[0][4].ToString();
            exRange = exSheet.Cells[1][hang + 10]; //Ô A1 

            exRange = exSheet.Cells[4][hang + 12]; //Ô A1 ;
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].Font.Italic = true;
            exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:C1"].Value = "Hà Nội, ngày " + DateTime.Today.Day + " tháng " + DateTime.Today.Month + " năm " + DateTime.Today.Year;
            exRange.Range["A2:C2"].MergeCells = true;
            exRange.Range["A2:C2"].Font.Italic = true;
            exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:C2"].Value = "Nhân viên bán hàng";
            exRange.Range["A6:C6"].MergeCells = true;
            exRange.Range["A6:C6"].Font.Italic = true;
            exRange.Range["A6:C6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A6:C6"].Value = Functions.GetFieldValues("SELECT TenNV FROM NhanVien WHERE MaNV = '" + Settings.Default.MaNV.ToString() + "'");





            exSheet.Name = "Báo Cáo Chi Phí";
            exApp.Visible = true;
        }
        private void btnInBaoCao_Click(object sender, EventArgs e)
        {
            Excel_baoCao();
        }

        private void rdoThang_CheckedChanged(object sender, EventArgs e)
        {
            checkLoai();
        }
    }
}
