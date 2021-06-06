using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BankManagement
{
    public partial class frmMain : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void biAbout_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            frmAbout f = new frmAbout();
            f.ShowDialog();
            this.Cursor = Cursors.Default;
        }

        private void biHelp_Click(object sender, EventArgs e)
        {
            Program.ShowMsg("Coming soon...");
        }

        private void biRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void biExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void biQAEmu_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            CallQAEmu();
            this.Cursor = Cursors.Default;
        }

        private void biNewQAEmu_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            CallQAEmu();
            this.Cursor = Cursors.Default;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmConnect f = new frmConnect();
            if (f.ShowDialog() == DialogResult.OK)
            {
                frmLogin flg = new frmLogin();
                if (flg.ShowDialog() == DialogResult.OK)
                {
                    bool status = Shared.CurrentUser.Permit;
                    biUsers.Visible = status;
                    biNewUser.Enabled = status;
                    biRule.Enabled = status;
                    biChangePass.Visible = !status;
                    ribbonMain.RecalcLayout();
                }
                else Application.Exit();
            }
            else Application.Exit();
        }

        private void CallQAEmu()
        {
            string path = Application.StartupPath + @"\QAEmu.exe";
            if (!Program.RunExe(path)) Program.ShowMsg("Load Query Analyzer Emulator failed");
        }

        private void biNewAcc_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            frmNewAcc f = new frmNewAcc();
            f.ShowDialog();
            this.Cursor = Cursors.Default;
        }

        private void biAccs_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            frmAccs f = new frmAccs(this);
            f.ClientSize = this.ClientSize;
            f.Show();
            this.Cursor = Cursors.Default;
        }

        private void biTypes_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            frmAccTypes f = new frmAccTypes();
            f.ShowDialog();
            this.Cursor = Cursors.Default;
        }

        private void biNewUser_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            frmNewUser f = new frmNewUser();
            f.ShowDialog();
            this.Cursor = Cursors.Default;
        }

        private void biBanks_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            frmBank f = new frmBank();
            f.ShowDialog();
            this.Cursor = Cursors.Default;
        }

        private void biUsers_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            frmUser f = new frmUser();
            f.ShowDialog();
            this.Cursor = Cursors.Default;
        }

        private void biChangePass_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            frmChangePass f = new frmChangePass();
            f.ShowDialog();
            this.Cursor = Cursors.Default;
        }

        private void biRule_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            frmRule f = new frmRule();
            f.ShowDialog();
            this.Cursor = Cursors.Default;
        }

        private void biSend_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            frmSend f = new frmSend();
            f.ShowDialog();
            this.Cursor = Cursors.Default;
        }

        private void biWithdraw_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            frmWithdraw f = new frmWithdraw();
            f.ShowDialog();
            this.Cursor = Cursors.Default;
        }
    }
}