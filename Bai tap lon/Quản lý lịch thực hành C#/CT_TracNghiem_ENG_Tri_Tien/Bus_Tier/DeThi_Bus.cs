using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using Data_Tier;

namespace Bus_Tier
{
    public class DeThi_Bus
    {
        #region Khai báo biến
        private String maDe;
        private String maCauHoi;
        private String id;
        DeThi_Data dethi;
        #endregion
        #region Các hàm get set
        public String MaDe
        {
            get { return maDe; }
            set { maDe = value; }
        }
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
        #endregion
        #region Constructor khởi tạo DeThi_Bus
        public DeThi_Bus()
        {
        }
        public DeThi_Bus(string made)
        {
            MaDe = made;
        }
        public DeThi_Bus(string made, String macauhoi)
        {
            MaDe = made;
            MaCauHoi = macauhoi;
        }
        public DeThi_Bus(string made, String macauhoi,String id)
        {
            MaDe = made;
            MaCauHoi = macauhoi;
            Id = id;
        } 
        #endregion
        public int TaoDe()
        {
            dethi = new DeThi_Data();
            return dethi.TaoDe(MaDe, MaCauHoi,Id);
        }
        public DataSet HienThi_MaDe(String id)
        {
            dethi = new DeThi_Data();
            return dethi.HienThi_MaDe(id);
        }
        public DataSet HienThi_MaDe_All()
        {
            dethi = new DeThi_Data();
            return dethi.HienThi_MaDe_All();
        }
        public DataSet HienThi_List_Combo(String made)
        {
            dethi = new DeThi_Data();
            return dethi.HienThi_List_ComBo(made);
        }
        public int XoaDe()
        {
            dethi = new DeThi_Data();
            return dethi.XoaDe(MaDe);
        }
        public int ThoiGian_Thi()
        {
            dethi = new DeThi_Data();
            return dethi.ThoiGian_Thi(MaDe);
        }
        public DataSet Load_Cau_Hoi()
        {
            dethi = new DeThi_Data();
            return dethi.Load_Cau_Hoi(MaDe);
        }
        public bool HienThi_MaDe_By_MaCauHoi(String macauhoi)
        {
            dethi = new DeThi_Data();
            return dethi.HienThi_MaDe_By_MaCauHoi(macauhoi);
        }
    }
}
