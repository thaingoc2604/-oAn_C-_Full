using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EventManager.Utilities;
using EventManager.Enums;
using EventManager.DataAccess;
using System.Linq;
using DevExpress.XtraEditors;
using EventManager.Business;

namespace EventManager.Presentation
{
    public partial class frmThemKhachHang : XtraForm
    {
        string _matKhau;
        private KhachHangBUS khachHangBUS;
        private NguoiDungBUS nguoiDungBUS;
        LogFile log;
        public frmThemKhachHang()
        {
            try
            {
                InitializeComponent();
                _matKhau = string.Empty;
                khachHangBUS = new KhachHangBUS();
                nguoiDungBUS = new NguoiDungBUS();
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
            txtHoTen.Focus();
        }

        private bool TaoMoi(KhachHang kh)
        {
            try
            {
                kh.MaKH = txtMa.Text;
                if (!string.IsNullOrEmpty(txtHoTen.Text))
                    kh.TenKH = txtHoTen.Text;
                else
                {
                    MsgboxUtil.Exclamation("Họ tên khách hàng không được để trồng");
                    txtHoTen.Focus();
                    return false;
                }
                if (!string.IsNullOrEmpty(txtDiaChi.Text))
                    kh.DiaChi = txtDiaChi.Text.Trim();
                if (!string.IsNullOrEmpty(txtDienThoai.Text))
                    kh.DienThoai = txtDienThoai.Text.Trim();
                if (!string.IsNullOrEmpty(txtEmail.Text))
                    kh.Email = txtEmail.Text.Trim();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        private void frmThemKhachHang_Load(object sender, EventArgs e)
        {
            try
            {
                txtMa.Text = khachHangBUS.SinhMaTuDong();
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                KhachHang kh = new KhachHang();
                if (TaoMoi(kh))
                {
                    frmMatKhau frm = new frmMatKhau();
                    frm.truyen += new frmMatKhau.TruyenMatKhau(GetMatKhau);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        NguoiDung user = new NguoiDung()
                        {
                            Username = kh.MaKH.ToLower(),
                            Password = UtilitiesClass.MaHoaMD5(_matKhau),
                            TenNguoiDung = kh.TenKH,
                            Quyen = (int)QuyenNguoiDung.KhachHang,
                            MoTaQuyen = "Khách hàng"
                        };
                        nguoiDungBUS.Them(user);
                        khachHangBUS.Them(kh);
                        khachHangBUS.LuuThayDoi();
                        nguoiDungBUS.LuuThayDoi();
                        log.GhiFile("Thêm khách hàng mới: " + kh.MaKH);
                        MsgboxUtil.Success("Thành công");
                        ClearText();
                        txtMa.Text = khachHangBUS.SinhMaTuDong();
                    }
                    else
                        MsgboxUtil.Exclamation("Không thể thêm kháchh hàng khi chưa thiết lập mật khẩu");
                }
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            ClearText();
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