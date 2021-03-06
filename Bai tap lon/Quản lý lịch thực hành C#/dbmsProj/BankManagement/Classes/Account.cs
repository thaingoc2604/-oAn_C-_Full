using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;

namespace BankManagement
{
    public class Account
    {
        string _SoTaiKhoan, _PinCode, _HoTen, _SoCMND, _DiaChi, _DienThoai, _Email;
        DateTime _NgayMo, _NgayDaoHan;
        int _MaLoaiTK, _MaNganHang;
        decimal _SoDuTK;
        bool _DaDong;
        string _GhiChu;

        #region Properties
        public string SoTaiKhoan
        {
            get { return _SoTaiKhoan; }
        }

        public string PinCode
        {
            get { return _PinCode; }
        }

        public string HoTen
        {
            get { return _HoTen; }
            set { _HoTen = value; }
        }

        public string SoCMND
        {
            get { return _SoCMND; }
            set { _SoCMND = value; }
        }

        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }

        public string DienThoai
        {
            get { return _DienThoai; }
            set { _DienThoai = value; }
        }

        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        public DateTime NgayMo
        {
            get { return _NgayMo; }
        }

        public DateTime NgayDaoHan
        {
            get { return _NgayDaoHan; }
        }

        public int MaLoaiTK
        {
            get { return _MaLoaiTK; }
        }

        public int MaNganHang
        {
            get { return _MaNganHang; }
        }

        public decimal SoDuTK
        {
            get { return _SoDuTK; }
        }

        public bool DaDong
        {
            get { return _DaDong; }
        }

        public string GhiChu
        {
            get { return _GhiChu; }
            set { _GhiChu = value; }
        }

        public string Info
        {
            get
            {
                string info = "Số tài khoản: " + _SoTaiKhoan + "\n";
                info += "PIN: " + _PinCode;
                if(_NgayDaoHan != new DateTime(1,1,1))
                    info += "\nNgày đáo hạn: " + _NgayDaoHan.ToShortDateString();
                return info;
            }
        }
        #endregion      

        #region Constructor
        public Account(string nSoTaiKhoan, string nPinCode)
        {
            _SoTaiKhoan = nSoTaiKhoan;
            _PinCode = nPinCode;
        }

        public Account(string nHoTen, string nSoCMND, string nDiaChi, string nDienThoai,
            string nEmail, DateTime nNgayMo, int nMaLoaiTK, int nMaNganHang, decimal nSoDuTK,
            string nGhiChu)
        {
            _SoTaiKhoan = "";
            _PinCode = "";
            _HoTen = nHoTen;
            _SoCMND = nSoCMND;
            _DiaChi = nDiaChi;
            _DienThoai = nDienThoai;
            _Email = nEmail;
            _NgayMo = nNgayMo;
            _MaLoaiTK = nMaLoaiTK;
            _MaNganHang = nMaNganHang;
            _SoDuTK = nSoDuTK;
            _DaDong = false;
            _GhiChu = nGhiChu;
        }

        public Account(string nSoTaiKhoan, string nPinCode, string nHoTen, string nSoCMND,
            string nDiaChi, string nDienThoai, string nEmail, DateTime nNgayMo, DateTime nNgayDaoHan,
            int nMaLoaiTK, int nMaNganHang, decimal nSoDuTK, bool nDaDong, string nGhiChu)
        {
            _SoTaiKhoan = nSoTaiKhoan;
            _PinCode = nPinCode;
            _HoTen = nHoTen;
            _SoCMND = nSoCMND;
            _DiaChi = nDiaChi;
            _DienThoai = nDienThoai;
            _Email = nEmail;
            _NgayMo = nNgayMo;
            _NgayDaoHan = nNgayDaoHan;
            _MaLoaiTK = nMaLoaiTK;
            _MaNganHang = nMaNganHang;
            _SoDuTK = nSoDuTK;
            _DaDong = nDaDong;
            _GhiChu = nGhiChu;
        }
        #endregion

        private void GeneratePin()
        {
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                int val = rnd.Next(0, 9);
                _PinCode += val.ToString();
            }
        }

        public string Validate()
        {
            int i = 1;
            string err = "";
            if (_HoTen == "") err += (i++).ToString() + ". Họ tên rỗng\n";
            if (_SoCMND == "") err += (i++).ToString() + ". Số CMND rỗng\n";
            if (_DiaChi == "") err += (i++).ToString() + ". Địa chỉ rỗng";
            return err;
        }

        public bool Add(ref string err)
        {
            this.GeneratePin();

            SqlCommand cmd = Shared.dbConnection.CreateCommand("sp_MoTaiKhoan");
            cmd.Parameters.Add("@SoTaiKhoan", SqlDbType.NVarChar).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("@PinCode", SqlDbType.NVarChar);
            cmd.Parameters.Add("@MaLoaiTK", SqlDbType.Int);
            cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar);
            cmd.Parameters.Add("@SoCMND", SqlDbType.NVarChar);
            cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar);
            cmd.Parameters.Add("@DienThoai", SqlDbType.NVarChar);
            cmd.Parameters.Add("@Email", SqlDbType.NVarChar);
            cmd.Parameters.Add("@NgayMo", SqlDbType.DateTime);
            cmd.Parameters.Add("@MaNganHang", SqlDbType.Int);
            cmd.Parameters.Add("@SoTienGui", SqlDbType.Money);
            cmd.Parameters.Add("@GhiChu", SqlDbType.NVarChar);
            cmd.Parameters.Add("@NgayDaoHan", SqlDbType.DateTime).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("@err", SqlDbType.NVarChar).Direction = ParameterDirection.Output;

            cmd.Parameters["@SoTaiKhoan"].Size = 10;
            cmd.Parameters["@PinCode"].Value = _PinCode;
            cmd.Parameters["@MaLoaiTK"].Value = _MaLoaiTK;
            cmd.Parameters["@HoTen"].Value = _HoTen;
            cmd.Parameters["@SoCMND"].Value = _SoCMND;
            cmd.Parameters["@DiaChi"].Value = _DiaChi;
            cmd.Parameters["@DienThoai"].Value = _DienThoai;
            cmd.Parameters["@Email"].Value = _Email;
            cmd.Parameters["@NgayMo"].Value = _NgayMo;
            cmd.Parameters["@MaNganHang"].Value = _MaNganHang;
            cmd.Parameters["@SoTienGui"].Value = _SoDuTK;
            cmd.Parameters["@GhiChu"].Value = _GhiChu;
            cmd.Parameters["@err"].Size = 255;

            if (!dbCn.ExecCmd(cmd))
            {
                err = "Không thể mở tài khoản!!!";
                return false;
            }

            err = cmd.Parameters["@err"].Value.ToString();
            if (err == "")
            {
                _SoTaiKhoan = cmd.Parameters["@SoTaiKhoan"].Value.ToString();
                object obj = cmd.Parameters["@NgayDaoHan"].Value;
                try { _NgayDaoHan = (DateTime)obj; }
                catch { }
                return true;
            }
            return false;
        }

        public bool Update()
        {
            SqlCommand cmd = Shared.dbConnection.CreateCommand("sp_CapNhatTaiKhoan");
            cmd.Parameters.Add("@SoTaiKhoan", SqlDbType.NVarChar).Value = _SoTaiKhoan;
            cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = _HoTen;
            cmd.Parameters.Add("@SoCMND", SqlDbType.NVarChar).Value = _SoCMND;
            cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = _DiaChi;
            cmd.Parameters.Add("@DienThoai", SqlDbType.NVarChar).Value = _DienThoai;
            cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = _Email;
            cmd.Parameters.Add("@GhiChu", SqlDbType.NVarChar).Value = _GhiChu;
            return dbCn.ExecCmd(cmd);
        }

        public string GetAccInfo()
        {
            string proc = "sp_AccInfo";
            SqlParameter pSoTaiKhoan = new SqlParameter("@SoTaiKhoan", SqlDbType.NVarChar);
            pSoTaiKhoan.Value = _SoTaiKhoan;

            DataSet ds = Shared.dbConnection.LoadData(proc, pSoTaiKhoan);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow row = ds.Tables[0].Rows[0];
                _HoTen = row["HoTen"].ToString();
                _DiaChi = row["DiaChi"].ToString();

                string msg = "";
                msg += string.Format("Số tài khoản: {0}\n", _SoTaiKhoan);
                msg += string.Format("Chủ tài khoản: {0}\n", _HoTen);
                msg += string.Format("Địa chỉ: {0}", _DiaChi);
                return msg;
            }
            return "Tài khoản không tồn tại!!!";
        }

        public bool IsValidAcc(ref string err, ref int KyHan)
        {
            SqlCommand cmd = Shared.dbConnection.CreateCommand("sp_IsValidAcc");
            cmd.Parameters.Add("@SoTaiKhoan", SqlDbType.NVarChar);
            cmd.Parameters.Add("@PinCode", SqlDbType.NVarChar);
            cmd.Parameters.Add("@KyHan", SqlDbType.Int).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("@err", SqlDbType.NVarChar).Direction = ParameterDirection.Output;

            cmd.Parameters["@SoTaiKhoan"].Value = _SoTaiKhoan;
            cmd.Parameters["@PinCode"].Value = _PinCode;
            cmd.Parameters["@err"].Size = 255;

            if (!dbCn.ExecCmd(cmd))
            {
                err = "Không đọc được thông tin!!!";
                return false;
            }

            err = cmd.Parameters["@err"].Value.ToString();
            if (err == "")
            {
                KyHan = (int)cmd.Parameters["@KyHan"].Value;
                return true;
            }
            return false;
        }

        #region Static functions
        public static DataTable LoadAccounts()
        {
            string proc = "sp_DsTaiKhoan";
            DataSet ds = Shared.dbConnection.LoadData(proc);
            if (ds != null) return ds.Tables[0];
            return null;
        }

        public static DataSet Transactions(string accID)
        {
            SqlParameter param = new SqlParameter("@SoTaiKhoan", SqlDbType.NVarChar);
            param.Value = accID;
            DataSet ds = Shared.dbConnection.LoadData("sp_XemGiaoDich", param);
            return ds;
        }

        public static void DelAcc(string accID)
        {
            SqlCommand cmd = Shared.dbConnection.CreateCommand("sp_XoaTaiKhoan");
            cmd.Parameters.Add("@SoTaiKhoan", SqlDbType.NVarChar).Value = accID;
            dbCn.ExecCmd(cmd);
        }
        #endregion
    }
}