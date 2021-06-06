using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLSV_Xuly;
namespace QLSV_GiaoDien.Reports
{
    public partial class frmBaocaoDiem : Form
    {
        QLSV_XXemDiem xlDiem = new QLSV_XXemDiem();

        public frmBaocaoDiem()
        {
            InitializeComponent();
        }

        private void btnXemDiem_Click(object sender, EventArgs e)
        {
            xlDiem.MASV = txtMSSV.Text;
            crpDiem crp = new crpDiem();
            crp.SetDataSource(xlDiem.xemdiem());
            crystalReportViewer1.ReportSource = crp;
            crystalReportViewer1.Refresh();

        }

        private void frmBaocaoDiem_Load(object sender, EventArgs e)
        {
            
            
        }
    }
}
