using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DAO;
using DTO;
namespace BUS
{
    public class HeThong_BUS
    {

        public void CapNhatCauHinh(HeThong_DTO ht_DTO, string tencty, string tendvchuquan)
        {
            HeThong_DAO ht_DAO = new HeThong_DAO();

            ht_DAO.CapNhatCauHinh(ht_DTO,tencty,tendvchuquan);
        }

        public string LayTenCty()
        {
            HeThong_DAO ht_DAO = new HeThong_DAO();

            return ht_DAO.LayTenCty();
        }

        public string LayTenCtyChuQuan()
        {
            HeThong_DAO ht_DAO = new HeThong_DAO();

            return ht_DAO.LayTenCtyChuQuan();
        }
    }
}
