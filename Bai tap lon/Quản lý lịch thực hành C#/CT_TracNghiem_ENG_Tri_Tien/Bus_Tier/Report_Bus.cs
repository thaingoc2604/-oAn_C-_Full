using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Data_Tier; 
namespace Bus_Tier
{
    public class Report_Bus
    {
        Report_Data re;
        public DataSet Show_ThongTin_Report(String id)
        {
            re = new Report_Data();
            return re.Show_ThongTin_Report(id);
        }
        public DataSet Report_DeThi(String made)
        {
            re = new Report_Data();
            return re.Report_DeThi(made);
        }
    }
}
