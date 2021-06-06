using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using Data_Tier;

namespace Bus_Tier
{
    public class User_Bus
    {
        #region Khai báo các biến
        private String id;
        private String matkhau;
        private String soCMND;
        private String chuoiBiMat;
        private String ho;
        private String ten;
        private String diaChi;
        private DateTime ngaySinh;
        private String quyen;
        private String duongDan;
        private byte[] hinhAnh;
        User_Data us;
        #endregion
        #region  Các hàm get set
        public String Id
        {
            get { return id; }
            set { id = value; }
        }
        public String Matkhau
        {
            get { return matkhau; }
            set { matkhau = value; }
        }
        public String SoCMND
        {
            get { return soCMND; }
            set { soCMND = value; }
        }
        public String ChuoiBiMat
        {
            get { return chuoiBiMat; }
            set { chuoiBiMat = value; }
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
        public String DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }
        public String Quyen
        {
            get { return quyen; }
            set { quyen = value; }
        }
        public byte[] HinhAnh
        {
            get { return hinhAnh; }
            set { hinhAnh = value; }
        }
        public String DuongDan
        {
            get { return duongDan; }
            set { duongDan = value; }
        }
        #endregion
        #region Constructor Tạo đối tượng User_Bus
        public User_Bus()
        {
        }
        public User_Bus(String id)
        {
            Id = id;
        }
        public User_Bus(String id, String matkhau)
        {
            Id = id;
            Matkhau = matkhau;
        }
        public User_Bus(String id, String socmnd, String chuoibimat)
        {
            Id = id;
            SoCMND = socmnd;
            ChuoiBiMat = chuoibimat;
        }
        public User_Bus(String id, String matkhau, String socmnd, String chuoibimat, String ho, String ten, String diachi, DateTime ngaysinh, String quyen)
        {
            Id = id;
            Matkhau = matkhau;
            SoCMND = socmnd;
            ChuoiBiMat = chuoibimat;
            Ho = ho;
            Ten = ten;
            DiaChi = diachi;
            NgaySinh = ngaysinh;
            Quyen = quyen;
        } 
        public User_Bus(String id, String matkhau, String socmnd, String chuoibimat, String ho, String ten, String diachi, DateTime ngaysinh, String quyen,String duongdan)
        {
            Id = id;
            Matkhau = matkhau;
            SoCMND = socmnd;
            ChuoiBiMat = chuoibimat;
            Ho = ho;
            Ten = ten;
            DiaChi = diachi;
            NgaySinh = ngaysinh;
            Quyen = quyen;
            DuongDan = duongdan;
        } 
        #endregion
        public bool Log_In()
        {
            us = new User_Data();
            return us.Log_In(Id, Matkhau);
        }
        public String Check_Quyen()
        {
            us = new User_Data();
            return us.Check_Quyen(Id, Matkhau);
        }
        public String Forgot_Password()
        {
            us = new User_Data();
            return us.Forgot_Password(Id,SoCMND,ChuoiBiMat);
        }
        public bool Res_User()
        {
            us = new User_Data();
            return us.Res_User(Id, Matkhau, SoCMND, ChuoiBiMat, Ho, Ten, DiaChi, NgaySinh, Quyen,DuongDan);
        }
        public int DK_User()
        {
            us = new User_Data();
            return us.DK_User(Id, Matkhau, SoCMND, ChuoiBiMat, Ho, Ten, DiaChi, NgaySinh, Quyen);
        }
        public byte[] Ret_Pic()
        {
            us = new User_Data();
            return us.Ret_Pic(Id, Matkhau);
        }
        public int Change_Pass()
        {
            us = new User_Data();
            return us.Change_Pass(Id, Matkhau);
        }
        public DataSet Get_ThongTin_User()
        {
            us = new User_Data();
            return us.Get_ThongTin_User(Id);
        }
        public DataTable Get_All_User()
        {
            us = new User_Data();
            return us.Get_All_User().Tables["tb_user"];
        }
        public DataTable Get_All()
        {
            us = new User_Data();
            return us.Show_All("tb_user").Table;
        }
        public int Edit_User()
        {
            us = new User_Data();
            return us.Edit_User(Id, Matkhau, SoCMND, ChuoiBiMat, Ho, Ten, DiaChi, NgaySinh, Quyen);
        }
        public int Del_User()
        {
            us = new User_Data();
            return us.Del_User(Id);
        }
    }
}
