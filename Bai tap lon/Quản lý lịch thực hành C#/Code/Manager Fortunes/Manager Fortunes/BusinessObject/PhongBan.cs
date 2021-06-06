using System;
using System.Collections.Generic;
using System.Text;

namespace Manager_Fortunes.BusinessObject
{
    public class PhongBan
    {
        public PhongBan()
        {

        }

        private string m_MaPhong;
        public string MaPhong
        {
            get { return m_MaPhong; }
            set { m_MaPhong = value; }
        }

        private string m_TenPhong;
        public string TenPhong
        {
            get { return m_TenPhong; }
            set { m_TenPhong = value; }
        }

        private string m_SoDienThoai;
        public string SodienThoai
        {
            get { return m_SoDienThoai; }
            set { m_SoDienThoai = value; }
        }

    }
}
