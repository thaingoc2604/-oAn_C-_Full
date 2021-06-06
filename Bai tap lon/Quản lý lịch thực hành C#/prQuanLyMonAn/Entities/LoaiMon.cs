//Đề Tài Quản Lý Món Ăn Ngon
//Sinh Viên Thực Hiện: Nguyễn Hoàng Vũ - 10200681 - NCTH4A
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class LoaiMon
    {
        public string MaLoai { get; set; }
        public string TenLoai { get; set; }
        public LoaiMon() { }
        public LoaiMon(string maloai, string tenloai)
        {
            MaLoai = maloai;
            TenLoai = tenloai;
        }
    }
}
