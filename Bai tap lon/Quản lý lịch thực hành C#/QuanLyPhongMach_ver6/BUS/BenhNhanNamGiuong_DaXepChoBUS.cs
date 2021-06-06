using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;
using DAO;

namespace BUS
{
    public class BenhNhanNamGiuong_DaXepChoBUS
    {
        public static bool InsertBenhNhanNamGiuong_DaXepCho(BenhNhanNamGiuong_DaXepChoDTO benhnhan_daxepcho)
        {
            return BenhNhanNamGiuong_DaXepChoDAO.InsertBenhNhanNamGiuong_DaXepCho(benhnhan_daxepcho);
        }

        public static DataTable SelectAllGiuongBenh_CoBenhNhan()
        {
            return BenhNhanNamGiuong_DaXepChoDAO.SelectAllGiuongBenh_CoBenhNhan();
        }

        public static bool DeleteBenhNhanNamGiuong_DaXepCho(BenhNhanNamGiuong_DaXepChoDTO benhnhan_DaXepCho)
        {
            return BenhNhanNamGiuong_DaXepChoDAO.DeleteBenhNhanNamGiuong_DaXepCho(benhnhan_DaXepCho);
        }

        public static List<BenhNhanNamGiuong_DaXepChoDTO> SelectAllBenhNhanNamGiuong_DaXepCho()
        {
            return BenhNhanNamGiuong_DaXepChoDAO.SelectAllBenhNhanNamGiuong_DaXepCho();
        }
    }    
}
