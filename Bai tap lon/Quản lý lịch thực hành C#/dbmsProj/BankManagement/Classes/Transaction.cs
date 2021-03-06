using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;

namespace BankManagement
{
    public class Transaction
    {
        protected string _AccNo;
        protected DateTime _TransDate;
        protected decimal _Money;
        protected string _Note;

        public Transaction(string nAccNo, DateTime nTransDate, decimal nMoney, string nNote)
        {
            _AccNo = nAccNo;
            _TransDate = nTransDate;
            _Money = nMoney;
            _Note = nNote;
        }

        public virtual string Validate()
        {
            Rule r = Shared.allRules;
            if (_Money < r.SoTienRutToiThieuGD || _Money > r.SoTienRutToiDaGD)
            {
                string err = string.Format("{0:C} < Số tiền rút < {1:C}", r.SoTienRutToiThieuGD, r.SoTienRutToiDaGD);
                return err;
            }
            return "";
        }

        public virtual bool Add(ref string err, bool Limited)
        {
            if (Limited)
            {
                string proc = "sp_RutTienCKH";
                SqlCommand cmd = Shared.dbConnection.CreateCommand(proc);
                cmd.Parameters.Add("@SoTaiKhoan", SqlDbType.NVarChar).Value = _AccNo;
                cmd.Parameters.Add("@NgayRut", SqlDbType.DateTime).Value = _TransDate;
                cmd.Parameters.Add("@GhiChu", SqlDbType.NVarChar).Value = _Note;
                cmd.Parameters.Add("@SoLanDaoHan", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@TienLai", SqlDbType.Money).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@SoTienRut", SqlDbType.Money).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@err", SqlDbType.NVarChar).Direction = ParameterDirection.Output;
                cmd.Parameters["@err"].Size = 255;

                if (!dbCn.ExecCmd(cmd))
                {
                    err = "Không thực hiện được giao dịch!!!";
                    return false;
                }

                err = cmd.Parameters["@err"].Value.ToString();
                if (err == "")
                {
                    int SoLanDaoHan = (int)cmd.Parameters["@SoLanDaoHan"].Value;
                    decimal TienLai = (decimal)cmd.Parameters["@TienLai"].Value;
                    decimal SoTienRut = (decimal)cmd.Parameters["@SoTienRut"].Value;
                    string msg = "Số tài khoản: " + _AccNo + "\n";
                    msg += "Số lần đáo hạn: " + SoLanDaoHan.ToString() + "\n";
                    msg += string.Format("Tiền lãi: {0:C}\n", TienLai);
                    msg += string.Format("Đã rút: {0:C}\n", SoTienRut);
                    msg += "Tài khoản đã được đóng.";
                    Program.ShowMsg(msg);
                    return true;
                }
                return false;
            }
            else
            {
                string proc = "sp_RutTienKKH";
                SqlCommand cmd = Shared.dbConnection.CreateCommand(proc);
                cmd.Parameters.Add("@SoTaiKhoan", SqlDbType.NVarChar).Value = _AccNo;
                cmd.Parameters.Add("@SoTienRut", SqlDbType.Money).Value = _Money;
                cmd.Parameters.Add("@NgayRut", SqlDbType.DateTime).Value = _TransDate;
                cmd.Parameters.Add("@GhiChu", SqlDbType.NVarChar).Value = _Note;
                cmd.Parameters.Add("@err", SqlDbType.NVarChar).Direction = ParameterDirection.Output;
                cmd.Parameters["@err"].Size = 255;

                if (!dbCn.ExecCmd(cmd))
                {
                    err = "Không thực hiện được giao dịch!!!";
                    return false;
                }

                err = cmd.Parameters["@err"].Value.ToString();
                if (err == "") return true;
                return false;
            }
        }
    }
}