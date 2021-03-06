using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using QuanLyTienGuiTietKiem.Controller;
using QuanLyTienGuiTietKiem.DataLayer;
using QuanLyTienGuiTietKiem.General;
namespace QuanLyTienGuiTietKiem
{
    public partial class frmGuiVonKKH : Office2007Form
    {
        SoTietKiemCtrl m_SoTietKiemCtrl = new SoTietKiemCtrl();
        DMTaiKhoanCtrl m_DMTaiKHoanCtrl = new DMTaiKhoanCtrl();
        RutTietKiemCtrl m_RutTietKiemCtrl = new RutTietKiemCtrl();
        SoDuTietKiemCtrl m_SoDuTietKiemCtrl = new SoDuTietKiemCtrl();

        public frmGuiVonKKH()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frmGuiVonKKH_Load(object sender, EventArgs e)
        {
            m_SoTietKiemCtrl.HienThiComboBox(txtMaLoaiTK.Text,cmbMaSoTietKiem);
            cmbMaSoTietKiem.SelectedValueChanged += new EventHandler(cmbMaSoTietKiem_SelectedValueChanged);

            m_DMTaiKHoanCtrl.HienThiComboBox(cmbTaiKhoanNo);
        }

        void cmbMaSoTietKiem_SelectedValueChanged(object sender, EventArgs e)
        {
            m_SoTietKiemCtrl.ThemSoKKH(cmbMaSoTietKiem, txtKhachHang, txtLoaiTietKiem, txtLaiSuat, txtSoDu, txtNgayDenHan, txtSoButToan,txtTaiKhoanCo,txtTaiKhoanCo1);
            ///lblThanhCong.Text = "Thành công!";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            MessageBoxEx.Show("Đang xây dựng", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnGiayGuiTien_Click(object sender, EventArgs e)
        {
            MessageBoxEx.Show("Đang xây dựng có thể đến khung nhìn in phiếu để in", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            if (cmbMaSoTietKiem.SelectedValue != null && txtSoDu.Text != "" && txtSoTienGui.Text != "")
            {
                m_SoDuTietKiemCtrl.ThemVonSo(cmbMaSoTietKiem.SelectedValue.ToString(), Convert.ToInt64(txtSoDu.Text), Convert.ToInt64(txtSoTienGui.Text));
                MessageBoxEx.Show("Đã lưu thành công!", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBoxEx.Show("Phải nhập đầy đủ dữ liệu để thêm vốn vào sổ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSoTienGui_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        

   }
}