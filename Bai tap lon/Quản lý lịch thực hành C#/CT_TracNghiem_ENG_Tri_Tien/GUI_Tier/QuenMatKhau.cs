using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bus_Tier;

namespace GUI_Tier
{
    public partial class QuenMatKhau : Form
    {
        public QuenMatKhau()
        {
            InitializeComponent();
        }
        User_Bus us;
        private void XoaTrang()
        {
            txtChuoiBiMat.Text = "";
            txtSoCMND.Text = "";
            txtTenDangNhap.Text = "";
            txtTenDangNhap.Focus();
        }
        private bool KiemTraRong()
        {
            if (txtTenDangNhap.Text == "")
            {
                txtTenDangNhap.Focus();
                txtTenDangNhap.SelectAll();
                return true;
            } 
            if (txtSoCMND.Text == "")
            {
                txtSoCMND.Focus();
                txtSoCMND.SelectAll();
                return true;
            }
            if (txtChuoiBiMat.Text == "")
            {
                txtChuoiBiMat.Focus();
                txtChuoiBiMat.SelectAll();
                return true;
            }            
            return false;
        }
    
        private void picHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void picDongY_Click(object sender, EventArgs e)
        {
            if (KiemTraRong())
                return;
            us = new User_Bus(txtTenDangNhap.Text, txtSoCMND.Text, txtChuoiBiMat.Text);
            if (us.Forgot_Password() != "")
            {
                MessageBox.Show("Mật khẩu của bạn là: " + us.Forgot_Password() + "\nVui lòng đổi mật khẩu khi đăng nhập");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Thông tin không đúng!");
            }
        }

        private void txtTenDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                picDongY_Click(sender, e);
            }
        }

    }
}
