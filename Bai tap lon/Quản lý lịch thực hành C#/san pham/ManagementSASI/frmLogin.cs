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
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private string userid, password;
        public bool unclock, fLogin = true;
        ManagementSASIDataContext db = new ManagementSASIDataContext();
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                ErrorProvider erro = new ErrorProvider();
                userid = txtName.Text.Trim();
                password = txtPassWord.Text.Trim();
                string asciiPass = CryptorEngine.Encrypt(password, true);
                var query = from c in db.Logins
                            select new { c.Password, c.UserName };
                bool ok = true;
                foreach (var item in query)
                {

                    if (item.UserName == txtName.Text && item.Password == asciiPass)
                    {
                        ok = true;
                        if (chkSave.Checked)
                        {
                            ManagementSASI.Properties.Settings.Default.UserName = txtName.Text;
                            ManagementSASI.Properties.Settings.Default.PassWord = txtPassWord.Text;
                        }
                        else
                        {
                            ManagementSASI.Properties.Settings.Default.UserName = "";
                            ManagementSASI.Properties.Settings.Default.PassWord = "";
                        }
                        ManagementSASI.Properties.Settings.Default.Save();
                        frmMain.username = txtName.Text;
                        frmMain.testlogin = true;
                        this.Close();
                      
                    }
                    else
                    {
                        ok = false; break;

                    }
                }
                if (ok == false)
                {
                   // XtraMessageBox.Show("Sai tên đăng nhập hoặc mật khẩu !");
                    erro.SetError(txtName, "Sai tên đăng nhập hoặc mật khẩu");
                    erro.SetError(txtPassWord, "Sai tên đăng nhập hoặc mật khẩu");
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                frmConfiguration t = new frmConfiguration();
                t.ShowDialog();
            }

            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
           txtName.Text = ManagementSASI.Properties.Settings.Default.UserName ;
           txtPassWord.Text = ManagementSASI.Properties.Settings.Default.PassWord;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
           btnOK.Enabled = (txtName.Text.Trim().Length > 0 && txtPassWord.Text.Trim().Length > 0);
        }

        private void txtPassWord_TextChanged(object sender, EventArgs e)
        {
            btnOK.Enabled = (txtName.Text.Trim().Length > 0 &&txtPassWord.Text.Trim().Length > 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(XtraMessageBox.Show("Bạn chắc chắn muốn thoát chương trình",Application.ProductName.ToString(),MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation)==DialogResult.OK)
        {frmMain.testlogin = false;
           Application.Exit();}
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOK_Click(sender, e);
            }
            if (e.KeyCode == Keys.F4)
            {
               btnClose_Click(sender, e);
            }
        }

        //private void simpleButton1_Click(object sender, EventArgs e)
        //{
        //    Login t = new Login();
        //    t.UserName = txtName.Text;
        //    t.Password = CryptorEngine.Encrypt(txtPassWord.Text,true);
        //    db.Logins.InsertOnSubmit(t);
        //    db.SubmitChanges();

        //    var query = from c in db.Logins
        //                select c;
        //    gridControl1.DataSource = query;
          
        //}
    }
}