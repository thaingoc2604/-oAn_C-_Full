using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using Manager_Fortunes.DaTaService;

namespace Manager_Fortunes.Datalayer
{
    public class DaTaDiaDiem
    {
        DaTaService.DataService ds = new Manager_Fortunes.DaTaService.DataService();
        public DaTaDiaDiem()
        {

        }

        public DataTable LayDSDiaDiem()
        {
            try
            {
                SqlCommand com = new SqlCommand("Select * from DIADIEM");
                ds.select(com);
                return ds;

            }
            catch (Exception e)
            {
                MessageBox.Show("Lấy danh sách đơn vị tính không thành công. " + e.Message, "Thông Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

    }
}
