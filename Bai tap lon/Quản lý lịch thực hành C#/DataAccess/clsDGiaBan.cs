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
    public class clsDGiaBan : clsDBase
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
        // Implement methods here
        // *****************************************************************************************************

        public DataTable SELECT_ALL()
        {
            DataTable returnValue = new DataTable();
            OpenConnection();
            sqlCommand.CommandText = "SELECT * FROM [GiaBan] ORDER BY MaHang";
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
            sqlCommand.CommandText = "SELECT * FROM [GiaBan] ORDER BY [" + expressionName + "] " + (sortAscending ? "ASC" : "DESC");
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

        public DataTable SELECT_GIABAN_BY_2ID()
        {
            DataTable returnValue = new DataTable();
            OpenConnection();
            sqlCommand.CommandText = "SELECT * FROM [GiaBan] WHERE LoaiKH=@LoaiKH AND MaHang=@MaHang";
            sqlCommand.CommandType = CommandType.Text;
            try
            {
                sqlCommand.Parameters.Add("@LoaiKH", SqlDbType.VarChar, 50).Value = LoaiKH;
                sqlCommand.Parameters.Add("@MaHang", SqlDbType.VarChar, 50).Value = MaHang;
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
        public int INSERT_GIABAN()
        {
            int affectedRows = 0;
            OpenConnection();
            sqlCommand.CommandText = "INSERT INTO [GiaBan](LoaiKH,MaHang,GiaBan) VALUES(@LoaiKH,@MaHang,@GiaBan)";
            sqlCommand.CommandType = CommandType.Text;
            try
            {
                sqlCommand.Parameters.Add("@LoaiKH", SqlDbType.VarChar, 50).Value = LoaiKH;
                sqlCommand.Parameters.Add("@MaHang", SqlDbType.VarChar, 256).Value = MaHang;
                sqlCommand.Parameters.Add("@GiaBan", SqlDbType.Int).Value = GiaBan;

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
        public int UPDATE_GIABAN()
        {
            int affectedRows = 0;
            OpenConnection();
            sqlCommand.CommandText = "UPDATE [GiaBan] SET MaHang=@MaHang,GiaBan=@GiaBan WHERE LoaiKH=@LoaiKH";
            sqlCommand.CommandType = CommandType.Text;
            try
            {
                sqlCommand.Parameters.Add("@MaHang", SqlDbType.VarChar, 255).Value = MaHang;
                sqlCommand.Parameters.Add("@GiaBan", SqlDbType.Int).Value = GiaBan;
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
        public int DELETE_GiaBan()
        {
            int affectedRows = 0;
            OpenConnection();
            sqlCommand.CommandText = "DELETE FROM [GiaBan] WHERE LoaiKH=@LoaiKH";
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
