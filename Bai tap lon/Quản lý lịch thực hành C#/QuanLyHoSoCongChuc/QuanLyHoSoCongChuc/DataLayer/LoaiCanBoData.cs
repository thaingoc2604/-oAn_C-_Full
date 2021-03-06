using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
namespace QuanLyHoSoCongChuc.DataLayer
{
    public class LoaiCanBoData
    {
        DataService m_LoaiCanBoData = new DataService();
        // DataService ds = new DataService();
        public DataTable LayDsLoaiCanBo()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM LoaiCanBo");
            m_LoaiCanBoData.Load(cmd);
            return m_LoaiCanBoData;
        }

        public DataRow ThemDongMoi()
        {
            return m_LoaiCanBoData.NewRow();
        }

        public void ThemLoaiCanBo(DataRow m_Row)
        {
            m_LoaiCanBoData.Rows.Add(m_Row);
        }

        public bool LuuLoaiCanBo()
        {
            return m_LoaiCanBoData.ExecuteNoneQuery() > 0;
        }

    }
}
