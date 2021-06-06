using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using Data_Tier;

namespace Bus_Tier
{
    public class KetQua_Bus
    {
        #region khai báo biến
        private String id;
        private String ho;
        private String ten;
        private String maDe;
        private double diem;
        private DateTime ngayThi;
        KetQua_Data kq;
        #endregion
        #region Các hàm get set
        public String Id
        {
            get { return id; }
            set { id = value; }
        }
        public String Ho
        {
            get { return ho; }
            set { ho = value; }
        }
        public String Ten
        {
            get { return ten; }
            set { ten = value; }
        }
        public String MaDe
        {
            get { return maDe; }
            set { maDe = value; }
        }
       
        public DateTime NgayThi
        {
            get { return ngayThi; }
            set { ngayThi = value; }
        }
        public double Diem
        {
            get { return diem; }
            set { diem = value; }
        }
        #endregion
        #region Constructor Tạo đối tượng KetQua_Bus
        public KetQua_Bus()
        {
        }
        public KetQua_Bus(String id)
        {
            Id = id;
        }
        public KetQua_Bus(String id, String ho, String ten, String made, double diem, DateTime ngaythi)
        {
            Id = id;
            Ho = ho;
            Ten = ten;
            MaDe = made;
            Diem = diem;
            NgayThi = ngaythi;
        } 
        #endregion
        public DataView Show_All_KQ()
        {
            kq = new KetQua_Data();
            return kq.Show_All("tb_KetQua");
        }
        public DataView Show_All_KQ_By_ID()
        {
            kq = new KetQua_Data();
            return kq.Show_All_KQ_By_ID(Id);
        }
        public int Luu_KetQua()
        {
            kq = new KetQua_Data();
            return kq.Luu_KetQua(Id, Ho, Ten, MaDe, Diem, NgayThi);
        }
    }
}
