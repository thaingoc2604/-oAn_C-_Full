using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace QLTS.BusinessObject
{
  public class DonvitinhObject
    {
      public DonvitinhObject(String madvt, String tendvt)
        {
            this.m_Madonvitinh = madvt;
            this.m_Tendonvitinh = tendvt;
            
        }
       
        private String m_Madonvitinh;
        public String Madonvitinh
        {
            get { return m_Madonvitinh; }
            set { value = m_Madonvitinh; }
        }
        private String m_Tendonvitinh;
        public String Tendonvitinh
        {
            get { return m_Tendonvitinh; }
            set { value = m_Tendonvitinh; }
        }
      
    }
}
