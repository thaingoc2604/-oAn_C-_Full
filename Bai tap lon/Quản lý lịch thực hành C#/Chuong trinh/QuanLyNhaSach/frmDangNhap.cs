using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QuanLyNhaSach;

namespace QuanLyNhaSach
{
    public partial class frmDangNhap : Form
    {
        DataService data = new DataService();
        
        public bool temp = false;
        public string tenDN;       
        public frmMain fm;
        public frmDangNhap()
        {
            InitializeComponent();
        }     
       
        string tendn;
        DataTable table;
        bool CheckUserName(string username)
        {
            bool temp = false;
            table = data.Table("select*from TAIKHOAN");
            foreach (DataRow datarow in table.Rows)
            {
                if (username == datarow["TENDN"].ToString())
                {
                    temp = true;
                    tendn = username;
                }
            }
            if (temp)
                return true;
            else return false;            
        }
        string matkhau;
        bool CheckPassword(string pass)
        {
            bool temp = false;
            table = data.Table("select Matkhau from TAIKHOAN where TENDN='" + tendn + "'");
            foreach (DataRow datarow in table.Rows)
            {
                if (pass == datarow["MATKHAU"].ToString())
                {
                    temp = true;
                    matkhau = pass;
                }
            }
            if (temp)
                return true;
            else return false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtTenDN.Text == "")
            {
                MessageBox.Show("Nhập lại tên đăng nhập");
                txtTenDN.Focus();
                return;
            }
            if (txtMK.Text == "")
            {
                MessageBox.Show("Nhập lại mật khẩu");
                txtMK.Focus();
                return;
            }
            if (CheckUserName(txtTenDN.Text))
            {
                if (CheckPassword(txtMK.Text))
                {
                    MessageBox.Show("Đăng nhập "+ tendn+" thành công!");
                    temp = true;                  
                    this.Close();
                }
                else MessageBox.Show("Mật khẩu bạn nhập không đúng");
            }
            else MessageBox.Show("Tài khoản bạn nhập không đúng");

            //if (tenDN == "admin")
            //{                
            //    fm = new frmMain();
            //    fm.Show();
            //    fm.Enable();
            //}
            //else
            //{
            //    fu = new frmUser();
            //    fu.Show();
            //    fu.Enable();
            //}
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn đã chắc chắn thoát!", "QUANLYNHASACH", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                this.Close();              
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMK.Clear();
            txtTenDN.Clear();
            txtTenDN.Focus();
        }
    }
}