using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
namespace BussinessLayer
{
    public  class MonHocBus
    {
        public static List<MonHoc_Info> GetAll_MonHoc()
        {
            try
            {
                return DataAccess.DataProvider.Instance.MonHoc_ExecuteDataReader("GetAll_MonHoc");
            }
            catch
            {
                return null;
            }
        }
    }
}
