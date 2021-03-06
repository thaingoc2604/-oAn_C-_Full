using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using QuanLyHoSoCongChuc.BusinessObject;
using QuanLyHoSoCongChuc.Controller;
using QuanLyHoSoCongChuc.DataLayer;

namespace QuanLyHoSoCongChuc
{
    public partial class FrmTKNhanVien : DockContent
    {
        NhanVienControl m_NhanVienCtrl = new NhanVienControl();
  

        public FrmTKNhanVien()
        {
            InitializeComponent();
        }


        private void frmTimNhanVien_Load(object sender, EventArgs e)
        {
            m_NhanVienCtrl.HienThiComboBox(cmbPhong, cmbChucVu,cmbTDCM);
            cmbTen_tt.SelectedIndex = 0;
            cmbChucVu_tt.SelectedIndex = 0;
            cmbPhong_tt.SelectedIndex = 0;
            cmbTDCM_tt.SelectedIndex = 0;
          
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string chonTen = cmbTen_tt.Text;
            if (chonTen == "Và")
                chonTen = "and";
            else
                if (chonTen == "Hoặc")
                    chonTen = "or";
           
            string chonChucVu = cmbChucVu_tt.Text;
            if (chonChucVu == "Và")
                chonChucVu = "and";
            else
                if (chonChucVu == "Hoặc")
                    chonChucVu = "or";
            //***************************************
            string chonPhong = cmbPhong_tt.Text;
            if (chonPhong == "Và")
                chonPhong = "and";
            else
                if (chonPhong == "Hoặc")
                    chonPhong = "or";
            string chonTDCM = cmbTDCM_tt.Text;
            if (chonTDCM == "Và")
                chonTDCM = "and";
            else
                if (chonTDCM == "Hoặc")
                    chonTDCM = "or";
           
            m_NhanVienCtrl.TimNhanVien(chonTen, txtTen.Text,chonTDCM, cmbTDCM, chonChucVu, cmbChucVu, chonPhong, cmbPhong,dataGridViewTimNV);
            if (dataGridViewTimNV.RowCount == 0)
                MessageBox.Show("Không tìm thấy nhân viên nào.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void macdinh()
        {
            m_NhanVienCtrl.KhongKichHoatTextBox(txtTen);
            m_NhanVienCtrl.KhongKichHoatComboBox(cmbChucVu);
            m_NhanVienCtrl.KhongKichHoatComboBox(cmbPhong);
            m_NhanVienCtrl.KhongKichHoatComboBox(cmbTDCM);
           
        }

       
        private void cmbTen_tt_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_NhanVienCtrl.KichHoatTextBox(txtTen);
            if (cmbTen_tt.Text == "Bỏ Qua")
            {
                m_NhanVienCtrl.KhongKichHoatTextBox(txtTen);
            }
        }
        private void cmbTDCM_tt_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_NhanVienCtrl.KichHoatComboBox(cmbTDCM);
            if (cmbTDCM_tt.Text == "Bỏ Qua")
            {
                m_NhanVienCtrl.KhongKichHoatComboBox(cmbTDCM);
            }
        }
       
        private void cmbChucVu_tt_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_NhanVienCtrl.KichHoatComboBox(cmbChucVu);
            if (cmbChucVu_tt.Text == "Bỏ Qua")
            {
                m_NhanVienCtrl.KhongKichHoatComboBox(cmbChucVu);
            }
        }

        private void cmbPhong_tt_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_NhanVienCtrl.KichHoatComboBox(cmbPhong);
            if (cmbPhong_tt.Text == "Bỏ Qua")
            {
                m_NhanVienCtrl.KhongKichHoatComboBox(cmbPhong);
            }
        }
       
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}