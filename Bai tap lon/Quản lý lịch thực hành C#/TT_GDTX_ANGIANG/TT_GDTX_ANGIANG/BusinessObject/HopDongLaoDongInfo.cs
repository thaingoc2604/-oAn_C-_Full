using System;
using System.Collections.Generic;
using System.Text;

namespace TT_GDTX_ANGIANG.BusinessObject
{
    public class HopDongLaoDongInfo
    {
         #region Ham Tao       
        public HopDongLaoDongInfo()
        {
        }

        public HopDongLaoDongInfo(String maHD, string maNV,int chonBHYT, int chonBHXH, String loaiHD, DateTime tuNgay, DateTime denNgay, String diaDiemLamViec, String chucDanhChuyenMon, String nhiemVu, String thoiGianLamViec, String trangBiPhuongTien, String ngach, int bac, float heSoLuong, String phucap, String nguoiKy, String chucvuNguoiKy, DateTime ngayKy)//BHYT, BHXH
        {
            MaHopDongLaoDong = maHD;
            MaNhanVien = maNV;
            LoaiHopDong = loaiHD;
            TuNgay = tuNgay;
            DenNgay = denNgay;
            DiaDiemLamViec = diaDiemLamViec;           
            ChucDanhChuyenMon = chucDanhChuyenMon;
            NhiemVu = nhiemVu;
            ThoiGianLamViec = thoiGianLamViec;
            TrangBiPhuongTien = trangBiPhuongTien;
            Ngach = ngach;
            Bac = bac;
            HeSoLuong = heSoLuong;
            PhuCap = phucap;
            NguoiKy = nguoiKy;
            ChucVu = chucvuNguoiKy;
            NgayKy = ngayKy;

            ChonBHXH = chonBHXH;
            ChonBHYT = chonBHYT;
            

        }
        #endregion

        #region MAHDLV
        private string m_HDLV;
        public string MaHopDongLaoDong
        {
            get { return m_HDLV; }
            set { m_HDLV = value; }
        }
        #endregion

        #region MANHANVIEN
        private string m_MANHANVIEN;
        public string MaNhanVien
        {
            get { return m_MANHANVIEN; }
            set { m_MANHANVIEN = value; }
        }
        #endregion

        #region LOAIHOPDONG
        private String m_LOAIHOPDONG;
        public String LoaiHopDong
        {
            get { return m_LOAIHOPDONG; }
            set { m_LOAIHOPDONG = value; }
        }
        #endregion

        #region TUNGAY
        private DateTime m_TUNGAY;
        public DateTime TuNgay
        {
            get { return m_TUNGAY; }
            set { m_TUNGAY = value; }
        }
        #endregion

        #region DENNGAY
        private DateTime m_DENNGAY;
        public DateTime DenNgay
        {
            get { return m_DENNGAY; }
            set { m_DENNGAY = value; }
        }
        #endregion

        #region DIADIEMLAMVIEC
        private String m_DIADIEMLAMVIEC;
        public String DiaDiemLamViec
        {
            get { return m_DIADIEMLAMVIEC; }
            set { m_DIADIEMLAMVIEC = value; }
        }
        #endregion

       
        #region CHUCDANHCHUYENMON
        private String m_CHUCDANHCHUYENMON;
        public String ChucDanhChuyenMon
        {
            get { return m_CHUCDANHCHUYENMON; }
            set { m_CHUCDANHCHUYENMON = value; }
        }
        #endregion

        #region NHIEMVU
        private String m_NHIEMVU;
        public String NhiemVu
        {
            get { return m_NHIEMVU; }
            set { m_NHIEMVU = value; }
        }
        #endregion

        #region THOIGIANLAMVIEC
        private String m_THOIGIANLAMVIEC;
        public String ThoiGianLamViec
        {
            get { return m_THOIGIANLAMVIEC; }
            set { m_THOIGIANLAMVIEC = value; }
        }
        #endregion

        #region TRANGBIPHUONGTIEN
        private String m_TRANGBIPHUONGTIEN;
        public String TrangBiPhuongTien
        {
            get { return m_TRANGBIPHUONGTIEN; }
            set { m_TRANGBIPHUONGTIEN = value; }
        }
        #endregion

        #region NGACH
        private String m_NGACH;
        public String Ngach
        {
            get { return m_NGACH; }
            set { m_NGACH = value; }
        }
        #endregion

        #region BAC
        private int m_BAC;
        public int Bac
        {
            get { return m_BAC; }
            set { m_BAC = value; }
        }
        #endregion

        #region HESOLUONG
        private float m_HESOLUONG;
        public float HeSoLuong
        {
            get { return m_HESOLUONG; }
            set { m_HESOLUONG = value; }
        }
        #endregion

        #region PHUCAP
        private String m_PHUCAP;
        public String PhuCap
        {
            get { return m_PHUCAP; }
            set { m_PHUCAP = value; }
        }
        #endregion

        #region NGUOIKY
        private String m_NGUOIKY;
        public String NguoiKy
        {
            get { return m_NGUOIKY; }
            set { m_NGUOIKY = value; }
        }
        #endregion

        #region CHUCVU
        private String m_CHUCVU;
        public String ChucVu
        {
            get { return m_CHUCVU; }
            set { m_CHUCVU = value; }
        }
        #endregion

        #region NGAYKY
        private DateTime m_NGAYKY;
        public DateTime NgayKy
        {
            get { return m_NGAYKY; }
            set { m_NGAYKY = value; }
        }
        #endregion

        #region CHONBHYT
        private int m_CHONBHYT;
        public int ChonBHYT
        {
            get { return m_CHONBHYT; }
            set { m_CHONBHYT = value; }
        }
        #endregion

        #region CHONBHXH
        private int m_CHONBHXH;
        public int ChonBHXH
        {
            get { return m_CHONBHXH; }
            set { m_CHONBHXH = value; }
        }
        #endregion

    }
}
