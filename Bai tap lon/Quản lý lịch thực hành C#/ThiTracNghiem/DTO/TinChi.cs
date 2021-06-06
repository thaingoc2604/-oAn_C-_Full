using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class TinChi
    {
        public string TenTinChi { get; set; }
        public TinChi()
        { }

        public TinChi(string tentinchi)
        {
            TenTinChi = tentinchi;
        }
    }
}
