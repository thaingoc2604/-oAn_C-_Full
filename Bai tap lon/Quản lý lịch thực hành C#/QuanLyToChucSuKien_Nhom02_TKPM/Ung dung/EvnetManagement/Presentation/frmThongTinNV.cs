using System;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using EventManager.Business;
using System.Data.Linq;
using EventManager.DataAccess;
using EventManager.Utilities;

namespace EventManager.Presentation
{
    public partial class frmThongTinNV : XtraForm
    {
        NhanVienBUS nhanVienBUS;
        Table<view_ThongTinNV> source;
        LogFile log;
        public frmThongTinNV()
        {
            try
            {
                InitializeComponent();
                nhanVienBUS = new NhanVienBUS();
                log = new LogFile();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void frmThongTinNV_Load_1(object sender, EventArgs e)
        {
            try
            {
                source = nhanVienBUS.ThongTinNV();
                gridControl1.DataSource = source;

                txtMaNV.DataBindings.Clear();
                txtMaNV.DataBindings.Add("Text", source, "MaNV");

                txtTenNV.DataBindings.Clear();
                txtTenNV.DataBindings.Add("Text", source, "TenNV");

                txtSoCTDky.DataBindings.Clear();
                txtSoCTDky.DataBindings.Add("Text", source, "SoCTDky");
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            try
            {
                gridControl1.ShowRibbonPrintPreview();
                log.GhiFile("Xuất danh sách thông tin nhân viên");
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }
    }
}