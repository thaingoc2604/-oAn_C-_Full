using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyTV
{
    public partial class rptFormSach : Form
    {
        public rptFormSach()
        {
            InitializeComponent();
        }

        private void rptFormSach_FormClosed(object sender, FormClosedEventArgs e)
        {
            ThongKe.DangMo = 0;
        }
    }
}
