using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;


// Name: clsDPhieuXuatCtiet 
// Purpose: to manage access table PhieuXuatCtiet 
// Creator: Hoangtt
// Created Date: 30/06/2007
// Modification history:

namespace MDS.DataAccess
{
    public class clsDPhieuXuatCtiet:clsDBase 
    {
        // *****************************************************************************************************
        // Declare Private variables
        // *****************************************************************************************************
        private string strSoPhieuXuat;
        private string strMaHang;
        private Int32 intSoLuong;
        private Int32 intDonGia;
        private Int32 intTraLai;//So luong hang bi tra lai
        //private Boolean bolTraThuoc;

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
        public Int32 TraLai
        {
            get { return intTraLai; }
            set { intTraLai = value; }
        }



        // *****************************************************************************************************
        // End declare properties

        // Implement methods here
        // *****************************************************************************************************
        public DataTable SELECT_ALL()
        {
            DataTable returnValue = new DataTable();

            OpenConnection();
            sqlCommand.CommandText = "SELECT * FROM PhieuXuatCTiet ";
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
            sqlCommand.CommandText = "SELECT * FROM PhieuXuatCTiet ORDER BY "+ expressionName +" ASC";
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


        public DataTable SELECT_BY_SOPHIEUXUAT()
        {
            DataTable returnValue = new DataTable();
            OpenConnection();
            sqlCommand.CommandText = "SELECT SoPhieuXuat,P.MaHang as MaHang,TenHang,SoLuong,DonGia, (SoLuong*DonGia) AS ThanhTien,TraLai FROM PhieuXuatCTiet P,Hang H WHERE P.MaHang = H.MaHang AND P.SoPhieuXuat = '" + SoPhieuXuat + "'";
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

        //Select by MaHang and MaPhieuXuat
        public DataTable SELECT_BY_2ID()
        {
            DataTable returnValue = new DataTable();
            OpenConnection();
            sqlCommand.CommandText = "SELECT * FROM PhieuXuatCTiet WHERE SoPhieuXuat = '" + SoPhieuXuat + "' AND MaHang = '" + MaHang + "'";
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


        public string TINH_TONG_TIEN()
        {
            string returnValue = "0";
            OpenConnection();
            sqlCommand.CommandText = "SELECT SUM(SoLuong*DonGia)AS TongTien FROM PhieuXuatCTiet WHERE SoPhieuXuat = '" + SoPhieuXuat + "'";
            sqlCommand.CommandType = CommandType.Text;
            try
            {
                sqlDataAdapter.SelectCommand = sqlCommand;
                sqlDataAdapter.Fill(dsData, "tblResult");
                returnValue = dsData.Tables["tblResult"].Rows[0][0].ToString();
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
        public int INSERT_PHIEUXUATCTIET()
        {
            int affectedRow = 0;
            OpenConnection();
            sqlCommand.CommandText = "INSERT INTO [PhieuXuatCTIET](SoPhieuXuat,MaHang,SoLuong,DonGia) VALUES(@SoPhieuXuat,@MaHang,@SoLuong,@DonGia)";
            sqlCommand.CommandType = CommandType.Text;
            try
            {
                sqlCommand.Parameters.Add("@SoPhieuXuat", SqlDbType.VarChar, 50).Value = SoPhieuXuat;
                sqlCommand.Parameters.Add("@MaHang", SqlDbType.VarChar, 50).Value = MaHang;
                //sqlCommand.Parameters.Add("@TenNCC", SqlDbType.NVarChar, 255).Value = TenNCC;
                sqlCommand.Parameters.Add("@SoLuong", SqlDbType.Int).Value = SoLuong;
                sqlCommand.Parameters.Add("@DonGia", SqlDbType.Int).Value = DonGia;
                //sqlCommand.Parameters.Add("@TraLai", SqlDbType.Boolean).Value = TraLai;
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
        public int UPDATE_PHIEUXUATCTIET()
        {
            int affectedRow = 0;

            OpenConnection();
            //sqlCommand.CommandText = "UPDATE [PhieuXuatCTIET] SET SoLuong=SoLuong + @SoLuong,DonGia=@DonGia,TraLai=TraLai + @TraLai WHERE SoPhieuXuat=@SoPhieuXuat AND MaHang=@MaHang";
            sqlCommand.CommandText = "UPDATE [PhieuXuatCTIET] SET SoLuong=@SoLuong,DonGia=@DonGia,TraLai=@TraLai WHERE SoPhieuXuat=@SoPhieuXuat AND MaHang=@MaHang";

            sqlCommand.CommandType = CommandType.Text;
            try
            {
                sqlCommand.Parameters.Add("@SoLuong", SqlDbType.Int).Value = SoLuong;
                sqlCommand.Parameters.Add("@DonGia", SqlDbType.Int).Value = DonGia;
                sqlCommand.Parameters.Add("@TraLai", SqlDbType.Int).Value = TraLai;
                sqlCommand.Parameters.Add("@SoPhieuXuat", SqlDbType.VarChar, 50).Value = SoPhieuXuat;
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
        public int DELETE_PHIEUXUATCTIET()
        {
            int affectedRow = 0;
            OpenConnection();
            sqlCommand.CommandText = "DELETE FROM [PhieuXuatCTIET] WHERE SoPhieuXuat=@SoPhieuXuat AND MaHang = @MaHang";
            sqlCommand.CommandType = CommandType.Text;
            try
            {
                sqlCommand.Parameters.Add("@SoPhieuXuat", SqlDbType.VarChar, 50).Value = SoPhieuXuat;
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
