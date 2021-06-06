using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;


// Name: clsDNhanVien 
// Purpose: to manage access table NhanVien
// Creator: Minhns
// Created Date: 30/06/2007
// Modification history:

namespace MDS.DataAccess
{
    public class clsDNhanVien : clsDBase
    {
        // *****************************************************************************************************
        // Declare Private variables
        // *****************************************************************************************************
        private string strMaNV;
        private string strMatKhau;
        private string strTenNV;
        private DateTime dtmNgaysinh;
        private string strDiachi;
        private string strDienthoai;
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
        public DateTime NgaySinh
        {
            get { return dtmNgaysinh; }
            set { dtmNgaysinh = value; }
        }

        public string TenNV
        {
            get { return strTenNV; }
            set { strTenNV = value; }
        }
        public string DiaChi
        {
            get { return strDiachi; }
            set { strDiachi = value; }
        }
        public string DienThoai
        {
            get { return strDienthoai; }
            set { strDienthoai = value; }
        }
        public string laAdmin
        {
            get { return strlaAdmin; }
            set { strlaAdmin = value; }
        }

        // *****************************************************************************************************
        // End declare properties

        // Implement methods here
        // *****************************************************************************************************

        public DataTable SELECT_ALL()
        {
            DataTable returnValue = new DataTable();
            OpenConnection();
            sqlCommand.CommandText = "SELECT * FROM [NHANVIEN]";
            sqlCommand.CommandType = CommandType.Text;
            try
            {
                sqlDataAdapter.SelectCommand = sqlCommand;
                sqlDataAdapter.Fill(dsData, "tblResult");
                returnValue = dsData.Tables["tblResult"];
                dsData.Tables.Remove("tblResult");
            }
            catch (OleDbException ex)
            {
                strErrorMsg = ex.Message.ToString();
                intErrorCode = ex.ErrorCode;
            }
            finally
            {
                sqlCommand.Parameters.Clear();
            }
            CloseConnection();
            return returnValue;
        }
        //ham chong de sap xep
        public DataTable SELECT_ALL(string expressionName, bool sortAscending)
        {
            DataTable returnValue = new DataTable();
            OpenConnection();
            sqlCommand.CommandText = "SELECT * FROM [NHANVIEN] ORDER BY [" + expressionName + "] " + (sortAscending ? "ASC" : "DESC");
            sqlCommand.CommandType = CommandType.Text;
            try
            {
                sqlDataAdapter.SelectCommand = sqlCommand;
                sqlDataAdapter.Fill(dsData, "tblResult");
                returnValue = dsData.Tables["tblResult"];
                dsData.Tables.Remove("tblResult");
            }
            catch (OleDbException ex)
            {
                strErrorMsg = ex.Message.ToString();
                intErrorCode = ex.ErrorCode;
            }
            finally
            {
                sqlCommand.Parameters.Clear();
            }
            CloseConnection();
            return returnValue;
        }
        public DataTable SELECT_NHANVIEN_BY_ID()
        {
            DataTable returnValue = new DataTable();
            OpenConnection();
            sqlCommand.CommandText = "SELECT * FROM [NHANVIEN] WHERE MaNV=@MaNV";
            sqlCommand.CommandType = CommandType.Text;
            try
            {
                sqlCommand.Parameters.Add("@MaNV", SqlDbType.VarChar, 50).Value = MaNV;
                sqlDataAdapter.SelectCommand = sqlCommand;
                sqlDataAdapter.Fill(dsData, "tblResult");
                returnValue = dsData.Tables["tblResult"];
                dsData.Tables.Remove("tblResult");
            }
            catch (OleDbException ex)
            {
                strErrorMsg = ex.Message.ToString();
                intErrorCode = ex.ErrorCode;
            }
            finally
            {
                sqlCommand.Parameters.Clear();
            }
            CloseConnection();
            return returnValue;
        }

        public DataTable SELECT_NHANVIEN_LOGIN_INFO()
        {
            DataTable returnValue = new DataTable();
            OpenConnection();
            sqlCommand.CommandText = "Select MatKhau,TenNV from Nhanvien where MaNV=@MaNV";
            sqlCommand.CommandType = CommandType.Text;
            try
            {
                sqlCommand.Parameters.Add("@MaNV", SqlDbType.VarChar, 50).Value = MaNV;
                sqlDataAdapter.SelectCommand = sqlCommand;
                sqlDataAdapter.Fill(dsData, "tblResult");
                returnValue = dsData.Tables["tblResult"];
                dsData.Tables.Remove("tblResult");
            }
            catch (OleDbException ex)
            {
                strErrorMsg = ex.Message.ToString();
                intErrorCode = ex.ErrorCode;
            }
            finally
            {
                sqlCommand.Parameters.Clear();
            }
            CloseConnection();
            return returnValue;
        }

        //
        public int UPDATE_NHANVIEN()
        {
            int affectedRow = 0;
            OpenConnection();
            sqlCommand.CommandText = "UPDATE [NHANVIEN] SET MatKhau=@MatKhau,TenNV=@TenNV,NgaySinh='" + NgaySinh.ToShortDateString() + "',Diachi=@Diachi,Dienthoai=@Dienthoai,laAdmin=@laAdmin WHERE MaNV=@MaNV";
            sqlCommand.CommandType = CommandType.Text;
            try
            {
                sqlCommand.Parameters.Add("@MatKhau", SqlDbType.VarChar, 50).Value = MatKhau;
                sqlCommand.Parameters.Add("@TenNV", SqlDbType.VarChar, 50).Value = TenNV;
                //sqlCommand.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = NgaySinh;
                sqlCommand.Parameters.Add("@Diachi", SqlDbType.VarChar, 255).Value = DiaChi;
                sqlCommand.Parameters.Add("@Dienthoai", SqlDbType.VarChar, 50).Value = DienThoai;
                sqlCommand.Parameters.Add("@laAdmin", SqlDbType.VarChar, 50).Value = laAdmin;
                sqlCommand.Parameters.Add("@MaNV", SqlDbType.VarChar, 50).Value = MaNV;
                affectedRow = sqlCommand.ExecuteNonQuery();
                sqlCommand.Transaction.Commit();
            }
            catch (OleDbException ex)
            {
                strErrorMsg = ex.Message.ToString();
                intErrorCode = ex.ErrorCode;
                sqlCommand.Transaction.Rollback();
            }
            finally
            {
                sqlCommand.Parameters.Clear();
            }
            CloseConnection();
            return affectedRow;
        }
        //
        public int DELETE_NHANVIEN()
        {
            int affectedRows = 0;
            OpenConnection();
            sqlCommand.CommandText = "DELETE FROM [NHANVIEN] WHERE MaNV=@MaNV";
            sqlCommand.CommandType = CommandType.Text;
            try
            {
                sqlCommand.Parameters.Add("@MaNV", SqlDbType.VarChar, 50).Value = MaNV;
                affectedRows = sqlCommand.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                strErrorMsg = ex.Message.ToString();
                intErrorCode = ex.ErrorCode;
            }
            finally
            {
                sqlCommand.Parameters.Clear();
            }
            CloseConnection();
            return affectedRows;
        }
        //
        public int INSERT_NHANVIEN()
        {
            int affectedRows = 0;
            OpenConnection();
            sqlCommand.CommandText = "INSERT INTO [NHANVIEN](MaNV,[MatKhau],TenNV,NgaySinh,Diachi,Dienthoai,laAdmin,LoaiNhanVienID) VALUES(@MaNV,@MatKhau,@TenNV,'" + NgaySinh.ToShortDateString() + "',@Diachi,@Dienthoai,@laAdmin)";
            sqlCommand.CommandType = CommandType.Text;
            try
            {
                sqlCommand.Parameters.Add("@MaNV", SqlDbType.VarChar, 50).Value = MaNV;
                sqlCommand.Parameters.Add("@MatKhau", SqlDbType.VarChar, 50).Value = MatKhau;
                sqlCommand.Parameters.Add("@TenNV", SqlDbType.VarChar, 50).Value = TenNV;
                //sqlCommand.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = NgaySinh;
                sqlCommand.Parameters.Add("@Diachi", SqlDbType.VarChar, 255).Value = DiaChi;
                sqlCommand.Parameters.Add("@Dienthoai", SqlDbType.VarChar, 50).Value = DienThoai;
                sqlCommand.Parameters.Add("@laAdmin", SqlDbType.VarChar, 50).Value = laAdmin;
                affectedRows = sqlCommand.ExecuteNonQuery();
                sqlCommand.Transaction.Commit();
            }
            catch (OleDbException ex)
            {
                strErrorMsg = ex.Message.ToString();
                intErrorCode = ex.ErrorCode;
                sqlCommand.Transaction.Rollback();
            }
            finally
            {
                sqlCommand.Parameters.Clear();
            }
            CloseConnection();
            return affectedRows;
        }

        public DataTable DANG_NHAP()
        {
            DataTable returnValue = new DataTable();
            OpenConnection();
            sqlCommand.CommandText = "SELECT * FROM [NHANVIEN] WHERE MaNV=@MaNV AND MatKhau=@MatKhau";
            sqlCommand.CommandType = CommandType.Text;
            try
            {
                sqlCommand.Parameters.Add("@MaNV", SqlDbType.VarChar, 50).Value = MaNV;
                sqlCommand.Parameters.Add("@MatKhau", SqlDbType.VarChar, 50).Value = MatKhau;
                sqlDataAdapter.SelectCommand = sqlCommand;
                sqlDataAdapter.Fill(dsData, "tblResult");
                returnValue = dsData.Tables["tblResult"];
                dsData.Tables.Remove("tblResult");
            }
            catch (OleDbException ex)
            {
                strErrorMsg = ex.Message.ToString();
                intErrorCode = ex.ErrorCode;
            }
            finally
            {
                sqlCommand.Parameters.Clear();
            }
            CloseConnection();
            return returnValue;


        }
    }
}
