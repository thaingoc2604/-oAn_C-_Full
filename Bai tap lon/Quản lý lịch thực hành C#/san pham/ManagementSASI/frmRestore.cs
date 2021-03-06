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

namespace ManagementSASI
{
    public partial class frmRestore : DevExpress.XtraEditors.XtraForm
    {
        public frmRestore()
        {
            InitializeComponent();
        }
        static string stringconnect = ConfigurationManager.ConnectionStrings["ManagementSASI.Properties.Settings.ManagementSASIConnectionString"].ConnectionString;
        SqlConnection sqlcon;
        private void Connect()
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
        }
     
        private  void RestoreDatabase(string databaseName, string path)
        {
            try
            {

               sqlcon = new SqlConnection(stringconnect);

                Connect();
                sqlcon.ChangeDatabase("master");

                SqlCommand cmd = new SqlCommand("RESTORE DATABASE " + databaseName + " FROM  DISK = N'" + path + "'WITH  FILE = 1 ,  REPLACE,  STATS = 10", sqlcon);
                cmd.ExecuteNonQuery();
                sqlcon.ChangeDatabase("ManagementSASI");
               
                XtraMessageBox.Show("Phục hồi thành công", Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("phục hồi lỗi :" + ex.Message, Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            RestoreDatabase("ManagementSASI", txtPart.Text);
        }

        private void btnSelectpart_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
                txtPart.Text = openFile.FileName;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}