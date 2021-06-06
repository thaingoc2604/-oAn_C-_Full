using System;
using System.Collections.Generic;
using System.Text;

namespace TT_GDTX_ANGIANG.BusinessObject
{
    public class TrinhDo_NgoaiNguInfo
    {
         #region Ham Tao       
        public TrinhDo_NgoaiNguInfo()
        {
        }

        public TrinhDo_NgoaiNguInfo(String maTDNN, String tenTDNN)
        {
            MaTrinhDoNgoaiNgu = maTDNN;
            TenTrinhDoNgoaiNgu = tenTDNN;
        }
        
        
        #endregion

        #region MATDNN
        private String m_TDNN;
        public String MaTrinhDoNgoaiNgu
        {
            get { return m_TDNN; }
            set { m_TDNN = value; }
        }
        #endregion

        #region TENTDNN
        private String m_TENTDNN;
        public String TenTrinhDoNgoaiNgu
        {
            get { return m_TENTDNN; }
            set { m_TENTDNN = value; }
        }
        #endregion
    }
}
