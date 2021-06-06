//Đề Tài Quản Lý Món Ăn Ngon
//Sinh Viên Thực Hiện: Nguyễn Hoàng Vũ - 10200681 - NCTH4A
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prQuanLyMonAn
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            timer1.Enabled = false;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
