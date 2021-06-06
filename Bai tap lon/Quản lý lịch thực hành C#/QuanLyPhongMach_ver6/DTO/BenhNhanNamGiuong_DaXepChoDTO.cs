using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class BenhNhanNamGiuong_DaXepChoDTO : BenhNhanDTO
    {
        private int _sttBNNG_DXC;
        private int _sttGiuong;
        private DateTime _NgayXep;


        public int sttBNNG_DXC
        {
            get { return _sttBNNG_DXC; }
            set { _sttBNNG_DXC = value; }
        }

        public int sttGiuong
        {
            get { return _sttGiuong; }
            set { _sttGiuong = value; }
        }

        public DateTime NgayXep
        {
            get { return _NgayXep; }
            set { _NgayXep = value; }
        }

        public BenhNhanNamGiuong_DaXepChoDTO()
        {
            //this._sttGiuong = 0;
            this._NgayXep = DateTime.Now;
        }

        public override int TinhTien()
        {
            return base.TinhTien()-(10*base.TinhTien()/100);
        }
    }
}
