using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using Data_Tier;

namespace Bus_Tier
{
    public class CauHoi_Bus
    {
        #region Khai báo biến
        private String maCauHoi;
        private String id;
        private String noiDungCauHoi;
        CauHoi_Data ch;
        #endregion
        #region Các hàm get set
        public String MaCauHoi
        {
            get { return maCauHoi; }
            set { maCauHoi = value; }
        }
        public String Id
        {
            get { return id; }
            set { id = value; }
        }
        public String NoiDungCauHoi
        {
            get { return noiDungCauHoi; }
            set { noiDungCauHoi = value; }
        } 
        #endregion
        #region Constructor CauHoi_Bus
        public CauHoi_Bus()
        {
        }
        public CauHoi_Bus(String macauhoi)
        {
            MaCauHoi = macauhoi;
        }
        public CauHoi_Bus(String macauhoi, String id)
        {
            MaCauHoi = macauhoi;
            Id = id;
        }
        public CauHoi_Bus(String macauhoi, String id, String noiduncauhoi)
        {
            MaCauHoi = macauhoi;
            Id = id;
            NoiDungCauHoi = noiduncauhoi;
        } 
        #endregion
        public int Check_MaCauHoi()
        {
            ch = new CauHoi_Data();
            return ch.Check_MaCauHoi(MaCauHoi);
        }
        public DataView Show_All()
        {
            ch=new CauHoi_Data();
            return ch.Show_All("tb_cauhoi");
        }
        public DataView Show_CauHoi_ID(String id)
        {
            ch = new CauHoi_Data();
            return ch.Show_CauHoi_ID(id);
        }
        public DataSet Show_CauHoi()
        {
            ch = new CauHoi_Data();
            return ch.Show_CauHoi(MaCauHoi);
        }
        public int Add_Update_CauHoi()
        {
            ch = new CauHoi_Data();
            return ch.Add_Update_CauHoi(MaCauHoi, Id, NoiDungCauHoi);
        }
        public int Delete_CauHoi()
        {
            ch = new CauHoi_Data();
            return ch.Delete_CauHoi(MaCauHoi);
        }
    }
}
