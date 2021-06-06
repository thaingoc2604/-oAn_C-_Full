using System;
using System.Collections.Generic;
using System.Text;

namespace TT_GDTX_ANGIANG.BusinessObject
{
    public class LươngNhanVienInfo
    {
        
        #region Ham Tao       
        public LươngNhanVienInfo()
        {
        }

        public LươngNhanVienInfo(string maLuong,int chongv, int chonnvvp,int chonThuViec ,int chon2nam,int chon3nam, float gv, float nvVanPhong, string maNV, String tenNgach, int bacLuong, float heSoLuong,float luongCoBan, DateTime ngayBD, DateTime ngayKT,float heSoChucVu, float dangPhi, float truCacKhoan, float luong, float luongConLai, float luongThucLanh )
        {
            MaLuong = maLuong;
            MaNhanVien = maNV;
            TenNgach = tenNgach;
            BacLuong = bacLuong;
            HeSoLuong = heSoLuong;
            LuongCoBan=luongCoBan;
            NgayBatDau = ngayBD;
            NgayKetThuc = ngayKT;           
            HeSoPCChucVu=heSoChucVu;
            Luong = luong;
            TruCacKhoan = truCacKhoan;
            LuongConLai = luongConLai;
            DangPhi = DangPhi;
            LuongThucLanh = luongThucLanh;
            GiaoVien = gv;
            NhanVienVanPhong = nvVanPhong;
            ChonGiaoVien = chongv;
            ChonNhanVienVanPhong = chonnvvp;
            ChonThuViec = chonThuViec;
            Chon2Nam = chon2nam;
            Chon3Nam = chon3nam;
        }
        #endregion

        #region MALUONG
        private string m_MALUONG;
        public string MaLuong
        {
            get { return m_MALUONG; }
            set { m_MALUONG = value; }
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

        #region TENNGACH
        private String m_TENNGACH;
        public String TenNgach
        {
            get { return m_TENNGACH; }
            set { m_TENNGACH = value; }
        }
        #endregion

        #region BACLUONG
        private int m_BACLUONG;
        public int BacLuong
        {
            get { return m_BACLUONG; }
            set { m_BACLUONG = value; }
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

        
        #region LUONGCOBAN
        private float m_LUONGCOBAN;
        public float LuongCoBan
        {
            get { return m_LUONGCOBAN; }
            set { m_LUONGCOBAN = value; }
        }
        #endregion

        #region NGAYBD
        private DateTime m_NGAYBD;
        public DateTime NgayBatDau
        {
            get { return m_NGAYBD; }
            set { m_NGAYBD = value; }
        }
        #endregion

        #region NGAYKT
        private DateTime m_NGAYKT;
        public DateTime NgayKetThuc
        {
            get { return m_NGAYKT; }
            set { m_NGAYKT = value; }
        }
        #endregion                                            
              
              

        #region HESOPCCHUCVU
        private float m_HESOPCCHUCVU;
        public float HeSoPCChucVu
        {
            get { return m_HESOPCCHUCVU; }
            set { m_HESOPCCHUCVU = value; }
        }
        #endregion

         #region TRUCACKHOAN
        private float m_TRUCACKHOAN;
        public float TruCacKhoan
        {
            get { return m_TRUCACKHOAN; }
            set { m_TRUCACKHOAN = value; }
        }
        #endregion

         #region LUONG
        private float m_LUONG;
        public float Luong
        {
            get { return m_LUONG; }
            set { m_LUONG = value; }
        }
        #endregion

         #region LUONGCONLAI
        private float m_LUONGCONLAI;
        public float LuongConLai
        {
            get { return m_LUONGCONLAI; }
            set { m_LUONGCONLAI = value; }
        }
        #endregion

        #region DANGPHI
        private float m_DANGPHI;
        public float DangPhi
        {
            get { return m_DANGPHI; }
            set { m_DANGPHI = value; }
        }
        #endregion

         #region LUONGTHUCLANH
        private float m_LUONGTHUCLANH;
        public float LuongThucLanh
        {
            get { return m_LUONGTHUCLANH; }
            set { m_LUONGTHUCLANH = value; }
        }
        #endregion

        #region GIAOVIEN
        private float m_GIAOVIEN;
        public float GiaoVien
        {
            get { return m_GIAOVIEN; }
            set { m_GIAOVIEN = value; }
        }
        #endregion

        #region CHONGIAOVIEN
        private int m_CHONGIAOVIEN;
        public int ChonGiaoVien
        {
            get { return m_CHONGIAOVIEN; }
            set { m_CHONGIAOVIEN = value; }
        }
        #endregion

        #region NHANVIENVANPHONG
        private float m_NHANVIENVANPHONG;
        public float NhanVienVanPhong
        {
            get { return m_NHANVIENVANPHONG; }
            set { m_NHANVIENVANPHONG = value; }
        }
        #endregion


        #region CHONNHANVIENVANPHONG
        private int m_CHONNHANVIENVANPHONG;
        public int ChonNhanVienVanPhong
        {
            get { return m_CHONNHANVIENVANPHONG; }
            set { m_CHONNHANVIENVANPHONG = value; }
        }
        #endregion

        #region CHONTHUVIEC
        private int m_CHONTHUVIEC;
        public int ChonThuViec
        {
            get { return m_CHONTHUVIEC; }
            set { m_CHONTHUVIEC = value; }
        }
        #endregion
        #region CHON2NAM
        private int m_CHON2NAM;
        public int Chon2Nam
        {
            get { return m_CHON2NAM; }
            set { m_CHON2NAM = value; }
        }
        #endregion
        #region CHON3NAM
        private int m_CHON3NAM;
        public int Chon3Nam
        {
            get { return m_CHON3NAM; }
            set { m_CHON3NAM = value; }
        }
         #endregion
       
    }
}
