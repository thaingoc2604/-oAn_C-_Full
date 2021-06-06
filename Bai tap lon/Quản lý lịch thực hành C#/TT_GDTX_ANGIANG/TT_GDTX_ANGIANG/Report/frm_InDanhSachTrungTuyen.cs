using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TT_GDTX_ANGIANG.Report
{
    public partial class frm_InDanhSachTrungTuyen : DevComponents.DotNetBar.Office2007Form
    {
        public frm_InDanhSachTrungTuyen()
        {
            InitializeComponent();
        }

        TT_GDTX_ANGIANG.Report.InDanhSachTrungTuyen report = new TT_GDTX_ANGIANG.Report.InDanhSachTrungTuyen();
        private void frm_InDanhSachTrungTuyen_Load(object sender, EventArgs e)
        {
            DataService dt = new DataService();
            Connect();
        }
        private void Connect()
        {
            CrystalDecisions.Shared.TableLogOnInfo tliCurrent = new CrystalDecisions.Shared.TableLogOnInfo();
            foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in report.Database.Tables)
            {
                tliCurrent = tbCurrent.LogOnInfo;
                tliCurrent.ConnectionInfo.ServerName = TT_GDTX_ANGIANG.Properties.Settings.Default.servername;
                tliCurrent.ConnectionInfo.UserID = TT_GDTX_ANGIANG.Properties.Settings.Default.username;
                tliCurrent.ConnectionInfo.Password = TT_GDTX_ANGIANG.Properties.Settings.Default.pass;
                tliCurrent.ConnectionInfo.DatabaseName = TT_GDTX_ANGIANG.Properties.Settings.Default.databasename;
                tbCurrent.ApplyLogOnInfo(tliCurrent);
            }
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Refresh();
        }
    }
}