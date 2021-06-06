using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using QLTS.BusinessObject;

namespace QLTS.BusinessObject
{
   public class NhomtaisanObject
    {
       //String m_Capbac;
       //String m_Manhomtaisan;
       

       public NhomtaisanObject(String capbac, String manhomtaisan, String maso, String tennhomtaisan, String madvt)
        {
            this.m_Capbac = capbac;
            this.m_Manhomtaisan = manhomtaisan;
            this.m_Maso = maso;
            this.m_Tennhomtaisan = tennhomtaisan;
            this.m_Madonvitinh = madvt;
       }

       private String m_Capbac;
       public String Capbac
        {
            get { return m_Capbac; }
            set { value = m_Capbac; }
        }
       private String m_Manhomtaisan;
       public String Manhomtaisan
        {
            get { return m_Manhomtaisan; }
            set { value = m_Manhomtaisan; }
        }
       private String m_Maso;
       public String Maso
        {
            get { return m_Maso; }
            set { value = m_Maso; }
        }
       private String m_Tennhomtaisan;
       public String Tennhomtaisan
        {
            get { return m_Tennhomtaisan; }
            set { value = m_Tennhomtaisan; }
        }
       private String m_Madonvitinh;
       public String Madonvitinh
        {
            get { return m_Madonvitinh; }
            set { value = m_Madonvitinh; }
        }
    }
}
