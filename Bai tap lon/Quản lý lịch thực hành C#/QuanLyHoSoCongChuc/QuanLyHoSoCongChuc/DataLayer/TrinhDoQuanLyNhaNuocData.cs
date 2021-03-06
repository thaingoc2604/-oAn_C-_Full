using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
namespace QuanLyHoSoCongChuc.DataLayer
{
    public class TrinhDoQuanLyNhaNuocData
    {
        DataService m_TrinhDoQuanLyNhaNuocData = new DataService();
        // DataService ds = new DataService();
        public DataTable LayDsTrinhDoQuanLyNhaNuoc()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM TrinhDoQuanLyNhaNuoc");
            m_TrinhDoQuanLyNhaNuocData.Load(cmd);
            return m_TrinhDoQuanLyNhaNuocData;
        }

        public DataRow ThemDongMoi()
        {
            return m_TrinhDoQuanLyNhaNuocData.NewRow();
        }

        public void ThemTrinhDoQuanLyNhaNuoc(DataRow m_Row)
        {
            m_TrinhDoQuanLyNhaNuocData.Rows.Add(m_Row);
        }

        public bool LuuTrinhDoQuanLyNhaNuoc()
        {
            return m_TrinhDoQuanLyNhaNuocData.ExecuteNoneQuery() > 0;
        }

    }
}
