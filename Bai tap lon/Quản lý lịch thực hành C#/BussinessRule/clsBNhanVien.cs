using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MDS.DataAccess;

namespace MDS.BussinessRule
{
    public class clsBNhanVien : clsBBase
    {
        // *****************************************************************************************************
        // Declare Private variables
        // *****************************************************************************************************
        private string strMaNV;
        private string strMatKhau;
        private string strTenNV;
        private DateTime dtmNgaySinh;
        private string strDiaChi;
        private string strDienThoai;
        private string strlaAdmin;
        
        // *****************************************************************************************************
        // End declare variables

        // Declare public properties
        // *****************************************************************************************************

        public string MaNV
        {
            get { return strMaNV; }
            set { strMaNV = value; }
        }
        public string MatKhau
        {
            get { return strMatKhau; }
            set { strMatKhau = value; }
        }
        public string TenNV
        {
            get { return strTenNV; }
            set { strTenNV = value; }
        }
        public DateTime NgaySinh
        {
            get { return dtmNgaySinh; }
            set { dtmNgaySinh = value; }
        }
        public string DiaChi
        {
            get { return strDiaChi; }
            set { strDiaChi = value; }
        }
        public string DienThoai
        {
            get { return strDienThoai; }
            set { strDienThoai = value; }
        }
        public string laAdmin
        {
            get { return strlaAdmin; }
            set { strlaAdmin = value; }
        }
        // *****************************************************************************************************
        // End declare properties

        MDS.DataAccess.clsDNhanVien objDNhanVien = new clsDNhanVien();
        // Method: Initialize

        // Purpose: Init all need objects
        public void Initialize()
        {
            objDNhanVien.ConnectionString = strConnectionstring;
            objDNhanVien.Initialize();
        }

        //Method:
        //Purpose:
        public DataTable SELECT_ALL()
        {
            DataTable returnValue = new DataTable();
            try
            {
                returnValue = objDNhanVien.SELECT_ALL();
                strErrorMsg = objDNhanVien.ErrorMsg;
                intErrorCode = objDNhanVien.ErrorCode;
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
                returnValue = objDNhanVien.SELECT_ALL(expressionName, sortAscending);
                strErrorMsg = objDNhanVien.ErrorMsg;
                intErrorCode = objDNhanVien.ErrorCode;
            }
            catch (Exception ex)
            {
                strErrorMsg = ex.Message.ToString();
            }
            return returnValue;
        }
        //
        public DataTable SELECT_NHANVIEN_BY_ID()
        {
            DataTable returnValue = new DataTable();
            try
            {
                objDNhanVien.MaNV = strMaNV;
                returnValue = objDNhanVien.SELECT_NHANVIEN_BY_ID();
                strErrorMsg = objDNhanVien.ErrorMsg;
                intErrorCode = objDNhanVien.ErrorCode;

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
                objDNhanVien.MaNV = strMaNV;
                affectedRows = objDNhanVien.DELETE_NHANVIEN();

                strErrorMsg = objDNhanVien.ErrorMsg;
                intErrorCode = objDNhanVien.ErrorCode;
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
                objDNhanVien.MaNV = MaNV;
                objDNhanVien.MatKhau = MatKhau;
                objDNhanVien.TenNV = TenNV;
                objDNhanVien.NgaySinh = NgaySinh;
                objDNhanVien.DiaChi = DiaChi;
                objDNhanVien.DienThoai = DienThoai;
                objDNhanVien.laAdmin = laAdmin;
                affectedRows = objDNhanVien.INSERT_NHANVIEN();
                strErrorMsg = objDNhanVien.ErrorMsg;
                intErrorCode = objDNhanVien.ErrorCode;
            }
            catch (Exception Ex)
            {
                strErrorMsg = Ex.Message.ToString();
            }
            return affectedRows;
        }
        //
        public int UPDATE_NHANVIEN()
        {
            int affectedRows = 0;
            try
            {
                objDNhanVien.MaNV = MaNV;
                objDNhanVien.MatKhau = MatKhau;
                objDNhanVien.TenNV = TenNV;
                objDNhanVien.NgaySinh = NgaySinh;
                objDNhanVien.DiaChi = DiaChi;
                objDNhanVien.DienThoai = DienThoai;
                objDNhanVien.laAdmin = laAdmin;
                affectedRows = objDNhanVien.UPDATE_NHANVIEN();
                strErrorMsg = objDNhanVien.ErrorMsg;
                intErrorCode = objDNhanVien.ErrorCode;
            }
            catch (Exception Ex)
            {
                strErrorMsg = Ex.Message.ToString();
            }
            return affectedRows;
        }

        public string[] LoginAuthentication()
        {
            string[] valueToGet = new string[3] { "", "", "" };
            DataTable returnValue = new DataTable();
            try
            {
                objDNhanVien.MaNV = strMaNV;
                returnValue = objDNhanVien.SELECT_NHANVIEN_LOGIN_INFO();
                strErrorMsg = objDNhanVien.ErrorMsg;
                intErrorCode = objDNhanVien.ErrorCode;

                if (returnValue.Rows.Count > 0)
                {
                    //Common cls = new Common();
                    //if (Convert.ToString(sqlDataReader["MatKhau"]) == cls.PassEncrypting(MatKhau, "key"))
                    if (Convert.ToString(returnValue.Rows[0]["MatKhau"]) == strMatKhau)
                    {
                        valueToGet[0] = "OK";
                        valueToGet[1] = strMaNV;
                        valueToGet[2] = Convert.ToString(returnValue.Rows[0]["TenNV"]);
                    }
                    else
                    {
                        valueToGet[0] = "P";
                    }
                }
                else
                {
                    valueToGet[0] = "U";
                }

            }
            catch (Exception ex)
            {
                strErrorMsg = ex.Message.ToString();
            }
            return valueToGet;
        }

        //Method: ChangeMatKhau()
        //Purpose: Change user MatKhau
        public string ChangeMatKhau(string newMatKhau)
        {
            string valueResult = "";
            DataTable returnValue = new DataTable();
            try
            {
                objDNhanVien.MaNV = strMaNV;
                objDNhanVien.MatKhau = strMatKhau;
                returnValue = objDNhanVien.SELECT_NHANVIEN_LOGIN_INFO();
                strErrorMsg = objDNhanVien.ErrorMsg;
                intErrorCode = objDNhanVien.ErrorCode;

                if (returnValue.Rows.Count > 0)
                {
                    if (Convert.ToString(returnValue.Rows[0]["MatKhau"]) == strMatKhau)
                    {
                        strMatKhau = newMatKhau;
                        objDNhanVien.MatKhau = strMatKhau;
                        if (objDNhanVien.UPDATE_NHANVIEN() > 0)
                        {
                            valueResult = "OK";//Doi pass thanh cong
                        }
                        else
                        {
                            strErrorMsg = objDNhanVien.ErrorMsg;
                            intErrorCode = objDNhanVien.ErrorCode;
                        }
                    }
                    else
                    {
                        valueResult = "P";//Sai MatKhau cu;
                    }
                }
                else
                {
                    valueResult = "U"; //Sai ten tai khoan
                }

            }
            catch (Exception ex)
            {
                strErrorMsg = ex.Message.ToString();
            }
            return valueResult;
        }

        public Boolean DangNhap()
        {
            DataTable returnValue = new DataTable();
            try
            {
                objDNhanVien.MaNV = MaNV;
                objDNhanVien.MatKhau = MatKhau;
                returnValue = objDNhanVien.DANG_NHAP();
                if (returnValue.Rows.Count > 0)
                    return true;
                strErrorMsg = objDNhanVien.ErrorMsg;
                intErrorCode = objDNhanVien.ErrorCode;
            }
            catch (Exception ex)
            {
                strErrorMsg = ex.Message.ToString();
            }
            return false;
        }
    }
}
