using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;


using CrystalDecisions.CrystalReports.Engine;
using System.Xml;
using System.Threading;
using CrystalDecisions.Shared;
namespace ManagementSASI
{
    public partial class frmListStudentMoneySI : DevExpress.XtraEditors.XtraForm
    {
        public frmListStudentMoneySI()
        {
            InitializeComponent();
        }
      
        ManagementSASIDataContext db = new ManagementSASIDataContext();

        static string stringconnect = ConfigurationManager.ConnectionStrings["ManagementSASI.Properties.Settings.SDGHYConnectionString"].ConnectionString;
       
        private void frmListStudentMoneySI_Load(object sender, EventArgs e)
        {
            LoadShoolYear();
            cboQuarter.Enabled = false;
            //if (ManagementSASI.Properties.Settings.Default.Dean == "" || ManagementSASI.Properties.Settings.Default.Trainbueau== "")
            //{
            //    XtraMessageBox.Show("Bạn chưa cấu hình thông tin chung", Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    this.Close();
            //    frmConfig t = new frmConfig();
                
            //    t.ShowDialog();
            //}
            cboShoolYear.Text = ManagementSASI.Properties.Settings.Default.ShoolYear;
            cboSemester.Text = ManagementSASI.Properties.Settings.Default.Semeste;
            
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
        ErrorProvider erro = new ErrorProvider();
        CrystalReportStudentSI cry = new CrystalReportStudentSI();
        private void btnPrint_Click(object sender, EventArgs e)
        {


            groupControl1.Text = "Thông tin tổng hợp sinh viên học cải thiện " + "  ( Chú ý thời gian bắt đầu đăng ký và thời gian kết thúc đăng ký )";
            if (rdbQuater.Checked == true)
            {
                SqlConnection sqlcon = new SqlConnection(stringconnect);
                DataSet ds = new DataSet();
                SqlCommand sqlcom = new SqlCommand();
                sqlcom.CommandText = "ListStudentMoneySIQuater";
                sqlcom.CommandType = CommandType.StoredProcedure;
                sqlcom.Connection = sqlcon;
                sqlcom.Parameters.Add(new SqlParameter("@EndDate", DateTime.Now));
                sqlcom.Parameters.Add(new SqlParameter("@Quater", int.Parse(cboQuarter.Text)));
                SqlDataAdapter da = new SqlDataAdapter(sqlcom);
                da.Fill(ds, "ListStudentMoneySIQuater");
                TestManageSASI testmana = new TestManageSASI();
                ((TextObject)cry.ReportDefinition.ReportObjects["txtSemester"]).Text = "Quý :" + cboQuarter.Text;

                DataTable dt = ds.Tables["ListStudentMoneySIQuater"];
                var query = from c in db.Configs
                            select new { c.Dean, c.Trainbueau };
                foreach (var item in query)
                {
                    ((TextObject)cry.ReportDefinition.ReportObjects["txtdean"]).Text = item.Dean;
                    ((TextObject)cry.ReportDefinition.ReportObjects["txtTrainbueau"]).Text = item.Trainbueau;
                }


                try
                {
                    ((TextObject)cry.ReportDefinition.ReportObjects["txtTotalAll"]).Text = string.Format("{0:0,0}", float.Parse(dt.Compute("sum(MoneySI)", string.Empty).ToString()));
                }
                catch { }
                cry.SetDataSource(ds);
                crystalReportViewer1.ReportSource = cry;
                ManagementSASI.Properties.Settings.Default.Quater = cboQuarter.Text;
                ManagementSASI.Properties.Settings.Default.Save();
            }
            if (rdbSchollYear.Checked == true)
            {
                SqlConnection sqlcon = new SqlConnection(stringconnect);
                DataSet ds = new DataSet();
                SqlCommand sqlcom = new SqlCommand();
                sqlcom.CommandText = "ListStudentMoneySI";
                sqlcom.CommandType = CommandType.StoredProcedure;
                sqlcom.Connection = sqlcon;
                sqlcom.Parameters.Add(new SqlParameter("@Semester", cboSemester.Text));
                sqlcom.Parameters.Add(new SqlParameter("@ShoolYear", cboShoolYear.Text));
                sqlcom.Parameters.Add(new SqlParameter("@EndDate", DateTime.Now.ToString()));
                SqlDataAdapter da = new SqlDataAdapter(sqlcom);
                da.Fill(ds, "ListMoneyStudentSI");
                TestManageSASI testmana = new TestManageSASI();

                var query = from c in db.Configs
                            select new { c.Dean, c.Trainbueau };
                foreach (var item in query)
                {
                    ((TextObject)cry.ReportDefinition.ReportObjects["txtdean"]).Text = item.Dean;
                    ((TextObject)cry.ReportDefinition.ReportObjects["txtTrainbueau"]).Text = item.Trainbueau;
                }
                ((TextObject)cry.ReportDefinition.ReportObjects["txtSemester"]).Text = "Học kì :" + cboSemester.Text + " :" + "năm học : " + cboShoolYear.Text;

                DataTable dt = ds.Tables["ListMoneyStudentSI"];
                try
                {
                    ((TextObject)cry.ReportDefinition.ReportObjects["txtTotalAll"]).Text = string.Format("{0:0,0}", float.Parse(dt.Compute("sum(MoneySI)", string.Empty).ToString()));

                }
                catch { }
                cry.SetDataSource(ds);
                crystalReportViewer1.ReportSource = cry;
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

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }


    }
}