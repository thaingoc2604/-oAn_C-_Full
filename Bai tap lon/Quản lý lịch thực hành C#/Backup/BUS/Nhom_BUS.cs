using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DAO;
using DTO;

namespace BUS
{
    public class Nhom_BUS
    {
        public DataTable DSNhom()
        {
            Nhom_DAO nhom_DAO = new Nhom_DAO();

            return nhom_DAO.DSNhom();
        }
    }
}
