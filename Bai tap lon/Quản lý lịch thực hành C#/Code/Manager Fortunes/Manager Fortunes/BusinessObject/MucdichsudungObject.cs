using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace QLTS.BusinessObject
{
   public class MucdichsudungObject
    {
       public MucdichsudungObject(String mamucdichsudung, String tenmucdichsudung)
        {
            this.m_Mamucdichsudung = mamucdichsudung;
            this.m_Tenmucdichsudung = tenmucdichsudung;
            
        }

       private String m_Mamucdichsudung;
       public String Mamucdichsudung
        {
            get { return m_Mamucdichsudung; }
            set { value = m_Mamucdichsudung; }
        }
       private String m_Tenmucdichsudung;
       public String Tenmucdichsudung
        {
            get { return m_Tenmucdichsudung; }
            set { value = m_Tenmucdichsudung; }
        }
      
    }
}
