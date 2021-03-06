using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Microsoft.Win32;
using Microsoft.SqlServer.Management.Smo;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

namespace ManagementSASI
{
    public partial class frmBackup : DevExpress.XtraEditors.XtraForm
    {
        public frmBackup()
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
        public  void BackupDatabase(string databaseName, string path)
        {
            try
            {
                sqlcon = new SqlConnection(stringconnect);
                Connect();
                SqlCommand cmd = new SqlCommand("Backup database " + databaseName + " to disk = N'" + path + "\\" + databaseName + ".BAK'", sqlcon);
                cmd.ExecuteNonQuery();
                sqlcon.Close();
                XtraMessageBox.Show("Sao lưu thành công", Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
      
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            if (folderBrowser.ShowDialog() == DialogResult.OK)
                txtPart.Text = folderBrowser.SelectedPath;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                BackupDatabase("ManagementSASI", txtPart.Text);
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show(ex.Message, Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmBackup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                btnOK_Click(sender, e);
            }
            if (e.KeyCode == Keys.F3)
            {
               btnClose_Click(sender, e);
            }
        }

        private void frmBackup_Load(object sender, EventArgs e)
        {

        }
    }
}