using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class GiaoVien_Info
    {
        public string MaGV { get; set; }
        public string HoGV { get; set; }
        public string TenGV { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string ChuyenNganh { get; set; }
        public string DiaChi { get; set; }
        public string SoDT { get; set; }
        public GiaoVien_Info() { }
        public GiaoVien_Info(string ma,string ho,string ten,string gt,DateTime ns,string  chuyenNganh,string dc,string soDT)
        {
            MaGV = ma;
            HoGV = ho;
            TenGV = ten;
            GioiTinh = gt;
            NgaySinh = ns;
            ChuyenNganh = chuyenNganh;
            DiaChi = dc; 
            SoDT = soDT;
        }
    }
}
