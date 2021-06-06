using System;
using System.Collections.Generic;
using System.Text;

namespace TT_GDTX_ANGIANG.BusinessObject
{
    public class ChucVuInfo
    {
        #region Constructor
        public ChucVuInfo()
        {
        }

        public ChucVuInfo(string maCV, string tenCV, float heSoCV, string gChu)
        {
            MaChucVu = maCV;
            TenChucVu = tenCV;
            HeSoChucVu = heSoCV;
            GhiChu = gChu;
        }

        public ChucVuInfo(string maCV, string tenCV)
        {
            MaChucVu = maCV;
            TenChucVu = tenCV;
        }
        #endregion

        #region MACV
        private string m_MACV;
        public string MaChucVu
        {
            get { return m_MACV; }
            set { m_MACV = value; }
        }
        #endregion

        #region TENCV
        private string m_TENCV;
        public string TenChucVu
        {
            get { return m_TENCV; }
            set { m_TENCV = value; }
        }
        #endregion

        #region HESOCHUCVU
        private float m_HESOCHUCVU;
        public float HeSoChucVu
        {
            get { return m_HESOCHUCVU; }
            set { m_HESOCHUCVU = value; }
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
