using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace QLTS.BusinessObject
{
   public class LydotanggiamObject
    {
       public LydotanggiamObject(String malydo, String tenlydo, String giatri)
        {
            this.m_Malydo = malydo;
            this.m_Tenlydo = tenlydo;
            this.m_Giatri = giatri;
           
        }
       private String m_Malydo;
       public String Malydo
        {
            get { return m_Malydo; }
            set { value = m_Malydo; }
        }
       private String m_Tenlydo;
        public String Tenlydo
        {
            get { return m_Tenlydo; }
            set { value = m_Tenlydo; }
        }
       private String m_Lydo;
        public String Lydo
        {
            get { return m_Lydo; }
            set { value = m_Lydo; }
        }
       private String m_Giatri;
       public String Giatri
        {
            get { return m_Giatri; }
            set { value = m_Giatri; }
        }
    }
}
