using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class LichThu
    {
          public string TenGV { get; set; }
          public string TenMH { get; set; }
          public string Phong { get; set; }
          public string ThoiGian { get; set; }
          public LichThu() { }
          public LichThu(string gv, string mh, string phong, string thoigian)
          {
              TenGV = gv;
              TenMH = mh;
              Phong = phong;
              ThoiGian = thoigian;
          }
          public override string ToString()
          {
              return TenMH+"\n"+ThoiGian+"\n"+Phong+"\n"+TenGV;
          }

    }
}
