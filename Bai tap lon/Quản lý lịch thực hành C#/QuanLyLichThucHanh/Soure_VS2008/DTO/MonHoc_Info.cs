using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class MonHoc_Info
    {
        public string MaMH { get; set; }
        public string TenMH { get; set; }
       // public string ChuyenNganh { get; set; }
        public MonHoc_Info() { }
        public MonHoc_Info(string maMH, string tenMH)
        {
            MaMH = maMH;
            TenMH = tenMH;
            //ChuyenNganh = chuyenNganh;
        }


    }
}
