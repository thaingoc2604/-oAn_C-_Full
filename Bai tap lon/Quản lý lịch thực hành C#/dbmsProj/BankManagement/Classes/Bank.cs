using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;

namespace BankManagement
{
    public class Bank
    {
        int _MaNganHang;
        string _TenNganHang;
        string _GhiChu;

        #region Properties 
        public int MaNganHang
        {
            get { return _MaNganHang; }
        }
        #endregion

        public Bank(int nMaNganHang, string nTenNganHang, string nGhiChu)
        {
            _MaNganHang = nMaNganHang;
            _TenNganHang = nTenNganHang;
            _GhiChu = nGhiChu;
        }

        public bool Add(ref string err)
        {
            SqlCommand cmd = Shared.dbConnection.CreateCommand("sp_ThemNganHang");
            cmd.Parameters.Add("@TenNganHang", SqlDbType.NVarChar);
            cmd.Parameters.Add("@GhiChu", SqlDbType.NVarChar);
            cmd.Parameters.Add("@MaNganHang", SqlDbType.Int).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("@err", SqlDbType.NVarChar).Direction = ParameterDirection.Output;

            cmd.Parameters["@TenNganHang"].Value = _TenNganHang;
            cmd.Parameters["@GhiChu"].Value = _GhiChu;
            cmd.Parameters["@err"].Size = 255;

            if (!dbCn.ExecCmd(cmd))
            {
                err = "Không thêm được!!!";
                return false;
            }
            err = cmd.Parameters["@err"].Value.ToString();
            if (err == "")
            {
                _MaNganHang = int.Parse(cmd.Parameters["@MaNganHang"].Value.ToString());
                return true;
            }
            return false;
        }

        public bool Update(ref string err)
        {
            string proc = "sp_CapNhatNganHang";
            SqlCommand cmd = Shared.dbConnection.CreateCommand(proc);
            cmd.Parameters.Add("@MaNganHang", SqlDbType.Int);
            cmd.Parameters.Add("@TenNganHang", SqlDbType.NVarChar);
            cmd.Parameters.Add("@GhiChu", SqlDbType.NVarChar);
            cmd.Parameters.Add("@err", SqlDbType.NVarChar).Direction = ParameterDirection.Output;

            cmd.Parameters["@MaNganHang"].Value = _MaNganHang;
            cmd.Parameters["@TenNganHang"].Value = _TenNganHang;
            cmd.Parameters["@GhiChu"].Value = _GhiChu;
            cmd.Parameters["@err"].Size = 255;
            
            if (!dbCn.ExecCmd(cmd))
            {
                err = "Không cập nhật được!!!";
                return false;
            }
            err = cmd.Parameters["@err"].Value.ToString();
            if (err == "") return true;
            return false;
        }

        public static DataTable LoadBanks()
        {
            string proc = "sp_DsNganHang";
            DataSet ds = Shared.dbConnection.LoadData(proc);
            if (ds != null) return ds.Tables[0];
            return null;
        }

        public static void DelBank(int BankID)
        {
            SqlCommand cmd = Shared.dbConnection.CreateCommand("sp_XoaNganHang");
            cmd.Parameters.Add("@MaNganHang",SqlDbType.Int).Value = BankID;
            dbCn.ExecCmd(cmd);
        }
    }
}
