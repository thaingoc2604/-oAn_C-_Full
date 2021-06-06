using System;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using EventManager.DataAccess;
using EventManager.Utilities;
using EventManager.Enums;
using EventManager.Business;

namespace EventManager.Presentation
{
    public partial class frmThemChuongTrinh : XtraForm
    {
        private ChuongTrinhBUS chuongTrinhBUS;
        LogFile log = new LogFile();
        public frmThemChuongTrinh()
        {
            try
            {
                InitializeComponent();
                chuongTrinhBUS = new ChuongTrinhBUS();
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
            txtTenCT.ResetText();
            txtMoTa.ResetText();
            txtTenCT.Focus();
        }

        private bool TaoMoi(ChuongTrinh ct)
        {
            try
            {
                ct.MaCT = txtMaCT.Text;
                if (!string.IsNullOrEmpty(txtTenCT.Text))
                    ct.TenCT = txtTenCT.Text;
                else
                {
                    MsgboxUtil.Exclamation("Tên chương trình không được để trống");
                    txtTenCT.Focus();
                    return false;
                }
                if (!string.IsNullOrEmpty(txtMoTa.Text))
                    ct.MoTaCT = txtMoTa.Text.Trim();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        private void frmThemChuongTrinh_Load(object sender, EventArgs e)
        {
            try
            {
                txtMaCT.Text = chuongTrinhBUS.SinhMaTuDong();
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
                ChuongTrinh ct=new ChuongTrinh();
                if (TaoMoi(ct))
                {
                    chuongTrinhBUS.Them(ct);
                    chuongTrinhBUS.LuuThayDoi();
                    log.GhiFile("Thêm dịch vụ: " + ct.MaCT);
                    MsgboxUtil.Success("Thành công");
                    ClearText();
                    txtMaCT.Text = chuongTrinhBUS.SinhMaTuDong();
                }
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

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


    }
}