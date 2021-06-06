using System;
using System.Collections.Generic;
using System.Text;

namespace TT_GDTX_ANGIANG.BusinessObject
{
    public class ThaiSanInfo
    {
        #region Ham Tao       
        public ThaiSanInfo()
        {
        }
        #region MANHANVIEN
        private string m_MANHANVIEN;
        public string MaNhanVien
        {
            get { return m_MANHANVIEN; }
            set { m_MANHANVIEN = value; }
        }
        #endregion
        public ThaiSanInfo(String maQTTS,String maNV, SoQuyetDinhInfo soQD, DateTime ngayQD, int sinhConThu, DateTime ngayBD, DateTime ngayKT, String nguoiKy, String noidung)
        {
            MaNhanVien = maNV;
            MaQuaTrinhThaiSan = maQTTS;
            SoQuyetDinh = soQD;
            NgayQuyetDinh = ngayQD;
            SinhConThuMay = sinhConThu;
            NgayBatDau = ngayBD;
            NgayKetThuc = ngayKT;
            NguoiKy = nguoiKy;
            NoiDung = noidung;

        }

        public ThaiSanInfo(String maQTTS, String nguoiKy)
        {
            MaQuaTrinhThaiSan = maQTTS;
            NguoiKy = nguoiKy;
        }
        #endregion

        #region MAQTTS
        private string m_QTTS;
        public string MaQuaTrinhThaiSan
        {
            get { return m_QTTS; }
            set { m_QTTS = value; }
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

        #region SINHCONTHUMAY
        private int m_SINHCONTHUMAY;
        public int SinhConThuMay
        {
            get { return m_SINHCONTHUMAY; }
            set { m_SINHCONTHUMAY = value; }
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

        #region NGUOIKY(nvarchar(255),Null)
        private String m_NGUOIKY;
        public String NguoiKy
        {
            get { return m_NGUOIKY; }
            set { m_NGUOIKY = value; }
        }
        #endregion

        #region NOIDUNG(nvarchar(255),Null)
        private String m_NOIDUNG;
        public String NoiDung
        {
            get { return m_NOIDUNG; }
            set { m_NOIDUNG = value; }
        }
        #endregion
    }
}
