using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
namespace QuanLyHoSoCongChuc.DataLayer
{
    public class DanTocData
    {
        DataService m_DanTocData = new DataService();
        // DataService ds = new DataService();
        public DataTable LayDsDanToc()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM DanToc");
            m_DanTocData.Load(cmd);
            return m_DanTocData;
        }

        public DataRow ThemDongMoi()
        {
            return m_DanTocData.NewRow();
        }

        public void ThemDanToc(DataRow m_Row)
        {
            m_DanTocData.Rows.Add(m_Row);
        }

        public bool LuuDanToc()
        {
            return m_DanTocData.ExecuteNoneQuery() > 0;
        }

    }
}
