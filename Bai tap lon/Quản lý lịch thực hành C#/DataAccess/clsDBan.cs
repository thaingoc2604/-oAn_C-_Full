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
    public class clsDBan : clsDBase
    {
        // *****************************************************************************************************
        // Declare Private variables
        // *****************************************************************************************************
        private string strMaBan;
        private string strTen;
        private string strKhuVuc;
        // *****************************************************************************************************
        // End declare variables
        // Declare public properties
        // *****************************************************************************************************

        public string MaBan
        {
            get { return strMaBan; }
            set { strMaBan = value; }
        }
        public string Ten
        {
            get { return strTen; }
            set { strTen = value; }
        }
        public string KhuVuc
        {
            get { return strKhuVuc; }
            set { strKhuVuc = value; }
        }
        // *****************************************************************************************************
        // End declare properties
        // Implement methods here
        // *****************************************************************************************************

        public DataTable SELECT_ALL()
        {
            DataTable returnValue = new DataTable();
            OpenConnection();
            sqlCommand.CommandText = "SELECT * FROM [BAN] ORDER BY Ten";
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
            sqlCommand.CommandText = "SELECT * FROM [BAN] ORDER BY [" + expressionName + "] " + (sortAscending ? "ASC" : "DESC");
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

        public DataTable SELECT_BAN_BY_ID()
        {
            DataTable returnValue = new DataTable();
            OpenConnection();
            sqlCommand.CommandText = "SELECT * FROM [BAN] WHERE MaBan=@MaBan";
            sqlCommand.CommandType = CommandType.Text;
            try
            {
                sqlCommand.Parameters.Add("@MaBan", SqlDbType.VarChar, 50).Value = MaBan;
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
        public int INSERT_BAN()
        {
            int affectedRows = 0;
            OpenConnection();
            sqlCommand.CommandText = "INSERT INTO [BAN](MaBan,Ten,KhuVuc) VALUES(@MaBan,@Ten,@KhuVuc)";
            sqlCommand.CommandType = CommandType.Text;
            try
            {
                sqlCommand.Parameters.Add("@MaBan", SqlDbType.VarChar, 50).Value = MaBan;
                sqlCommand.Parameters.Add("@Ten", SqlDbType.VarChar, 256).Value = Ten;
                sqlCommand.Parameters.Add("@KhuVuc", SqlDbType.VarChar, 256).Value = KhuVuc;

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
        public int UPDATE_BAN()
        {
            int affectedRows = 0;
            OpenConnection();
            sqlCommand.CommandText = "UPDATE [BAN] SET Ten=@Ten,KhuVuc=@KhuVuc WHERE MaBan=@MaBan";
            sqlCommand.CommandType = CommandType.Text;
            try
            {
                sqlCommand.Parameters.Add("@Ten", SqlDbType.VarChar, 255).Value = Ten;
                sqlCommand.Parameters.Add("@KhuVuc", SqlDbType.VarChar, 255).Value = KhuVuc;
                sqlCommand.Parameters.Add("@MaBan", SqlDbType.VarChar, 50).Value = MaBan;
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
        public int DELETE_BAN()
        {
            int affectedRows = 0;
            OpenConnection();
            sqlCommand.CommandText = "DELETE FROM [BAN] WHERE MaBan=@MaBan";
            sqlCommand.CommandType = CommandType.Text;
            try
            {
                sqlCommand.Parameters.Add("@MaBan", SqlDbType.VarChar, 50).Value = MaBan;
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
