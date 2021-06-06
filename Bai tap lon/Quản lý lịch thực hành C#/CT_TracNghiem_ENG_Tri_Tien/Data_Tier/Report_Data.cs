using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Data_Tier
{
    public class Report_Data:All_In_One
    {
        public DataSet Show_ThongTin_Report(String id)
        {
            SqlCommand cmd = new SqlCommand("select TB_User.ID,socmnd,tb_user.HO,tb_user.ten,diachi,ngaysinh,hinhanh,made,diem,ngaythi from TB_User,TB_KetQua where TB_User.ID=TB_KetQua.ID and TB_User.ID=@id", cnn);
            cmd.Parameters.Add("@id", SqlDbType.Char).Value = id;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds,"tb_user");
            return ds;
        }
        public DataSet Report_DeThi(String made)
        {
            SqlCommand cmd = new SqlCommand("select TB_dapan.MaCauHoi,noidungcauhoi,noidungdapan,made from TB_CauHoi,TB_DapAn,TB_DeThi where TB_DapAn.MaCauHoi=TB_CauHoi.MaCauHoi and tb_cauhoi.macauhoi=tb_dethi.macauhoi and made=@made", cnn);
            cmd.Parameters.Add("@made", SqlDbType.Char).Value = made;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "tb_cauhoi_dethi_dapan");
            return ds;
        }
    }
}
