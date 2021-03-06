using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyHoSoCongChuc.DataLayer
{
    public class KhenThuongData
    {
        DataService m_KhenThuongData = new DataService();

        public DataTable LayDanhsachKhenThuong()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM KhenThuong");
            m_KhenThuongData.Load(cmd);
            return m_KhenThuongData;
        }


        public DataRow ThemDongMoi()
        {
            return m_KhenThuongData.NewRow();
        }

        public void ThemKhenThuong(DataRow m_Row)
        {
            m_KhenThuongData.Rows.Add(m_Row);
        }

        public bool LuuKhenThuong()
        {
            return m_KhenThuongData.ExecuteNoneQuery() > 0;
        }
        public DataTable LayDSNV(string maNV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT nv.MaNhanVien AS MaNhanVien,kt.MaKhenThuong AS MaKhenThuong,kt.LoaiKhenThuong AS LoaiKhenThuong, kt.HinhThucKhenThuong AS HinhThucKhenThuong, kt.CapKhenThuong AS CapKhenThuong, kt.Nam AS Nam FROM  NhanVien AS nv, KhenThuong AS kt WHERE kt.MaNhanVien  = nv.MaNhanVien AND kt.MaNhanVien=@ma");
                cmd.Parameters.Add("@ma", SqlDbType.NVarChar).Value = maNV;
                m_KhenThuongData.Load(cmd);

                return m_KhenThuongData;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lấy thông tin Đào tạo không thành công." + e.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
