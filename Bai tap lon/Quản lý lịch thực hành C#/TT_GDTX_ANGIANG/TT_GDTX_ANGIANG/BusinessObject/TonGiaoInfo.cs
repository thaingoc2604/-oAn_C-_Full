using System;
using System.Collections.Generic;
using System.Text;

namespace TT_GDTX_ANGIANG.BusinessObject
{
    public class TonGiaoInfo
    {
        #region Ham Tao
        /// <summary>
        /// Ham tao khong doi so
        /// </summary>
        public TonGiaoInfo()
        {
        }
        /// <summary>
        /// Ham tao co doi so
        /// </summary>
        /// <param name="maTG">Ma ton giao</param>
        /// <param name="tenTG">Ten ton giao</param>
        /// <param name="gChu">Ghi chu</param>
        public TonGiaoInfo(String maTG, String tenTG, String gChu)
        {
            MaTonGiao = maTG;
            TenTonGiao = tenTG;
            GhiChu = gChu;
        }

        public TonGiaoInfo(String maTG, String tenTG)
        {
            MaTonGiao = maTG;
            TenTonGiao = tenTG;
            
        }
        #endregion

        #region MATG(Primary,int(4),Not Null)
        private String m_MATG;
        public String MaTonGiao
        {
            get { return m_MATG; }
            set { m_MATG = value; }
        }
        #endregion

        #region TENTG(nvarchar(159),Null)
        private String m_TENTG;
        public String TenTonGiao
        {
            get { return m_TENTG; }
            set { m_TENTG = value; }
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
