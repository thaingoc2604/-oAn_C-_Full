using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Configuration;
using CrystalDecisions.CrystalReports.Engine;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ManagementSASI
{
    public partial class frmListMoneySASI : DevExpress.XtraEditors.XtraForm
    {
        public frmListMoneySASI()
        {
            InitializeComponent();
        }
        private void LoadShoolYear()
        {
            DateTime dt = DateTime.Now;
            for (int i = dt.Year - 2; i < dt.Year + 1; i++)
            {
                cboSchoolYear.Properties.Items.Add(i + "-" + (i + 1));
                cboSchoolYear.SelectedIndex = 2;
            }
            cboSchoolYear.Text = (DateTime.Now.Year - 1) + "-" + (DateTime.Now.Year);
        }
        ManagementSASIDataContext db = new ManagementSASIDataContext();
        CrystalReportListMoneySASI cry = new CrystalReportListMoneySASI();
        TestManageSASI test = new TestManageSASI();
        static string stringconnect = ConfigurationManager.ConnectionStrings["ManagementSASI.Properties.Settings.SDGHYConnectionString"].ConnectionString;
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection sqlCon = new SqlConnection(stringconnect);
                DataSet ds = new DataSet();
                sqlCon.Open();
                SqlCommand sqlcom = new SqlCommand();
                sqlcom.CommandText = "ListMoneySASI";
                sqlcom.CommandType = CommandType.StoredProcedure;
                sqlcom.Connection = sqlCon;
                sqlcom.Parameters.Add(new SqlParameter("@Semester", int.Parse(cboSemester.Text)));
                sqlcom.Parameters.Add(new SqlParameter("@ShoolYear", cboSchoolYear.Text));


                SqlDataAdapter da = new SqlDataAdapter(sqlcom);
                da.Fill(ds, "ListMoneySASI");
                TestManageSASI testmana = new TestManageSASI();
                ((TextObject)cry.ReportDefinition.ReportObjects["txtSemester"]).Text = "Học kì :" + cboSemester.Text + " :" + "năm học : " + cboSchoolYear.Text;
                ((TextObject)cry.ReportDefinition.ReportObjects["txtDay"]).Text = DateTime.Now.Day.ToString();
                ((TextObject)cry.ReportDefinition.ReportObjects["txtMonth"]).Text = DateTime.Now.Month.ToString();
                ((TextObject)cry.ReportDefinition.ReportObjects["txtYear"]).Text = DateTime.Now.Year.ToString();
                DataTable dt = ds.Tables["ListMoneySASI"];
                try{
                ((TextObject)cry.ReportDefinition.ReportObjects["txtTong"]).Text =string.Format("{0:0,0}", float.Parse( dt.Compute("Sum(MoneyNumber)", string.Empty).ToString()));
                }
                catch { }
                SqlDataReader sqldr = sqlcom.ExecuteReader(CommandBehavior.Default);

                while (sqldr.Read())
                {
                    ((TextObject)cry.ReportDefinition.ReportObjects["txtTienChu"]).Text = test.Standardized1(TestManageSASI.ToString(double.Parse(((TextObject)cry.ReportDefinition.ReportObjects["txtTong"]).Text)));
                }
                sqlCon.Close();
                cry.SetDataSource(ds);
                crvListMoneySASI.ReportSource = cry;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void frmListMoneySASI_Load(object sender, EventArgs e)
        {
            LoadShoolYear();
        }
    }
}