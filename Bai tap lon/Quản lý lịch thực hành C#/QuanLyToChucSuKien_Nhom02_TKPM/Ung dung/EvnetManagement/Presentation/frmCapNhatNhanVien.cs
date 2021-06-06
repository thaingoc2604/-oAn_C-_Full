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
    public partial class frmCapNhatNhanVien : XtraForm
    {
        NhanVienBUS nhanVienBUS;
        Table<NhanVien> source;
        LogFile log;
        public frmCapNhatNhanVien()
        {
            try
            {
                InitializeComponent();
                nhanVienBUS = new NhanVienBUS();
                source = nhanVienBUS.DanhSachNhanVien();
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
                source = nhanVienBUS.DanhSachNhanVien();
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
            try
            {
                txtMaNV.DataBindings.Add("Text", source, "MaNV");
                txtHoTen.DataBindings.Add("Text", source, "TenNV");
                txtDiaChi.DataBindings.Add("Text", source, "DiaChi");
                txtDienThoai.DataBindings.Add("Text", source, "DienThoai");
                txtEmail.DataBindings.Add("Text", source, "Email");
                numricHeSoLuong.DataBindings.Add("Value", source, "HeSoLuong");
                dateTimeNgaySinh.DataBindings.Add("DateTime", source, "NgaySinh");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Clear data binding
        /// </summary>
        private void ClearBinding()
        {
            try
            {
                txtMaNV.DataBindings.Clear();
                txtHoTen.DataBindings.Clear();
                txtDiaChi.DataBindings.Clear();
                txtDienThoai.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                numricHeSoLuong.DataBindings.Clear();
                dateTimeNgaySinh.DataBindings.Clear();
            }
            catch (Exception ex)
            {
                throw ex;
            } 
        }

        private void BindingGioiTinh(int rowHandle)
        {
            try
            {
                bool gioiTinh = bool.Parse(gridView1.GetRowCellValue(rowHandle, "GioiTinh").ToString());
                if (gioiTinh)
                    radiGioiTinh.SelectedIndex = 1;
                else
                    radiGioiTinh.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

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

        private void frmCapNhatNhanVien_Load(object sender, EventArgs e)
        {
            try
            {
                LoadSource();
                ClearBinding();
                Binding();
                BindingGioiTinh(0);
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            } 
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                BindingGioiTinh(e.RowHandle);
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
                return;
            }
        }

        private void toolStripMenuXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int[] i = gridView1.GetSelectedRows();
                if (i.Length > 0)
                {
                    string maNV = gridView1.GetRowCellDisplayText(i[0], "MaNV");
                    gridView1.DeleteRow(i[0]);
                    nhanVienBUS.Xoa(maNV);
                }
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            try
            {
                log.GhiFile("Xuất danh sách nhân viên.");
                gridControl1.ShowRibbonPrintPreview();
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            nhanVienBUS.LuuThayDoi();
            log.GhiFile("Thay đổi thông tin cơ bản một hoặc nhiều nhân viên");
            MsgboxUtil.Success("Đã cập nhật các thay đổi vào CSDL");
        }
    }
}