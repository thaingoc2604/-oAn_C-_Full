//Đề Tài Quản Lý Món Ăn Ngon
//Sinh Viên Thực Hiện: Nguyễn Hoàng Vũ - 10200681 - NCTH4A
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class MonAn
    {
        public string MaMon { get; set; }
        public string TenMon { get; set; }
        public string MaLoai { get; set; }
        public string SucKhoe { get; set; }
        public string NguyenLieu { get; set; }
        public string CachLam { get; set; }
        public string ChuY { get; set; }
        public MonAn() { }
        public MonAn(string mamon, string tenmon, string maloai, string suckhoe, string nguyenlieu, string cachlam, string chuy)
        {
            MaMon = mamon;
            TenMon = tenmon;
            MaLoai = maloai;
            SucKhoe = suckhoe;
            NguyenLieu = nguyenlieu;
            CachLam = cachlam;
            ChuY = chuy;
        }
    }
}
