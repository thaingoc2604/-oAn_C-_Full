using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing.Imaging;
using System.Drawing;
using System.Text;
using DevComponents.DotNetBar;
using System.Windows.Forms;
using System.Collections;
using TT_GDTX_ANGIANG.BusinessObject;
using TT_GDTX_ANGIANG.Controller;
using TT_GDTX_ANGIANG.DataLayer;

namespace TT_GDTX_ANGIANG
{
    public partial class frm_NHANVIEN1 : DevComponents.DotNetBar.Office2007Form
    {
        public frm_NHANVIEN1()
        {
            InitializeComponent();
        }

        #region PhanQuyen_Xem
        public void PhanQuyen_Xem_An()
        {
            this.btThemNhanVien.Enabled = false;
            this.btXoaNhanVien.Enabled = false;
            this.btLuuNhanVien.Enabled = false;
            this.btInSoYeuLyLichNhanVien.Enabled = false;
           
        }
        public void PhanQuyen_Xem_Hien()
        {
            this.btThemNhanVien.Enabled = true;
            this.btXoaNhanVien.Enabled = true;
            this.btLuuNhanVien.Enabled = true;
            this.btInSoYeuLyLichNhanVien.Enabled = true;
            
        }
        #endregion

        #region Property NhanVien

        private NhanVienInfo m_NhanVienSelected;
        public NhanVienInfo NhanVienSelected
        {
            get { return m_NhanVienSelected; }
            set { m_NhanVienSelected = value; }
        }

        private string m_Open;
        public string Open
        {
            get { return m_Open; }
            set { m_Open = value; }
        }

        private string m_MaNV;
        public string MaNhanVien
        {
            get { return m_MaNV; }
            set { m_MaNV = value; }
        }
        private string m_PH;
        public string MaPhong
        {
            get { return m_PH; }
            set { m_PH = value; }
        }
        private string m_Enable;
        public string An_Hien
        {
            get { return m_Enable; }
            set { m_Enable = value; }
        }
        #endregion

        #region IsAddNew
        /// <summary>
        /// True trong khi chon Them, sau do chon Save.
        /// </summary>
        private bool m_IsAddNew;
        public bool IsAddNew
        {
            get { return m_IsAddNew; }
            set { m_IsAddNew = value; }
        }
        #endregion

        #region ctrlNhanVien
        private NhanVienCtrl m_ctrlNhanVien;
        public NhanVienCtrl ctrlNhanVien
        {
            get { return m_ctrlNhanVien; }
            set { m_ctrlNhanVien = value; }
        }
        #endregion

        #region SelectedIndex
        /// <summary>
        /// Vi tri dong da chon
        /// </summary>
        private int m_SelectedIndex;
        public int SelectedIndex
        {
            get { return m_SelectedIndex; }
            set { m_SelectedIndex = value; }
        }
        #endregion

        #region btThoatNhanSu_Click       
        
        private void btThoatNhanSu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region frm_NHANVIEN1_Load        
       
        private void frm_NHANVIEN1_Load(object sender, EventArgs e)
        {
            #region HienThi Combobox

            PhongBanCtrl ctrlPhongBan = new PhongBanCtrl();
            ctrlPhongBan.HienThiComboBox(this.cboPhongBan);

          

            ChucVuCtrl ctrlChucVu = new ChucVuCtrl();
            ctrlChucVu.HienThiComboBox(this.cboChucVuHienNay);


            DanTocCtrl ctrlDanToc = new DanTocCtrl();
            ctrlDanToc.HienThiComboBox(this.cboDanToc);

            TonGiaoCtrl ctrlTonGiao = new TonGiaoCtrl();
            ctrlTonGiao.HienThiComboBox(this.cboTonGiao);

            QuocTichCtrl ctrlQuocTich = new QuocTichCtrl();
            ctrlQuocTich.HienThiComboBox(this.cboQuocTich);


            NgoaiNguCtrl ctrlNgoaiNgu = new NgoaiNguCtrl();
            ctrlNgoaiNgu.HienThiComboBox(this.cboNgoaiNguChinh);

            TrinhDo_TinHocCtrl ctrlTD_TinHoc = new TrinhDo_TinHocCtrl();
            ctrlTD_TinHoc.HienThiComboBox(this.cboTDTinHoc);

            TrinhDo_NgoaiNguCtrl ctrlTD_NgoaiNgu = new TrinhDo_NgoaiNguCtrl();
            ctrlTD_NgoaiNgu.HienThiComboBox(this.cboTDNgoaiNgu);

            TrinhDo_HocVanCtrl ctrlTD_HocVan = new TrinhDo_HocVanCtrl();
            ctrlTD_HocVan.HienThiComboBox(this.cboHocVanPhoThong);




            #endregion

            if (An_Hien == "Xem")
            {
                this.PhanQuyen_Xem_An();
            }
            else
            {
                this.PhanQuyen_Xem_Hien();
            }

            if (this.Open != "Open")
            {
                this.IsAddNew = false;

                this.txtMaNV.Text = NhanVienSelected.MaNhanVien;
                this.txtHoTen.Text = NhanVienSelected.HoTen;
                this.txtBiDanh.Text = NhanVienSelected.BiDanh;
                if (NhanVienSelected.GioiTinh == 1)
                {
                    this.radNam.Checked = true;
                    this.linkThaiSan.Enabled = false;
                }
                else
                {
                    this.radNu.Checked = true;
                    this.linkThaiSan.Enabled = true;
                }
                this.dtNgaySinh.Value = NhanVienSelected.NgaySinh;
                this.txtNoiSinh.Text = NhanVienSelected.NoiSinh;
                this.txtCMND.Text = NhanVienSelected.ChungMinh;
                this.dtNgayCapCMND.Value = NhanVienSelected.NgayCapCMND;
                this.txtNoiCapCMND.Text = NhanVienSelected.NoiCapCMND;
                //this.picHinhAnh.Tag = null;


                this.txtQueQuan.Text = NhanVienSelected.QueQuan;
                this.txtDChiThuongTru.Text = NhanVienSelected.DC_ThuongTru;
                this.txtNoiOHienNay.Text = NhanVienSelected.NoiOHienNay;
                this.txtDThoaiNha.Text = NhanVienSelected.DienThoaiNha;
                this.txtDThoaiDD.Text = NhanVienSelected.DienThoaiDiDong;
                this.txtEmail.Text = NhanVienSelected.Email;
                this.cboTinhTrangHonNhan.Text = NhanVienSelected.TinhTrangHonNhan;
                this.cboHinhThucDaoTao.Text = NhanVienSelected.HinhThucDaoTao;
                this.cboTinhTrangSucKhoe.Text = NhanVienSelected.TinhTrangSucKhoe;
                this.cboNhomMau.Text = NhanVienSelected.NhomMau;
                this.txtCanNang.Text = Convert.ToString(NhanVienSelected.ChieuCao);
                this.txtChieuCao.Text = Convert.ToString(NhanVienSelected.CanNang);

                this.txtChucVuCongDoan.Text = NhanVienSelected.ChucVuCD;
                this.txtChucVuDang.Text = NhanVienSelected.ChucVuDang;
                this.txtChucVuDoan.Text = NhanVienSelected.ChucVuDoan;
                this.txtChuyenNganhDaoTao.Text = NhanVienSelected.ChuyenNganhDaoTao;
                this.txtCoQuanTuyenDung.Text = NhanVienSelected.CoQuanTuyenDung;
                this.txtDaTotNghiep.Text = NhanVienSelected.DaTotNghiep;
                this.txtDienUuTienBanThan.Text = NhanVienSelected.UuTienBanThan;
                this.txtDienUuTienGiaDinh.Text = NhanVienSelected.UuTienGiaDinh;
                this.txtHinhThucTuyenDung.Text = NhanVienSelected.HinhThucTuyenDung;
                this.txtKhuyetTat.Text = NhanVienSelected.KhuyetTat;
                //this.txtNamTotNghiep.Text = NhanVienSelected.NamTotNghiep;
                this.txtNangKhieu.Text = NhanVienSelected.NangKhieu;
                this.txtNganhDaoTao.Text = NhanVienSelected.NganhDaoTao;
                this.txtNgoaiNgucKhac.Text = NhanVienSelected.NgoaiNguKhac;
                this.txtNoiDaoTao.Text = NhanVienSelected.NoiDaoTao;
                this.txtNoiVaoDang.Text = NhanVienSelected.NoiVaoDang;
                this.txtNoiVaoDoan.Text = NhanVienSelected.NoiVaoDoan;
                this.txtThanhPhanXuatThan.Text = NhanVienSelected.ThanhPhanXuatThan;
                this.txtTrinhDoChuyenMonCaoNhat.Text = NhanVienSelected.TD_ChuyenMonCaoNhat;
                this.txtTDLyLuanChinhTri.Text = NhanVienSelected.TD_LyLuanChinhTri;
                this.txtTDQuanLyNhaNuoc.Text = NhanVienSelected.TD_QuanLyNhaNuoc;
                this.txtTDQuanLyGiaoDuc.Text = NhanVienSelected.TD_QuanLyGiaoDuc;
                this.txtTenCongDoan.Text = NhanVienSelected.TenCD;
                this.dtNgayHopDong.Value = NhanVienSelected.NgayHopDong;
                this.dtNgayVeCoQuan.Value = NhanVienSelected.NgayVaoCQ;
                this.dtNgayVaoNgayGiaoDuc.Value = NhanVienSelected.NgayVaoNganhGiaoDuc;
                this.dtNgayCT_VaoDang.Value = NhanVienSelected.NgayCT_VaoDang;
                this.dtNgayTuyenDung.Value = NhanVienSelected.NgayTuyenDung;
                this.dtNgayVaoCongDoan.Value = NhanVienSelected.NgayVaoCD;
                this.dtNgayVaoDang.Value = NhanVienSelected.NgayVaoDang;
                this.dtNgayVaoDoan.Value = NhanVienSelected.NgayVaoDoan;

                this.cboChucVuHienNay.Text = NhanVienSelected.ChucVu.TenChucVu;
                this.cboDanToc.Text = NhanVienSelected.DanToc.TenDanToc;
                this.cboTonGiao.Text = NhanVienSelected.TonGiao.TenTonGiao;
                this.cboQuocTich.Text = NhanVienSelected.QuocTich.TenQuocTich;
                this.cboPhongBan.Text = NhanVienSelected.PhongBan.TenPhong;
                this.cboNgoaiNguChinh.Text = NhanVienSelected.NgoaiNgu.TenNgoaiNgu;
                this.cboTDNgoaiNgu.Text = NhanVienSelected.TD_NgoaiNgu.TenTrinhDoNgoaiNgu;
                this.cboTDTinHoc.Text = NhanVienSelected.TD_TinHoc.TenTrinhDoTinHoc;
                this.cboHocVanPhoThong.Text = NhanVienSelected.HocVanPhoThong.TenHocVan;

                this.picHinhAnh.ImageLocation = NhanVienSelected.HinhAnh;


                ///////////////////////

                this.txtCongViecHienNay.Text = NhanVienSelected.CongViecHienNay;
                this.txtCongViecDuocGiao.Text = NhanVienSelected.CongViecDuocGiao;
                this.txtSoQuyetDinh.Text = NhanVienSelected.SoQuyetDinh;

            }
            else
            {
                this.IsAddNew = true;
                this.txtHoTen.Focus();
            }

        }
        #endregion

        #region btThemNhanVien_Click        
       
        private void btThemNhanVien_Click(object sender, EventArgs e)
        {

            if (!this.IsAddNew)
            {
                this.txtMaNV.Text = null;
                this.txtHoTen.Text = null;
                this.txtBiDanh.Text = null;
                this.dtNgaySinh.Text = null;
                this.txtNoiSinh.Text = null;
                this.txtCMND.Text = null;
                this.dtNgayCapCMND.Text = null;
                this.txtNoiCapCMND.Text = null;
                this.picHinhAnh.Tag = null;


                this.cboTinhTrangHonNhan.Text = "Độc Thân";
                this.cboTinhTrangSucKhoe.Text = "Tốt";
                this.cboNhomMau.Text = "A";
                this.cboHinhThucDaoTao.Text = "Chính Quy";
                this.cboDanToc.SelectedText = "";
                this.cboTonGiao.SelectedText = "";
                this.cboQuocTich.SelectedText = "";
                this.cboNgoaiNguChinh.SelectedText = "";
                this.txtQueQuan.Text = null;
                this.txtDChiThuongTru.Text = null;
                this.txtNoiOHienNay.Text = null;
                this.txtDThoaiNha.Text = null;
                this.txtDThoaiNha.Text = null;
                this.txtEmail.Text = null;
                this.txtCanNang.Text = null;
                this.txtChieuCao.Text = null;
                this.txtChucVuCongDoan.Text = null;
                this.txtChucVuDang.Text = null;
                this.txtChucVuDoan.Text = null;
                this.txtChuyenNganhDaoTao.Text = null;
                this.txtCoQuanTuyenDung.Text = null;
                this.txtDaTotNghiep.Text = null;
                this.txtDienUuTienBanThan.Text = null;
                this.txtDienUuTienGiaDinh.Text = null;
                this.txtHinhThucTuyenDung.Text = null;
                this.txtKhuyetTat.Text = null;
                //this.txtNamTotNghiep.Text = null;
                this.txtNangKhieu.Text = null;
                this.txtNganhDaoTao.Text = null;
                this.txtNgoaiNgucKhac.Text = null;
                this.txtNoiDaoTao.Text = null;
                this.txtNoiVaoDang.Text = null;
                this.txtNoiVaoDoan.Text = null;
                this.txtThanhPhanXuatThan.Text = null;
                this.txtTrinhDoChuyenMonCaoNhat.Text = null;
                this.txtTDLyLuanChinhTri.Text = null;
                this.txtTDQuanLyNhaNuoc.Text = null;
                this.txtTDQuanLyGiaoDuc.Text = null;
                this.dtNgayCT_VaoDang.Text = null;
                this.dtNgayTuyenDung.Text = null;
                this.dtNgayVaoCongDoan.Text = null;
                this.dtNgayVaoDang.Text = null;
                this.dtNgayVaoDoan.Text = null;
                this.txtCongViecDuocGiao.Text = null;
                this.txtCongViecHienNay.Text = null;
                this.txtSoQuyetDinh.Text = null;

                #region HienThiComboBox
                PhongBanCtrl ctrlPhongBan = new PhongBanCtrl();
                ctrlPhongBan.HienThiComboBox(this.cboPhongBan);

              

                ChucVuCtrl ctrlChucVu = new ChucVuCtrl();
                ctrlChucVu.HienThiComboBox(this.cboChucVuHienNay);


                DanTocCtrl ctrlDanToc = new DanTocCtrl();
                ctrlDanToc.HienThiComboBox(this.cboDanToc);

                TonGiaoCtrl ctrlTonGiao = new TonGiaoCtrl();
                ctrlTonGiao.HienThiComboBox(this.cboTonGiao);

                QuocTichCtrl ctrlQuocTich = new QuocTichCtrl();
                ctrlQuocTich.HienThiComboBox(this.cboQuocTich);


                NgoaiNguCtrl ctrlNgoaiNgu = new NgoaiNguCtrl();
                ctrlNgoaiNgu.HienThiComboBox(this.cboNgoaiNguChinh);

                TrinhDo_TinHocCtrl ctrlTD_TinHoc = new TrinhDo_TinHocCtrl();
                ctrlTD_TinHoc.HienThiComboBox(this.cboTDTinHoc);

                TrinhDo_NgoaiNguCtrl ctrlTD_NgoaiNgu = new TrinhDo_NgoaiNguCtrl();
                ctrlTD_NgoaiNgu.HienThiComboBox(this.cboTDNgoaiNgu);

                TrinhDo_HocVanCtrl ctrlTD_HocVan = new TrinhDo_HocVanCtrl();
                ctrlTD_HocVan.HienThiComboBox(this.cboHocVanPhoThong);
                #endregion

                this.IsAddNew = true;
            }
            if (ctrlNhanVien == null)
                ctrlNhanVien = new NhanVienCtrl();
            ctrlNhanVien.Create(txtMaNV);
            //this.tab1_TTCoBan.Show();
            //this.tab1_TTCoBan.Focus();
            this.txtHoTen.Focus();
        }
        #endregion

        #region btLuuNhanVien_Click

        private void btLuuNhanVien_Click(object sender, EventArgs e)
        {
            if (this.CheckValid())
            {
                NhanVienInfo info = new NhanVienInfo();
                try
                {
                    info.MaNhanVien = this.txtMaNV.Text;
                    info.HoTen = this.txtHoTen.Text;
                    info.BiDanh = this.txtBiDanh.Text;
                    info.NgaySinh = this.dtNgaySinh.Value;
                    info.NoiSinh = this.txtNoiSinh.Text;
                    if (this.radNam.Checked == true)
                    {
                        info.GioiTinh = int.Parse("1");
                    }
                    else
                    {
                        info.GioiTinh = int.Parse("0");
                    }

                    info.ChungMinh = this.txtCMND.Text;
                    info.NgayCapCMND = this.dtNgayCapCMND.Value;
                    info.NoiCapCMND = this.txtNoiCapCMND.Text;

                    PhongBanCtrl ctrPhongBan = new PhongBanCtrl();
                    info.PhongBan = ctrPhongBan.GetPhongBan(this.cboPhongBan.SelectedValue.ToString());

                    DanTocCtrl ctrDT = new DanTocCtrl();
                    info.DanToc = ctrDT.GetDanToc(this.cboDanToc.SelectedValue.ToString());


                    TonGiaoCtrl ctrTG = new TonGiaoCtrl();
                    info.TonGiao = ctrTG.GetTonGiao(this.cboTonGiao.SelectedValue.ToString());


                    QuocTichCtrl ctrQT = new QuocTichCtrl();
                    info.QuocTich = ctrQT.GetQuocTich(this.cboQuocTich.SelectedValue.ToString());

                    TrinhDo_HocVanCtrl ctrTD_HocVan = new TrinhDo_HocVanCtrl();
                    info.HocVanPhoThong = ctrTD_HocVan.GetTrinhDoHocVan(this.cboHocVanPhoThong.SelectedValue.ToString());

                    NgoaiNguCtrl ctrNgoaiNgu = new NgoaiNguCtrl();
                    info.NgoaiNgu = ctrNgoaiNgu.GetNgoaiNgu(this.cboNgoaiNguChinh.SelectedValue.ToString());

                    TrinhDo_NgoaiNguCtrl ctrTD_NgoaiNgu = new TrinhDo_NgoaiNguCtrl();
                    info.TD_NgoaiNgu = ctrTD_NgoaiNgu.GetTrinhDoNgoaiNgu(this.cboTDNgoaiNgu.SelectedValue.ToString());

                    TrinhDo_TinHocCtrl ctrTD_TinHoc = new TrinhDo_TinHocCtrl();
                    info.TD_TinHoc = ctrTD_TinHoc.GetTrinhDoTinHoc(this.cboTDTinHoc.SelectedValue.ToString());

                    ChucVuCtrl ctrlChucVu = new ChucVuCtrl();
                    info.ChucVu = ctrlChucVu.GetChucVu(this.cboChucVuHienNay.SelectedValue.ToString());

                    ////info.SoQuyetDinh = this.txtSoQuyetDinh.Text;
                    ////info.NgayVaoCQ = this.dtNgayVeCoQuan.Value;
                    ////info.ChucVu = this.cboChucVuHienNay.SelectedValue.ToString();

                    string tenhinh;

                    tenhinh = txtMaNV.Text.ToString();
                    if (picHinhAnh.Image == null)
                    {
                        info.HinhAnh = null;

                    }
                    else
                    {
                        picHinhAnh.Image.Save(Application.StartupPath + "/image/" + tenhinh + ".jpg");
                        info.HinhAnh = "image/" + tenhinh + ".jpg";
                    }

                    //////////////////

                    info.QueQuan = this.txtQueQuan.Text;
                    info.DC_ThuongTru = this.txtDChiThuongTru.Text;
                    info.NoiOHienNay = this.txtNoiOHienNay.Text;
                    info.DienThoaiNha = this.txtDThoaiNha.Text;
                    info.DienThoaiDiDong = this.txtDThoaiDD.Text;
                    info.TinhTrangHonNhan = this.cboTinhTrangHonNhan.SelectedItem.ToString();
                    info.TinhTrangSucKhoe = this.cboTinhTrangSucKhoe.SelectedItem.ToString();
                    info.NhomMau = this.cboNhomMau.SelectedItem.ToString();
                    info.HinhThucDaoTao = this.cboHinhThucDaoTao.SelectedItem.ToString();

                    info.Email = this.txtEmail.Text;



                    info.ChucVuCD = this.txtChucVuCongDoan.Text;
                    info.ChucVuDang = this.txtChucVuDang.Text;
                    info.ChucVuDoan = this.txtChucVuDoan.Text;
                    info.ChuyenNganhDaoTao = this.txtChuyenNganhDaoTao.Text;
                    info.CoQuanTuyenDung = this.txtCoQuanTuyenDung.Text;
                    info.DaTotNghiep = this.txtDaTotNghiep.Text;
                    info.HinhThucTuyenDung = this.txtHinhThucTuyenDung.Text;

                    info.KhuyetTat = this.txtKhuyetTat.Text;
                    //info.NamTotNghiep = this.txtNamTotNghiep.Text;
                    info.NangKhieu = this.txtNangKhieu.Text;
                    info.NganhDaoTao = this.txtNganhDaoTao.Text;

                    info.NgayCT_VaoDang = this.dtNgayCT_VaoDang.Value;

                    info.NgayTuyenDung = this.dtNgayTuyenDung.Value;
                    info.NgayVaoCD = this.dtNgayVaoCongDoan.Value;
                    info.NgayVaoDang = this.dtNgayVaoDang.Value;
                    info.NgayVaoDoan = this.dtNgayVaoDoan.Value;
                    info.NgayHopDong = this.dtNgayHopDong.Value;
                    info.NgayVaoCQ = this.dtNgayVeCoQuan.Value;
                    info.NgayVaoNganhGiaoDuc = this.dtNgayVaoNgayGiaoDuc.Value;

                    info.NgoaiNguKhac = this.txtNgoaiNgucKhac.Text;

                    info.NoiDaoTao = this.txtNoiDaoTao.Text;
                    info.NoiOHienNay = this.txtNoiOHienNay.Text;
                    info.NoiVaoDang = this.txtNoiVaoDang.Text;
                    info.NoiVaoDoan = this.txtNoiVaoDoan.Text;

                    info.TD_ChuyenMonCaoNhat = this.txtTrinhDoChuyenMonCaoNhat.Text;
                    info.TD_LyLuanChinhTri = this.txtTDLyLuanChinhTri.Text;
                    info.TD_QuanLyGiaoDuc = this.txtTDQuanLyGiaoDuc.Text;
                    info.TD_QuanLyNhaNuoc = this.txtTDQuanLyNhaNuoc.Text;
                    info.TenCD = this.txtTenCongDoan.Text;
                    info.ThanhPhanXuatThan = this.txtThanhPhanXuatThan.Text;

                    info.UuTienBanThan = this.txtDienUuTienBanThan.Text;
                    info.UuTienGiaDinh = this.txtDienUuTienGiaDinh.Text;
                    /////////////////////////////
                    info.SoQuyetDinh = this.txtSoQuyetDinh.Text;
                    info.CongViecHienNay = this.txtCongViecHienNay.Text;
                    info.CongViecDuocGiao = this.txtCongViecDuocGiao.Text;

                    //////////////////////////





                    info.Status = byte.Parse("1");
                    info.CanNang = Convert.ToDecimal(this.txtCanNang.Text);
                    info.ChieuCao = Convert.ToDecimal(this.txtChieuCao.Text);
                }
                catch { }
                if (IsAddNew)
                {
                    if (ctrlNhanVien == null)
                        ctrlNhanVien = new NhanVienCtrl();
                    if (ctrlNhanVien.Add(info))
                    {
                        this.IsAddNew = false;
                        MessageBoxEx.Show("Thêm thành công!", "Thêm Thành Công");
                        this.ReloadData();
                    }
                }
                else
                {
                    if (MessageBoxEx.Show("Bạn có muốn cập nhật thông tin nhân viên này không?", "Cập Nhật", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (ctrlNhanVien == null)
                            ctrlNhanVien = new NhanVienCtrl();
                        ctrlNhanVien.Update(info, SelectedIndex, MaNhanVien);
                    }
                    //this.txtMaNV.Text = "";

                }

            }
        }
        #endregion


        #region CheckValid()
        private bool CheckValid()
        {

            // Kiểm Tra Mã Hồ Sơ
            if (this.txtMaNV.Text.Trim() == "")
            {
                MessageBoxEx.Show("Bạn Chưa Nhập Mã Hồ Sơ. Hãy Bấm nút Thêm Mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.btThemNhanVien.Focus();
                return false;
            }
            // Kiểm Tra Họ Tên
            if (this.txtHoTen.Text.Trim() == "")
            {
                MessageBoxEx.Show(" Bạn Chưa nhập Họ Tên !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtHoTen.Focus();
                return false;
            }
            //Kiểm tra Ngày sinh
            if (this.dtNgaySinh.Value != null)
            {
                if ((DateTime.Now.Year - this.dtNgaySinh.Value.Year) < 18 || (DateTime.Now.Year - this.dtNgaySinh.Value.Year) > 60)
                {
                    MessageBoxEx.Show("Năm sinh của nhân viên không hợp lệ. ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.dtNgaySinh.Focus();
                    return false;
                }
            }
           

            // Kiểm tra số CMND
            if (this.txtCMND.Text.Trim() != "")
            {
                if (this.txtCMND.Text.Trim().Length != 9)
                {
                    MessageBoxEx.Show("Bạn đã nhập số CMND không đúng với thực tế", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtCMND.Text = "";
                    this.txtCMND.Focus();
                    return false;
                }
            }
            else
            {
                MessageBoxEx.Show("Chưa nhập số CMND ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtCMND.Focus();
                return false;
            }
            // Kiểm tra số Điện Thoại Nhà
            if (this.txtDThoaiNha.Text.Trim() != "")
            {
                if (this.txtDThoaiNha.Text.Trim().Length != 10)
                {
                    MessageBoxEx.Show("Bạn đã nhập số Điện Thoại không đúng với thực tế", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtDThoaiNha.Text = "";
                    this.txtDThoaiNha.Focus();
                    return false;
                }
            }


            // Kiểm tra số Điện Thoại Di Động
            if (this.txtDThoaiDD.Text.Trim() != "")
            {
                if (this.txtDThoaiDD.Text.Trim().Length != 10 || this.txtDThoaiDD.Text.Trim().Length != 11)
                {
                    MessageBoxEx.Show("Bạn đã nhập số Điện Thoại không đúng với thực tế", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtDThoaiDD.Text = "";
                    this.txtDThoaiDD.Focus();
                    return false;
                }
            }


            // Kiểm Tra Tình Trạng Hôn Nhân
            if (this.cboTinhTrangHonNhan.Text.Trim() == "")
            {
                MessageBoxEx.Show("Bạn chưa chọn tình trạng Hôn nhân !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.cboTinhTrangHonNhan.Focus();
                return false;
            }
            // Kiểm Tra Tình Trạng Sức Khỏe
            if (this.cboTinhTrangSucKhoe.Text.Trim() == "")
            {
                MessageBoxEx.Show("Bạn chưa chọn tình trạng Sức Khỏe !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.cboTinhTrangSucKhoe.Focus();
                return false;
            }
            // Kiểm Tra Nhóm Máu
            if (this.cboNhomMau.Text.Trim() == "")
            {
                MessageBoxEx.Show("Bạn chưa chọn Nhóm Máu !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.cboNhomMau.Focus();
                return false;
            }
            // Kiểm Tra Hình Thức Đào Tạo
            if (this.cboHinhThucDaoTao.Text.Trim() == "")
            {
                MessageBoxEx.Show("Bạn chưa chọn Hình thức Đào Tạo !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.cboHinhThucDaoTao.Focus();
                return false;
            }
           
          


            return true;
        }
        #endregion

        #region ReloadData()
        frm_LIST_NHANVIEN nv = null;
        private void ReloadData()
        {
            if (nv == null)
                nv = new frm_LIST_NHANVIEN();
            nv.listView.Refresh();
        }
        #endregion

        #region link_QuaTrinhBoiDuong_LinkClicked        
        frm_QUATRINHBOIDUONG QT_boiduong = null;
        private void link_QuaTrinhBoiDuong_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (QT_boiduong == null || QT_boiduong.IsDisposed)
                QT_boiduong = new frm_QUATRINHBOIDUONG();
                //QT_boiduong.MdiParent = this.MdiParent;
           

            if (ctrlNhanVien == null)
                ctrlNhanVien = new NhanVienCtrl();
            int kq = ctrlNhanVien.KiemTra_MaNhanVien(this.txtMaNV.Text);
            if (kq == 1)
            {
                QT_boiduong.LayMaNhanVien_BoiDuong = this.txtMaNV.Text;
                QT_boiduong.LayTenNhanVien = this.txtHoTen.Text;
                QT_boiduong.An_Hien = this.An_Hien;
                QT_boiduong.Text = "Quá Trình Bồi Dưỡng Của: "+ NhanVienSelected.HoTen;
                QT_boiduong.ShowDialog();
                Graphics f = this.CreateGraphics();
            }
            else
            {
                MessageBox.Show("Bạn phải lưu lại thông tin nhân viên trước khi thực hiện chức năng này!", "THONG BAO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region link_QuaTrinhDaoTao_LinkClicked        
        frm_QUATRINHDAOTAO QT_daotao = null;
        private void link_QuaTrinhDaoTao_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (QT_daotao == null || QT_daotao.IsDisposed)
                QT_daotao = new frm_QUATRINHDAOTAO();
            //QT_daotao.MdiParent = this.MdiParent;


            if (ctrlNhanVien == null)
                ctrlNhanVien = new NhanVienCtrl();
            int kq = ctrlNhanVien.KiemTra_MaNhanVien(this.txtMaNV.Text);
            if (kq == 1)
            {
                QT_daotao.LayMaNhanVien_QTDaoTao = this.txtMaNV.Text;
                QT_daotao.LayTenNhanVien = this.txtHoTen.Text;
                QT_daotao.Text = "Quá Trình Đào Tạo Của: " + NhanVienSelected.HoTen;
                QT_daotao.An_Hien = this.An_Hien;
                QT_daotao.ShowDialog();
                Graphics f = this.CreateGraphics();
            }
            else
            {
                MessageBox.Show("Bạn phải lưu lại thông tin nhân viên trước khi thực hiện chức năng này!", "THONG BAO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region link_QuaTrinhCongTac_LinkClicked        
        frm_QUATRINHCONGTAC QT_congtac = null;
        private void link_QuaTrinhCongTac_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (QT_congtac == null || QT_congtac.IsDisposed)
                QT_congtac = new frm_QUATRINHCONGTAC();
            //QT_congtac.MdiParent = this.MdiParent;


            if (ctrlNhanVien == null)
                ctrlNhanVien = new NhanVienCtrl();
            int kq = ctrlNhanVien.KiemTra_MaNhanVien(this.txtMaNV.Text);
            if (kq == 1)
            {
                QT_congtac.LayMaNhanVien_QTCongTac = this.txtMaNV.Text;
                QT_congtac.LayTenNhanVien = this.txtHoTen.Text;
                QT_congtac.Text = "Quá Trình Công Tác Của:  " + NhanVienSelected.HoTen;
                QT_congtac.An_Hien = this.An_Hien;
                QT_congtac.ShowDialog();
                Graphics f = this.CreateGraphics();
            }
            else
            {
                MessageBox.Show("Bạn phải lưu lại thông tin nhân viên trước khi thực hiện chức năng này!", "THONG BAO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region link_QuaTrinhThamGiaHDXaHoi_LinkClicked

        frm_QUATRINHHOATDONGXAHOI QT_thamgiaHDXH = null;
        private void link_QuaTrinhThamGiaHDXaHoi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (QT_thamgiaHDXH == null || QT_thamgiaHDXH.IsDisposed)
                QT_thamgiaHDXH = new frm_QUATRINHHOATDONGXAHOI();
            //QT_thamgiaHDXH.MdiParent = this.MdiParent;


            if (ctrlNhanVien == null)
                ctrlNhanVien = new NhanVienCtrl();
            int kq = ctrlNhanVien.KiemTra_MaNhanVien(this.txtMaNV.Text);
            if (kq == 1)
            {
                QT_thamgiaHDXH.LayMaNhanVien_QTHoatDongXH = this.txtMaNV.Text;
                QT_thamgiaHDXH.LayTenNhanVien = this.txtHoTen.Text;
                QT_thamgiaHDXH.Text = "Quá Trình Tham Gia Hoạt Động Xã Hội Của:  " + NhanVienSelected.HoTen;
                QT_thamgiaHDXH.An_Hien = this.An_Hien;
                QT_thamgiaHDXH.ShowDialog();
                Graphics f = this.CreateGraphics();
            }
            else
            {
                MessageBox.Show("Bạn phải lưu lại thông tin nhân viên trước khi thực hiện chức năng này!", "THONG BAO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region btXoaNhanVien_Click        
       
        private void btXoaNhanVien_Click(object sender, EventArgs e)
        {
            
            if (!IsAddNew)
            {
                if (MessageBox.Show("Bạn có chắc là xóa thông tin nhân viên này không?", "Xoa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (ctrlNhanVien == null)
                        ctrlNhanVien = new NhanVienCtrl();
                    ctrlNhanVien.XoaNhanVien(this.txtMaNV.Text);
                    //  1
                    QuaTrinhDaoTaoCtrl ctrlDaoTao =new QuaTrinhDaoTaoCtrl();                    
                    ctrlDaoTao.Xoa_QuaTrinhDaoTaoNV(this.txtMaNV.Text);
                    //2
                    QuaTrinhBoiDuongCtrl ctrBoiDuong = new QuaTrinhBoiDuongCtrl();
                    ctrBoiDuong.Xoa_QuaTrinhBoiDuongNV(this.txtMaNV.Text);
                    //3
                    QuaTrinhCongTacCtrl ctrlCongTac = new QuaTrinhCongTacCtrl();
                    ctrlCongTac.Xoa_QuaTrinhCongTacNV(this.txtMaNV.Text);
                    //4
                    QuaTrinhThamGiaLucLuongVuTrangCtrl ctrl_LLVuTrang = new QuaTrinhThamGiaLucLuongVuTrangCtrl();
                    ctrl_LLVuTrang.Xoa_QuaTrinhTGLLVuTrangNV(this.txtMaNV.Text);
                    //  5
                    QuaTrinhHoatDongXaHoiCtrl ctrlQTHDXH = new QuaTrinhHoatDongXaHoiCtrl();
                    ctrlQTHDXH.Xoa_QuaTrinhHoatDongXaHoi_NhanVien(this.txtMaNV.Text);
                    //6
                    KhenThuongCtrl ctrl_KhenThuong = new KhenThuongCtrl();
                    ctrl_KhenThuong.Xoa_QuaTrinhKhenThuongNV(this.txtMaNV.Text);
                    //7
                    KyLuatCtrl ctrl_KyLuat = new KyLuatCtrl();
                    ctrl_KyLuat.Xoa_KyLuat_NhanVien(this.txtMaNV.Text);
                    //8
                    LichSuBanThanCtrl ctrl_LichSuBanThan = new LichSuBanThanCtrl();
                    ctrl_LichSuBanThan.Xoa_LichSuBanThan_NhanVien(this.txtMaNV.Text);
                    //9
                    QuanHeGiaDinhCtrl ctrl_QuanHeGiaDinh = new QuanHeGiaDinhCtrl();
                    ctrl_QuanHeGiaDinh.Xoa_QuanHeGiaDinh_NhanVien(this.txtMaNV.Text);
                    //  10
                    DanhGiaCBCCCtrl ctrl_DanhGia = new DanhGiaCBCCCtrl();
                    ctrl_DanhGia.Xoa_DanhGia_CBCC_NhanVien(this.txtMaNV.Text);
                    //11
                    ThaiSanCtrl ctrl_ThaiSan = new ThaiSanCtrl();
                    ctrl_ThaiSan.Xoa_ThaiSan_NhanVien(this.txtMaNV.Text);
                    //12
                    HopDongLaoDongCtrl ctrl_HopDongLaoDong = new HopDongLaoDongCtrl();
                    ctrl_HopDongLaoDong.Xoa_HopDongLaoDong_NhanVien(this.txtMaNV.Text);
                    //13
                    LuongNhanVienCtrl ctrl_HuongLuong = new LuongNhanVienCtrl();
                    ctrl_HuongLuong.Xoa_Luong_NhanVien(this.txtMaNV.Text);
                    //14
                    QuaTrinhCongTacNuocNgoaiCtrl ctrl_nuocngoai = new QuaTrinhCongTacNuocNgoaiCtrl();
                    ctrl_nuocngoai.Xoa_QuaTrinhCongTacNuocNgoai_NhanVien(this.txtMaNV.Text);
                    //15
                    NghiViecCtrl ctrl_nghiviec = new NghiViecCtrl();
                    ctrl_nghiviec.Xoa_NhanVienNghiViec(this.txtMaNV.Text);


                   
                }
                this.ReloadDataNhanVien();
               
            }
            else
            {
                MessageBoxEx.Show("Không hợp lệ !","Thông Báo");
            }
        }
        #endregion

        #region ReloadDataNhanVien        
       
        private void ReloadDataNhanVien()
        {

            #region HienThi Combobox

            PhongBanCtrl ctrlPhongBan = new PhongBanCtrl();
            ctrlPhongBan.HienThiComboBox(this.cboPhongBan);

           

            ChucVuCtrl ctrlChucVu = new ChucVuCtrl();
            ctrlChucVu.HienThiComboBox(this.cboChucVuHienNay);


            DanTocCtrl ctrlDanToc = new DanTocCtrl();
            ctrlDanToc.HienThiComboBox(this.cboDanToc);

            TonGiaoCtrl ctrlTonGiao = new TonGiaoCtrl();
            ctrlTonGiao.HienThiComboBox(this.cboTonGiao);

            QuocTichCtrl ctrlQuocTich = new QuocTichCtrl();
            ctrlQuocTich.HienThiComboBox(this.cboQuocTich);


            NgoaiNguCtrl ctrlNgoaiNgu = new NgoaiNguCtrl();
            ctrlNgoaiNgu.HienThiComboBox(this.cboNgoaiNguChinh);


            #endregion

            if (An_Hien == "Xem")
            {
                this.PhanQuyen_Xem_An();
            }
            else
            {
                this.PhanQuyen_Xem_Hien();
            }

            this.txtMaNV.Text = null;
            this.txtHoTen.Text = null;
            this.txtBiDanh.Text = null;
            this.dtNgaySinh.Text = null;
            this.txtNoiSinh.Text = null;
            this.txtCMND.Text = null;
            this.dtNgayCapCMND.Text = null;
            this.txtNoiCapCMND.Text = null;
            this.picHinhAnh.Tag = null;

            this.cboDanToc.SelectedText = "";
            this.cboTonGiao.SelectedText = "";
            this.cboQuocTich.SelectedText = "";
            this.cboNgoaiNguChinh.SelectedText = "";
            this.txtQueQuan.Text = null;
            this.txtDChiThuongTru.Text = null;
            this.txtNoiOHienNay.Text = null;
            this.txtDThoaiNha.Text = null;
            this.txtDThoaiNha.Text = null;
            this.txtEmail.Text = null;
            this.txtCanNang.Text = null;
            this.txtChieuCao.Text = null;
            this.txtChucVuCongDoan.Text = null;
            this.txtChucVuDang.Text = null;
            this.txtChucVuDoan.Text = null;
            this.txtChuyenNganhDaoTao.Text = null;
            this.txtCoQuanTuyenDung.Text = null;
            this.txtDaTotNghiep.Text = null;
            this.txtDienUuTienBanThan.Text = null;
            this.txtDienUuTienGiaDinh.Text = null;
            this.txtHinhThucTuyenDung.Text = null;
            this.txtKhuyetTat.Text = null;
           //
            this.txtNangKhieu.Text = null;
            this.txtNganhDaoTao.Text = null;
            this.txtNgoaiNgucKhac.Text = null;
            this.txtNoiDaoTao.Text = null;
            this.txtNoiVaoDang.Text = null;
            this.txtNoiVaoDoan.Text = null;
            this.txtThanhPhanXuatThan.Text = null;
            this.txtTrinhDoChuyenMonCaoNhat.Text = null;
            this.txtTDLyLuanChinhTri.Text = null;
            this.txtTDQuanLyNhaNuoc.Text = null;
            this.txtTDQuanLyGiaoDuc.Text = null;
            this.dtNgayCT_VaoDang.Text = null;
            this.dtNgayTuyenDung.Text = null;
            this.dtNgayVaoCongDoan.Text = null;
            this.dtNgayVaoDang.Text = null;
            this.dtNgayVaoDoan.Text = null;
        }
        #endregion       

        #region link_QuaTrinhKhenThuong_LinkClicked        
        frm_KHENTHUONG QT_khenthuong = new frm_KHENTHUONG();
        private void link_QuaTrinhKhenThuong_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (QT_khenthuong == null || QT_khenthuong.IsDisposed)
                QT_khenthuong = new frm_KHENTHUONG();
            //QT_congtac.MdiParent = this.MdiParent;


            if (ctrlNhanVien == null)
                ctrlNhanVien = new NhanVienCtrl();
            int kq = ctrlNhanVien.KiemTra_MaNhanVien(this.txtMaNV.Text);
            if (kq == 1)
            {
                QT_khenthuong.LayMaNhanVien_QTKhenThuong = this.txtMaNV.Text;
                QT_khenthuong.LayTenNhanVien = this.txtHoTen.Text;
                QT_khenthuong.Text = "Quá Trình Khen Thưởng Của:  " + NhanVienSelected.HoTen;
                QT_khenthuong.An_Hien = this.An_Hien;
                QT_khenthuong.ShowDialog();
                Graphics f = this.CreateGraphics();
            }
            else
            {
                MessageBox.Show("Bạn phải lưu lại thông tin nhân viên trước khi thực hiện chức năng này!", "THONG BAO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region link_ThamGiaLLVuTrang_LinkClicked        
        frm_QUATRINHTHAMGIALUCLUONGVUTRANG QT_vutrang = null;
        private void link_ThamGiaLLVuTrang_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (QT_vutrang == null || QT_vutrang.IsDisposed)
                QT_vutrang = new frm_QUATRINHTHAMGIALUCLUONGVUTRANG();
            //QT_congtac.MdiParent = this.MdiParent;


            if (ctrlNhanVien == null)
                ctrlNhanVien = new NhanVienCtrl();
            int kq = ctrlNhanVien.KiemTra_MaNhanVien(this.txtMaNV.Text);
            if (kq == 1)
            {
                QT_vutrang.LayMaNhanVien_QTVuTrang = this.txtMaNV.Text;
                QT_vutrang.LayTenNhanVien = this.txtHoTen.Text;
                QT_vutrang.Text = "Quá Trình Tham Gia Lực Lượng Vũ Trang Của:  " + NhanVienSelected.HoTen;
                QT_vutrang.An_Hien = this.An_Hien;
                QT_vutrang.ShowDialog();
                Graphics f = this.CreateGraphics();
            }
            else
            {
                MessageBoxEx.Show("Bạn phải lưu lại thông tin nhân viên trước khi thực hiện chức năng này!", "THONG BAO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region linkLichSuBanThan_LinkClicked        
        frm_LICHSUBANTHAN LS_BantThan = null;
        private void linkLichSuBanThan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (LS_BantThan == null || LS_BantThan.IsDisposed)
                LS_BantThan = new frm_LICHSUBANTHAN();
            //QT_congtac.MdiParent = this.MdiParent;


            if (ctrlNhanVien == null)
                ctrlNhanVien = new NhanVienCtrl();
            int kq = ctrlNhanVien.KiemTra_MaNhanVien(this.txtMaNV.Text);
            if (kq == 1)
            {
                LS_BantThan.LayMaNhanVien_LichSuBanThan = this.txtMaNV.Text;
                LS_BantThan.LayTenNhanVien = this.txtHoTen.Text;
                LS_BantThan.Text = "Lịch Sử Bản Thân Của:  " + NhanVienSelected.HoTen;
                LS_BantThan.An_Hien = this.An_Hien;
                LS_BantThan.ShowDialog();
                Graphics f = this.CreateGraphics();
            }
            else
            {
                MessageBoxEx.Show("Bạn phải lưu lại thông tin nhân viên trước khi thực hiện chức năng này!", "THONG BAO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region linkQuanHeGiaDinh_LinkClicked        
        frm_QUANHEGIADINH quanhe_GD = null;
        private void linkQuanHeGiaDinh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (quanhe_GD == null || quanhe_GD.IsDisposed)
                quanhe_GD = new frm_QUANHEGIADINH();
            //QT_congtac.MdiParent = this.MdiParent;


            if (ctrlNhanVien == null)
                ctrlNhanVien = new NhanVienCtrl();
            int kq = ctrlNhanVien.KiemTra_MaNhanVien(this.txtMaNV.Text);
            if (kq == 1)
            {
                quanhe_GD.LayMaNhanVien_QuanHeGiaDinh = this.txtMaNV.Text;
                quanhe_GD.LayTenNhanVien = this.txtHoTen.Text;
                quanhe_GD.Text = "Quan Hệ Gia Đình Của:  " + NhanVienSelected.HoTen;
                quanhe_GD.An_Hien = this.An_Hien;
                quanhe_GD.ShowDialog();
                Graphics f = this.CreateGraphics();
            }
            else
            {
                MessageBoxEx.Show("Bạn phải lưu lại thông tin nhân viên trước khi thực hiện chức năng này!", "THONG BAO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region linkQuaTrinhKyLuat_LinkClicked        
        frm_KYLUAT kyluat = null;
        private void linkQuaTrinhKyLuat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (kyluat == null || kyluat.IsDisposed)
                kyluat = new frm_KYLUAT();          


            if (ctrlNhanVien == null)
                ctrlNhanVien = new NhanVienCtrl();
            int kq = ctrlNhanVien.KiemTra_MaNhanVien(this.txtMaNV.Text);
            if (kq == 1)
            {
                kyluat.LayMaNhanVien_BiKyLuat = this.txtMaNV.Text;
                kyluat.LayTenNhanVien = this.txtHoTen.Text;
                kyluat.Text = "Quá Trình Bị Kỷ Luật Của:  " + NhanVienSelected.HoTen;
                kyluat.An_Hien = this.An_Hien;
                kyluat.ShowDialog();
                Graphics f = this.CreateGraphics();
            }
            else
            {
                MessageBoxEx.Show("Bạn phải lưu lại thông tin nhân viên trước khi thực hiện chức năng này!", "THONG BAO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region linkDanhGiaCongChuc_LinkClicked        
        frm_DANHGIACBCC danhgia = null;
        private void linkDanhGiaCongChuc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (danhgia == null || danhgia.IsDisposed)
                danhgia = new frm_DANHGIACBCC();


            if (ctrlNhanVien == null)
                ctrlNhanVien = new NhanVienCtrl();
            int kq = ctrlNhanVien.KiemTra_MaNhanVien(this.txtMaNV.Text);
            if (kq == 1)
            {
                danhgia.LayMaNhanVien_DanhGiaCB = this.txtMaNV.Text;
                danhgia.LayTenNhanVien = this.txtHoTen.Text;
                danhgia.Text = "Đánh Giá Nhân Viên:  " + NhanVienSelected.HoTen;
                danhgia.An_Hien = this.An_Hien;
                danhgia.ShowDialog();
                Graphics f = this.CreateGraphics();
            }
            else
            {
                MessageBoxEx.Show("Bạn phải lưu lại thông tin nhân viên trước khi thực hiện chức năng này!", "THONG BAO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region linkChenHinh_LinkClicked       
       
        private void linkChenHinh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openDlg = new OpenFileDialog();
            openDlg.Title = "Chon mot hinh anh";
            openDlg.RestoreDirectory = true;
            openDlg.Filter = "All images (*.bmp;*.jpg;*.gif;*.png)|*.bmp;*.jpg;*.gif;*.png";
            openDlg.Multiselect = false;
            if (openDlg.ShowDialog() == DialogResult.OK)
            {
                
                picHinhAnh.Image = Image.FromFile(openDlg.FileName);
            }
        }
        #endregion

        #region linkXoaHinh_LinkClicked

        private void linkXoaHinh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.picHinhAnh.Image = null;
        }
        #endregion

        #region linkHopDongLaoDong_LinkClicked
        frm_HOPDONGLAODONG hopdonglaodong = null;
        private void linkHopDongLaoDong_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (hopdonglaodong == null || hopdonglaodong.IsDisposed)
                hopdonglaodong = new frm_HOPDONGLAODONG();


            if (ctrlNhanVien == null)
                ctrlNhanVien = new NhanVienCtrl();
            int kq = ctrlNhanVien.KiemTra_MaNhanVien(this.txtMaNV.Text);
            if (kq == 1)
            {
                hopdonglaodong.LayMaNhanVien_HopDongLaoDong = this.txtMaNV.Text;
                hopdonglaodong.LayTenNhanVien = this.txtHoTen.Text;
                hopdonglaodong.Text = "Hợp Đồng Lao Động Của:  " + NhanVienSelected.HoTen;
                hopdonglaodong.An_Hien = this.An_Hien;
                hopdonglaodong.ShowDialog();
                Graphics f = this.CreateGraphics();
            }
            else
            {
                MessageBoxEx.Show("Bạn phải lưu lại thông tin nhân viên trước khi thực hiện chức năng này!", "THONG BAO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region link_QuaTrinhHuongLuong_LinkClicked        
        frm_LUONGNHANVIEN huongluong = null;
        private void link_QuaTrinhHuongLuong_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (huongluong == null || huongluong.IsDisposed)
                huongluong = new frm_LUONGNHANVIEN();


            if (ctrlNhanVien == null)
                ctrlNhanVien = new NhanVienCtrl();
            int kq = ctrlNhanVien.KiemTra_MaNhanVien(this.txtMaNV.Text);
            if (kq == 1)
            {
                huongluong.LayMaNhanVien_LuongNhanVien = this.txtMaNV.Text;
                huongluong.LayTenNhanVien = this.txtHoTen.Text;
                huongluong.Text = "Quá Trình Hưởng Lương Của:  " + NhanVienSelected.HoTen;
                huongluong.An_Hien = this.An_Hien;
                huongluong.ShowDialog();
                Graphics f = this.CreateGraphics();
            }
            else
            {
                MessageBoxEx.Show("Bạn phải lưu lại thông tin nhân viên trước khi thực hiện chức năng này!", "THONG BAO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region linkQuaTrinhCongTacNuocNgoai_LinkClicked        
        frm_QUATRINHCONGTACNUOCNGOAI congtacnuocngoai = null;
        private void linkQuaTrinhCongTacNuocNgoai_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (congtacnuocngoai == null || congtacnuocngoai.IsDisposed)
                congtacnuocngoai = new frm_QUATRINHCONGTACNUOCNGOAI();


            if (ctrlNhanVien == null)
                ctrlNhanVien = new NhanVienCtrl();
            int kq = ctrlNhanVien.KiemTra_MaNhanVien(this.txtMaNV.Text);
            if (kq == 1)
            {
                congtacnuocngoai.LayMaNhanVien_QTCongTacNuocNgoai = this.txtMaNV.Text;
                congtacnuocngoai.LayTenNhanVien = this.txtHoTen.Text;
                congtacnuocngoai.Text = "Quá Trình Công Tác Nước Ngoài Của:  " + NhanVienSelected.HoTen;
                congtacnuocngoai.An_Hien = this.An_Hien;
                congtacnuocngoai.ShowDialog();
                Graphics f = this.CreateGraphics();
            }
            else
            {
                MessageBoxEx.Show("Bạn phải lưu lại thông tin nhân viên trước khi thực hiện chức năng này!", "THONG BAO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region linkThaiSan_LinkClicked        
       
        frm_THAISAN thaisan = null;
        private void linkThaiSan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (thaisan == null || thaisan.IsDisposed)
                thaisan = new frm_THAISAN();


            if (ctrlNhanVien == null)
                ctrlNhanVien = new NhanVienCtrl();
            int kq = ctrlNhanVien.KiemTra_MaNhanVien(this.txtMaNV.Text);
            if (kq == 1)
            {
                thaisan.LayMaNhanVien_ThaiSan = this.txtMaNV.Text;
                thaisan.LayTenNhanVien = this.txtHoTen.Text;
                thaisan.Text = "Quá Trình Thai Sản Của:  " + NhanVienSelected.HoTen;
                thaisan.An_Hien = this.An_Hien;
                thaisan.ShowDialog();
                Graphics f = this.CreateGraphics();
            }
            else
            {
                MessageBoxEx.Show("Bạn phải lưu lại thông tin nhân viên trước khi thực hiện chức năng này!", "THONG BAO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

       
        #region linkNghiViec_LinkClicked        
       
        private void linkNghiViec_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_NGHIVIEC nghiviec = null;
            if (nghiviec == null || nghiviec.IsDisposed)
                nghiviec = new frm_NGHIVIEC();


            if (ctrlNhanVien == null)
                ctrlNhanVien = new NhanVienCtrl();
            int kq = ctrlNhanVien.KiemTra_MaNhanVien(this.txtMaNV.Text);
            if (kq == 1)
            {
                nghiviec.LayMaNhanVien_NghiViec = this.txtMaNV.Text;
                nghiviec.LayTenNhanVien = this.txtHoTen.Text;
                nghiviec.Text = "Nhân Viên:  " + NhanVienSelected.HoTen;
                nghiviec.An_Hien = this.An_Hien;
                nghiviec.ShowDialog();
                Graphics f = this.CreateGraphics();
            }
            else
            {
                MessageBoxEx.Show("Bạn phải lưu lại thông tin nhân viên trước khi thực hiện chức năng này!", "THONG BAO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

      

        private void radNam_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radNam.Checked == true)
            {
                linkThaiSan.Enabled = false;
            }
            else if (this.radNu.Checked == true)
            {
                linkThaiSan.Enabled = true;
            }
        }

        #region linkHopDongLaoDong_ThoiViec_LinkClicked        
        
        frm_HOPDONGLAODONG_THOIVIEC hopdonglaodong_thoiviec = null;
        private void linkHopDongLaoDong_ThoiViec_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (hopdonglaodong_thoiviec == null || hopdonglaodong_thoiviec.IsDisposed)
                hopdonglaodong_thoiviec = new frm_HOPDONGLAODONG_THOIVIEC();


            if (ctrlNhanVien == null)
                ctrlNhanVien = new NhanVienCtrl();
            int kq = ctrlNhanVien.KiemTra_MaNhanVien(this.txtMaNV.Text);
            if (kq == 1)
            {
                hopdonglaodong_thoiviec.LayMaNhanVien_HopDongLaoDong_ThoiViec = this.txtMaNV.Text;
                hopdonglaodong_thoiviec.LayTenNhanVien = this.txtHoTen.Text;
                hopdonglaodong_thoiviec.Text = "Hợp Đồng Lao Động Của:  " + NhanVienSelected.HoTen;
                hopdonglaodong_thoiviec.An_Hien = this.An_Hien;
                hopdonglaodong_thoiviec.ShowDialog();
                Graphics f = this.CreateGraphics();
            }
            else
            {
                MessageBoxEx.Show("Bạn phải lưu lại thông tin nhân viên trước khi thực hiện chức năng này!", "THONG BAO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void btInSoYeuLyLichNhanVien_Click(object sender, EventArgs e)
        {
            TT_GDTX_ANGIANG.Report.frm_InSoYeuLyLichNhanVien f = new TT_GDTX_ANGIANG.Report.frm_InSoYeuLyLichNhanVien(txtMaNV.Text.ToString());
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        private void btHuyNhanVien_Click(object sender, EventArgs e)
        {

        }

        #region btTrinhDoTinHoc_Click        
       
        private void btTrinhDoTinHoc_Click(object sender, EventArgs e)
        {
            TrinhDo_TinHocCtrl TD_tinhoc = new TrinhDo_TinHocCtrl();
            TT_GDTX_ANGIANG.frm_TRINHDOTINHOC qh = new TT_GDTX_ANGIANG.frm_TRINHDOTINHOC();

            qh.ShowDialog();
            Graphics f = this.CreateGraphics();
            TD_tinhoc.HienThiComboBox(cboTDTinHoc);

            if (qh.Index > -1)
                cboTDTinHoc.SelectedIndex = qh.Index;
        }
        #endregion

        #region btTrinhDoNgoaiNgu_Click        
       
        private void btTrinhDoNgoaiNgu_Click(object sender, EventArgs e)
        {
            TrinhDo_NgoaiNguCtrl TD_ngoaingu = new TrinhDo_NgoaiNguCtrl();
            TT_GDTX_ANGIANG.frm_TRINHDO_NGOAINGU qh = new TT_GDTX_ANGIANG.frm_TRINHDO_NGOAINGU();

            qh.ShowDialog();
            Graphics f = this.CreateGraphics();
            TD_ngoaingu.HienThiComboBox(cboTDNgoaiNgu);

            if (qh.Index > -1)
                cboTDNgoaiNgu.SelectedIndex = qh.Index;
        }
        #endregion

        #region btNgoaiNgu_Click        
       
        private void btNgoaiNgu_Click(object sender, EventArgs e)
        {
            NgoaiNguCtrl ngoaingu = new NgoaiNguCtrl();
            TT_GDTX_ANGIANG.frm_NGOAINGU qh = new TT_GDTX_ANGIANG.frm_NGOAINGU();
            qh.ShowDialog();
            Graphics f = this.CreateGraphics();
            ngoaingu.HienThiComboBox(cboNgoaiNguChinh);

            if (qh.Index > -1)
                cboNgoaiNguChinh.SelectedIndex = qh.Index;
        }
        #endregion

        #region btTrinhDoHocVan_Click        
       
        private void btTrinhDoHocVan_Click(object sender, EventArgs e)
        {
            TrinhDo_HocVanCtrl TD_hocvan = new TrinhDo_HocVanCtrl();
            TT_GDTX_ANGIANG.frm_TRINHDOHOCVAN qh = new TT_GDTX_ANGIANG.frm_TRINHDOHOCVAN();
            qh.ShowDialog();
            Graphics f = this.CreateGraphics();
            TD_hocvan.HienThiComboBox(cboHocVanPhoThong);

            if (qh.Index > -1)
                cboHocVanPhoThong.SelectedIndex = qh.Index;
        }
        #endregion

        #region btDanToc_Click        
       
        private void btDanToc_Click(object sender, EventArgs e)
        {
            DanTocCtrl dantoc = new DanTocCtrl();
            TT_GDTX_ANGIANG.frm_DANTOC qh = new TT_GDTX_ANGIANG.frm_DANTOC();

            qh.ShowDialog();
            Graphics f = this.CreateGraphics();
            dantoc.HienThiComboBox(cboDanToc);

            if (qh.Index > -1)
                cboDanToc.SelectedIndex = qh.Index;
        }
        #endregion

        #region btTonGiao_Click        
       
        private void btTonGiao_Click(object sender, EventArgs e)
        {
            TonGiaoCtrl tongiao = new TonGiaoCtrl();
            TT_GDTX_ANGIANG.frm_TONGIAO qh = new TT_GDTX_ANGIANG.frm_TONGIAO();

            qh.ShowDialog();
            Graphics f = this.CreateGraphics();
            tongiao.HienThiComboBox(cboTonGiao);

            if (qh.Index > -1)
                cboTonGiao.SelectedIndex = qh.Index;
        }
        #endregion

        #region btQuocTich_Click       
       
        private void btQuocTich_Click(object sender, EventArgs e)
        {
            QuocTichCtrl quoctich = new QuocTichCtrl();
            TT_GDTX_ANGIANG.frm_QUOCTICH qh = new TT_GDTX_ANGIANG.frm_QUOCTICH();

            qh.ShowDialog();
            Graphics f = this.CreateGraphics();
            quoctich.HienThiComboBox(cboQuocTich);

            if (qh.Index > -1)
                cboQuocTich.SelectedIndex = qh.Index;
        }
        #endregion
    }
}