using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class DonThuocDAO
    {
        public static bool InsertDonThuoc_DonThuocBenhNhanThuong(DonThuocDTO donthuoc,int sttBNT)
        {
            try
            {
                List<SqlParameter> sqlparams = new List<SqlParameter>();
                sqlparams.Add(new SqlParameter("@TenThuoc", donthuoc.TenThuoc));
                sqlparams.Add(new SqlParameter("@TienThuoc", donthuoc.TienThuoc));
                sqlparams.Add(new SqlParameter("@MaBenhNhanThuong", sttBNT));

                int n = DataAccessHelper.ExcuteNonQuery("sp_InsertDonThuoc_DonThuocBenhNhanThuong", sqlparams);
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

        public static bool InsertDonThuoc_DonThuocBenhNhanNamGiuong_DaXepCho(DonThuocDTO donthuoc, int sttBN_DXC)
        {
            try
            {
                List<SqlParameter> sqlparams = new List<SqlParameter>();
                sqlparams.Add(new SqlParameter("@TenThuoc", donthuoc.TenThuoc));
                sqlparams.Add(new SqlParameter("@TienThuoc", donthuoc.TienThuoc));
                sqlparams.Add(new SqlParameter("@MaBenhNhanNamGiuong_DaXepCho", sttBN_DXC));

                int n = DataAccessHelper.ExcuteNonQuery("sp_InsertDonThuoc_DonThuocBenhNhanNamGiuong_DaXepCho", sqlparams);
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
    }
}
