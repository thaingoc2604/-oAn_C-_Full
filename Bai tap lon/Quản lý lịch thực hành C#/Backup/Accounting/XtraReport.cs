using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using BUS;

namespace Accounting
{
    public partial class XtraReport : DevExpress.XtraReports.UI.XtraReport
    {
        private int rowsPerPage;

        DateTime _ngaythang;

        static 
            int count;

        TKThuChi_BUS _tk;

        string _SoDuDauKy;

        string _tenCty;

        string _tenDVChuQuan;

        string _ngaybd;

        string _ngaykt;

        public int RowsPerPage
        {
            get { return rowsPerPage; }
            set { rowsPerPage = value; }
        }

        int _flag;

        public XtraReport(string ngaybd,string ngaykt, string SoDuDauKy, int flag, string tenCty, string tenDVChuQuan)
        {
            InitializeComponent();

            _ngaybd = ngaybd;

            _ngaykt = ngaykt;

            _tk = new TKThuChi_BUS();

            _SoDuDauKy = SoDuDauKy;

            _flag = flag;

            count=0;

            _tenCty = tenCty;

            _tenDVChuQuan = tenDVChuQuan;
        }

        
      
        

      
        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //currentPage = 0;
        }

        private void Detail_AfterPrint(object sender, EventArgs e)
        {
            //if ((currentPage + 1) % RowsPerPage == 0)
            //    (sender as DetailBand).PageBreak = PageBreak.AfterBand;
            //else
            //    (sender as DetailBand).PageBreak = PageBreak.None;

            //currentPage++;
        }

        private void XtraReport_BeforePrint_1(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
           
        }

        private void PageHeader_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            
        }

        private void PageHeader_AfterPrint(object sender, EventArgs e)
        {
            
        }

        private void xrTableCell29_TextChanged(object sender, EventArgs e)
        {

            if (count == 0)
            {
                //MessageBox.Show(_SoDuDauKy.ToString());
                xrTableCell29.Text = _SoDuDauKy.ToString();
            }

            count++;
        }

        private void xrTableCell43_AfterPrint(object sender, EventArgs e)
        {
         
        }

        private void XtraReport_AfterPrint(object sender, EventArgs e)
        {

       
        
        }

        private void xrTableCell43_TextChanged(object sender, EventArgs e)
        {
            xrLabel8.Text = "Gò Vấp, Ngày " + _ngaykt.Split('/')[0].ToString() + " Tháng " + _ngaykt.Split('/')[1].ToString() + " Năm " + _ngaykt.Split('/')[2].ToString();

        }

        private void ReportFooter_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
          
        }

        private void xrTableCell17_TextChanged(object sender, EventArgs e)
        {
           
            //MessageBox.Show(count.ToString());
            
        }

        private void xrTableCell25_TextChanged(object sender, EventArgs e)
        {
          //  MessageBox.Show(count.ToString());

            xrTableCell29.Text = xrTableCell25.Text;

        }

        private void XtraReport_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            lbldenngay.Text = "Đến ngày:";
            lbltungay.Text = "Từ ngày:";
            if (_flag == 1)
            {
                lbldenngay.Text += " " + _ngaykt;

                lbltungay.Text += " " + _ngaybd;
            }

            if (_flag == 2)
            {
                lbldenngay.Text += " " + _ngaykt;

                lbltungay.Text += " " + _ngaybd;
            }

            lblTenCty.Text = _tenCty;

            lblTenCtyChuQuan.Text = _tenDVChuQuan;

            
        }


      


    }
}
