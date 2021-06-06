using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using DataAccess_Layer;
using DTO;
namespace BUS_Tier
{
    public class bThuVien
    {
        dThuVien objtv = new dThuVien();
        public DataTable get_ThuVien_KetHop()
        {
            return objtv.get_ThuVien_KetHop().Tables["ThuVien"];
        }

        public DataTable get_ThuVien_TimKiem_NangCao( string chuoibosung)
        {
            return objtv.get_ThuVien_TimKiem_NangCao(chuoibosung).Tables["ThuVien"];
        }

        public int delete_question(int mach)
        {
            return objtv.Delete_Question(mach);
        }
    }
}
