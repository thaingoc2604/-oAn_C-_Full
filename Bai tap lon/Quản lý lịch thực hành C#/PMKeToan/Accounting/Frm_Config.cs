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
    public partial class Frm_Config : Office2007Form
    {
        HeThong_BUS _HT_BUS;

        public Frm_Config()
        {
            InitializeComponent();

            _HT_BUS = new HeThong_BUS();
        }

        private void frmConfig_Load(object sender, EventArgs e)
        {
            txtDVChuQuan.Text = _HT_BUS.LayTenCtyChuQuan();

            txtTenCty.Text = _HT_BUS.LayTenCty();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            HeThong_DTO ht_DTO= new HeThong_DTO();

            ht_DTO.TenCSDL = txtTenCSDL.Text;

            ht_DTO.Tenmaychu = txtTenMayChu.Text;

            ht_DTO.Tendangnhap = txtTenDangNhap.Text;

            ht_DTO.Matkhau = txtMatKhau.Text;

            HeThong_BUS ht_BUS = new HeThong_BUS();

            ht_BUS.CapNhatCauHinh(ht_DTO, txtTenCty.Text, txtDVChuQuan.Text);

            labelX7.Text = "Thông tin hệ thống đã được cập nhật!";
        }

        private void labelX6_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Config_Activated(object sender, EventArgs e)
        {
            txtTenCSDL.Focus();
        }

        private void txtTenCSDL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                txtTenMayChu.Focus();
            }

        }

        private void txtTenMayChu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                txtTenDangNhap.Focus();
            }
        }

        private void txtTenDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                txtMatKhau.Focus();
            }
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                txtDVChuQuan.Focus();
            }
        }

        private void txtDVChuQuan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                txtTenCty.Focus();
            }
        }

        private void txtTenCty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                buttonX3.Focus();
            }
        }
    }
}