using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Collections;
using DTO;
namespace DataAccess_Layer
{
    public class dCauHoi : ConnectDB
    {
        CauHoi ch = new CauHoi();
        public dCauHoi()
        {
        }
        public int ThemCauHoi(string noidung, string dapan, string madapan, string mamd, string matc)
        {
            connect.Open();
            OleDbCommand cmd = new OleDbCommand("Insert into ThuVien(noidung,dapan,mada,mamd,matc) values('" + noidung + "','" + dapan + "','" + madapan + "','" + mamd + "','" + matc + "')", connect);
            int n = cmd.ExecuteNonQuery();
            connect.Close();
            return n;
        }
        public int CapNhatCauHoi(string noidung, string dapan, string madapan, string mamd, string matc, string mach)
        {
            int result = 0;
            connect.Open();
            OleDbCommand cmd = new OleDbCommand("Update Thuvien set NoiDung='" + noidung + "',DapAn='" + dapan + "',MaDA=" + madapan + ",MaMD=" + mamd + ",MaTC=" + matc + " WHERE MaCH=" + mach, connect);
            result = cmd.ExecuteNonQuery();
            connect.Close();
            return result;
        }
        public int Dem_ReCord()
        {
            int result = 0;
            connect.Open();
            OleDbCommand cmd = new OleDbCommand("select Count(MaCH) from ThuVien",connect);
            result = int.Parse(cmd.ExecuteScalar().ToString());
            connect.Close();
            return result;
        }

        public DataSet get_Table_CauHoi_NgauNhien(int songaunhien)
        {
            OleDbCommand cmd = new OleDbCommand("SELECT ThuVien.NOIDUNG,ThuVien.DAPAN,MUCDO.TENMD,DAPAN.TEN,TinChi.TENTC FROM ThuVien,MUCDO,DAPAN,TinChi WHERE (ThuVien.MAMD=MUCDO.MAMD AND ThuVien.MADA=DAPAN.MADA AND ThuVien.MATC=TinChi.MATC) AND MaCH=@macauhoi", connect);
            cmd.Parameters.Add("@macauhoi", OleDbType.Integer).Value = songaunhien;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "ThuVien");
            return ds;
        }
       
    }
}
