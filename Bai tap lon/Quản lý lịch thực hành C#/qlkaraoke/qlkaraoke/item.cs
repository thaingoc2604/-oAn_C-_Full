using System;
using System.Collections.Generic;
using System.Text;

namespace qlkaraoke
{
    class item
    {
        public string sName;
        public int iID;

        public item()
        {
            sName = "";
            iID = 0;
        }

        public item(string Name, int ID)
        {
            sName = Name;
            iID = ID;
        }

        public string Name
        {
            get
            {
                return sName;
            }
            set
            {
                sName = value;
            }
        }

        public int ItemData
        {
            get
            {
                return iID;
            }

            set
            {
                iID = value;
            }
        }

        public override string ToString()
        {
            return sName;
        }

    }
}