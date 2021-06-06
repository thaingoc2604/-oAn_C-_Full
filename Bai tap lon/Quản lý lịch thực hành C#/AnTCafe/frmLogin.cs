using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using MDS.BussinessRule;
using System.Configuration;

namespace AnTCafe
{
    public partial class frmLogin : Form
    {
        clsBNhanVien objBNhanVien = new clsBNhanVien();
        public frmLogin()
        {
            InitializeComponent();
            //string con_str = "Data Source=.;Initial Catalog=CafeManager;Integrated Security=True";//;ConfigurationManager.ConnectionStrings["AnTCafe.Properties.Settings.AnTCafeConnectionString"].ConnectionString;
            string con_str =Program.ConnectionString;
            objBNhanVien.ConnectionString = con_str;
            objBNhanVien.Initialize();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DangNhap() {
            objBNhanVien.MaNV = txtTenDangNhap.Text;
            objBNhanVien.MatKhau = txtMatKhau.Text;

            if (objBNhanVien.DangNhap() != true)
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!");
                return;
            }
            DataTable tblNhanVien = new DataTable();
            tblNhanVien = objBNhanVien.SELECT_NHANVIEN_BY_ID();

            frmMain mainForm = new frmMain();
            mainForm.MaNV = tblNhanVien.Rows[0]["MaNV"].ToString();
            mainForm.TenNV = tblNhanVien.Rows[0]["TenNV"].ToString();
            mainForm.LaAdmin = Convert.ToBoolean(tblNhanVien.Rows[0]["laAdmin"].ToString());
            mainForm.Show();
            mainForm.Activate();
            this.Hide();

        }

        private void bntDangNhap_Click(object sender, EventArgs e)
        {
            this.DangNhap();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //RegistryKey regKey;
            //regKey = Registry.LocalMachine.OpenSubKey("Software\\SoftAProtect",true);
            //if (regKey == null) {
            //    MessageBox.Show("Phần mềm chưa được đăng ký sử dụng !\n Xin liên hệ Công ty CP A.N.T: ĐT: 098 598 5378(Minh)");
            //    Application.Exit();
            //    return;
            //}
            //string defaut = "-0";
            //if (regKey.GetValue("lic", defaut).ToString() == "1")//Phien ban chinh thuc
            //{
            //    if (regKey.GetValue("date", defaut).ToString() == "-0")
            //    {
            //        //cap nhat ngay lan dau
            //        string datenow = DateTime.Now.Date.ToShortDateString();
            //        regKey.SetValue("date", datenow);
            //        regKey.Close();
            //        MessageBox.Show("Đăng ký thành công 'phiên bản 1.0'! \n Cảm ơn bạn đã sử dụng phần mềm của A.N.T");
            //    }
                
            //    return;
            //}
            //if (regKey.GetValue("remain", defaut).ToString() == "-0")//Phien ban demo 10 ngay
            //{
            //    MessageBox.Show("Phần mềm chưa được đăng ký sử dụng !\n Xin liên hệ Công ty CP A.N.T: ĐT: 098 598 5378(Minh)");
            //    Application.Exit();
            //}
            //else
            //{
            //    if (regKey.GetValue("date", defaut).ToString() == "-0")
            //    {
            //        //cap nhat ngay lan dau
            //        string datenow = DateTime.Now.Date.ToShortDateString();
            //        regKey.SetValue("date", datenow);
            //        MessageBox.Show("Đăng ký thành công 'phiên bản dùng thử' 10 ngày! \n Cảm ơn bạn đã sử dụng phần mềm của A.N.T");
            //    }
            //    else
            //    {
            //        //lay ngay hien tai tru di ngay lan dau
            //        DateTime datenow = DateTime.Now.Date;
            //        DateTime datebegin = Convert.ToDateTime(regKey.GetValue("date").ToString());
            //        TimeSpan ts = new TimeSpan();
            //        ts = datenow.Subtract(datebegin);
            //        int intRemain;
            //        intRemain = 10 - (ts.Days);
            //        if (intRemain > 0)
            //            MessageBox.Show("Bạn còn " + (intRemain) + " ngày sử dụng phần mềm");
            //        else
            //        {
            //            MessageBox.Show("Hết thời gian sử dụng thử phần mềm \n Xin liên hệ Công ty CP A.N.T: ĐT: 098 598 5378(Minh) \n để được sử dụng phiên bản chính thức");
            //            Application.Exit();
            //        }
            //    }
            //}            
            //regKey.Close();
        }


        private void txtMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.DangNhap();
            }

        }

        private void txtTenDangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.DangNhap();
            }
        }

    }
}