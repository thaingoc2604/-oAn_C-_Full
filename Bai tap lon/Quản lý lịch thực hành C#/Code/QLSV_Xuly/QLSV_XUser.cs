﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLSV_Database;
using System.Security.Cryptography;
using System.Data;
using System.Windows.Forms;
namespace QLSV_Xuly
{
   public class QLSV_XUser
    {
        private QLSV_Database.QLSV_DUser qlsv_dUser = new QLSV_DUser();
        c_ThaoTacChung ctc = new c_ThaoTacChung();
        //public QLSV_XUser()
        //{
        //    qlsv_dUser = new QLSV_DUser(this);
        //}
        private string User;
        private string Pass;
        private string newPass;
        private TextBox txt = new TextBox();
        private string table = "tb_User";
        private int column = 0;
        public TextBox TXT
        {
            get { return txt; }
            set { txt = value; }
        }

        public string NewPass
        {
            get { return newPass; }
            set 
            { 
                newPass = value;
                if (this.newPass == "")
                {
                    //throw new Exception("Vui lòng nhập mật khẩu mới");
                    MessageBox.Show("Vui lòng nhập mật khẩu mới");
                }
            }
        }
        public string PASS
        {
            get { return Pass; }
            set 
            { 
                Pass = value;
                if (this.PASS == "")
                {
                    //throw new Exception("Vui long nhap Password");
                    MessageBox.Show("Vui lòng nhập Password");
                }
            }
        }
        public string USER
        {
            get { return User; }
            set 
            { 
                User = value;
                if (this.USER == "")
                {
                    //throw new Exception("Chưa nhập Username");
                    MessageBox.Show("Chưa nhập Username");
                }
            }
        }
        //mã hóa password ,using System.Security.Cryptography
        public string MahoaPass(string pass)
        {
            UnicodeEncoding uc = new UnicodeEncoding();
            byte[] hash = uc.GetBytes(pass);
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            hash = md5.ComputeHash(hash);
            return Convert.ToBase64String(hash);
        }

        public void CreateUser()
        {
            if (qlsv_dUser.isExist(USER) == true)
            {
                // throw new Exception("User này đã tồn tại");
                MessageBox.Show("User này đã tồn tại");
            }
            else
            {
                qlsv_dUser.CreateUser(USER, MahoaPass(PASS));
                MessageBox.Show("Tạo tài khoản mới thành công");
            }
        }
        public void DeleteUser()
        {
            if (qlsv_dUser.isExist(USER) == true)
            {
                
                qlsv_dUser.DeleteUser(USER);
            }
            else
                //throw new Exception("Không tồn tại User này");
                  MessageBox.Show("Không tồn tại User này");
        }

        public void UpdateUser()
        {
            if (qlsv_dUser.isExist(USER) == true)
            {
                string oldpass = qlsv_dUser.GetOldPass(USER).Rows[0][0].ToString();
                if (MahoaPass(PASS) != oldpass)
                {
                    //throw new Exception("Mật khẩu nhập vào không trùng khớp");
                    MessageBox.Show("Mật khẩu nhập vào không trùng khớp");

                }
                else
                {
                    qlsv_dUser.UpdateUser(USER, MahoaPass(NewPass));
                    MessageBox.Show("Cập nhật thành công");
                }
            }
        }

        public DataTable LoadDL()
        {
            DataTable dt = new DataTable();
            dt = qlsv_dUser.LoadDL("tb_User");
           
            return dt;
        }

        public DataTable TimKiem()
        {
            DataTable dt = new DataTable();
            dt = qlsv_dUser.TimKiem(USER);
            return dt;
        }

        public void TextBoxAutoComplete()
        {
            ctc.TextBox_AutoComplete(TXT, table, column);
        }

        public bool Login()
        {
            bool kq = false;
            if (qlsv_dUser.CheckUser(USER,MahoaPass(PASS)) == true)
            {
                MessageBox.Show("Đăng nhập thành công");
                kq = true;
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
                kq = false;
            }
            return kq; 
        }
    }
}
