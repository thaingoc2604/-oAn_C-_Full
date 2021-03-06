using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;

namespace BankManagement
{
    public class AccType
    {
        int _MaLoaiTK;
        string _TenLoaiTK;
        float _LaiSuat;
        int _KyHan;
        string _GhiChu;

        #region Properties
        public int MaLoaiTK
        {
            get { return _MaLoaiTK; }
        }
        #endregion

        public AccType(int nMaLoaiTK, string nTenLoaiTK, float nLaiSuat, int nKyHan, string nGhiChu)
        {
            _MaLoaiTK = nMaLoaiTK;
            _TenLoaiTK = nTenLoaiTK;
            _LaiSuat = nLaiSuat;
            _KyHan = nKyHan;
            _GhiChu = nGhiChu;
        }

        public bool Add(ref string err)
        {
            SqlCommand cmd = Shared.dbConnection.CreateCommand("sp_ThemLoaiTaiKhoan");
            cmd.Parameters.Add("@TenLoaiTK", SqlDbType.NVarChar);
            cmd.Parameters.Add("@LaiSuat", SqlDbType.Float);
            cmd.Parameters.Add("@KyHan", SqlDbType.Int);
            cmd.Parameters.Add("@GhiChu", SqlDbType.NVarChar);
            cmd.Parameters.Add("@MaLoaiTK", SqlDbType.Int).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("@err", SqlDbType.NVarChar).Direction = ParameterDirection.Output;

            cmd.Parameters["@TenLoaiTK"].Value = _TenLoaiTK;
            cmd.Parameters["@LaiSuat"].Value = _LaiSuat;
            cmd.Parameters["@KyHan"].Value = _KyHan;
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
                _MaLoaiTK = int.Parse(cmd.Parameters["@MaLoaiTK"].Value.ToString());
                return true;
            }
            return false;
        }

        public bool Update(ref string err)
        {
            SqlCommand cmd = Shared.dbConnection.CreateCommand("sp_CapNhatLoaiTaiKhoan");
            cmd.Parameters.Add("@MaLoaiTK", SqlDbType.Int);
            cmd.Parameters.Add("@TenLoaiTK", SqlDbType.NVarChar);
            cmd.Parameters.Add("@LaiSuat", SqlDbType.Float);
            cmd.Parameters.Add("@KyHan", SqlDbType.Int);
            cmd.Parameters.Add("@GhiChu", SqlDbType.NVarChar);            
            cmd.Parameters.Add("@err", SqlDbType.NVarChar).Direction = ParameterDirection.Output;

            cmd.Parameters["@MaLoaiTK"].Value = _MaLoaiTK;
            cmd.Parameters["@TenLoaiTK"].Value = _TenLoaiTK;
            cmd.Parameters["@LaiSuat"].Value = _LaiSuat;
            cmd.Parameters["@KyHan"].Value = _KyHan;
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

        public static DataTable LoadAccTypes()
        {
            string proc = "sp_DsLoaiTaiKhoan";
            DataSet ds = Shared.dbConnection.LoadData(proc);
            if (ds != null) return ds.Tables[0];
            return null;
        }

        public static void DelAccType(int typeID)
        {
            SqlCommand cmd = Shared.dbConnection.CreateCommand("sp_XoaLoaiTaiKhoan");
            cmd.Parameters.Add("@MaLoaiTK", SqlDbType.NVarChar).Value = typeID;
            dbCn.ExecCmd(cmd);
        }
    }
}
