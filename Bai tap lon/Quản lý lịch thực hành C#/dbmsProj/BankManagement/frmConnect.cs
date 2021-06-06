using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace BankManagement
{
    public partial class frmConnect : DevComponents.DotNetBar.Office2007Form
    {
        public frmConnect()
        {
            InitializeComponent();
        }

        private void frmConnect_Load(object sender, EventArgs e)
        {
            LoadConfig();
        }

        private void chkIntegrated_CheckedChanged(object sender, EventArgs e)
        {
            txtUID.Enabled = !(chkIntegrated.Checked);
            txtPassword.Enabled = !(chkIntegrated.Checked);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            string server = txtServer.Text;
            if (chkStartService.Checked && (server == "." || server == "(local)"))
                if (!Program.StartSQLService())
                {
                    Program.ShowMsg("Start MSSQL Service failed", true);
                    this.Cursor = Cursors.Default;
                    return;
                }
            
            string db = txtDatabase.Text;
            bool integrated = chkIntegrated.Checked;
            string uid = txtUID.Text;
            string pwd = txtPassword.Text;
            dbCn Cn = new dbCn();
            if (integrated) Cn.BuildCnStr(server, db);
            else Cn.BuildCnStr(server, db, uid, pwd);
            Cn.Connect();
            if (Cn.CnStatus)
            {
                Shared.dbConnection = Cn;
                SaveConfig(server, db, uid, integrated);
                this.DialogResult = DialogResult.OK;
            }
            else this.DialogResult = DialogResult.Cancel;

            this.Cursor = Cursors.Default;
        }

    #region Config IO
        private void LoadConfig()
        {
            string configPath = Application.StartupPath + @"\BankCnInfo.xml";
            if (File.Exists(configPath))
            {
                DataTable dt = new DataTable();
                try
                {
                    dt.ReadXml(configPath);
                    if (dt == null || dt.Rows.Count == 0) throw new Exception("Load config file failed");
                    txtServer.Text = dt.Rows[0]["Server"].ToString();
                    txtDatabase.Text = dt.Rows[0]["Database"].ToString();
                    txtUID.Text = dt.Rows[0]["UID"].ToString();
                    chkIntegrated.Checked = bool.Parse(dt.Rows[0]["Integrated"].ToString());
                }
                catch (Exception ex)
                {
                    Program.ShowMsg(ex.Message, true);
                }
            }
        }

        private void SaveConfig(string server, string db, string uid, bool integrated)
        {
            string configPath = Application.StartupPath + @"\BankCnInfo.xml";
            if (File.Exists(configPath)) File.Delete(configPath);
            DataTable dt = new DataTable("CnInfo");
            dt.Columns.Add("Server");
            dt.Columns.Add("Database");
            dt.Columns.Add("UID");
            dt.Columns.Add("Integrated");
            DataRow dr = dt.NewRow();
            dr["Server"] = server;
            dr["Database"] = db;
            dr["UID"] = uid;
            dr["Integrated"] = integrated;
            dt.Rows.Add(dr);
            try
            {
                dt.WriteXml(configPath, XmlWriteMode.WriteSchema);
            }
            catch (Exception ex)
            {
                Program.ShowMsg(ex.Message, true);
            }
        }
    #endregion
    }
}