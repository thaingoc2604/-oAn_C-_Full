using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BankManagement
{
    public partial class frmNewUser : DevComponents.DotNetBar.Office2007Form
    {
        public frmNewUser()
        {
            InitializeComponent();
        }

        #region Code
        private string Confirm()
        {
            if (txtUID.Text == "" || txtPWD.Text == "" || txtConfirm.Text == "")
                return "Chưa điền đủ dữ liệu!!!";

            if (txtUID.Text.IndexOf(' ') != -1)
                return "Username không được có khoảng trắng";

            if (txtPWD.Text != txtConfirm.Text)
                return "Chưa confirm password!!!";

            if (txtPWD.Text.Length < 6)
                return "Password nên có ít nhất 6 ký tự!!!";

            return "";
        }

        private void ClearForm()
        {
            Program.Clear(txtUID, txtPWD, txtConfirm);
            chkPermit.Checked = false;
            txtUID.Focus();
        }
        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            string err = "";
            err = Confirm();
            if(err!="")
            {
                Program.ShowMsg(err, true);
                this.Cursor = Cursors.Default;
                return;
            }

            string uid = txtUID.Text;
            string pwd = txtPWD.Text;
            bool permit = chkPermit.Checked;
            User u = new User(uid, pwd, permit);
            err = "";
            if (!u.Add(ref err))
            {
                Program.ShowMsg(err, true);
                this.Cursor = Cursors.Default;
                return;
            }
            ClearForm();
            this.Cursor = Cursors.Default;
        }
    }
}