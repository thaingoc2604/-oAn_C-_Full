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
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
            cboQuyen.Visible = false;
            lblQuyen.Visible = false;
        }
        public DangKy(int n)
        {
            InitializeComponent();
        }
        User_Bus us;
        private void lblQuyChe_Click(object sender, EventArgs e)
        {
            chkQuyChe.Checked = true;
            QuyDinhTracNghiem QuyDinh = new QuyDinhTracNghiem();
            QuyDinh.ShowDialog();
        }
        private void XoaTrang()
        {
            txtChuoiBiMat.Text = "";
            txtDiaChi.Text = "";
            txtHo.Text = "";
            txtMatKhau.Text = "";
            txtSoCMND.Text = "";
            txtTen.Text = "";
            txtTenDangNhap.Text = "";
            txtXacNhanMatKhau.Text = "";
            txtTenDangNhap.Focus();
            chkQuyChe.Checked = false;
        }
        private bool Check_Empty()
        {
            if (txtTenDangNhap.Text == "")
            {
                MessageBox.Show("Tên Đăng Nhập chưa được nhập!");
                return true;
            }
            if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Mật Khẩu chưa được nhập!");
                return true;
            }
            if (txtXacNhanMatKhau.Text == "")
            {
                MessageBox.Show("Xác Nhận Mật Khẩu chưa được nhập!");
                return true;
            }
            if (txtChuoiBiMat.Text == "")
            {
                MessageBox.Show("Chuỗi bí mật chưa được nhập!");
                return true;
            }
            if (txtHo.Text == "")
            {
                MessageBox.Show("Họ chưa được nhập!");
                return true;
            }
            if (txtTen.Text == "")
            {
                MessageBox.Show("Tên chưa được nhập!");
                return true;
            }
            if (txtSoCMND.Text == "")
            {
                MessageBox.Show("Số CMND chưa được nhập!");
                return true;
            }
            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Địa chỉ chưa được nhập!");
                return true;
            }
            if (txtMatKhau.Text!=txtXacNhanMatKhau.Text)
            {
                MessageBox.Show("Mật khẩu xác nhận không trùng nhau!");
                return true;
            }
            if (chkQuyChe.Checked==false)
            {
                MessageBox.Show("Vui lòng đọc Quy Chế");
                return true;
            }
            if (picHinh.Image==null)
            {
                MessageBox.Show("Vui lòng chọn hình ảnh");
                return true;
            }
            return false;
        }
        private void picXoaTrang_Click(object sender, EventArgs e)
        {
            XoaTrang();
        }

        private void btnXemChuoi_Click(object sender, EventArgs e)
        {
            if (txtChuoiBiMat.UseSystemPasswordChar == true)
            {
                txtChuoiBiMat.UseSystemPasswordChar = false;
                return;
            }
            if (txtChuoiBiMat.UseSystemPasswordChar == false)
            {
                txtChuoiBiMat.UseSystemPasswordChar = true;
                return;
            }
        }
        private void picHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Res_User()
        {
           
                if (Check_Empty())
                    return;
                else
                {
                    DateTime dtp = new DateTime();
                    dtp = dtpNgaySinh.Value;
                    dtp.ToString("dd/MM/yyyy");
                    if (cboQuyen.Visible == false)
                    {
                        us = new User_Bus(txtTenDangNhap.Text, txtMatKhau.Text, txtSoCMND.Text, txtChuoiBiMat.Text, txtHo.Text, txtTen.Text, txtDiaChi.Text, dtp, "Student", picHinh.Tag.ToString());
                    }
                    else
                    {
                        us = new User_Bus(txtTenDangNhap.Text, txtMatKhau.Text, txtSoCMND.Text, txtChuoiBiMat.Text, txtHo.Text, txtTen.Text, txtDiaChi.Text, dtp, cboQuyen.SelectedItem.ToString(), picHinh.Tag.ToString());
                    }
                    if (us.Res_User())
                    {
                        MessageBox.Show("Đăng ký thành công");
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                        MessageBox.Show("Tên đăng nhập đã trùng");
                }
            
        }

        private void picDongY_Click(object sender, EventArgs e)
        {
            Res_User();
            XoaTrang();
        }

        private void lblHinhAnh_Click(object sender, EventArgs e)
        {
            dlgOpenFile.Filter = "All Files|*.*|JPG|*.jpg|PNG|*.PNG|GIF|*.gif";
            dlgOpenFile.FileName = "";
            if (dlgOpenFile.ShowDialog() == DialogResult.OK)
            {
                picHinh.Tag = dlgOpenFile.FileName;
                picHinh.Image = new Bitmap(dlgOpenFile.FileName);
            }
        }

        private void picHinh_Click(object sender, EventArgs e)
        {
            lblHinhAnh_Click(sender, e);
        }

        private void txtSoCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Chỉ nhập số");
            }
        }
    }
}
