using System;
using DevExpress.XtraReports.UI;
using System.Data;
using EventManager.Utilities;

namespace EventManager.Reports
{
    public partial class rptTimKiemNangCao : XtraReport
    {
        object source = new object();

        public object Source
        {
            get { return source; }
            set { source = value; }
        }
        public rptTimKiemNangCao(object source)
        {
            try
            {
                InitializeComponent();
                this.source = source;
                CreateReport(source);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public rptTimKiemNangCao()
        {
            try
            {
                InitializeComponent();
                CreateReport(source);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CreateReport(object source)
        {
            try
            {
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
                thanhToanTre.DataBindings.Clear();
                thanhToanTre.DataBindings.Add("Text", source, "SoLanTreHan");
                tongNo.DataBindings.Clear();
                tongNo.DataBindings.Add("Text", source, "TongNo");
                xepLoai.DataBindings.Clear();
                xepLoai.DataBindings.Add("Text", source, "XepLoai");
                dienThoai.DataBindings.Clear();
                dienThoai.DataBindings.Add("Text", source, "DienThoai");
                email.DataBindings.Clear();
                email.DataBindings.Add("Text", source, "Email");
                diaChi.DataBindings.Clear();
                diaChi.DataBindings.Add("Text", source, "DiaChi");

                nguoiLap.Text = StaticClass.User.TenNguoiDung;

                khachHangTrang.DataBindings.Clear();
                khachHangTrang.DataBindings.Add("Text", source, "MaKH");
                khachHangBC.DataBindings.Clear();
                khachHangBC.DataBindings.Add("Text", source, "MaKH");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
