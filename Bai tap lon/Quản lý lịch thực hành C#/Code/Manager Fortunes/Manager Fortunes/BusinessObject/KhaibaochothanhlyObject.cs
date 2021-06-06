using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace QLTS.BusinessObject
{
   public class KhaibaochothanhlyObject
    {
       public KhaibaochothanhlyObject(String mataisan ,String tentaisan, String lydo, String ngaygiam)
        {
            this.m_Mataisan = mataisan;
            this.m_Tentaisan = tentaisan;
            this.m_Lydo = lydo;
            this.m_Ngaygiam = ngaygiam;
        }
       private String m_Mataisan;
        public String Mataisan
        {
            get { return m_Mataisan; }
            set { value = m_Mataisan; }
        }
       private String m_Tentaisan;
        public String Tentaisan
        {
            get { return m_Tentaisan; }
            set { value = m_Tentaisan; }
        }
       private String m_Lydo;
        public String Lydo
        {
            get { return m_Lydo; }
            set { value = m_Lydo; }
        }
       private String m_Ngaygiam;
        public String Ngaygiam
        {
            get { return m_Ngaygiam; }
            set { value = m_Ngaygiam; }
        }
    }
}
