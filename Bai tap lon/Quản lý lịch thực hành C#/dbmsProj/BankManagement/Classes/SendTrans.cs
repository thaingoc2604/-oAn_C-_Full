using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;

namespace BankManagement
{
    public class SendTrans : Transaction
    {
        string _HoTen;
        string _SoCMND;
        string _DiaChi;
        string _DienThoai;
        string _Email;

        public SendTrans(string nAccNo, DateTime nTransDate, decimal nMoney, string nNote,
            string nHoTen, string nSoCMND, string nDiaChi, string nDienThoai, string nEmail)
            : base(nAccNo, nTransDate, nMoney, nNote)
        {
            _HoTen = nHoTen;
            _SoCMND = nSoCMND;
            _DiaChi = nDiaChi;
            _DienThoai = nDienThoai;
            _Email = nEmail;
        }

        public override string Validate()
        {
            string err = "";
            int i = 1;
            if (_AccNo == "") err += (i++).ToString() + ". Số tài khoản không được rỗng\n";
            if (_HoTen == "") err += (i++).ToString() + ". Tên người gửi không được rỗng\n";
            
            decimal minSend = Shared.allRules.SoTienGuiToiThieu;
            if (_Money < minSend)
                err += string.Format("{0}. Số tiền gửi >= {1:C}\n", i++, minSend);

            return err;
        }

        public bool Add(ref string err)
        {
            SqlCommand cmd = Shared.dbConnection.CreateCommand("sp_GuiTien");
            cmd.Parameters.Add("@SoTaiKhoan", SqlDbType.NVarChar).Value = _AccNo;
            cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = _HoTen;
            cmd.Parameters.Add("@SoCMND", SqlDbType.NVarChar).Value = _SoCMND;
            cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = _DiaChi;
            cmd.Parameters.Add("@DienThoai", SqlDbType.NVarChar).Value = _DienThoai;
            cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = _Email;
            cmd.Parameters.Add("@NgayGui", SqlDbType.DateTime).Value = _TransDate;
            cmd.Parameters.Add("@SoTienGui", SqlDbType.Money).Value = _Money;
            cmd.Parameters.Add("@GhiChu", SqlDbType.NVarChar).Value = _Note;
            cmd.Parameters.Add("@err", SqlDbType.NVarChar).Direction = ParameterDirection.Output;
            cmd.Parameters["@err"].Size = 255;

            if (!dbCn.ExecCmd(cmd))
            {
                err = "Không thực hiện được giao dịch!!!";
                return false;
            }

            err = cmd.Parameters["@err"].Value.ToString();
            if (err != "") return false;
            return true;
        }
    }
}
