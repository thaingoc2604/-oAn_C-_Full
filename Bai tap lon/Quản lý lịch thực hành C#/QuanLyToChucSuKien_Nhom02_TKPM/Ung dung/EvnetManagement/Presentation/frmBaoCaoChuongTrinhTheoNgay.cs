using System;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using EventManager.Reports;
using EventManager.Utilities;
using DevExpress.XtraReports.UserDesigner;

namespace EventManager.Presentation
{
    public partial class frmBaoCaoChuongTrinhTheoNgay : XtraForm
    {
        rptChuongTrinhTheoNgay rpt;
        LogFile log;
        public frmBaoCaoChuongTrinhTheoNgay()
        {
            InitializeComponent();
            log = new LogFile();
        }

        private void frmBaoCaoChuongTrinhTheoNgay_Load(object sender, EventArgs e)
        {
            try
            {
                ngayTruyVan.EditValue = DateTime.Now;
                barEditItem1_EditValueChanged(null, null);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void barEditItem1_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                rpt = new rptChuongTrinhTheoNgay(DateTime.Parse(ngayTruyVan.EditValue.ToString()));
                printControl1.PrintingSystem = rpt.PrintingSystem;
                rpt.CreateDocument();
                log.GhiFile("Xuất danh sách các chương trình tổ chức trong ngày: " + ngayTruyVan.EditValue.ToString());
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }
    }
}