using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using EventManager.Utilities;
using DevExpress.XtraTab;
using DevExpress.XtraEditors;
using System.IO;
using WBrowser;
using EventManager.DataAccess;
using EventManager.Enums;


namespace EventManager.Presentation
{
    public partial class frmChinh : RibbonForm
    {
        LogFile log;
        public frmChinh()
        {
            try
            {
                InitializeComponent();
                InitSkinGallery();
                // Kiểm tra kết nối CSDL
                if (!frmAddConnection.TestConnect())
                {
                    if (frmAddConnection.Show() != DialogResult.OK)
                        Environment.Exit(1);
                }
                log = new LogFile();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rgbiSkins, true);
        }

        #region Xử lý add form vào xtra tab control

        protected void TabCreating(string tabTitle, XtraForm frm)
        {
            int Index = KiemTraTonTai(tabTitle);
            if (Index >= 0)
            {
                xtraTabControl1.SelectedTabPage = xtraTabControl1.TabPages[Index];
                xtraTabControl1.SelectedTabPage.Text = tabTitle;
            }
            else
            {
                

                XtraTabPage TabPage = new XtraTabPage { Text = tabTitle };
                TabPage.AutoScroll = true;
                xtraTabControl1.TabPages.Add(TabPage);
                xtraTabControl1.SelectedTabPage = TabPage;
                TabPage.AutoScroll = true;
                //TabPage.AutoScrollMargin = new Size(20, 20);
                TabPage.AutoScrollMinSize = new Size(TabPage.Width, TabPage.Height);

                frm.TopLevel = false;
                frm.Parent = TabPage;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
        }

        private int KiemTraTonTai(string tabName)
        {
            int temp = -1;
            for (int i = 0; i < xtraTabControl1.TabPages.Count; i++)
            {
                if (xtraTabControl1.TabPages[i].Text == tabName)
                {
                    temp = i;
                    break;
                }
            }
            return temp;
        }

        private void xtraTabControl1_CloseButtonClick(object sender, EventArgs e)
        {
            try
            {
                XtraTabControl TabControl = (XtraTabControl)sender;
                int i = TabControl.SelectedTabPageIndex;
                TabControl.TabPages[i].Dispose();
                //if (i >= 0)
                //    TabControl.TabPages.RemoveAt(i);
                if (i > 0)
                    TabControl.SelectedTabPageIndex = i - 1;
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
                return;
            }
        }

        #endregion

        #region Các hàm không phải hàm xử lý sự kiện

        private void PhanQuyen()
        {
            try
            {
                #region Đăng nhập
                if (StaticClass.DangNhap)
                {
                    btnDangNhap.Enabled = false;
                    btnDangXuat.Enabled = true;
                    btnDoiMatKhau.Enabled = true;
                    btnThongTin.Enabled = true;

                    #region Admin
                    if (StaticClass.User.Quyen == (int)QuyenNguoiDung.Admin)
                    {
                        rpNghiepVu.Visible = true;
                        rpBCThongKe.Visible = true;
                        rpAdmin.Visible = true;

                        //nghiep vu
                        btnThemKH.Enabled = true;
                        btnTimKiemKH.Enabled = true;
                        btnSuaKH.Enabled = true;
                        bntTTKH.Enabled = true;
                        btnTaoHD.Enabled = true;
                        btnDsHD.Enabled = true;
                        btnLapPTT.Enabled = true;
                        btnXemLTT.Enabled = true;
                        btnTTTrongTuan.Enabled = true;
                        btnTTQuaHan.Enabled = true;
                        btnThemDV.Enabled = true;
                        btnDsDV.Enabled = true;
                        btnThemNV.Enabled = true;
                        btnTimNV.Enabled = true;
                        btnSuaNV.Enabled = true;
                        btnXepLoaiNV.Enabled = true;

                        //bao cao thong ke
                        btnBCDsKH.Enabled = true;
                        btnThanhToanCanThu.Enabled = true;
                        btnCTNgay.Enabled = true;
                        btnTKDoanhThu.Enabled = true;
                        btnTKNo.Enabled = true;
                        btnDoanhThuvaNo.Enabled = true;

                        //admin
                        btnNguoiDung.Enabled = true;
                        btnThemNguoiDung.Enabled = true;
                        btnXoaNguoiDung.Enabled = true;
                        btnCauHinhCSDL.Enabled = true;
                        btnSaoLuu.Enabled = true;
                        btnPhucHoi.Enabled = true;
                        btnThongTinCSDL.Enabled = true;
                        btnCauHinhHeThong.Enabled = true;
                        btnXemNhatKy.Enabled = true;

                        return;
                    }
                    #endregion

                    #region Nhân viên
                    if (StaticClass.User.Quyen == (int)QuyenNguoiDung.NhanVien)
                    {
                        rpNghiepVu.Visible = true;
                        rpBCThongKe.Visible = true;
                        rpAdmin.Visible = false;

                        //nghiep vu
                        btnThemKH.Enabled = true;
                        btnTimKiemKH.Enabled = true;
                        btnSuaKH.Enabled = true;
                        bntTTKH.Enabled = true;
                        btnTaoHD.Enabled = true;
                        btnDsHD.Enabled = true;
                        btnLapPTT.Enabled = true;
                        btnXemLTT.Enabled = true;
                        btnTTTrongTuan.Enabled = true;
                        btnTTQuaHan.Enabled = true;
                        btnThemDV.Enabled = true;
                        btnDsDV.Enabled = true;
                        btnThemNV.Enabled = true;
                        btnTimNV.Enabled = true;
                        btnSuaNV.Enabled = true;
                        btnXepLoaiNV.Enabled = true;

                        //bao cao thong ke
                        btnBCDsKH.Enabled = true;
                        btnThanhToanCanThu.Enabled = true;
                        btnCTNgay.Enabled = true;
                        btnTKDoanhThu.Enabled = true;
                        btnTKNo.Enabled = true;
                        btnDoanhThuvaNo.Enabled = true;

                        //admin
                        btnNguoiDung.Enabled = false;
                        btnThemNguoiDung.Enabled = false;
                        btnXoaNguoiDung.Enabled = false;
                        btnCauHinhCSDL.Enabled = false;
                        btnSaoLuu.Enabled = false;
                        btnPhucHoi.Enabled = false;
                        btnThongTinCSDL.Enabled = false;
                        btnCauHinhHeThong.Enabled = false;
                        btnXemNhatKy.Enabled = false;

                        return;
                    }
                    #endregion

                    #region Khách hàng
                    if (StaticClass.User.Quyen == (int)QuyenNguoiDung.KhachHang)
                    {
                        rpNghiepVu.Visible = false;
                        rpBCThongKe.Visible = false;
                        rpAdmin.Visible = false;

                        //nghiep vu
                        btnThemKH.Enabled = false;
                        btnTimKiemKH.Enabled = false;
                        btnSuaKH.Enabled = false;
                        bntTTKH.Enabled = false;
                        btnTaoHD.Enabled = false;
                        btnDsHD.Enabled = false;
                        btnLapPTT.Enabled = false;
                        btnXemLTT.Enabled = false;
                        btnTTTrongTuan.Enabled = false;
                        btnTTQuaHan.Enabled = false;
                        btnThemDV.Enabled = false;
                        btnDsDV.Enabled = false;
                        btnThemNV.Enabled = false;
                        btnTimNV.Enabled = false;
                        btnSuaNV.Enabled = false;
                        btnXepLoaiNV.Enabled = false;

                        //bao cao thong ke
                        btnBCDsKH.Enabled = false;
                        btnThanhToanCanThu.Enabled = false;
                        btnCTNgay.Enabled = false;
                        btnTKDoanhThu.Enabled = false;
                        btnTKNo.Enabled = false;
                        btnDoanhThuvaNo.Enabled = false;

                        //admin
                        btnNguoiDung.Enabled = false;
                        btnThemNguoiDung.Enabled = false;
                        btnXoaNguoiDung.Enabled = false;
                        btnCauHinhCSDL.Enabled = false;
                        btnSaoLuu.Enabled = false;
                        btnPhucHoi.Enabled = false;
                        btnThongTinCSDL.Enabled = false;
                        btnCauHinhHeThong.Enabled = false;
                        btnXemNhatKy.Enabled = false;

                        return;
                    }
                    #endregion
                }
                #endregion

                #region Đăng xuất
                else//chua dang nhap
                {
                    btnDangNhap.Enabled = true;
                    btnDangXuat.Enabled = false;
                    btnDoiMatKhau.Enabled = false;
                    btnThongTin.Enabled = false;

                    rpNghiepVu.Visible = false;
                    rpBCThongKe.Visible = false;
                    rpAdmin.Visible = false;

                    //nghiep vu
                    btnThemKH.Enabled = false;
                    btnTimKiemKH.Enabled = false;
                    btnSuaKH.Enabled = false;
                    bntTTKH.Enabled = false;
                    btnTaoHD.Enabled = false;
                    btnDsHD.Enabled = false;
                    btnLapPTT.Enabled = false;
                    btnXemLTT.Enabled = false;
                    btnTTTrongTuan.Enabled = false;
                    btnTTQuaHan.Enabled = false;
                    btnThemDV.Enabled = false;
                    btnDsDV.Enabled = false;
                    btnThemNV.Enabled = false;
                    btnTimNV.Enabled = false;
                    btnSuaNV.Enabled = false;
                    btnXepLoaiNV.Enabled = false;

                    //bao cao thong ke
                    btnBCDsKH.Enabled = false;
                    btnThanhToanCanThu.Enabled = false;
                    btnCTNgay.Enabled = false;
                    btnTKDoanhThu.Enabled = false;
                    btnTKNo.Enabled = false;
                    btnDoanhThuvaNo.Enabled = false;

                    //admin
                    btnNguoiDung.Enabled = false;
                    btnThemNguoiDung.Enabled = false;
                    btnXoaNguoiDung.Enabled = false;
                    btnCauHinhCSDL.Enabled = false;
                    btnSaoLuu.Enabled = false;
                    btnPhucHoi.Enabled = false;
                    btnThongTinCSDL.Enabled = false;
                    btnCauHinhHeThong.Enabled = false;
                    btnXemNhatKy.Enabled = false;

                    return;
                }
                #endregion
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        private void btnDangNhap_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frmDangNhap frm = new frmDangNhap();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    lblQuyen.Caption = StaticClass.User.MoTaQuyen + ":";
                    lblTen.Caption = StaticClass.User.TenNguoiDung;
                }
                else
                {
                    lblQuyen.Caption = "Bạn chưa đăng nhập.";
                    lblTen.Caption = "Vui lòng đăng nhập để sử dụng hệ thống.";
                }
                PhanQuyen();
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
                return;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                DateTime now=DateTime.Now;
                lblNgayGio.Caption = now.ToString("HH:mm") + " ngày " + now.ToString("dd/MM/yyyy");
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
                return;
            }
        }

        private void frmChinh_Load(object sender, EventArgs e)
        {
            try
            {
                timer1_Tick(null, null);
                //đăng nhập và phân quyền
                frmDangNhap frm = new frmDangNhap();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    lblQuyen.Caption = StaticClass.User.MoTaQuyen + ":";
                    lblTen.Caption = StaticClass.User.TenNguoiDung;
                }
                PhanQuyen();
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
                return;
            }
        }

        private void btnCauHinhCSDL_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frmAddConnection frm = new frmAddConnection();
                log.GhiFile("Cấu hình kết nối CSDL");
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    if (xtraTabControl1.TabPages.Count > 0)
                    {
                        MsgboxUtil.Info("Chương trình sẽ đóng tất cả trang hiện tại để cấu hình CSDL");
                        xtraTabControl1.TabPages.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
                return;
            }
        }

        private void btnSaoLuu_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                string path = "";
                string fileName = "";
                DataProvider dp = new DataProvider();
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Backup file (*.bak)|*.bak";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    this.Cursor = Cursors.WaitCursor;
                    path = save.FileName;
                    fileName = Path.GetFileName(path);
                    path = path.Substring(0, path.Length - (fileName.Length + 1));
                    if (dp.BackupDatabase(fileName, path))
                    {
                        log.GhiFile("Sao lưu CSDL vào: " + save.FileName);
                        this.Cursor = Cursors.Default;
                        MsgboxUtil.Success("Sao lưu CSDL thành công!");
                    }
                }

            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void btnPhucHoi_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                string path = "";
                DataProvider dp = new DataProvider();
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Backup file (*.bak)|*.bak";
                open.Multiselect = false;
                if (open.ShowDialog() == DialogResult.OK)
                {
                    this.Cursor = Cursors.WaitCursor;
                    path = open.FileName;
                    if (dp.RestoreDatabase(path))
                    {
                        log.GhiFile("Phục hồi CSDL từ: " + path);
                        this.Cursor = Cursors.Default;
                        MsgboxUtil.Success("Phục hồi CSDL thành công!");
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void btnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                StaticClass.DangNhap = false;
                log.GhiFile("Đăng xuất hệ thống.");
                StaticClass.User = null;
                PhanQuyen();
                xtraTabControl1.TabPages.Clear();
                lblQuyen.Caption = "Bạn chưa đăng nhập.";
                lblTen.Caption = "Vui lòng đăng nhập để sử dụng hệ thống.";
                MsgboxUtil.Info("Bạn đã đăng xuất.\nVui lòng đăng nhập để sử dụng hệ thống.");
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
                return;
            }
        }

        private void btnDoiMatKhau_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frmDoiMatKhau frm = new frmDoiMatKhau();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void btnThoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (StaticClass.DangNhap)
                log.GhiFile("Thoát chương trình mà không đăng xuất.");
            Application.Exit();
        }

        private void btnThongTin_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmThongTinNguoiDung frm = new frmThongTinNguoiDung();
            frm.ShowDialog();
        }

        private void btnWeb_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                WBrowser.WBrowser frm = new WBrowser.WBrowser();
                log.GhiFile("Lướt web");
                TabCreating("Duyệt web", frm);
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
                return;
            }
        }

        private void btnRSS_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frmRSS frm = new frmRSS();
                log.GhiFile("Đọc tin tức (RSS)");
                TabCreating("Tin tức", frm);
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
                return;
            }
        }

        private void btnSuaKH_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frmCapNhatKhachHang frm = new frmCapNhatKhachHang();
                TabCreating("Cập nhật khách hàng", frm);
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void btnThemKH_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frmThemKhachHang frm = new frmThemKhachHang();
                TabCreating("Khách hàng mới", frm);
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void btnThemNV_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frmThemNhanVien frm = new frmThemNhanVien();
                TabCreating("Thêm nhân viên", frm);
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void btnSuaNV_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frmCapNhatNhanVien frm = new frmCapNhatNhanVien();
                TabCreating("Cập nhật nhân viên", frm);
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void btnThemDV_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frmThemChuongTrinh frm = new frmThemChuongTrinh();
                TabCreating("Dịch vụ mới", frm);
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void btnDsDV_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frmCapNhatChuongTrinh frm = new frmCapNhatChuongTrinh();
                TabCreating("Danh mục dịch vụ", frm);
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void btnTaoHD_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frmHopDongMoi frm = new frmHopDongMoi();
                TabCreating("Hợp đồng mới", frm);
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void btnDsHD_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frmDanhMucHopDong frm = new frmDanhMucHopDong();
                TabCreating("Danh mục hợp đồng", frm);
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void btnLapPTT_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frmLapPhieuThanhToan frm = new frmLapPhieuThanhToan();
                TabCreating("Lập phiếu thanh toán", frm);
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void bntTTKH_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frmThongTinKH frm = new frmThongTinKH();
                TabCreating("Xếp loại khách hàng", frm);
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void btnCTNgay_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frmBaoCaoChuongTrinhTheoNgay frm = new frmBaoCaoChuongTrinhTheoNgay();
                TabCreating("Chương trình tổ chức trong ngày", frm);
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void btnBCDsKH_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frmBaoCaoKhachHangKyNhieuHD frm = new frmBaoCaoKhachHangKyNhieuHD();
                TabCreating("KH nhiều hợp đồng", frm);
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void btnTTCT_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frmThongTinChuongTrinh frm = new frmThongTinChuongTrinh();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void btnXepLoaiNV_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frmThongTinNV frm = new frmThongTinNV();
                TabCreating("Xếp loại nhân viên", frm);
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void btnNguoiDung_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frmDanhMucNguoiDung frm = new frmDanhMucNguoiDung();
                TabCreating("Danh mục người dùng", frm);
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void btnXemNhatKy_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frmXemNhatKy frm = new frmXemNhatKy();
                TabCreating("Nhật ký hệ thống", frm);
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void frmChinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (StaticClass.DangNhap)
                    log.GhiFile("Thoát chương trình mà không đăng xuất.");
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void btnTTTrongTuan_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frmBaoCaoThanhToanCanThu frm = new frmBaoCaoThanhToanCanThu();
                TabCreating("Thanh toán cần thu theo tuần", frm);
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void btnThanhToanCanThu_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frmBaoCaoThanhToanCanThu frm = new frmBaoCaoThanhToanCanThu();
                TabCreating("Thanh toán cần thu theo tuần", frm);
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void btnTimKiemKH_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frmTimKiemKhachHang frm = new frmTimKiemKhachHang();
                TabCreating("Tìm kiếm khách hàng", frm);
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void btnNhapXuatDuLieu_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frmNhapXuatDuLieuNangCao frm = new frmNhapXuatDuLieuNangCao();
                TabCreating("Nhập xuất dữ liệu", frm);
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void btnHuongDan_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                Help.ShowHelp(this, "Tro_Giup.chm");
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }
    }
}