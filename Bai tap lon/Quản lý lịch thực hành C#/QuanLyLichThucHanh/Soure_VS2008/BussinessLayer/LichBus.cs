using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data;
namespace BussinessLayer
{
    public class LichBus
    {
        public static bool ThemLich(Lich_Info lich)
        {
            try 
            {
                return DataAccess.DataProvider.Instance.ExecuteNonQuery("ThemLich", lich.MaGV, lich.MaMH, lich.Lop, lich.Phong, lich.ThoiGian, lich.Ngay, lich.Tuan, lich.Thu);
                   //.ExecuteNonQuery("ThemLich", lich.MaGV, lich.MaMH, lich.Lop, lich.Phong, lich.ThoiGian, lich.Ngay, lich.Tuan, lich.Thu);
            }
            catch { return false;  }
        }
        public static bool TimTuanThuTietLop(int tuan, int  thu, string tiet, string lop)
        {
            try
            {
                return DataAccess.DataProvider.Instance.ExecuteNonQuery("TimTuanThuTietLop",tuan, thu, tiet, lop);
            }
            catch { return false; }
        }
        //public static List<Lich_Info>GetAll_Lich()
        //{
        //    try
        //    {
        //        return DataAccess.DataProvider.Instance.LLich_ExecuteDataReader("GetAll_Lich");
        //    }
        //    catch
        //    {
        //        return null;
        //    }
        //}
        //public static List<Lich_Info> GetAll_Lich()
        //{
        //    try
        //    {
        //        return DataAccess.DataProvider.Instance.Lich_ExecuteDataReader("GetAll_Lich");

        //    }
        //    catch
        //    {
        //        return null;
        //    }
        //}
        //public static List<Lich_Info> LayTuan_Lich()
        //{
        //    try
        //    {
        //        return DataAccess.DataProvider.Instance.Lich_ExecuteDataReader("LayTuan_Lich");

        //    }
        //    catch
        //    {
        //        return null;
        //    }
        //}
        //public static List<Lich_Info> LayTenLop_Lich()
        //{
        //    try
        //    {
        //        return DataAccess.DataProvider.Instance.Lich_ExecuteDataReader("LayTenLop_Lich");

        //    }
        //    catch
        //    {
        //        return null;
        //    }
        //}
        //public static List<Lich_Info> LayTuan()
        //{
        //    try
        //    {
        //        return DataAccess.DataProvider.Instance.Lich_ExecuteDataReader("LayTuan"); 
        //    }
        //    catch
        //    {
        //        return null;
        //    }
        //}
        public static LichHocTuan LoadLich(string MaLop, int Tuan)
        {
            try
            {
                LichHocTuan tuan = new LichHocTuan();
                tuan.T2 = DataAccess.DataProvider.Instance.Lich_ExecuteDataReader("LichThu", MaLop, Tuan, 2);
                tuan.T3 = DataAccess.DataProvider.Instance.Lich_ExecuteDataReader("LichThu", MaLop, Tuan, 3);
                tuan.T4 = DataAccess.DataProvider.Instance.Lich_ExecuteDataReader("LichThu", MaLop, Tuan, 4);
                tuan.T5 = DataAccess.DataProvider.Instance.Lich_ExecuteDataReader("LichThu", MaLop, Tuan, 5);
                tuan.T6 = DataAccess.DataProvider.Instance.Lich_ExecuteDataReader("LichThu", MaLop, Tuan, 6);
                tuan.T7 = DataAccess.DataProvider.Instance.Lich_ExecuteDataReader("LichThu", MaLop, Tuan, 7);
                tuan.CN = DataAccess.DataProvider.Instance.Lich_ExecuteDataReader("LichThu", MaLop, Tuan, 8);
                tuan.Ngay = DataAccess.DataProvider.Instance.Ngay_ExecuteDataReader("LayNgay", Tuan);
                return tuan;
            }
            catch { return null; }
        }
        public static DataTable KiemTraLopTrung(string MaLop,int Tuan,int Thu,string ThoiGian)
        {
            try
            {
                return DataAccess.DataProvider.Instance.ExecuteDataTable("LopTTT",MaLop,Tuan,Thu,ThoiGian);
            }
            catch { return null; }
        }
    }
}
