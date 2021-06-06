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
    public partial class DoiMatKhau : Form
    {
        public DoiMatKhau()
        {
            InitializeComponent();
        }
        User_Bus us;
        private void XoaTrang()
        {
            txtXacNhan.Text = "";
            txtMauKhauMoi.Text = "";
            txtMatKhauCu.Text = "";
            txtMatKhauCu.Focus();
        }
        private bool KiemTraRong()
        {
            if (txtMauKhauMoi.Text == "")
            {
                txtMauKhauMoi.Focus();
                return true;
            }
            if (txtMatKhauCu.Text == "")
            {
                txtMatKhauCu.Focus();
                return true;
            }
            if (txtXacNhan.Text == "")
            {
                txtXacNhan.Focus();
                return true;
            }
            if (txtMauKhauMoi.Text !=txtXacNhan.Text)
            {
                MessageBox.Show("Xác nhận mật khẩu không chính xác!");
                return true;
            }
            if (txtMatKhauCu.Text != DangNhap.MatKhau)
            {
                MessageBox.Show("Mật khẩu cũ không chính xác!");
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
            Change_Pass();      
        }
        private void Change_Pass()
        {
            try
            {
                if (KiemTraRong())
                    return;
                else
                {
                    us = new User_Bus(DangNhap.TenDangNhap, txtMauKhauMoi.Text);
                    if (us.Change_Pass() > 0)
                    {
                        DangNhap.MatKhau = txtMauKhauMoi.Text;
                        MessageBox.Show("Đổi mật khẩu thành công");
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Đổi mật khẩu không thành công!\nVui lòng liền hệ BQT");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Mật khẩu quá dài!");
            }
        }

        private void txtMatKhauCu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Change_Pass();
            }
        }
    }
}
