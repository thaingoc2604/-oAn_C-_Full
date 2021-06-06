using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLBH._forms
{
    public partial class frmAbout : Form
    { 
        Timer t;
       
        public frmAbout()
        {
            InitializeComponent();
            t=new Timer();
            t.Interval=2;
            t.Tick += new System.EventHandler(this.timer1_Tick);
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
            textBox1.Text = "     Chương trình quản lý bán hàng được viết bằng C# 2005 và cơ sở dữ liệu Oracle XE. Được viết bởi Nguyễn Minh Thắng - Lớp LT Đại Học Đà Nẵng - Khoa Công Nghệ Thông Tin - Dưới sự hướng dẫn của Tiến Sĩ Huỳnh Hữu Hưng";
        }

        private void button1_Click(object sender, EventArgs e)
        {
           t.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.02;
            if (this.Opacity <= 0) this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.google.com.vn");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }




       
    }
}