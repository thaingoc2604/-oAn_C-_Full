using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace BankManagement
{
    public class User
    {
        string _Username;
        string _Password;
        bool _Permit;

        #region Constructor
        public User()
        {
            _Username = "";
            _Password = "";
            _Permit = false;
        }

        public User(string uid, string pwd)
        {
            _Username = uid;
            _Password = pwd;
            _Permit = false;
        }

        public User(string uid, string pwd, bool permit)
        {
            _Username = uid;
            _Password = pwd;
            _Permit = permit;
        }

       
        #endregion

        #region Properties
        public string Username
        {
            get { return _Username; }
        }

        public bool Permit
        {
            get { return _Permit; }
        }

        public string Password
        {
            set { _Password = value; }
        }
        #endregion

        public bool Login()
        {
            SqlCommand cmd = Shared.dbConnection.CreateCommand("sp_Login");
            cmd.Parameters.Add("@UID", SqlDbType.NVarChar);
            cmd.Parameters.Add("@PWD", SqlDbType.NVarChar);
            cmd.Parameters.Add("@rs", SqlDbType.Bit).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("@permit", SqlDbType.Bit).Direction = ParameterDirection.Output;

            cmd.Parameters[0].Value = _Username;
            cmd.Parameters[1].Value = _Password;

            if (!dbCn.ExecCmd(cmd)) return false;

            bool rs = (bool)cmd.Parameters[2].Value;
            if(rs) _Permit = (bool)cmd.Parameters[3].Value;
            cmd.Dispose();

            return rs;
        }

        public bool Add(ref string err)
        {
            string proc = "sp_NewUser";
            SqlCommand cmd = Shared.dbConnection.CreateCommand(proc);
            cmd.Parameters.Add("@UID", SqlDbType.NVarChar).Value = _Username;
            cmd.Parameters.Add("@PWD", SqlDbType.NVarChar).Value = _Password;
            cmd.Parameters.Add("@permit", SqlDbType.Bit).Value = _Permit;
            cmd.Parameters.Add("@err", SqlDbType.NVarChar).Direction = ParameterDirection.Output;
            cmd.Parameters["@err"].Size = 255;

            if (!dbCn.ExecCmd(cmd)) return false;

            err = cmd.Parameters["@err"].Value.ToString();
            if (err == "") return true;
            return false;
        }

        public bool Update()
        {
            SqlCommand cmd = Shared.dbConnection.CreateCommand("sp_EditUser");
            cmd.Parameters.Add("@UID", SqlDbType.NVarChar).Value = _Username;
            cmd.Parameters.Add("@PWD", SqlDbType.NVarChar).Value = _Password;
            cmd.Parameters.Add("@Permit", SqlDbType.Bit).Value = _Permit;
            return dbCn.ExecCmd(cmd);
        }

        public static DataTable LoadUsers()
        {
            string proc = "sp_Users";
            DataSet ds = Shared.dbConnection.LoadData(proc);
            if (ds != null) return ds.Tables[0];
            return null;
        }

        public static void DelUser(string uid)
        {
            SqlCommand cmd = Shared.dbConnection.CreateCommand("sp_DelUser");
            cmd.Parameters.Add("@UID", SqlDbType.NVarChar).Value = uid;
            dbCn.ExecCmd(cmd);
        }
    }
}
