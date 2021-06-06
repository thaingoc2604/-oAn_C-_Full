using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;

namespace BUS
{
    public class DonThuocBUS
    {
        public static bool InsertDonThuoc_DonThuocBenhNhanThuong(DonThuocDTO donthuoc, int sttBNT)
        {
            return DonThuocDAO.InsertDonThuoc_DonThuocBenhNhanThuong(donthuoc, sttBNT);
        }

        public static bool InsertDonThuoc_DonThuocBenhNhanNamGiuong_DaXepCho(DonThuocDTO donthuoc, int sttBN_DXC)
        {
            return DonThuocDAO.InsertDonThuoc_DonThuocBenhNhanNamGiuong_DaXepCho(donthuoc, sttBN_DXC);
        }
    }
}
