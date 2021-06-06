using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using Manager_Fortunes.DaTaService;
namespace Quanlytaisan.Data
{
    public class DaTaDVT
    {
        DataService ds = new DataService();

        public DaTaDVT()
        {

        }

        public DataTable LayDSDonViTinh()
        {
            try
            {
                SqlCommand com = new SqlCommand("Select * from DONVITINH");
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
