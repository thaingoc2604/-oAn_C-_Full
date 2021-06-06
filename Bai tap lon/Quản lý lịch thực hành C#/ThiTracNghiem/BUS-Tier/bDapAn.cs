using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using DataAccess_Layer;

namespace BUS_Tier
{
    public class bDapAn
    {
        dDapAn objda = new dDapAn();
        public bDapAn()
        { }
        public DataTable get_table_DapAn()
        {
            return objda.SelectFrom("DapAn").Tables["DapAn"];
        }
    }
}
