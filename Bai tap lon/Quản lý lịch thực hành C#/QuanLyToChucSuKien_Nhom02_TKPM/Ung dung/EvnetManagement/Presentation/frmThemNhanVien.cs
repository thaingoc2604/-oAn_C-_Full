using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using EventManager.DataAccess;
using EventManager.Enums;
using EventManager.Utilities;
using EventManager.Business;

namespace EventManager.Presentation
{
    public partial class frmThemNhanVien : XtraForm
    {
        string _matKhau;
        NguoiDungBUS nguoiDungBUS;
        NhanVienBUS nhanVienBUS;
        LogFile log;
        public frmThemNhanVien()
        {
            try
            {
                InitializeComponent();
                _matKhau = string.Empty;
                nguoiDungBUS = new NguoiDungBUS();
                nhanVienBUS = new NhanVienBUS();
                log = new LogFile();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #region Các hàm tiện ích

        /// <summary>
        /// Xóa chữ của các text box
        /// </summary>
        private void ClearText()
        {
            txtHoTen.ResetText();
            txtDiaChi.ResetText();
            txtEmail.ResetText();
            txtDienThoai.ResetText();
            dateTimeNgaySinh.DateTime = new DateTime(1993, 1, 1);
            radiGioiTinh.SelectedIndex = 0;
            numricHeSoLuong.Value = (decimal)2.34;
            txtHoTen.Focus();
        }

        private bool TaoMoi(NhanVien nv)
        {
            try
            {
                nv.MaNV = txtMaNV.Text;
                if (!string.IsNullOrEmpty(txtHoTen.Text))
                    nv.TenNV = txtHoTen.Text;
                else
                {
                    MsgboxUtil.Exclamation("Họ tên nhân viên không được để trống");
                    txtHoTen.Focus();
                    return false;
                }
                if (numricHeSoLuong.Value > 0)
                    nv.HeSoLuong = (double)numricHeSoLuong.Value;
                else
                {
                    MsgboxUtil.Exclamation("Hệ số lương không hợp lệ");
                    numricHeSoLuong.Focus();
                    return false;
                }
                if (!string.IsNullOrEmpty(dateTimeNgaySinh.Text))
                    nv.NgaySinh = dateTimeNgaySinh.DateTime;
                if (!string.IsNullOrEmpty(txtDiaChi.Text))
                    nv.DiaChi = txtDiaChi.Text.Trim();
                if (!string.IsNullOrEmpty(txtDienThoai.Text))
                    nv.DienThoai = txtDienThoai.Text.Trim();
                if (!string.IsNullOrEmpty(txtEmail.Text))
                    nv.Email = txtEmail.Text.Trim();
                if (radiGioiTinh.SelectedIndex == 0)
                    nv.GioiTinh = false;
                else
                    nv.GioiTinh = true;
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        private void btnHuy_Click(object sender, EventArgs e)
        {
            try
            {
                ClearText();
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                NhanVien nv = new NhanVien();
                if (TaoMoi(nv))
                {
                    frmMatKhau frm = new frmMatKhau();
                    frm.truyen += new frmMatKhau.TruyenMatKhau(GetMatKhau);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        NguoiDung user = new NguoiDung()
                        {
                            Username = nv.MaNV.ToLower(),
                            Password = UtilitiesClass.MaHoaMD5(_matKhau),
                            TenNguoiDung = nv.TenNV,
                            Quyen = (int)QuyenNguoiDung.NhanVien,
                            MoTaQuyen = "Nhân viên"
                        };
                        nguoiDungBUS.Them(user);
                        nhanVienBUS.Them(nv);
                        nhanVienBUS.LuuThayDoi();
                        nguoiDungBUS.LuuThayDoi();
                        log.GhiFile("Thêm nhân viên mới: " + nv.MaNV);
                        MsgboxUtil.Success("Thành công");
                        ClearText();
                        txtMaNV.Text = nhanVienBUS.SinhMaTuDong();
                    }
                    else
                        MsgboxUtil.Exclamation("Không thể thêm nhân viên khi chưa thiết lập mật khẩu");
                }
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
                return;
            }
        }

        private void frmThemNhanVien_Load(object sender, EventArgs e)
        {
            try
            {
                txtMaNV.Text = nhanVienBUS.SinhMaTuDong();
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if ((e.KeyChar >= 33 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 126))
                    e.Handled = true;
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        /// <summary>
        /// Hàm nhận mật khẩu từ form con
        /// </summary>
        private void GetMatKhau(string value)
        {
            _matKhau = value;
        }
    }
}