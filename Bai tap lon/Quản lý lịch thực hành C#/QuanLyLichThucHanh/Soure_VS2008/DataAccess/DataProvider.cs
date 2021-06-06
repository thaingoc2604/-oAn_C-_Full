using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DTO;
namespace DataAccess
{
    public abstract class DataProvider
    {
        public static DataProvider _Instance = null;
        public static DataProvider Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new SqlDataProvider("ConnectionStringName");
                return _Instance;
            }
        }
        public abstract bool ExecuteNonQuery(string StoneProduce, params object[] value);
        public abstract int NonQuery(string StoneProduce, params object[] value);
        public abstract DataTable ExecuteDataTable(string StoneProduce, params object[] ParamaterValues);
       //public abstract List<Lich_Info> LLich_ExecuteDataReader(string StoneProduce, params object[] values);
        public abstract List<GiaoVien_Info>GiaoVien_ExecuteDataReader(string StoneProduce, params object[] values);
        public abstract List<Lop_Info> Lop_ExecuteDataReader(string StoneProduce, params object[] values);
        public abstract List<ThoiGian_Info> ThoiGian_ExecuteDataReader(string StoneProduce, params object[] values);
        public abstract List<MonHoc_Info> MonHoc_ExecuteDataReader(string StoneProduce, params object[] values);
        public abstract List<LichThu> Lich_ExecuteDataReader(string StoneProduce, params object[] values);
        public abstract List<Phong_Info> Phong_ExecuteDataReader(string StoneProduce, params object[] values);
        public abstract DateTime Ngay_ExecuteDataReader(string StoneProduce, params object[] ParamaterValues);

        //public abstract List<Lich_Info> Lich_ExecuteDataReader(string StoneProduce, params object[]Values);
        //public abstract DataTable LoadLop(string StoneProduce, params object[] ParamaterValues);
        //public DataTable LayLop();
    }  
}
