using System;
using System.Collections.Generic;
using System.Text;

namespace TT_GDTX_ANGIANG.BusinessObject
{
    public class KyLuatInfo
    {
        #region Ham Tao       
        public KyLuatInfo()
        {
        }

        public KyLuatInfo(String maQTTS,string maNV,SoQuyetDinhInfo soQD, DateTime ngayQD, String coQuanKT, String hinhThucKT, String lyDoKT, String nguoiKy, String ghiChu)
        {
            MaQuaTrinhKyLuat = maQTTS;
            MaNhanVien = maNV;
            SoQuyetDinh = soQD;
            NgayQuyetDinh = ngayQD;
            CoQuanKyLuat = coQuanKT;
            HinhThuc = hinhThucKT;
            LyDo = lyDoKT;
            NguoiKy = nguoiKy;
            GhiChu = ghiChu;

        }

        public KyLuatInfo(String maKyLuat, String coQuanKyLuat)
        {
            MaQuaTrinhKyLuat = maKyLuat;
            CoQuanKyLuat = CoQuanKyLuat;
        }
        #endregion

        #region MAQTKT
        private string m_QTKT;
        public string MaQuaTrinhKyLuat
        {
            get { return m_QTKT; }
            set { m_QTKT = value; }
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

        #region SOQD
        private SoQuyetDinhInfo m_SOQD;
        public SoQuyetDinhInfo SoQuyetDinh
        {
            get { return m_SOQD; }
            set { m_SOQD = value; }
        }
        #endregion

        #region NGAYQD
        private DateTime m_NGAYQD;
        public DateTime NgayQuyetDinh
        {
            get { return m_NGAYQD; }
            set { m_NGAYQD = value; }
        }
        #endregion

        #region COQUANKYLUAT
        private String m_COQUANKHENTHUONG;
        public String CoQuanKyLuat
        {
            get { return m_COQUANKHENTHUONG; }
            set { m_COQUANKHENTHUONG = value; }
        }
        #endregion

        #region HINHTHUC
        private String m_HINHTHUC;
        public String HinhThuc
        {
            get { return m_HINHTHUC; }
            set { m_HINHTHUC = value; }
        }
        #endregion

        #region LYDO
        private String m_LYDO;
        public String LyDo
        {
            get { return m_LYDO; }
            set { m_LYDO = value; }
        }
        #endregion

        #region NGUOIKY(nvarchar(255),Null)
        private String m_NGUOIKY;
        public String NguoiKy
        {
            get { return m_NGUOIKY; }
            set { m_NGUOIKY = value; }
        }
        #endregion

        #region GHICHU(nvarchar(255),Null)
        private String m_GHICHU;
        public String GhiChu
        {
            get { return m_GHICHU; }
            set { m_GHICHU = value; }
        }
        #endregion
    }
}
