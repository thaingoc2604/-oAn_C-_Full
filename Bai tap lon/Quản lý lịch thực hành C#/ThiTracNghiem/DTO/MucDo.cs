using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class MucDo
    {
          public string tenmucdo = "";

        #region Set and Get
        public string tenmd
        {
            get { return tenmucdo; }
            set { tenmucdo = value; }
        }
        #endregion

        //Contructor

        public MucDo()
        { }
        public MucDo(string tenmd)
        {
            tenmucdo = tenmd;
        }
    }
}
