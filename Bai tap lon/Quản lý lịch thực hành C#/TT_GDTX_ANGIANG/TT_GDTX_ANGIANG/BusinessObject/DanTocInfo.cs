using System;
using System.Collections.Generic;
using System.Text;

namespace TT_GDTX_ANGIANG.BusinessObject
{
    public class DanTocInfo
    {
        #region Ham Tao       
        public DanTocInfo()
        {
        }
       
        public DanTocInfo(String maDT, String tenDT, String gChu)
        {
            MaDanToc = maDT;
            TenDanToc = tenDT;
            GhiChu = gChu;
        }

        public DanTocInfo(String maDT, String tenDT)
        {
            MaDanToc = maDT;
            TenDanToc = tenDT;
           
        }
        #endregion

        #region MADT
        private String m_MADT;
        public String MaDanToc
        {
            get { return m_MADT; }
            set { m_MADT = value; }
        }
        #endregion

        #region TENDT
        private String m_TENDT;
        public String TenDanToc
        {
            get { return m_TENDT; }
            set { m_TENDT = value; }
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
