using System;
using System.Collections.Generic;
using System.Text;

namespace Manager_Fortunes.BusinessObject
{
    public class DonViTinh
    {
        public DonViTinh()
        {

        }

        private string m_MaDonViTinh;
        public string MaDonViTinh
        {
            get { return m_MaDonViTinh; }
            set { m_MaDonViTinh = value; }
        }

        private string m_TenDonViTinh;
        public string TenDonViTinh
        {
            get { return m_TenDonViTinh; }
            set { m_TenDonViTinh = value; }
        }

    }
}
