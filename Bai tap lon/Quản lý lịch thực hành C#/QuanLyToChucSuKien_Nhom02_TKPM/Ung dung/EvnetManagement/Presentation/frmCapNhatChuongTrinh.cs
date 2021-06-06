using System;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using EventManager.DataAccess;
using System.Data.Linq;
using System.Linq;
using EventManager.Business;
using EventManager.Utilities;

namespace EventManager.Presentation
{
    public partial class frmCapNhatChuongTrinh : XtraForm
    {
        ChuongTrinhBUS chuongTrinhBUS;
        Table<ChuongTrinh> source;
        LogFile log;
        public frmCapNhatChuongTrinh()
        {
            try
            {
                InitializeComponent();
                chuongTrinhBUS = new ChuongTrinhBUS();
                source = chuongTrinhBUS.DanhSachChuongTrinh();
                log = new LogFile();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #region Các hàm tiện ích

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

        /// <summary>
        /// Load dữ liệu lên grid view
        /// </summary>
        private void LoadSource()
        {
            try
            {
                source = chuongTrinhBUS.DanhSachChuongTrinh();
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
                txtMaCT.DataBindings.Add("Text", source, "MaCT");
                txtTenCT.DataBindings.Add("Text", source, "TenCT");
                txtMoTa.DataBindings.Add("Text", source, "MoTaCT");
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
                txtMaCT.DataBindings.Clear();
                txtTenCT.DataBindings.Clear();
                txtMoTa.DataBindings.Clear();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        private void frmCapNhatChuongTrinh_Load(object sender, EventArgs e)
        {
            try
            {
                LoadSource();
                ClearBinding();
                Binding();
            }
            catch (Exception ex)
            {
                MsgboxUtil.Error(ex);
            } 
        }

        private void toolStripMenuXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int[] i = gridView1.GetSelectedRows();
                if (i.Length > 0)
                {
                    string maCT = gridView1.GetRowCellDisplayText(i[0], "MaCT");
                    gridView1.DeleteRow(i[0]);
                    chuongTrinhBUS.Xoa(maCT);
                }
            }
            catch (Exception ex)
            {
                MsgboxUtil.Error(ex);
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            try
            {
                gridControl1.ShowRibbonPrintPreview();
                log.GhiFile("Xuất danh sách các dịch vụ");
            }
            catch (Exception ex)
            {
                MsgboxUtil.Error(ex);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                chuongTrinhBUS.LuuThayDoi();
                log.GhiFile("Thay đổi thông tin 1 hoặc nhiều chương trình");
                MsgboxUtil.Success("Đã cập nhật tất cả các thay đổi vào CSDL");
            }
            catch (Exception ex)
            {
                MsgboxUtil.Error(ex);
            }
        }

    }
}