using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data;
namespace BussinessLayer
{
    public class GiaoVienBus
    {
        public static List<GiaoVien_Info>GetAll_GiaoVien()
        {
            try
            {
                return DataAccess.DataProvider.Instance.GiaoVien_ExecuteDataReader("GetAll_GiaoVien");

            }
            catch
            {
                return null;
            }
        }
        public static bool Them_GiaoVien(GiaoVien_Info gv)
        {
            try
            {
                return DataAccess.DataProvider.Instance.ExecuteNonQuery("ThemGiaoVien", gv.MaGV, gv.HoGV,gv.TenGV, gv.GioiTinh, gv.NgaySinh, gv.ChuyenNganh, gv.DiaChi, gv.SoDT);

            }
            catch
            {
                return false;
            }
        }
        public static bool Xoa_GiaoVien(string maGV)
        {
            try
            {
                return DataAccess.DataProvider.Instance.ExecuteNonQuery("Xoa_GiaoVienTheoMa", maGV);
            }
            catch
            {
                return false;
            }
        }
        public static bool Sua_GiaoVien(GiaoVien_Info gv)
        {
            try
            {
                return DataAccess.DataProvider.Instance.ExecuteNonQuery("Sua_NhanVien", gv.MaGV, gv.HoGV,gv.TenGV, gv.GioiTinh, gv.NgaySinh, gv.ChuyenNganh, gv.DiaChi, gv.SoDT);

            }
            catch
            {
                return false;
            }

        }
        public static DataTable LoadGiaoVien()
        {
            try
            {
                return DataAccess.DataProvider.Instance.ExecuteDataTable("GetAll_GiaoVien");
            }
            catch { return null; }
        }
        public static DataTable TimTheoMa(string MaGV)
        {
            try
            {
                return DataAccess.DataProvider.Instance.ExecuteDataTable("TimGVTheoMa",MaGV);
            }
            catch { return null; }
        }
        public static DataTable TimTheoTen(string TenGV)
        {
            try
            {
                return DataAccess.DataProvider.Instance.ExecuteDataTable("TimGVTheoTen", TenGV);
            }
            catch { return null; }
        }
        public static bool ThemGV(GiaoVien_Info giaovien)
        {
            try
            {
                return DataAccess.DataProvider.Instance.ExecuteNonQuery("ThemGiaoVien", giaovien.MaGV, giaovien.HoGV, giaovien.TenGV, giaovien.GioiTinh, giaovien.NgaySinh, giaovien.ChuyenNganh, giaovien.DiaChi,giaovien.SoDT);
            }
            catch
            {
                return false;
            }
        }
    }
}
