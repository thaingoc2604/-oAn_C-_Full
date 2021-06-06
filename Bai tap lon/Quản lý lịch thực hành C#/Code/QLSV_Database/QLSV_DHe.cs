using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace QLSV_Database
{
   public class QLSV_DHe
    {
       c_ThaoTacChung cthaotachung = new c_ThaoTacChung();

       public DataTable LoadDL_He()
       {
           DataTable dt = new DataTable();
           dt = cthaotachung.LayDanhSach("Select * from He");
           return dt;
       }

       SqlParameter _Mahe = new SqlParameter();
       SqlParameter _Tenhe = new SqlParameter();
       SqlParameter _Ghichu = new SqlParameter();
       public void ThemHe(String MaHe, string TenHe, String GhiChu)
       {
           _Mahe.SqlValue = MaHe;
           _Mahe.ParameterName = "@MaHe";

           _Tenhe.SqlValue = TenHe;
           _Tenhe.ParameterName = "@TenHe";

           _Ghichu.SqlValue = GhiChu;
           _Ghichu.ParameterName = "@GhiChu";

           cthaotachung.ThaoTacDuLieu("qlsv_ThemHe", CommandType.StoredProcedure, _Mahe, _Tenhe, _Ghichu);
       }

       public void CapNhatHe(String MaHe, string TenHe, String GhiChu)
       {
           _Mahe.SqlValue = MaHe;
           _Mahe.ParameterName = "@MaHe";

           _Tenhe.SqlValue = TenHe;
           _Tenhe.ParameterName = "@TenHe";

           _Ghichu.SqlValue = GhiChu;
           _Ghichu.ParameterName = "@GhiChu";

           cthaotachung.ThaoTacDuLieu("qlsv_CapNhatHe", CommandType.StoredProcedure, _Mahe, _Tenhe, _Ghichu);
       }

       public void XoaHe(string MaHe)
       {
           _Mahe.SqlValue = MaHe;
           _Mahe.ParameterName = "@MaHe";
           cthaotachung.ThaoTacDuLieu("qlsv_XoaHe", CommandType.StoredProcedure, _Mahe);
           
       }
       public string TaoMaHe()
       {
           string ma = "";
           ma = cthaotachung.SinhMaTuDong("HE", "Select * from He");
           return ma;
       }
    }
}
