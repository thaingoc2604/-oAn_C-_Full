using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class SoDu_DTO
    {
        DateTime _ngaythang;

        public DateTime Ngaythang
        {
            get { return _ngaythang; }
            set { _ngaythang = value; }
        }
        int _soton;

        public int Soton
        {
            get { return _soton; }
            set { _soton = value; }
        }

    }
}
