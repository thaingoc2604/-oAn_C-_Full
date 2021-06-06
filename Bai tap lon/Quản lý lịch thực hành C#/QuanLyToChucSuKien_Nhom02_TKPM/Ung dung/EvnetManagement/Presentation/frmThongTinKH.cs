using System;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using EventManager.DataAccess;
using EventManager.Utilities;
using System.Data.Linq;
using EventManager.Business;

namespace EventManager.Presentation
{
    public partial class frmThongTinKH : XtraForm
    {
        KhachHangBUS khachHangBUS;
        Table<view_ThongTinKH> source;
        LogFile log;
        public frmThongTinKH()
        {
            try
            {
                InitializeComponent();
                khachHangBUS = new KhachHangBUS();
                source = khachHangBUS.ThongTinTongHop();
                log = new LogFile();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Binding()
        {
            try
            {
                txtMaKH.DataBindings.Add("Text", source, "MaKH");
                txtHoTen.DataBindings.Add("Text", source, "TenKH");
                txtSoCTDky.DataBindings.Add("Text", source, "SoCTDky");
                txtTongPhi.DataBindings.Add("Text", source, "TongPhi");
                txtTreHan.DataBindings.Add("Text", source, "SoLanTreHan");
                txtTongNo.DataBindings.Add("Text", source, "TongNo");
                txtDienThoai.DataBindings.Add("Text", source, "DienThoai");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtDiaChi.DataBindings.Add("Text", source, "DiaChi");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ClearBinding()
        {
            try
            {
                txtMaKH.DataBindings.Clear();
                txtHoTen.DataBindings.Clear();
                txtSoCTDky.DataBindings.Clear();
                txtTongPhi.DataBindings.Clear();
                txtTreHan.DataBindings.Clear();
                txtTongNo.DataBindings.Clear();
                txtDienThoai.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtDiaChi.DataBindings.Clear();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void frmThongTinKH_Load(object sender, EventArgs e)
        {
            try
            {
                gridControl1.DataSource = source;
                ClearBinding();
                Binding();
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
            log.GhiFile("Xuất danh sách thông tin chi tiết của khách hàng");
        }
    }
}