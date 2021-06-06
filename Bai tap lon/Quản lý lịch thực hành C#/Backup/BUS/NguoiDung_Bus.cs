using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DAO;
using DTO;

namespace BUS
{
    public class NguoiDung_Bus
    {
        public int GetPermit(string Username)
        {
            NguoiDung_DAO nd_DAO = new NguoiDung_DAO();

            return nd_DAO.GetPermit(Username);
        }
        public DataTable GetDSNguoiDung()
        {
            NguoiDung_DAO nguoidung_DAO = new NguoiDung_DAO();

            return nguoidung_DAO.GetDSNguoiDung();
        }


        public int KTDangNhap(string Username, string Pass)
        {
            NguoiDung_DAO ngdung_DAO = new NguoiDung_DAO();

            return ngdung_DAO.KTDangNhap(Username, Pass);
        }

        public int KTTenDangNhap(string Username)
        {
            NguoiDung_DAO ngdung_DAO = new NguoiDung_DAO();

            return ngdung_DAO.KTTenDangNhap(Username);
        }

        public NguoiDung_DTO GetInfo(string Username, string Pass)
        {
            NguoiDung_DAO ngdung_DAO = new NguoiDung_DAO();

            return ngdung_DAO.GetInfo(Username, Pass);
        }

        public int CapNhatThongTin(NguoiDung_DTO _ndDTO,string oldpass)
        {
            NguoiDung_DAO ngdung_DAO = new NguoiDung_DAO();

            return ngdung_DAO.CapNhatThongTin(_ndDTO, oldpass);
        }

        public int ThemNguoiDung(NguoiDung_DTO _ndDTO)
        {
            NguoiDung_DAO nd_DAO = new NguoiDung_DAO();

            return nd_DAO.ThemNguoiDung(_ndDTO);
        }
    }
}
