using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace frmAdministrator.report
{
    public partial class report : Form
    {
        public report()
        {
            InitializeComponent();
        }

        public static DataTable dt;

        private void report_Load(object sender, EventArgs e)
        {
            allcauhoi obj = new allcauhoi();
            obj.SetDataSource(dt);
            crystalReportViewer1.ReportSource = obj;
        }
    }
}
