using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using System.Data;

namespace DETAI
{
    class clsdt:clsdm1 
    {
        private int MaDT;
        private string TenDT;

        public int maDT
        {
            get { return MaDT; }
            set { MaDT = value; }
        }
        public string tenDT
        {
            get { return TenDT; }
            set { TenDT = value; }
        }
        public clsdt()
        {
            MaDT=0;
            TenDT="";
        }
        public clsdt(int ma, string ten)
        {
            MaDT = ma;
            TenDT = ten;
        }
    }
}
