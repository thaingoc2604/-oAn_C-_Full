using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Xml;
using CrystalDecisions.CrystalReports.Engine;
using System.Data.SqlClient;
using System.Threading;
using System.Configuration;
using CrystalDecisions.Shared;
using System.Linq;

namespace ManagementSASI
{
    public partial class frmListStudentToClass : DevExpress.XtraEditors.XtraForm
    {
        public frmListStudentToClass()
        {
            InitializeComponent();
        }
        Thread thread;
        static string stringconnect = ConfigurationManager.ConnectionStrings["ManagementSASI.Properties.Settings.SDGHYConnectionString"].ConnectionString;

        frmWatingServer frmw = new frmWatingServer();
        private void Waiting()
        {
            frmw.ShowDialog();
        }
        ManagementSASIDataContext db = new ManagementSASIDataContext();
        CrystalReportListStudentToClass cry = new CrystalReportListStudentToClass();
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboSemester.Text != "" && cboShoolYear.Text != "")
                {
                    thread = new Thread(new ThreadStart(Waiting));
                    thread.Start();
                    if (rdbYear.Checked == true)
                    {
                        SqlConnection sqlcon = new SqlConnection(stringconnect);
                        DataSet ds = new DataSet();
                        SqlCommand sqlcom = new SqlCommand();
                        sqlcom.CommandText = "ListStudentToClass";
                        sqlcom.CommandType = CommandType.StoredProcedure;
                        sqlcom.Connection = sqlcon;
                        DateTime dtime = DateTime.Now;

                        sqlcom.Parameters.Add(new SqlParameter("@EndDate", dtime));
                        sqlcom.Parameters.Add(new SqlParameter("@Semester", int.Parse(cboSemester.Text)));
                        sqlcom.Parameters.Add(new SqlParameter("@ShoolYear", cboShoolYear.Text));
                        SqlDataAdapter da = new SqlDataAdapter(sqlcom);
                        da.Fill(ds, "ListStudentToClass");
                        TestManageSASI testmana = new TestManageSASI();
                        ((TextObject)cry.ReportDefinition.ReportObjects["txtSemester"]).Text = "Học kì :" + cboSemester.Text + " :" + "năm học : " + cboShoolYear.Text;

                        DataTable dt = ds.Tables["ListStudentToClass"];

                        var query = from c in db.Configs
                                    select new { c.Dean, c.Rector, c.Departmentfinance, c.DepartmentTrain };
                        foreach (var item in query)
                        {
                            ((TextObject)cry.ReportDefinition.ReportObjects["txtRector"]).Text = item.Rector;
                            ((TextObject)cry.ReportDefinition.ReportObjects["txtDepartmentfinance"]).Text = item.Departmentfinance;
                            ((TextObject)cry.ReportDefinition.ReportObjects["txtDepartmentTrain"]).Text = item.DepartmentTrain;
                            ((TextObject)cry.ReportDefinition.ReportObjects["txtdean"]).Text = item.Dean;
                        }


                        try
                        {
                            ((TextObject)cry.ReportDefinition.ReportObjects["txtTotalMoneySASI"]).Text = string.Format("{0:0,0}", float.Parse(dt.Compute("Sum(MoneySASI)", string.Empty).ToString()));
                            ((TextObject)cry.ReportDefinition.ReportObjects["txtTotalAll"]).Text = string.Format("{0:0,0}", float.Parse(dt.Compute("Sum(MoneySASI)", string.Empty).ToString()));
                        }
                        catch { }
                        if (dt.Compute("Sum(MoneySASI)", string.Empty).ToString() != null && dt.Compute("Sum(MoneySASI)", string.Empty).ToString() != "")
                        {
                            ((TextObject)cry.ReportDefinition.ReportObjects["txtTotalLetter"]).Text = testmana.Standardized2(TestManageSASI.ToString(double.Parse(dt.Compute("Sum(MoneySASI)", string.Empty).ToString())));
                        }
                        cry.SetDataSource(ds);
                        thread.Abort();
                        crystalReportViewer1.ReportSource = cry;

                        ManagementSASI.Properties.Settings.Default.ShoolYear = cboShoolYear.Text;
                        ManagementSASI.Properties.Settings.Default.Semeste = cboSemester.Text;

                        ManagementSASI.Properties.Settings.Default.Save();
                    }
                    if (rdbQuater.Checked == true)
                    {
                        if (cboQuarter.Text != "")
                        {
                            SqlConnection sqlcon = new SqlConnection(stringconnect);
                            DataSet ds = new DataSet();
                            SqlCommand sqlcom = new SqlCommand();
                            sqlcom.CommandText = "ListStudentToClassQuater";
                            sqlcom.CommandType = CommandType.StoredProcedure;
                            sqlcom.Connection = sqlcon;
                            DateTime dtime = DateTime.Now;

                            sqlcom.Parameters.Add(new SqlParameter("@EndDate", dtime));
                            sqlcom.Parameters.Add(new SqlParameter("@Quater", int.Parse(cboQuarter.Text)));
                            SqlDataAdapter da = new SqlDataAdapter(sqlcom);
                            da.Fill(ds, "ListStudentToClass");
                            TestManageSASI testmana = new TestManageSASI();
                            ((TextObject)cry.ReportDefinition.ReportObjects["txtSemester"]).Text = "Quý :" + cboQuarter.Text;
                            DataTable dt = ds.Tables["ListStudentToClass"];
                            var query = from c in db.Configs
                                        select new { c.Dean, c.Rector, c.Departmentfinance, c.DepartmentTrain };
                            foreach (var item in query)
                            {
                                ((TextObject)cry.ReportDefinition.ReportObjects["txtRector"]).Text = item.Rector;
                                ((TextObject)cry.ReportDefinition.ReportObjects["txtDepartmentfinance"]).Text = item.Departmentfinance;
                                ((TextObject)cry.ReportDefinition.ReportObjects["txtDepartmentTrain"]).Text = item.DepartmentTrain;
                                ((TextObject)cry.ReportDefinition.ReportObjects["txtdean"]).Text = item.Dean;
                            }
                            try
                            {
                                ((TextObject)cry.ReportDefinition.ReportObjects["txtTotalMoneySASI"]).Text = string.Format("{0:0,0}", float.Parse(dt.Compute("Sum(MoneySASI)", string.Empty).ToString()));
                                ((TextObject)cry.ReportDefinition.ReportObjects["txtTotalAll"]).Text = string.Format("{0:0,0}", float.Parse(dt.Compute("Sum(MoneySASI)", string.Empty).ToString()));
                            }
                            catch { }
                            if (dt.Compute("Sum(MoneySASI)", string.Empty).ToString() != null && dt.Compute("Sum(PlusMoney)", string.Empty).ToString() != "")
                            {
                                ((TextObject)cry.ReportDefinition.ReportObjects["txtTotalLetter"]).Text = testmana.Standardized2(TestManageSASI.ToString(double.Parse(dt.Compute("Sum(PlusMoney)", string.Empty).ToString())));
                            }
                            cry.SetDataSource(ds);
                            thread.Abort();
                            crystalReportViewer1.ReportSource = cry;
                            ManagementSASI.Properties.Settings.Default.Quater = cboQuarter.Text;
                            ManagementSASI.Properties.Settings.Default.Save();
                        }
                        else
                        {
                            XtraMessageBox.Show("Bạn chưa nhập quý", Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation); cboQuarter.Focus();

                        }

                    }
                }
                else
                {
                    XtraMessageBox.Show("Xem lại thông tin kì học hoặc năm học", Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void frmListStudentToClass_Load(object sender, EventArgs e)
        {
            cboQuarter.Enabled = false;
            LoadShoolYear();
            //if (ManagementSASI.Properties.Settings.Default.Dean == "" || ManagementSASI.Properties.Settings.Default.Rector == "" || ManagementSASI.Properties.Settings.Default.Departmentfinance == "" || ManagementSASI.Properties.Settings.Default.DepartmentTrain == "")
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

        private void rdbYear_Click(object sender, EventArgs e)
        {
            if (rdbYear.Checked == true)
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