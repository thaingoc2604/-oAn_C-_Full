using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BankManagement
{
    public partial class frmLogin : DevComponents.DotNetBar.Office2007Form
    {
        public frmLogin()
        {
            InitializeComponent();

            txtUsername.Text = "06hc079";
            txtPwd.Text = "06hc079";
        }

        private void txtPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter) btnLogin_Click(sender, e);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            string uid = txtUsername.Text;
            string pwd = txtPwd.Text;
            User curUser = new User(uid, pwd);
            if (!curUser.Login())
            {
                Program.ShowMsg("Đăng nhập thất bại");
                txtPwd.Clear();
                txtPwd.Focus();
            }
            else
            {
                //Set current user and allRules
                Shared.CurrentUser = curUser;

                Rule r = new Rule();
                Shared.allRules = r;

                this.DialogResult = DialogResult.OK;
            }
            this.Cursor = Cursors.Default;
        }
    }
}