using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using EventManager.DataAccess;
using EventManager.Utilities;

namespace EventManager.Reports
{
    public partial class rptThanhToanCanThuTuan : XtraReport
    {
        dbEventsManagementDataContext db;

        public rptThanhToanCanThuTuan(DateTime ngay)
        {
            InitializeComponent();
            db = new dbEventsManagementDataContext();
            CreateReport(ngay);
        }

        public rptThanhToanCanThuTuan()
        {
            InitializeComponent();
            db = new dbEventsManagementDataContext();
            CreateReport(DateTime.Now);
        }

        private void CreateReport(DateTime ngay)
        {
            try
            {
                var source = db.sp_ThanhToanCanThuTuan(ngay);
                this.DataSource = source;
                thoiGian.Text = "TỪ " + ngay.ToString("dd/MM/yyyy") + " ĐẾN " + ngay.AddDays(7).ToString("dd/MM/yyyy");
                maKH.DataBindings.Clear();
                maKH.DataBindings.Add("Text", source, "MaKH");
                tenKH.DataBindings.Clear();
                tenKH.DataBindings.Add("Text", source, "TenKH");
                maHD.DataBindings.Clear();
                maHD.DataBindings.Add("Text", source, "IdCTCT");
                giaiDoan.DataBindings.Clear();
                giaiDoan.DataBindings.Add("Text", source, "GiaiDoan");
                ngayThanhToan.DataBindings.Clear();
                ngayThanhToan.DataBindings.Add("Text", source, "NgayTTTheoKH");
                tien.DataBindings.Clear();
                tien.DataBindings.Add("Text", source, "Phi");
                nhanVien.DataBindings.Clear();
                nhanVien.DataBindings.Add("Text", source, "TenNV");
                dienThoai.DataBindings.Clear();
                dienThoai.DataBindings.Add("Text", source, "DienThoai");

                DateTime toDay = DateTime.Today;
                ngayLap.Text = "Long Xuyên, ngày " + toDay.Day + " tháng " + toDay.Month + " năm " + toDay.Year;
                nguoiLap.Text = StaticClass.User.TenNguoiDung;

                tongSoKH.DataBindings.Clear();
                tongSoKH.DataBindings.Add("Text", source, "MaKH");
                tongSoKHTrang.DataBindings.Clear();
                tongSoKHTrang.DataBindings.Add("Text", source, "MaKH");
                tongTien.DataBindings.Clear();
                tongTien.DataBindings.Add("Text", source, "Phi");
                tongTienTrang.DataBindings.Clear();
                tongTienTrang.DataBindings.Add("Text", source, "Phi");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
