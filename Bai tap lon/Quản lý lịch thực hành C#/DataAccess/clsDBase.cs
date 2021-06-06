using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

// Name: clsDBase
// Purpose: Base class
// Creator: Minhns
// Created Date: 07/06/2007
// Modification history:

namespace MDS.DataAccess
{
    public abstract class clsDBase
    {
        // *****************************************************************************************************
        // Declare Private variables
        // *****************************************************************************************************

        protected string strErrorMsg = "";
        protected int intErrorCode = 0;
        protected string strConnectionstring ;
        protected string strSQLStatement = "";

        protected SqlConnection sqlConnection;
        protected SqlCommand sqlCommand;
        protected SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        protected DataSet dsData = new DataSet();

        // *****************************************************************************************************
        // End declare variables

        // Declare public properties
        // *****************************************************************************************************

        // ErrorMsg property
        public string ErrorMsg
        {
            get
            {
                string returnValue;
                returnValue = strErrorMsg;
                return returnValue;
            }
            set
            {
                strErrorMsg = value;
            }
        }

        // ErrorCode property
        public int ErrorCode
        {
            get
            {
                int returnValue;
                returnValue = intErrorCode;
                return returnValue;
            }
            set
            {
                intErrorCode = value;
            }
        }
        
        // ConnectionString property
        public string ConnectionString
        {
            get
            {
                string returnValue;
                returnValue = strConnectionstring;
                return returnValue;
            }
            set
            {
                strConnectionstring = value;
            }
        }

        // SQLStatement property
        public string SQLStatement
        {
            get
            {
                return strSQLStatement;
            }
            set
            {
                strSQLStatement = value;
            }
        }

        // *****************************************************************************************************
        // End declare properties

        // Implement methods here
        // *****************************************************************************************************

        // Initialize method
        // Purpose: init all objects
        public void Initialize()
        {
            strConnectionstring = "Data Source=.;Initial Catalog=CafeManager;Integrated Security=True";
            sqlConnection = new SqlConnection(strConnectionstring);
            sqlCommand = new SqlCommand(); ;
            sqlCommand.Connection = sqlConnection;
        }

        // OpenConnection method
        // Purpose: open connection
        public void OpenConnection()
        {
            if (sqlConnection == null || sqlCommand == null)
                Initialize();
            strErrorMsg = "";

            intErrorCode = 0;
            try
            {
                //sqlConnection.ConnectionString = strConnectionstring;
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }
            }
            //add: HoangTT
            catch (OleDbException sql)
            {
                intErrorCode = sql.ErrorCode;
                strErrorMsg = sql.Message;
            }
            //add: HoangTT
        }

        // CloseConnection method
        // Purpose: close connection
        public void CloseConnection()
        {
            strErrorMsg = "";
            intErrorCode = 0;
            try
            {
                if (sqlConnection.State != ConnectionState.Closed)
                {
                    sqlConnection.Close();
                }
            }
            //add: HoangTT
            catch (OleDbException sql)
            {
                intErrorCode = sql.ErrorCode;
                strErrorMsg = sql.Message;
            }
        }

    }
}
