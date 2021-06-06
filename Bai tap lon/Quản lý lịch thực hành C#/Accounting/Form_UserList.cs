using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

using Janus.Windows.UI;
using Janus.Windows.UI.Dock;
using Janus.Windows.UI.CommandBars;

using BUS;
using DTO;
using System.IO;
using System.Reflection;
using System.Data.OleDb;
using DevComponents.DotNetBar;


using System.Security.Cryptography;

namespace Accounting
{
    public partial class Form_UserList : Office2007Form
    {
        Nhom_BUS _Nhom_Bus;

        NguoiDung_Bus _NguoiDung_BUS;

        NguoiDung_DTO _NguoiDung_DTO;

        int flag = 0;

        public Form_UserList()
        {
            InitializeComponent();

            _Nhom_Bus = new Nhom_BUS();

            _NguoiDung_BUS = new NguoiDung_Bus();

            _NguoiDung_DTO = new NguoiDung_DTO();
        }

        private void Form_UserList_Load(object sender, EventArgs e)
        {
            cboNhom.DataSource = _Nhom_Bus.DSNhom();

            cboNhom.DisplayMember = "TenNhom";

            cboNhom.ValueMember = "MaNhom";

            LayDSNguoiDung();
        }

        private void LayDSNguoiDung()
        {
            lstDsNgDung.DataSource = _NguoiDung_BUS.GetDSNguoiDung();

            lstDsNgDung.DisplayMember = "Fullname";

            lstDsNgDung.ValueMember = "Username";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                flag = 0;

                bttThem.Text = "Thêm";

                lstDsNgDung.Enabled = true;

                txtTenDangNhap.ReadOnly = true;

                txtMatkhau.ReadOnly = true;

                txtHoten.ReadOnly = true;

                txtTenDangNhap.Text = "";

                txtMatkhau.Text = "";

                txtHoten.Text = "";

            }
            else
            {
                Close();
            }
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

        private void bttThem_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                
                int kq=_NguoiDung_BUS.KTTenDangNhap(txtTenDangNhap.Text);
                if (kq  == 0 && txtHoten.Text != "" && txtMatkhau.Text != "" && txtTenDangNhap.Text != "" && cboNhom.SelectedValue != null)
                {
                    errorProvider1.Clear();
                    _NguoiDung_DTO.Fullname = txtHoten.Text;
                    _NguoiDung_DTO.IsAdmin = int.Parse(cboNhom.SelectedValue.ToString());
                    txtMatkhau.Text = txtMatkhau.Text.Replace(" ", "");
                    txtTenDangNhap.Text = txtTenDangNhap.Text.Replace(" ", "");
                    _NguoiDung_DTO.Username = txtTenDangNhap.Text;
                    _NguoiDung_DTO.Pass = GetMD5(txtMatkhau.Text);

                    if (_NguoiDung_BUS.ThemNguoiDung(_NguoiDung_DTO) == 1)
                    {
                        MessageBoxEx.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBoxEx.Show("Thêm mới thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    flag = 0;

                    bttThem.Text = "Thêm";

                    lstDsNgDung.Enabled = true;

                    txtTenDangNhap.ReadOnly = true;

                    txtMatkhau.ReadOnly = true;

                    txtHoten.ReadOnly = true;

                    txtTenDangNhap.Text = "";

                    txtMatkhau.Text = "";

                    txtHoten.Text = "";

                    LayDSNguoiDung();
                }
                else
                {
                    errorProvider1.Clear();

                    if (kq != 0)
                    {
                        errorProvider1.SetError(txtTenDangNhap, "Tên đăng nhập đã tồn tại.");

                    }

                    if (txtTenDangNhap.Text == "")
                        errorProvider1.SetError(txtTenDangNhap, "Chưa nhập họ tên.");

                    if (txtMatkhau.Text == "")
                        errorProvider1.SetError(txtMatkhau, "Chưa nhập mật khẩu.");

                    if (txtTenDangNhap.Text == "")
                        errorProvider1.SetError(txtTenDangNhap, "Cuưa nhập tên đăng nhập.");

                }

            }

            if (flag == 0)
            {
                lstDsNgDung.Enabled=false;

                bttThem.Text = "Lưu";

                txtTenDangNhap.ReadOnly = false;

                txtMatkhau.ReadOnly = false;

                txtHoten.ReadOnly = false;

                txtTenDangNhap.Text = "";

                txtMatkhau.Text = "";

                txtHoten.Text = "";

                flag = 1;

                txtHoten.Focus();
            }

           
            
        }

        private void lstDsNgDung_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void lstDsNgDung_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lstDsNgDung.SelectedValue != null)
            {
                int isadmin = _NguoiDung_BUS.GetPermit(lstDsNgDung.SelectedValue.ToString());

                cboNhom.SelectedValue = isadmin;

                txtHoten.Text = lstDsNgDung.Text;
            }
        }

        private void bttUpDate_Click(object sender, EventArgs e)
        {

        }
    }
}