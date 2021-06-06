using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;


// Name: clsDPhieuNhapCtiet 
// Purpose: to manage access table PhieuNhapCtiet 
// Creator: Hoangtt
// Created Date: 30/06/2007
// Modification history:

namespace MDS.DataAccess
{
    public class clsDPhieuNhapCtiet:clsDBase 
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

        // Implement methods here
        // *****************************************************************************************************
        public DataTable SELECT_ALL()
        {
            DataTable returnValue = new DataTable();

            OpenConnection();
            sqlCommand.CommandText = "SELECT * FROM PhieuNhapCTiet ";
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
        //ham chong de sap xep
        public DataTable SELECT_ALL(string expressionName, bool sortAscending)
        {
            DataTable returnValue = new DataTable();
            OpenConnection();
            sqlCommand.CommandText = "SELECT * FROM PhieuNhapCTiet ORDER BY "+ expressionName +" ASC";
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


        public DataTable SELECT_BY_SOPHIEUNHAP()
        {
            DataTable returnValue = new DataTable();
            OpenConnection();
            sqlCommand.CommandText = "SELECT SoPhieuNhap,P.MaHang as MaHang,TenHang,SoLuong,GiaNhap FROM PhieuNhapCTiet P,Hang H WHERE P.MaHang = H.MaHang AND P.SoPhieuNhap = '" + SoPhieuNhap + "'";
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

        //Select co dieu kien
        public DataTable SELECT_BY_2ID()
        {
            DataTable returnValue = new DataTable();
            OpenConnection();
            sqlCommand.CommandText = "SELECT * FROM PhieuNhapCTiet WHERE SoPhieuNhap = '" + SoPhieuNhap + "' AND MaHang = '" + MaHang + "'";
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
        //Insert tra ve so dong them vao
        public int INSERT_PHIEUNHAPCTIET()
        {
            int affectedRow = 0;
            OpenConnection();
            sqlCommand.CommandText = "INSERT INTO [PHIEUNHAPCTIET](Sophieunhap,MaHang,SoLuong,GiaNhap) VALUES(@Sophieunhap,@MaHang,@SoLuong,@GiaNhap)";
            sqlCommand.CommandType = CommandType.Text;
            try
            {
                sqlCommand.Parameters.Add("@Sophieunhap", SqlDbType.VarChar, 50).Value = SoPhieuNhap;
                sqlCommand.Parameters.Add("@MaHang", SqlDbType.VarChar, 50).Value = MaHang;
                //sqlCommand.Parameters.Add("@TenNCC", SqlDbType.NVarChar, 255).Value = TenNCC;
                sqlCommand.Parameters.Add("@SoLuong", SqlDbType.Int).Value = SoLuong;
                sqlCommand.Parameters.Add("@GiaNhap", SqlDbType.Int).Value = GiaNhap;
                affectedRow = sqlCommand.ExecuteNonQuery();
            }
            catch (OleDbException sqlClientEx)
            {
                ErrorMsg = sqlClientEx.Message.ToString();
                ErrorCode = sqlClientEx.ErrorCode;
            }
            finally
            {
                sqlCommand.Parameters.Clear();
                CloseConnection();
            }
            return affectedRow;
        }

        //Update  tra ve so dong anh huong
        public int UPDATE_PHIEUNHAPCTIET()
        {
            int affectedRow = 0;

            OpenConnection();
            sqlCommand.CommandText = "UPDATE [PHIEUNHAPCTIET] SET SoLuong=@SoLuong,GiaNhap=@GiaNhap WHERE Sophieunhap=@Sophieunhap AND MaHang=@MaHang";
            sqlCommand.CommandType = CommandType.Text;
            try
            {
                sqlCommand.Parameters.Add("@SoLuong", SqlDbType.Int).Value = SoLuong;
                sqlCommand.Parameters.Add("@GiaNhap", SqlDbType.Int).Value = GiaNhap;
                sqlCommand.Parameters.Add("@Sophieunhap", SqlDbType.VarChar, 50).Value = SoPhieuNhap;
                sqlCommand.Parameters.Add("@MaHang", SqlDbType.VarChar, 50).Value = MaHang;
                //sqlCommand.Parameters.Add("@TenNCC", SqlDbType.NVarChar, 255).Value = TenNCC;
                affectedRow = sqlCommand.ExecuteNonQuery();
            }
            catch (OleDbException sqlClientEx)
            {
                strErrorMsg = sqlClientEx.Message.ToString();
                intErrorCode = sqlClientEx.ErrorCode;
            }
            finally
            {
                sqlCommand.Parameters.Clear();
                CloseConnection();
            }    
            return affectedRow;
        }

        //Delete tra ve so dong bi xoa
        public int DELETE_PHIEUNHAPCTIET()
        {
            int affectedRow = 0;
            OpenConnection();
            sqlCommand.CommandText = "DELETE FROM [PHIEUNHAPCTIET] WHERE Sophieunhap=@Sophieunhap AND MaHang = @MaHang";
            sqlCommand.CommandType = CommandType.Text;
            try
            {
                sqlCommand.Parameters.Add("@Sophieunhap", SqlDbType.VarChar, 50).Value = SoPhieuNhap;
                sqlCommand.Parameters.Add("@MaHang", SqlDbType.VarChar, 50).Value = MaHang;
                affectedRow = sqlCommand.ExecuteNonQuery();
            }
            catch (OleDbException sqlClientEx)
            {
                strErrorMsg = sqlClientEx.Message.ToString();
                intErrorCode = sqlClientEx.ErrorCode;
            }
            finally
            {
                sqlCommand.Parameters.Clear();
                this.CloseConnection();
            }
            return affectedRow;
        }
    }
}
