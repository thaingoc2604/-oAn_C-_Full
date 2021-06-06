﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Business_Tier;
using Entities;
namespace GUI_Tier
{
    public partial class frm9_QuanLyThiSinh : Form
    {
        public frm9_QuanLyThiSinh()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();

        private void loadThiSinh()
        {
            dt = new B_ThiSinh().Lay_TatCa_ThiSinhDaDK();
            dgv_ThiSinh.DataSource = dt; 
        }

        private void xoatrang()
        {
            txtMaTS.Clear();
            txtHoTen.Clear();
            txtTenDN.Clear();
            txtMatKhau.Clear();
            txtDiaChi.Clear();
        }

        private void frm10_QuanLyThiSinh_Load(object sender, EventArgs e)
        {
            loadThiSinh();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            
        }               

        private void btnThem_Click(object sender, EventArgs e)
        {
            xoatrang();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtDiaChi.Text == "" || txtHoTen.Text == "" || txtMatKhau.Text == "" || txtMaTS.Text == "" || txtTenDN.Text == "")
            {
                MessageBox.Show("Ban Chưa Nhập Đầy Đủ Thông Tin !!", "Thông Báo !!!");
            }
            else
            {
                ThiSinh TS = new ThiSinh(txtMaTS.Text.ToUpper(),txtHoTen.Text,txtTenDN.Text,txtMatKhau.Text,txtDiaChi.Text);

                if (new B_ThiSinh().dangki(TS) == 1)
                {
                    MessageBox.Show("Thêm Thí Sinh Thành Công !!", "Thông Báo !!!");
                    loadThiSinh();
                    xoatrang();
                }
                else
                {
                    MessageBox.Show("Thêm Thí Sinh Thất Bại!!", "Thông Báo !!!");
                    xoatrang();
                }
 
            }
        }

        private void dgv_ThiSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //------lay ma cau hoi trong DataGridview ------------
            string MaThiSinhDangChon = dgv_ThiSinh.CurrentRow.Cells[0].Value.ToString();
            
            //--sử dụng mã thí sinh vừa chon để lấy thông tin thí sinh.
            DataTable dt_theomats = new B_ThiSinh().LayThiSinh_TheoMaTS_b(MaThiSinhDangChon);//----1

            txtMaTS.Text = dt_theomats.Rows[0]["mathisinh"].ToString();
            txtHoTen.Text = dt_theomats.Rows[0]["hoten"].ToString();
            txtTenDN.Text = dt_theomats.Rows[0]["tendn"].ToString();
            txtMatKhau.Text = dt_theomats.Rows[0]["matkhau"].ToString();
            txtDiaChi.Text = dt_theomats.Rows[0]["diachi"].ToString();
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtDiaChi.Text == "" || txtHoTen.Text == "" || txtMaTS.Text == "" || txtMatKhau.Text == "" || txtTenDN.Text == "" )
            {
                MessageBox.Show("Bạn Không Được Để Trống Nội Dung Nào !! ", "Thông Báo !!!!");
            }
            else
            {
                string mats = dgv_ThiSinh.CurrentRow.Cells[0].Value.ToString();

                ThiSinh ts = new ThiSinh(mats, txtHoTen.Text, txtTenDN.Text, txtMatKhau.Text, txtDiaChi.Text);
                if (new B_ThiSinh().Sua_ThiSinh_B(ts) == 1)
                {
                    MessageBox.Show("Sửa Thông Tin Thí Sinh Thành Công !!");
                    loadThiSinh();
                    xoatrang();
                }
                else
                {
                    MessageBox.Show("Sửa Thông Tin Nhân Viên Thất Bại ! !");
                    xoatrang();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaTS.Text=="")
            {
                MessageBox.Show("Bạn Chưa Chọn Thí Sinh Để Xóa !! ", "Thông Báo !!!!");
            }
            else
            {
                string mats = dgv_ThiSinh.CurrentRow.Cells[0].Value.ToString();

                ThiSinh ts = new ThiSinh(mats, txtHoTen.Text, txtTenDN.Text, txtMatKhau.Text, txtDiaChi.Text);
                if (new B_ThiSinh().xoa_ThiSinh_D(ts) == 1)
                {
                    MessageBox.Show("Xóa Thông Tin Thí Sinh Thành Công !!");
                    loadThiSinh();
                    xoatrang();
                }
                else
                {
                    MessageBox.Show("Xóa Thông Tin Nhân Viên Thất Bại ! !");
                    xoatrang();
                }
            }
        }

        private void pic_TroVe_Click(object sender, EventArgs e)
        {
            frm2_GiaoDienChinh ch = new frm2_GiaoDienChinh();
            ch.Show();
            this.Hide();
        }
    }
}
