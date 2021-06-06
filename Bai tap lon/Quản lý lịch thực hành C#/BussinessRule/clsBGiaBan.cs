using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MDS.DataAccess;

namespace MDS.BussinessRule
{
    public class clsBGiaBan: clsBBase
    {
        // *****************************************************************************************************
        // Declare Private variables
        // *****************************************************************************************************
        private string strLoaiKH;
        private string strMaHang;
        private int intGiaBan;

        // *****************************************************************************************************
        // End declare variables

        // Declare public properties
        // *****************************************************************************************************

        public string LoaiKH
        {
            get { return strLoaiKH; }
            set { strLoaiKH = value; }
        }
        public string MaHang
        {
            get { return strMaHang; }
            set { strMaHang = value; }
        }
        public int GiaBan
        {
            get { return intGiaBan; }
            set { intGiaBan = value; }
        }

        // *****************************************************************************************************
        // End declare properties

        clsDGiaBan objDGiaBan = new clsDGiaBan();
        // Method: Initialize
        // Purpose: Init all need objects
        public void Initialize()
        {
            objDGiaBan.ConnectionString = strConnectionstring;
            objDGiaBan.Initialize();

        }

        //Method:
        //Purpose:
        public DataTable SELECT_ALL()
        {
            DataTable returnValue = new DataTable();
            try
            {
                returnValue = objDGiaBan.SELECT_ALL();
                strErrorMsg = objDGiaBan.ErrorMsg;
                intErrorCode = objDGiaBan.ErrorCode;
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
                returnValue = objDGiaBan.SELECT_ALL(expressionName, sortAscending);
                strErrorMsg = objDGiaBan.ErrorMsg;
                intErrorCode = objDGiaBan.ErrorCode;
            }
            catch (Exception ex)
            {
                strErrorMsg = ex.Message.ToString();
            }
            return returnValue;
        }
        //
        public DataTable SELECT_GIABAN_BY_2ID()
        {
            DataTable returnValue = new DataTable();
            try
            {
                objDGiaBan.LoaiKH = LoaiKH;
                objDGiaBan.MaHang = MaHang;
                returnValue = objDGiaBan.SELECT_GIABAN_BY_2ID();
                strErrorMsg = objDGiaBan.ErrorMsg;
                intErrorCode = objDGiaBan.ErrorCode;

            }
            catch (Exception ex)
            {
                strErrorMsg = ex.Message.ToString();
            }
            return returnValue;

        }
        public int DELETE_GIABAN()
        {
            int affectedRows = 0;
            try
            {
                objDGiaBan.LoaiKH = LoaiKH;
                affectedRows = objDGiaBan.DELETE_GiaBan();
                strErrorMsg = objDGiaBan.ErrorMsg;
                intErrorCode = objDGiaBan.ErrorCode;
            }
            catch (Exception Ex)
            {
                strErrorMsg = Ex.Message.ToString();
            }
            return affectedRows;
        }
        ////
        public int INSERT_GIABAN()
        {
            int affectedRows = 0;
            try
            {
                objDGiaBan.LoaiKH = LoaiKH;
                objDGiaBan.MaHang = MaHang;
                objDGiaBan.GiaBan = GiaBan;
                affectedRows = objDGiaBan.INSERT_GIABAN();
                strErrorMsg = objDGiaBan.ErrorMsg;
                intErrorCode = objDGiaBan.ErrorCode;
            }
            catch (Exception Ex)
            {
                strErrorMsg = Ex.Message.ToString();
            }
            return affectedRows;
        }
        ////
        public int UPDATE_GIABAN()
        {
            int affectedRows = 0;
            try
            {
                objDGiaBan.LoaiKH = LoaiKH;
                objDGiaBan.MaHang = MaHang;
                objDGiaBan.GiaBan = GiaBan;

                affectedRows = objDGiaBan.UPDATE_GIABAN();
                strErrorMsg = objDGiaBan.ErrorMsg;
                intErrorCode = objDGiaBan.ErrorCode;
            }
            catch (Exception Ex)
            {
                strErrorMsg = Ex.Message.ToString();
            }
            return affectedRows;
        }

    }
}
