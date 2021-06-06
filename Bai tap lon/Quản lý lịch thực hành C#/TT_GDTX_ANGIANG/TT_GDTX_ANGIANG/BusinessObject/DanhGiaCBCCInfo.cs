using System;
using System.Collections.Generic;
using System.Text;

namespace TT_GDTX_ANGIANG.BusinessObject
{
    public class DanhGiaCBCCInfo
    {
        #region Ham Tao       
        public DanhGiaCBCCInfo()
        {
        }

        public DanhGiaCBCCInfo(String maQTTS,string maNV, String soQD, DateTime ngayQD, String coQuanKT, String hinhThucKT, String lyDoKT, String nguoiKy, String ghiChu)
        {
            MaDanhGiaCBCC = maQTTS;
            MaNhanVien = maNV;
            DotDanhGia = soQD;
            NgayDanhGia = ngayQD;
            XepLoaiSucKhoe = coQuanKT;
            XepLoaiDaoDuc = hinhThucKT;
            XepLoaiTDChuyenMon = lyDoKT;
            XepLoaiChung = nguoiKy;
            NhanXet = ghiChu;

        }
        #endregion

        #region MADGCBCC
        private string m_DGCBCC;
        public string MaDanhGiaCBCC
        {
            get { return m_DGCBCC; }
            set { m_DGCBCC = value; }
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

        #region DOTDG
        private String m_DOTDG;
        public String DotDanhGia
        {
            get { return m_DOTDG; }
            set { m_DOTDG = value; }
        }
        #endregion

        #region NGAYDG
        private DateTime m_NGAYDG;
        public DateTime NgayDanhGia
        {
            get { return m_NGAYDG; }
            set { m_NGAYDG = value; }
        }
        #endregion

        #region XEPLOAISUCKHOE
        private String m_XEPLOAISUCKHOE;
        public String XepLoaiSucKhoe
        {
            get { return m_XEPLOAISUCKHOE; }
            set { m_XEPLOAISUCKHOE = value; }
        }
        #endregion

        #region XEPLOAIDAODUC
        private String m_XEPLOAIDAODUC;
        public String XepLoaiDaoDuc
        {
            get { return m_XEPLOAIDAODUC; }
            set { m_XEPLOAIDAODUC = value; }
        }
        #endregion

        #region XEPLOAITDCHUYENMON
        private String m_XEPLOAITDCHUYENMON;
        public String XepLoaiTDChuyenMon
        {
            get { return m_XEPLOAITDCHUYENMON; }
            set { m_XEPLOAITDCHUYENMON = value; }
        }
        #endregion

        #region XEPLOAICHUNG(nvarchar(255),Null)
        private String m_XEPLOAICHUNG;
        public String XepLoaiChung
        {
            get { return m_XEPLOAICHUNG; }
            set { m_XEPLOAICHUNG = value; }
        }
        #endregion

        #region NHANXET(nvarchar(255),Null)
        private String m_NHANXET;
        public String NhanXet
        {
            get { return m_NHANXET; }
            set { m_NHANXET = value; }
        }
        #endregion
    }
}
