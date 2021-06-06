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
    public class clsSMS : clsDBase
    {
        // *****************************************************************************************************
        // Declare Private variables
        // *****************************************************************************************************
        private string strID;
        private string strNumberID;
        private string strText;
        private DateTime date;
        private int iStatus=0;
        private string strNote;
        // *****************************************************************************************************
        // End declare variables
        // Declare public properties
        // *****************************************************************************************************

        public string ID
        {
            get { return strID; }
            set { strID = value; }
        }
        public string NumberID
        {
            get { return strNumberID; }
            set { strNumberID = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }

        }
        public string Text
        {
            get { return strText; }
            set { strText = value; }
        }
        public int Status
        {
            get { return iStatus; }
            set { iStatus = value; }
        }


        public string Note
        {
            get { return strNote; }
            set { strNote = value; }
        }
        // *****************************************************************************************************
        // End declare properties
        // Implement methods here
        // *****************************************************************************************************

        public DataTable SELECT_ALL()
        {
            DataTable returnValue = new DataTable();
            OpenConnection();
            sqlCommand.CommandText = "SELECT * FROM [SMS] ORDER BY SMS_DateTime";
            sqlCommand.CommandType = CommandType.Text;
            try
            {
                sqlDataAdapter.SelectCommand = sqlCommand;
                sqlDataAdapter.Fill(dsData, "tblSMS");
                returnValue = dsData.Tables["tblSMS"];
                dsData.Tables.Remove("tblSMS");
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
            sqlCommand.CommandText = "SELECT * FROM [SMS] ORDER BY [" + expressionName + "] " + (sortAscending ? "ASC" : "DESC");
            sqlCommand.CommandType = CommandType.Text;
            try
            {
                sqlDataAdapter.SelectCommand = sqlCommand;
                sqlDataAdapter.Fill(dsData, "tblSMS");
                returnValue = dsData.Tables["tblSMS"];
                dsData.Tables.Remove("tblSMS");
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

        public DataTable SELECT_SMS_BY_STATUS(int status)
        {
            DataTable returnValue = new DataTable();
            OpenConnection();
            sqlCommand.CommandText = "SELECT * FROM [SMS] WHERE SMS_Status=@SMS_Status";
            sqlCommand.CommandType = CommandType.Text;
            try
            {
                sqlCommand.Parameters.Add("@SMS_Status", SqlDbType.Int,4).Value = status;
                sqlDataAdapter.SelectCommand = sqlCommand;
                sqlDataAdapter.Fill(dsData, "tblSMS");
                returnValue = dsData.Tables["tblSMS"];
                dsData.Tables.Remove("tblSMS");
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
        public int INSERT_SMS()
        {
            int affectedRows = 0;
            OpenConnection();
            sqlCommand.CommandText = "INSERT INTO [SMS](SMS_ID,SMS_NumberID,SMS_Text,SMS_DateTime,SMS_Status,SMS_Note) VALUES(@SMS_ID,@SMS_NumberID,@SMS_Text,@SMS_DateTime,@SMS_Status,@SMS_Note)";
            sqlCommand.CommandType = CommandType.Text;
            try
            {
                sqlCommand.Parameters.Add("@SMS_ID", SqlDbType.VarChar, 256).Value = ID;
                sqlCommand.Parameters.Add("@SMS_NumberID", SqlDbType.VarChar, 256).Value = NumberID;
                sqlCommand.Parameters.Add("@SMS_Text", SqlDbType.VarChar, 256).Value = Text;
                sqlCommand.Parameters.Add("@SMS_DateTime", SqlDbType.DateTime, 8).Value = Date;
                sqlCommand.Parameters.Add("@SMS_Status", SqlDbType.VarChar, 256).Value = Status;
                sqlCommand.Parameters.Add("@SMS_Note", SqlDbType.VarChar, 256).Value = Note;

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
      
        public int DELETE_SMS()
        {
            int affectedRows = 0;
            OpenConnection();
            sqlCommand.CommandText = "DELETE FROM [SMS] WHERE SMS_ID=@SMS_ID";
            sqlCommand.CommandType = CommandType.Text;
            try
            {
                sqlCommand.Parameters.Add("@SMS_ID", SqlDbType.VarChar, 256).Value = ID;
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
