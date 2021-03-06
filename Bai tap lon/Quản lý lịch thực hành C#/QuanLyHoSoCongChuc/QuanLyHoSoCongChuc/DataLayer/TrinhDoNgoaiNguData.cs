using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
namespace QuanLyHoSoCongChuc.DataLayer
{
    public class TrinhDoNgoaiNguData
    {
        DataService m_TrinhDoNgoaiNguData = new DataService();
        // DataService ds = new DataService();
        public DataTable LayDsTrinhDoNgoaiNgu()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM TrinhDoNgoaiNgu");
            m_TrinhDoNgoaiNguData.Load(cmd);
            return m_TrinhDoNgoaiNguData;
        }

        public DataRow ThemDongMoi()
        {
            return m_TrinhDoNgoaiNguData.NewRow();
        }

        public void ThemTrinhDoNgoaiNgu(DataRow m_Row)
        {
            m_TrinhDoNgoaiNguData.Rows.Add(m_Row);
        }

        public bool LuuTrinhDoNgoaiNgu()
        {
            return m_TrinhDoNgoaiNguData.ExecuteNoneQuery() > 0;
        }

    }
}
