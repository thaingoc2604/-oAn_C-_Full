using System;
using System.Collections.Generic;
using System.Text;

namespace TT_GDTX_ANGIANG.BusinessObject
{
    public class NghiViecInfo
    {
        #region Constructor
        public NghiViecInfo()
        {
        }

        public NghiViecInfo(string maNghiViec, string maNV, string soQD, DateTime ngayQD, string nguoiKy,ChucVuInfo chucVu, DateTime ngayTV, string lydoTV)
        {
            MaNghiViec = maNghiViec;
            MaNhanVien = maNV;
            SoQuyetDinh = soQD;
            NgayQuyetDinh = ngayQD;
            NguoiKy = nguoiKy;
            NgayThoiViec = ngayTV;
            LyDoTV = lydoTV;
            ChucVu = chucVu;
           
        }
        #endregion

        #region MANGHIVIEC
        private string m_MANGHIVIEC;
        public string MaNghiViec
        {
            get { return m_MANGHIVIEC; }
            set { m_MANGHIVIEC = value; }
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
        private string m_SOQD;
        public string SoQuyetDinh
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

        #region NGUOIKY
        private string m_NGUOIKY;
        public string NguoiKy
        {
            get { return m_NGUOIKY; }
            set { m_NGUOIKY = value; }
        }
        #endregion

        #region NGAYTV
        private DateTime m_NGAYTV;
        public DateTime NgayThoiViec
        {
            get { return m_NGAYTV; }
            set { m_NGAYTV = value; }
        }
        #endregion

        #region LYDOTV
        private string m_LYDOTV;
        public string LyDoTV
        {
            get { return m_LYDOTV; }
            set { m_LYDOTV = value; }
        }
        #endregion

        #region CHUCVU
        private ChucVuInfo m_CHUCVU;
        public ChucVuInfo ChucVu
        {
            get { return m_CHUCVU; }
            set { m_CHUCVU = value; }
        }
        #endregion
    }
}
