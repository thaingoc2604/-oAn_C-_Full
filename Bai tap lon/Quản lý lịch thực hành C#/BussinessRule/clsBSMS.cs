using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace MDS.BussinessRule
{
    public class clsBSMS : clsBBase
    {
        // *****************************************************************************************************
        // Declare Private variables
        // *****************************************************************************************************
        private string strID;
        private string strNumberID;
        private string strText;
        private DateTime date;
        private int iStatus = 0;
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

        // *****************************************************************************************************
        // End declare properties

        MDS.DataAccess.clsSMS objSMS = new MDS.DataAccess.clsSMS();
        // Method: Initialize

        // Purpose: Init all need objects
        public void Initialize()
        {
            objSMS.ConnectionString = strConnectionstring;
            objSMS.Initialize();
        }

        //Method:
        //Purpose:
        public DataTable SELECT_ALL()
        {
            DataTable returnValue = new DataTable();
            try
            {
                returnValue = objSMS.SELECT_ALL();
                strErrorMsg = objSMS.ErrorMsg;
                intErrorCode = objSMS.ErrorCode;
            }
            catch (Exception ex)
            {
                strErrorMsg = ex.Message.ToString();
            }
            return returnValue;
        }
        //Method:
        //Purpose:ham chong de sap xep du lieu
        public DataTable SELECT_ALL(string expressionName, bool sortAscending)
        {
            DataTable returnValue = new DataTable();
            try
            {
                returnValue = objSMS.SELECT_ALL(expressionName, sortAscending);
                strErrorMsg = objSMS.ErrorMsg;
                intErrorCode = objSMS.ErrorCode;
            }
            catch (Exception ex)
            {
                strErrorMsg = ex.Message.ToString();
            }
            return returnValue;
        }
        //
        public DataTable SELECT_SMS_BY_STATUS(int status)
        {
            DataTable returnValue = new DataTable();
            try
            {
                objSMS.ID = this.strID;
                returnValue = objSMS.SELECT_SMS_BY_STATUS(status);
                strErrorMsg = objSMS.ErrorMsg;
                intErrorCode = objSMS.ErrorCode;

            }
            catch (Exception ex)
            {
                strErrorMsg = ex.Message.ToString();
            }
            return returnValue;
        }

        //

        //
        public int DELETE_NHANVIEN()
        {
            int affectedRows = 0;
            try
            {
                objSMS.ID = strID;
                affectedRows = objSMS.DELETE_SMS();

                strErrorMsg = objSMS.ErrorMsg;
                intErrorCode = objSMS.ErrorCode;
            }
            catch (Exception Ex)
            {
                strErrorMsg = Ex.Message.ToString();
            }
            return affectedRows;
        }
        //
        public int INSERT_NHANVIEN()
        {
            int affectedRows = 0;
            try
            {
                objSMS.ID = strID;
                objSMS.NumberID = NumberID;
                objSMS.Text = strText;
                objSMS.Date = Date;
                objSMS.Status = iStatus;
                objSMS.Note = strNote;
                affectedRows = objSMS.INSERT_SMS();
                strErrorMsg = objSMS.ErrorMsg;
                intErrorCode = objSMS.ErrorCode;
            }
            catch (Exception Ex)
            {
                strErrorMsg = Ex.Message.ToString();
            }
            return affectedRows;
        }
    }
}
