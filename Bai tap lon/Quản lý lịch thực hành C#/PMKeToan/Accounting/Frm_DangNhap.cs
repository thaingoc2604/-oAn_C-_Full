using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Security.Cryptography;
using DTO;
using BUS;

namespace Accounting
{
    public partial class Frm_DangNhap : Office2007Form
    {
        private static NguoiDung_DTO _ngdung_DTO = new NguoiDung_DTO();

        public static NguoiDung_DTO Ngdung_DTO
        {
            get { return Frm_DangNhap._ngdung_DTO; }
            set { Frm_DangNhap._ngdung_DTO = value; }
        }

         
       
        NguoiDung_Bus _ngdung_BUS = new NguoiDung_Bus();

        public Frm_DangNhap()
        {
            InitializeComponent();

        }

        private void Frm_DangNhap_Load(object sender, EventArgs e)
        {

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
            DAO.DataProvider.ResetConnectionString();

            NguoiDung_Bus ng_BUS = new NguoiDung_Bus();
            int flag=ng_BUS.KTDangNhap(txtmaNV.Text, txtMaKhau.Text) ;
            if (flag== 1)
            {
                _ngdung_DTO = _ngdung_BUS.GetInfo(txtmaNV.Text, txtMaKhau.Text);
                
                this.DialogResult = DialogResult.Yes;
            }
            else
            {
                if(flag==2)
                    MessageBoxEx.Show("Vui lòng kiểm tra Server", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBoxEx.Show("Sai mật khẩu!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        private void Frm_DangNhap_Activated(object sender, EventArgs e)
        {
            txtmaNV.Focus();
        }

        private void txtmaNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtmaNV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                txtMaKhau.Focus();
            }
        }

        private void txtMaKhau_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtMaKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                buttonX3.Focus();
            }
        }

        private void Frm_DangNhap_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                contextMenuStrip1.Show(MousePosition.X, MousePosition.Y); ;
            }
        }

        private void CauHinhHeThongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Config frm = new Frm_Config();

            frm.ShowDialog();
        }
    }
}