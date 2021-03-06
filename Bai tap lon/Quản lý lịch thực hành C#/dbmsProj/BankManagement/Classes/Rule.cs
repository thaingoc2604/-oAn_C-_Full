using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;

namespace BankManagement
{
    public class Rule
    {
        decimal _SoDuTKToiThieu;
        decimal _SoTienGuiToiThieu;
        int _SoLanRutToiDaMotNgay;
        decimal _SoTienRutToiDaMotNgay;
        decimal _SoTienRutToiThieuGD;
        decimal _SoTienRutToiDaGD;
        float _CPCKCungNH;
        float _CPCKKhacNH;
        int _SoNgayGD;

        #region Constructor
        public Rule()
        {
            _SoDuTKToiThieu = 0;
            _SoTienGuiToiThieu = 0;
            _SoLanRutToiDaMotNgay = 0;
            _SoTienRutToiDaMotNgay = 0;
            _SoTienRutToiThieuGD = 0;
            _SoTienRutToiDaGD = 0;
            _CPCKCungNH = 0;
            _CPCKKhacNH = 0;
            _SoNgayGD = 0;

            LoadRules();
        }

        public Rule(decimal nSoDuTKToiThieu, decimal nSoTienGuiToiThieu, int nSoLanRutToiDaMotNgay,
            decimal nSoTienRutToiDaMotNgay,decimal nSoTienRutToiThieuGD,decimal nSoTienRutToiDaGD,
            float nCPCKCungNH,float nCPCKKhacNH,int nSoNgayGD)
        {
            _SoDuTKToiThieu = nSoDuTKToiThieu;
            _SoTienGuiToiThieu = nSoTienGuiToiThieu;
            _SoLanRutToiDaMotNgay = nSoLanRutToiDaMotNgay;
            _SoTienRutToiDaMotNgay = nSoTienRutToiDaMotNgay;
            _SoTienRutToiThieuGD = nSoTienRutToiThieuGD;
            _SoTienRutToiDaGD = nSoTienRutToiDaGD;
            _CPCKCungNH = nCPCKCungNH;
            _CPCKKhacNH = nCPCKKhacNH;
            _SoNgayGD = nSoNgayGD;
        }
        #endregion

        #region Properties
        public decimal SoDuTKToiThieu
        {
            get { return _SoDuTKToiThieu; }
        }

        public decimal SoTienGuiToiThieu
        {
            get { return _SoTienGuiToiThieu; }
        }

        public int SoLanRutToiDaMotNgay
        {
            get { return _SoLanRutToiDaMotNgay; }
        }

        public decimal SoTienRutToiDaMotNgay
        {
            get { return _SoTienRutToiDaMotNgay; }
        }

        public decimal SoTienRutToiThieuGD
        {
            get { return _SoTienRutToiThieuGD; }
        }

        public decimal SoTienRutToiDaGD
        {
            get { return _SoTienRutToiDaGD; }
        }

        public float CPCKCungNH
        {
            get { return _CPCKCungNH; }
        }

        public float CPCKKhacNH
        {
            get { return _CPCKKhacNH; }
        }

        public int SoNgayGD
        {
            get { return _SoNgayGD; }
        }
        #endregion

        private void LoadRules()
        {
            string proc = "sp_LoadRules";
            DataSet ds = Shared.dbConnection.LoadData(proc);
            if (ds != null)
            {
                DataRow row = ds.Tables[0].Rows[0];
                _SoDuTKToiThieu = (decimal)(row[0]);
                _SoTienGuiToiThieu = (decimal)(row[1]);
                _SoLanRutToiDaMotNgay = (int)(row[2]);
                _SoTienRutToiDaMotNgay = (decimal)(row[3]);
                _SoTienRutToiThieuGD = (decimal)(row[4]);
                _SoTienRutToiDaGD = (decimal)(row[5]);
                _CPCKCungNH = float.Parse(row[6].ToString());
                _CPCKKhacNH = float.Parse(row[7].ToString());
                _SoNgayGD = (int)(row[8]);
            }
            else Program.ShowMsg("Không đọc được quy định!!!", true);
        }

        public string Validate()
        {
            string err = "";
            int i = 1;
            if (_SoDuTKToiThieu < 0) err += (i++).ToString() + ". Số dư tài khoản tối thiểu >= 0\n";
            if (_SoTienGuiToiThieu < 0) err += (i++).ToString() + ". Số tiền gửi tối thiểu >= 0\n";
            if (_SoTienRutToiDaMotNgay < 0) err += (i++).ToString() + ". Số tiền rút tối đa 1 ngày >= 0\n";
            if (_SoTienRutToiThieuGD < 0) err += (i++).ToString() + ". Số tiền rút tối tối thiểu 1 giao dịch >= 0\n";
            if (_SoTienRutToiDaGD < 0) err += (i++).ToString() + ". Số tiền rút tối tối đa 1 giao dịch >= 0\n";
            if (_SoTienRutToiDaGD > _SoTienRutToiDaMotNgay) err += (i++).ToString() + ". Số tiền rút tối tối đa 1 giao dịch <= Số tiền rút tối đa 1 ngày\n";
            if (_CPCKCungNH < 0) err += (i++).ToString() + ". Chi phí chuyển khoản cùng ngân hàng >= 0\n";
            if (_CPCKKhacNH < 0) err += (i++).ToString() + ". Chi phí chuyển khoản khác ngân hàng >= 0";
            return err;
        }

        public bool Save()
        {
            SqlCommand cmd = Shared.dbConnection.CreateCommand("sp_SaveRules");
            cmd.Parameters.Add("@SoDuTKToiThieu", SqlDbType.Money).Value = _SoDuTKToiThieu;
            cmd.Parameters.Add("@SoTienGuiToiThieu", SqlDbType.Money).Value = _SoTienGuiToiThieu;
            cmd.Parameters.Add("@SoLanRutToiDaMotNgay", SqlDbType.Int).Value = _SoLanRutToiDaMotNgay;
            cmd.Parameters.Add("@SoTienRutToiDaMotNgay", SqlDbType.Money).Value = _SoTienRutToiDaMotNgay;
            cmd.Parameters.Add("@SoTienRutToiThieuGD", SqlDbType.Money).Value = _SoTienRutToiThieuGD;
            cmd.Parameters.Add("@SoTienRutToiDaGD", SqlDbType.Money).Value = _SoTienRutToiDaGD;
            cmd.Parameters.Add("@CPCKCungNH", SqlDbType.Float).Value = _CPCKCungNH;
            cmd.Parameters.Add("@CPCKKhacNH", SqlDbType.Float).Value = _CPCKKhacNH;
            cmd.Parameters.Add("@SoNgayGD", SqlDbType.Int).Value = _SoNgayGD;
            return dbCn.ExecCmd(cmd);
        }
    }
}
