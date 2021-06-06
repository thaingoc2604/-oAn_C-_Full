using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DTO;
using System.Windows.Forms;

namespace DAO
{
    public class HeThong_DAO: DataProvider
    {
        public void CapNhatCauHinh(HeThong_DTO ht_DTO, string tencty, string tendvchuquan)
        {
            string cn_string="data source=" + ht_DTO.Tenmaychu + ";initial catalog=" + ht_DTO.TenCSDL + ";user id=" + ht_DTO.Tendangnhap + ";password=" + ht_DTO.Matkhau + ";";

            UpdateInfoComp(tencty, tendvchuquan);

            UpdateConnectionString(cn_string);
        }

        public  string LayTenCty()
        {
            return GetTenCy();
        }

        public string LayTenCtyChuQuan()
        {
            return GetTenCyChuQuan();
        }
    }
}
