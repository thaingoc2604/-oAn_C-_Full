using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MDS.DataAccess;

namespace MDS.BussinessRule
{
    public class clsBPhieuXuat: clsBBase
    {
        // *****************************************************************************************************
        // Declare Private variables
        // *****************************************************************************************************
        private string strSoPhieuXuat;
        private string strMaNV;
        //private string strTenNCC;
        private DateTime dtmNgayXuat;
        private string strLoaiKH;
        private string strMaBan;
        private int intTienTra;
        private int intTienDu;
        private string strGhiChu;
        private int intThanhToan;
        clsDPhieuXuat objDPhieuXuat = new clsDPhieuXuat();

        // *****************************************************************************************************
        // End declare variables
        // Declare public properties
        // *****************************************************************************************************
        public string SoPhieuXuat
        {
            get { return strSoPhieuXuat; }
            set { strSoPhieuXuat = value; }
        }
        public string MaNV
        {
            get { return strMaNV; }
            set { strMaNV = value; }
        }

        public DateTime NgayXuat
        {
            get { return dtmNgayXuat; }
            set { dtmNgayXuat = value; }
        }

        public string LoaiKH
        {
            get { return strLoaiKH; }
            set { strLoaiKH = value; }
        }

        public string MaBan
        {
            get { return strMaBan; }
            set { strMaBan = value; }
        }

        public int TienTra
        {
            get { return intTienTra; }
            set { intTienTra = value; }
        }

        public int TienDu
        {
            get { return intTienDu; }
            set { intTienDu = value; }
        }

        public string GhiChu
        {
            get { return strGhiChu; }
            set { strGhiChu = value; }
        }

        public int ThanhToan
        {
            get { return intThanhToan; }
            set { intThanhToan = value; }
        }
        // *****************************************************************************************************
        // End declare properties

        // Implement methods here
        // *****************************************************************************************************

        // Method: Initialize
        // Purpose: Init all need objects
        public void Initialize()
        {
            objDPhieuXuat.ConnectionString = strConnectionstring;
            objDPhieuXuat.Initialize();

        }


        public string GET_NEXT_ID()
        {
            string returnvalue = "PX";
            try 
            {
                returnvalue += objDPhieuXuat.GET_NEXT_ID().ToString();
                strErrorMsg = objDPhieuXuat.ErrorMsg;
                intErrorCode = objDPhieuXuat.ErrorCode;
            }
            catch (Exception Ex)
            {
                strErrorMsg = Ex.Message.ToString();
            }
            return returnvalue;
        }

        public bool DA_THANH_TOAN(string strMaBan) {

            bool returnValue = false;
            try
            {
                returnValue = objDPhieuXuat.DA_THANH_TOAN(strMaBan);
                strErrorMsg = objDPhieuXuat.ErrorMsg;
                intErrorCode = objDPhieuXuat.ErrorCode;
            }
            catch (Exception Ex)
            {
                strErrorMsg = Ex.Message.ToString();
            }
            return returnValue;
        }

        public DataTable GET_LAST_BY_BAN()
        {
            DataTable returnvalue = new DataTable();
            try
            {
                objDPhieuXuat.MaBan = MaBan;
                returnvalue = objDPhieuXuat.GET_LAST_BY_BAN();
                strErrorMsg = objDPhieuXuat.ErrorMsg;
                intErrorCode = objDPhieuXuat.ErrorCode;
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
                tblResult = objDPhieuXuat.SELECT_ALL();
                strErrorMsg = objDPhieuXuat.ErrorMsg;
                intErrorCode = objDPhieuXuat.ErrorCode;
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
                tblResult = objDPhieuXuat.SELECT_ALL(expressionName, sortAscending);
                strErrorMsg = objDPhieuXuat.ErrorMsg;
                intErrorCode = objDPhieuXuat.ErrorCode;
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
                objDPhieuXuat.SoPhieuXuat = SoPhieuXuat;
                tblResult = objDPhieuXuat.SELECT_BY_ID();
                strErrorMsg = objDPhieuXuat.ErrorMsg;
                intErrorCode = objDPhieuXuat.ErrorCode;
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
                tblResult = objDPhieuXuat.SELECT_BY_TIME(dtmDateBegin, dtmDateEnd);
                strErrorMsg = objDPhieuXuat.ErrorMsg;
                intErrorCode = objDPhieuXuat.ErrorCode;
            }
            catch (Exception Ex)
            {
                strErrorMsg = Ex.Message.ToString();
            }
            return tblResult;
        }


        public int INSERT_PHIEUXUAT()
        {
            int returnvalue = 0;
            try
            {
                objDPhieuXuat.SoPhieuXuat = SoPhieuXuat;
                objDPhieuXuat.MaNV = MaNV;
                objDPhieuXuat.NgayXuat = NgayXuat;
                objDPhieuXuat.LoaiKH = LoaiKH;
                objDPhieuXuat.MaBan = MaBan;
                objDPhieuXuat.GhiChu = GhiChu;
                returnvalue = objDPhieuXuat.INSERT_PhieuXuat();
                strErrorMsg = objDPhieuXuat.ErrorMsg;
                intErrorCode = objDPhieuXuat.ErrorCode;
            }
            catch (Exception Ex)
            {
                strErrorMsg = Ex.Message.ToString();
            }
            return returnvalue;
        }

        public int UPDATE_PHIEUXuat()
        {
            int returnvalue = 0;
            try
            {
                objDPhieuXuat.SoPhieuXuat = SoPhieuXuat;
                objDPhieuXuat.MaNV = MaNV;
                objDPhieuXuat.NgayXuat = NgayXuat;
                objDPhieuXuat.LoaiKH = LoaiKH;
                objDPhieuXuat.MaBan = MaBan;
                objDPhieuXuat.TienTra = TienTra;
                objDPhieuXuat.TienDu = TienDu;
                objDPhieuXuat.GhiChu = GhiChu;
                objDPhieuXuat.ThanhToan = ThanhToan;
                returnvalue = objDPhieuXuat.UPDATE_PhieuXuat();
                strErrorMsg = objDPhieuXuat.ErrorMsg;
                intErrorCode = objDPhieuXuat.ErrorCode;
            }
            catch (Exception Ex)
            {
                strErrorMsg = Ex.Message.ToString();
            }
            return returnvalue;
        }

        public int DELETE_PHIEUXuat()
        {
            int returnvalue = 0;
            try
            {
                objDPhieuXuat.SoPhieuXuat = SoPhieuXuat;
                returnvalue = objDPhieuXuat.DELETE_PhieuXuat();
                strErrorMsg = objDPhieuXuat.ErrorMsg;
                intErrorCode = objDPhieuXuat.ErrorCode;
            }
            catch (Exception Ex)
            {
                strErrorMsg = Ex.Message.ToString();
            }
            return returnvalue;
        }


    }//End class
}
