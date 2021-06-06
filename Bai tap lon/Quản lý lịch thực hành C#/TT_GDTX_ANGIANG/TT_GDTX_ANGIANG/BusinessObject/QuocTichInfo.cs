using System;
using System.Collections.Generic;
using System.Text;

namespace TT_GDTX_ANGIANG.BusinessObject
{
    public class QuocTichInfo
    {
        #region Constructor
        public QuocTichInfo()
        {
        }

        public QuocTichInfo(string maQT, string tenQT, string gChu)
        {
            MaQuocTich = maQT;
            TenQuocTich = tenQT;
            GhiChu = gChu;
        }

        public QuocTichInfo(string maQT, string tenQT)
        {
            MaQuocTich = maQT;
            TenQuocTich = tenQT;
           
        }
        #endregion

        #region MAQT
        private string m_MAQT;
        public string MaQuocTich
        {
            get { return m_MAQT; }
            set { m_MAQT = value; }
        }
        #endregion

        #region TENQT
        private string m_TENQT;
        public string TenQuocTich
        {
            get { return m_TENQT; }
            set { m_TENQT = value; }
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
