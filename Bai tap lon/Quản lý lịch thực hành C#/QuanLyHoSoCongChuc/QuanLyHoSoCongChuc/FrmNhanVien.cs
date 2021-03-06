using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using WeifenLuo.WinFormsUI.Docking;
using QuanLyHoSoCongChuc.BusinessObject;
using QuanLyHoSoCongChuc.Controller;
using QuanLyHoSoCongChuc.DataLayer;


namespace QuanLyHoSoCongChuc
{
    public partial class FrmNhanVien : DockContent
    {
        public FrmNhanVien()
        {
            InitializeComponent();
        }
      
        NhanVienInfo NhanVien = new NhanVienInfo();
        NhanVienControl m_NhanVienControl = new NhanVienControl();
        private void FrmNhanVien_Load(object sender, EventArgs e)
        {

            DataService.OpenConnection();
           
            m_NhanVienControl.HienThi(DGVNhanVien, bindingNavigatorNhanVien, txtMaNhanVien,txtHinhAnh, txtHoTen, txtTenGoiKhac, cbxGioiTinh, dtNgaySinh, txtNoiSinh, txtSoCMND, txtNoiCap, dtNgayCap, cbxDanToc, cbxTonGiao, txtQueQuan, txtHoKhauThuongTru, txtNoiOHienTai, txtDienThoaiNhaRieng, txtDienThoaiDiDong, cbxTinhTrangHonNhan, cbxThanhPhanXuatThan, cbxDienUuTienGiaDinh, cbxDienUuTienCuaBanThan, txtNangKhieu, dtNgayHopDong, dtNgayTuyenDung, cbxCoQuanTuyenDung, cbxHinhThucTuyenDung, cbxCongViecDuocGiao, dtNgayBoNhiemVaoNgach, dtNgayVeCoQuanHienNay, cbxLoaiCanBo, txtCongViecHienNay, cbxDangNghiBHXH, cbxChucVuHienTai, dtNgayBoNhiemChucVuHienTai, txtLanBoNhiem, txtChucVuKiemNhiem, txtChucVuCaoNhatDaQua, dtNgayVaoDangCSVN, dtNgayChinhThuc, txtChucVuDangHienTai, cbxDoanVien, dtNgayThamGiaTCCTXH, txtTenToChucCTXH, txtChucVuDoan, cbxDTBD, cbxTrinhDoHocVan, cbxTrinhDoChuyenMonCaoNhat, cbxTrinhDoLLCT, cbxTrinhDoQLNN, cbxTrinhDoTinHoc, cbxTrinhDoNgoaiNgu, cbxNgachCongChuc, txtMaNgach, txtBacLuong, txtHeSoLuong, cbxHuong85, txtChenhLechBaoLuuHSL, dtHuongTuNgay, dtMocTinhNangLuongLanSau,dtngaynangluong, txtHeSoPhuCapChucVu, txtPhuCapThamNienVuotKhung, txtHeSoPhuCapKiemNhiem, txtHeSoPhuCapKhac, txtSoSoBHXH, dtNgayBatDauDongBHXH);
            m_NhanVienControl.HienThiComBoBox(cbxDanToc, cbxTonGiao, cbxGioiTinh, cbxTinhTrangHonNhan, cbxThanhPhanXuatThan, cbxDienUuTienGiaDinh, cbxDienUuTienCuaBanThan, cbxCoQuanTuyenDung, cbxHinhThucTuyenDung, cbxCongViecDuocGiao, cbxLoaiCanBo, cbxDangNghiBHXH, cbxChucVuHienTai, cbxDoanVien, cbxDTBD, cbxTrinhDoHocVan, cbxTrinhDoChuyenMonCaoNhat, cbxTrinhDoLLCT, cbxTrinhDoQLNN, cbxTrinhDoTinHoc, cbxTrinhDoNgoaiNgu, cbxNgachCongChuc, cbxHuong85);
            this.Allow(false);

        }

        //Thêm dan toc
        private void btnThemDanToc_Click(object sender, EventArgs e)
        {
            FrmDanToc frm = new FrmDanToc();
            frm.Show();
        }
        //Thêm tôn giáo
        private void btnThemTonGiao_Click(object sender, EventArgs e)
        {
            FrmTonGiao frm = new FrmTonGiao();
            frm.Show();
        }
        //Thêm tình trạng hôn nhân
        private void btnThemTinhTrangHonNhan_Click(object sender, EventArgs e)
        {
            FrmTinhTrangHonNhan frm = new FrmTinhTrangHonNhan();
            frm.Show();
        }
        //Thêm thành phần xuất thân
        private void btnThemThanhPhanXuatThan_Click(object sender, EventArgs e)
        {
            FrmThanhPhanXuatThan frm = new FrmThanhPhanXuatThan();
            frm.Show();
        }
        //Thêm diện ưu tiên của gia đình
        private void btnThemDienUuTienCuaGiaDinh_Click(object sender, EventArgs e)
        {
            FrmDienUuTienGiaDinh frm = new FrmDienUuTienGiaDinh();
            frm.Show();
        }
        //Thêm diện ưu tiên của bản thân
        private void btnThemDienUuTienCuaBanThan_Click(object sender, EventArgs e)
        {
            FrmDienUuTienBanThan frm = new FrmDienUuTienBanThan();
            frm.Show();
        }

        //Thêm đơn vị
        private void DonVi_Click(object sender, EventArgs e)
        {
            FrmDonVi frm = new FrmDonVi();
            frm.Show();
        }
        //Thêm hình thức tuyển dụng
        private void HinhThucTuyenDung_Click(object sender, EventArgs e)
        {
            FrmHinhThucTuyenDung frm = new FrmHinhThucTuyenDung();
            frm.Show();
        }
        //Thêm công việc
        private void CongViec_Click(object sender, EventArgs e)
        {
            FrmCongViec frm = new FrmCongViec();
            frm.Show();
        }
        //Thêm loại cán bộ
        private void LoaiCanBo_Click(object sender, EventArgs e)
        {
            FrmLoaiCanBo frm = new FrmLoaiCanBo();
            frm.Show();
        }
        //Thêm loại nghĩ BHXH
        private void LoaiNghiBHXH_Click(object sender, EventArgs e)
        {
            FrmLoaiNghiBaoHiemXaHoi frm = new FrmLoaiNghiBaoHiemXaHoi();
            frm.Show();
        }
        //Thêm chức vụ
        private void ChucVu_Click(object sender, EventArgs e)
        {
            FrmChucVu frm = new FrmChucVu();
            frm.Show();
        }
        //Thêm trình độ học vấn
        private void TrinhDoHocVan_Click(object sender, EventArgs e)
        {
            FrmTrinhDoHocVan frm = new FrmTrinhDoHocVan();
            frm.Show();
        }
        //Thêm trình độ chuyên môn
        private void TrinhDoChuyenMon_Click(object sender, EventArgs e)
        {
            FrmTrinhDoChuyenMon frm = new FrmTrinhDoChuyenMon();
            frm.Show();
        }
        //Thêm trình độ chính trị
        private void TrinhDoChinhTri_Click(object sender, EventArgs e)
        {
            FrmTrinhDoChinhTri frm = new FrmTrinhDoChinhTri();
            frm.Show();
        }
        //Thêm trình độ quản lý nhà nước
        private void TrinhDoQuanLyNhaNuoc_Click(object sender, EventArgs e)
        {
            FrmTrinhDoQuanLyNhaNuoc frm = new FrmTrinhDoQuanLyNhaNuoc();
            frm.Show();
        }
        //Thêm trình độ tin học
        private void TrinhDoTinHoc_Click(object sender, EventArgs e)
        {
            FrmTrinhDoTinHoc frm = new FrmTrinhDoTinHoc();
            frm.Show();
        }
        //Thêm trình độ ngoại ngữ
        private void TrinhDoNgoaiNgu_Click(object sender, EventArgs e)
        {
            FrmTrinhDoNgoaiNgu frm = new FrmTrinhDoNgoaiNgu();
            frm.Show();

        }
        //Thêm ngạch công chức
        private void NgachCongChuc_Click(object sender, EventArgs e)
        {
            FrmNgachCongChuc frm = new FrmNgachCongChuc();
            frm.Show();
        }

        //Thêm Nhân viên
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Xem();
            DataRow m_Row = m_NhanVienControl.ThemDongMoi();

            m_Row["MaNhanVien"] = "";
            m_Row["HinhAnh"] = "";
            m_Row["HoTenNhanVien"] = "";
            m_Row["TenGoiKhac"] = "";
            m_Row["MaGioiTinh"] = "";
            m_Row["NgaySinh"] = DateTime.Today;
            m_Row["NoiSinh"] = "";
            m_Row["SoChungMinhNhanDan"] = "";
            m_Row["NoiCap"] = "";
            m_Row["NgayCap"] = DateTime.Today;
            m_Row["MaDanToc"] = "";
            m_Row["MaTonGiao"] = "";
            m_Row["QueQuan"] = "";
            m_Row["HoKhauThuongTru"] = "";
            m_Row["NoiOHienTai"] = "";
            m_Row["DienThoaiNhaRieng"] = "";
            m_Row["DienThoaiDiDong"] = "";
            m_Row["MaTinhTrangHonNhan"] = "";
            m_Row["MaThanhPhanXuatThan"] = "";
            m_Row["MaDienUuTienCuaGiaDinh"] = "";
            m_Row["MaDienUuTienCuaBanThan"] = "";
            m_Row["NangKhieu"] = "";
            m_Row["NgayHopDong"] = DateTime.Today;
            m_Row["NgayTuyenDung"] = DateTime.Today;
            m_Row["MaHinhThucTuyenDung"] = "";
            m_Row["MaDonVi"] = "";
            m_Row["MaCongViec"] = "";
            m_Row["NgayBoNhiemVaoNgach"] = DateTime.Today;
            m_Row["NgayVeCoQuanHienTai"] = DateTime.Today;
            m_Row["MaLoaiCanBo"] = "";
            m_Row["CongViecHienNay"] = "";
            m_Row["MaLoaiNghiBaoHiemXaHoi"] = "";
            m_Row["MaChucVu"] = "";
            m_Row["HeSoPhuCapChucVu"] = "";
            m_Row["NgayBoNhiemChucVuHienTai"] = DateTime.Today;
            m_Row["LanBoNhiemCVCQHienTai"] = "";
            m_Row["ChucVuLanhDaoKiemNhiem"] = "";
            m_Row["ChucVuChinhQuyenCaoNhat"] = "";
            m_Row["NgayVaoDang"] = DateTime.Today;
            m_Row["NgayChinhThuc"] = DateTime.Today;
            m_Row["ChucVuDangHienTai"] = "";
            m_Row["DoanVien"] = "";

            m_Row["NgayThamGiaTCCTXH"] = DateTime.Today;
            m_Row["TenTCCTXH"] = "";
            m_Row["ChucVuDoan"] = "";
            m_Row["DangDTBD"] = "";
            m_Row["MaTrinhDoHocVan"] = "";
            m_Row["MaTrinhDoChuyenMon"] = "";
            m_Row["MaTrinhDoChinhTri"] = "";
            m_Row["MaTrinhDoQuanLyNhaNuoc"] = "";
            m_Row["MaTrinhDoTinHoc"] = "";
            m_Row["MaTrinhDoNgoaiNgu"] = "";
            m_Row["MaNgach"] = "";
            m_Row["BacLuong"] = "";
            m_Row["HeSoLuong"] = "";
            m_Row["LuongCongChucDuBi"] = "";
            m_Row["ChenhLechBaoLuuHeSoLuong"] = "";
            m_Row["HuongLuongTuNgay"] = DateTime.Today;
            m_Row["MocTinhNangLuongLanSau"] = DateTime.Today;
            m_Row["HeSoPhuCapThamNienVuotKhung"] = "";
            m_Row["HeSoPhuCapKiemNhiem"] = "";
            m_Row["HeSoPhuCapKhac"] = "";
            m_Row["SoSoBHXH"] = "";
            m_Row["NgayDongBHXH"] = DateTime.Today;
            m_NhanVienControl.ThemNhanVien(m_Row);
            bindingNavigatorNhanVien.BindingSource.MoveLast();

            this.Allow(true);
        }
        //Lưu
        private void Luu_Click(object sender, EventArgs e)
        {
            bindingNavigatorNhanVien.BindingSource.MoveNext();
            m_NhanVienControl.LuuNhanVien();
            MessageBox.Show("Lưu dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        void Allow(bool val)
        {
            txtMaNhanVien.Enabled = val;
            txtHoTen.Enabled = val;
            DGVNhanVien.Enabled = val;
            toolStripLuu.Enabled = val;
            bindingNavigatorXoa.Enabled = val;
          
        }
        public void Xem()
        {
            DGVNhanVien.Enabled = true;
            m_NhanVienControl.HienThi(DGVNhanVien, bindingNavigatorNhanVien, txtMaNhanVien,txtHinhAnh, txtHoTen, txtTenGoiKhac, cbxGioiTinh, dtNgaySinh, txtNoiSinh, txtSoCMND, txtNoiCap, dtNgayCap, cbxDanToc, cbxTonGiao, txtQueQuan, txtHoKhauThuongTru, txtNoiOHienTai, txtDienThoaiNhaRieng, txtDienThoaiDiDong, cbxTinhTrangHonNhan, cbxThanhPhanXuatThan, cbxDienUuTienGiaDinh, cbxDienUuTienCuaBanThan, txtNangKhieu, dtNgayHopDong, dtNgayTuyenDung, cbxCoQuanTuyenDung, cbxHinhThucTuyenDung, cbxCongViecDuocGiao, dtNgayBoNhiemVaoNgach, dtNgayVeCoQuanHienNay, cbxLoaiCanBo, txtCongViecHienNay, cbxDangNghiBHXH, cbxChucVuHienTai, dtNgayBoNhiemChucVuHienTai, txtLanBoNhiem, txtChucVuKiemNhiem, txtChucVuCaoNhatDaQua, dtNgayVaoDangCSVN, dtNgayChinhThuc, txtChucVuDangHienTai, cbxDoanVien, dtNgayThamGiaTCCTXH, txtTenToChucCTXH, txtChucVuDoan, cbxDTBD, cbxTrinhDoHocVan, cbxTrinhDoChuyenMonCaoNhat, cbxTrinhDoLLCT, cbxTrinhDoQLNN, cbxTrinhDoTinHoc, cbxTrinhDoNgoaiNgu, cbxNgachCongChuc, txtMaNgach, txtBacLuong, txtHeSoLuong, cbxHuong85, txtChenhLechBaoLuuHSL, dtHuongTuNgay, dtMocTinhNangLuongLanSau,dtngaynangluong, txtHeSoPhuCapChucVu, txtPhuCapThamNienVuotKhung, txtHeSoPhuCapKiemNhiem, txtHeSoPhuCapKhac, txtSoSoBHXH, dtNgayBatDauDongBHXH);
        }

        //Xem danh sách nhân viên
        private void toolStripXemDS_Click(object sender, EventArgs e)
        {
            this.Allow(false);
            DGVNhanVien.Enabled = true;
            m_NhanVienControl.HienThi(DGVNhanVien, bindingNavigatorNhanVien, txtMaNhanVien, txtHinhAnh, txtHoTen, txtTenGoiKhac, cbxGioiTinh, dtNgaySinh, txtNoiSinh, txtSoCMND, txtNoiCap, dtNgayCap, cbxDanToc, cbxTonGiao, txtQueQuan, txtHoKhauThuongTru, txtNoiOHienTai, txtDienThoaiNhaRieng, txtDienThoaiDiDong, cbxTinhTrangHonNhan, cbxThanhPhanXuatThan, cbxDienUuTienGiaDinh, cbxDienUuTienCuaBanThan, txtNangKhieu, dtNgayHopDong, dtNgayTuyenDung, cbxCoQuanTuyenDung, cbxHinhThucTuyenDung, cbxCongViecDuocGiao, dtNgayBoNhiemVaoNgach, dtNgayVeCoQuanHienNay, cbxLoaiCanBo, txtCongViecHienNay, cbxDangNghiBHXH, cbxChucVuHienTai, dtNgayBoNhiemChucVuHienTai, txtLanBoNhiem, txtChucVuKiemNhiem, txtChucVuCaoNhatDaQua, dtNgayVaoDangCSVN, dtNgayChinhThuc, txtChucVuDangHienTai, cbxDoanVien, dtNgayThamGiaTCCTXH, txtTenToChucCTXH, txtChucVuDoan, cbxDTBD, cbxTrinhDoHocVan, cbxTrinhDoChuyenMonCaoNhat, cbxTrinhDoLLCT, cbxTrinhDoQLNN, cbxTrinhDoTinHoc, cbxTrinhDoNgoaiNgu, cbxNgachCongChuc, txtMaNgach, txtBacLuong, txtHeSoLuong, cbxHuong85, txtChenhLechBaoLuuHSL, dtHuongTuNgay, dtMocTinhNangLuongLanSau,dtngaynangluong, txtHeSoPhuCapChucVu, txtPhuCapThamNienVuotKhung, txtHeSoPhuCapKiemNhiem, txtHeSoPhuCapKhac, txtSoSoBHXH, dtNgayBatDauDongBHXH);
        }
        //Thoát
        private void toolStripThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Xóa nhân viên
        private void bindingNavigatorXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorNhanVien.BindingSource.RemoveCurrent();
            }
        }
        //Sửa nhân viên
        private void toolStripSua_Click(object sender, EventArgs e)
        {
            Xem();
            this.Allow(true);
        }

        
       
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            m_NhanVienControl.HienThiComBoBox(cbxDanToc, cbxTonGiao, cbxGioiTinh, cbxTinhTrangHonNhan, cbxThanhPhanXuatThan, cbxDienUuTienGiaDinh, cbxDienUuTienCuaBanThan, cbxCoQuanTuyenDung, cbxHinhThucTuyenDung, cbxCongViecDuocGiao, cbxLoaiCanBo, cbxDangNghiBHXH, cbxChucVuHienTai, cbxDoanVien, cbxDTBD, cbxTrinhDoHocVan, cbxTrinhDoChuyenMonCaoNhat, cbxTrinhDoLLCT, cbxTrinhDoQLNN, cbxTrinhDoTinHoc, cbxTrinhDoNgoaiNgu, cbxNgachCongChuc, cbxHuong85);
        }

        private void DGVNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow row = ((DataGridView)sender).CurrentRow;
            picNv.ImageLocation = row.Cells["HinhAnh"].Value.ToString();
        }

        private void picNv_Click(object sender, EventArgs e)
        {

        }

    }
}