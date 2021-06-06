using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace QLTS.BusinessObject
{
  public  class DiadiemObject
    {
      public DiadiemObject(String madd, String tendd,String diachi, String sodienthoai)
        {
            this.m_Madiadiem = madd;
            this.m_Tendiadiem = tendd;
            this.m_Diachi = diachi;
            this.m_Sodienthoai = sodienthoai;
        }
        //private String m_Sothutu;
        //public String Sothutu
        //{
        //    get { return m_Sothutu; }
        //    set { value = m_Sothutu; }
        //}
        private String m_Madiadiem;
        public String Madiadiem
        {
            get { return m_Madiadiem; }
            set { value = m_Madiadiem; }
        }
        private String m_Tendiadiem;
        public String Tendiadiem
        {
            get { return m_Tendiadiem; }
            set { value = m_Tendiadiem; }
        }
        private String m_Diachi;
        public String Diachi
        {
            get { return m_Diachi; }
            set { value = m_Diachi; }
        }
        private String m_Sodienthoai;
        public String Sodienthoai
        {
            get { return m_Sodienthoai; }
            set { value = m_Sodienthoai; }
        }
    }
}
