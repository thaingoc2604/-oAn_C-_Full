using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyHoSoCongChuc.DataLayer
{
    public class QuaTrinhCongTacData
    {
        DataService m_QTCTData = new DataService();

        public DataTable LayDanhsachQTCT()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM QuaTrinhCongTac");
            m_QTCTData.Load(cmd);
            return m_QTCTData;
        }


        public DataRow ThemDongMoi()
        {
            return m_QTCTData.NewRow();
        }

        public void ThemQTCT(DataRow m_Row)
        {
            m_QTCTData.Rows.Add(m_Row);
        }

        public bool LuuQTCT()
        {
            return m_QTCTData.ExecuteNoneQuery() > 0;
        }
        public DataTable LayDSCT(string maNV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT nv.MaNhanVien AS MaNhanVien,qtct.MaQuaTrinhCongTac AS MaQuaTrinhCongTac, qtct.TenQuaTrinhCongTac AS TenQuaTrinhCongTac, qtct.ThoiGianBatDau AS ThoiGianBatDau, qtct.ThoiGianKetThuc AS ThoiGianKetThuc FROM  NhanVien AS nv, QuaTrinhCongTac AS qtct WHERE qtct.MaNhanVien  = nv.MaNhanVien AND qtct.MaNhanVien=@ma");
                cmd.Parameters.Add("@ma", SqlDbType.NVarChar).Value = maNV;
                m_QTCTData.Load(cmd);

                return m_QTCTData;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lấy thông tin Đào tạo không thành công." + e.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
