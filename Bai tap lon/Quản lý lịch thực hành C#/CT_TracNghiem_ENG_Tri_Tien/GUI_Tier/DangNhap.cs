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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        public static String TenDangNhap;
        public static String MatKhau;

        private void Login()
        {
            User_Bus us = new User_Bus(txtTenDangNhap.Text, txtMatKhau.Text);
            if (us.Log_In())
            {
                TenDangNhap = txtTenDangNhap.Text;
                MatKhau = txtMatKhau.Text;
                if (us.Check_Quyen() == "Student")
                {
                    this.DialogResult = DialogResult.OK;
                }
                else if (us.Check_Quyen() == "Teacher")
                {
                    this.DialogResult = DialogResult.Yes;
                }
                else
                {
                    this.DialogResult = DialogResult.Abort;
                }
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!");
            }
        }
        private bool KiemTra()
        {
            if (txtTenDangNhap.Text == "")
            {
                MessageBox.Show("Tên đăng nhập chưa điền!");
                txtTenDangNhap.Focus();
                return false;
            }
            if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Mật khẩu chưa nhập!");
                txtMatKhau.Focus();
                return false;
            }           
            return true;
        }
        private void lblDangKy_Click(object sender, EventArgs e)
        {
            DangKy Dangky = new DangKy();
            Dangky.ShowDialog();
        }

        private void lblQuenMatKhau_Click(object sender, EventArgs e)
        {
            QuenMatKhau QuenMK = new QuenMatKhau();
            QuenMK.ShowDialog();
        }

        private void picHuy_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn muốn thoát?","Thoát",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                Close();
        }

        private void picDangNhap_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void txtTenDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                picDangNhap_Click(sender, e);
        }

        private void lblAbout_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }
    }
}
