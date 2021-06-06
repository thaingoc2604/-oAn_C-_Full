using System;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using System.Data.Linq;
using EventManager.DataAccess;
using EventManager.Business;
using EventManager.Utilities;
using System.Windows.Forms;

namespace EventManager.Presentation
{
    public partial class frmDanhMucNguoiDung : XtraForm
    {
        Table<NguoiDung> source;
        NguoiDungBUS nguoiDungBUS;
        string matKhau;
        LogFile log;
        public frmDanhMucNguoiDung()
        {
            try
            {
                InitializeComponent();
                nguoiDungBUS = new NguoiDungBUS();
                matKhau = string.Empty;
                log = new LogFile();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void frmDanhMucNguoiDung_Load(object sender, EventArgs e)
        {
            try
            {
                source = nguoiDungBUS.DanhSachNguoiDung();
                gridControl1.DataSource = source;

                txtTenDangNhap.DataBindings.Clear();
                txtTenDangNhap.DataBindings.Add("Text", source, "Username");
                txtHoTen.DataBindings.Clear();
                txtHoTen.DataBindings.Add("Text", source, "TenNguoiDung");
                txtQuyen.DataBindings.Clear();
                txtQuyen.DataBindings.Add("Text", source, "MoTaQuyen");
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            frmMatKhau frm = new frmMatKhau();
            frm.truyen += new frmMatKhau.TruyenMatKhau(GetMatKhau);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                nguoiDungBUS.ThietLapLaiMatKhau(txtTenDangNhap.Text, matKhau);
                nguoiDungBUS.LuuThayDoi();
                log.GhiFile("Thiết lập lại mật khẩu của người dùng " + txtTenDangNhap.Text);
                MsgboxUtil.Success("Đã thiết lập lại mật khẩu cho \"" + txtTenDangNhap.Text + "\"");
            }
        }

        private void GetMatKhau(string value)
        {
            matKhau = value;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            try
            {
                gridControl1.ShowRibbonPrintPreview();
                log.GhiFile("Xuất danh sách các người dùng");
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }
    }
}