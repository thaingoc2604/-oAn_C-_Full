using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using MDS.DataAccess;

namespace MDS.BussinessRule
{
    public class clsBHang : clsBBase
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

        clsDHang objDHang = new clsDHang();
        // Method: Initialize
        // Purpose: Init all need objects
        public void Initialize()
        {
            objDHang.ConnectionString = strConnectionstring;
            objDHang.Initialize();

        }

        //Method:
        //Purpose:
        public DataTable SELECT_ALL()
        {
            DataTable returnValue = new DataTable();
            try
            {
                returnValue = objDHang.SELECT_ALL();
                strErrorMsg = objDHang.ErrorMsg;
                intErrorCode = objDHang.ErrorCode;
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
                returnValue = objDHang.SELECT_ALL(expressionName, sortAscending);
                strErrorMsg = objDHang.ErrorMsg;
                intErrorCode = objDHang.ErrorCode;
            }
            catch (Exception ex)
            {
                strErrorMsg = ex.Message.ToString();
            }
            return returnValue;
        }
        //
        public DataTable SELECT_HANG_BY_ID()
        {
            DataTable returnValue = new DataTable();
            try
            {
                objDHang.MaHang = MaHang;
                returnValue = objDHang.SELECT_HANG_BY_ID();
                strErrorMsg = objDHang.ErrorMsg;
                intErrorCode = objDHang.ErrorCode;

            }
            catch (Exception ex)
            {
                strErrorMsg = ex.Message.ToString();
            }
            return returnValue;

        }
        public int DELETE_HANG()
        {
            int affectedRows = 0;
            try
            {
                objDHang.MaHang = MaHang;
                affectedRows = objDHang.DELETE_HANG();
                strErrorMsg = objDHang.ErrorMsg;
                intErrorCode = objDHang.ErrorCode;
            }
            catch (Exception Ex)
            {
                strErrorMsg = Ex.Message.ToString();
            }
            return affectedRows;
        }
        ////
        public int INSERT_HANG()
        {
            int affectedRows = 0;
            try
            {
                objDHang.MaHang = MaHang;
                objDHang.TenHang = TenHang;
                objDHang.GhiChu = GhiChu;
                affectedRows = objDHang.INSERT_HANG();
                strErrorMsg = objDHang.ErrorMsg;
                intErrorCode = objDHang.ErrorCode;
            }
            catch (Exception Ex)
            {
                strErrorMsg = Ex.Message.ToString();
            }
            return affectedRows;
        }
        ////
        public int UPDATE_HANG()
        {
            int affectedRows = 0;
            try
            {
                objDHang.MaHang = MaHang;
                objDHang.TenHang = TenHang;
                objDHang.GhiChu = GhiChu;

                affectedRows = objDHang.UPDATE_HANG();
                strErrorMsg = objDHang.ErrorMsg;
                intErrorCode = objDHang.ErrorCode;
            }
            catch (Exception Ex)
            {
                strErrorMsg = Ex.Message.ToString();
            }
            return affectedRows;
        }

    }
}
