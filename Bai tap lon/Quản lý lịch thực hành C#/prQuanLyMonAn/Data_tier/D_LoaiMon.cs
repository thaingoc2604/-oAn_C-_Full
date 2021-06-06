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
    public class D_LoaiMon:General_data
    {
        public int XoaLoaiMon(string maloai)
        {
            try
            {
                // Chú ý phải có kiểm tra đóng kết nối rồi mới mở, nếu không sẽ xảy ra lỗi không thể mỡ kết nối đang mở khi thêm xóa dữ liệu:
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                OleDbCommand cmd = new OleDbCommand("delete from LoaiMon where MaLoai=@maloai", conn);
                cmd.Parameters.Add("@maloai", OleDbType.BSTR).Value = maloai;
                int n = cmd.ExecuteNonQuery();
                conn.Close();
                return n;
            }
            catch // catch return -1 để không bị quăng bảng lỗi khó chịu
            { 
                return -1;
                
            }
            
        }
        public int ThemLoaiMon(LoaiMon lm)
        {            
            try
            {
                // Chú ý phải có kiểm tra đóng kết nối rồi mới mở, nếu không sẽ xảy ra lỗi không thể mở kết nối đang mở khi thêm xóa dữ liệu:
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                OleDbCommand cmd = new OleDbCommand("insert into LoaiMon values(@MaLoai,@TenLoai)", conn);
                cmd.Parameters.Add("@maloai", OleDbType.BSTR).Value = lm.MaLoai;
                cmd.Parameters.Add("@tenloai", OleDbType.BSTR).Value = lm.TenLoai;
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                return i;
            }
            catch // catch return -1 để không bị quăng bảng lỗi khó chịu
            {
                return -1;                
            }            
        }
    }
}
