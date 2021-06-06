using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QuanLyPhongMach
{
    public partial class DangNhap : Form
    {
        public BacSiDTO BS;
        public DangNhap()
        {
            InitializeComponent();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            this.txtTaiKhoan.Focus();
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {            
            if (txtTaiKhoan.Text == "")
            {
                MessageBox.Show("Tên Đăng Nhập Còn Trống!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTaiKhoan.Focus();
                return;
            }

            if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Mật Khẩu Còn Trống!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau.Focus();
                return;
            }

            BS = BacSiBUS.SelectBacSiByID(txtTaiKhoan.Text, txtMatKhau.Text);
            if (BS.TenBacSi != string.Empty)
            {
                //MessageBox.Show("Đăng Nhập Thành Công");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng Nhập Thất Bại");
                this.txtMatKhau.Text = string.Empty;
                this.txtTaiKhoan.Text = string.Empty;
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
