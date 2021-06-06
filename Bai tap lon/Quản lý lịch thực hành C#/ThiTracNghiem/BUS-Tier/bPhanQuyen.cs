using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DTO;
using DataAccess_Layer;
using System.Data;
namespace BUS_Tier
{
    public class bPhanQuyen
    {
        dPhanQuyen objpq = new dPhanQuyen();

        public DataTable get_Table_PhanQuyen(string madn, string tendn)
        {
            return objpq.get_Table_PhanQuyen(madn, tendn).Tables["PhanQuyen"];
        }
        public int TaoTaiKhoan(PhanQuyen pq)
        {

           return objpq.TaoTaiKhoan(pq);

        }
        public DataTable KiemTraTaiKhoan(string tentk)
        {
            return objpq.KiemTraTaiKhoan(tentk).Tables["PhanQuyen"];
        }
    }
}
