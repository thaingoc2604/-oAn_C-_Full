using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;



namespace DTO
{
    public class Nhom_DTO
    {
        int _manhom;

        public int Manhom
        {
            get { return _manhom; }
            set { _manhom = value; }
        }

        string _TenNhom;

        public string TenNhom
        {
            get { return _TenNhom; }
            set { _TenNhom = value; }
        }
    }
}
