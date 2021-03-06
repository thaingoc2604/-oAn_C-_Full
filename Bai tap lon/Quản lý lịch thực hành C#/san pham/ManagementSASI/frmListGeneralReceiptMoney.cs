using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Threading;
using CrystalDecisions.CrystalReports.Engine;
using System.Data.SqlClient;
using System.Configuration;

namespace ManagementSASI
{
    public partial class frmListGeneralReceiptMoney : DevExpress.XtraEditors.XtraForm
    {
        public frmListGeneralReceiptMoney()
        {
            InitializeComponent();
        }
        CrystalReportGeneralReceiptMoney cry = new CrystalReportGeneralReceiptMoney();
        frmWatingServer frmw = new frmWatingServer();
        Thread thread ;
        ManagementSASIDataContext db = new ManagementSASIDataContext();

        static string stringconnect = ConfigurationManager.ConnectionStrings["ManagementSASI.Properties.Settings.SDGHYConnectionString"].ConnectionString;

        private void Waiting()
        {
            frmw.ShowDialog();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboSemester.Text == "")
                {
                    XtraMessageBox.Show("Xem lại kì học", Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation); cboSemester.Focus();
                }
                else
                {
                    if (rdbSchollYear.Checked == true)
                    {
                        thread = new Thread(new ThreadStart(Waiting));
                        thread.Start();
                       // groupControl1.Text = "Thông tin tổng hợp sinh viên học cải thiện " + "  ( Chú ý thời gian bắt đầu đăng ký và thời gian kết thúc đăng ký )";
                        SqlConnection sqlcon = new SqlConnection(stringconnect);
                        DataSet ds = new DataSet();
                        SqlCommand sqlcom = new SqlCommand();
                        sqlcom.CommandText = "GeneralReceiptMoney";
                        sqlcom.CommandType = CommandType.StoredProcedure;
                        sqlcom.Connection = sqlcon;
                        DateTime dtime = DateTime.Now;

                        sqlcom.Parameters.Add(new SqlParameter("@EndDate", dtime));
                        sqlcom.Parameters.Add(new SqlParameter("@Semester", cboSemester.Text));
                        sqlcom.Parameters.Add(new SqlParameter("@ShoolYear", cboShoolYear.Text));
                        SqlDataAdapter da = new SqlDataAdapter(sqlcom);
                        da.Fill(ds, "GeneralReceiptMoney");
                        TestManageSASI testmana = new TestManageSASI();
                        ((TextObject)cry.ReportDefinition.ReportObjects["txtSemester"]).Text = "Học kì :" + cboSemester.Text + " :" + "năm học : " + cboShoolYear.Text;
                        DataTable dt = ds.Tables["GeneralReceiptMoney"];
                        try{
                        ((TextObject)cry.ReportDefinition.ReportObjects["txtTotalAll"]).Text =string.Format("{0:0,0}", float.Parse( dt.Compute("sum(total)", string.Empty).ToString()));
                           }
                        catch { }
                        cry.SetDataSource(ds);
                        thread.Abort();
                        crystalReportViewer1.ReportSource = cry;

                    }
                    if (rdbQuater.Checked == true)
                    {
                        thread = new Thread(new ThreadStart(Waiting));
                        thread.Start();
                       // groupControl1.Text = "Thông tin tổng hợp sinh viên học cải thiện " + "  ( Chú ý thời gian bắt đầu đăng ký và thời gian kết thúc đăng ký )";
                        SqlConnection sqlcon = new SqlConnection(stringconnect);
                        DataSet ds = new DataSet();
                        SqlCommand sqlcom = new SqlCommand();
                        sqlcom.CommandText = "GeneralReceiptMoneyQuater";
                        sqlcom.CommandType = CommandType.StoredProcedure;
                        sqlcom.Connection = sqlcon;
                        DateTime dtime = DateTime.Now;

                        sqlcom.Parameters.Add(new SqlParameter("@EndDate", dtime));
                        sqlcom.Parameters.Add(new SqlParameter("@Quater", cboQuarter.Text)); ;
                        SqlDataAdapter da = new SqlDataAdapter(sqlcom);
                        da.Fill(ds, "GeneralReceiptMoney");
                        TestManageSASI testmana = new TestManageSASI();
                        ((TextObject)cry.ReportDefinition.ReportObjects["txtSemester"]).Text = "Quý: " + cboQuarter.Text;
                        DataTable dt = ds.Tables["GeneralReceiptMoney"];
                        try
                        {
                            ((TextObject)cry.ReportDefinition.ReportObjects["txtTotalAll"]).Text = string.Format("{0:0,0}", float.Parse(dt.Compute("sum(total)", string.Empty).ToString()));
                        }
                        catch { }
                        cry.SetDataSource(ds);
                        thread.Abort();
                        crystalReportViewer1.ReportSource = cry;
                    }

                    ManagementSASI.Properties.Settings.Default.ShoolYear = cboShoolYear.Text;
                    ManagementSASI.Properties.Settings.Default.Semeste = cboSemester.Text;
                    ManagementSASI.Properties.Settings.Default.Quater = cboQuarter.Text;
                    ManagementSASI.Properties.Settings.Default.Save();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void LoadShoolYear()
        {
            DateTime dt = DateTime.Now;
            for (int i = dt.Year - 2; i < dt.Year + 1; i++)
            {
                cboShoolYear.Properties.Items.Add(i + "-" + (i + 1));
                cboShoolYear.SelectedIndex = 2;
            }
        }
        private void GeneralReceiptMoney_Load(object sender, EventArgs e)
        {
            LoadShoolYear();
            cboShoolYear.Text = ManagementSASI.Properties.Settings.Default.ShoolYear;
            cboSemester.Text = ManagementSASI.Properties.Settings.Default.Semeste;
            cboQuarter.Text = ManagementSASI.Properties.Settings.Default.Quater;
        }

        private void rdbSchollYear_Click(object sender, EventArgs e)
        {
            if (rdbSchollYear.Checked == true)
            {
                cboShoolYear.Enabled = true;
                cboSemester.Enabled = true;
                cboQuarter.Enabled = false;
                cboShoolYear.Text = ManagementSASI.Properties.Settings.Default.ShoolYear;
                cboSemester.Text = ManagementSASI.Properties.Settings.Default.Semeste;
            }
        }

        private void rdbQuater_Click(object sender, EventArgs e)
        {
            if (rdbQuater.Checked == true)
            {
                cboQuarter.Enabled = true;
                cboShoolYear.Enabled = false;
                cboSemester.Enabled = false;
                cboQuarter.Text = ManagementSASI.Properties.Settings.Default.Quater;
            }
        }
    }
}