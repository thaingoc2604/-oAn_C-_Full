using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace QLYNV1
{
    class clsDuLieu
    {
        OleDbConnection Cnn = new OleDbConnection();
        OleDbDataAdapter da;
        OleDbCommandBuilder CmdBD;
        public void KetNoi()
        {
            try
            {
                if (Cnn.State == ConnectionState.Closed || Cnn.State == ConnectionState.Broken)
                {
                    Cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\..\..\Data\quanlynhanvien.mdb";
                    Cnn.Open();
                }

            }
            catch
            {
                MessageBox.Show("Kết nối không thành công ");
            }

        }
        public DataSet GetDataSet(string TenBang)
        {
            DataSet ds = new DataSet();
            string strSQL = "Select * From " + TenBang;
            da = new OleDbDataAdapter(strSQL, Cnn);
            CmdBD = new OleDbCommandBuilder(da);
            da.Fill(ds, TenBang);
            return ds;
        }
        public DataSet GetDataSet(ref OleDbDataAdapter da, ref OleDbCommandBuilder CmdBD, string TenBang)
        {
            DataSet ds = new DataSet();
            string strSQL = " Select * From " + TenBang;
            da = new OleDbDataAdapter(strSQL, Cnn);
            CmdBD = new OleDbCommandBuilder(da);
            da.Fill(ds, TenBang);
            return ds;

        }
        public DataSet GetDataSetDK(string TenBang, string TenField, string DieuKien)
        {
            DataSet ds = new DataSet();
            string strSQL = " Select * From " + TenBang;
            if (TenField != "" && DieuKien != "") ;
            {
                strSQL += " And " + TenField + "='" + DieuKien + "'";

            }
            OleDbDataAdapter da = new OleDbDataAdapter(strSQL, Cnn);
            da.Fill(ds, TenBang);
            return ds;
        }
        public DataRow KTMaSo(DataTable tbl, string TenField, string GiaTri)
        {
            DataColumn[] CotChiMuc = new DataColumn[1];
            CotChiMuc[0] = tbl.Columns[TenField];
            tbl.PrimaryKey = CotChiMuc;
            DataRow Dong = tbl.Rows.Find(GiaTri);
            return Dong;
        }
        public bool KTMaSoSua(string TenBang, string TenField, string GiaTri, string GiaTriCu)
        {
            int so;
            string strSQL = " Select Count(*) From " + TenBang + " where " + TenField + " = '" + GiaTri + "'";
            OleDbCommand Cmd = new OleDbCommand(strSQL, Cnn);
            so = (int)Cmd.ExecuteScalar();
            if (GiaTri.ToUpper() != GiaTriCu.ToUpper())
            {
                if (so > 0)
                    return true;
                else
                    return false;
            }
            else
            {
                return false;
            }
        }
        public void Xoa(string TenBang, string TenField, string DieuKien)
        {
            string strSQL = " Delete* From " + TenBang;
            if (TenField != "" && DieuKien != "")
            {
                strSQL += " Where " + TenField + "='" + DieuKien + "'";
            }
            OleDbCommand Cmd = new OleDbCommand(strSQL, Cnn);
            Cmd.ExecuteNonQuery();
        }
        public void CapNhat(DataTable tbl, string TenBang)
        {
            try
            {
                string strSQL = " Select * From " + TenBang;
                OleDbDataAdapter da = new OleDbDataAdapter(strSQL, Cnn);
                OleDbCommandBuilder cmdBD = new OleDbCommandBuilder(da);
                da.Update(tbl);

            }
            catch
            {
                MessageBox.Show("Lỗi cập nhật");
            }
        }
        public DataSet LayKetQua(string TenBang, string TenField, String DieuKien)
        {
            DataSet ds = new DataSet();
            string strSQL = " Select * From " + TenBang;
            if (TenField != "" && DieuKien != "") ;
            {
                strSQL += " And " + TenField + "='" + DieuKien + "'";
            }
            OleDbDataAdapter da = new OleDbDataAdapter(strSQL, Cnn);
            OleDbCommandBuilder cmdBD = new OleDbCommandBuilder(da);
            da.Fill(ds, TenBang);
            return ds;
        }
        public DataSet LayTTNVTheoDK(string DieuKien)
        {
            DataSet ds = new DataSet();
            string strSQL = "Select *From NHANVIEN " + DieuKien;
            OleDbDataAdapter da = new OleDbDataAdapter(strSQL, Cnn);
            da.Fill(ds, "TIMNHANVIEN");
            return ds;
        }


    }
}
