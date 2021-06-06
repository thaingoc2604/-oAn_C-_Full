using System;
using System.Collections.Generic;
using System.Text;

namespace TT_GDTX_ANGIANG.BusinessObject
{
    public class QuaTrinhHoatDongXaHoiInfo
    {
        #region Constructor
        public QuaTrinhHoatDongXaHoiInfo()
        {
        }

        public QuaTrinhHoatDongXaHoiInfo(string maQTHDXH, string maNV, DateTime tuNgay, DateTime denNgay, String noiDung)
        {
            MaQTHoatDongXaHoi = maQTHDXH;
            MaNhanVien = maNV;
            TuNgay = tuNgay;
            DenNgay = denNgay;
            NoiDung = noiDung;
        }

               
        #endregion

        #region MAQTHDXH
        private string m_MAQTHDXH;
        public string MaQTHoatDongXaHoi
        {
            get { return m_MAQTHDXH; }
            set { m_MAQTHDXH = value; }
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

        #region NOIDUNG
        private string m_NOIDUNG;
        public string NoiDung
        {
            get { return m_NOIDUNG; }
            set { m_NOIDUNG = value; }
        }
        #endregion
    }
}
