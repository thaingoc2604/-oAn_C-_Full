using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyTV
{
    public partial class ThongKe : Form
    {

        public static int DangMo = 0;
       
        
        public ThongKe()
        {
            InitializeComponent();
        }

        private void toolBar_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
        {
            if (e.Button == toolBar.Buttons[0] && DangMo == 0)
            {
                rptDocGia report = new rptDocGia();
                rptFormDocGia frmBCDocGia = new rptFormDocGia();
                frmBCDocGia.crystalReportViewer1.ReportSource = report;
                DangMo = 1;
                frmBCDocGia.MdiParent = this;
                frmBCDocGia.Show();
            }
            if (e.Button == toolBar.Buttons[1] && DangMo == 0)
            {
                rptNhanVien report = new rptNhanVien();
                rptFormNhanVien frmBCNhanVien = new rptFormNhanVien();
                frmBCNhanVien.crystalReportViewer1.ReportSource = report;
                DangMo = 1;
                frmBCNhanVien.MdiParent = this;
                frmBCNhanVien.Show();
            }
            if (e.Button == toolBar.Buttons[2] && DangMo == 0)
            {
                rptSach report = new rptSach();
                rptFormSach frmBCSach = new rptFormSach();
                frmBCSach.crystalReportViewer1.ReportSource = report;
                DangMo = 1;
                frmBCSach.MdiParent = this;
                frmBCSach.Show();
            }
            if (e.Button == toolBar.Buttons[3] && DangMo == 0)
            {
                rptQuanLymuontra report = new rptQuanLymuontra();
                rptFormQuanLyMuon frmBCMuon = new rptFormQuanLyMuon();
                frmBCMuon.crystalReportViewer1.ReportSource = report;
                DangMo = 1;
                frmBCMuon.MdiParent = this;
                frmBCMuon.Show();
            }

        }

        private void ThongKe_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.DaMo[10] = 0;
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            Form1.DaMo[10] = 1;
        }



    }
}
