using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using EventManager.DataAccess;
using EventManager.Utilities;

namespace EventManager.Reports
{
    public partial class rptChuongTrinhTheoNgay : XtraReport
    {
        dbEventsManagementDataContext db=new dbEventsManagementDataContext();
        public rptChuongTrinhTheoNgay()
        {
            InitializeComponent();
            CreatReport(DateTime.Now);
        }

        public rptChuongTrinhTheoNgay(DateTime ngay)
        {
            InitializeComponent();
            CreatReport(ngay);
        }

        private void CreatReport(DateTime ngay)
        {
            try
            {
                var source = db.sp_chuongTrinhTrongNgay(ngay);
                this.DataSource = source;
                txtNgay.Text = ngay.ToString("dd/MM/yyyy");
                DateTime toDay = DateTime.Today;
                lblNgayLap.Text = "Long Xuyên, ngày " + toDay.Day + " tháng " + toDay.Month + " năm " + toDay.Year;

                tenCT.DataBindings.Clear();
                tenCT.DataBindings.Add("Text", source, "TenCT");
                tenKH.DataBindings.Clear();
                tenKH.DataBindings.Add("Text", source, "TenKH");
                ngayKT.DataBindings.Clear();
                ngayKT.DataBindings.Add("Text", source, "NgayKetThuc");
                soNguoi.DataBindings.Clear();
                soNguoi.DataBindings.Add("Text", source, "SoNguoiThamGia");
                mucPhat.DataBindings.Clear();
                mucPhat.DataBindings.Add("Text", source, "MucPhat");
                diaDiem.DataBindings.Clear();
                diaDiem.DataBindings.Add("Text", source, "DiaDiem");
                nhanVien.DataBindings.Clear();
                nhanVien.DataBindings.Add("Text", source, "TenNV");

                lblNguoiLap.Text = StaticClass.User.TenNguoiDung;

                lblTongSoCT.DataBindings.Clear();
                lblTongSoCT.DataBindings.Add("Text", source, "TenCT");
                lblTongSoNguoi.DataBindings.Clear();
                lblTongSoNguoi.DataBindings.Add("Text", source, "SoNguoiThamGia");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
