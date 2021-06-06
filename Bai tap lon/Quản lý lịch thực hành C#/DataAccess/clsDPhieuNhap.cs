using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;


// Name: clsDPhieuNhap 
// Purpose: to manage access table PhieuNhap 
// Creator: Hoangtt
// Created Date: 30/06/2007
// Modification history:

namespace MDS.DataAccess
{
    public class clsDPhieuNhap:clsDBase 
    {
        // *****************************************************************************************************
        // Declare Private variables
        // *****************************************************************************************************
        private string strSoPhieuNhap;
        private string strMaNV;
        //private string strTenNCC;
        private DateTime dtmNgayNhap;
        private string strGhiChu;

        // *****************************************************************************************************
        // End declare variables
        // Declare public properties
        // *****************************************************************************************************
        public string SoPhieuNhap
        {
            get { return strSoPhieuNhap; }
            set { strSoPhieuNhap = value; }
        }
        public string MaNV
        {
            get { return strMaNV; }
            set { strMaNV = value; }
        }

        public DateTime NgayNhap
        {
            get { return dtmNgayNhap; }
            set { dtmNgayNhap = value; }
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


        public int GET_NEXT_ID()
        {
            int returnValue = 0;

            OpenConnection();
            sqlCommand.CommandText = "SELECT iif( max(ID)is null,1,max(ID)+1)  as newID FROM PhieuNhap";
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.Connection = sqlConnection;
            try
            {
                returnValue = (int)sqlCommand.ExecuteScalar();
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


        public DataTable SELECT_ALL()
        {
            DataTable returnValue = new DataTable();

            OpenConnection();
            sqlCommand.CommandText = "SELECT * FROM PhieuNhap ";
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
            sqlCommand.CommandText = "SELECT * FROM PhieuNhap ORDER BY "+ expressionName +" ASC";
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
        public DataTable SELECT_BY_ID()
        {
            DataTable returnValue = new DataTable();
            OpenConnection();
            sqlCommand.CommandText = "SELECT * FROM PhieuNhap WHERE SoPhieuNhap = '"+  SoPhieuNhap +"'";
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

        public DataTable SELECT_BY_TIME(DateTime dtmDateBegin, DateTime dtmDateEnd) {
            DataTable returnValue = new DataTable();
            OpenConnection();
            sqlCommand.CommandText = "SELECT SoPhieuNhap,NgayNhap,P.MaNV as MaNV,TenNV,GhiChu FROM PhieuNhap P,NhanVien N WHERE P.MaNV = N.MaNV AND( NgayNhap between #" + dtmDateBegin.ToShortDateString() + "# AND #"  + dtmDateEnd.ToShortDateString() + "#)";
            
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
        public int INSERT_PHIEUNHAP()
        {
            int affectedRow = 0;
            OpenConnection();
            sqlCommand.CommandText = "INSERT INTO [PHIEUNHAP](Sophieunhap,NgayNhap,MaNV,GhiChu) VALUES(@Sophieunhap,'" + NgayNhap.ToShortDateString() + "',@Manv,@GhiChu)";
            sqlCommand.CommandType = CommandType.Text;
            try
            {
                sqlCommand.Parameters.Add("@Sophieunhap", SqlDbType.VarChar, 50).Value = SoPhieuNhap;
                sqlCommand.Parameters.Add("@Manv", SqlDbType.VarChar, 50).Value = MaNV;
                //sqlCommand.Parameters.Add("@TenNCC", SqlDbType.NVarChar, 255).Value = TenNCC;
                //sqlCommand.Parameters.Add("@NgayNhap", SqlDbType.DBDate).Value = NgayNhap.ToShortDateString();
                sqlCommand.Parameters.Add("@Ghichu",SqlDbType.VarChar,255).Value = GhiChu;
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

        //Update  tra ve so dong anh huong
        public int UPDATE_PHIEUNHAP()
        {
            int affectedRow = 0;

            OpenConnection();
            sqlCommand.CommandText = "UPDATE [PHIEUNHAP] SET Manv=@Manv,NgayNhap='" + NgayNhap.ToShortDateString() + "',Ghichu=@Ghichu WHERE Sophieunhap=@Sophieunhap";
            sqlCommand.CommandType = CommandType.Text;
            try
            {
                sqlCommand.Parameters.Add("@Manv", SqlDbType.VarChar, 25).Value = MaNV;
                //sqlCommand.Parameters.Add("@TenNCC", SqlDbType.NVarChar, 255).Value = TenNCC;
                //sqlCommand.Parameters.Add("@NgayNhap", SqlDbType., 20).Value = NgayNhap;
                sqlCommand.Parameters.Add("@Ghichu", SqlDbType.VarChar, 255).Value = GhiChu;
                sqlCommand.Parameters.Add("@Sophieunhap", SqlDbType.VarChar, 25).Value = SoPhieuNhap;
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
        public int DELETE_PHIEUNHAP()
        {
            int affectedRow = 0;
            OpenConnection();
            sqlCommand.CommandText = "DELETE FROM [PHIEUNHAP] WHERE Sophieunhap=@Sophieunhap";
            sqlCommand.CommandType = CommandType.Text;
            try
            {
                sqlCommand.Parameters.Add("@Sophieunhap", SqlDbType.VarChar, 50).Value = SoPhieuNhap;
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
