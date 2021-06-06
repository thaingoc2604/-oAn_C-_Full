using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DTO;
using System.Data;
using System.Data.OleDb;
namespace DataAccess_Layer
{
    public class dPhanQuyen:ConnectDB
    {

        public DataSet get_Table_PhanQuyen(string madn, string tendn)
        {
            OleDbCommand cmd = new OleDbCommand("select * from PhanQuyen where TenDN=@tendn AND Password=@pass", connect);

            cmd.Parameters.Add("@tendn", OleDbType.BSTR).Value = madn;
            cmd.Parameters.Add("@pass", OleDbType.BSTR).Value = tendn;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "PhanQuyen");
            return ds;
        }

        public int TaoTaiKhoan(PhanQuyen pq)
        {
            connect.Open();
            OleDbCommand cmd = new OleDbCommand("Insert into PhanQuyen values(@tendn,@pass)", connect);
            cmd.Parameters.Add("@tendn", OleDbType.BSTR).Value = pq.TenDangNhap;
            cmd.Parameters.Add("@pass", OleDbType.BSTR).Value = pq.MaDangNhap;

            int result = cmd.ExecuteNonQuery();
            connect.Close();
            return result;
        }

        public DataSet KiemTraTaiKhoan(string tentk)
        {
            OleDbCommand cmd = new OleDbCommand("select * from PhanQuyen where TenDN=@tendn" , connect);
            cmd.Parameters.Add("@tendn", OleDbType.BSTR).Value = tentk;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds,"PhanQuyen");
            return ds;

        }
    }
}
