using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class Lop_Info
    {
        public string MaLop { get; set; }
        public string TenLop{ get; set; }
        public int TongSo { get; set; }
        public Lop_Info() { }
        public Lop_Info(string malop, string tenlop, int tongso)
        {
            MaLop = malop;
            TenLop = tenlop;
            TongSo = tongso;
        }
    }
}
