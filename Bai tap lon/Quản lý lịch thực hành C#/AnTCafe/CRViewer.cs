using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;


namespace AnTCafe
{
    public partial class CRViewer : Form
    {
        clsCommonUI objCommonUI = new clsCommonUI();
        DataTable tblResult = new DataTable();
        string strTenReport;
        string strCRQuery;

        public string TenReport
        {
            get { return strTenReport; }
            set { strTenReport = value; }
        }
        public string CRQuery
        {
            get { return strCRQuery; }
            set { strCRQuery = value; }
        }

        public CRViewer()
        {
            InitializeComponent();

        }

        private void CRViewer_Load(object sender, EventArgs e)
        {
            string strSQL = strCRQuery;
            if (TenReport == "PHIEUTHU") {
                tblResult = objCommonUI.getDataFromSQL(strSQL);
                crPhieuXuat report = new crPhieuXuat();
                // Set data source to the crystal report. If the report contains multiple
                // datatables, then we can index each tables by using the table
                // name. Following code explains how table name is used for indexing.
                report.Database.Tables[0].SetDataSource((DataTable)tblResult);
                // Assign the report to the Crystal report viewer.    
                crystalReportViewer.ReportSource = report;
            }
            if (TenReport == "THONGKEHANGTON")
            {
                tblResult = objCommonUI.getDataFromSQL(strSQL);
                crHangTon report = new crHangTon();
                report.Database.Tables["HangTon"].SetDataSource((DataTable)tblResult);
                crystalReportViewer.ReportSource = report;
            }

            
            crystalReportViewer.PrintReport();
            this.Close();
        }
    }
}