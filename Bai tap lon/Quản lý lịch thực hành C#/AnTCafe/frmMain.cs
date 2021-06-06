using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AnTCafe
{
    public partial class frmMain : Form
    {
        //private int childFormNumber = 0;

        string strMaNV;
        string strTenNV;
        Boolean bolLaAdmin;
        public static string staticMaNV;


        public string MaNV
        {
            get { return strMaNV; }
            set { strMaNV = value; }
        }
        public string TenNV
        {
            get { return strTenNV; }
            set { strTenNV = value; }
        }
        public Boolean LaAdmin
        {
            get { return bolLaAdmin; }
            set { bolLaAdmin = value; }
        }


        public frmMain()
        {
            InitializeComponent();

        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            lblTenNV.Text = TenNV;
            lblMaNV.Text = MaNV;
            staticMaNV = MaNV;
            if (!LaAdmin)
            {
                mnuHeThong.Enabled = false;
                mnuDanhMuc.Enabled = false;
                mnuThongKe.Enabled = false;
                mnuNhapGia.Enabled = false;
                mnuNhapHang.Enabled = false;
                mnuQuanLyPhieuNhap.Enabled = false;
                mnuHangBan.Enabled = false;
            }
        }

        private void mnuDSNhanvien_Click(object sender, EventArgs e)
        {
            frmNhanVien fNhanVien = new frmNhanVien();
            // Make it a child of this MDI form before showing it.
            //MessageBox.Show(fNhanVien.IsDisposed.ToString());
            fNhanVien.MdiParent = this;
            if (!FormIsLoaded(fNhanVien.Name))
                fNhanVien.Show();
            else
                fNhanVien.Activate();

        }

        private void mnuDMBan_Click(object sender, EventArgs e)
        {
            frmBan fBan = new frmBan();
            fBan.MdiParent = this;
            if (!FormIsLoaded(fBan.Name))
                fBan.Show();
            else
                fBan.Activate();

        }

        private void mnuDMHang_Click(object sender, EventArgs e)
        {
            frmHang fHang = new frmHang();
            fHang.MdiParent = this;
            if (!FormIsLoaded(fHang.Name))
                fHang.Show();
            else
                fHang.Activate();

        }


        private void mnuDMLoaiKhach_Click(object sender, EventArgs e)
        {
            frmLoaiKhachHang fLoaiKhachHang = new frmLoaiKhachHang();
            fLoaiKhachHang.MdiParent = this;
            if (!FormIsLoaded(fLoaiKhachHang.Name))
                fLoaiKhachHang.Show();
            else
                fLoaiKhachHang.Activate();

        }

        private void mnuNhapGia_Click(object sender, EventArgs e)
        {
            frmNhapGia fNhapGia = new frmNhapGia();
            fNhapGia.MdiParent = this;
            if (!FormIsLoaded(fNhapGia.Name))
                fNhapGia.Show();
            else
                fNhapGia.Activate();

        }

        private void mnuNhapHang_Click(object sender, EventArgs e)
        {
            frmNhapHang fNhapHang = new frmNhapHang();
            fNhapHang.MdiParent = this;
            if (!FormIsLoaded(fNhapHang.Name))
                fNhapHang.Show();
            else
                fNhapHang.Activate();

        }

        //bool fChonBanloaded = false;
        private void mnuBanHang_Click(object sender, EventArgs e)
        {
            frmChonBan fChonBan = new frmChonBan();
            fChonBan.MdiParent = this;
            if (!FormIsLoaded(fChonBan.Name))
                fChonBan.Show();
            else
                fChonBan.Activate();
        }

        private void mnuTKeBanHang_Click(object sender, EventArgs e)
        {
            frmThongKeBanHang fThongKeBanHang = new frmThongKeBanHang();
            fThongKeBanHang.MdiParent = this;
            fThongKeBanHang.Show();
        }

        private void mnuTKeHangTrongKho_Click(object sender, EventArgs e)
        {
            frmThongKeHangTon fThongKeHangTon = new frmThongKeHangTon();
            fThongKeHangTon.MdiParent = this;
            fThongKeHangTon.Show();
        }

        private void mnuQuanLyPhieuNhap_Click(object sender, EventArgs e)
        {
            frmQuanLyHangNhap fQuanLyHangNhap = new frmQuanLyHangNhap();
            fQuanLyHangNhap.MdiParent = this;
            if (!FormIsLoaded(fQuanLyHangNhap.Name))
                fQuanLyHangNhap.Show();
            else
                fQuanLyHangNhap.Activate();

        }

        private void mnuHangBan_Click(object sender, EventArgs e)
        {
            frmQuanLyHangXuat fQuanLyHangXuat = new frmQuanLyHangXuat();
            fQuanLyHangXuat.MdiParent = this;
            if (!FormIsLoaded(fQuanLyHangXuat.Name))
                fQuanLyHangXuat.Show();
            else
                fQuanLyHangXuat.Activate();

        }


        private void frmMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show(e.KeyChar.ToString());
            if ((e.KeyChar == 'z') || (e.KeyChar == 'Z'))
            {
                mnuBanHang_Click(sender, e);
            }
        }


        private void frmMain_MdiChildActivate(object sender, EventArgs e)
        {
            //this.menuStrip.Enabled = !this.menuStrip.Enabled;

        }

        private bool FormIsLoaded(String FormName)
        {
            bool opened = false;
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name == FormName)
                    opened = true;
                else
                    opened = false;
            }
            return opened;
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void đặtHàngQuaSMSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SMS.frmSMS sms=new SMS.frmSMS();
            sms.MdiParent = this;
            if (!FormIsLoaded(sms.Name))
                sms.Show();
            else
                sms.Activate();
        }




    }
}
