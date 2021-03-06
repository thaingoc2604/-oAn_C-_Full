using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using QuanLyTienGuiTietKiem.General;
using QuanLyTienGuiTietKiem.Controller;

namespace QuanLyTienGuiTietKiem
{
    public partial class frmMain : Office2007RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
            frmFlash m_FrmFlash = new frmFlash();
            m_FrmFlash.Show();
            System.Threading.Thread.Sleep(3000);
            m_FrmFlash.Close();
            DataService.OpenConnection();
        }
        NhanVienCtrl m_NhanVienCtrl = new NhanVienCtrl();
        PhanQuyenCtrl m_PhanQuyenCtrl = new PhanQuyenCtrl();
        frmDangNhap m_FrmDangNhap = null;

        private void frmMain_Load(object sender, EventArgs e)
        {
            Default();

            DangNhap();

            ribbonControl.QatFrequentCommands.Add(btnDangNhap);
            ribbonControl.QatFrequentCommands.Add(btnDangXuat);
            ribbonControl.QatFrequentCommands.Add(btnClose);

            // Load Quick Access Toolbar layout if one is saved from last session...
            Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\DevComponents\Ribbon");
            if (key != null)
            {
                try
                {
                    string layout = key.GetValue("RibbonPadCSLayout", "").ToString();
                    if (layout != "" && layout != null)
                        ribbonControl.QatLayout = layout;
                }
                finally
                {
                    key.Close();
                }
            }

            // Pulse the Application Button
            buttonFile.Pulse(11);
        }

        private void frmMain_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Save Quick Access Toolbar layout if it has changed...
            if (ribbonControl.QatLayoutChanged)
            {
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"Software\DevComponents\Ribbon");
                try
                {
                    key.SetValue("RibbonPadCSLayout", ribbonControl.QatLayout);
                }
                finally
                {
                    key.Close();
                }
            }
        }


        #region DangNhap
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            m_FrmDangNhap.txtUserName.Text = "";
            m_FrmDangNhap.txtPass.Text = "";
            m_FrmDangNhap.lbErrorPass.Text = "";
            m_FrmDangNhap.lbErrorUserName.Text = "";

            DangNhap();

        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            Default();
            lblTenNguoiDung.Text = "";
        }
        public void DangNhap()
        {
        Cont:
            if (m_FrmDangNhap == null || m_FrmDangNhap.IsDisposed)
                m_FrmDangNhap = new frmDangNhap();

            if (m_FrmDangNhap.ShowDialog() == DialogResult.OK)
            {
                if (m_FrmDangNhap.txtUserName.Text == "")
                {
                    m_FrmDangNhap.lbErrorUserName.Text = "Bạn chưa nhập tên đăng nhập";
                    m_FrmDangNhap.lbErrorPass.Text = "";
                    goto Cont;
                }

                if (m_FrmDangNhap.txtPass.Text == "")
                {
                    m_FrmDangNhap.lbErrorPass.Text = "Bạn chưa nhập mật khẩu";
                    m_FrmDangNhap.lbErrorUserName.Text = "";
                    goto Cont;
                }
                int kq = m_PhanQuyenCtrl.DangNhap(m_FrmDangNhap.txtUserName.Text, m_FrmDangNhap.txtPass.Text);
                lblTenNguoiDung.Text = m_PhanQuyenCtrl.LayTenNguoiDung(m_FrmDangNhap.txtUserName.Text);
                switch (kq)
                {
                    case 0:
                        m_FrmDangNhap.lbErrorPass.Text = "";
                        m_FrmDangNhap.lbErrorUserName.Text = "Người dùng không tồn tại";
                        goto Cont;
                    case 1:
                        m_FrmDangNhap.lbErrorUserName.Text = "";
                        m_FrmDangNhap.lbErrorPass.Text = "Mật khẩu không hợp lệ";
                        goto Cont;
                    case 2:
                        if (m_PhanQuyenCtrl.PhanQuyen == "MQ001")
                            Manager();
                        else if (m_PhanQuyenCtrl.PhanQuyen == "MQ002")
                            Users();
                        else
                            Admin();
                        break;

                }
            }
        }
        public void Default()
        {
            btnAbout.Enabled = true;
            btnCalculator.Enabled = true;
            btnClose.Enabled = true;

            btnTimNV.Enabled = true;
            //btnTimSoTK.Enabled = true;

            btnDangNhap.Enabled = true;
            btnBackUp.Enabled = false;
            btnRestor.Enabled = false;
            btnChangePass.Enabled = false;
            btnDangXuat.Enabled = false;

            btnDSSoTK.Enabled = false;

            btnRutTietKiem.Enabled = false;
            btnGuiThemTienSoKKH.Enabled = false;
            btnDuyetSoGopVon.Enabled = false;
            btnMoSoTietKiem.Enabled = false;
            btnKhachHang.Enabled = false;
            btnPhongGiaoDich.Enabled = false;
            btnQuayGiaoDich.Enabled = false;
            btnNhanVien.Enabled = false;
            btnGiaoDichVien.Enabled = false;
            btnNhomNguoiDung.Enabled = false;
            btnQuyen.Enabled = false;
            btnPhanNhom.Enabled = false;
            btnPhanQuyen.Enabled = false;
            btnLoaiTietKiem.Enabled = false;
            btnPSTietKiem.Enabled = false;
            btnSoDuTK.Enabled = false;

            btnDMChiTietPSGD.Enabled = false;
            btnDMKyLaiTK.Enabled = false;
            btnDMLoaiGiaoDich.Enabled = false;
            btnDMLoaiTien.Enabled = false;
            btnDMTaiKhoan.Enabled = false;
            btnLaiSuatTK.Enabled = false;
            btnTaiKhoan.Enabled = false;

            btnPhieuChi.Enabled = false;
            btnPhieuLuu.Enabled = false;
            btnPhieuThu.Enabled = false;
            //btnChuyenKhoan.Enabled = false;
            btnBangKeTinh.Enabled = false;
            btnInSoCoKyHan.Enabled = false;
            btnSoTKKhongKyhan.Enabled = false;
            //m_FrmPhongGD.bindingNavigatorAddNewItem.Enabled = false;

        }

        public void Manager()
        {
            btnAbout.Enabled = true;
            btnCalculator.Enabled = true;
            btnClose.Enabled = true;

            btnTimNV.Enabled = true;
            //btnTimSoTK.Enabled = true;

            btnDangNhap.Enabled = true;
            btnBackUp.Enabled = true;
            btnRestor.Enabled = true;
            btnChangePass.Enabled = true;
            btnDangXuat.Enabled = true;

            btnRutTietKiem.Enabled = true;
            btnGuiThemTienSoKKH.Enabled = true;
            btnDuyetSoGopVon.Enabled = true;

            btnMoSoTietKiem.Enabled = true;
            btnDSSoTK.Enabled = true;
            btnKhachHang.Enabled = true;
            btnPhongGiaoDich.Enabled = true;
            btnQuayGiaoDich.Enabled = true;
            btnNhanVien.Enabled = true;
            btnGiaoDichVien.Enabled = true;
            btnNhomNguoiDung.Enabled = true;
            btnQuyen.Enabled = true;
            btnPhanNhom.Enabled = true;
            btnPhanQuyen.Enabled = true;
            btnLoaiTietKiem.Enabled = true;
            btnPSTietKiem.Enabled = true;
            btnSoDuTK.Enabled = true;

            btnDMChiTietPSGD.Enabled = true;
            btnDMKyLaiTK.Enabled = true;
            btnDMLoaiGiaoDich.Enabled = true;
            btnDMLoaiTien.Enabled = true;
            btnDMTaiKhoan.Enabled = true;
            btnLaiSuatTK.Enabled = true;
            btnTaiKhoan.Enabled = true;

            btnPhieuChi.Enabled = true;
            btnPhieuLuu.Enabled = true;
            btnPhieuThu.Enabled = true;
            btnInSoCoKyHan.Enabled = true;
            btnSoTKKhongKyhan.Enabled = true;
            // btnChuyenKhoan.Enabled = false;
            btnBangKeTinh.Enabled = false;
        }

        public void Users()
        {
            btnAbout.Enabled = true;
            btnCalculator.Enabled = true;
            btnClose.Enabled = true;

            btnTimNV.Enabled = true;
            //btnTimSoTK.Enabled = true;
            btnMoSoTietKiem.Enabled = true;
            btnDangNhap.Enabled = true;
            btnBackUp.Enabled = false;
            btnRestor.Enabled = false;
            btnChangePass.Enabled = true;
            btnDangXuat.Enabled = true;

            btnDSSoTK.Enabled = true;
            btnKhachHang.Enabled = true;
            btnPhongGiaoDich.Enabled = true;
            btnQuayGiaoDich.Enabled = true;
            btnNhanVien.Enabled = true;

            btnGiaoDichVien.Enabled = false;
            btnNhomNguoiDung.Enabled = false;
            btnQuyen.Enabled = false;
            btnPhanNhom.Enabled = false;
            btnPhanQuyen.Enabled = false;

            btnLoaiTietKiem.Enabled = false;
            btnPSTietKiem.Enabled = false;
            btnSoDuTK.Enabled = false;

            btnDMChiTietPSGD.Enabled = false;
            btnDMKyLaiTK.Enabled = false;
            btnDMLoaiGiaoDich.Enabled = false;
            btnDMLoaiTien.Enabled = false;
            btnDMTaiKhoan.Enabled = false;
            btnLaiSuatTK.Enabled = false;
            btnTaiKhoan.Enabled = false;
            btnRutTietKiem.Enabled = true;
            btnGuiThemTienSoKKH.Enabled = true;
            btnDuyetSoGopVon.Enabled = false;

            btnPhieuChi.Enabled = true;
            btnPhieuLuu.Enabled = true;
            btnPhieuThu.Enabled = true;
            btnInSoCoKyHan.Enabled = true;
            btnSoTKKhongKyhan.Enabled = true;
            //btnChuyenKhoan.Enabled = false;
            btnBangKeTinh.Enabled = false;
        }

        public void Admin()
        {
            btnAbout.Enabled = true;
            btnCalculator.Enabled = true;
            btnClose.Enabled = true;

            btnTimNV.Enabled = true;
            //btnTimSoTK.Enabled = true;

            btnDangNhap.Enabled = true;
            btnBackUp.Enabled = true;
            btnRestor.Enabled = true;
            btnChangePass.Enabled = true;
            btnDangXuat.Enabled = true;

            btnRutTietKiem.Enabled = false;
            btnGuiThemTienSoKKH.Enabled = false;
            btnDuyetSoGopVon.Enabled = false;
            btnInSoCoKyHan.Enabled = false;
            btnSoTKKhongKyhan.Enabled = false;
            btnMoSoTietKiem.Enabled = false;
            btnDSSoTK.Enabled = false;
            btnKhachHang.Enabled = false;
            btnPhongGiaoDich.Enabled = false;
            btnQuayGiaoDich.Enabled = false;
            btnNhanVien.Enabled = true;
            btnGiaoDichVien.Enabled = false;

            btnNhomNguoiDung.Enabled = true;
            btnQuyen.Enabled = true;
            btnPhanNhom.Enabled = true;
            btnPhanQuyen.Enabled = true;

            btnLoaiTietKiem.Enabled = false;
            btnPSTietKiem.Enabled = false;
            btnSoDuTK.Enabled = false;

            btnDMChiTietPSGD.Enabled = false;
            btnDMKyLaiTK.Enabled = false;
            btnDMLoaiGiaoDich.Enabled = false;
            btnDMLoaiTien.Enabled = false;
            btnDMTaiKhoan.Enabled = false;
            btnLaiSuatTK.Enabled = false;
            btnTaiKhoan.Enabled = false;

            btnPhieuChi.Enabled = false;
            btnPhieuLuu.Enabled = false;
            btnPhieuThu.Enabled = false;
            //btnChuyenKhoan.Enabled = false;
            btnBangKeTinh.Enabled = false;
        }
        #endregion

        #region Quan ly
        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            LoadMain.HienThiKhachHang();
        }

        private void btnDSSoTK_Click(object sender, EventArgs e)
        {
            LoadMain.HienThiSoTietKiem();
        }

        private void btnRutTietKiem_Click(object sender, EventArgs e)
        {
            LoadMain.HienThiRutTietKiem();
        }
        private void btnGuiThemTienSoKKH_Click(object sender, EventArgs e)
        {
            LoadMain.HienThiGuiVonKKH();
        }

        private void btnPhongGiaoDich_Click(object sender, EventArgs e)
        {
            LoadMain.HienThiPhongGiaoDich();
        }

        private void btnQuayGiaoDich_Click(object sender, EventArgs e)
        {
            LoadMain.HienThiQuayGiaoDich();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            LoadMain.HienThiNhanVien();
        }

        private void btnGiaoDichVien_Click(object sender, EventArgs e)
        {
            LoadMain.HienThiGiaoDichVien();
        }

        private void btnNhomNguoiDung_Click(object sender, EventArgs e)
        {
            LoadMain.HienThiNhomNguoiDung();
        }

        private void btnQuyen_Click(object sender, EventArgs e)
        {
            LoadMain.HienThiQuyen();
        }

        private void btnPhanQuyen_Click(object sender, EventArgs e)
        {
            LoadMain.HienThiPhanQuyen();
        }

        private void btnPhanNhom_Click(object sender, EventArgs e)
        {
            LoadMain.HienThiPhanNhomNguoiDung();
        }

        private void btnLoaiTietKiem_Click(object sender, EventArgs e)
        {
            LoadMain.HienThiLoaiTietKiem();
        }

        private void btnPSTietKiem_Click(object sender, EventArgs e)
        {
            LoadMain.HienThiPhatSinhTietKiem();

        }

        private void btnSoDuTK_Click(object sender, EventArgs e)
        {
            LoadMain.HienThiSoDuTietKiem();
        }

        private void btnDuyetSoGopVon_Click(object sender, EventArgs e)
        {
            LoadMain.HienThiDuyetSoTietKiem();
        }

        private void btnMoSoTietKiem_Click(object sender, EventArgs e)
        {
            LoadMain.HienThiMoSoTietKiem();
        }

        #endregion

        #region Quan ly chi tiet
        private void btnDMChiTietPSGD_Click(object sender, EventArgs e)
        {
            LoadMain.HienThiChiTietPhatSinhGD();
        }

        private void btnDMKyLaiTK_Click(object sender, EventArgs e)
        {
            LoadMain.HienThiDMKyLaiTK();
        }

        private void btnDMLoaiGiaoDich_Click(object sender, EventArgs e)
        {
            LoadMain.HienThiDMLoaiGiaoDich();
        }

        private void btnDMLoaiTien_Click(object sender, EventArgs e)
        {
            LoadMain.HienThiDMLoaiTien();
        }

        private void btnDMTaiKhoan_Click(object sender, EventArgs e)
        {
            LoadMain.HienThiDMTaiKhoan();
        }

        private void btnLaiSuatTK_Click(object sender, EventArgs e)
        {
            LoadMain.HienThiLaiSuatTietKiem();
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            LoadMain.HienThiTaiKhoan();
        }
        #endregion

        #region Thong ke
        private void btnDSNhanVien_Click(object sender, EventArgs e)
        {
            LoadMain.HienThiInDanhSachNhanVien();
        }

        private void btnDSSoLap_Click(object sender, EventArgs e)
        {
            LoadMain.HienThiInDanhSachSoCuaNgay();
        }
        #endregion

        #region Lập phiếu
        private void btnPhieuThu_Click(object sender, EventArgs e)
        {
            LoadMain.HienThiInPhieuThu();
        }

        private void btnPhieuChi_Click(object sender, EventArgs e)
        {
            LoadMain.HienThiInPhieuChi();
        }

        private void btnInSoCoKyHan_Click(object sender, EventArgs e)
        {
            LoadMain.HienThiInSoCoKyHan();
        }

        private void btnSoTKKhongKyhan_Click(object sender, EventArgs e)
        {
            LoadMain.HienThiInSoKhongKyHan();
        }

        private void btnPhieuLuu_Click(object sender, EventArgs e)
        {
            LoadMain.HienThiInPhieuLuuTienGui();
        }
        #endregion

        #region Tim kiem
        private void btnTimSoTK_Click(object sender, EventArgs e)
        {
            LoadMain.HienThiTimSoTietKiem();
        }
        #endregion


        private void btnCalculator_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #region Doi mat khau
        frmDoiMatKhau m_FrmDoiMatKhau = null;
        private void btnChangePass_Click(object sender, EventArgs e)
        {
            if (m_FrmDoiMatKhau == null || m_FrmDoiMatKhau.IsDisposed)
            {
                m_FrmDoiMatKhau = new frmDoiMatKhau();

                m_FrmDoiMatKhau.txtMatKhauCu.Text = "";
                m_FrmDoiMatKhau.txtMatKhauMoi.Text = "";
                m_FrmDoiMatKhau.txtNhapLaiMatKhauMoi.Text = "";

                m_FrmDoiMatKhau.lblMatKhauCu.Text = "";
                m_FrmDoiMatKhau.lblMatKhauMoi.Text = "";
                m_FrmDoiMatKhau.lblNhapLaiMatKhauMoi.Text = "";

                DoiMatKhau();

            }
        }

        public void DoiMatKhau()
        {
        Cont:
            if (m_FrmDoiMatKhau.ShowDialog() == DialogResult.OK)
            {
                if (m_FrmDoiMatKhau.txtMatKhauCu.Text == "")
                {
                    m_FrmDoiMatKhau.lblMatKhauCu.Text = "Chưa nhập mật khẩu cũ";
                    m_FrmDoiMatKhau.lblMatKhauMoi.Text = "";
                    m_FrmDoiMatKhau.lblNhapLaiMatKhauMoi.Text = "";

                    goto Cont;
                }

                if (m_FrmDoiMatKhau.txtMatKhauMoi.Text == "")
                {
                    m_FrmDoiMatKhau.lblMatKhauMoi.Text = "Chưa nhập mật khẩu mới";
                    m_FrmDoiMatKhau.lblMatKhauCu.Text = "";
                    m_FrmDoiMatKhau.lblNhapLaiMatKhauMoi.Text = "";

                    goto Cont;
                }

                if (m_FrmDoiMatKhau.txtNhapLaiMatKhauMoi.Text == "")
                {
                    m_FrmDoiMatKhau.lblNhapLaiMatKhauMoi.Text = "Chưa nhập lại mật khẩu mới";
                    m_FrmDoiMatKhau.lblMatKhauMoi.Text = "";
                    m_FrmDoiMatKhau.lblMatKhauCu.Text = "";

                    goto Cont;
                }

                String m_TenDangNhap = m_FrmDangNhap.txtUserName.Text;
                String m_MatKhau = m_FrmDangNhap.txtPass.Text;

                String m_MatKhauCu = m_FrmDoiMatKhau.txtMatKhauCu.Text;
                String m_MatKhauMoi = m_FrmDoiMatKhau.txtMatKhauMoi.Text;
                String m_NhapLaiMatKhauMoi = m_FrmDoiMatKhau.txtNhapLaiMatKhauMoi.Text;

                if (m_MatKhauCu != m_MatKhau)
                {
                    m_FrmDoiMatKhau.lblMatKhauCu.Text = "Nhập mật khẩu cũ không khớp";
                    m_FrmDoiMatKhau.lblMatKhauMoi.Text = "";
                    m_FrmDoiMatKhau.lblNhapLaiMatKhauMoi.Text = "";
                    goto Cont;
                }

                else if (m_MatKhauMoi != m_NhapLaiMatKhauMoi)
                {
                    m_FrmDoiMatKhau.lblNhapLaiMatKhauMoi.Text = "Nhập lại mật khẩu không khớp";
                    m_FrmDoiMatKhau.lblMatKhauMoi.Text = "";
                    m_FrmDoiMatKhau.lblMatKhauCu.Text = "";
                    goto Cont;
                }
                else
                {
                    m_PhanQuyenCtrl.DoiMatKhau(m_TenDangNhap, m_MatKhauMoi);
                    MessageBoxEx.Show("Đổi mật khẩu thành công!", "PASSWORD CHANGED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        #endregion

        #region Sao luu, phuc hoi du lieu
        private void btnBackUp_Click(object sender, EventArgs e)
        {
            if (backupDialog.ShowDialog() == DialogResult.OK)
            {
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand("BACKUP DATABASE " + ThamSo.DatabaseName + " TO DISK = '" + backupDialog.FileName.ToString() + "'");
                DataService data = new DataService();
                data.Load(cmd);
                MessageBoxEx.Show("Sao lưu dữ liệu thành công!", "BACKUP COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                return;
        }

        private void btnRestor_Click(object sender, EventArgs e)
        {
            if (restoreDialog.ShowDialog() == DialogResult.OK)
            {
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand("BACKUP DATABASE " + ThamSo.DatabaseName + " TO DISK = '" + backupDialog.FileName.ToString() + "'");
                DataService data = new DataService();
                data.Load(cmd);
                MessageBoxEx.Show("Sao lưu dữ liệu thành công!", "BACKUP COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                return;
        }

        #endregion

        frmAbout m_FrmAbout = null;
        private void btnAbout_Click(object sender, EventArgs e)
        {
            if (m_FrmAbout == null || m_FrmAbout.IsDisposed)
            {
                m_FrmAbout = new frmAbout();
                m_FrmAbout.MdiParent = frmMain.ActiveForm;
                m_FrmAbout.Show();
            }
            else
                m_FrmAbout.Activate();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Trogiup.chm");
        }

       
    }
}