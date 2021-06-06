using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bus_Tier;
namespace GUI_Tier
{
    public partial class Report_All_SinhVien_Form : Form
    {
        public Report_All_SinhVien_Form()
        {
            InitializeComponent();
        }
        KetQua_Bus kq;
        private void Report_All_SinhVien_Form_Load(object sender, EventArgs e)
        {
            kq=new KetQua_Bus ();
            Report_All_SinhVien re = new Report_All_SinhVien();
            re.SetDataSource(kq.Show_All_KQ());
            crystalReportViewer1.ReportSource = re;
        }
    }
}
