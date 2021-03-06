using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyHoSoCongChuc.DataLayer
{
    public class QuaTrinhBoiDuongData
    {

        DataService m_QTBDData = new DataService();

        public DataTable LayDanhsachQTBD()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM QuaTrinhBoiDuong");
            m_QTBDData.Load(cmd);
            return m_QTBDData;
        }


        public DataRow ThemDongMoi()
        {
            return m_QTBDData.NewRow();
        }

        public void ThemQTBD(DataRow m_Row)
        {
            m_QTBDData.Rows.Add(m_Row);
        }

        public bool LuuQTBD()
        {
            return m_QTBDData.ExecuteNoneQuery() > 0;
        }
        public DataTable LayDSNV(string maNV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT nv.MaNhanVien AS MaNhanVien,qtbd.MaQuaTrinhBoiDuong AS MaQuaTrinhBoiDuong, qtbd.TenQuaTrinhBoiDuong AS TenQuaTrinhBoiDuong, qtbd.ThoiGian AS ThoiGian, qtbd.NoiBoiDuong AS NoiBoiDuong, qtbd.LoaiHinhBoiDuong AS LoaiHinhBoiDuong, qtbd.ChungChi AS ChungChi FROM  NhanVien AS nv, QuaTrinhBoiDuong AS qtbd WHERE qtbd.MaNhanVien  = nv.MaNhanVien AND qtbd.MaNhanVien=@ma");
                cmd.Parameters.Add("@ma", SqlDbType.NVarChar).Value = maNV;
                m_QTBDData.Load(cmd);

                return m_QTBDData;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lấy thông tin Đào tạo không thành công." + e.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
