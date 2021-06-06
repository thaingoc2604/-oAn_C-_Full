using System;
using System.Collections.Generic;
using System.Text;
using QUANLIKH.Data;
using System.Data;
using QUANLIKH.BusinessObject;
using QUANLIKH.Resources;

namespace QUANLIKH.Controller
{
  public  class NguoiDungControl
    {
       NguoiDungData data = new NguoiDungData();

      public NguoiDungControl()
        {
        }
        //
        //0- 
        //1- 
        //2- 
        //
        public int DangNhap(String username, String password)
        {
            DataTable nd = data.LayNguoiDung(username);
            if (nd.Rows.Count == 0)
                return 0;//Khong ton tai nguoi dung nay

            String matkhau_hethong = nd.Rows[0][2].ToString();//MNat khau trong CSDL

            if (matkhau_hethong != password)
            {
                return 1;//Sai mat khau
            }
            else
            {
                NguoiDung ndinfo = new NguoiDung(Convert.ToInt32(nd.Rows[0][0]), nd.Rows[0][1].ToString(), nd.Rows[0][2].ToString(), Convert.ToInt32(nd.Rows[0][3]));

                staticClass.nguoidungStatic = ndinfo;
                return 2;//Dang nhap thanh cong
            }
        }
    }
}
