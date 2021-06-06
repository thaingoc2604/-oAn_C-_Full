using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QUANLIKH.Controller;
using DevComponents.DotNetBar;

namespace QUANLIKH.GiaoDien
{
    public partial class frmTimKiemKhachHang : Office2007Form
    {
        public frmTimKiemKhachHang()
        {
            InitializeComponent();
        }
        KhachHangControl khctrl = new KhachHangControl();
        private void buttontimkh_Click(object sender, EventArgs e)
        {
            khctrl.TimKhachHang(dataGridViewTimKiemKhachHang, bindingNavigatorTimKiemKhachHang, textBoxHoTenKhachHang, cmbChonDiaChi, textBoxDiaChi, cmbChonBienSo, textBoxBienSo, cmbChonSoKhung, textBoxSoKhung, cmbChonSoMay, textBoxSoMay);
            
        }

        private void cmbChonDiaChi_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cmbChonDiaChi.SelectedIndex == 0)
                textBoxDiaChi.Enabled = false;
            else
                textBoxDiaChi.Enabled = true;
        }

        private void cmbChonBienSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChonBienSo.SelectedIndex == 0)
                textBoxBienSo.Enabled = false;
            else
                textBoxBienSo.Enabled = true;

        }

        private void cmbChonSoKhung_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChonSoKhung.SelectedIndex == 0)
                textBoxSoKhung.Enabled = false;
            else
                textBoxSoKhung.Enabled = true;


        }

        private void cmbChonSoMay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChonSoMay.SelectedIndex == 0)
                textBoxSoMay.Enabled = false;
            else
                textBoxSoMay.Enabled = true;

        }

        private void frmTimKiemKhachHang_Load(object sender, EventArgs e)
        {
            
            cmbChonDiaChi.SelectedIndex = 0;
            cmbChonBienSo.SelectedIndex = 0;
            cmbChonSoKhung.SelectedIndex = 0;
            cmbChonSoMay.SelectedIndex = 0;
        }

        



        
    }
}