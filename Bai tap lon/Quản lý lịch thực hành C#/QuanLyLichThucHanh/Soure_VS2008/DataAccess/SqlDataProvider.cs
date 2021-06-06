using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using DTO;
namespace DataAccess
{
    public class SqlDataProvider:DataProvider
    {
        private string _ConnectionString;
        public SqlDataProvider(string connectionStringName)
        {

            _ConnectionString = ConfigurationManager.ConnectionStrings[connectionStringName].ConnectionString;

        }
        protected SqlConnection GetSqlConnection()
        {
            try
            {
                return new SqlConnection(_ConnectionString);

            }
            catch
            {
                throw new Exception("SqlConnection");
            }
        }
        public override bool ExecuteNonQuery(string StoneProduce, params object[] value)
        {
            using (SqlConnection cnn = GetSqlConnection())
            {
                try
                {
                    SqlCommand cmd = cnn.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cnn.Open();
                    cmd.CommandText = StoneProduce;
                    SqlCommandBuilder.DeriveParameters(cmd);
                    int n = cmd.Parameters.Count;

                    for (int i = 1; i < n; i++)
                    {
                        cmd.Parameters[i].Value = value[i - 1];
                        string str = cmd.Parameters[i].ToString();
                    }
                    int rs = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return rs > 0;
                }
                catch
                {
                    return false;
                }
            }
        }
        public override int NonQuery(string StoneProduce, params object[] value)
        {
            using (SqlConnection cnn = GetSqlConnection())
            {
               
                    SqlCommand cmd = cnn.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cnn.Open();
                    cmd.CommandText = StoneProduce;
                    SqlCommandBuilder.DeriveParameters(cmd);
                    int n = cmd.Parameters.Count;

                    for (int i = 1; i < n; i++)
                    {
                        cmd.Parameters[i].Value = value[i - 1];
                        string str = cmd.Parameters[i].ToString();
                    }
                    int rs = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return rs ;
                
             
            }
        }
       // public List<Lich_Info>LLich_ExecuteDataReader(string StoneProduce, params object[] ParamaterValues)
        //{
        //    using (SqlConnection cnn = GetSqlConnection())
        //    {
        //        try
        //        {

        //            SqlCommand cmd = cnn.CreateCommand();
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            cmd.CommandText = StoneProduce;
        //            cnn.Open();
        //            SqlCommandBuilder.DeriveParameters(cmd);
        //            if (cmd.Parameters.Count > 0)
        //            {
        //                for (int i = 1; i < cmd.Parameters.Count; i++)
        //                {
        //                    cmd.Parameters[i].Value = ParamaterValues[i - 1];
        //                }
        //            }
        //            using (SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
        //            {
        //                List<Lich_Info> list = new List<Lich_Info>();
        //                while (reader.Read())
        //                {
        //                    Lich_Info lich = new Lich_Info();
        //                    lich.MaGV = reader[0].ToString();
        //                    lich.MaMH = reader[1].ToString();
        //                    lich.Lop = reader[2].ToString();
        //                    lich.Phong = reader[3].ToString();
        //                    lich.ThoiGian = reader[4].ToString();
        //                    lich.Ngay = Convert.ToDateTime(reader[5]);
        //                    lich.Tuan = Convert.ToInt32(reader[6]);
        //                    list.Add(lich);
        //                }
        //                return list;
        //            }
        //        }
        //        catch
        //        {
        //            return null;
        //        }
        //    }
        //}
        public override List<Lop_Info> Lop_ExecuteDataReader(string StoneProduce, params object[] ParamaterValues)
        {
            using (SqlConnection cnn = GetSqlConnection())
            {
                try
                {
                    SqlCommand cmd = cnn.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = StoneProduce;
                    cnn.Open();
                    SqlCommandBuilder.DeriveParameters(cmd);
                    if (cmd.Parameters.Count > 0)
                    {
                        for (int i = 1; i < cmd.Parameters.Count; i++)
                        {
                            cmd.Parameters[i].Value = ParamaterValues[i - 1];
                        }
                    }
                    using (SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        List<Lop_Info> list = new List<Lop_Info>();
                        while (reader.Read())
                        {
                            Lop_Info lop = new Lop_Info();
                            lop.MaLop = reader[0].ToString();
                            lop.TenLop = reader[1].ToString();
                            lop.TongSo = Convert.ToInt32(reader[2].ToString());
                            list.Add(lop);
                        }
                        return list;
                    }
                }
                catch
                {
                    return null;
                }
            }
        }
        public override List<GiaoVien_Info> GiaoVien_ExecuteDataReader(string StoneProduce, params object[] ParamaterValues)
        {
            using (SqlConnection cnn = GetSqlConnection())
            {
                try
                {
                    SqlCommand cmd = cnn.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = StoneProduce;
                    cnn.Open();
                    SqlCommandBuilder.DeriveParameters(cmd);
                    if (cmd.Parameters.Count > 0)
                    {
                        for (int i = 1; i < cmd.Parameters.Count; i++)
                        {
                            cmd.Parameters[i].Value = ParamaterValues[i - 1];
                        }
                    }
                    using (SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        List<GiaoVien_Info> list = new List<GiaoVien_Info>();
                        while (reader.Read())
                        {
                            GiaoVien_Info gv = new GiaoVien_Info();
                            gv.MaGV = reader[0].ToString();
                            gv.HoGV = reader[1].ToString();
                            gv.TenGV= reader[2].ToString();
                            gv.GioiTinh= reader[3].ToString();
                            gv.NgaySinh = Convert.ToDateTime(reader[4]);
                            gv.ChuyenNganh = reader[5].ToString();
                            gv.DiaChi = reader[6].ToString();
                            gv.SoDT = reader[7].ToString();
                            
                            list.Add(gv);
                        }

                        return list;
                    }
                }
                catch
                {
                    return null;
                }

            }

        }
        public override DataTable ExecuteDataTable(string StoneProduce, params object[] ParamaterValues)
        {
            try
            {
                using (SqlConnection cnn = GetSqlConnection())
                {
                    SqlCommand cmd = cnn.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = StoneProduce;
                    cnn.Open();
                    SqlCommandBuilder.DeriveParameters(cmd);
                    for (int i = 1; i < cmd.Parameters.Count; i++)
                    {
                        cmd.Parameters[i].Value = ParamaterValues[i - 1];
                    }
                    DataTable table = new System.Data.DataTable();
                    table.Load(cmd.ExecuteReader());
                    return table;
                }
            }
            catch (System.Exception)
            {
                return null;
            }

        }
        //public abstract DataTable LoadLop(string StoneProduce, params object[] ParamaterValues)
        //{
        //    try
        //    {
        //        using (SqlConnection cnn = GetSqlConnection())
        //        {
        //            SqlCommand cmd = cnn.CreateCommand();
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            cmd.CommandText = StoneProduce;
        //            cnn.Open();
        //            SqlCommandBuilder.DeriveParameters(cmd);
        //            for (int i = 1; i < cmd.Parameters.Count; i++)
        //            {
        //                cmd.Parameters[i].Value = ParamaterValues[i - 1];
        //            }
        //            DataTable table = new DataTable();
                    
        //            return table;
        //        }

        //    }
        //}
        //public DataTable LayLop()
        //{
        //    SqlConnection cnn = GetSqlConnection();
        //    string select = "Select TenLop From Lop";
        //    SqlDataAdapter da = new SqlDataAdapter(select, cnn);
        //    DataTable ds = new DataTable();
        //    da.Fill(ds);
        //    cnn.Close();
        //    return ds;
        //}
        public override List<ThoiGian_Info> ThoiGian_ExecuteDataReader(string StoneProduce, params object[] ParamaterValues)
        {
            using (SqlConnection cnn = GetSqlConnection())
            {
                try
                {
                    SqlCommand cmd = cnn.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = StoneProduce;
                    cnn.Open();
                    SqlCommandBuilder.DeriveParameters(cmd);
                    if (cmd.Parameters.Count > 0)
                    {
                        for (int i = 1; i < cmd.Parameters.Count; i++)
                        {
                            cmd.Parameters[i].Value = ParamaterValues[i - 1];
                        }
                    }
                    using (SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {

                        List<ThoiGian_Info> list = new List<ThoiGian_Info>();
                        while (reader.Read())
                        {
                            ThoiGian_Info tg = new ThoiGian_Info();
                            tg.MaTG = reader[0].ToString();
                            tg.Tiet = reader[1].ToString();
                            list.Add(tg);
                        }
                        return list;



                    }
                }
                catch
                {
                    return null;
                }
               
            }
        }
        public override List<MonHoc_Info> MonHoc_ExecuteDataReader(string StoneProduce, params object[] ParamaterValues)
        {
            using (SqlConnection cnn = GetSqlConnection())
            {
                try
                {
                    SqlCommand cmd = cnn.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = StoneProduce;
                    cnn.Open();
                    SqlCommandBuilder.DeriveParameters(cmd);
                    if (cmd.Parameters.Count > 0)
                    {
                        for (int i = 1; i < cmd.Parameters.Count; i++)
                        {
                            cmd.Parameters[i].Value = ParamaterValues[i - 1];
                        }
                    }
                    using (SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        List<MonHoc_Info> list = new List<MonHoc_Info>();
                        while (reader.Read())
                        {
                            MonHoc_Info mh=new MonHoc_Info();
                            mh.MaMH=reader[0].ToString();
                            mh.TenMH=reader[1].ToString();
                            //mh.ChuyenNganh=reader[2].ToString();
                            list.Add(mh);
                        }
                        return list;
                    }

                }
                catch
                {
                    return null;
                }
            }
        }
        public override List<LichThu> Lich_ExecuteDataReader(string StoneProduce, params object[] ParamaterValues)
        {
            using (SqlConnection cnn = GetSqlConnection())
            {
                try
                {
                    SqlCommand cmd = cnn.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = StoneProduce;
                    cnn.Open();
                    SqlCommandBuilder.DeriveParameters(cmd);
                    if (cmd.Parameters.Count > 0)
                    {
                        for (int i = 1; i < cmd.Parameters.Count; i++)
                        {
                            cmd.Parameters[i].Value = ParamaterValues[i - 1];
                        }
                    }
                    using (SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        List<LichThu> list = new List<LichThu>();
                        while (reader.Read())
                        {
                            LichThu lich = new LichThu();

                            lich.TenMH = reader[0].ToString();
                            lich.ThoiGian = reader[1].ToString();
                            lich.Phong = reader[2].ToString();
                            list.Add(lich);
                        }
                        return list;
                    }

                }
                catch
                {
                    return null;
                }
            }
        }
        public override DateTime Ngay_ExecuteDataReader(string StoneProduce, params object[] ParamaterValues)
        {
            using (SqlConnection cnn = GetSqlConnection())
            {
                try
                {
                    SqlCommand cmd = cnn.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = StoneProduce;
                    cnn.Open();
                    SqlCommandBuilder.DeriveParameters(cmd);
                    if (cmd.Parameters.Count > 0)
                    {
                        for (int i = 1; i < cmd.Parameters.Count; i++)
                        {
                            cmd.Parameters[i].Value = ParamaterValues[i - 1];
                        }
                    }
                    using (SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        DateTime ngay = new DateTime();
                        ngay =Convert.ToDateTime(reader[0]);
                        //List<LichThu> list = new List<LichThu>();
                        //while (reader.Read())
                        //{
                        //    LichThu lich = new LichThu();

                        //    lich.TenMH = reader[0].ToString();
                        //    lich.ThoiGian = reader[1].ToString();
                        //    lich.Phong = reader[2].ToString();
                        //    list.Add(lich);
                        //}
                        //return list;
                        return ngay;
                    }

                }
                catch
                {
                    return DateTime.Now;
                }
            }
        }
        public override List<Phong_Info> Phong_ExecuteDataReader(string StoneProduce, params object[] ParamaterValues)
        {
            using (SqlConnection cnn = GetSqlConnection())
            {
                try
                {
                    SqlCommand cmd = cnn.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = StoneProduce;
                    cnn.Open();
                    SqlCommandBuilder.DeriveParameters(cmd);
                    if (cmd.Parameters.Count > 0)
                    {
                        for (int i = 1; i < cmd.Parameters.Count; i++)
                        {
                            cmd.Parameters[i].Value = ParamaterValues[i - 1];
                        }
                    }
                    using (SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        List<Phong_Info> list = new List<Phong_Info>();
                        while (reader.Read())
                        {
                            Phong_Info phong = new Phong_Info();
                            phong.MaPHG = reader[0].ToString();
                            phong.TenPhong = reader[1].ToString();
                            phong.ThietBi = reader[2].ToString();
                            list.Add(phong);
                        }
                        return list;
                    }
                }
                catch { return null; }
            }

        }
        //public override List<Lich_Info> Lich_ExecuteDataReder(string StoneProduce, params object[] ParamatersValues)
        //{
        //    using (SqlConnection cnn = GetSqlConnection())
        //    {
        //        try
        //        {
        //            SqlCommand cmd = cnn.CreateCommand();
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            cmd.CommandText = StoneProduce;
        //            cnn.Open();
        //            SqlCommandBuilder.DeriveParameters(cmd);
        //            if (cmd.Parameters.Count > 0)
        //            {
        //                for (int i = 1; i < cmd.Parameters.Count; i++)
        //                {
        //                    cmd.Parameters[i].Value = ParamatersValues[i - 1];
        //                }
        //            }
        //            using (SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
        //            {
        //                List<Lich_Info> list = new List<Lich_Info>();
        //                while (reader.Read())
        //                {
        //                    Lich_Info lich = new Lich_Info();
        //                    lich.MaGV = reader[0].ToString();
        //                    //lich.MaMH = reader[1].ToString();
        //                    //lich.Lop = reader[2].ToString();
        //                    //lich.Phong = reader[3].ToString();
        //                    //lich.ThoiGian = reader[4].ToString();
        //                    //lich.Ngay = Convert.ToDateTime(reader[5]);
        //                    //lich.Tuan = Convert.ToInt32(reader[6]);
        //                    //lich.Thu = Convert.ToInt32(reader[7]);
        //                    list.Add(lich);
        //                }
        //                return list;
        //            }
        //        }
        //        catch { return null; }
        //    }
        //}
    }
}
