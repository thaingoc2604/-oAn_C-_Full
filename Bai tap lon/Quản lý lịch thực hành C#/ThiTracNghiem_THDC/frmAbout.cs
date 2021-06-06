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
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
            lblThongTin.Text = " Trường Đại Học Công Nghiệp Thành Phố Hồ Chí Minh\n Khoa : Công Nghệ Thông Tin \n Chuyên Ngành Công Nghệ Phần Mềm \n Đồ Án Môn Học \nTHI TRẮC NGHIỆM TIN HỌC ĐẠI CƯƠNG\n GIẢNG VIÊN HƯỚNG DẪN :TRẦN THỊ ANH THI \n SVTH : NGUYỄN THỊ PHƯƠNG :10195511 \n SVTH :NGUYỄN THỊ THU SANG :10276721 \n LỚP :NCTH4A -KHÓA HỌC :2010-2013";
        }

        private void btnDong_Click(object sender, EventArgs e)
        {

            this.Hide();
            frmMain main = new frmMain();
            main.ShowDialog();
            //this.Close();
        }
    }
}
