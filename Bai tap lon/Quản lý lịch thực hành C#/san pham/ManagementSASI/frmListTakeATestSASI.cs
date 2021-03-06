using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Threading;
using System.Configuration;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using System.Xml;
using System.Linq;
using CrystalDecisions.Shared;

namespace ManagementSASI
{
    public partial class frmListTakeATestSASI : DevExpress.XtraEditors.XtraForm
    {
        public frmListTakeATestSASI()
        {
            InitializeComponent();//Download source code tại Sharecode.vn
        }
        private void LoadLookUpEditOfSASIClass()
        {
            var query= from c in db.SASIClasses
                       join h in db.StudentToRegisters
                       on new {c.SASIClassID}
                       equals new {h.SASIClassID}
                       select new {c.SASIClassID,c.SASIClassName};
            lueSASIClass.Properties.DataSource = query.Distinct();
        }
        Thread thread;

        ManagementSASIDataContext db = new ManagementSASIDataContext();

        static string stringconnect = ConfigurationManager.ConnectionStrings["ManagementSASI.Properties.Settings.SDGHYConnectionString"].ConnectionString;

        frmWatingServer frmw = new frmWatingServer();
        private void Waiting()
        {
            frmw.ShowDialog();
        }
        
        private void frmListTakeATestSASI_Load(object sender, EventArgs e)
        {
            LoadLookUpEditOfSASIClass();
            txtHeader.Text = ManagementSASI.Properties.Settings.Default.HeaderText;
            
            
        }

        CrystalReportListTakeATestSASI cry = new CrystalReportListTakeATestSASI();
        ErrorProvider erro = new ErrorProvider();
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (lueSASIClass.Text == "")
                {
                    erro.SetError(lueSASIClass, "Bạn chưa chọn lớp học lại");
                }
                else
                {
                    erro.Clear();

                    thread = new Thread(new ThreadStart(Waiting));
                    thread.Start();
                   // groupControl1.Text = "Thông tin danh sách dự thi kết thúc học phần" + "  ( Chú ý thời gian bắt đầu đăng ký và thời gian kết thúc đăng ký )";
                    SqlConnection sqlcon = new SqlConnection(stringconnect);
                    DataSet ds = new DataSet();
                    SqlCommand sqlcom = new SqlCommand();
                    sqlcom.CommandText = "ListTakeATestSASI";
                    sqlcom.CommandType = CommandType.StoredProcedure;
                    sqlcom.Connection = sqlcon;
                    sqlcom.Parameters.Add(new SqlParameter("@SASIClassName", lueSASIClass.Text));
                    sqlcom.Parameters.Add(new SqlParameter("@Semester", txtSemester.Text));
                    sqlcom.Parameters.Add(new SqlParameter("@ShoolYear", txtShoolYear.Text));
                    SqlDataAdapter da = new SqlDataAdapter(sqlcom);
                    da.Fill(ds, "ListTakeATestSASI");
                  
                    TestManageSASI testmana = new TestManageSASI();
                    ((TextObject)cry.ReportDefinition.ReportObjects["txtSemester"]).Text = txtSemester.Text;
                    ((TextObject)cry.ReportDefinition.ReportObjects["txtSchoolYear"]).Text = txtShoolYear.Text;
                    ((TextObject)cry.ReportDefinition.ReportObjects["txtBasis"]).Text = cboBasis.Text;
                    ((TextObject)cry.ReportDefinition.ReportObjects["txtDepartmentExam"]).Text = cboDepartmentExam.Text;
                    ((TextObject)cry.ReportDefinition.ReportObjects["txtlocation"]).Text = txtlocation.Text;
                    ((TextObject)cry.ReportDefinition.ReportObjects["txtExamDay"]).Text = DateTime.Parse(dtpExamDay.Text).ToShortDateString();
                    ((TextObject)cry.ReportDefinition.ReportObjects["txtExamTime"]).Text = DateTime.Parse(dtpExamTime.Text).ToShortTimeString();
                    ((TextObject)cry.ReportDefinition.ReportObjects["txtheader"]).Text = txtHeader.Text.ToUpper();
                    DataTable dt = ds.Tables["ListTakeATestSASI"];
                    try{
                    ((TextObject)cry.ReportDefinition.ReportObjects["txtTotal"]).Text =string.Format("{0:0,0}", float.Parse( dt.Compute("sum(MoneySASI)", string.Empty).ToString()));
                    }
                    catch { }
                    if (dt.Compute("sum(MoneySASI)", string.Empty).ToString() != null && dt.Compute("sum(MoneySASI)", string.Empty).ToString() != "")
                    {
                        ((TextObject)cry.ReportDefinition.ReportObjects["txtTotalLeter"]).Text = testmana.Standardized2(TestManageSASI.ToString(double.Parse(dt.Compute("sum(MoneySASI)", string.Empty).ToString())));
                    }
                    var query = from c in db.Configs
                                select new { c.Dean, c.Trainbueau };
                    foreach (var item in query)
                    {
                        ((TextObject)cry.ReportDefinition.ReportObjects["txtdean"]).Text = item.Dean;
                        ((TextObject)cry.ReportDefinition.ReportObjects["txtTrainbueau"]).Text = item.Trainbueau;
                    } cry.SetDataSource(ds);
                    thread.Abort();
                    crystalReportViewer1.ReportSource = cry;
                
                    ManagementSASI.Properties.Settings.Default.HeaderText = txtHeader.Text;
                    ManagementSASI.Properties.Settings.Default.Save();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void lueSASIClass_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var query = from c in db.SASIClasses
                            select new { c.SASIClassID, c.Semester, c.ShoolYear };
                foreach (var item in query)
                {
                    if (item.SASIClassID ==int.Parse( lueSASIClass.EditValue.ToString()))
                    {
                        txtSemester.Text = item.Semester.ToString();
                        txtShoolYear.Text = item.ShoolYear;
                    }
                }
                if (lueSASIClass.Text != "")
                {
                    erro.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

     
    }
}