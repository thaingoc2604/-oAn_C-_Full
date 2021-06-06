using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration ;

using System.Security.Cryptography;
using BUS;
using DTO;
using System.IO;
using System.Reflection;
using System.Data.OleDb;
using DevComponents.DotNetBar;

namespace Accounting
{
    public partial class Form_Info : Office2007Form
    {
        NguoiDung_DTO _user_DTO;

        NguoiDung_Bus _user_BUS;

        

        public Form_Info(NguoiDung_DTO user_DTO)
        {
            InitializeComponent();

            _user_DTO = user_DTO;

            _user_BUS = new NguoiDung_Bus();
        }

      

        private void Form_Config_Load(object sender, EventArgs e)
        {
            //_user_DTO = _user_BUS.GetInfo(_user_DTO.Username, _user_DTO.Pass);

                txtHoten.Text = _user_DTO.Fullname;

                txtTenDangNhap.Text = _user_DTO.Username;
        }


        public string GetMD5(string chuoi)
        {
            string str_md5 = "";
            byte[] mang = System.Text.Encoding.UTF8.GetBytes(chuoi);

            MD5CryptoServiceProvider my_md5 = new MD5CryptoServiceProvider();
            mang = my_md5.ComputeHash(mang);

            foreach (byte b in mang)
            {
                str_md5 += b.ToString("X2");
            }

            return str_md5;
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            _user_DTO.Pass = _user_DTO.Pass.Replace(" ", "");
            if (txtTenDangNhap.Text != "" && txtMatkhaucu.Text != "" && txtMatKhaumoi1.Text != "" && txtmatkhaumoi2.Text != "" && txtMatKhaumoi1.Text == txtmatkhaumoi2.Text && GetMD5(txtMatkhaucu.Text) == _user_DTO.Pass)
            {
                errorProvider1.Clear();
                _user_DTO.Fullname = txtHoten.Text;
                _user_DTO.IsAdmin = 1;
                txtMatKhaumoi1.Text = txtMatKhaumoi1.Text.Replace(" ", "");
                txtTenDangNhap.Text = txtTenDangNhap.Text.Replace(" ", "");
                _user_DTO.Username = txtTenDangNhap.Text;
                _user_DTO.Pass = GetMD5(txtMatKhaumoi1.Text);

                if (_user_BUS.CapNhatThongTin(_user_DTO, GetMD5(txtMatkhaucu.Text)) == 1)
                {
                    MessageBoxEx.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBoxEx.Show("Cập nhật thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                errorProvider1.Clear();
                if (txtTenDangNhap.Text == "")
                    errorProvider1.SetError(txtTenDangNhap, "Ch­a nhËp hä tªn.");
                
                if (txtMatkhaucu.Text == "")
                    errorProvider1.SetError(txtMatkhaucu, "Ch­a nhËp mËt khÈu cò.");

                if (txtMatKhaumoi1.Text == "")
                    errorProvider1.SetError(txtMatKhaumoi1, "Ch­a nhËp mËt khÈu míi.");

                if (txtmatkhaumoi2.Text == "")
                    errorProvider1.SetError(txtmatkhaumoi2, "Ch­a nhËp x¸c nhËn mËt khÈu míi.");

                if (txtmatkhaumoi2.Text != txtMatKhaumoi1.Text)
                    errorProvider1.SetError(txtmatkhaumoi2, "MËt khÈu x¸c nhËn sai.");

                if (GetMD5(txtMatkhaucu.Text) != _user_DTO.Pass)
                    errorProvider1.SetError(txtMatkhaucu, "MËt khÈu cò sai.");
            }
        }

        private void Form_Config_Activated(object sender, EventArgs e)
        {
            txtHoten.Focus();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}