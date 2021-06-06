using System;
using System.Collections.Generic;
using System.Text;

namespace TT_GDTX_ANGIANG.BusinessObject
{
    public class NhatKyInfo
    {
        #region Constructor
        public NhatKyInfo()
        {
        }

        public NhatKyInfo(string maNKy, string tenDangNhap, string tenDayDu, string ngaydangnhap, string lydo)
        {
            
        }

        #region MANHATKY
        private string m_MANK;
        public string MaNhatKy
        {
            get { return m_MANK; }
            set { m_MANK = value; }
        }
        #endregion

      
        #region TENDN
        private string m_TENDN;
        public string TenDangNhap
        {
            get { return m_TENDN; }
            set { m_TENDN = value; }
        }
        #endregion

     

        #region HOTEN
        private string m_HOTEN;
        public string HoTenDayDu
        {
            get { return m_HOTEN; }
            set { m_HOTEN = value; }
        }
        #endregion

        #region NGAYDANGNHAP
        private string m_NGAYDANGNHAP;
        public string NgayDangNhap
        {
            get { return m_NGAYDANGNHAP; }
            set { m_NGAYDANGNHAP = value; }
        }
        #endregion

        #region LYDO
        private string m_LYDO;
        public string LyDoDangNhap
        {
            get { return m_LYDO; }
            set { m_LYDO = value; }
        }
        #endregion
        #endregion
    }
}
