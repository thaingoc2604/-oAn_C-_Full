using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using DTO;
using System.Data;
using System.Data.OleDb;
namespace DataAccess_Layer
{
    public class dThuVien : ConnectDB
    {

        public DataSet get_ThuVien_KetHop()
        {
            OleDbCommand cmd = new OleDbCommand("SELECT ThuVien.NoiDung, ThuVien.DapAn, DapAn.Ten, MucDo.TenMD, TinChi.TenTC, ThuVien.MaCH, TinChi.MaTC, MucDo.MaMD, DapAn.MaDA FROM TinChi INNER JOIN (MucDo INNER JOIN (DapAn INNER JOIN ThuVien ON DapAn.MaDA = ThuVien.MaDA) ON MucDo.MaMD = ThuVien.MaMD) ON TinChi.MaTC = ThuVien.MaTC", connect);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "ThuVien");
            return ds;
        }


        public int Delete_Question(int mach)
        {
            connect.Open();
            OleDbCommand cmd = new OleDbCommand("delete from ThuVien where MaCH=@mach", connect);
            cmd.Parameters.Add("@mach", OleDbType.Integer).Value = mach;
            int n = cmd.ExecuteNonQuery();
            return n;
        }
        public DataSet get_ThuVien_TimKiem_NangCao(string chuoibosung)
        {
            OleDbCommand cmd = new OleDbCommand("SELECT  ThuVien.NOIDUNG, ThuVien.DAPAN, MUCDO.TENMD, DAPAN.TEN AS Expr1, TinChi.TENTC AS Expr2,ThuVien.MAMD,ThuVien.MADA,ThuVien.MATC,ThuVien.MaCH FROM(((ThuVien INNER JOIN MUCDO ON thuVien.MAMD = MUCDO.MAMD) INNER JOIN  DAPAN ON thuVien.MADA = DAPAN.MADA) INNER JOIN TinChi ON ThuVien.MATC =TinChi.MATC) where ThuVien.NoiDung like '%"+chuoibosung+"%' OR Thuvien.NoiDung like '%"+chuoibosung+"' OR ThuVien.NoiDung like '"+chuoibosung+"%' ", connect);

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "ThuVien");
            return ds;
        }
    }
}
