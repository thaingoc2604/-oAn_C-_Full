using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
namespace QuanLyHoSoCongChuc.DataLayer
{
    public class TrinhDoHocVanData
    {
        DataService m_TrinhDoHocVanData = new DataService();
        // DataService ds = new DataService();
        public DataTable LayDsTrinhDoHocVan()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM TrinhDoHocVan");
            m_TrinhDoHocVanData.Load(cmd);
            return m_TrinhDoHocVanData;
        }

        public DataRow ThemDongMoi()
        {
            return m_TrinhDoHocVanData.NewRow();
        }

        public void ThemTrinhDoHocVan(DataRow m_Row)
        {
            m_TrinhDoHocVanData.Rows.Add(m_Row);
        }

        public bool LuuTrinhDoHocVan()
        {
            return m_TrinhDoHocVanData.ExecuteNoneQuery() > 0;
        }

    }
}
