using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BankManagement
{
    public partial class frmChangePass : DevComponents.DotNetBar.Office2007Form
    {
        public frmChangePass()
        {
            InitializeComponent();
        }

        #region Code
        private string Confirm()
        {
            if (txtPWD.Text == "" || txtConfirm.Text == "")
                return "Chưa điền đủ dữ liệu!!!";

            if (txtPWD.Text != txtConfirm.Text)
                return "Chưa confirm password!!!";

            if (txtPWD.Text.Length < 6)
                return "Password nên có ít nhất 6 ký tự!!!";

            return "";
        }

        private void ClearForm()
        {
            Program.Clear(txtPWD, txtConfirm);
            txtPWD.Focus();
        }
        #endregion

        private void frmChangePass_Load(object sender, EventArgs e)
        {
            txtUID.Text = Shared.CurrentUser.Username;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            string err = Confirm();
            if (err != "")
            {
                Program.ShowMsg(err, true);
                this.Cursor = Cursors.Default;
                return;
            }

            User u = Shared.CurrentUser;
            u.Password = txtPWD.Text;
            if (!u.Update()) Program.ShowMsg("Không đổi được mật khẩu!!!", true);
            else Program.ShowMsg("Đổi mật khẩu thành công");
            ClearForm();
            this.Cursor = Cursors.Default;
        }
    }
}