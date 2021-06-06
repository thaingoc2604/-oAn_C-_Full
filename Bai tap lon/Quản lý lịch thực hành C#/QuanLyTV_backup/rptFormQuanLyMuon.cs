using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyTV
{
    public partial class rptFormQuanLyMuon : Form
    {
        public rptFormQuanLyMuon()
        {
            InitializeComponent();
        }

        private void rptFormQuanLyMuon_FormClosed(object sender, FormClosedEventArgs e)
        {
            ThongKe.DangMo = 0;
        }
    }
}
