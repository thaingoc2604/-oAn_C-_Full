using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace BankManagement
{
    public class dbCn
    {
        string _CnStr;
        SqlConnection _Cn;
        bool _CnStatus;

        #region Constructor
        public dbCn()
        {
            _CnStr = "";
            _Cn = null;
            _CnStatus = false;
        }
        #endregion

        #region Properties
        public SqlConnection Cn
        {
            get { return _Cn; }
        }

        public bool CnStatus
        {
            get { return _CnStatus; }
        }
        #endregion

        public void BuildCnStr(string server, string db, string uid, string pwd)
        {
            _CnStr = string.Format("Server={0};Database={1};UID={2};PWD={3}", server, db, uid, pwd);
        }

        public void BuildCnStr(string server, string db)
        {
            _CnStr = string.Format("Server={0};Database={1};Integrated Security=SSPI", server, db);
        }

        public void Connect()
        {
            if (!_CnStatus)
            {
                _Cn = new SqlConnection(_CnStr);
                try
                {
                    _Cn.Open();
                    _CnStatus = true;
                }
                catch (Exception ex)
                {
                    Program.ShowMsg(ex.Message, true);
                }
                finally
                {
                    _Cn.Close();
                }
            }
        }

        public SqlCommand CreateCommand(string procName)
        {
            SqlCommand cmd = new SqlCommand(procName, _Cn);
            cmd.CommandType = CommandType.StoredProcedure;
            return cmd;
        }

        public void Disconnect()
        {
            if (_CnStatus) _Cn.Close();
        }

        public DataSet LoadData(string procName)
        {
            if (_CnStatus)
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(procName, _Cn);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    return ds;
                }
                catch (Exception ex)
                {
                    Program.ShowMsg(ex.Message, true);
                    return null;
                }
            }
            else return null;
        }

        public DataSet LoadData(string procName,params SqlParameter[] Params)
        {
            if (_CnStatus)
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(procName, _Cn);
                    SqlCommand cmd = da.SelectCommand;
                    cmd.CommandType = CommandType.StoredProcedure;
                    foreach (SqlParameter param in Params) cmd.Parameters.Add(param);

                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    return ds;
                }
                catch (Exception ex)
                {
                    Program.ShowMsg(ex.Message, true);
                    return null;
                }
            }
            else return null;
        }

        public static bool ExecCmd(SqlCommand cmd)
        {
            try
            {
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                Program.ShowMsg(ex.Message, true);
                cmd.Connection.Close();
                return false;
            }
        }
    }
}