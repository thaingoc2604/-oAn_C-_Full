//Đề Tài Quản Lý Món Ăn Ngon
//Sinh Viên Thực Hiện: Nguyễn Hoàng Vũ - 10200681 - NCTH4A
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using Entities;
namespace Data_tier
{
    public class D_MonAn:General_data
    {
        public DataSet getMonAn_theo_maloai(string strML)
        {
            OleDbCommand cmd = new OleDbCommand("select * from MonAn where maloai=@maloai",conn);
            cmd.Parameters.Add("@maloai",OleDbType.BSTR).Value=strML;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "MonAn");
            return ds;
        }
        public DataSet getMonAn_theo_mamon(string strMM)
        {
            OleDbCommand cmd = new OleDbCommand("select * from MonAn where mam=@mamon",conn);
            cmd.Parameters.Add("@mamon",OleDbType.BSTR).Value=strMM;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "monan");
            return ds;
        }

        public DataSet TimTenMon_TheoLoai(string tenmonGanDung, string maloai)
        {
            OleDbCommand cmd = new OleDbCommand("Select * From MonAn Where TenM LIKE @tenmonGanDung AND MaLoai = @maloai order by TenM", conn);
            cmd.Parameters.Add("@tenmonGanDung", OleDbType.BSTR).Value = tenmonGanDung + "%";
            cmd.Parameters.Add("@maloai", OleDbType.BSTR).Value = maloai;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "monan");
            return ds;            
        } 

        public int ThemMoiMonAn(MonAn ma)
        {
            try
            {
                // Chú ý phải có kiểm tra đóng kết nối rồi mới mở, nếu không sẽ xảy ra lỗi không thể mở kết nối đang mở khi thêm xóa dữ liệu:
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                OleDbCommand cmd = new OleDbCommand("insert into MonAn values(@MaMon,@TenMon,@MaLoai,@SucKhoe,@NguyenLieu,@CachLam,@ChuY)", conn);
                cmd.Parameters.Add("@MaMon", OleDbType.BSTR).Value = ma.MaMon;
                cmd.Parameters.Add("@TenMon", OleDbType.BSTR).Value = ma.TenMon;
                cmd.Parameters.Add("@MaLoai", OleDbType.BSTR).Value = ma.MaLoai;
                cmd.Parameters.Add("@SucKhoe", OleDbType.BSTR).Value = ma.SucKhoe;
                cmd.Parameters.Add("@Nguyenlieu", OleDbType.BSTR).Value = ma.NguyenLieu;
                cmd.Parameters.Add("@CachLam", OleDbType.BSTR).Value = ma.CachLam;
                cmd.Parameters.Add("@ChuY", OleDbType.BSTR).Value = ma.ChuY;
                int n = cmd.ExecuteNonQuery();
                conn.Close();
                return n;
            }
            catch //// catch return -1 để không bị quăng bảng lỗi khó chịu
            {
                return -1;
            }
        }
        public int XoaMonAn(string mamon)
        {
            try
            {
                // Chú ý phải có kiểm tra đóng kết nối rồi mới mở, nếu không sẽ xảy ra lỗi không thể mở kết nối đang mở khi thêm xóa dữ liệu:
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                OleDbCommand cmd = new OleDbCommand("delete from MonAn where MaM=@mamon", conn);
                cmd.Parameters.Add("@mamon", OleDbType.BSTR).Value = mamon;
                int n = cmd.ExecuteNonQuery();
                conn.Close();
                return n;
            }
            catch //// catch return -1 để không bị quăng bảng lỗi khó chịu
            {
                return -1;
            }
        }        

        public int SuaMonAn_TheoMaMon(MonAn monmoi, string mamon)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }  
                string updateSateMent = @"update monan set MaM='" + monmoi.MaMon + "',TenM='" + monmoi.TenMon + "', SucKhoe='" + monmoi.SucKhoe + "',NguyenLieu='" + monmoi.NguyenLieu + "',ThucHien='" + monmoi.CachLam + "',ChuY='" + monmoi.ChuY + "' WHERE MaM='" + mamon + "'";
                OleDbCommand cmd = new OleDbCommand(updateSateMent, conn); 
                int n = cmd.ExecuteNonQuery();                
                conn.Close();
                return n;
            }
            catch //// catch return -1 để không bị quăng bảng lỗi khó chịu
            {
                return -1;
            }
        }        
    }
}
