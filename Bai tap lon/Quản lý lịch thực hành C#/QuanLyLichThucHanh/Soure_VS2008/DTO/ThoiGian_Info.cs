using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public  class ThoiGian_Info
    {
        public string MaTG { get; set; }
        public string Tiet { get; set; }
        public ThoiGian_Info(){}
        public ThoiGian_Info(string maTG, string tiet)
        {
            MaTG=maTG;
            Tiet=tiet;
        }
    }
}
