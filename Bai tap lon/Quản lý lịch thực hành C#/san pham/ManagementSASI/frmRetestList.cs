using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using DevExpress.XtraEditors;
using System.Linq;

namespace ManagementSASI
{
    public partial class frmRetestList : DevExpress.XtraEditors.XtraForm
    {
        public frmRetestList()
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
            cboSchoolYear.Text = (DateTime.Now.Year-1) + "-" + (DateTime.Now.Year);
        }
        ManagementSASIDataContext db = new ManagementSASIDataContext();
        CrystalReportRetestList cry = new CrystalReportRetestList();
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
                sqlcom.CommandText = "RetestList";
                sqlcom.CommandType = CommandType.StoredProcedure;
                sqlcom.Connection = sqlCon;
                sqlcom.Parameters.Add(new SqlParameter("@Semester", int.Parse(cboSemester.Text)));
                sqlcom.Parameters.Add(new SqlParameter("@ShoolYear", cboSchoolYear.Text));
               
               
                SqlDataAdapter da = new SqlDataAdapter(sqlcom);
                da.Fill(ds, "RetestList");
                TestManageSASI testmana = new TestManageSASI();
                ((TextObject)cry.ReportDefinition.ReportObjects["txtSemester"]).Text = cboSemester.Text;
                ((TextObject)cry.ReportDefinition.ReportObjects["txtSchoolYear"]).Text = cboSchoolYear.Text;
                ((TextObject)cry.ReportDefinition.ReportObjects["txtDay"]).Text =DateTime.Now.Day.ToString();
                ((TextObject)cry.ReportDefinition.ReportObjects["txtMonth"]).Text = DateTime.Now.Month.ToString();
                ((TextObject)cry.ReportDefinition.ReportObjects["txtYear"]).Text = DateTime.Now.Year.ToString();
                DataTable dt = ds.Tables["RetestList"];
                ((TextObject)cry.ReportDefinition.ReportObjects["txtTong"]).Text = dt.Compute("Sum(MoneyRetake)", string.Empty).ToString();
                
                SqlDataReader sqldr = sqlcom.ExecuteReader(CommandBehavior.Default);

                while (sqldr.Read())
                {
                    ((TextObject)cry.ReportDefinition.ReportObjects["txtTienChu"]).Text = test.Standardized1(TestManageSASI.ToString(double.Parse(((TextObject)cry.ReportDefinition.ReportObjects["txtTong"]).Text)));
                }
                sqlCon.Close();
                cry.SetDataSource(ds);
                crvRetestList.ReportSource = cry;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void frmRetestList_Load(object sender, EventArgs e)
        {
            LoadShoolYear();
        }
    }
}