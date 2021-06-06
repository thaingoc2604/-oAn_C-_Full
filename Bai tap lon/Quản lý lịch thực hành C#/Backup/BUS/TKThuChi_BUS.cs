using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DAO;
using DTO;

namespace BUS
{
    public class TKThuChi_BUS
    {

        public DataTable GetDSTK_PhieuDaHuy()
        {
            DataTable kq = new DataTable();
            TK_ThuChiDAO tk = new TK_ThuChiDAO();
            kq = tk.GetDSTK_PhieuDaHuy();
            return kq;
        }

        public int Khoi_Phuc_Phieu(TKThuChi_DTO tk_DTO)
        {
            TK_ThuChiDAO tk_DAO = new TK_ThuChiDAO();

            return tk_DAO.Khoi_Phuc_Phieu(tk_DTO);
        }

        public int Kiem_Tra_Ma_Phieu_Chi(int maphieuchi)
        {
            TK_ThuChiDAO tk_DAO = new TK_ThuChiDAO();

            return tk_DAO.Kiem_Tra_Ma_Phieu_Chi(maphieuchi);
        }

        public int Kiem_Tra_Ma_Phieu_Thu(int maphieuthu)
        {
            TK_ThuChiDAO tk_DAO = new TK_ThuChiDAO();

            return tk_DAO.Kiem_Tra_Ma_Phieu_Thu(maphieuthu);
        }

         public int Cap_nhat_Phieu(TKThuChi_DTO tk_DTO)
        {
            TK_ThuChiDAO tk_DAO = new TK_ThuChiDAO();

            return tk_DAO.Cap_nhat_Phieu(tk_DTO);
        }

        public int Cap_nhat_Phieu_Thu(TKThuChi_DTO tk_DTO)
        {
            TK_ThuChiDAO tk_DAO = new TK_ThuChiDAO();

            return tk_DAO.Cap_nhat_Phieu_Thu(tk_DTO);
        }

        public int Cap_nhat_Phieu_Chi(TKThuChi_DTO tk_DTO)
        {
            TK_ThuChiDAO tk_DAO = new TK_ThuChiDAO();

            return tk_DAO.Cap_nhat_Phieu_Chi(tk_DTO);
        }

        public int Huy_Phieu(TKThuChi_DTO tk_DTO)
        {
            TK_ThuChiDAO tk_DAO = new TK_ThuChiDAO();

            return tk_DAO.Huy_Phieu(tk_DTO);
        }

        public DataTable LayDanhSachSPExel(string path)
        {
            DataTable kq = new DataTable();

            TK_ThuChiDAO tk_dao = new TK_ThuChiDAO();

            kq = tk_dao.LayDanhSachSPExel(path);

            return kq;
        }

        public DataTable PhatsinhTrongKy (string ngaybd,string ngaykt)
        {
            TK_ThuChiDAO tk = new TK_ThuChiDAO();

            return tk.PhatsinhTrongKy(ngaybd, ngaykt);
        }
        public int KT_PhatSinh(DateTime ngaythang)
        {
            TK_ThuChiDAO pt = new TK_ThuChiDAO();

            return pt.KT_PhatSinh(ngaythang);
        }

        public DataTable GetDSTK_ThuChi()
        {
            DataTable kq = new DataTable();
            TK_ThuChiDAO tk = new TK_ThuChiDAO();
            kq=tk.GetDSTK_ThuChi();
            return kq;
        }

        public DataTable GetDSTK_ThuChi_TheoNgay(DateTime ngaythang)
        {
            DataTable kq = new DataTable();
            TK_ThuChiDAO tk = new TK_ThuChiDAO();
            kq = tk.GetDSTK_ThuChi_TheoNgay(ngaythang);
            return kq;
        }

        public DataTable GetDSTK_ThuChi_TheoThang(DateTime ngaythang)
        {
            DataTable kq = new DataTable();
            TK_ThuChiDAO tk = new TK_ThuChiDAO();
            kq = tk.GetDSTK_ThuChi_TheoThang(ngaythang);
            return kq;
        }
        public DataTable GetDSTK_ThuChi_TheoGiaiDoan(DateTime ngaybd, DateTime ngaykt)
        {
            DataTable kq = new DataTable();
            TK_ThuChiDAO tk = new TK_ThuChiDAO();
            kq = tk.GetDSTK_ThuChi_TheoGiaiDoan(ngaybd,ngaykt);
            return kq;
        }

        public void Cap_Nhat_SO_Ton_Phieu_Thu(int maphieuthu, Int64 sodu)
        {
            TK_ThuChiDAO tk_Dao = new TK_ThuChiDAO();

            tk_Dao.Cap_Nhat_SO_Ton_Phieu_Thu(maphieuthu, sodu);
        }

        public void Cap_Nhat_SO_Ton_Phieu_Chi(int maphieuchi, Int64 sodu)
        {
            TK_ThuChiDAO tk_Dao = new TK_ThuChiDAO();

            tk_Dao.Cap_Nhat_SO_Ton_Phieu_Chi(maphieuchi, sodu);
        }
    }
}
