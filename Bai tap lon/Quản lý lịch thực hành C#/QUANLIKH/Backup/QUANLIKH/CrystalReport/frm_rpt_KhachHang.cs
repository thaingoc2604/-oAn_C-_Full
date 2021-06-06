using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace QUANLIKH.CrystalReport
{
    public partial class frm_rpt_KhachHang : Office2007Form
    {
        public frm_rpt_KhachHang()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            rpt_KhachHang_CrystalReport rptkh = new rpt_KhachHang_CrystalReport();
            crystalReportViewer1.ReportSource = rptkh;
        }
    }
}