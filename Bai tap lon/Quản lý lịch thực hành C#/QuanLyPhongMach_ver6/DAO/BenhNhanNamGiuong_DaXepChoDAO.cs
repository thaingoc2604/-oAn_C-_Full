using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class BenhNhanNamGiuong_DaXepChoDAO
    {
        public static bool InsertBenhNhanNamGiuong_DaXepCho(BenhNhanNamGiuong_DaXepChoDTO benhnhan_daxepcho)
        {
            try
            {
                List<SqlParameter> sqlparams = new List<SqlParameter>();

                sqlparams.Add(new SqlParameter("@sttBN", benhnhan_daxepcho.STTBN));
                sqlparams.Add(new SqlParameter("@sttGB", benhnhan_daxepcho.sttGiuong));
                sqlparams.Add(new SqlParameter("@ngayxep", benhnhan_daxepcho.NgayXep));

                int n = DataAccessHelper.ExcuteNonQuery("sp_InsertBenhNhanNamGiuong_DaXepCho", sqlparams);
                if (n == 1)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable SelectAllGiuongBenh_CoBenhNhan()
        {
            try
            {
                DataTable dt = DataAccessHelper.ExcuteQuery("sp_SelectAllGiuongBenh_CoBenhNhan");
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool DeleteBenhNhanNamGiuong_DaXepCho(BenhNhanNamGiuong_DaXepChoDTO benhnhan_DaXepCho)
        {
            try
            {
                List<SqlParameter> sqlparams = new List<SqlParameter>();

                sqlparams.Add(new SqlParameter("@sttBN", benhnhan_DaXepCho.STTBN));
                sqlparams.Add(new SqlParameter("@sttGB", benhnhan_DaXepCho.sttGiuong));

                int n = DataAccessHelper.ExcuteNonQuery("sp_DeleteBenhNhanNamGiuong_DaXepCho", sqlparams);
                if (n == 1)
                    return true;
                else
                    return false;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public static List<BenhNhanNamGiuong_DaXepChoDTO> SelectAllBenhNhanNamGiuong_DaXepCho()
        {
            try
            {
                List<BenhNhanNamGiuong_DaXepChoDTO> List = new List<BenhNhanNamGiuong_DaXepChoDTO>();

                DataTable dt = DataAccessHelper.ExcuteQuery("sp_selectAllBenhNhanNamGiuong_DaXepCho");
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        BenhNhanNamGiuong_DaXepChoDTO benhnhan = new BenhNhanNamGiuong_DaXepChoDTO();

                        benhnhan.sttBNNG_DXC = int.Parse(row["sttBNNG_DXC"].ToString());
                        benhnhan.STTBN = int.Parse(row["Mã Bệnh Nhân"].ToString());
                        benhnhan.Hoten = row["Họ Tên Bệnh Nhân"].ToString();
                        benhnhan.CMND = int.Parse(row["Số Chứng Minh Nhân Dân"].ToString());
                        benhnhan.DiaChi = row["Địa Chỉ"].ToString();
                        benhnhan.BacSiPhuTrach = int.Parse(row["sttBS"].ToString());

                        List.Add(benhnhan);
                    }
                }
                return List;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }        
    }
}
