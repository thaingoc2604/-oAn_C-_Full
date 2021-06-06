using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class PHIEUCHI_DTO
    {
        int _maphieuchi;

        public int Maphieuchi
        {
            get { return _maphieuchi; }
            set { _maphieuchi = value; }
        }
      
        string _diachi;

        public string Diachi
        {
            get { return _diachi; }
            set { _diachi = value; }
        }
        int _maloaiphieu;

        public int Maloaiphieu
        {
            get { return _maloaiphieu; }
            set { _maloaiphieu = value; }
        }


        Int64 _sotien;

        public Int64 Sotien
        {
            get { return _sotien; }
            set { _sotien = value; }
        }
        DateTime _ngaylap;

        public DateTime Ngaylap
        {
            get { return _ngaylap; }
            set { _ngaylap = value; }
        }
        int _ton;

        public int Ton
        {
            get { return _ton; }
            set { _ton = value; }
        }
        string _diengiai;

        public string Diengiai
        {
            get { return _diengiai; }
            set { _diengiai = value; }
        }
    }
}
