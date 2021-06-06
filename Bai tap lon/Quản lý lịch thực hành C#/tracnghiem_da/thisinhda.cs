using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace tracnghiem_da
{
    public class thisinhda
    {
        tracnghiem_data objdata = new tracnghiem_data();
        public DataSet dangki(string ma, string hoten, string diachi, string ngaysinh, string tendangnhap, string mk)
        {
            string sql = "Insert into thisinh(mathisinh, hoten, diachi, ngaysinh, tendangnhap, matkhau) values('" + ma + "','" + hoten + "','" + diachi + "','" + ngaysinh + "','" + tendangnhap + "','"+mk+"')";
            return objdata.executeQuery(sql, "thisinh");
        }
        public DataSet GetThiSinh(string pass)
        {
            string sql = "Select * from thisinh where matkhau='" + pass + "'";
            return objdata.executeQuery(sql, "thisinh");
        }
        public DataSet GetThiSinhDN(string user, string pass)
        {
           string sql = "Select * from thisinh where tendangnhap='" + user + "' and matkhau='" + pass + "'";
            return objdata.executeQuery(sql, "thisinh");
        }
        public DataSet GetMatKhau(string ma, string tendn)
        {
            string sql = "Select * from thisinh where tendangnhap='" + tendn + "' and mathisinh='" + ma + "'";
            return objdata.executeQuery(sql, "thisinh");
        }
        public DataSet GetThiSinh()
        {
            string sql = "Select mathisinh,hoten,diachi,ngaysinh from thisinh ";
            return objdata.executeQuery(sql,"thisinh");
        }
        public DataSet GetThiSinhTen(string hoten)
        {
            string sql = "Select mathisinh,hoten,diachi,ngaysinh from thisinh where hoten='" + hoten + "' ";
            return objdata.executeQuery(sql,"thisinh");
        }
        public DataSet GetThiSinhMa(string ma)
        {
             string sql = "Select mathisinh,hoten,diachi,ngaysinh from thisinh where mathisinh='" + ma + "' ";
             return objdata.executeQuery(sql, "thisinh");
        }
        public DataSet GetMonThi()
        {
             string sql = "Select * from monthi";
             return objdata.executeQuery(sql, "monthi");
        }
        public DataSet GetDapAn(string macauhoi)
        {
             string sql = "select ndcautraloi,kieudapan,macautraloi from dapan where macauhoi='" + macauhoi + "'";
             return objdata.executeQuery(sql, "dapan");
        }
        public DataSet GetDapAnDung(string macauhoi)
        {
            string sql="select ndcautraloi,kieudapan,macauhoi from dapan where kieudapan='1' and macauhoi='"+macauhoi+"'";
            return objdata.executeQuery(sql, "cauhoi");
        }
        public DataSet GetCauHoi_Mon(string mon)
        {
            string sql="select macauhoi,ndcauhoi,manv,mamon from cauhoi where mamon='" + mon + "'";
            return objdata.executeQuery(sql, "cauhoi");
        }
        public DataSet GetCauHoi()
        {
            string sql = "select * from cauhoi";
            return objdata.executeQuery(sql, "cauhoi");
        }

        //public DataSet RDGetCauHoi()
        //{
        //    string sql="select top 15 * from cauhoi order by newid()";
        //    return objdata.executeQuery(sql,"cauhoi");
        //}
        public DataSet GetCauHoiNV(string manv)
        {
            string sql="select * from cauhoi where manv='" + manv + "'";
            return objdata.executeQuery(sql, "cauhoi");
        }
        public DataSet GetCauHoiNV_Mon(string manv, string mamon)
        {
            string sql="select macauhoi,ndcauhoi,manv,mamon from cauhoi where manv='" + manv + "' and mamon='" + mamon + "'";
            return objdata.executeQuery(sql,"cauhoi");
        }
        
        public DataSet ThemCauHoi(string mach, string noidungch, string manv, string mamon,string hinh)
        {  
               string sql = "insert into cauhoi(macauhoi, ndcauhoi, mamon, manv,ghichu,hinh) values(" + mach + ",'" + noidungch + "','" + mamon + "','" + manv + "','cau hoi','" + hinh + "')";
                return objdata.executeQuery(sql, "cauhoi");
        }
        public DataSet ThemDapan( string ndtrl,string mach, string kieu)
        {
            string sql = "insert into dapan(ndcautraloi,macauhoi,kieudapan)values('" + ndtrl + "','" + mach + "','" + kieu + "')";
            return objdata.executeQuery(sql, "dapan");
        }
        public DataSet SoCH_Mon(string mamon)
        {
            string sql="Select count(mamon) from cauhoi where mamon='" + mamon + "'";
            return objdata.executeQuery(sql, "cauhoi");
        }
        public DataSet ThemMon(string mamon, string tenmon)
        {
            try
            {
                string sql = "insert into monthi values('" + mamon + "','" + tenmon + "')";
                return objdata.executeQuery(sql, "monthi");
            }
            catch (Exception)
            {
                throw new Exception("Không thể thêm");
            }
        }
        public DataSet GetCauHoi_Ghichu(string ghichu)
        {
            string sql="select ndcauhoi from cauhoi";
            return objdata.executeQuery(sql, "cauhoi");
        }
       
        public DataSet KiemTraMon(string mamon)
        {
            string sql="select count(mamon) from cauhoi where mamon='" + mamon + "'";
           return objdata.executeQuery(sql,"cauhoi");
        }
        public DataSet ThemKetQua(string mats, string ketqua, string mamon)
        {
            try
            {
                string sql = "insert into ketqua(ketqua, mamon, mathisinh) values('" + ketqua + "','" + mamon + "','" + mats + "')";
                return objdata.executeQuery(sql, "ketqua");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message+" Không thể thêm");
            }
        }

       
    }
}
