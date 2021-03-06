using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyHoSoCongChuc.DataLayer
{
    public class QuaTrinhDaoTaoData
    {
        DataService m_QTDTData = new DataService();

        public DataTable LayDanhsachQTDT()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM QuaTrinhDaoTao");
            m_QTDTData.Load(cmd);
            return m_QTDTData;
        }
       
        
        public DataRow ThemDongMoi()
        {
            return m_QTDTData.NewRow();
        }

        public void ThemQTDT(DataRow m_Row)
        {
            m_QTDTData.Rows.Add(m_Row);
        }

        public bool LuuQTDT()
        {
            return m_QTDTData.ExecuteNoneQuery() > 0;
        }
        public DataTable LayDSNV(string maNV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT nv.MaNhanVien AS MaNhanVien,qtdt.MaQuaTrinhDaoTao AS MaQuaTrinhDaoTao, qtdt.TenQuaTrinhDaoTao AS TenQuaTrinhDaoTao, qtdt.ThoiGianBatDauDaoTao AS ThoiGianBatDauDaoTao, qtdt.ThoiGianKetThucDaoTao AS ThoiGianKetThucDaoTao, qtdt.HinhThucDaoTao AS HinhThucDaoTao, qtdt.BangCap AS BangCap FROM  NhanVien AS nv, QuaTrinhDaoTao AS qtdt WHERE qtdt.MaNhanVien  = nv.MaNhanVien AND qtdt.MaNhanVien=@ma");
                cmd.Parameters.Add("@ma", SqlDbType.NVarChar).Value = maNV;
                m_QTDTData.Load(cmd);

                return m_QTDTData;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lấy thông tin Đào tạo không thành công." + e.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
   
}

