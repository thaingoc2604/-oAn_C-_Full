using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using System.Data;
using System.Data.SqlClient;

namespace Data_Tier
{
    public class User_Data : All_In_One
    {
        public bool Log_In(String id, String matkhau)
        {
            KetNoi();
            SqlCommand cmd = new SqlCommand("select count(*) from tb_user where id=@id and matkhau=@matkhau", cnn);
            cmd.Parameters.Add("@id",SqlDbType.Char).Value=id;
            cmd.Parameters.Add("@matkhau", SqlDbType.Char).Value = matkhau;
            if ((int)cmd.ExecuteScalar() > 0)
                return true;
            else
                return false;
        }
        public String Check_Quyen(String id,String matkhau)
        {
            String quyen="";
            SqlCommand cmd = new SqlCommand("select quyen from tb_user where id=@id and matkhau=@matkhau", cnn);
            cmd.Parameters.Add("@id", SqlDbType.Char).Value = id;
            cmd.Parameters.Add("@matkhau", SqlDbType.Char).Value = matkhau;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("tb_user");
            da.Fill(dt);
            DataRow dr = dt.Rows[0];
            quyen = dr["quyen"].ToString();
            return quyen;
        }
        public String Forgot_Password(String id, String socmnd, String chuoibimat)
        {
            try
            {
                String matkhau = "";
                SqlCommand cmd = new SqlCommand("select matkhau from tb_user where id=@id and socmnd=@socmnd and chuoibimat=@chuoibimat", cnn);
                cmd.Parameters.Add("@id", SqlDbType.Char).Value = id;
                cmd.Parameters.Add("@socmnd", SqlDbType.Char).Value = socmnd;
                cmd.Parameters.Add("@chuoibimat", SqlDbType.Char).Value = chuoibimat;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("tb_user");
                da.Fill(dt);
                DataRow dr = dt.Rows[0];
                matkhau = dr["matkhau"].ToString();
                return matkhau;
            }
            catch (Exception)
            {
                return "";
            }
        }
        public int DK_User(String id, String mk, String socmnd, String chuoibimat, String ho, String ten, String diachi, DateTime ngaysinh, String quyen)
        {

            KetNoi();
            SqlCommand cmd = new SqlCommand("Insert into tb_user(id,matkhau,socmnd,chuoibimat,ho,ten,diachi,ngaysinh,quyen) values(@id,@mk,@socmnd,@chuoibimat,@ho,@ten,@diachi,@ngaysinh,@quyen)", cnn);
            cmd.Parameters.Add("@id", SqlDbType.Char).Value = id;
            cmd.Parameters.Add("@mk", SqlDbType.Char).Value = mk;
            cmd.Parameters.Add("@socmnd", SqlDbType.Char).Value = socmnd;
            cmd.Parameters.Add("@chuoibimat", SqlDbType.Char).Value = chuoibimat;
            cmd.Parameters.Add("@ho", SqlDbType.NVarChar).Value = ho;
            cmd.Parameters.Add("@ten", SqlDbType.NVarChar).Value = ten;
            cmd.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = diachi;
            cmd.Parameters.Add("@ngaysinh", SqlDbType.DateTime).Value = ngaysinh;
            cmd.Parameters.Add("@quyen", SqlDbType.Char).Value = quyen;
            int n = cmd.ExecuteNonQuery();
            NgatKetNoi();
            return n;


        }
        public bool Res_User(String id, String mk, String socmnd, String chuoibimat, String ho, String ten, String diachi, DateTime ngaysinh, String quyen, String duongdan)
        {
            byte[] hinhanh = null;
            // Read the file into a byte array
            using (FileStream fs = new FileStream(duongdan, FileMode.Open, FileAccess.Read))
            {
                hinhanh = new Byte[fs.Length];
                fs.Read(hinhanh, 0, (int)fs.Length);
            }
            using (cnn)
            {
                try
                {
                    KetNoi();
                    SqlCommand cmd = new SqlCommand("Insert into tb_user values(@id,@mk,@socmnd,@chuoibimat,@ho,@ten,@diachi,@ngaysinh,@quyen,@duongdan,@hinhanh)", cnn);
                    cmd.Parameters.Add("@id", SqlDbType.Char).Value = id;
                    cmd.Parameters.Add("@mk", SqlDbType.Char).Value = mk;
                    cmd.Parameters.Add("@socmnd", SqlDbType.Char).Value = socmnd;
                    cmd.Parameters.Add("@chuoibimat", SqlDbType.Char).Value = chuoibimat;
                    cmd.Parameters.Add("@ho", SqlDbType.NVarChar).Value = ho;
                    cmd.Parameters.Add("@ten", SqlDbType.NVarChar).Value = ten;
                    cmd.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = diachi;
                    cmd.Parameters.Add("@ngaysinh", SqlDbType.DateTime).Value = ngaysinh;
                    cmd.Parameters.Add("@quyen", SqlDbType.Char).Value = quyen;
                    cmd.Parameters.Add("@duongdan", SqlDbType.Char).Value = duongdan;
                    cmd.Parameters.Add("@hinhanh", SqlDbType.Image).Value = hinhanh;
                    cmd.ExecuteNonQuery();
                    NgatKetNoi();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        public byte[] Ret_Pic(String id, String mk)
        {
            KetNoi();
            byte[] hinhanh = null;
            SqlCommand cmd = new SqlCommand("select hinhanh from tb_User where id=@id"/* and matkhau=@matkhau*/, cnn);
            cmd.Parameters.Add("@id", SqlDbType.Char).Value = id;
            //cmd.Parameters.Add("@matkhau", SqlDbType.Char).Value = mk;
            using (SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.SequentialAccess))
            {
                reader.Read();
                long bytesize = reader.GetBytes(0, 0, null, 0, 0);
                hinhanh = new byte[bytesize];
                long bytesread = 0;
                int curpos = 0;
                int chunkSize = 1;
                while (bytesread < bytesize)
                {
                    bytesread += reader.GetBytes(0, curpos, hinhanh, curpos, chunkSize);
                    curpos += chunkSize;
                }
            }
            NgatKetNoi() ;
            return hinhanh;
        }
        public int Change_Pass(String id, String pass)
        {
            KetNoi();
            SqlCommand cmd = new SqlCommand("update tb_user set matkhau=@matkhau where id=@id", cnn);
            cmd.Parameters.Add("@matkhau", SqlDbType.Char).Value = pass;
            cmd.Parameters.Add("@id", SqlDbType.Char).Value = id;
            int n = cmd.ExecuteNonQuery();
            NgatKetNoi();
            return n;
        }
        public DataSet Get_ThongTin_User(String id)
        {
            SqlCommand cmd = new SqlCommand("select * from tb_user where id=@id", cnn);
            cmd.Parameters.Add("@id", SqlDbType.Char).Value = id;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet("tb_user");
            da.Fill(ds, "tb_user");
            return ds;
        }
        public DataSet Get_All_User()
        {
            SqlCommand cmd = new SqlCommand("select * from tb_user where quyen='Student'", cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet("tb_user");
            da.Fill(ds, "tb_user");
            return ds;
        }
        public int Edit_User(String id,String mk, String socmnd, String chuoibimat, String ho, String ten, String diachi, DateTime ngaysinh, String quyen)
        {
           
                KetNoi();
                SqlCommand cmd = new SqlCommand("Update tb_user set matkhau=@mk,socmnd=@socmnd,chuoibimat=@chuoibimat,ho=@ho,ten=@ten,diachi=@diachi,ngaysinh=@ngaysinh,quyen=@quyen where id=@id", cnn);
                cmd.Parameters.Add("@mk", SqlDbType.Char).Value = mk;
                cmd.Parameters.Add("@socmnd", SqlDbType.Char).Value = socmnd;
                cmd.Parameters.Add("@chuoibimat", SqlDbType.Char).Value = chuoibimat;
                cmd.Parameters.Add("@ho", SqlDbType.NVarChar).Value = ho;
                cmd.Parameters.Add("@ten", SqlDbType.NVarChar).Value = ten;
                cmd.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = diachi;
                cmd.Parameters.Add("@ngaysinh", SqlDbType.DateTime).Value = ngaysinh;
                cmd.Parameters.Add("@quyen", SqlDbType.Char).Value = quyen;
                cmd.Parameters.Add("@id", SqlDbType.Char).Value = id;
                int n=cmd.ExecuteNonQuery();
                NgatKetNoi();
                return n;
           
        }
        public int Del_User(String id)
        {
            
                KetNoi();
                SqlCommand cmd = new SqlCommand("delete from tb_user where id=@id", cnn);
                cmd.Parameters.Add("@id", SqlDbType.Char).Value = id;
                int n=cmd.ExecuteNonQuery();
                NgatKetNoi();
                return n;
          
        }
    }
}
