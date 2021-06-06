using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class DapAn
    {
        public string TenDapAn { get; set; }
        public DapAn()
        { }

        public DapAn(string tendapan)
        {
            TenDapAn = tendapan;
        }
    }
}
