using System;
using System.Collections.Generic;
using System.Text;

namespace TT_GDTX_ANGIANG.BusinessObject
{
    public class TrinhDo_TinHocInfo
    {
         #region Ham Tao       
        public TrinhDo_TinHocInfo()
        {
        }

        public TrinhDo_TinHocInfo(string maTDTH, String tenTDTH)
        {
            MaTrinhDoTinHoc = maTDTH;
            TenTrinhDoTinHoc = tenTDTH;
        }
        #endregion

        #region MATDTH
        private string m_TDTH;
        public string MaTrinhDoTinHoc
        {
            get { return m_TDTH; }
            set { m_TDTH = value; }
        }
        #endregion

        #region TENTDTH
        private String m_TENTDTH;
        public String TenTrinhDoTinHoc
        {
            get { return m_TENTDTH; }
            set { m_TENTDTH = value; }
        }
        #endregion
    }
}
