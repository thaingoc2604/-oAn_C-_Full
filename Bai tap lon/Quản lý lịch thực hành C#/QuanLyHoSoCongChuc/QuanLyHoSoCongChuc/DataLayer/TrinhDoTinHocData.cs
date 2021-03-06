using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
namespace QuanLyHoSoCongChuc.DataLayer
{
    public class TrinhDoTinHocData
    {
        DataService m_TrinhDoTinHocData = new DataService();
        // DataService ds = new DataService();
        public DataTable LayDsTrinhDoTinHoc()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM TrinhDoTinHoc");
            m_TrinhDoTinHocData.Load(cmd);
            return m_TrinhDoTinHocData;
        }

        public DataRow ThemDongMoi()
        {
            return m_TrinhDoTinHocData.NewRow();
        }

        public void ThemTrinhDoTinHoc(DataRow m_Row)
        {
            m_TrinhDoTinHocData.Rows.Add(m_Row);
        }

        public bool LuuTrinhDoTinHoc()
        {
            return m_TrinhDoTinHocData.ExecuteNoneQuery() > 0;
        }

    }
}
