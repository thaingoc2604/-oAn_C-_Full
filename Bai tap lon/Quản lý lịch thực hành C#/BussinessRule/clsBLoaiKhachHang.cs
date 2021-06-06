using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MDS.DataAccess;

namespace MDS.BussinessRule
{
    public class clsBLoaiKhachLoai: clsBBase
    {
        // *****************************************************************************************************
        // Declare Private variables
        // *****************************************************************************************************
        private string strLoaiKH;
        private string strTen;
        private string strGhiChu;

        // *****************************************************************************************************
        // End declare variables

        // Declare public properties
        // *****************************************************************************************************

        public string LoaiKH
        {
            get { return strLoaiKH; }
            set { strLoaiKH = value; }
        }
        public string Ten
        {
            get { return strTen; }
            set { strTen = value; }
        }
        public string GhiChu
        {
            get { return strGhiChu; }
            set { strGhiChu = value; }
        }

        // *****************************************************************************************************
        // End declare properties

        clsDLoaiKhachHang objDLoaiKhachHang = new clsDLoaiKhachHang();
        // Method: Initialize
        // Purpose: Init all need objects
        public void Initialize()
        {
            objDLoaiKhachHang.ConnectionString = strConnectionstring;
            objDLoaiKhachHang.Initialize();

        }

        //Method:
        //Purpose:
        public DataTable SELECT_ALL()
        {
            DataTable returnValue = new DataTable();
            try
            {
                returnValue = objDLoaiKhachHang.SELECT_ALL();
                strErrorMsg = objDLoaiKhachHang.ErrorMsg;
                intErrorCode = objDLoaiKhachHang.ErrorCode;
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
                returnValue = objDLoaiKhachHang.SELECT_ALL(expressionName, sortAscending);
                strErrorMsg = objDLoaiKhachHang.ErrorMsg;
                intErrorCode = objDLoaiKhachHang.ErrorCode;
            }
            catch (Exception ex)
            {
                strErrorMsg = ex.Message.ToString();
            }
            return returnValue;
        }
        //
        public DataTable SELECT_LOAIKHACHHANG_BY_ID()
        {
            DataTable returnValue = new DataTable();
            try
            {
                objDLoaiKhachHang.LoaiKH = LoaiKH;
                returnValue = objDLoaiKhachHang.SELECT_LOAIKHACHHANG_BY_ID();
                strErrorMsg = objDLoaiKhachHang.ErrorMsg;
                intErrorCode = objDLoaiKhachHang.ErrorCode;

            }
            catch (Exception ex)
            {
                strErrorMsg = ex.Message.ToString();
            }
            return returnValue;

        }
        public int DELETE_LOAIKHACHHANG()
        {
            int affectedRows = 0;
            try
            {
                objDLoaiKhachHang.LoaiKH = LoaiKH;
                affectedRows = objDLoaiKhachHang.DELETE_LOAIKHACHHANG();
                strErrorMsg = objDLoaiKhachHang.ErrorMsg;
                intErrorCode = objDLoaiKhachHang.ErrorCode;
            }
            catch (Exception Ex)
            {
                strErrorMsg = Ex.Message.ToString();
            }
            return affectedRows;
        }
        ////
        public int INSERT_LOAIKHACHHANG()
        {
            int affectedRows = 0;
            try
            {
                objDLoaiKhachHang.LoaiKH = LoaiKH;
                objDLoaiKhachHang.Ten = Ten;
                objDLoaiKhachHang.GhiChu = GhiChu;
                affectedRows = objDLoaiKhachHang.INSERT_LOAIKHACHHANG();
                strErrorMsg = objDLoaiKhachHang.ErrorMsg;
                intErrorCode = objDLoaiKhachHang.ErrorCode;
            }
            catch (Exception Ex)
            {
                strErrorMsg = Ex.Message.ToString();
            }
            return affectedRows;
        }
        ////
        public int UPDATE_LOAIKHACHHANG()
        {
            int affectedRows = 0;
            try
            {
                objDLoaiKhachHang.LoaiKH = LoaiKH;
                objDLoaiKhachHang.Ten = Ten;
                objDLoaiKhachHang.GhiChu = GhiChu;

                affectedRows = objDLoaiKhachHang.UPDATE_LOAIKHACHHANG();
                strErrorMsg = objDLoaiKhachHang.ErrorMsg;
                intErrorCode = objDLoaiKhachHang.ErrorCode;
            }
            catch (Exception Ex)
            {
                strErrorMsg = Ex.Message.ToString();
            }
            return affectedRows;
        }

    }
}
