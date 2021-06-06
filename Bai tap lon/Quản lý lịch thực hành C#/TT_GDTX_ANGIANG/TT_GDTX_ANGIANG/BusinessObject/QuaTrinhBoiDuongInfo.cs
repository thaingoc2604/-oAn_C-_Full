using System;
using System.Collections.Generic;
using System.Text;

namespace TT_GDTX_ANGIANG.BusinessObject
{
    public class QuaTrinhBoiDuongInfo
    {
        #region Constructor
        public QuaTrinhBoiDuongInfo()
        {
        }

        public QuaTrinhBoiDuongInfo(string maQTBD,string maNV,  DateTime ngayBD, DateTime ngayKT, string noiBoiDuong, string noiDungBoiDuong)
        {
            MaQTBD = maQTBD;
            MaNhanVien = maNV;
            NgayBatDau = ngayBD;
            NgayKetThuc = ngayKT;
            NoiBoiDUong = noiBoiDuong;
            NoiDungBoiDUong = noiBoiDuong;            
        }
        
        #endregion

        #region MAQTBD
        private string m_QTBD;
        public string MaQTBD
        {
            get { return m_QTBD; }
            set { m_QTBD = value; }
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



        #region NOIBOIDUONG
        private string m_NOIBOIDUONG;
        public string NoiBoiDUong
        {
            get { return m_NOIBOIDUONG; }
            set { m_NOIBOIDUONG = value; }
        }
        #endregion


        #region NOIDUNGBOIDUONG
        private string m_NOIDUNGBOIDUONG;
        public string NoiDungBoiDUong
        {
            get { return m_NOIDUNGBOIDUONG; }
            set { m_NOIDUNGBOIDUONG = value; }
        }
        #endregion
    }
}
