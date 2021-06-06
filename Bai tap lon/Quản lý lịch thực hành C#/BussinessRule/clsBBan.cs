using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MDS.DataAccess;

namespace MDS.BussinessRule
{
    public class clsBBan: clsBBase
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

        clsDBan objDBan = new clsDBan();
        // Method: Initialize
        // Purpose: Init all need objects
        public void Initialize()
        {
            objDBan.ConnectionString = strConnectionstring;
            objDBan.Initialize();

        }

        //Method:
        //Purpose:
        public DataTable SELECT_ALL()
        {
            DataTable returnValue = new DataTable();
            try
            {
                returnValue = objDBan.SELECT_ALL();
                strErrorMsg = objDBan.ErrorMsg;
                intErrorCode = objDBan.ErrorCode;
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
                returnValue = objDBan.SELECT_ALL(expressionName, sortAscending);
                strErrorMsg = objDBan.ErrorMsg;
                intErrorCode = objDBan.ErrorCode;
            }
            catch (Exception ex)
            {
                strErrorMsg = ex.Message.ToString();
            }
            return returnValue;
        }
        //
        public DataTable SELECT_BAN_BY_ID()
        {
            DataTable returnValue = new DataTable();
            try
            {
                objDBan.MaBan = MaBan;
                returnValue = objDBan.SELECT_BAN_BY_ID();
                strErrorMsg = objDBan.ErrorMsg;
                intErrorCode = objDBan.ErrorCode;

            }
            catch (Exception ex)
            {
                strErrorMsg = ex.Message.ToString();
            }
            return returnValue;

        }
        public int DELETE_BAN()
        {
            int affectedRows = 0;
            try
            {
                objDBan.MaBan = MaBan;
                affectedRows = objDBan.DELETE_BAN();
                strErrorMsg = objDBan.ErrorMsg;
                intErrorCode = objDBan.ErrorCode;
            }
            catch (Exception Ex)
            {
                strErrorMsg = Ex.Message.ToString();
            }
            return affectedRows;
        }
        ////
        public int INSERT_BAN()
        {
            int affectedRows = 0;
            try
            {
                objDBan.MaBan = MaBan;
                objDBan.Ten = Ten;
                objDBan.KhuVuc = KhuVuc;
                affectedRows = objDBan.INSERT_BAN();
                strErrorMsg = objDBan.ErrorMsg;
                intErrorCode = objDBan.ErrorCode;
            }
            catch (Exception Ex)
            {
                strErrorMsg = Ex.Message.ToString();
            }
            return affectedRows;
        }
        ////
        public int UPDATE_BAN()
        {
            int affectedRows = 0;
            try
            {
                objDBan.MaBan = MaBan;
                objDBan.Ten = Ten;
                objDBan.KhuVuc = KhuVuc;

                affectedRows = objDBan.UPDATE_BAN();
                strErrorMsg = objDBan.ErrorMsg;
                intErrorCode = objDBan.ErrorCode;
            }
            catch (Exception Ex)
            {
                strErrorMsg = Ex.Message.ToString();
            }
            return affectedRows;
        }

    }
}
