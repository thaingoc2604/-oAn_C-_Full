using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using DataAccess_Layer;
namespace BUS_Tier
{
    public class bTinChi
    {

        dTinChi objtc = new dTinChi();


        //Constructor
        public bTinChi()
        { }

        public DataTable get_table_TinChi()
        {
            return objtc.get_All_Table("TinChi").Tables["TinChi"];
        }
    }
}
