using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Business_Tier;
using Entities;

namespace ThiTracNghiem_THDC
{
    public partial class frmSVDangNhap : Form
    {
        B_SinhVien objsinhvien = new B_SinhVien();
        public frmSVDangNhap()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain main = new frmMain();
            main.ShowDialog();
           
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (txtTenSV.Text == "" || txtMatKhau.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin !");
                txtTenSV.SelectAll();
            }
            else
            {
                DataTable dt = new B_SinhVien().get_tbSinhVien_B(txtMatKhau.Text, txtTenSV.Text);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Bạn đã đăng nhập thành công !");
                    if (radLuyenThi.Checked == false && radThi.Checked == false)
                    {
                        MessageBox.Show("Bạn chưa chọn hình thức thi !", "Thông báo");
                    }
                    else
                    {
                        if (radLuyenThi.Checked == true)
                        {
                            frmThiThu frmLuyenTap = new frmThiThu();
                            frmLuyenTap.Show();
                            this.Hide();
                        }
                        else
                        {
                            frmThiTracNghiem frmThi = new frmThiTracNghiem();
                            frmThi.Show();
                            this.Hide();
                        }
                    }   
                }
                else
                    MessageBox.Show("dang nhap khong thanh cong!!");

                

            }
        }
    }
}
