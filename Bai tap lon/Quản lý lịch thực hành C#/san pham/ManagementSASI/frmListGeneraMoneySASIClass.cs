using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using System.Linq;
using CrystalDecisions.CrystalReports.Engine;
using System.Threading;
using System.Configuration;
using System.Xml;
using CrystalDecisions.Shared;

namespace ManagementSASI
{
    public partial class frmListGeneraMoneySASIClass : DevExpress.XtraEditors.XtraForm
    {
        public frmListGeneraMoneySASIClass()
        {
            InitializeComponent();
        }
        Thread thread;

        ManagementSASIDataContext db = new ManagementSASIDataContext();

        static string stringconnect = ConfigurationManager.ConnectionStrings["ManagementSASI.Properties.Settings.SDGHYConnectionString"].ConnectionString;

        private void LoadShoolYear()
        {
            DateTime dt = DateTime.Now;
            for (int i = dt.Year - 2; i < dt.Year + 1; i++)
            {
                cboShoolYear.Properties.Items.Add(i + "-" + (i + 1));
                cboShoolYear.SelectedIndex = 2;
            }
        }
        private void frmListGeneraMoneySASIClass_Load(object sender, EventArgs e)
        {
            LoadShoolYear();
            
           cboShoolYear.Text= ManagementSASI.Properties.Settings.Default.ShoolYear ;
           cboSemester.Text=  ManagementSASI.Properties.Settings.Default.Semeste ;
           cboQuarter.Text = ManagementSASI.Properties.Settings.Default.Quater;
        }
        

        frmWatingServer frmw = new frmWatingServer();
        private void Waiting()
        {
            frmw.ShowDialog();
        }

        CrystalReportGeneraMoneySASIClass cry = new CrystalReportGeneraMoneySASIClass();
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
                        //thread = new Thread(new ThreadStart(Waiting));
                        //thread.Start();
                        //groupControl1.Text = "Thông tin tổng hợp sinh viên học cải thiện " + "  ( Chú ý thời gian bắt đầu đăng ký và thời gian kết thúc đăng ký )";
                        SqlConnection sqlcon = new SqlConnection(stringconnect);
                        DataSet ds = new DataSet();
                        SqlCommand sqlcom = new SqlCommand();
                        sqlcom.CommandText = "GeneraMoneySASIClass";
                        sqlcom.CommandType = CommandType.StoredProcedure;
                        sqlcom.Connection = sqlcon;
                        DateTime dtime = DateTime.Now;

                        sqlcom.Parameters.Add(new SqlParameter("@EndDate", dtime));
                        sqlcom.Parameters.Add(new SqlParameter("@Semester", cboSemester.Text));
                        sqlcom.Parameters.Add(new SqlParameter("@ShoolYear", cboShoolYear.Text));
                        SqlDataAdapter da = new SqlDataAdapter(sqlcom);
                        da.Fill(ds, "GeneralMoneySASIClass");
                        TestManageSASI testmana = new TestManageSASI();
                        ((TextObject)cry.ReportDefinition.ReportObjects["txtSemester"]).Text = "Học kì :" + cboSemester.Text + " :" + "năm học : " + cboShoolYear.Text;
                        DataTable dt = ds.Tables["GeneralMoneySASIClass"];
                        try{
                        ((TextObject)cry.ReportDefinition.ReportObjects["txtTotalAll"]).Text =string.Format("{0:0,0}", float.Parse( dt.Compute("sum(NumberMoney)", string.Empty).ToString()));
                        }
                        catch { }
                        var query = from c in db.Configs
                                    select new { c.Dean, c.Trainbueau };
                        foreach (var item in query)
                        {
                            ((TextObject)cry.ReportDefinition.ReportObjects["txtdean"]).Text = item.Dean;
                            ((TextObject)cry.ReportDefinition.ReportObjects["txtTrainbueau"]).Text = item.Trainbueau;
                        }
                        cry.SetDataSource(ds);
                        //thread.Abort();
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
                        sqlcom.CommandText = "GeneraMoneySASIClassQuater";
                        sqlcom.CommandType = CommandType.StoredProcedure;
                        sqlcom.Connection = sqlcon;
                        DateTime dtime = DateTime.Now;

                        sqlcom.Parameters.Add(new SqlParameter("@EndDate", dtime));
                        sqlcom.Parameters.Add(new SqlParameter("@Quater", cboQuarter.Text)); ;
                        SqlDataAdapter da = new SqlDataAdapter(sqlcom);
                        da.Fill(ds, "GeneralMoneySASIClass");
                        TestManageSASI testmana = new TestManageSASI();
                        ((TextObject)cry.ReportDefinition.ReportObjects["txtSemester"]).Text = "Quý :" + cboQuarter.Text;
                        DataTable dt = ds.Tables["GeneralMoneySASIClass"];
                       try{
                        ((TextObject)cry.ReportDefinition.ReportObjects["txtTotalAll"]).Text =string.Format("{0:0,0}", float.Parse( dt.Compute("sum(NumberMoney)", string.Empty).ToString()));
                       }
                       catch { }

                       var query = from c in db.Configs
                                   select new { c.Dean,c.Trainbueau};
                       foreach (var item in query)
                       {
                           ((TextObject)cry.ReportDefinition.ReportObjects["txtdean"]).Text =item.Dean;
                           ((TextObject)cry.ReportDefinition.ReportObjects["txtTrainbueau"]).Text = item.Trainbueau;
                       }
                         
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
                XtraMessageBox.Show(ex.Message, Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnToWord_Click(object sender, EventArgs e)
        {
            SaveFileDialog sava = new SaveFileDialog();
            if (sava.ShowDialog() == DialogResult.OK)
            {
                cry.ExportToDisk(ExportFormatType.WordForWindows, sava.FileName + ".doc");
            }
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

        private void rdbQuater_CheckedChanged(object sender, EventArgs e)
        {
            cboQuarter.Enabled = true;
            cboSemester.Enabled = false;
            cboShoolYear.Enabled = false;
        }

        private void rdbSchollYear_CheckedChanged(object sender, EventArgs e)
        {
            cboQuarter.Enabled = false;
            cboSemester.Enabled = true;
            cboShoolYear.Enabled = true;
        }
    }
}