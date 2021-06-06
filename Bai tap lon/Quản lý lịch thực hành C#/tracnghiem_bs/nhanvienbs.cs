using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using tracnghiem_da;

namespace tracnghiem_bs
{
    public class nhanvienbs
    {
        nhanvienda objnv = new nhanvienda(); 
        public DataSet DangNhapNV(string tendn, string pass)
        {
            return objnv.DangNhapNV(tendn, pass);
        }
        public DataSet ThongTinNV(string pass)
        {
            return objnv.ThongTinNV(pass);
        }
        public DataSet GetNhanVien()
        {
            return objnv.GetNhanVien();
        }
        public DataSet GetNhanVienCV(string cv)
        {
            return objnv.GetNhanVienCV(cv);
        }
        public DataSet GetNhanVienL2()
        {
            return objnv.GetNhanVienL2();
        }
        public DataSet GetNhanVien_Ma(string ma)
        {
            return objnv.GetNhanVien_Ma(ma);
        }
        public DataSet ThemNV(string manv, string hoten, string diachi, string sodt, string chucv,string mknguoidung)
        {
            return objnv.ThemNV(manv, hoten, diachi, sodt, chucv, mknguoidung);
        }
        public DataSet UpdateNhanvien(string diachi, string sodt, string ma)
        {
            return objnv.UpdateNhanvien(diachi, sodt, ma);
        }
        public DataSet DeleteNhanVien(string manv)
        {
            return objnv.DeleteNhanVien(manv);
        }
    }
}
