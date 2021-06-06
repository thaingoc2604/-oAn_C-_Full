using System;
using System.Collections.Generic;
using System.Text;

namespace BankManagement
{
    public class Shared
    {
        static dbCn _dbConnection = null;
        static User _CurrentUser = null;
        static Rule _allRules = null;

        public static dbCn dbConnection
        {
            get { return _dbConnection; }
            set { _dbConnection = value; }
        }

        public static User CurrentUser
        {
            get { return _CurrentUser; }
            set { _CurrentUser = value; }
        }

        public static Rule allRules
        {
            get { return _allRules; }
            set { _allRules = value; }
        }
    }
}
