using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;



namespace QuayThuoc
{
    public partial class FrmDoanhThu : Form
    {
        public FrmDoanhThu()
        {
            InitializeComponent();
        }

        private void FrmDoanhThu_Load(object sender, EventArgs e)
        {

          //  this.reportViewer1.RefreshReport();
            //this.reportViewer2.RefreshReport();
      //      this.reportViewer3.RefreshReport();
        //    this.reportViewer4.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(@"C:\Documents and Settings\Administrator\My Documents\Visual Studio 2008\Projects\QuayThuoc\QuayThuoc\CrystalReport4.rpt");
            crystalReportViewer4.ReportSource = cryRpt;
            crystalReportViewer4.Refresh();  

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(@"C:\Documents and Settings\Administrator\My Documents\Visual Studio 2008\Projects\QuayThuoc\QuayThuoc\CrystalReport1.rpt");
            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();  

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //C:\Documents and Settings\Administrator\My Documents\Visual Studio 2008\Projects\QuayThuoc\QuayThuoc\CrystalReport1.rpt
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(@"C:\Documents and Settings\Administrator\My Documents\Visual Studio 2008\Projects\QuayThuoc\QuayThuoc\CrystalReport2.rpt");
            crystalReportViewer2.ReportSource = cryRpt;
            crystalReportViewer2.Refresh();  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(@"C:\Documents and Settings\Administrator\My Documents\Visual Studio 2008\Projects\QuayThuoc\QuayThuoc\CrystalReport3.rpt");
            crystalReportViewer3.ReportSource = cryRpt;
            crystalReportViewer3.Refresh();  
        }
    }
}
