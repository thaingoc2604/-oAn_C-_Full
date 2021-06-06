using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;


// Name: clsDDaiLy
// Purpose: to manage access table DaiLy
// Creator: Hoangtt
// Created Date: 07/07/2007
// Modification history:

namespace MDS.DataAccess
{
    public class clsDLoaiKhachHang : clsDBase
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
        // Implement methods here
        // *****************************************************************************************************

        public DataTable SELECT_ALL()
        {
            DataTable returnValue = new DataTable();
            OpenConnection();
            sqlCommand.CommandText = "SELECT * FROM [LoaiKhachLOAIKHACHHANG] ORDER BY Ten";
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
                CloseConnection();
            }
            
            return returnValue;
        }
        //Method: get data from table Daily and sorting
        public DataTable SELECT_ALL(string expressionName, bool sortAscending)
        {
            DataTable returnValue = new DataTable();
            OpenConnection();
            sqlCommand.CommandText = "SELECT * FROM [LOAIKHACHHANG] ORDER BY [" + expressionName + "] " + (sortAscending ? "ASC" : "DESC");
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

        public DataTable SELECT_LOAIKHACHHANG_BY_ID()
        {
            DataTable returnValue = new DataTable();
            OpenConnection();
            sqlCommand.CommandText = "SELECT * FROM [LOAIKHACHHANG] WHERE LoaiKH=@LoaiKH";
            sqlCommand.CommandType = CommandType.Text;
            try
            {
                sqlCommand.Parameters.Add("@LoaiKH", SqlDbType.VarChar, 50).Value = LoaiKH;
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
                CloseConnection();
            }
            return returnValue;
        }
        //
        public int INSERT_LOAIKHACHHANG()
        {
            int affectedRows = 0;
            OpenConnection();
            sqlCommand.CommandText = "INSERT INTO [LOAIKHACHHANG](LoaiKH,Ten,GhiChu) VALUES(@LoaiKH,@Ten,@GhiChu)";
            sqlCommand.CommandType = CommandType.Text;
            try
            {
                sqlCommand.Parameters.Add("@LoaiKH", SqlDbType.VarChar, 50).Value = LoaiKH;
                sqlCommand.Parameters.Add("@Ten", SqlDbType.VarChar, 256).Value = Ten;
                sqlCommand.Parameters.Add("@GhiChu", SqlDbType.VarChar, 256).Value = GhiChu;

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
                CloseConnection();
            }
            
            return affectedRows;
        }

        ////
        public int UPDATE_LOAIKHACHHANG()
        {
            int affectedRows = 0;
            OpenConnection();
            sqlCommand.CommandText = "UPDATE [LOAIKHACHHANG] SET Ten=@Ten,GhiChu=@GhiChu WHERE LoaiKH=@LoaiKH";
            sqlCommand.CommandType = CommandType.Text;
            try
            {
                sqlCommand.Parameters.Add("@Ten", SqlDbType.VarChar, 255).Value = Ten;
                sqlCommand.Parameters.Add("@GhiChu", SqlDbType.VarChar, 255).Value = GhiChu;
                sqlCommand.Parameters.Add("@LoaiKH", SqlDbType.VarChar, 50).Value = LoaiKH;
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

        ////
        public int DELETE_LOAIKHACHHANG()
        {
            int affectedRows = 0;
            OpenConnection();
            sqlCommand.CommandText = "DELETE FROM [LOAIKHACHHANG] WHERE LoaiKH=@LoaiKH";
            sqlCommand.CommandType = CommandType.Text;
            try
            {
                sqlCommand.Parameters.Add("@LoaiKH", SqlDbType.VarChar, 50).Value = LoaiKH;
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
    }
}
