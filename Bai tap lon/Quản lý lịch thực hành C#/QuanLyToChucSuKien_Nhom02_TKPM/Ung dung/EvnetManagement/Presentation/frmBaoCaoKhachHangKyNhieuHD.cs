using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraEditors;
using EventManager.Reports;
using EventManager.Utilities;
using DevExpress.XtraReports.UserDesigner;

namespace EventManager.Presentation
{
    public partial class frmBaoCaoKhachHangKyNhieuHD : XtraForm
    {
        rptThongTinKhachHang rpt;
        LogFile log;
        public frmBaoCaoKhachHangKyNhieuHD()
        {
            InitializeComponent();
            rpt = new rptThongTinKhachHang();
            log = new LogFile();
        }

        private void frmBaoCaoKhachHangKyNhieuHD_Load(object sender, EventArgs e)
        {
            try
            {
                printControl1.PrintingSystem = rpt.PrintingSystem;
                rpt.CreateDocument();
                log.GhiFile("Xuất báo cáo danh sách các khách hàng nhiều hợp đồng");
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            } 
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                XRDesignRibbonForm form = new XRDesignRibbonForm();
                form.OpenReport(new rptThongTinKhachHang());
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }
    }
}
