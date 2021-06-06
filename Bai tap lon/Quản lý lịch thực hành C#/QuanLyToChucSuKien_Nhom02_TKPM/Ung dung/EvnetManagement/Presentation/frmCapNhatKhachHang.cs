using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using EventManager.Utilities;
using System.Data.Linq;
using System.Linq;
using EventManager.Business;
using EventManager.DataAccess;

namespace EventManager.Presentation
{
    public partial class frmCapNhatKhachHang : XtraForm
    {
        KhachHangBUS khachHangBUS;
        Table<KhachHang> source;
        LogFile log;

        public frmCapNhatKhachHang()
        {
            try
            {
                InitializeComponent();
                khachHangBUS = new KhachHangBUS();
                source = khachHangBUS.DanhSachKhachHang();
                log = new LogFile();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #region Các hàm tiện ích

        /// <summary>
        /// Load dữ liệu lên grid view
        /// </summary>
        private void LoadSource()
        {
            try
            {
                source = khachHangBUS.DanhSachKhachHang();
                gridControl1.DataSource = source;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        /// <summary>
        /// Bind dữ liệu lên các text box
        /// </summary>
        private void Binding()
        {
            txtMaKH.DataBindings.Add("Text", source, "MaKH");
            txtHoTen.DataBindings.Add("Text", source, "TenKH");
            txtDiaChi.DataBindings.Add("Text", source, "DiaChi");
            txtDienThoai.DataBindings.Add("Text", source, "DienThoai");
            txtEmail.DataBindings.Add("Text", source, "Email");
        }

        /// <summary>
        /// Clear data binding
        /// </summary>
        private void ClearBinding()
        {
            txtMaKH.DataBindings.Clear();
            txtHoTen.DataBindings.Clear();
            txtDiaChi.DataBindings.Clear();
            txtDienThoai.DataBindings.Clear();
            txtEmail.DataBindings.Clear();
        }
        #endregion

        private void frmDanhSachKhachHang_Load(object sender, EventArgs e)
        {
            try
            {
                LoadSource();
                ClearBinding();
                Binding();
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }   
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            try
            {
                log.GhiFile("Xuất danh sách khách hàng.");
                gridControl1.ShowRibbonPrintPreview();
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void toolStripMenuXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int[] i = gridView1.GetSelectedRows();
                if (i.Length > 0)
                {
                    string maKH = gridView1.GetRowCellDisplayText(i[0], "MaKH");
                    gridView1.DeleteRow(i[0]);
                    khachHangBUS.Xoa(maKH);
                }
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                khachHangBUS.LuuThayDoi();
                log.GhiFile("Thay đổi thông tin cơ bản một hoặc nhiều khách hàng.");
                MsgboxUtil.Success("Đã cập nhật các thay đổi vào CSDL");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}