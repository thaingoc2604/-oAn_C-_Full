using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DTO;


namespace DAO
{
    public class Nhom_DAO: DataProvider
    {
        public DataTable DSNhom()
        {
            DataTable kq = new DataTable();

            kq = LoadData("sp_Get_dsNhom");

            DisConnect();

            return kq;
        }
    }
}
