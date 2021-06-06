using System;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using System.Linq;
using EventManager.DataAccess;
using EventManager.Utilities;
using System.Data.Linq;
using EventManager.Business;

namespace EventManager.Presentation
{
    public partial class frmDanhMucHopDong : XtraForm
    {
        Table<ChiTietCT> source;
        HopDongBUS hopDongBUS;
        LogFile log;
        public frmDanhMucHopDong()
        {
            try
            {
                InitializeComponent();
                hopDongBUS = new HopDongBUS();
                source = hopDongBUS.DanhSachHopDong();
                log = new LogFile();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void LoadSource()
        {
            try
            {
                source = hopDongBUS.DanhSachHopDong();
                //cmbKhachHang
                cmbKhachHang.Properties.DataSource = (new KhachHangBUS()).DanhSachKhachHang();
                //cmbChuongTrinh
                cmbChuongTrinh.Properties.DataSource = (new ChuongTrinhBUS()).DanhSachChuongTrinh();
                //cmbNhanVien
                cmbNhanVien.Properties.DataSource = (new NhanVienBUS()).DanhSachNhanVien();
                gridControl1.DataSource = source;
                ClearBinding();
                Binding();
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
                txtID.DataBindings.Add("Text", source, "ID");
                cmbKhachHang.DataBindings.Add("EditValue", source, "MaKH");
                cmbChuongTrinh.DataBindings.Add("EditValue", source, "MaCT");
                cmbNhanVien.DataBindings.Add("EditValue", source, "MaNV");
                dateNgayBD.DataBindings.Add("DateTime", source, "NgayBatDau");
                dateNgayKT.DataBindings.Add("DateTime", source, "NgayKetThuc");
                numricSoNguoi.DataBindings.Add("Value", source, "SoNguoiThamGia");
                numricMucPhat.DataBindings.Add("Value", source, "MucPhat");
                txtDiaDiem.DataBindings.Add("Text", source, "DiaDiem");
                txtMoTa.DataBindings.Add("Text", source, "MoTa");
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
                txtID.DataBindings.Clear();
                cmbKhachHang.DataBindings.Clear();
                cmbChuongTrinh.DataBindings.Clear();
                cmbNhanVien.DataBindings.Clear();
                dateNgayBD.DataBindings.Clear();
                dateNgayKT.DataBindings.Clear();
                numricSoNguoi.DataBindings.Clear();
                numricMucPhat.DataBindings.Clear();
                txtDiaDiem.DataBindings.Clear();
                txtMoTa.DataBindings.Clear();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void frmDanhMucHopDong_Load(object sender, EventArgs e)
        {
            try
            {
                LoadSource();
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
                gridControl1.ShowRibbonPrintPreview();
                log.GhiFile("Xuất danh sách các hợp đồng");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}