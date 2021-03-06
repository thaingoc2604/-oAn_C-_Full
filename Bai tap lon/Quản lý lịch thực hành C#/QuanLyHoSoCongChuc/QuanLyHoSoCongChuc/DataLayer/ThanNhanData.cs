using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using QuanLyHoSoCongChuc.BusinessObject;
namespace QuanLyHoSoCongChuc.DataLayer
{
    public class ThanNhanData
    {
        DataService m_ThanNhanData = new DataService();
        public DataTable LayDanhsachThanNhan()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM ThanNhan");
            m_ThanNhanData.Load(cmd);
            return m_ThanNhanData;
        }


        public DataRow ThemDongMoi()
        {
            return m_ThanNhanData.NewRow();
        }

        public void ThemThanNhan(DataRow m_Row)
        {
            m_ThanNhanData.Rows.Add(m_Row);
        }

        public bool LuuThanNhan()
        {
            return m_ThanNhanData.ExecuteNoneQuery() > 0;
        }




        public DataTable LayTTThanNhan()
        {

            SqlCommand cmd = new SqlCommand();
            string sql = "select tn.MaQuanHe as MaQuanHe, qh.TenQuanHe as TenQuanHe, tn.MaNhanVien as MaNhanVien, tn.TenThanNhan as TenThanNhan, tn.DiaChi as DiaChi, tn.NgheNghiep as NgheNghiep, tn.NamSinh as NamSinh, tn.NuocDinhCu as NuocDinhCu, tn.QuocTich as QuocTich, tn.NamDinhCu as NamDinhCu ";
            sql += "from ThanNhan tn, QuanHe qh ";
            sql += "where tn.MaQuanHe = qh.MaQuanHe";
            cmd.CommandText = sql;
            m_ThanNhanData.Load(cmd);

            return m_ThanNhanData;

        }
      
      
    }
}
