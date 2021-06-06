using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class NguoiDung_DTO
    {
        string _fullname;

        public string Fullname
        {
            get { return _fullname; }
            set { _fullname = value; }
        }
        string _username;

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }
        string _pass;

        public string Pass
        {
            get { return _pass; }
            set { _pass = value; }
        }

        int _IsAdmin;

        public int IsAdmin
        {
            get { return _IsAdmin; }
            set { _IsAdmin = value; }
        }
    }
}
