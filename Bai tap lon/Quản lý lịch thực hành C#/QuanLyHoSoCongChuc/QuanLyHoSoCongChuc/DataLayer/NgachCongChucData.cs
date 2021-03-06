using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
namespace QuanLyHoSoCongChuc.DataLayer
{
    public class NgachCongChucData
    {
        DataService m_NgachCongChucData = new DataService();
        // DataService ds = new DataService();
        public DataTable LayDsNgachCongChuc()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM NgachCongChuc");
            m_NgachCongChucData.Load(cmd);
            return m_NgachCongChucData;
        }

        public DataRow ThemDongMoi()
        {
            return m_NgachCongChucData.NewRow();
        }

        public void ThemNgachCongChuc(DataRow m_Row)
        {
            m_NgachCongChucData.Rows.Add(m_Row);
        }

        public bool LuuNgachCongChuc()
        {
            return m_NgachCongChucData.ExecuteNoneQuery() > 0;
        }

    }
}
