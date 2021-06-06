using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using DataAccess_Layer;
using System.Collections;

namespace BUS_Tier
{
    public class bMucDo
    {

        dMucDo objmd = new dMucDo();
        //khai báo các thuộc tính của đối tượng
        //Contructor
        
        public bMucDo()
        { }


        public DataTable get_table_MuDo()
        {
            return objmd.get_All_Table("MucDo").Tables["MucDo"];
        }
        
    }

}
