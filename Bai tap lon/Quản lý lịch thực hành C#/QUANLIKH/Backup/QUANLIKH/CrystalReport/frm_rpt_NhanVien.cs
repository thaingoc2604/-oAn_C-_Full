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
    public partial class frm_rpt_NhanVien : Office2007Form
    {
        public frm_rpt_NhanVien()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            
            rpt_NhanVien_CrystalReport rpt = new rpt_NhanVien_CrystalReport();
            
            crystalReportViewer1.ReportSource = rpt;
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frm_rpt_NhanVien_Load(object sender, EventArgs e)
        {

        }
    }
}