using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class BacSiDAO
    {
        public static List<BacSiDTO> SelectAllBacSi()
        {
            try
            {
                List<BacSiDTO> list = new List<BacSiDTO>();

                DataTable dt = new DataTable();
                dt = DataAccessHelper.ExcuteQuery("sp_SelectAllBacSi");

                foreach (DataRow row in dt.Rows)
                {
                    BacSiDTO BS = new BacSiDTO();

                    BS.sttBS = int.Parse(row["sttBS"].ToString());
                    BS.TenBacSi = row["tenBS"].ToString();
                    BS.UserName = row["username"].ToString();
                    BS.PassWord = row["password"].ToString();
                    BS.DiaChi = row["DiaChi"].ToString();
                    BS.SoDienThoai = float.Parse(row["DienThoai"].ToString());

                    list.Add(BS);
                }
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<BacSiDTO> SelectAllCacSiForTraCuu()
        {
            try
            {
                List<BacSiDTO> List_BacSi = new List<BacSiDTO>();

                DataTable dt = new DataTable();
                dt = DataAccessHelper.ExcuteQuery("sp_SelectAllBacSiForTraCuu");

                foreach (DataRow row in dt.Rows)
                {
                    BacSiDTO BS = new BacSiDTO();

                    BS.sttBS = int.Parse(row["sttBS"].ToString());
                    BS.TenBacSi = row["tenBS"].ToString();                    
                    BS.DiaChi = row["DiaChi"].ToString();
                    BS.SoDienThoai = float.Parse(row["DienThoai"].ToString());

                    List_BacSi.Add(BS);
                }
                return List_BacSi;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static BacSiDTO SelectBacSiByID(string txtUser, string txtPass)
        {
            try
            {
                BacSiDTO BS = new BacSiDTO();

                List<SqlParameter> sqlparams = new List<SqlParameter>();

                sqlparams.Add(new SqlParameter("@username", txtUser));
                sqlparams.Add(new SqlParameter("@password", txtPass));

                DataTable dt = DataAccessHelper.ExcuteQuery("sp_SelectBacSiByUserNameandPassword", sqlparams);

                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];

                    BS.sttBS = int.Parse(dr["sttBS"].ToString());
                    BS.TenBacSi = dr["tenBS"].ToString();
                    BS.UserName = dr["username"].ToString();
                    BS.PassWord = dr["password"].ToString();
                    BS.DiaChi = dr["DiaChi"].ToString();
                    BS.SoDienThoai = float.Parse(dr["DienThoai"].ToString());
                }

                return BS;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool ChangePassWord(BacSiDTO bacsi,string Newpassword)
        {
            try
            {
                List<SqlParameter> sqlparams = new List<SqlParameter>();
                sqlparams.Add(new SqlParameter("@sttBS", bacsi.sttBS));
                sqlparams.Add(new SqlParameter("@password",Newpassword));

                int n = DataAccessHelper.ExcuteNonQuery("sp_UpdatePassWord", sqlparams);
                if (n > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool UpdateBacSi(BacSiDTO bacsi)
        {
            try
            {
                List<SqlParameter> sqlparams = new List<SqlParameter>();
                sqlparams.Add(new SqlParameter("@sttBS", bacsi.sttBS));
                sqlparams.Add(new SqlParameter("@DiaChi", bacsi.DiaChi));
                sqlparams.Add(new SqlParameter("@DienThoai", bacsi.SoDienThoai));

                int n = DataAccessHelper.ExcuteNonQuery("sp_UpdateThongTinBacSi", sqlparams);
                if (n > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool InsertBacSi(BacSiDTO bacsi)
        {
            try
            {
                List<SqlParameter> sqlparams = new List<SqlParameter>();
                sqlparams.Add(new SqlParameter("@tenBS", bacsi.TenBacSi));
                sqlparams.Add(new SqlParameter("@username", bacsi.UserName));
                sqlparams.Add(new SqlParameter("@password", bacsi.PassWord));
                sqlparams.Add(new SqlParameter("@DiaChi", bacsi.DiaChi));
                sqlparams.Add(new SqlParameter("@DienThoai", bacsi.SoDienThoai));

                int n = DataAccessHelper.ExcuteNonQuery("sp_InsertBacSi", sqlparams);
                if (n > 1)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
