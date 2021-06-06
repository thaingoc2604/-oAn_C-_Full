using System;
using System.Collections.Generic;
using System.Text;

namespace TT_GDTX_ANGIANG.BusinessObject
{
    public class NgoaiNguInfo
    {
        #region Constructor
        public NgoaiNguInfo()
        {
        }

        public NgoaiNguInfo(string maNN, string tenNN, string gChu)
        {
            MaNgoaiNgu = maNN;
            TenNgoaiNgu = tenNN;
            GhiChu = gChu;
        }
        public NgoaiNguInfo(string maNN, string tenNN)
        {
            MaNgoaiNgu = maNN;
            TenNgoaiNgu = tenNN;
           
        }
        #endregion

        #region MANN
        private string m_MANN;
        public string MaNgoaiNgu
        {
            get { return m_MANN; }
            set { m_MANN = value; }
        }
        #endregion

        #region TENNN
        private string m_TENNN;
        public string TenNgoaiNgu
        {
            get { return m_TENNN; }
            set { m_TENNN = value; }
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
