using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace tracnghiem_da
{
    public class nhanvienda
    {
        tracnghiem_data objdata = new tracnghiem_data();
        public DataSet DangNhapNV(string tendn, string pass)
        {
            string sql="select * from  nhanvien  where hoten='" + tendn + "' and mknguoidung='" + pass + "'";
            return objdata.executeQuery(sql, "nhanvien");

        }
        public DataSet ThongTinNV(string pass)
        {
            string sql="select * from nhanvien where mknguoidung='" + pass + "'";
            return objdata.executeQuery(sql, "nhanvien");
        }
        public DataSet GetNhanVien()
        {
            string sql="Select * from nhanvien";
            return objdata.executeQuery(sql, "nhavien");
        }
        public DataSet GetNhanVienCV(string cv)
        {
            string sql="Select * from nhanvien where chucvu='" + cv + "'";
            return objdata.executeQuery(sql,"nhanvien");
        }
        public DataSet GetNhanVienL2()
        {
            string sql="Select * from nhanvien ";
            return objdata.executeQuery(sql, "nhanvien");
        }
        public DataSet GetNhanVien_Ma(string ma)
        {
            string sql="Select * from nhanvien where manv='" + ma + "'";
            return objdata.executeQuery(sql, "nhanvien");
        }
       
        public DataSet ThemNV(string manv, string hoten, string diachi, string sodt, string chucv,string mknguoidung)
        {
            try
            {
                string sql = "insert into nhanvien(manv,hoten, diachi,sdt, chucvu, mknguoidung) values('" + manv + "','" + hoten + "','" + diachi + "','" + sodt + "','" + chucv + "','" + mknguoidung + "')";
                return objdata.executeQuery(sql, "nhanvien");
            }
            catch (Exception)
            {
                throw new Exception("Không thể thêm nhân viên");
            }
        }
        
        public DataSet UpdateNhanvien(string diachi, string sodt,string ma)
        {
            try
            {
                string sql = "update nhanvien set diachi='" + diachi + "', sdt='" + sodt + "' where manv='" + ma + "'";
                return objdata.executeQuery(sql, "nhanvien");
            }
            catch (Exception)
            {
                throw new Exception("Không thể thêm tài khoản");
            }
        }
        
        public DataSet DeleteNhanVien(string manv)
        {
            try
            {
                string sql = " delete from nhanvien where manv='" + manv + "'";
                return objdata.executeQuery(sql, "nhanvien");
            }
            catch (Exception )
            {
                throw new Exception(" Không thể xóa nhân viên");
            }
        }
    }
}
