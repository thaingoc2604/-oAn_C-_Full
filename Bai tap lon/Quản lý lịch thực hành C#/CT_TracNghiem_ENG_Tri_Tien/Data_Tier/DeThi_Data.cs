using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace Data_Tier
{
    public class DeThi_Data:All_In_One
    {
        public int TaoDe(String made,String macauhoi,String id)
        {
            KetNoi();
            SqlCommand cmd = new SqlCommand("insert into tb_DeThi values(@made,@macauhoi,@id)", cnn);
            cmd.Parameters.Add("@made", SqlDbType.Char).Value = made;
            cmd.Parameters.Add("@macauhoi", SqlDbType.Char).Value = macauhoi;
            cmd.Parameters.Add("@id", SqlDbType.Char).Value = id;
            int n=cmd.ExecuteNonQuery();
            NgatKetNoi();
            return n;
        }
        public int XoaDe(String made)
        {
            KetNoi();
            SqlCommand cmd = new SqlCommand("delete from tb_DeThi where made=@made", cnn);
            cmd.Parameters.Add("@made", SqlDbType.Char).Value = made;
            int n = cmd.ExecuteNonQuery();
            NgatKetNoi();
            return n;
        }
        public DataSet HienThi_MaDe(String id)
        {
            SqlCommand cmd = new SqlCommand("select distinct made from tb_dethi where id=@id", cnn);
            cmd.Parameters.Add("@id", SqlDbType.Char).Value = id;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet("tb_dethi");
            da.Fill(ds,"tb_dethi");
            return ds;
        }
        public DataSet HienThi_MaDe_All()
        {
            SqlCommand cmd = new SqlCommand("select distinct made from tb_dethi", cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet("tb_dethi");
            da.Fill(ds, "tb_dethi");
            return ds;
        }
        public bool HienThi_MaDe_By_MaCauHoi(String macauhoi)
        {
            SqlCommand cmd = new SqlCommand("select distinct made from tb_dethi where macauhoi=@macauhoi", cnn);
            cmd.Parameters.Add("@macauhoi", SqlDbType.Char).Value = macauhoi;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet("tb_dethi");
            da.Fill(ds, "tb_dethi");
            DataRow dr = ds.Tables["tb_dethi"].Rows[0];
            if (dr[0].ToString() == "")
                return true;
            else
                return false;
        }
        public DataSet HienThi_List_ComBo(String made)
        {
            SqlCommand cmd = new SqlCommand("select tb_dethi.macauhoi,noidungcauhoi from tb_dethi,tb_cauhoi where tb_Cauhoi.macauhoi=tb_Dethi.macauhoi and MaDe=@made", cnn);
            cmd.Parameters.Add("@made", SqlDbType.Char).Value = made;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet("tb_DeThi_CauHoi");
            da.Fill(ds, "tb_DeThi_CauHoi");
            return ds;
        }
        public int ThoiGian_Thi(String made)
        {
            KetNoi();
            SqlCommand cmd = new SqlCommand("select count(*) from tb_dethi where made=@made", cnn);
            cmd.Parameters.Add("@made", SqlDbType.Char).Value = made;
            int n =(int)cmd.ExecuteScalar();
            NgatKetNoi();
            return n;
        }
        public DataSet Load_Cau_Hoi(String made)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM TB_DeThi WHERE MaDe=@made ORDER BY NEWID()", cnn);
            cmd.Parameters.Add("@made", SqlDbType.Char).Value = made;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet("tb_dethi");
            da.Fill(ds, "tb_dethi");
            return ds;
        }
       
    }
}
