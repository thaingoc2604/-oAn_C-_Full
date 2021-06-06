using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data;
namespace BussinessLayer
{
    public class LopBus
    {
        public static List<Lop_Info> GetAll_Lop()
        {
            try
            {
                return DataAccess.DataProvider.Instance.Lop_ExecuteDataReader("GetAll_Lop");

            }
            catch
            {
                return null;
            }
        }
        public static DataTable LoadLop()
        {
            try
            {
                return DataAccess.DataProvider.Instance.ExecuteDataTable("GetAll_Lop");
            }
            catch { return null; }
        }
        public static bool ThemLop(Lop_Info lop)
        {
            try
            {
                return DataAccess.DataProvider.Instance.ExecuteNonQuery("ThemLop", lop.MaLop, lop.TenLop, lop.TongSo);
            }
            catch 
            {
                return false;
            }
        }
        public static bool TimLopMa(string maLop)
        {
            try
            {
                return DataAccess.DataProvider.Instance.ExecuteNonQuery("TimLopMa",maLop);
            }
            catch
            {
                return false;
            }
        }
        //public static List<Lop_Info>Get_Lop()
        //{
        //    //try
        //    //{
        //    //    return DataAccess.DataProvider.Instance.ExecuteDataTable("Get_Lop",);
        //    //}
        //    //catch
        //    //{
        //    //    return null;
        //    //}
        //}
    }
}
