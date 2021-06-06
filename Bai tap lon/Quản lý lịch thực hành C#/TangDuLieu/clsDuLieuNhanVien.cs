using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace TangDuLieu
{
    public class clsDuLieuNhanVien:KetNoiCommon
    {
        public DataTable GetThongtinNV()
        {
            string sql = @"selcet * from NhanVien ";
            return GetDataSet(sql, "NhanVien").Tables[0];
        }

        public DataSet GetDataSetNV(string TenBang)
        {
            string sql = @"selcet * from " + TenBang;
            return GetDataSet(sql, "NhanVien");
        }
        public void XoaData()
        {
            /*
                         DataRow[] objRow = objDataTable.Select("STT=" + Convert.ToInt32(txt_stt.Text));
             objRow[0].Delete();
             //Delete dữ liệu nguồn
             objAdapter.Update(objDataTable);
             */
            string sql = "select * from NhanVien ";
            OleDbDataAdapter da = new OleDbDataAdapter(sql, con);
            DataTable tbl = new DataTable();
            da.Fill(tbl);
            OleDbCommandBuilder cmdbd = new OleDbCommandBuilder(da);
            DataRow[] drw = tbl.Select();
            drw[0].Delete();
            da.Update(tbl);



        }
        public void CapNhatNV(DataSet ds, string TenBang)
        {
            CapNhat(ds, TenBang);
        }
    }
}
