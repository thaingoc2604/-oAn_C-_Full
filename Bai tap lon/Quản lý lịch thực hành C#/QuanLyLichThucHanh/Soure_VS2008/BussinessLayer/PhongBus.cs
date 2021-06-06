using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
namespace BussinessLayer
{
    public class PhongBus
    {
        public static List<Phong_Info> GetAll_Phong()
       {
           try
           {
               return DataAccess.DataProvider.Instance.Phong_ExecuteDataReader("GetAll_Phong");
           }
           catch { return null;  }
        }
        
    }
}
