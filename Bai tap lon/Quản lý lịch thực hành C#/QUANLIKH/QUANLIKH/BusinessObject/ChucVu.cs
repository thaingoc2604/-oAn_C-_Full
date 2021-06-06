using System;
using System.Collections.Generic;
using System.Text;

namespace QUANLIKH.BusinessObject
{
   public  class ChucVu
    {
        private String  _MACHUCVU;

       public String MACHUCVU
        {
            get { return _MACHUCVU; }
            set { _MACHUCVU = value; }
        }
       private String _TENCHUCVU;

       public String TENCHUCVU
        {
            get { return _TENCHUCVU; }
            set { _TENCHUCVU = value; }
        }
    }
}
