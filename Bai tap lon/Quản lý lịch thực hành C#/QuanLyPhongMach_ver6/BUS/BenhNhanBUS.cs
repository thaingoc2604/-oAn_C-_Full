using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using DTO;

namespace BUS
{
    public class BenhNhanBUS
    {
        public static bool Insert_BenhNhanThuong(BenhNhanDTO benhnhan)
        {
            return BenhNhanDAO.Insert_BenhNhanThuong(benhnhan);
        }

        public static bool Insert_BenhNhanNamVien(BenhNhanDTO benhnhan)
        {
            return BenhNhanDAO.Insert_BenhNhanNamVien(benhnhan);
        }

        public static List<BenhNhanDTO> SelectAllBenhNhanNamGiuong_ChuaXepCho()
        {
            return BenhNhanDAO.SelectAllBenhNhanNamGiuong_ChuaXepCho();
        }

        public static List<BenhNhanDTO> SelectAllBenhNhan()
        {
            return BenhNhanDAO.SelectAllBenhNhan();
        }

        public static List<BenhNhanDTO> SelectBenhNhanByHoTen(string hoten)
        {
            return BenhNhanDAO.SelectBenhNhanByHoTen(hoten);
        }

        public static List<BenhNhanDTO> SelectAllBenhNhanByBacSiDieuTri(int sttBS)
        {
            return BenhNhanDAO.SelectAllBenhNhanByBacSiDieuTri(sttBS);
        }

        public static List<BenhNhanDTO> SelectAllBenhNhanByBacSiAndGioiTinh(int sttBS, string gioitinh)
        {
            return BenhNhanDAO.SelectAllBenhNhanByBacSiAndGioiTinh(sttBS, gioitinh);
        }

        public static bool UpdateBenhNhan(BenhNhanDTO benhnhan)
        {
            return BenhNhanDAO.UpdateBenhNhan(benhnhan);
        }
    }
}
