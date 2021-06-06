using System;
using DevExpress.XtraReports.UI;
using EventManager.DataAccess;
using EventManager.Utilities;

namespace EventManager.Reports
{
    public partial class rptThongTinKhachHang : XtraReport
    {
        dbEventsManagementDataContext db;
        public rptThongTinKhachHang()
        {
            InitializeComponent();
            db = new dbEventsManagementDataContext();
            CreateReport();
        }

        private void CreateReport()
        {
            try
            {
                var source = db.sp_thongKeKH();
                this.DataSource = source;
                DateTime toDay = DateTime.Today;
                lblNgayLap.Text = "Long Xuyên, ngày " + toDay.Day + " tháng " + toDay.Month + " năm " + toDay.Year;

                maKH.DataBindings.Clear();
                maKH.DataBindings.Add("Text", source, "MaKH");
                tenKH.DataBindings.Clear();
                tenKH.DataBindings.Add("Text", source, "TenKH");
                soHD.DataBindings.Clear();
                soHD.DataBindings.Add("Text", source, "SoCTDky");
                tongGiaTri.DataBindings.Clear();
                tongGiaTri.DataBindings.Add("Text", source, "TongPhi");
                diaC.DataBindings.Clear();
                diaC.DataBindings.Add("Text", source, "DiaChi");

                lblNguoiLap.Text = StaticClass.User.TenNguoiDung;

                lblTongSoKH.DataBindings.Clear();
                lblTongSoKH.DataBindings.Add("Text", source, "MaKH");
                lblTongGiaTriHD.DataBindings.Clear();
                lblTongGiaTriHD.DataBindings.Add("Text", source, "TongPhi");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
