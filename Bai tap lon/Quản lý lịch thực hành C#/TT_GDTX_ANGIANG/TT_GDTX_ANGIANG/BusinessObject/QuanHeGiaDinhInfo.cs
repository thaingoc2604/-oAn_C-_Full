using System;
using System.Collections.Generic;
using System.Text;

namespace TT_GDTX_ANGIANG.BusinessObject
{
    public class QuanHeGiaDinhInfo
    {
        #region Ham Tao       
        public QuanHeGiaDinhInfo()
        {
        }

        public QuanHeGiaDinhInfo(String maQHGD,string maNV, String moiQH,String hoTen, DateTime namSinh, String queQuan, String noiOHienNay, String ngheNghiep, String donViCongTac, String chucVu)
        {
            MaQuanHeGiaDinh = maQHGD;
            MaNhanVien = maNV;
            MoiQuanHe = moiQH;
            HoTen = hoTen;
            NamSinh = namSinh;
            QueQuan = queQuan;
            NoiOHienNay = noiOHienNay;
            NgheNghiep = ngheNghiep;
            DonViCongTac = donViCongTac;
            ChucVu = chucVu;

        }
        #endregion

        #region MAQHGD
        private string m_QHGD;
        public string MaQuanHeGiaDinh
        {
            get { return m_QHGD; }
            set { m_QHGD = value; }
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

        #region MOIQUANHE
        private String m_MOIQUANHE;
        public String MoiQuanHe
        {
            get { return m_MOIQUANHE; }
            set { m_MOIQUANHE = value; }
        }
        #endregion

        #region HOTEN
        private String m_HOTEN;
        public String HoTen
        {
            get { return m_HOTEN; }
            set { m_HOTEN = value; }
        }
        #endregion

        #region NAMSINH
        private DateTime m_NAMSINH;
        public DateTime NamSinh
        {
            get { return m_NAMSINH; }
            set { m_NAMSINH = value; }
        }
        #endregion

        #region QUEQUAN(nvarchar(255),Null)
        private String m_QUEQUAN;
        public String QueQuan
        {
            get { return m_QUEQUAN; }
            set { m_QUEQUAN = value; }
        }
        #endregion

        #region NOIOHIENNAY(nvarchar(255),Null)
        private String m_NOIOHIENNAY;
        public String NoiOHienNay
        {
            get { return m_NOIOHIENNAY; }
            set { m_NOIOHIENNAY = value; }
        }
        #endregion

        #region NGHENGHIEP(nvarchar(255),Null)
        private String m_NGHENGHIEP;
        public String NgheNghiep
        {
            get { return m_NGHENGHIEP; }
            set { m_NGHENGHIEP = value; }
        }
        #endregion

        #region DONVICONGTAC(nvarchar(255),Null)
        private String m_DONVICONGTAC;
        public String DonViCongTac
        {
            get { return m_DONVICONGTAC; }
            set { m_DONVICONGTAC = value; }
        }
        #endregion

        #region CHUCVU(nvarchar(255),Null)
        private String m_CHUCVU;
        public String ChucVu
        {
            get { return m_CHUCVU; }
            set { m_CHUCVU = value; }
        }
        #endregion
    }
}
