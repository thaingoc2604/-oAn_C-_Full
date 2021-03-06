using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
namespace QuanLyHoSoCongChuc.DataLayer
{
    public class TrinhDoChinhTriData
    {
        DataService m_TrinhDoChinhTriData = new DataService();
        // DataService ds = new DataService();
        public DataTable LayDanhSachTrinhDoChinhTri()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM TrinhDoChinhTri");
            m_TrinhDoChinhTriData.Load(cmd);
            return m_TrinhDoChinhTriData;
        }

        public DataRow ThemDongMoi()
        {
            return m_TrinhDoChinhTriData.NewRow();
        }

        public void ThemTrinhDoChinhTri(DataRow m_Row)
        {
            m_TrinhDoChinhTriData.Rows.Add(m_Row);
        }

        public bool LuuTrinhDoChinhTri()
        {
            return m_TrinhDoChinhTriData.ExecuteNoneQuery() > 0;
        }

    }
}
