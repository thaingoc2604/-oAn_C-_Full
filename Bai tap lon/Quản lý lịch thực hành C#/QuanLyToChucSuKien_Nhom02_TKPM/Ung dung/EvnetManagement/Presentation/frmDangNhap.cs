using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using EventManager.Utilities;
using EventManager.DataAccess;
using System.Linq;
using EventManager.Business;

namespace EventManager.Presentation
{
    public partial class frmDangNhap : XtraForm
    {
        private NguoiDungBUS nguoiDungBUS;
        public frmDangNhap()
        {
            InitializeComponent();
            nguoiDungBUS = new NguoiDungBUS();
        }

        public bool KiemTra()
        {
            try
            {
                if (txtTenDangNhap.Text.Trim().Length == 0)
                {
                    MsgboxUtil.Exclamation("Bạn chưa nhập Tên người dùng");
                    txtTenDangNhap.Focus();
                    return false;
                }
                if (txtMatKhau.Text.Trim().Length == 0)
                {
                    MsgboxUtil.Exclamation("Bạn chưa nhập Mật khẩu");
                    txtMatKhau.Focus();
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (nguoiDungBUS.KiemTraTenDangNhap(txtTenDangNhap.Text.Trim()))
                {
                    NguoiDung user = nguoiDungBUS.LayThongTin(txtTenDangNhap.Text.Trim());
                    if (user.Password == UtilitiesClass.MaHoaMD5(txtMatKhau.Text))
                    {
                        StaticClass.User = user;
                        StaticClass.DangNhap = true;
                        LogFile log = new LogFile() { ThaoTac = "Đăng nhập hệ thống" };
                        log.GhiFile();
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MsgboxUtil.Exclamation("Mật khẩu không đúng.");
                        txtMatKhau.Focus();
                        txtMatKhau.SelectAll();
                        return;
                    }      
                }
                else
                {
                    MsgboxUtil.Exclamation("Người dùng không tồn tại");
                    txtTenDangNhap.Focus();
                    txtTenDangNhap.SelectAll();
                    return;
                }
            }
            catch (Exception ex)
            {
                MsgboxUtil.Error(ex.Message);
            }
        }

        private void textEdit2_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                    simpleButton1_Click(null, null);
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}