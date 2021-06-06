using System;
using System.Collections.Generic;
using System.Text;

namespace TT_GDTX_ANGIANG.BusinessObject
{
    public class TrinhDo_HocVanInfo
    {
        #region Constructor
        public TrinhDo_HocVanInfo()
        {
        }

        public TrinhDo_HocVanInfo(String maHV, String tenHV, string gChu)
        {
            MaHocVan = maHV;
            TenHocVan = tenHV;
            GhiChu = gChu;
        }
        public TrinhDo_HocVanInfo(String maHV, String tenHV)
        {
            MaHocVan = maHV;
            TenHocVan = tenHV;
            
        }
        #endregion

        #region MAHV
        private String m_MAHV;
        public String MaHocVan
        {
            get { return m_MAHV; }
            set { m_MAHV = value; }
        }
        #endregion

        #region TENHV
        private String m_TENHV;
        public String TenHocVan
        {
            get { return m_TENHV; }
            set { m_TENHV = value; }
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
    }
}
