using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class ThuVien
    {
        public string NoiDung { get; set; }
        public string DapAn { get; set; }
        public int MaDapAn { get; set; }
        public int MaMucDo { get; set; }
        public int MaTinChi { get; set; }

        public ThuVien()
        { }

        public ThuVien(string noidung, string dapan, int madapan, int mamucdo, int matinchi)
        {
            NoiDung = noidung;
            DapAn = dapan;
            MaDapAn = madapan;
            MaMucDo = mamucdo;
            MaTinChi = matinchi;
        }
    }
}
