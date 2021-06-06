using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using Data_Tier;

namespace Bus_Tier
{
    public class DapAn_Bus
    {
        #region Khai báo biến
        private String maCauHoi;
        private String maDapAn;
        private String noiDungDapAn;
        private int dapAnDung;
        DapAn_Data da;
        #endregion

        #region Các hàm get set
        public String MaCauHoi
        {
            get { return maCauHoi; }
            set { maCauHoi = value; }
        }
        public String MaDapAn
        {
            get { return maDapAn; }
            set { maDapAn = value; }
        }
        public String NoiDungDapAn
        {
            get { return noiDungDapAn; }
            set { noiDungDapAn = value; }
        }
        public int DapAnDung
        {
            get { return dapAnDung; }
            set { dapAnDung = value; }
        } 
        #endregion
        #region Constructor khởi tạo DapAn_Bus
        public DapAn_Bus()
        {
        }
        public DapAn_Bus(String macauhoi)
        {
            MaCauHoi = macauhoi;
        }
        public DapAn_Bus(String madapan,String noidungdapan)
        {
            MaDapAn = madapan;
            NoiDungDapAn = noidungdapan;
        }
        public DapAn_Bus(String macauhoi, String madapan, String noidungdapan)
        {
            MaCauHoi = macauhoi;
            MaDapAn = madapan;
            NoiDungDapAn = noidungdapan;
        }
        public DapAn_Bus(String macauhoi, String madapan, String noidungdapan, int dapandung)
        {
            MaCauHoi = macauhoi;
            MaDapAn = madapan;
            NoiDungDapAn = noidungdapan;
            DapAnDung = dapandung;
        } 
        #endregion
        public DataSet Show_DapAn()
        {
            da = new DapAn_Data();
            return da.Show_DapAn(MaCauHoi);            
        }
        public DataSet Show_DapAn_Ran()
        {
            da = new DapAn_Data();
            return da.Show_DapAn_Ran(MaCauHoi);
        }
        public int Add_Update_DapAn(bool trangthai)
        {
            da = new DapAn_Data();
            return da.Add_Update_DapAn(MaCauHoi, MaDapAn, NoiDungDapAn, DapAnDung,trangthai);
        }
        public int Delete_DapAn()
        {
            da = new DapAn_Data();
            return da.Delete_DapAn(MaCauHoi);
        }
    }
}
