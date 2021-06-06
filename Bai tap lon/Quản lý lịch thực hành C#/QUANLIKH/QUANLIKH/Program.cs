using System;
using System.Collections.Generic;
using System.Windows.Forms;
using QUANLIKH.CrystalReport;

namespace QUANLIKH.GiaoDien
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           // Application.Run(new frmTimDaiLy ());
            //Application.Run(new frmGiayChungNhanBaoHiem());
            //Application.Run(new frmHopDongDaiLy());
            //Application.Run(new frmMucBaoHiem());
            Application.Run(new frmMain());
           //Application.Run(new frmAnChiXuat());
            //Application.Run(new frmThuAnChi());
            //Application.Run(new frmQuyenSo());
          //  Application.Run(new frmTinhtrangGiayChungNhan());
           // Application.Run(new frmGiayChungNhanBaoHiem());
          //Application.Run(new frm_rpt_KhachHang());
        }
    }
}