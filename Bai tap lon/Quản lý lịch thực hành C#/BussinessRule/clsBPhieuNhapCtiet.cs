using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using MDS.DataAccess;

namespace MDS.BussinessRule
{
    public class clsBPhieuNhapCtiet: clsBBase 
    {
        // *****************************************************************************************************
        // Declare Private variables
        // *****************************************************************************************************
        private string strSoPhieuNhap;
        private string strMaHang;
        private Int32 intSoLuong;
        private Int32 intGiaNhap;

        // *****************************************************************************************************
        // End declare variables
        // Declare public properties
        // *****************************************************************************************************
        public string SoPhieuNhap
        {
            get { return strSoPhieuNhap; }
            set { strSoPhieuNhap = value; }
        }
        public string MaHang
        {
            get { return strMaHang; }
            set { strMaHang = value; }
        }
        public Int32 SoLuong
        {
            get { return intSoLuong; }
            set { intSoLuong = value; }
        }
        public Int32 GiaNhap
        {
            get { return intGiaNhap; }
            set { intGiaNhap = value; }
        }

        // *****************************************************************************************************
        // End declare properties

        clsDPhieuNhapCtiet objDPhieuNhapCtiet = new clsDPhieuNhapCtiet();

        // Method: Initialize
        // Purpose: Init all need objects
        public void Initialize()
        {
            objDPhieuNhapCtiet.ConnectionString = strConnectionstring;
            objDPhieuNhapCtiet.Initialize();
        }
        //Method:
        //Purpose:


        public DataTable SELECT_ALL()
        {
            DataTable tblResult = new DataTable();
            try
            {
                tblResult = objDPhieuNhapCtiet.SELECT_ALL();
                strErrorMsg = objDPhieuNhapCtiet.ErrorMsg;
                intErrorCode = objDPhieuNhapCtiet.ErrorCode;
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
                tblResult = objDPhieuNhapCtiet.SELECT_ALL(expressionName, sortAscending);
                strErrorMsg = objDPhieuNhapCtiet.ErrorMsg;
                intErrorCode = objDPhieuNhapCtiet.ErrorCode;
            }
            catch (Exception Ex)
            {
                strErrorMsg = Ex.Message.ToString();
            }
            return tblResult;
        }

        public DataTable SELECT_BY_SOPHIEUNHAP()
        {
            DataTable tblResult = new DataTable();

            try
            {
                objDPhieuNhapCtiet.SoPhieuNhap = SoPhieuNhap;
                tblResult = objDPhieuNhapCtiet.SELECT_BY_SOPHIEUNHAP();
                strErrorMsg = objDPhieuNhapCtiet.ErrorMsg;
                intErrorCode = objDPhieuNhapCtiet.ErrorCode;
            }
            catch (Exception Ex)
            {
                strErrorMsg = Ex.Message.ToString();
            }
            return tblResult;
        }


        public DataTable SELECT_BY_2ID()
        {
            DataTable tblResult = new DataTable();

            try
            {
                objDPhieuNhapCtiet.SoPhieuNhap = SoPhieuNhap;
                objDPhieuNhapCtiet.MaHang = MaHang;
                tblResult = objDPhieuNhapCtiet.SELECT_BY_2ID();
                strErrorMsg = objDPhieuNhapCtiet.ErrorMsg;
                intErrorCode = objDPhieuNhapCtiet.ErrorCode;
            }
            catch (Exception Ex)
            {
                strErrorMsg = Ex.Message.ToString();
            }
            return tblResult;
        }

        public int INSERT_PHIEUNHAPCTIET()
        {
            int returnvalue = 0;
            try
            {
                objDPhieuNhapCtiet.SoPhieuNhap = SoPhieuNhap;
                objDPhieuNhapCtiet.MaHang = MaHang;
                objDPhieuNhapCtiet.SoLuong = SoLuong;
                objDPhieuNhapCtiet.GiaNhap = GiaNhap;
                returnvalue = objDPhieuNhapCtiet.INSERT_PHIEUNHAPCTIET();
                strErrorMsg = objDPhieuNhapCtiet.ErrorMsg;
                intErrorCode = objDPhieuNhapCtiet.ErrorCode;
            }
            catch (Exception Ex)
            {
                strErrorMsg = Ex.Message.ToString();
            }
            return returnvalue;
        }

        public int UPDATE_PHIEUNHAPCTIET()
        {
            int returnvalue = 0;
            try
            {
                objDPhieuNhapCtiet.SoPhieuNhap = SoPhieuNhap;
                objDPhieuNhapCtiet.MaHang = MaHang;
                objDPhieuNhapCtiet.SoLuong = SoLuong;
                objDPhieuNhapCtiet.GiaNhap = GiaNhap;
                returnvalue = objDPhieuNhapCtiet.UPDATE_PHIEUNHAPCTIET();
                strErrorMsg = objDPhieuNhapCtiet.ErrorMsg;
                intErrorCode = objDPhieuNhapCtiet.ErrorCode;
            }
            catch (Exception Ex)
            {
                strErrorMsg = Ex.Message.ToString();
            }
            return returnvalue;
        }

        public int DELETE_PHIEUNHAPCTIET()
        {
            int returnvalue = 0;
            try
            {
                objDPhieuNhapCtiet.SoPhieuNhap = SoPhieuNhap;
                objDPhieuNhapCtiet.MaHang = MaHang;
                returnvalue = objDPhieuNhapCtiet.DELETE_PHIEUNHAPCTIET();
                strErrorMsg = objDPhieuNhapCtiet.ErrorMsg;
                intErrorCode = objDPhieuNhapCtiet.ErrorCode;
            }
            catch (Exception Ex)
            {
                strErrorMsg = Ex.Message.ToString();
            }
            return returnvalue;
        }


    }//End class
}
