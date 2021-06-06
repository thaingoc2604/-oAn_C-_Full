using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class LichHocTuan
    {
        public DateTime Ngay = new DateTime();
        public List<LichThu> T2 = new List<LichThu>();
        public List<LichThu> T3 = new List<LichThu>();
        public List<LichThu> T4 = new List<LichThu>();
        public List<LichThu> T5 = new List<LichThu>();
        public List<LichThu> T6 = new List<LichThu>();
        public List<LichThu> T7 = new List<LichThu>();
        public List<LichThu> CN = new List<LichThu>();
        public LichHocTuan() { }
    }
}
