using System;
using System.Collections.Generic;
using System.Text;

namespace TT_GDTX_ANGIANG.BusinessObject
{
    public class QuaTrinhCongTacInfo
    {
        #region Ham Tao       
        public QuaTrinhCongTacInfo()
        {
        }

        public QuaTrinhCongTacInfo(string maQTCT, string maNV, DateTime tuNgay, DateTime denNgay, String noiCongTac, String chucDanh, String chucVuCaoNhat)
        {
            MaQuaTrinhCongTac = maQTCT;
            MaNhanVien = maNV;
            TuNgay = tuNgay;
            DenNgay = denNgay;
            NoiCongTac = noiCongTac;
            ChucDanh = chucDanh;
            ChucVuCaoNhat = chucVuCaoNhat;
           

        }
        #endregion

        #region MAQTCT
        private string m_QTCT;
        public string MaQuaTrinhCongTac
        {
            get { return m_QTCT; }
            set { m_QTCT = value; }
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

        #region NOICONGTAC(nvarchar(255),Null)
        private String m_NOICONGTAC;
        public String NoiCongTac
        {
            get { return m_NOICONGTAC; }
            set { m_NOICONGTAC = value; }
        }
        #endregion

        #region CHUCDANH(nvarchar(255),Null)
        private String m_CHUCDANH;
        public String ChucDanh
        {
            get { return m_CHUCDANH; }
            set { m_CHUCDANH = value; }
        }
        #endregion

        #region CHUCVUCAONHAT(nvarchar(255),Null)
        private String m_CHUCVUCAONHAT;
        public String ChucVuCaoNhat
        {
            get { return m_CHUCVUCAONHAT; }
            set { m_CHUCVUCAONHAT = value; }
        }
        #endregion

       
    }
}
