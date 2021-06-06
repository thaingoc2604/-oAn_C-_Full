using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DAO;
using DTO;

namespace BUS
{
    public class PHIEUCHI_BUS
    {
        public int LapPhieu(PHIEUCHI_DTO phieuchiDTO)
        {
            PHIEUCHI_DAO pt = new PHIEUCHI_DAO();

            return pt.LapPhieu(phieuchiDTO);
        }

        public int getIDMax()
        {
            PHIEUCHI_DAO pt = new PHIEUCHI_DAO();

            return pt.getIDMax();
        } 
    }
}
