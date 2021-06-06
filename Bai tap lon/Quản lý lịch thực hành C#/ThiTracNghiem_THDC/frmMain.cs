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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            //frmDangNhap frmnhap = new frmDangNhap();
            //frmnhap.ShowDialog();
        }

        private void btnHuongDan_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHuongDan huongdan = new frmHuongDan();
            huongdan.ShowDialog();
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAbout frnThongTin = new frmAbout();
            frnThongTin.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdminDangNhap frmAdmin = new frmAdminDangNhap();
            frmAdmin.ShowDialog();
        }

        private void btnSinhVien_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSVDangNhap frmSV = new frmSVDangNhap();
            frmSV.ShowDialog();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblchay.Left+= 10;
            lblchay.Text = "Chương trình thi trắc nghiệm tin học đại cương !";

            lblNgayGio.Text = DateTime.Now.Hour.ToString() + " Giờ : " + DateTime.Now.Minute.ToString() + " phút ";// +DateTime.Now.Second.ToString() + " s";
        }

    }
}
