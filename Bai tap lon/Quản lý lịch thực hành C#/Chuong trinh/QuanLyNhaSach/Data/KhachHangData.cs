using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyNhaSach.Data
{
    public class KhachHangData
    {
        DataService data = new DataService();
        SqlCommand cmd = new SqlCommand();

        public KhachHangData()
        {
            data.CreateAdapter();
        }

        public DataTable DS_KhachHang()
        {
            //SqlCommand scm = new SqlCommand("Select * from NHANVIEN");
            //data.Load(scm);
            string select = "Select* from KHACHHANG";
            return data.Table(select);

        }
        public DataTable LayKhachHang()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM KHACHHANG");
            data.Load1(cmd);
            return data;
        }
        public DataTable Table_KhachHang(string str)
        {
            return data.Table(str);
        }
        public string Value(string str, string column)
        {
            return data.Value(str, column);
        }

        public void ThemKH(string str)
        {
            cmd.CommandText = str;
            data.AddTypeUpdate(cmd, 2);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Một khách hàng được thêm vào danh sách");
            }
            catch
            {
                MessageBox.Show("Không thêm vào được");
            }
        }

        public void XoaKH(string str)
        {
            cmd.CommandText = str;
            data.AddTypeUpdate(cmd, 3);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Một khách hàng đã bị xóa");
            }
            catch
            {
                MessageBox.Show("Không xóa được");
            }
        }

        public void UpdateKH(string str)
        {
            cmd.CommandText = str;
            data.AddTypeUpdate(cmd, 1);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Một khách hàng đã được sửa");
            }
            catch
            {
                MessageBox.Show("Không sửa được");
            }
        }
        public DataTable TimKhachHang(string ten, string chondiachi, string diachi, string chondienthoai, string dienthoai)
        {
            if (ten == "")
                ten = " ";
            SqlCommand cmd = new SqlCommand();
            String sql = "select * from KHACHHANG where (HOTENKH Like '%' + @ten + '%' )";
            cmd.Parameters.Add("ten", SqlDbType.VarChar).Value = ten;

            if (chondiachi != "None")
            {
                sql += chondiachi + " (DIACHI LIKE '%' + @diachi  + '%') ";
                cmd.Parameters.Add("diachi", SqlDbType.VarChar).Value = diachi;
            }

            if (chondienthoai != "None")
            {
                sql += chondienthoai + " (DIENTHOAI LIKE '%' + @dt  + '%') ";
                cmd.Parameters.Add("dt", SqlDbType.VarChar).Value = dienthoai;
                
            }
            cmd.CommandText = sql;
            data.Load1(cmd);
            return data;
        }
    }
}
