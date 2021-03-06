using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using QLHSTPTTHSP.PresentationLayer;
using QLHSTPTTHSP.Initiation;

namespace QLHSTPTTHSP
{
    public partial class frmMain : Office2007RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonItemThoat_Click(object sender, EventArgs e)
        {
            //if (MessageBoxEx.Show("Bạn có muốn thoát khỏi ứng dụng không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            Application.Exit();
        }
        
        private void buttonItemMauDen_Click(object sender, EventArgs e)
        {
            if (this.ribbonControl1.Office2007ColorTable != DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Black)
            {
                if (MessageBoxEx.Show("Bạn có muốn thay đổi màu nền cho ứng dụng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    this.ribbonControl1.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Black;
            }
        }

        private void buttonItemMauBac_Click(object sender, EventArgs e)
        {
            if (this.ribbonControl1.Office2007ColorTable != DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Silver)
            {
                if (MessageBoxEx.Show("Bạn có muốn thay đổi màu nền cho ứng dụng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    this.ribbonControl1.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Silver;
            }
        }

        private void buttonItemMauXanh_Click(object sender, EventArgs e)
        {
            if (this.ribbonControl1.Office2007ColorTable != DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Blue)
            {
                if (MessageBoxEx.Show("Bạn có muốn thay đổi màu nền cho ứng dụng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    this.ribbonControl1.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Blue;
            }
        }

        private void buttonItemNienHoc_Click(object sender, EventArgs e)
        {
            if (KhoiTao.nienHoc == null || KhoiTao.nienHoc.IsDisposed)
            {
                KhoiTao.nienHoc = new frmNienHoc();                
                KhoiTao.nienHoc.ShowDialog();                           
            }
            KhoiTao.nienHoc.Dispose();
        }

        private void buttonItemHocKy_Click(object sender, EventArgs e)
        {
            if (KhoiTao.hocKy == null || KhoiTao.hocKy.IsDisposed)
            {
                KhoiTao.hocKy = new frmHocKy();
                KhoiTao.hocKy.ShowDialog();
            }
            KhoiTao.hocKy.Dispose();
        }

        private void buttonItemToChuyenMon_Click(object sender, EventArgs e)
        {
            if (KhoiTao.toChuyenMon == null || KhoiTao.toChuyenMon.IsDisposed)
            {
                KhoiTao.toChuyenMon = new frmToChuyenMon();
                KhoiTao.toChuyenMon.ShowDialog();
            }
            KhoiTao.toChuyenMon.Dispose();
        }

        private void buttonItemLopHoc_Click(object sender, EventArgs e)
        {
            if (KhoiTao.lopHoc == null || KhoiTao.lopHoc.IsDisposed)
            {
                KhoiTao.lopHoc = new frmLopHoc();
                KhoiTao.lopHoc.ShowDialog();
            }
            KhoiTao.lopHoc.Dispose();
        }

        private void buttonItemQuanLy_HocSinh_Click(object sender, EventArgs e)
        {
            if (KhoiTao.hocSinh == null || KhoiTao.hocSinh.IsDisposed)
            {
                KhoiTao.hocSinh = new frmHocSinh();
                KhoiTao.hocSinh.ShowDialog();
            }
            KhoiTao.hocSinh.Dispose();
        }

        private void buttonItemGiaoVien_Click(object sender, EventArgs e)
        {
            if (KhoiTao.giaoVien == null || KhoiTao.giaoVien.IsDisposed)
            {
                KhoiTao.giaoVien = new frmGiaoVien();
                KhoiTao.giaoVien.ShowDialog();
            }
            KhoiTao.giaoVien.Dispose();
        }

        private void buttonItemDiem_PT_Click(object sender, EventArgs e)
        {
            if (KhoiTao.nhapDiem == null || KhoiTao.nhapDiem.IsDisposed)
            {
                KhoiTao.nhapDiem = new frmNhapDiem();
                KhoiTao.nhapDiem.ShowDialog();
            }
            KhoiTao.nhapDiem.Dispose();
        }

        private void buttonItemHanhKiem_PT_Click(object sender, EventArgs e)
        {
            if (KhoiTao.nhapHanhKiem == null || KhoiTao.nhapHanhKiem.IsDisposed)
            {
                KhoiTao.nhapHanhKiem = new frmNhapHanhKiem();
                KhoiTao.nhapHanhKiem.ShowDialog();
            }
            KhoiTao.nhapHanhKiem.Dispose();
        }

       
    }
}