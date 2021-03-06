using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
namespace QuanLyHoSoCongChuc.DataLayer
{
    public class TrinhDoChuyenMonData
    {
        DataService m_TrinhDoChuyenMonData = new DataService();
        // DataService ds = new DataService();
        public DataTable LayDsTrinhDoChuyenMon()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM TrinhDoChuyenMon");
            m_TrinhDoChuyenMonData.Load(cmd);
            return m_TrinhDoChuyenMonData;
        }

        public DataRow ThemDongMoi()
        {
            return m_TrinhDoChuyenMonData.NewRow();
        }

        public void ThemTrinhDoChuyenMon(DataRow m_Row)
        {
            m_TrinhDoChuyenMonData.Rows.Add(m_Row);
        }

        public bool LuuTrinhDoChuyenMon()
        {
            return m_TrinhDoChuyenMonData.ExecuteNoneQuery() > 0;
        }

    }
}
