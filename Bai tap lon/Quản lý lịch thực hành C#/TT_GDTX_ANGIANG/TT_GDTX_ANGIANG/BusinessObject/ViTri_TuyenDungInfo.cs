using System;
using System.Collections.Generic;
using System.Text;

namespace TT_GDTX_ANGIANG.BusinessObject
{
    public class ViTri_TuyenDungInfo
    {
        #region Constructor
        public ViTri_TuyenDungInfo()
        {
        }

        public ViTri_TuyenDungInfo(String maVT, String tenVT, string tenTat, string gChu)
        {
            MaVTTD = maVT;
            TenVTTD = tenVT;
            TenTat = tenTat;
            GhiChu = gChu;
        }
        public ViTri_TuyenDungInfo(String maVT, String tenVT)
        {
            MaVTTD = maVT;
            TenVTTD = tenVT;            
        }
        #endregion

        #region MAVTTD
        private String m_MAVTTD;
        public String MaVTTD
        {
            get { return m_MAVTTD; }
            set { m_MAVTTD = value; }
        }
        #endregion

        #region TENVTTD
        private String m_TENVTTD;
        public String TenVTTD
        {
            get { return m_TENVTTD; }
            set { m_TENVTTD = value; }
        }
        #endregion

        #region TENTAT
        private string m_TENTAT;
        public string TenTat
        {
            get { return m_TENTAT; }
            set { m_TENTAT = value; }
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
