using System;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using EventManager.Utilities;
using EventManager.DataAccess;
using System.Linq;
using EventManager.Business;

namespace EventManager.Presentation
{
    public partial class frmLapPhieuThanhToan : XtraForm
    {
        private HopDongBUS hopDongBUS;
        private KeHoachChiTraBUS keHoachBUS;
        LogFile log;
        public frmLapPhieuThanhToan()
        {
            try
            {
                InitializeComponent();
                hopDongBUS = new HopDongBUS();
                keHoachBUS = new KeHoachChiTraBUS();
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
                //cmbKhachHang
                cmbKhachHang.Properties.DataSource = (new KhachHangBUS()).DanhSachKhachHang();
                cmbKhachHang.EditValue = cmbKhachHang.Properties.GetDataSourceValue("MaKH", 0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ckbThoiGian_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (ckbThoiGian.Checked)
                {
                    dateNgayThatSuTT.DateTime = DateTime.Now;
                    dateNgayThatSuTT.Enabled = false;
                }
                else
                    dateNgayThatSuTT.Enabled = true;
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void cmbKhachHang_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                groupHD.Text = "Các hợp đồng đã ký của: " + cmbKhachHang.Text;
                var hd = hopDongBUS.DanhSachHopDong(cmbKhachHang.EditValue.ToString());
                gridControl1.DataSource = hd;
                gridControl2.DataSource = null;
                txtGiaiDoan.ResetText();
                txtIdCTCT.ResetText();
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void frmLapPhieuThanhToan_Load(object sender, EventArgs e)
        {
            try
            {
                LoadSource();
                dateNgayThatSuTT.DateTime = DateTime.Now;
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
                int IdCTCT = int.Parse(gridView1.GetRowCellValue(e.RowHandle, "ID").ToString());
                var keHoach = keHoachBUS.KeHoachChiTra(IdCTCT);
                gridControl2.DataSource = keHoach;
                txtIdCTCT.Text = IdCTCT.ToString();
                txtGiaiDoan.ResetText();
                txtNhanVien.Text = gridView1.GetRowCellValue(e.RowHandle, "TenNV").ToString();
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void gridView2_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                txtGiaiDoan.Text = gridView2.GetRowCellDisplayText(e.RowHandle, "GiaiDoan");
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdCTCT.Text))
            {
                MsgboxUtil.Exclamation("Hãy chọn hợp đồng ở panel bên trái phía dưới");
                gridView1.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtGiaiDoan.Text))
            {
                MsgboxUtil.Exclamation("Hãy chọn kế hoạch chi trả ở panel bên phải phía dưới");
                gridView2.Focus();
                return;
            }
            KeHoachChiTra x = keHoachBUS.LayThongTin(int.Parse(txtIdCTCT.Text), int.Parse(txtGiaiDoan.Text));
            if (x.NgayThatSuTT != null)
            {
                MsgboxUtil.Exclamation("Kế hoạch chi trả này đã được thanh toán.");
                gridView2.Focus();
                return;
            }
            x.NgayThatSuTT = dateNgayThatSuTT.DateTime;
            keHoachBUS.LuuThayDoi();
            log.GhiFile("Lập phiếu thanh toán cho hợp đồng số: " + x.IdCTCT + " giai đoạn " + x.GiaiDoan);
            //load lai
            var keHoach = keHoachBUS.KeHoachChiTra(x.IdCTCT);
            gridControl2.DataSource = keHoach;

        }
    }
}