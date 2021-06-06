using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Configuration;
using System.Data.SqlClient;

namespace AnTCafe
{
    class clsCommonUI
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter adapter;
        DataTable tblDataTable = new DataTable();

        public clsCommonUI()
        {
            string con_str = Program.ConnectionString;
            //conn = new SqlConnection(con_str);
            conn.ConnectionString = con_str;
        }

         public int isDuplicate(string strValue, string strFieldName,string strTableName) {     
                string strSQL = "SELECT " + strFieldName + " FROM " + strTableName + " WHERE " + strFieldName + " = '" + strValue + "'";
                adapter = new SqlDataAdapter(strSQL,conn);
                tblDataTable.Clear();
                adapter.Fill(tblDataTable);
                 if (tblDataTable.Rows.Count > 0) {
                     return tblDataTable.Rows.Count;

                 }
                 return 0;
        }
        public bool isNumberic(string strValue) {
            int outvalue;
            if (Int32.TryParse(strValue, out outvalue))
                return true;
            else
                return false;
        }

        public DataTable getDataFromSQL(string strSQL) {
            adapter = new SqlDataAdapter(strSQL, conn);
            tblDataTable.Clear();
            try {
                adapter.Fill(tblDataTable);
            }catch(SqlException ex) {
                
            } finally{
            
            }
            return tblDataTable;
        }


    }
}
