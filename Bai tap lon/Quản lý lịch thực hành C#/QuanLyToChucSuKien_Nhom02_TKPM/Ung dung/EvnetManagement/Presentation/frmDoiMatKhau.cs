using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using EventManager.Utilities;
using System.Linq;
using EventManager.Business;

namespace EventManager.Presentation
{
    public partial class frmDoiMatKhau : XtraForm
    {
        NguoiDungBUS nguoiDungBUS;
        public frmDoiMatKhau()
        {
            try
            {
                InitializeComponent();
                nguoiDungBUS = new NguoiDungBUS();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void textEdit3_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                    btnDoiMK_Click(null, null);
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMKCu.Text.Trim().Length == 0)
                {
                    MsgboxUtil.Exclamation("Vui lòng nhập mật khẩu cũ của bạn!");
                    txtMKCu.Focus();
                    return;
                }
                if (txtMKMoi.Text.Trim().Length == 0)
                {
                    MsgboxUtil.Exclamation("Vui lòng nhập mật khẩu mới của bạn!");
                    txtMKMoi.Focus();
                    return;
                }
                if (txtNhapLai.Text.Trim().Length == 0)
                {
                    MsgboxUtil.Exclamation("Vui lòng xác minh mật khẩu mới!");
                    txtNhapLai.Focus();
                    return;
                }
                if (txtMKMoi.Text.Trim() != txtNhapLai.Text.Trim())
                {
                    MsgboxUtil.Exclamation("Xác minh mật khẩu không đúng. Vui lòng xác minh lại!");
                    txtMKMoi.ResetText();
                    txtNhapLai.ResetText();
                    txtMKMoi.Focus();
                    return;
                }
                if (nguoiDungBUS.DoiMatKhau(StaticClass.User.Username, txtMKCu.Text, txtMKMoi.Text))
                {
                    (new LogFile()).GhiFile("Đổi mật khẩu.");
                    MsgboxUtil.Success("Mật khẩu của bạn đã được thay đổi");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}