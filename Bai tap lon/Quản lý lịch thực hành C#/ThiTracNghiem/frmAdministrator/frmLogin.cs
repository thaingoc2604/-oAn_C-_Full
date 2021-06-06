using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DTO;
using BUS_Tier;

namespace frmAdministrator
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        System.Windows.Forms.ToolTip tt = new System.Windows.Forms.ToolTip();//hiện helps
        bPhanQuyen objpq = new bPhanQuyen();
        frmAdministrator frmadmin = new frmAdministrator();
        frmUser frmuser = new frmUser();
        DataTable tbpq;
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dl;
            dl = MessageBox.Show("Bạn thật sự muốn thoát chương trình ?", "Thông Báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
                this.Close();
            Application.Exit();
        }

        private void btnLoggin_Click(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                MessageBox.Show("Bạn chưa điền thông tin user !");
                txtUser.Focus();
            }
            else if (txtPass.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập password !");
                txtPass.Focus();
            }
            else
            {
                if (txtPass.Text.Trim().Length > 11)
                {
                    MessageBox.Show("Password chỉ cho phép nhập nhiều nhất 11 ký tự !");
                    txtPass.SelectAll();
                    txtPass.Focus();
                }
                tbpq = objpq.get_Table_PhanQuyen(txtUser.Text, txtPass.Text);
                if (tbpq.Rows.Count > 0)
                {
                    MessageBox.Show("Đăng nhập thành công !");
                    string user = tbpq.Rows[0]["TenDN"].ToString();
                    if (user == "admin")
                    {
                        MessageBox.Show("Bạn đã đăng nhập thành công tài khoản admin !");
                        frmadmin.Show();
                        this.Hide();
                    }
                    else
                    {
                        this.Hide();
                        frmuser.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Thông tin tài khoản không đúng !" + Environment.NewLine + "Bạn có thể đăng ký tài khoản mới !");

                }
            }
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            PhanQuyen pq = new PhanQuyen();
            if (txtUser.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập tên tài khoản !");
                txtUser.SelectAll();
                txtUser.Focus();
            }
            else if (txtPass.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập password !");
                txtPass.SelectAll();
                txtPass.Focus();
            }
            else
            {
                if (txtPass.Text.Trim().Length > 11)
                {
                    MessageBox.Show("Password chỉ cho phép nhập tối đa 11 ký tự !");
                    txtPass.SelectAll();
                    txtPass.Focus();
                }
                else
                {
                    DataTable tbkt = objpq.KiemTraTaiKhoan(txtUser.Text);

                    if (tbkt.Rows.Count > 0)
                    {
                        MessageBox.Show("Đăng ký tài khoản " + txtUser.Text + " thất bại !" + Environment.NewLine + "Tài khoản này đã tồn tại !" + Environment.NewLine + "Vui lòng kiểm tra lại tài khoản !");
                        txtUser.Text = "";
                        txtPass.Text = "";
                        txtUser.Focus();
                    }
                    else
                    {
                        pq.TenDangNhap = txtUser.Text;
                        pq.MaDangNhap = txtPass.Text;
                        int result = objpq.TaoTaiKhoan(pq);
                        if (result > 0)
                        {
                            MessageBox.Show("Bạn đã đăng ký tài khoản " + txtUser.Text + " thành công !!");
                            txtUser.Text = "";
                            txtPass.Text = "";
                            txtUser.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Đăng ký tài khoản " + txtUser.Text + " thất bại !!");
                            txtUser.Text = "";
                            txtPass.Text = "";
                            txtUser.Focus();
                        }
                    }
                }
            }
        }

        #region Xử lý hiện Tooltip trên các Button chức năng

            private void btnRegister_MouseHover(object sender, EventArgs e)
            {
                this.tt.Show("Tạo mới một tài khoản", this.btnRegister, new Point(1, -67));
            }

            private void btnRegister_MouseLeave(object sender, EventArgs e)
            {
                this.tt.Hide(this.btnRegister);
            }

            private void btnLoggin_MouseHover(object sender, EventArgs e)
            {
                this.tt.Show("Thực hiện quá trình đăng nhập", this.btnLoggin, new Point(1, -67));
            }

            private void btnLoggin_MouseLeave(object sender, EventArgs e)
            {
                this.tt.Hide(this.btnLoggin);
            }

            private void btnExit_MouseHover(object sender, EventArgs e)
            {
                this.tt.Show("Thoát chương trình", this.btnExit, new Point(1, -67));
            }

            private void btnExit_MouseLeave(object sender, EventArgs e)
            {
                this.tt.Hide(this.btnExit);
            }
        #endregion            

    }     
}
