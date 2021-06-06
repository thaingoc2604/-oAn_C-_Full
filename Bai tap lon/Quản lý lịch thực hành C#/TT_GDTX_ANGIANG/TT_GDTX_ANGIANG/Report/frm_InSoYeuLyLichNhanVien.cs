using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using DevComponents.DotNetBar;
using System.Windows.Forms;
using System.Collections;

namespace TT_GDTX_ANGIANG.Report
{
    public partial class frm_InSoYeuLyLichNhanVien : DevComponents.DotNetBar.Office2007Form
    {
        public frm_InSoYeuLyLichNhanVien()
        {
            InitializeComponent();
        }
        String m_MaNV = "";
        public frm_InSoYeuLyLichNhanVien(String MaNV)
        {
            InitializeComponent();
            m_MaNV = MaNV;
        }
        TT_GDTX_ANGIANG.Report.InSoYeuLyLichNhanVien report = new TT_GDTX_ANGIANG.Report.InSoYeuLyLichNhanVien();
        private void frm_InSoYeuLyLichNhanVien_Load(object sender, EventArgs e)
        {
            DataService dt = new DataService();
            Connect();           

            para();

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
        void para()
        {
            
            report.SetParameterValue("paraMaNV", m_MaNV);
            
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Refresh();
        }
    }
}