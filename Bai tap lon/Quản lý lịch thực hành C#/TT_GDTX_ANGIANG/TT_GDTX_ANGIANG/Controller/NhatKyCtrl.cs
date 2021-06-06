using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Windows.Forms;
using System.Data;
using TT_GDTX_ANGIANG.BusinessObject;
using TT_GDTX_ANGIANG.DataLayer;
using DevComponents.DotNetBar.Controls;

namespace TT_GDTX_ANGIANG.Controller
{
    public class NhatKyCtrl
    {

        #region data_NhatKy
         private NhatKyData m_data_NhatKy;
         public NhatKyData data_NhatKy
        {
            get { return m_data_NhatKy; }
            set { m_data_NhatKy = value; }
        }
        #endregion

        #region Table
        private DataTable m_Table;
        public DataTable Table
        {
            get { return m_Table; }
            set { m_Table = value; }
        }

        #endregion

      

         //public void HienThiTimKiem(DataGridViewX tb)
         //{            
        
         //   if (data_NhatKy == null)
         //       data_NhatKy = new NhatKyData();
         //   DataTable tb = data_NhatKy.NhatKy();
                              
         //}
    }
}
