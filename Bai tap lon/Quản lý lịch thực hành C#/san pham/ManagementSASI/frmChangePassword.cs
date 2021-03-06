using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Linq;

namespace ManagementSASI
{
    public partial class frmChangePassword : DevExpress.XtraEditors.XtraForm
    {
        public frmChangePassword()
        {
            InitializeComponent();//Download source code tại Sharecode.vn
        }
        ManagementSASIDataContext db = new ManagementSASIDataContext();
        ErrorProvider erro = new ErrorProvider();
        private bool Test(string strName, string strPass)
        {
            var query = from c in db.Logins
                        select new { c.UserName, c.Password };
            foreach (var item in query)
            {
                if (item.Password == strPass && item.UserName == strName)
                {
                    return false;
                }
            }
            return true;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                string pass = CryptorEngine.Encrypt(txtPassWord.Text, true);

                string newpass = CryptorEngine.Encrypt(txtNewPassWord.Text, true);
                if (txtName.Text == "")
                {
                    erro.SetError(txtName, "Bạn xem lại tên đăng nhập"); txtName.Focus();
                }
                else
                {
                    if (txtPassWord.Text == "")
                    {
                        erro.SetError(txtPassWord, "Bạn chưa nhập mật khẩu cũ"); txtPassWord.Focus();
                    }
                    else
                    {
                        if (txtNewPassWord.Text == "")
                        {
                            erro.SetError(txtNewPassWord, "Bạn chưa nhập mật khẩu mới"); txtNewPassWord.Focus();
                        }
                        else
                        {
                            if (Test(txtName.Text, pass) == false)
                            {
                                Login l = db.Logins.SingleOrDefault(c => c.UserName == txtName.Text);

                                if (l != null)
                                {
                                    l.Password = newpass;
                                    db.SubmitChanges();
                                    XtraMessageBox.Show("Thành công", Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                }
                            }
                            else
                            {
                                XtraMessageBox.Show("Bạn xem lại tên đăng nhập và mật khẩu", Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmChange_Load(object sender, EventArgs e)
        {
       
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void frmChangePassword_KeyDown(object sender, KeyEventArgs e)
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
    }
}