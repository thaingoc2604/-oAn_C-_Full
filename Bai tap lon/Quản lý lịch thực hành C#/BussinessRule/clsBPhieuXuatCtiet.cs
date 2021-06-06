using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using MDS.DataAccess;

namespace MDS.BussinessRule
{
    public class clsBPhieuXuatCtiet: clsBBase 
    {
        // *****************************************************************************************************
        // Declare Private variables
        // *****************************************************************************************************
        private string strSoPhieuXuat;
        private string strMaHang;
        private Int32 intSoLuong;
        private Int32 intDonGia;
        private Boolean bolTraLai;
        private Boolean bolTraThuoc;

        // *****************************************************************************************************
        // End declare variables
        // Declare public properties
        // *****************************************************************************************************
        public string SoPhieuXuat
        {
            get { return strSoPhieuXuat; }
            set { strSoPhieuXuat = value; }
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
        public Int32 DonGia
        {
            get { return intDonGia; }
            set { intDonGia = value; }
        }
        public Boolean TraLai
        {
            get { return bolTraLai; }
            set { bolTraLai = value; }
        }
        public Boolean TraThuoc
        {
            get { return bolTraThuoc; }
            set { bolTraThuoc = value; }
        }

        // *****************************************************************************************************
        // End declare properties

        clsDPhieuXuatCtiet objDPhieuXuatCtiet = new clsDPhieuXuatCtiet();

        // Method: Initialize
        // Purpose: Init all need objects
        public void Initialize()
        {
            objDPhieuXuatCtiet.ConnectionString = strConnectionstring;
            objDPhieuXuatCtiet.Initialize();
        }
        //Method:
        //Purpose:


        public DataTable SELECT_ALL()
        {
            DataTable tblResult = new DataTable();
            try
            {
                tblResult = objDPhieuXuatCtiet.SELECT_ALL();
                strErrorMsg = objDPhieuXuatCtiet.ErrorMsg;
                intErrorCode = objDPhieuXuatCtiet.ErrorCode;
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
                tblResult = objDPhieuXuatCtiet.SELECT_ALL(expressionName, sortAscending);
                strErrorMsg = objDPhieuXuatCtiet.ErrorMsg;
                intErrorCode = objDPhieuXuatCtiet.ErrorCode;
            }
            catch (Exception Ex)
            {
                strErrorMsg = Ex.Message.ToString();
            }
            return tblResult;
        }

        public DataTable SELECT_BY_SOPHIEUXUAT()
        {
            DataTable tblResult = new DataTable();

            try
            {
                objDPhieuXuatCtiet.SoPhieuXuat = SoPhieuXuat;
                tblResult = objDPhieuXuatCtiet.SELECT_BY_SOPHIEUXUAT();
                strErrorMsg = objDPhieuXuatCtiet.ErrorMsg;
                intErrorCode = objDPhieuXuatCtiet.ErrorCode;
            }
            catch (Exception Ex)
            {
                strErrorMsg = Ex.Message.ToString();
            }
            return tblResult;
        }

        public int TINH_TONG_TIEN()
        {
            int intResult = 0;
            try
            {
                objDPhieuXuatCtiet.SoPhieuXuat = SoPhieuXuat;
                intResult = Convert.ToInt32(objDPhieuXuatCtiet.TINH_TONG_TIEN());
                strErrorMsg = objDPhieuXuatCtiet.ErrorMsg;
                intErrorCode = objDPhieuXuatCtiet.ErrorCode;
            }
            catch (Exception Ex)
            {
                strErrorMsg = Ex.Message.ToString();
            }
            return intResult;
        }


        public DataTable SELECT_BY_2ID()
        {
            DataTable tblResult = new DataTable();

            try
            {
                objDPhieuXuatCtiet.SoPhieuXuat = SoPhieuXuat;
                objDPhieuXuatCtiet.MaHang = MaHang;
                tblResult = objDPhieuXuatCtiet.SELECT_BY_2ID();
                strErrorMsg = objDPhieuXuatCtiet.ErrorMsg;
                intErrorCode = objDPhieuXuatCtiet.ErrorCode;
            }
            catch (Exception Ex)
            {
                strErrorMsg = Ex.Message.ToString();
            }
            return tblResult;
        }


        public int INSERT_PHIEUXUATCTIET()
        {
            int returnvalue = 0;
            try
            {
                objDPhieuXuatCtiet.SoPhieuXuat = SoPhieuXuat;
                objDPhieuXuatCtiet.MaHang = MaHang;
                objDPhieuXuatCtiet.SoLuong = SoLuong;
                objDPhieuXuatCtiet.DonGia = DonGia;
                //objDPhieuXuatCtiet.TraLai = TraLai;
                returnvalue = objDPhieuXuatCtiet.INSERT_PHIEUXUATCTIET();
                strErrorMsg = objDPhieuXuatCtiet.ErrorMsg;
                intErrorCode = objDPhieuXuatCtiet.ErrorCode;
            }
            catch (Exception Ex)
            {
                strErrorMsg = Ex.Message.ToString();
            }
            return returnvalue;
        }

        public int UPDATE_PHIEUXUATCTIET()
        {
            int returnvalue = 0;
            try
            {
                objDPhieuXuatCtiet.SoPhieuXuat = SoPhieuXuat;
                objDPhieuXuatCtiet.MaHang = MaHang;

                //if (TraLai)//Neu la hang tra lai nhu thuoc la thi tru so luong
                //{
                //    objDPhieuXuatCtiet.DonGia = DonGia;
                //    objDPhieuXuatCtiet.SoLuong = -SoLuong;
                //    if (!TraThuoc)//Khong phai la tra lai thuoc la thi tru so luong va tang tra lai
                //        objDPhieuXuatCtiet.TraLai = SoLuong;
                //}
                //else
                //{
                objDPhieuXuatCtiet.SoLuong = SoLuong;
                objDPhieuXuatCtiet.DonGia = DonGia;
                //}
                returnvalue = objDPhieuXuatCtiet.UPDATE_PHIEUXUATCTIET();
                strErrorMsg = objDPhieuXuatCtiet.ErrorMsg;
                intErrorCode = objDPhieuXuatCtiet.ErrorCode;
            }
            catch (Exception Ex)
            {
                strErrorMsg = Ex.Message.ToString();
            }
            return returnvalue;
        }

        public int DELETE_PHIEUXUATCTIET()
        {
            int returnvalue = 0;
            try
            {
                objDPhieuXuatCtiet.SoPhieuXuat = SoPhieuXuat;
                objDPhieuXuatCtiet.MaHang = MaHang;
                returnvalue = objDPhieuXuatCtiet.DELETE_PHIEUXUATCTIET();
                strErrorMsg = objDPhieuXuatCtiet.ErrorMsg;
                intErrorCode = objDPhieuXuatCtiet.ErrorCode;
            }
            catch (Exception Ex)
            {
                strErrorMsg = Ex.Message.ToString();
            }
            return returnvalue;
        }


    }//End class
}
