using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
namespace QuanLyHoSoCongChuc.DataLayer
{
    public class ThanhPhanXuatThanData
    {
        DataService m_ThanhPhanXuatThanData = new DataService();
        // DataService ds = new DataService();
        public DataTable LayDanhSachThanhPhanXuatThan()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM ThanhPhanXuatThan");
            m_ThanhPhanXuatThanData.Load(cmd);
            return m_ThanhPhanXuatThanData;
        }

        public DataRow ThemDongMoi()
        {
            return m_ThanhPhanXuatThanData.NewRow();
        }

        public void ThemThanhPhanXuatThan(DataRow m_Row)
        {
            m_ThanhPhanXuatThanData.Rows.Add(m_Row);
        }

        public bool LuuThanhPhanXuatThan()
        {
            return m_ThanhPhanXuatThanData.ExecuteNoneQuery() > 0;
        }

    }
}
