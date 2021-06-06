using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;

namespace BUS
{
    public class BenhNhanThuongBUS
    {
        public static List<BenhNhanThuongDTO> SelectAllBenhNhanThuong()
        {
            return BenhNhanThuongDAO.SelectAllBenhNhanThuong();
        }
    }
}
