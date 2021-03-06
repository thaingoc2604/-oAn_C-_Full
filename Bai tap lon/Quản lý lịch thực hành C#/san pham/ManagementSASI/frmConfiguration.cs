using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using System.Threading;
using System.Xml;
using Microsoft.Win32;

namespace ManagementSASI
{
    public partial class frmConfiguration : DevExpress.XtraEditors.XtraForm
    {
        public frmConfiguration()
        {
            InitializeComponent();
        }
        private void frmconfiguration_Load(object sender, EventArgs e)
        {
            cboAuthentication.SelectedIndex = 0;
            txtNameCSDL.Text = "SDGHY";
            txtNameCSDL.Enabled = false;
            LoadNameServer();
            
        }
        private void LoadNameServer()
        {
            try
            {
                CheckForIllegalCrossThreadCalls = false;

                //DataTable dtServer = SmoApplication.EnumAvailableSqlServers();

                //if (dtServer.Rows.Count > 0)
                //{
                //    foreach (DataRow drServer in dtServer.Rows)
                //    {
                //        cboNameServer.Properties.Items.Add(drServer["Name"]);
                //    }
                //}

                RegistryKey rk = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server");
                String[] instances = (String[])rk.GetValue("InstalledInstances");
                if (instances.Length > 0)
                {
                    foreach (String element in instances)
                    {
                        if (element == "MSSQLSERVER")
                            cboNameServer.Properties.Items.Add(System.Environment.MachineName);
                        else
                            cboNameServer.Properties.Items.Add(System.Environment.MachineName + @"\" + element);
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
         
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboNameServer.SelectedItem != null && cboNameServer.SelectedItem.ToString() != "")
                {
                    Updateconfiguration();
                    XtraMessageBox.Show("Kết nối thành công.Bạn cần Reset để lấy lại cấu hình", Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Restart();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        XmlDocument xmlDoc = new XmlDocument();
        public void Updateconfiguration()
        {
           
            xmlDoc.Load(AppDomain.CurrentDomain.BaseDirectory +
                                    "..\\..\\app.config"); 
            XmlNode appSettingsNode =
               xmlDoc.SelectSingleNode("/configuration/connectionStrings");
            // Attempt to locate the requested setting.
            foreach (XmlNode childNode in appSettingsNode)
            {
                    //childNode.Attributes["connectionString"].Value = newValue;
                    if (cboAuthentication.SelectedIndex == 1)
                    {
                        childNode.Attributes["connectionString"].Value = "Data Source="+cboNameServer.Text+";Initial Catalog=SDGHY;User ID="+txtLogin.Text+";PassWord="+txtPassWord.Text+"";
                    }
                    if (cboAuthentication.SelectedIndex == 0)
                    {
                        childNode.Attributes["connectionString"].Value = "Data Source=" + cboNameServer.Text + ";Initial Catalog=SDGHY;Integrated Security=True";
                    }
            }
            xmlDoc.Save(AppDomain.CurrentDomain.BaseDirectory +
                                       
                                     "..\\..\\app.config");
            xmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);

        }

        private void cboAuthentication_TextChanged(object sender, EventArgs e)
        {
            if (cboAuthentication.SelectedIndex == 1)
            {
                txtLogin.Enabled = true;
                txtPassWord.Enabled = true;
            }
            if (cboAuthentication.SelectedIndex == 0)
            {
                txtLogin.Enabled = false;
                txtPassWord.Enabled = false;
                txtLogin.Text = "";
                txtPassWord.Text = "";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboNameServer.Text == "")
                {
                    cboNameServer.Properties.Items.Clear();
                    frmconfiguration_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}