using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class PhanQuyen
    {
        public string MaDangNhap { get; set; }
        public string TenDangNhap { get; set; }
        public PhanQuyen() { }
        public PhanQuyen(string madn, string tendn)
        {
            MaDangNhap = madn;
            TenDangNhap = tendn;
        }

    }
}
