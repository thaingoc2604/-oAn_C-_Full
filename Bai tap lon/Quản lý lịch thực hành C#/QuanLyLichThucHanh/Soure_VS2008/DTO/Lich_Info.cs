using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
   public  class Lich_Info
    {
       public string MaGV { get; set; }
      public string MaMH { get; set; }
      public string Lop { get; set; }
      public string Phong { get; set; }
      public string ThoiGian { get; set; }
      public DateTime Ngay { get; set; }
      public int Tuan { get; set; }
      public int Thu { get; set; }
      public Lich_Info() { }
      public Lich_Info(string gv,string mh,string lop,string phong,string thoigian,DateTime ngay,int tuan,int thu)
      {
          MaGV = gv;
          MaMH = mh;
          Lop = lop;
          Phong = phong;
          ThoiGian = thoigian;
          Ngay = ngay;
          Tuan = tuan;
          Thu = thu;
      }

    }
}
