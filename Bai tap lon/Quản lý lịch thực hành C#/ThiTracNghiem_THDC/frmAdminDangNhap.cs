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
    public partial class frmAdminDangNhap : Form
    {
               
        public frmAdminDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            
           
            if(txtTenDN.Text==""||txtMatKhau.Text=="")
            {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin đăng nhập");
                txtTenDN.SelectAll();
            }            
            else
            {
                DataTable dt = new B_Admin().get_tbAdmin(txtMatKhau.Text, txtTenDN.Text);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Bạn đã đăng nhập thành công !");
                    frmTaoVaChinhSuaDeThi frmTaoDe = new frmTaoVaChinhSuaDeThi();
                    frmTaoDe.ShowDialog();
                }
                else
                    MessageBox.Show("Đăng nhập không thành công!!");
            }
        
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.ShowDialog();
            this.Hide();
        }

        
    }
}
