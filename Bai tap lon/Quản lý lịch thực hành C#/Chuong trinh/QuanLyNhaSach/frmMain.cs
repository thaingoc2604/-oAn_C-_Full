using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using QuanLyNhaSach.Report;

namespace QuanLyNhaSach
{
    public partial class frmMain : Form
    {

        frmDangNhap dn = null;
        frmDangNhap dn1 = new frmDangNhap();
        frmKhachHang kh = null;
        frmNhaCC ncc = null;
        frmNhanVien nv = null;
        frmThongTinSach ttsach = null;
        frmPhieuNhanSach pns = null;
        frmPhieuXuatSach pxs = null;
        frmThongKeBaoCao tkbc = null;
        frmTonKho tk = null;
        frmDanhMucSach dms= null;
        frmDanhMucLoaiSach dmls = null;
        frmPhieuChi pc = null;
        frmPhieuThu pt = null;
        frmSachThanhLy stl = null;
        frmPhieuDatSach pds = null;        
        frmAbout ab = null;
        frmRegister re = null;
        frmReportNhanVien tkNV = null;       
        frmReportKhachHang tkkh= null;
        frmReportNCC tkncc = null;
        frmDoiMatKhau dmk = null;
        frmReportPhieuChi tkpc = null;
        frmReportPhieuThu tkpt = null;
        frmReportPhieuDatSach tkpd = null;
        frmReportPhieuXuatSach tkpx = null;
        public string tendangnhap = null;

       

        public frmMain()
        {
            InitializeComponent();           
        }

        public void Enable()
        {            
            mnuDanhMuc.Enabled = true;
            mnuQuanLy.Enabled = true;
            mnuNV.Enabled = true;
            tsbKhachHang.Enabled = true;
            tsbNhaCC.Enabled = true;
            tsbPhieuChi.Enabled = true;
            tsbPhieuThu.Enabled = true;
            tsbPNS.Enabled = true;
            tstTKBC.Enabled = true;
            tsbThongTinSach.Enabled = true;
            tsbPXS.Enabled = true;
            tsbPD.Enabled = true;
            tiKhachHang.Enabled = true;
            tiNhaCC.Enabled = true;
            tiNhanVien.Enabled = true;
            tiPhieuChi.Enabled = true;
            tiPhieuDatSach.Enabled = true;
            TiPhieuNhanSach.Enabled = true;
            tiPhieuThu.Enabled = true;
            tiPhieuXuatSach.Enabled = true;
            tiTKBC.Enabled = true;
            tiTTSach.Enabled = true;
            mnuDN.Enabled = false;
            mnuDX.Enabled = true;            
            tiDX.Enabled = true;
            tiTK.Enabled = true;

        }
        public void Disable()     
        {
            
            tiDX.Enabled = false;
            tiTK.Enabled = false;
            mnuDanhMuc.Enabled = false;
            mnuQuanLy.Enabled = false;
            mnuNV.Enabled = false;
            tsbKhachHang.Enabled = false;
            tsbNhaCC.Enabled = false;
            tsbPhieuChi.Enabled = false;
            tsbPhieuThu.Enabled = false;
            tsbPNS.Enabled = false;
            tstTKBC.Enabled = false;
            tsbThongTinSach.Enabled = false;
            tsbPXS.Enabled = false;
            tsbPD.Enabled = false;
            tiKhachHang.Enabled = false;
            tiNhaCC.Enabled = false;
            tiNhanVien.Enabled = false;
            tiPhieuChi.Enabled = false;
            tiPhieuDatSach.Enabled = false;
            TiPhieuNhanSach.Enabled = false;
            tiPhieuThu.Enabled = false;
            tiPhieuXuatSach.Enabled = false;
            tiTKBC.Enabled = false;
            tiTTSach.Enabled = false;
            mnuDN.Enabled = true;
            mnuDX.Enabled = false;
            
        
        }
        private void mnuDN_Click(object sender, EventArgs e)
        {
            if (dn == null || dn.IsDisposed)
                dn = new frmDangNhap();
            dn.txtTenDN.Clear();
            dn.txtMK.Clear();
            //dn.MdiParent = this;
            dn.ShowDialog();
            if (dn.temp == true)
            {
                Enable();
            }
        }
        private void tiDX_Click(object sender, EventArgs e)
        {
            this.Disable();
            this.dongHetCuaSo();
            dn1.temp = false;
        }

        private void mnuDX_Click(object sender, EventArgs e)
        {           
            this.Disable();
            this.dongHetCuaSo();
            dn1.temp = false;
        }
        private void mnuThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            dn1.temp = false;
        }
        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            if (taskPane1.Visible == true)
                taskPane1.Visible = false;
            else
                taskPane1.Visible = true;
        }
        private void taskItem11_Click(object sender, EventArgs e)
        {
            this.taskPane1.Visible = false;
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.dongHetCuaSo();

        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.dongHetCuaSoTruHienHanh();
        }
        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            this.HienThiKH();
        }

        private void mnuNhaCC_Click(object sender, EventArgs e)
        {
            this.HienThiNCC();
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            this.HienThiNhanVien();
        }

        private void mnuTTSach_Click(object sender, EventArgs e)
        {
            this.HienThiThongTinSach();
        }

        private void mnuNhanSach_Click(object sender, EventArgs e)
        {
            this.HienThiPhieuNhanSach();
        }

        private void mnuXuatSach_Click(object sender, EventArgs e)
        {
            this.HienThiPhieuXuatSach();
        }   
       
        private void mnuTonKho_Click(object sender, EventArgs e)
        {
            this.HienThiTK();
        }
        private void mnuPhieuChi_Click(object sender, EventArgs e)
        {
            this.HienThiPhieuChi();
        }

        private void mnuPhieuThu_Click(object sender, EventArgs e)
        {
            this.HienThiPhieuThu();
        } 

        private void tiTTSach_Click(object sender, EventArgs e)
        {
            this.HienThiThongTinSach();
        }

        private void mnupPhieuNhanSach_Click(object sender, EventArgs e)
        {
            this.HienThiPhieuNhanSach();
        }

        private void mnuDanhMucSachThanhLy_Click(object sender, EventArgs e)
        {
            this.HienThiDMSTL();
        }

        private void mnuPhieuXuatSach_Click(object sender, EventArgs e)
        {
            this.HienThiPhieuXuatSach();
        }

        private void tiNhanVien_Click(object sender, EventArgs e)
        {
            this.HienThiNhanVien();
        }

        private void tiNhaCC_Click(object sender, EventArgs e)
        {
            this.HienThiNCC();
        }

        private void tiKhachHang_Click(object sender, EventArgs e)
        {
            this.HienThiKH();
        }
        private void mnuTraCuuPDS_Click(object sender, EventArgs e)
        {
            this.HienThiPhieuDatSach();
        }

        private void tiPhieuThu_Click(object sender, EventArgs e)
        {
            this.HienThiPhieuThu();
        }

        private void tiPhieuChi_Click(object sender, EventArgs e)
        {
            this.HienThiPhieuChi();
        }

        private void TiPhieuNhanSach_Click(object sender, EventArgs e)
        {
            this.HienThiPhieuNhanSach();
        }

        private void mnupPhieuNhanSach_Click_1(object sender, EventArgs e)
        {
            this.HienThiPhieuNhanSach();
        }

        private void mnuPhieuXuatSach_Click_1(object sender, EventArgs e)
        {
            this.HienThiPhieuXuatSach();
        }

        private void tiPhieuXuatSach_Click(object sender, EventArgs e)
        {
            this.HienThiPhieuXuatSach();
        }

        private void tiPhieuDatSach_Click(object sender, EventArgs e)
        {
            this.HienThiPhieuDatSach();
        }      

        private void tsbThongTinSach_Click(object sender, EventArgs e)
        {
            this.HienThiThongTinSach();
        }

        private void tsbNhaCC_Click(object sender, EventArgs e)
        {
            this.HienThiNCC();
        }

        private void tsbKhachHang_Click(object sender, EventArgs e)
        {
            this.HienThiKH();
        }

        private void tsbPNS_Click(object sender, EventArgs e)
        {
            this.HienThiPhieuNhanSach();
        }

        private void txtPXS_Click(object sender, EventArgs e)
        {
            this.HienThiPhieuXuatSach();
        }

        private void tsbPhieuThu_Click(object sender, EventArgs e)
        {
            this.HienThiPhieuThu(); 
        }

        private void tsbPhieuChi_Click(object sender, EventArgs e)
        {
            this.HienThiPhieuChi();
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.HienThiPhieuDatSach();
        }

        //private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        //{
        //    HienThiHelp();
        //}

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.HienThiRegister();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.HienThiAbout();
        }
        private void tiTK_Click(object sender, EventArgs e)
        {
            this.HienThiTK();
        }
       
        private void tiTKBC_Click(object sender, EventArgs e)
        {
            this.HienThiTKBC();
        }

        private void tstTKBC_Click(object sender, EventArgs e)
        {
            this.HienThiTKBC();
        }

        //dong cua so
        private void dongHetCuaSo()
        {
            while (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Dispose();
        }

        private void dongHetCuaSoTruHienHanh()
        {
            int n = this.MdiChildren.Length - 1;
            Form[] f = this.MdiChildren;
            Form fcurent = this.ActiveMdiChild;
            while (n != -1)
            {
                if (f[n] != fcurent)
                {
                    f[n].Dispose();
                }
                n--;
            }
        }

        private void mnuDMS_Click(object sender, EventArgs e)
        {
            if (dms == null || dms.IsDisposed)
                dms = new frmDanhMucSach();
            dms.MdiParent = this;
            dms.Show(dockPanel1);
        }
        private void mnuDMLS_Click(object sender, EventArgs e)
        {
            if (dmls == null || dmls.IsDisposed)
                dmls = new frmDanhMucLoaiSach();
            dmls.MdiParent = this;
            dmls.Show(dockPanel1);
        }
        void HienThiNhanVien()
        {
            if (nv == null || nv.IsDisposed)
                nv = new frmNhanVien();
            nv.MdiParent = this;
            nv.Show(dockPanel1);
        }
        void HienThiKH()
        {
            if (kh == null || kh.IsDisposed)
                kh = new frmKhachHang();
            kh.MdiParent = this;
            kh.Show(dockPanel1);
        }
        void HienThiNCC()
        {
            if (ncc == null || ncc.IsDisposed)
                ncc = new frmNhaCC();
            ncc.MdiParent = this;
            ncc.Show(dockPanel1);
        }
        void HienThiThongTinSach()
        {
            if (ttsach == null || ttsach.IsDisposed)
                ttsach = new frmThongTinSach();
            ttsach.MdiParent = this;
            ttsach.Show(dockPanel1);
        }
        void HienThiDMSTL()
        {
            if (stl == null || stl.IsDisposed)
                stl = new frmSachThanhLy();
            stl.MdiParent = this;
            stl.Show(dockPanel1);
        }

        void HienThiTKBC()
        {
            if (tkbc == null || tkbc.IsDisposed)
                tkbc = new frmThongKeBaoCao();
            tkbc.MdiParent = this;
            tkbc.Show(dockPanel1);
        }

        void HienThiPhieuDatSach()
        {
            if (pds == null || pds.IsDisposed)
                pds = new frmPhieuDatSach();
            pds.MdiParent = this;
            pds.Show(dockPanel1);
        }
        void HienThiPhieuNhanSach()
        {
            if (pns == null || pns.IsDisposed)
                pns = new frmPhieuNhanSach();
            pns.MdiParent = this;
            pns.Show(dockPanel1);
        }
        void HienThiPhieuXuatSach()
        {
            if (pxs == null || pxs.IsDisposed)
                pxs = new frmPhieuXuatSach();
            pxs.MdiParent = this;
            pxs.Show(dockPanel1);
        }
        void HienThiPhieuThu()
        {
            if (pt == null || pt.IsDisposed)
                pt = new frmPhieuThu();
            pt.MdiParent = this;
            pt.Show(dockPanel1);
        }

        void HienThiPhieuChi()
        {
            if (pc == null || pc.IsDisposed)
                pc = new frmPhieuChi();
            pc.MdiParent = this;
            pc.Show(dockPanel1);
        }
        //void HienThiHelp()
        //{
        //    if (help == null || help.IsDisposed)
        //        help = new frmHelp();
        //    help.MdiParent = this;
        //    help.Show(dockPanel1);
        //}
        void HienThiAbout()
        {
            if (ab == null || ab.IsDisposed)
                ab = new frmAbout();
            ab.MdiParent = this;
            ab.Show(dockPanel1);
        }
        void HienThiRegister()
        {
            if (re == null || re.IsDisposed)
                re = new frmRegister();
            re.MdiParent = this;
            re.Show(dockPanel1);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmDangNhap frmDN = new frmDangNhap();
            //help();
            frmDN.ShowDialog();          
            if (frmDN.temp == true)
            {
                Enable();
            }
            else Disable();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tkNV == null || tkNV.IsDisposed)
                tkNV = new frmReportNhanVien();
            tkNV.MdiParent = this;
            tkNV.Show(dockPanel1);
        }
        void HienThiTK()
        {
            if (tk == null || tk.IsDisposed)
                tk = new frmTonKho();
            tk.MdiParent = this;
            tk.Show(dockPanel1);
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tkkh == null || tkkh.IsDisposed)
                tkkh = new frmReportKhachHang();
            tkkh.MdiParent = this;
            tkkh.Show(dockPanel1);
        }
        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "HelpQLNS.chm");
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tkncc == null || tkncc.IsDisposed)
                tkncc = new frmReportNCC();
            tkncc.MdiParent = this;
            tkncc.Show(dockPanel1);
        }
        void hientthiDoiMatKhau()
        {
            if (dmk == null || dmk.IsDisposed)
                dmk = new frmDoiMatKhau();
            dmk.MdiParent = this;
            dmk.Show(dockPanel1);        
        }

        private void taskItem1_Click(object sender, EventArgs e)
        {
            this.hientthiDoiMatKhau();
        }

        private void phiếuThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tkpt == null || tkpt.IsDisposed)
                tkpt = new frmReportPhieuThu();
            tkpt.MdiParent = this;
            tkpt.Show(dockPanel1);  
        }

        private void phiếuChiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tkpc == null || tkpc.IsDisposed)
                tkpc = new frmReportPhieuChi();
            tkpc.MdiParent = this;
            tkpc.Show(dockPanel1); 
        }

        private void phiếuXuấtSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tkpx == null || tkpx.IsDisposed)
                tkpx = new frmReportPhieuXuatSach();
            tkpx.MdiParent = this;
            tkpx.Show(dockPanel1); 
        }

        private void phiếuĐặtSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tkpd == null || tkpd.IsDisposed)
                tkpd = new frmReportPhieuDatSach();
            tkpd.MdiParent = this;
            tkpd.Show(dockPanel1); 
        }

        private void phiếuNhậnSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

     }
}