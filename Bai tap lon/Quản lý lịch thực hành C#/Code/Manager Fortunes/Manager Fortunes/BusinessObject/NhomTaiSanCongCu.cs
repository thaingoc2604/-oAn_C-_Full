using System;
using System.Collections.Generic;
using System.Text;

namespace Manager_Fortunes.BusinessObject
{
    public class NhomTaiSanCongCu
    {
        public NhomTaiSanCongCu()
        {

        }
        
        private string m_MaNhom;
        public string MaNhom
        {
            get { return m_MaNhom; }
            set { m_MaNhom = value; }
        }

        private string m_TenNhom;
        public string TenNhom
        {
            get { return m_TenNhom; }
            set { m_TenNhom = value; }
        }

        private string m_CapBat;
        public string CapBat
        {
            get { return m_CapBat; }
            set { m_CapBat = value; }
        }

    }
}
