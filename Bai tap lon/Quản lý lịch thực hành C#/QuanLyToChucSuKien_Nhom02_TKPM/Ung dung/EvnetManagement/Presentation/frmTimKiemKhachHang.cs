using System;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using EventManager.Business;
using EventManager.Utilities;
using EventManager.Enums;
using DevExpress.XtraReports.UserDesigner;
using EventManager.Reports;

namespace EventManager.Presentation
{
    public partial class frmTimKiemKhachHang : XtraForm
    {
        KhachHangBUS khachHangBUS;
        LogFile log;
        List<string> truong = new List<string>();
        List<string> giaTri = new List<string>();
        List<string> dieuKien = new List<string>();
        List<string> toanTu = new List<string>();

        public frmTimKiemKhachHang()
        {
            try
            {
                InitializeComponent();
                khachHangBUS = new KhachHangBUS();
                log = new LogFile();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ckbHoTen_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string ten = ((CheckEdit)sender).Name;
                bool trangThai = ((CheckEdit)sender).Checked;
                switch (ten)
                {
                    case "ckbHoTen":
                        txtHoTen.Enabled = trangThai;
                        rdbHoTen.Enabled = trangThai;
                        swbHoTen.Enabled = trangThai;
                        break;
                    case "ckbSoHD":
                        numSoHD.Enabled = trangThai;
                        rdbSoHD.Enabled = trangThai;
                        swbSoHD.Enabled = trangThai;
                        break;
                    case "ckbGiaTriHD":
                        numGiaTriHD.Enabled = trangThai;
                        rdbGiaTriHD.Enabled = trangThai;
                        swbGiaTriHD.Enabled = trangThai;
                        break;
                    case "ckbTongNo":
                        numTongNo.Enabled = trangThai;
                        rdbTongNo.Enabled = trangThai;
                        swbTongNo.Enabled = trangThai;
                        break;
                    case "ckbSoLanTTTre":
                        numTTTre.Enabled = trangThai;
                        rdbTTTre.Enabled = trangThai;
                        swbTTTre.Enabled = trangThai;
                        break;
                    case "ckbLoaiKH":
                        cmbLoaiKH.Enabled = trangThai;
                        rdbLoaiKH.Enabled = trangThai;
                        swbLoaiKH.Enabled = trangThai;
                        break;
                    case "ckbDiaChi":
                        txtDiaChi.Enabled = trangThai;
                        rdbDiaChi.Enabled = trangThai;
                        swbDiaChi.Enabled = trangThai;
                        break;
                    case "ckbDienThoai":
                        txtDienThoai.Enabled = trangThai;
                        rdbDienThoai.Enabled = trangThai;
                        swbDienThoai.Enabled = trangThai;
                        break;
                    case "ckbEmail":
                        txtEmail.Enabled = trangThai;
                        rdbEmail.Enabled = trangThai;
                        swbEmail.Enabled = trangThai;
                        break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CreateQuery()
        {
            try
            {
                truong.Clear();
                giaTri.Clear();
                dieuKien.Clear();
                toanTu.Clear();
                //ho ten
                if (ckbHoTen.Checked && !string.IsNullOrEmpty(txtHoTen.Text))
                {
                    truong.Add("TenKH");
                    giaTri.Add("N'%" + txtHoTen.Text.Trim() + "%'");
                    dieuKien.Add(rdbHoTen.EditValue.ToString());
                    toanTu.Add(swbHoTen.ValueObject.ToString());
                }
                //so hop dong da ky
                if (ckbSoHD.Checked)
                {
                    truong.Add("SoCTDky");
                    giaTri.Add(numSoHD.Value.ToString());
                    dieuKien.Add(rdbSoHD.EditValue.ToString());
                    toanTu.Add(swbSoHD.ValueObject.ToString());
                }
                //gia tri cac hop dong
                if (ckbGiaTriHD.Checked)
                {
                    truong.Add("TongPhi");
                    giaTri.Add(numGiaTriHD.Value.ToString());
                    dieuKien.Add(rdbGiaTriHD.EditValue.ToString());
                    toanTu.Add(swbGiaTriHD.ValueObject.ToString());
                }
                //tong no
                if (ckbTongNo.Checked)
                {
                    truong.Add("TongNo");
                    giaTri.Add(numTongNo.Value.ToString());
                    dieuKien.Add(rdbTongNo.EditValue.ToString());
                    toanTu.Add(swbTongNo.ValueObject.ToString());
                }
                //so lan thanh toan tre
                if (ckbSoLanTTTre.Checked)
                {
                    truong.Add("SoLanTreHan");
                    giaTri.Add(numTTTre.Value.ToString());
                    dieuKien.Add(rdbTTTre.EditValue.ToString());
                    toanTu.Add(swbTTTre.ValueObject.ToString());
                }
                //loai khach hang
                if (ckbLoaiKH.Checked)
                {
                    truong.Add("XepLoai");
                    giaTri.Add("N'%" + cmbLoaiKH.SelectedItem.ToString() + "%'");
                    dieuKien.Add(rdbLoaiKH.EditValue.ToString());
                    toanTu.Add(swbLoaiKH.ValueObject.ToString());
                }
                //dia chi
                if (ckbDiaChi.Checked && !string.IsNullOrEmpty(txtDiaChi.Text))
                {
                    truong.Add("DiaChi");
                    giaTri.Add("N'%" + txtDiaChi.Text.Trim() + "%'");
                    dieuKien.Add(rdbDiaChi.EditValue.ToString());
                    toanTu.Add(swbDiaChi.ValueObject.ToString());
                }
                //dien thoai
                if (ckbDienThoai.Checked && !string.IsNullOrEmpty(txtDienThoai.Text))
                {
                    truong.Add("DienThoai");
                    giaTri.Add("N'%" + txtDienThoai.Text.Trim() + "%'");
                    dieuKien.Add(rdbDienThoai.EditValue.ToString());
                    toanTu.Add(swbDienThoai.ValueObject.ToString());
                }
                //Email
                if (ckbEmail.Checked && !string.IsNullOrEmpty(txtEmail.Text))
                {
                    truong.Add("Email");
                    giaTri.Add("'%" + txtEmail.Text.Trim() + "%'");
                    dieuKien.Add(rdbEmail.EditValue.ToString());
                    toanTu.Add(swbEmail.ValueObject.ToString());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }      
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                CreateQuery();
                gridControl1.DataSource = khachHangBUS.TimKiemNangCao(truong, giaTri, dieuKien, toanTu);
                log.GhiFile("Tìm kiếm khách hàng nâng cao với " + truong.Count + " điều kiện");
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                CreateQuery();
                frmXemTruyVan frm = new frmXemTruyVan() { TruyVan = khachHangBUS.TaoTruyVan(truong, giaTri, dieuKien, toanTu) };
                frm.ketQua+=new frmXemTruyVan.TruyenKetQua(TruyVanNangCaoCao);
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    gridControl1.DataSource = khachHangBUS.TimKiemNangCao(truyVan);
                    log.GhiFile("Tìm kiếm nâng cao cao");
                }
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        string truyVan = "";

        public void TruyVanNangCaoCao(string truyVan)
        {
            try
            {
                this.truyVan = truyVan;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void frmTimKiemKhachHang_Load(object sender, EventArgs e)
        {
            try
            {
                if (StaticClass.User.Quyen == (int)QuyenNguoiDung.Admin)
                    simpleButton2.Enabled = true;
                else
                    simpleButton2.Enabled = false;
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
                gridControl1.DataSource = null;
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
                if (gridControl1.DataSource != null)
                {
                    XRDesignRibbonForm form = new XRDesignRibbonForm();
                    form.OpenReport(new rptTimKiemNangCao(gridControl1.DataSource));
                    form.ShowDialog();
                }
                else
                    MsgboxUtil.Exclamation("Chưa có dữ liệu. Hãy tìm kiếm trước nhé");
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
            
        }
    }
}