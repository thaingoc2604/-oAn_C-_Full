using System;
using System.Collections.Generic;
using System.Text;
using System.Data;


namespace MDS.BussinessRule
{
    public abstract class clsBBase
    {
        protected string strErrorMsg = "";
        protected int intErrorCode = 0;
        protected string strConnectionstring = "Data Source=.;Initial Catalog=CafeManager;Integrated Security=True";
        protected string strSQLStatement = "";

        public string ErrorMsg
        {
            get
            {
                string returnValue;
                returnValue = strErrorMsg;
                return returnValue;
            }
            set
            {
                strErrorMsg = value;
            }
        }

        // ErrorCode property
        public int ErrorCode
        {
            get
            {
                int returnValue;
                returnValue = intErrorCode;
                return returnValue;
            }
            set
            {
                intErrorCode = value;
            }
        }


        // ConnectionString property
        public string ConnectionString
        {
            get
            {
                string returnValue;
                returnValue = strConnectionstring;
                return returnValue;
            }
            set
            {
                strConnectionstring = value;
            }
        }

        // SQLStatement property
        public string SQLStatement
        {
            get
            {
                return strSQLStatement;
            }
            set
            {
                strSQLStatement = value;
            }
        }


    }
}
