using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Business_Tier;

namespace GUI_Tier
{
    public partial class frmINBANGDIEM : Form
    {
        public frmINBANGDIEM()
        {
            InitializeComponent();
        }
        B_KetQua B_KQ = new B_KetQua();
        DataTable dt_ketuqa = new DataTable();
        private void frmINBANGDIEM_Load(object sender, EventArgs e)
        {
           // this.reportViewer1.RefreshReport();
            CrystalReport1 r = new CrystalReport1();
            dt_ketuqa=B_KQ.XemDiem_All_B();
            r.SetDataSource(dt_ketuqa);
            crystalReportViewer1.ReportSource = r;
        }
    }
}
