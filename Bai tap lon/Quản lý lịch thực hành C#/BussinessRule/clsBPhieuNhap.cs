using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MDS.DataAccess;

namespace MDS.BussinessRule
{
    public class clsBPhieuNhap: clsBBase
    {
        // *****************************************************************************************************
        // Declare Private variables
        // *****************************************************************************************************
        private string strSoPhieuNhap;
        private string strMaNV;
        //private string strTenNCC;
        private DateTime dtmNgayNhap;
        private string strGhiChu;

        clsDPhieuNhap objDPhieuNhap = new clsDPhieuNhap();

        // *****************************************************************************************************
        // End declare variables
        // Declare public properties
        // *****************************************************************************************************
        public string SoPhieuNhap
        {
            get { return strSoPhieuNhap; }
            set { strSoPhieuNhap = value; }
        }
        public string MaNV
        {
            get { return strMaNV; }
            set { strMaNV = value; }
        }

        public DateTime NgayNhap
        {
            get { return dtmNgayNhap; }
            set { dtmNgayNhap = value; }
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

        // Method: Initialize
        // Purpose: Init all need objects
        public void Initialize()
        {
            objDPhieuNhap.ConnectionString = strConnectionstring;
            objDPhieuNhap.Initialize();

        }

        


        public string GET_NEXT_ID()
        {
            string returnvalue = "PN";
            try 
            {
                returnvalue += objDPhieuNhap.GET_NEXT_ID().ToString();
                strErrorMsg = objDPhieuNhap.ErrorMsg;
                intErrorCode = objDPhieuNhap.ErrorCode;
            }
            catch (Exception Ex)
            {
                strErrorMsg = Ex.Message.ToString();
            }
            return returnvalue;
        }


        public DataTable SELECT_ALL()
        {
            DataTable tblResult = new DataTable();
            try 
            {   
                tblResult = objDPhieuNhap.SELECT_ALL();
                strErrorMsg = objDPhieuNhap.ErrorMsg;
                intErrorCode = objDPhieuNhap.ErrorCode;
            }
            catch (Exception Ex)
            {
                strErrorMsg = Ex.Message.ToString();
            }
            return tblResult;
        }

        public DataTable SELECT_ALL(string expressionName, bool sortAscending)
        {
            DataTable tblResult = new DataTable();
            try
            {
                tblResult = objDPhieuNhap.SELECT_ALL(expressionName, sortAscending);
                strErrorMsg = objDPhieuNhap.ErrorMsg;
                intErrorCode = objDPhieuNhap.ErrorCode;
            }
            catch (Exception Ex)
            {
                strErrorMsg = Ex.Message.ToString();
            }
            return tblResult;
        }


        public DataTable SELECT_BY_ID()
        {
            DataTable tblResult = new DataTable();

            try
            {
                objDPhieuNhap.SoPhieuNhap = SoPhieuNhap;
                tblResult = objDPhieuNhap.SELECT_BY_ID();
                strErrorMsg = objDPhieuNhap.ErrorMsg;
                intErrorCode = objDPhieuNhap.ErrorCode;
            }
            catch (Exception Ex)
            {
                strErrorMsg = Ex.Message.ToString();
            }
            return tblResult;
        }

        public DataTable SELECT_BY_TIME(DateTime dtmDateBegin, DateTime dtmDateEnd)
        {
            DataTable tblResult = new DataTable();
            try
            {
                tblResult = objDPhieuNhap.SELECT_BY_TIME(dtmDateBegin, dtmDateEnd);
                strErrorMsg = objDPhieuNhap.ErrorMsg;
                intErrorCode = objDPhieuNhap.ErrorCode;
            }
            catch (Exception Ex)
            {
                strErrorMsg = Ex.Message.ToString();
            }
            return tblResult;
        }


        public int INSERT_PHIEUNHAP()
        {
            int returnvalue = 0;
            try
            {
                objDPhieuNhap.SoPhieuNhap = SoPhieuNhap;
                objDPhieuNhap.MaNV = MaNV;
                objDPhieuNhap.NgayNhap = NgayNhap;
                objDPhieuNhap.GhiChu = GhiChu;
                returnvalue = objDPhieuNhap.INSERT_PHIEUNHAP();
                strErrorMsg = objDPhieuNhap.ErrorMsg;
                intErrorCode = objDPhieuNhap.ErrorCode;
            }
            catch (Exception Ex)
            {
                strErrorMsg = Ex.Message.ToString();
            }
            return returnvalue;
        }

        public int UPDATE_PHIEUNHAP()
        {
            int returnvalue = 0;
            try
            {
                objDPhieuNhap.SoPhieuNhap = SoPhieuNhap;
                objDPhieuNhap.MaNV = MaNV;
                objDPhieuNhap.NgayNhap = NgayNhap;
                objDPhieuNhap.GhiChu = GhiChu;
                returnvalue = objDPhieuNhap.UPDATE_PHIEUNHAP();
                strErrorMsg = objDPhieuNhap.ErrorMsg;
                intErrorCode = objDPhieuNhap.ErrorCode;
            }
            catch (Exception Ex)
            {
                strErrorMsg = Ex.Message.ToString();
            }
            return returnvalue;
        }

        public int DELETE_PHIEUNHAP()
        {
            int returnvalue = 0;
            try
            {
                objDPhieuNhap.SoPhieuNhap = SoPhieuNhap;
                returnvalue = objDPhieuNhap.DELETE_PHIEUNHAP();
                strErrorMsg = objDPhieuNhap.ErrorMsg;
                intErrorCode = objDPhieuNhap.ErrorCode;
            }
            catch (Exception Ex)
            {
                strErrorMsg = Ex.Message.ToString();
            }
            return returnvalue;
        }


    }//End class
}
