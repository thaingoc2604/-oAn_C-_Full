using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
   public  class Phong_Info
    {
       public string MaPHG { get; set; }
       public string TenPhong { get; set; }
       public string ThietBi { get; set; }
       public Phong_Info() { }
       public Phong_Info(string maPHG, string tenPhong, string thietbi)
       {
           MaPHG = maPHG;
           TenPhong = tenPhong;
           ThietBi = thietbi;
       }

    }
}
