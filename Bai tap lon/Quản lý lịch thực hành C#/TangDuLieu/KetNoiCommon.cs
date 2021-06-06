using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace TangDuLieu
{
    public class KetNoiCommon
    {
        public OleDbConnection con = new OleDbConnection();

        #region"Kết Nối Xuống File Access"

        public KetNoiCommon()
        {

            string strKetNoi;
            if (con.State == ConnectionState.Closed)
            {
                strKetNoi = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=QlCaFe.mdb";
                con.ConnectionString = strKetNoi;
                con.Open();
            }

        }
        #endregion

        public DataSet GetDataSet(string sql, string TenBang)
        {
            DataSet ds = new DataSet();
            sql = "select * from " + TenBang;
            OleDbDataAdapter da = new OleDbDataAdapter(sql, con);
            da.Fill(ds, TenBang);
            return ds;

        }

        #region "Cập Nhật(Thêm-Xóa-Sửa)Chung"
        public void CapNhat(DataSet ds, string TenBang)
        {
            try
            {
                string sql;
                OleDbCommand cmd = new OleDbCommand();
                OleDbDataAdapter da = new OleDbDataAdapter();
                OleDbCommandBuilder cbd = new OleDbCommandBuilder();
                sql = "Select * from " + TenBang;
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                da.SelectCommand = cmd;
                cbd.DataAdapter = da;
                da.Update(ds, TenBang);
                ds.AcceptChanges();


            }
            catch
            {
                throw new Exception("Loi Cap Nhat khong thanh cong");
            }
        }


        #endregion
    }
}
