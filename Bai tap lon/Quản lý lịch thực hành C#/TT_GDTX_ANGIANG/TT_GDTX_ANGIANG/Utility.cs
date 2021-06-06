using System;
using System.Collections.Generic;
using System.Text;
using TT_GDTX_ANGIANG.BusinessObject;

namespace TT_GDTX_ANGIANG
{
    public class Utility
    {
        public static NguoiDungInfo NGUOIDUNG;
        public static bool IsNumberric(String str)
        {
            try
            {
                long n = Convert.ToInt64(str);
                if (n < 0)
                {
                    return false;
                }
                else
                    return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool IsNum(String str)
        {
            try
            {
                decimal n = Convert.ToDecimal(str);
                if (n < 0)
                {
                    return false;
                }
                else
                    return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
