using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace QLTS.BusinessObject
{
   public class PhongbanObject
    {
       public PhongbanObject() { }
       public PhongbanObject(String madiadiem,String maphongban, String tenphongban, String sodienthoai)
        {
            this.m_Tenphongban = maphongban;
            this.m_Maphongban = maphongban;
            this.m_Tenphongban = tenphongban;
            this.m_Sodienthoai = sodienthoai;
            
        }
        private String m_Madiadiem;
        public String Madiadiem
        {
            get { return m_Madiadiem; }
            set { value = m_Madiadiem; }
        }
        private String m_Maphongban;
        public String Maphongban
        {
            get { return m_Maphongban; }
            set { value = m_Maphongban; }
        }
      
       private String m_Tenphongban;
       public String Tenphongban
        {
            get { return m_Tenphongban; }
            set { value = m_Tenphongban; }
        }
        private String m_Sodienthoai;
        public String Sodienthoai
        {
            get { return m_Sodienthoai; }
            set { value = m_Sodienthoai; }
        }
    }
}
