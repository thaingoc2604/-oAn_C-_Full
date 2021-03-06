using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Configuration;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using System.Threading;
using System.Xml;
using System.Linq;
using CrystalDecisions.Shared;

namespace ManagementSASI
{
    public partial class frmListGeneraMoneySASITeacher : DevExpress.XtraEditors.XtraForm
    {
        public frmListGeneraMoneySASITeacher()
        {
            InitializeComponent();
        }
        //  Thread thread;
        ManagementSASIDataContext db = new ManagementSASIDataContext();
        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
        CrystalReportGeneraMoneySASITeacher cry = new CrystalReportGeneraMoneySASITeacher();
        static string stringconnect = ConfigurationManager.ConnectionStrings["ManagementSASI.Properties.Settings.SDGHYConnectionString"].ConnectionString;
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                 //thread = new Thread(new ThreadStart(Waiting));
                // thread.Start();
                // groupControl1.Text = groupControl1.Text + "  ( Chú ý thời gian bắt đầu đăng ký và thời gian kết thúc đăng ký )";
                string moneyExam = "", moneyProctor = "";
                var t = from c in db.Configs
                        select new { c.MoneyExam, c.MoneyProctor };
                foreach (var tt in t)
                {
                    moneyExam = tt.MoneyExam;
                    moneyProctor = tt.MoneyProctor;
                    //XtraMessageBox.Show(moneyExam + "," + moneyProctor);
                }
                SqlConnection sqlCon = new SqlConnection(stringconnect);
                DataSet ds = new DataSet();
                SqlCommand sqlCom = new SqlCommand();
                sqlCom.CommandText = "GeneraMoneySASITeacher";
                sqlCom.CommandType = CommandType.StoredProcedure;
                sqlCom.Connection = sqlCon;
                sqlCom.Parameters.Add(new SqlParameter("@Semester", int.Parse(cboSemester.Text)));
                sqlCom.Parameters.Add(new SqlParameter("@ShoolYear", cboShoolYear.Text));
                sqlCom.Parameters.Add(new SqlParameter("@MoneyProctor", int.Parse(moneyProctor)));
                sqlCom.Parameters.Add(new SqlParameter("@MoneyExam", int.Parse(moneyExam)));
                // sqlcom.Parameters.Add(new SqlParameter("@ShoolYear", cboShoolYear.Text));

                SqlDataAdapter da = new SqlDataAdapter(sqlCom);
                da.Fill(ds, "GeneraMoneySASITeacher");
                TestManageSASI testmana = new TestManageSASI();
                ((TextObject)cry.ReportDefinition.ReportObjects["txtSemester"]).Text = cboSemester.Text;
                ((TextObject)cry.ReportDefinition.ReportObjects["txtSchoolYear"]).Text = cboShoolYear.Text;
                var t1 = from c in db.Configs
                        select new { c.Rector,c.Departmentfinance,c.DepartmentTrain,c.Dean };
                foreach (var tt in t1)
                {
                    ((TextObject)cry.ReportDefinition.ReportObjects["txtRector"]).Text = tt.Rector;
                    ((TextObject)cry.ReportDefinition.ReportObjects["txtDepartmentfinance"]).Text =tt.Departmentfinance;
                    ((TextObject)cry.ReportDefinition.ReportObjects["txtDepartmentTrain"]).Text = tt.DepartmentTrain;
                    ((TextObject)cry.ReportDefinition.ReportObjects["txtDean"]).Text = tt.Dean;
                    //XtraMessageBox.Show(moneyExam + "," + moneyProctor);
                }
               

                DataTable dt = ds.Tables["GeneraMoneySASITeacher"];
                try
                {
                   
                   
                   // ((TextObject)cry.ReportDefinition.ReportObjects["txtTotalMoneySASI"]).Text = Convert.ToString(dt.Compute("Sum(MoneySASI)", string.Empty).ToString());

                ((TextObject)cry.ReportDefinition.ReportObjects["txtTotalMoneySASI"]).Text = string.Format("{0:0,0}", float.Parse(dt.Compute("Sum(MoneySASI)", string.Empty).ToString()));
                ((TextObject)cry.ReportDefinition.ReportObjects["txtTotalMoneyProctor"]).Text = string.Format("{0:0,0}", float.Parse(dt.Compute("Sum(MoneyProctor)", string.Empty).ToString()));
                ((TextObject)cry.ReportDefinition.ReportObjects["txtTotalMoneyExam"]).Text = string.Format("{0:0,0}", float.Parse(dt.Compute("Sum(MoneyExam)", string.Empty).ToString()));
                ((TextObject)cry.ReportDefinition.ReportObjects["txtTotalAll"]).Text = string.Format("{0:0,0}", float.Parse(dt.Compute("Sum(PlusMoney)", string.Empty).ToString()));
                ((TextObject)cry.ReportDefinition.ReportObjects["txtTotalAll1"]).Text = string.Format("{0:0,0}", float.Parse(dt.Compute("Sum(PlusMoney)", string.Empty).ToString()));
                


                //((TextObject)cry.ReportDefinition.ReportObjects["txtMoneyToTeacher"]).Text = dt.Compute("Sum(PlusMoney)", "row_number").ToString();

                }
                catch { }
                if (dt.Compute("Sum(PlusMoney)", string.Empty).ToString() != null && dt.Compute("Sum(PlusMoney)", string.Empty).ToString() != "")
                {
                    
                    ((TextObject)cry.ReportDefinition.ReportObjects["txtTotalLetter"]).Text = testmana.Standardized2(TestManageSASI.ToString(double.Parse(dt.Compute("Sum(PlusMoney)", string.Empty).ToString())));
                }
             
                cry.SetDataSource(ds);
                
                crystalReportViewer1.ReportSource = cry;

                ManagementSASI.Properties.Settings.Default.ShoolYear = cboShoolYear.Text;
                ManagementSASI.Properties.Settings.Default.Semeste = cboSemester.Text;
                ManagementSASI.Properties.Settings.Default.Save();
            //}
            //catch { }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        frmWatingServer frmw = new frmWatingServer();
        private void Waiting()
        {
            frmw.ShowDialog();
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
        private void frmListGeneraMoneySASITeacher_Load(object sender, EventArgs e)
        {
            LoadShoolYear();
            //if (ManagementSASI.Properties.Settings.Default.ShoolYear == "" || ManagementSASI.Properties.Settings.Default.ShoolYear == "")
            //{
            //    XtraMessageBox.Show("Bạn chưa cấu hình thông tin chung", Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    this.Close();
            //    frmConfig t = new frmConfig();
            //    t.ShowDialog();
            //}
            cboShoolYear.Text = ManagementSASI.Properties.Settings.Default.ShoolYear;
            cboSemester.Text = ManagementSASI.Properties.Settings.Default.Semeste;
        }

        private void btnToWord_Click(object sender, EventArgs e)
        {
        //    SaveFileDialog sava = new SaveFileDialog();
        //    if (sava.ShowDialog() == DialogResult.OK)
        //    {
        //        cry.ExportToDisk(ExportFormatType.WordForWindows, sava.FileName + ".doc");
        //    }
        }
    }
}