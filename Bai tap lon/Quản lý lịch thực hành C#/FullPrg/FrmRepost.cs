using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Threading;
using System.IO;
using System.Media;
using System.Drawing.Drawing2D;

using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;


namespace FullPrg
{
    public partial class FrmRepost : Form
    {
        public FrmRepost()
        {
            InitializeComponent();
        }

        private void FrmRepost_Load(object sender, EventArgs e)
        {
            /*
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(@"D:\Project 10\Project end\Menutestone\Menutestone\CrystalReport3.rpt");
            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();  
*/

          //  this.reportViewer1.RefreshReport();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            /*
             * 
            Hàng
//Hàng nhập
//Hàng bán
Hóa đơn nhập
Hóa đơn bán
Khách hàng
Nhà cung cấp
    */
            if (comboBox1.Text == "Hàng")
            {
                ReportDocument cryRpt = new ReportDocument();
                cryRpt.Load(@"D:\Test Csharp\FullPrg\FullPrg\CrystalReport1.rpt");
                crystalReportViewer1.ReportSource = cryRpt;
                crystalReportViewer1.Refresh();  
            }

            //if (comboBox1.Text == "Hàng nhập")
            //{

            //}

            //if (comboBox1.Text == "Hàng bán")
            //{

            //}

            if (comboBox1.Text == "Hóa đơn nhập")
            {
                ReportDocument cryRpt = new ReportDocument();
                cryRpt.Load(@"D:\Test Csharp\FullPrg\FullPrg\CrystalReport2.rpt");
                crystalReportViewer1.ReportSource = cryRpt;
                crystalReportViewer1.Refresh(); 
            }

            if (comboBox1.Text == "Hóa đơn bán")
            {
                ReportDocument cryRpt = new ReportDocument();
                cryRpt.Load(@"D:\Test Csharp\FullPrg\FullPrg\CrystalReport3.rpt");
                crystalReportViewer1.ReportSource = cryRpt;
                crystalReportViewer1.Refresh(); 
            }

            if (comboBox1.Text == "Khách hàng")
            {
                ReportDocument cryRpt = new ReportDocument();
                cryRpt.Load(@"D:\Test Csharp\FullPrg\FullPrg\CrystalReport4.rpt");
                crystalReportViewer1.ReportSource = cryRpt;
                crystalReportViewer1.Refresh(); 
            }

            if (comboBox1.Text == "Nhà cung cấp")
            {
                ReportDocument cryRpt = new ReportDocument();
                cryRpt.Load(@"D:\Test Csharp\FullPrg\FullPrg\CrystalReport5.rpt");
                crystalReportViewer1.ReportSource = cryRpt;
                crystalReportViewer1.Refresh(); 
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát không ?", "Thoát ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                this.Close();//this close
          
        }
    }
}
