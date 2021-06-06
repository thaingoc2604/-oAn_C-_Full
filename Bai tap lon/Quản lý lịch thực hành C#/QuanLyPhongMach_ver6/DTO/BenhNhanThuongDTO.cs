using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class BenhNhanThuongDTO:BenhNhanDTO
    {
        private int _sttBNT;

        public int sttBNT
        {
            get { return _sttBNT; }
            set { _sttBNT = value; }
        }

        public BenhNhanThuongDTO()
        {
            NgayKham = DateTime.Now;
            GioiTinh = "Nam";
        }        
    }
}
