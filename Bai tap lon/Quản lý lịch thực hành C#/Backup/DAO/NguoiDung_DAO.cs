using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DTO;
using System.Windows.Forms;

namespace DAO
{
    public class NguoiDung_DAO:DataProvider
    {
        public int KTDangNhap(string Username, string Pass)
        {

            SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@Username", Username), new SqlParameter("@Pass", GetMD5(Pass)) };
            int flag=(int)ExecuteScalar("sp_DangNhap", sqlParams) ;
            return flag;
        }

        public int GetPermit(string Username)
        {
            SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@Username", Username)};
            object O = ExecuteScalar("sp_GetPermit", sqlParams);


            return (Int16)O;

        }

        public DataTable GetDSNguoiDung()
        {
            DataTable kq = new DataTable();

            kq = LoadData("sp_Get_dsNguoiDung");

            return kq;
        }

        public NguoiDung_DTO GetInfo(string Username, string Pass)
        {

            NguoiDung_DTO kq= new NguoiDung_DTO();
            DataTable table = new DataTable();
            SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@username", Username), new SqlParameter("@pass", GetMD5(Pass)) };
            table = LoadData("sp_Getuser", sqlParams);

            kq.Fullname = table.Rows[0]["fullname"].ToString();
            kq.IsAdmin = int.Parse(table.Rows[0]["IsAdmin"].ToString());
            kq.Username = table.Rows[0]["username"].ToString();
            kq.Pass = table.Rows[0]["pass"].ToString();
            return kq;

        }

        public int CapNhatThongTin(NguoiDung_DTO _ndDTO, string OldPass)
        {
            SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@username", _ndDTO.Username),
                new SqlParameter("@oldpass", OldPass),new SqlParameter("@NewPass", _ndDTO.Pass),
                new SqlParameter("@fullname", _ndDTO.Fullname) };

            return ExecuteNonQuery("sp_CapNhat_ThongtinCaNhan", sqlParams);
        }

        public int ThemNguoiDung(NguoiDung_DTO _ndDTO)
        {
            SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@username", _ndDTO.Username),
                new SqlParameter("@IsAdmin", _ndDTO.IsAdmin),new SqlParameter("@Pass", _ndDTO.Pass),
                new SqlParameter("@fullname", _ndDTO.Fullname) };

            return ExecuteNonQuery("sp_ThemNguoiDung", sqlParams);
        }

        public int KTTenDangNhap(string Username)
        {
            SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@Username", Username) };
            
            int flag = (int)ExecuteScalar("sp_KTTenDangNhap", sqlParams);
            return flag;
        }
    }
}
