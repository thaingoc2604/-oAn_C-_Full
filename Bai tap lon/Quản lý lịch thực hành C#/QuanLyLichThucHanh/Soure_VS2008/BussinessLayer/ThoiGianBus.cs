using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
namespace BussinessLayer
{
    public class ThoiGianBus
    {
        public static List<ThoiGian_Info> GetAll_ThoiGian()
        {
            try
            {
                return DataAccess.DataProvider.Instance.ThoiGian_ExecuteDataReader("GetAll_ThoiGian");
            }
            catch
            {
                return null;
            }
        }
    }
}
