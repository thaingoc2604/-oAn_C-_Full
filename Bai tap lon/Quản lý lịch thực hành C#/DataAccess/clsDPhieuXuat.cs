using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;


// Name: clsDPhieuXuat 
// Purpose: to manage access table PhieuXuat 
// Creator: Hoangtt
// Created Date: 30/06/2007
// Modification history:

namespace MDS.DataAccess
{
    public class clsDPhieuXuat:clsDBase 
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


        public int GET_NEXT_ID()
        {
            int returnValue = 0;
            OpenConnection();
            sqlCommand.CommandText = "SELECT iif( max(ID)is null,1,max(ID)+1)  as newID FROM PhieuXuat";
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

        public bool DA_THANH_TOAN(string strMaBan)//Kiem tra xem 1 ban da thanh toan tien chua?
        {
            bool returnValue = false;
            OpenConnection();
            sqlCommand.CommandText = "SELECT TOP 1 ThanhToan FROM PhieuXuat WHERE MaBan = '" + strMaBan + "' ORDER BY ID DESC";
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.Connection = sqlConnection;
            if (sqlCommand.ExecuteScalar() == null)//Ban moi su dung
                return true;
            try
            {
                if ((int)sqlCommand.ExecuteScalar() == 1)
                    returnValue = true;
                else
                    returnValue = false;

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


        public DataTable GET_LAST_BY_BAN() //Xem phieu xuat da duoc thanh toan chua
        {
            DataTable returnValue = new DataTable();
            OpenConnection();
            sqlCommand.CommandText = "SELECT TOP 1 * FROM PhieuXuat WHERE MaBan = '"+ MaBan +"' ORDER BY ID DESC";
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.Connection = sqlConnection;
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


        public DataTable SELECT_ALL()
        {
            DataTable returnValue = new DataTable();

            OpenConnection();
            sqlCommand.CommandText = "SELECT * FROM PhieuXuat";
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
            sqlCommand.CommandText = "SELECT * FROM PhieuXuat ORDER BY "+ expressionName +" ASC";
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
            string strSQL = "SELECT SoPhieuXuat, NgayXuat, MaNV, P.LoaiKH as LoaiKH,L.Ten as TenLoaiKH, P.MaBan as MaBan,B.Ten as TenBan ,TienTra, TienDu, P.GhiChu as GhiChu " +
            "FROM PhieuXuat P,Ban B,LoaiKhachHang L " +
            "WHERE P.MaBan = B.MaBan AND P.LoaiKH = L.LoaiKH AND SoPhieuXuat = '" + SoPhieuXuat + "'";
            sqlCommand.CommandText = strSQL;
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
            sqlCommand.CommandText = "SELECT SoPhieuXuat,NgayXuat,P.MaNV as MaNV,TenNV,TienTra,TienDu,(TienTra-TienDu) as ThanhTien,GhiChu FROM PhieuXuat P,NhanVien N WHERE P.MaNV = N.MaNV AND( NgayXuat between #" + dtmDateBegin.ToShortDateString() + "# AND #"  + dtmDateEnd.ToShortDateString() + "#)";            
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
        public int INSERT_PhieuXuat()
        {
            int affectedRow = 0;
            OpenConnection();
            sqlCommand.CommandText = "INSERT INTO [PhieuXuat](SoPhieuXuat,NgayXuat,MaNV,LoaiKH,MaBan,TienTra,TienDu,GhiChu) VALUES(@SoPhieuXuat,'" + NgayXuat.ToShortDateString() + "',@Manv,@LoaiKH,@MaBan,@TienTra,@TienDu,@GhiChu)";
            sqlCommand.CommandType = CommandType.Text;
            try
            {
                sqlCommand.Parameters.Add("@SoPhieuXuat", SqlDbType.VarChar, 50).Value = SoPhieuXuat;
                sqlCommand.Parameters.Add("@Manv", SqlDbType.VarChar, 50).Value = MaNV;
                sqlCommand.Parameters.Add("@LoaiKH", SqlDbType.VarChar, 50).Value = LoaiKH;
                sqlCommand.Parameters.Add("@MaBan", SqlDbType.VarChar, 50).Value = MaBan;
                sqlCommand.Parameters.Add("@TienTra", SqlDbType.Int).Value = TienTra;
                sqlCommand.Parameters.Add("@TienDu", SqlDbType.Int).Value = TienDu;
                //sqlCommand.Parameters.Add("@TenNCC", SqlDbType.NVarChar, 255).Value = TenNCC;
                //sqlCommand.Parameters.Add("@NgayXuat", SqlDbType.DBDate).Value = NgayXuat.ToShortDateString();
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
        public int UPDATE_PhieuXuat()
        {
            int affectedRow = 0;

            OpenConnection();
            sqlCommand.CommandText = "UPDATE [PhieuXuat] SET Manv=@Manv,NgayXuat='" + NgayXuat.ToShortDateString() + "',LoaiKH=@LoaiKH,MaBan=@MaBan,TienTra=@TienTra,TienDu=@TienDu,Ghichu=@Ghichu,ThanhToan=@ThanhToan WHERE SoPhieuXuat=@SoPhieuXuat";
            sqlCommand.CommandType = CommandType.Text;
            try
            {
                sqlCommand.Parameters.Add("@Manv", SqlDbType.VarChar, 25).Value = MaNV;
                sqlCommand.Parameters.Add("@LoaiKH", SqlDbType.VarChar, 50).Value = LoaiKH;
                sqlCommand.Parameters.Add("@MaBan", SqlDbType.VarChar, 50).Value = MaBan;
                sqlCommand.Parameters.Add("@TienTra", SqlDbType.Int).Value = TienTra;
                sqlCommand.Parameters.Add("@TienDu", SqlDbType.Int).Value = TienDu;
                //sqlCommand.Parameters.Add("@TenNCC", SqlDbType.NVarChar, 255).Value = TenNCC;
                //sqlCommand.Parameters.Add("@NgayXuat", SqlDbType., 20).Value = NgayXuat;
                sqlCommand.Parameters.Add("@Ghichu", SqlDbType.VarChar, 255).Value = GhiChu;
                sqlCommand.Parameters.Add("@ThanhToan", SqlDbType.Int).Value = ThanhToan;
                sqlCommand.Parameters.Add("@SoPhieuXuat", SqlDbType.VarChar, 25).Value = SoPhieuXuat;
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
        public int DELETE_PhieuXuat()
        {
            int affectedRow = 0;
            OpenConnection();
            sqlCommand.CommandText = "DELETE FROM [PhieuXuat] WHERE SoPhieuXuat=@SoPhieuXuat";
            sqlCommand.CommandType = CommandType.Text;
            try
            {
                sqlCommand.Parameters.Add("@SoPhieuXuat", SqlDbType.VarChar, 50).Value = SoPhieuXuat;
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
