using System;
using System.Collections.Generic;
using System.Text;

namespace TT_GDTX_ANGIANG.BusinessObject
{
    public class KetQuaTuyenDungInfo
    {
        #region Constructor
        public KetQuaTuyenDungInfo()
        {
        }

        public KetQuaTuyenDungInfo(int maKQ, string maHS, string manv, string phongban, BoPhanInfo boPhan, ChucVuInfo chucVu, string soQD, DateTime ngayTD,  byte trangthai)
        {
            MaKetQua = maKQ;
            MaHoSo = maHS;          
            MaNhanVien = manv;
            PhongBan = phongban;
            BoPhan = boPhan;
            ChucVu = chucVu;
            SoQuyetDinh = soQD;
            NgayTuyenDung = ngayTD;          
            Status = trangthai;
        }
        #endregion

        #region MAKQTD
        private int m_MAKQTD;
        public int MaKetQua
        {
            get { return m_MAKQTD; }
            set { m_MAKQTD = value; }
        }
        #endregion

        #region MAHS
        private string m_MAHS;
        public string MaHoSo
        {
            get { return m_MAHS; }
            set { m_MAHS = value; }
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

        #region PHONGBAN
        private string m_PHONGBAN;
        public string PhongBan
        {
            get { return m_PHONGBAN; }
            set { m_PHONGBAN = value; }
        }
        #endregion

        #region BOPHAN
        private BoPhanInfo m_BOPHAN;
        public BoPhanInfo BoPhan
        {
            get { return m_BOPHAN; }
            set { m_BOPHAN = value; }
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

        #region SOQD
        private string m_SOQD;
        public string SoQuyetDinh
        {
            get { return m_SOQD; }
            set { m_SOQD = value; }
        }
        #endregion

        #region NGAYTD
        private DateTime m_NGAYTD;
        public DateTime NgayTuyenDung
        {
            get { return m_NGAYTD; }
            set { m_NGAYTD = value; }
        }
        #endregion

        #region GHICHU
        private string m_GHICHU;
        public string GhiChu
        {
            get { return m_GHICHU; }
            set { m_GHICHU = value; }
        }
        #endregion

        #region STATUS
        private int m_STATUS;
        public int Status
        {
            get { return m_STATUS; }
            set { m_STATUS = value; }
        }
        #endregion
    }
}
