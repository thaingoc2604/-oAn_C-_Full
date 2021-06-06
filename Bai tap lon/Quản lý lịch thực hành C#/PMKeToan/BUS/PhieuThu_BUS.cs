using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DAO;
using DTO;

namespace BUS
{
    public class PhieuThu_BUS
    {
        public int LapPhieu(PHIEUTHU_DTO phieuthu_DTO)
        {
            PhieuThu_DAO pt = new PhieuThu_DAO( );

            return pt.LapPhieu(phieuthu_DTO);
        }

        public int getIDMax()
        {
            PhieuThu_DAO pt = new PhieuThu_DAO();

            return pt.getIDMax();
        }
    }
}
