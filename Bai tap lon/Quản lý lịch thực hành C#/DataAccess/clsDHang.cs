using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;


// Name: clsDDaiLy
// Purpose: to manage access table DaiLy
// Creator: Hoangtt
// Created Date: 07/07/2007
// Modification history:

namespace MDS.DataAccess
{
    public class clsDHang : clsDBase
    {
        // *****************************************************************************************************
        // Declare Private variables
        // *****************************************************************************************************
        private string strMaHang;
        private string strTenHang;
        private string strGhiChu;
        // *****************************************************************************************************
        // End declare variables
        // Declare public properties
        // *****************************************************************************************************

        public string MaHang
        {
            get { return strMaHang; }
            set { strMaHang = value; }
        }
        public string TenHang
        {
            get { return strTenHang; }
            set { strTenHang = value; }
        }
        public string GhiChu
        {
            get { return strGhiChu; }
            set { strGhiChu = value; }
        }
        // *****************************************************************************************************
        // End declare properties
        // Implement methods here
        // *****************************************************************************************************

        public DataTable SELECT_ALL()
        {
            DataTable returnValue = new DataTable();
            OpenConnection();
            sqlCommand.CommandText = "SELECT * FROM [HANG] ORDER BY MaHang";
            sqlCommand.CommandType = CommandType.Text;
            try
            {
                sqlDataAdapter.SelectCommand = sqlCommand;
                sqlDataAdapter.Fill(dsData, "tblResult");
                returnValue = dsData.Tables["tblResult"];
                dsData.Tables.Remove("tblResult");
            }
            catch (OleDbException ex)
            {
                strErrorMsg = ex.Message.ToString();
                intErrorCode = ex.ErrorCode;
            }
            finally
            {
                sqlCommand.Parameters.Clear();
                CloseConnection();
            }
            
            return returnValue;
        }
        //Method: get data from table Daily and sorting
        public DataTable SELECT_ALL(string expressionName, bool sortAscending)
        {
            DataTable returnValue = new DataTable();
            OpenConnection();
            sqlCommand.CommandText = "SELECT * FROM [HANG] ORDER BY [" + expressionName + "] " + (sortAscending ? "ASC" : "DESC");
            sqlCommand.CommandType = CommandType.Text;
            try
            {
                sqlDataAdapter.SelectCommand = sqlCommand;
                sqlDataAdapter.Fill(dsData, "tblResult");
                returnValue = dsData.Tables["tblResult"];
                dsData.Tables.Remove("tblResult");
            }
            catch (OleDbException ex)
            {
                strErrorMsg = ex.Message.ToString();
                intErrorCode = ex.ErrorCode;
            }
            finally
            {
                sqlCommand.Parameters.Clear();
            }
            CloseConnection();
            return returnValue;
        }

        public DataTable SELECT_HANG_BY_ID()
        {
            DataTable returnValue = new DataTable();
            OpenConnection();
            sqlCommand.CommandText = "SELECT * FROM [HANG] WHERE MaHang=@MaHang";
            sqlCommand.CommandType = CommandType.Text;
            try
            {
                sqlCommand.Parameters.Add("@MaHang", SqlDbType.VarChar, 50).Value = MaHang;
                sqlDataAdapter.SelectCommand = sqlCommand;
                sqlDataAdapter.Fill(dsData, "tblResult");
                returnValue = dsData.Tables["tblResult"];
                dsData.Tables.Remove("tblResult");
            }
            catch (OleDbException ex)
            {
                strErrorMsg = ex.Message.ToString();
                intErrorCode = ex.ErrorCode;
            }
            finally
            {
                sqlCommand.Parameters.Clear();
                CloseConnection();
            }
            return returnValue;
        }
        //
        public int INSERT_HANG()
        {
            int affectedRows = 0;
            OpenConnection();
            sqlCommand.CommandText = "INSERT INTO [HANG](MaHang,TenHang,GhiChu) VALUES(@MaHang,@TenHang,@GhiChu)";
            sqlCommand.CommandType = CommandType.Text;
            try
            {
                sqlCommand.Parameters.Add("@MaHang", SqlDbType.VarChar, 50).Value = MaHang;
                sqlCommand.Parameters.Add("@TenHang", SqlDbType.VarChar, 256).Value = TenHang;
                sqlCommand.Parameters.Add("@GhiChu", SqlDbType.VarChar, 256).Value = GhiChu;

                affectedRows = sqlCommand.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                strErrorMsg = ex.Message.ToString();
                intErrorCode = ex.ErrorCode;
            }
            finally
            {
                sqlCommand.Parameters.Clear();
                CloseConnection();
            }
            
            return affectedRows;
        }

        ////
        public int UPDATE_HANG()
        {
            int affectedRows = 0;
            OpenConnection();
            sqlCommand.CommandText = "UPDATE [HANG] SET TenHang=@TenHang,GhiChu=@GhiChu WHERE MaHang=@MaHang";
            sqlCommand.CommandType = CommandType.Text;
            try
            {
                sqlCommand.Parameters.Add("@TenHang", SqlDbType.VarChar, 255).Value = TenHang;
                sqlCommand.Parameters.Add("@GhiChu", SqlDbType.VarChar, 255).Value = GhiChu;
                sqlCommand.Parameters.Add("@MaHang", SqlDbType.VarChar, 50).Value = MaHang;
                affectedRows = sqlCommand.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                strErrorMsg = ex.Message.ToString();
                intErrorCode = ex.ErrorCode;
            }
            finally
            {
                sqlCommand.Parameters.Clear();
            }
            CloseConnection();
            return affectedRows;
        }

        ////
        public int DELETE_HANG()
        {
            int affectedRows = 0;
            OpenConnection();
            sqlCommand.CommandText = "DELETE FROM [HANG] WHERE MaHang=@MaHang";
            sqlCommand.CommandType = CommandType.Text;
            try
            {
                sqlCommand.Parameters.Add("@MaHang", SqlDbType.VarChar, 50).Value = MaHang;
                affectedRows = sqlCommand.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                strErrorMsg = ex.Message.ToString();
                intErrorCode = ex.ErrorCode;
            }
            finally
            {
                sqlCommand.Parameters.Clear();
            }
            CloseConnection();
            return affectedRows;
        }
    }
}
