using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyHoSoCongChuc.DataLayer
{
    public class KyLuatData
    {
        DataService m_KyLuatData = new DataService();

        public DataTable LayDanhsachKyLuat()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM KyLuat");
            m_KyLuatData.Load(cmd);
            return m_KyLuatData;
        }


        public DataRow ThemDongMoi()
        {
            return m_KyLuatData.NewRow();
        }

        public void ThemKyLuat(DataRow m_Row)
        {
            m_KyLuatData.Rows.Add(m_Row);
        }

        public bool LuuKyLuat()
        {
            return m_KyLuatData.ExecuteNoneQuery() > 0;
        }
        public DataTable LayDSNV(string maNV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT nv.MaNhanVien AS MaNhanVien,kl.MaKyLuat AS MaKyLuat, kl.HinhThucKyLuat AS HinhThucKyLuat, kl.NgayKyLuat AS NgayKyLuat, kl.CoQuanRaQuyetDinh AS CoQuanRaQuyetDinh, kl.NguyenNhan AS NguyenNhan, kl.CoQuanSauKyLuat AS CoQuanSauKyLuat FROM  NhanVien AS nv, KyLuat AS kl WHERE kl.MaNhanVien  = nv.MaNhanVien AND kl.MaNhanVien=@ma");
                cmd.Parameters.Add("@ma", SqlDbType.NVarChar).Value = maNV;
                m_KyLuatData.Load(cmd);

                return m_KyLuatData;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lấy thông tin Đào tạo không thành công." + e.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
