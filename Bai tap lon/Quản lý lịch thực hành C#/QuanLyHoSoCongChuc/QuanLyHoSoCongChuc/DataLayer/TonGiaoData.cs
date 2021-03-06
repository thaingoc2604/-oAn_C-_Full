using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
namespace QuanLyHoSoCongChuc.DataLayer
{
    public class TonGiaoData
    {
        DataService m_TonGiaoData = new DataService();
        // DataService ds = new DataService();
        public DataTable LayDanhSachTonGiao()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM TonGiao");
            m_TonGiaoData.Load(cmd);
            return m_TonGiaoData;
        }

        public DataRow ThemDongMoi()
        {
            return m_TonGiaoData.NewRow();
        }

        public void ThemTonGiao(DataRow m_Row)
        {
            m_TonGiaoData.Rows.Add(m_Row);
        }

        public bool LuuTonGiao()
        {
            return m_TonGiaoData.ExecuteNoneQuery() > 0;
        }

    }
}
