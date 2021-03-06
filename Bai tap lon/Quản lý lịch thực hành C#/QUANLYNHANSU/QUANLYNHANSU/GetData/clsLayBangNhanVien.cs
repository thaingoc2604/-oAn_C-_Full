using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace QUANLYNHANSU.GetData
{
    public class clsLayBangNhanVien
    {
        DataService ds = new DataService();

        public DataTable LayNhanVien()
        {
            SqlCommand com = new SqlCommand("select * from nhanvien");
            ds.Load(com);
            return ds;
        }

        public DataTable LayChucVuNhanVien()
        {
            SqlCommand com = new SqlCommand("select * from nhanvien,chucvu where nhanvien.machucvu=chucvu.machucvu and ten=N'Giam Doc'");
            ds.Load(com);
            return ds;
        }

        public DataTable LayNhanVienTheoTenTheoTinhTrang(string tennv,string tinhtrang)
        {
            string query = null;
            if (tinhtrang != "Tất cả")
                query = "select * from nhanvien where tennv like N'%" + tennv + "%'and tinhtranglamviec=N'" + tinhtrang + "'";
            else
                query = "select * from nhanvien where tennv like N'%" + tennv + "%'";

            SqlCommand com = new SqlCommand(query);
            ds.Load(com);
            return ds;
        }
        public void UpdateNhanVienTheoTinhTrang(string manv, string tinhtrang)
        {
            SqlCommand com = new SqlCommand("update nhanvien set tinhtranglamviec=N'" + tinhtrang + "'where manv='" + manv + "'");
            ds.Load(com);
        }
        public DataTable LayHinhTheoNhanVien(string manv)
        {
            SqlCommand com = new SqlCommand("select * from nhanvien where manv='" + manv + "'");
            ds.Load(com);
            return ds;
        }

        public DataTable LayNhanVienDangLamViec()
        {
            SqlCommand com = new SqlCommand("select * from nhanvien where tinhtranglamviec=N'Đang làm việc'");
            ds.Load(com);
            return ds;
        }
        public DataTable LayNhanVienThuViecTheoPhong(string maphong)
        {
            SqlCommand com = new SqlCommand("select * from nhanvien where phongban='" + maphong + "'and tinhtranglamviec=N'Thử việc'");
            ds.Load(com);
            return ds;
        }

        public DataTable LayNhanVienTheoTo(string mato)
        {
            SqlCommand com = new SqlCommand("select * from nhanvien where tophutrach='" + mato + "'");
            ds.Load(com);
            return ds;
        }

        public DataTable LayNhanVienTheoPhongBanDangLam(string maphong)
        {
            SqlCommand com = new SqlCommand("select * from nhanvien where phongban='" + maphong + "'and tinhtranglamviec=N'Đang làm việc'");
            ds.Load(com);
            return ds;
        }
        public DataTable LayNhanVienTheoPhongBan(string maphong)
        {
            SqlCommand com = new SqlCommand("select * from nhanvien where phongban='" + maphong + "'");
            ds.Load(com);
            return ds;
        }

        //public DataTable LayNhanVienTheoTo(string mato)
        //{
        //    SqlCommand com = new SqlCommand("select * from nhanvien where tophutrach='" + mato + "'");
        //    ds.Load(com);
        //    //System.Windows.Forms.MessageBox.Show("tan");
        //    return ds;
        //}

        public void UpdatePhongBanMoi(string maphongmoi, string tomoi, string manhanvien)
        {
            SqlCommand com = new SqlCommand("update nhanvien set phongban='" + maphongmoi + "', tophutrach='" + tomoi + "'where manv='" + manhanvien + "'");
            ds.Load(com);
        }

        public void CapNhat(string manv, string tennv, string bidanh, string cmnd, string ngaycap, string noicap, string ngaysinh, string gioitinh, string diachi, string email, string sdtcty, string sdtrieng, string sdtnha, string tinhtranghonnhan, string phongban, string tophutrach, string machucvu, string ngayvaolam, int thamnien, double heso, string tinhtranglamviec, string hinhthuctuyendung, string tinhoc, string ngoaingu, string hocvi, string soBHXH, string soBHYT, int cannang, double cao, string nhommau, string tinhtrangsuckhoe, string taikhoanNH)
        {
            string query;
            query = "update nhanvien set tennv=N'" + tennv + "', bidanh=N'" + bidanh + "', cmnd='" + cmnd + "',ngaycap='" + ngaycap + "', noicap=N'" + noicap + "',ngaysinh='" + ngaysinh + "',gioitinh=N'" + gioitinh + "', diachi=N'" + diachi + "', email=N'" + email + "', sdtcty='" + sdtcty + "',sdtrieng='" + sdtrieng + "',sdtnha='" + sdtnha + "',tinhtranghonnhan=N'" + tinhtranghonnhan + "',phongban='" + phongban + "',tophutrach='" + tophutrach + "',machucvu='" + machucvu + "',ngayvaolam='" + ngayvaolam + "',thamnien=" + thamnien + ",heso=" + heso + ",tinhtranglamviec=N'" + tinhtranglamviec + "',hinhthuctuyendung=N'" + hinhthuctuyendung + "',tinhoc=N'" + tinhoc + "',ngoaingu=N'" + ngoaingu + "',hocvi=N'" + hocvi + "',soBHXH='" + soBHXH + "',soBHYT='" + soBHYT + "',cannang=" + cannang + ",cao=" + cao + ",nhommau='" + nhommau + "',tinhtrangsuckhoe=N'" + tinhtrangsuckhoe + "',taikhoanNH='" + taikhoanNH + "' where manv='" + manv + "'";
            SqlCommand com = new SqlCommand(query);
            ds.Load(com);
        }

        public void ThemMoi(string manv, string tennv, string bidanh, string cmnd, string ngaycap, string noicap, string ngaysinh, string gioitinh, string diachi, string email, string sdtcty, string sdtrieng, string sdtnha, string tinhtranghonnhan, string phongban, string tophutrach, string machucvu, string ngayvaolam, int thamnien, double heso, string tinhtranglamviec, string hinhthuctuyendung, string tinhoc, string ngoaingu, string hocvi, string soBHXH, string soBHYT, int cannang, double cao, string nhommau, string tinhtrangsuckhoe, string taikhoanNH, string ngaythem)
        {
            string query;
            query = "insert into nhanvien values('" + manv + "', N'" + tennv + "', N'" + bidanh + "', '" + cmnd + "','" + ngaycap + "', N'" + noicap + "','" + ngaysinh + "',N'" + gioitinh + "', N'" + diachi + "', '" + email + "', '" + sdtcty + "','" + sdtrieng + "','" + sdtnha + "',N'" + tinhtranghonnhan + "','" + phongban + "','" + tophutrach + "','" + machucvu + "','" + ngayvaolam + "'," + thamnien + "," + heso + ",N'" + tinhtranglamviec + "',null,N'" + hinhthuctuyendung + "',N'" + tinhoc + "',N'" + ngoaingu + "',N'" + hocvi + "','" + soBHXH + "','" + soBHYT + "'," + cannang + "," + cao + ",'" + nhommau + "',N'" + tinhtrangsuckhoe + "','" + taikhoanNH + "','" + ngaythem + "')";
            SqlCommand com = new SqlCommand(query);
            ds.Load(com);
        }

        public void CapNhatHinh(string manv, byte[] hinhanh)
        {
            SqlCommand com = new SqlCommand("update nhanvien set hinhanh = @hinhanh where manv = @manv");
            com.Parameters.Add("hinhanh", SqlDbType.Image).Value = hinhanh;
            com.Parameters.Add("manv", SqlDbType.VarChar, 10).Value = manv;
            ds.Load(com);
        }
        public void XoaHinh(string manv)
        {
            SqlCommand com = new SqlCommand("update nhanvien set [hinhanh] = null where manv = '" + manv + "'");
            ds.Load(com);
        }
    }
}
