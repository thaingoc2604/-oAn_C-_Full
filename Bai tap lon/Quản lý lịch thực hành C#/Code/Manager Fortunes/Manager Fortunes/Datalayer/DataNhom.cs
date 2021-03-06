using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Manager_Fortunes.DaTaService;

namespace Manager_Fortunes.Datalayer
{
    public class DataNhom
    {
        DaTaService.DataService ds = new Manager_Fortunes.DaTaService.DataService();
        public DataNhom()
        {

        }

        public DataTable LayDSNhomTaiSan()
        {
            try
            {
                SqlCommand com = new SqlCommand("Select * from NHOMTAISAN");
                ds.select(com);
                return ds;

            }
            catch (Exception e)
            {
                MessageBox.Show("Lấy danh sách nhóm tài sản thuê không thành công. " + e.Message, "Thông Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

    }
}
