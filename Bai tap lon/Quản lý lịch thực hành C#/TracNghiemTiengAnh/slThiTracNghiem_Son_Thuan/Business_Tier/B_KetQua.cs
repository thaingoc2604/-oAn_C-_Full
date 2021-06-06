using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Entities;
using System.Data;
using System.Data.SqlClient;
using Data_Tier;

namespace Business_Tier
{
   public class B_KetQua
    {

       D_KetQua kq_B = new D_KetQua();

       public int LuuKetQua_B(KetQua kq)
       {
           return kq_B.LuuKetQua(kq);
       }

       public DataTable XemDiem_B(string mathisinh)
       {
           return kq_B.XemDiem_D(mathisinh).Tables[0];
       }

       public DataTable XemDiem_All_B()
       {
           return kq_B.XemDiem_AllD().Tables[0];
       }

    }
}
