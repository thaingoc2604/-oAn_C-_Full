using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
namespace QuanLyHoSoCongChuc.DataLayer
{
    public class QuanHeData
    {
        DataService m_QuanHeData = new DataService();
        // DataService ds = new DataService();
        public DataTable LayDsQuanHe()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM QuanHe");
            m_QuanHeData.Load(cmd);
            return m_QuanHeData;
        }

        public DataRow ThemDongMoi()
        {
            return m_QuanHeData.NewRow();
        }

        public void ThemQuanHe(DataRow m_Row)
        {
            m_QuanHeData.Rows.Add(m_Row);
        }

        public bool LuuQuanHe()
        {
            return m_QuanHeData.ExecuteNoneQuery() > 0;
        }

    }
}
