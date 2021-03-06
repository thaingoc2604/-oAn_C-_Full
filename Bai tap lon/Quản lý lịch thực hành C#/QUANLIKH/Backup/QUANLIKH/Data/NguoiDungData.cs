using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QUANLIKH.Data
{
    public class NguoiDungData
    {

        DataProvider ds = new DataProvider();

        public NguoiDungData()
        {

        }

        public DataTable LayNguoiDung(String username)
        {
            String sql = "SELECT * FROM NGUOIDUNG WHERE TENNGUOIDUNG = @ten";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ten", SqlDbType.NVarChar, 20).Value = username;
            ds.Load(cmd);

            return ds;

        }


        internal bool LuuMatKhau(int ma, string mk)
        {
            try
            {
                String sql = "Update NGUOIDUNG set MATKHAU =@mk Where ID = @ma";
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Parameters.Add("ma", SqlDbType.Int).Value = Convert.ToInt16(ma);
                cmd.Parameters.Add("mk", SqlDbType.VarChar).Value = mk;
                ds.Load(cmd);

            }
            catch (SqlException e)
            {
                MessageBox.Show("Lỗi không đổi được vì:" + e.Message);
                return false;
            }
            return true;
        }
    }
}
