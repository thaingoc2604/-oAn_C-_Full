using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using EventManager.DataAccess;
using EventManager.Utilities;
using System.Linq;
using EventManager.Business;

namespace EventManager.Presentation
{
    public partial class frmHopDongMoi : XtraForm
    {
        private HopDongBUS hopDongBUS;
        private KhachHangBUS khachHangBUS;
        private KeHoachChiTraBUS keHoachChiTraBUS;
        LogFile log;
        public frmHopDongMoi()
        {
            try
            {
                InitializeComponent();
                hopDongBUS = new HopDongBUS();
                keHoachChiTraBUS = new KeHoachChiTraBUS();
                khachHangBUS = new KhachHangBUS();
                log = new LogFile();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #region Các hàm tiện ích

        private void LoadSource()
        {
            try
            {
                //cmbKhachHang
                cmbKhachHang.Properties.DataSource = (new KhachHangBUS()).DanhSachKhachHang();
                cmbKhachHang.EditValue = cmbKhachHang.Properties.GetDataSourceValue("MaKH", 0);
                //cmbChuongTrinh
                cmbChuongTrinh.Properties.DataSource = (new ChuongTrinhBUS()).DanhSachChuongTrinh();
                cmbChuongTrinh.EditValue = cmbChuongTrinh.Properties.GetDataSourceValue("MaCT", 0);
                //txtnhanvien
                txtNhanVien.Text = StaticClass.User.TenNguoiDung;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool TaoMoi(ChiTietCT ct)
        {
            try
            {
                ct.ID = int.Parse(txtID.Text);
                ct.MaNV = StaticClass.User.Username.ToUpper();
                if (!string.IsNullOrEmpty(cmbKhachHang.EditValue.ToString()))
                    ct.MaKH = cmbKhachHang.EditValue.ToString();
                else
                {
                    MsgboxUtil.Exclamation("Vui lòng chọn khách hàng");
                    cmbKhachHang.Focus();
                    return false;
                }

                if (!string.IsNullOrEmpty(cmbChuongTrinh.EditValue.ToString()))
                    ct.MaCT = cmbChuongTrinh.EditValue.ToString();
                else
                {
                    MsgboxUtil.Exclamation("Vui lòng chọn chương trình");
                    cmbChuongTrinh.Focus();
                    return false;
                }

                if (!string.IsNullOrEmpty(dateNgayBD.Text))
                    ct.NgayBatDau = dateNgayBD.DateTime;
                else
                {
                    MsgboxUtil.Exclamation("Vui lòng thiết lập ngày bắt đầu.");
                    dateNgayBD.Focus();
                    return false;
                }

                if (!string.IsNullOrEmpty(dateNgayKT.Text))
                    ct.NgayKetThuc = dateNgayKT.DateTime;
                else
                {
                    MsgboxUtil.Exclamation("Vui lòng thiết lập ngày kết thúc.");
                    dateNgayKT.Focus();
                    return false;
                }

                if (!string.IsNullOrEmpty(txtMoTa.Text))
                    ct.MoTa = txtMoTa.Text;

                if (numricSoNguoi.Value >= 0)
                    ct.SoNguoiThamGia = (int)numricSoNguoi.Value;
                else
                {
                    MsgboxUtil.Exclamation("Số người tham gia không hợp lệ");
                    numricSoNguoi.Focus();
                    return false;
                }

                if (!string.IsNullOrEmpty(txtDiaDiem.Text))
                    ct.DiaDiem = txtDiaDiem.Text;

                if (numricMucPhat.Value >= 0)
                    ct.MucPhat = (int)numricMucPhat.Value;
                else
                {
                    MsgboxUtil.Exclamation("Mức phạt không hợp lệ");
                    numricMucPhat.Focus();
                    return false;
                }

                if(ct.NgayBatDau.CompareTo(ct.NgayKetThuc)==1)
                {
                    MsgboxUtil.Exclamation("Ngày kết thúc phải bằng hoặc sau ngày bắt đầu");
                    dateNgayKT.Focus();
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ClearText()
        {
            dateNgayBD.DateTime = DateTime.Now;
            dateNgayKT.DateTime = DateTime.Now.AddDays(1);
            numricSoNguoi.Value = 0;
            numricMucPhat.Value = 0;
            txtDiaDiem.ResetText();
            txtMoTa.ResetText();

            btnXoa_Click(null, null);
            lsvKeHoach.Items.Clear();
            txtGiaiDoan.Text = "1";

            cmbKhachHang.Focus();
        }

        #endregion

        private void frmHopDongMoi_Load(object sender, EventArgs e)
        {
            try
            {
                LoadSource();
                txtID.Text = hopDongBUS.SinhMaTuDong();
                txtGiaiDoan.Text = "1";
                dateNgayBD.DateTime = DateTime.Now;
                dateNgayKT.DateTime = DateTime.Now.AddDays(1);
                dateNgayTT.DateTime = dateNgayBD.DateTime.AddMonths(-1);
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
                string maKH=cmbKhachHang.EditValue.ToString();
                groupControl1.Text = "Các hợp đồng đã ký của: " + cmbKhachHang.Text;
                var hd = hopDongBUS.DanhSachHopDong(maKH);
                gridControl1.DataSource = hd;
                if (khachHangBUS.LayLoaiKH(maKH) == "Nợ xấu")
                    MsgboxUtil.Exclamation("Khách hàng " + cmbKhachHang.Text + " hiện được xếp loại \"Nợ xấu\". Bạn hãy lưu ý nhé");
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
                ChiTietCT ct=new ChiTietCT();
                if (TaoMoi(ct))
                {
                    hopDongBUS.Them(ct);
                    
                    //kế hoạch chi trả
                    if (lsvKeHoach.Items.Count <= 0)
                    {
                        MsgboxUtil.Exclamation("Hãy lập kế hoạch chi trả cho hợp đồng này trước khi lưu.");
                        numTienTT.Focus();
                        return;
                    }
                    foreach (ListViewItem i in lsvKeHoach.Items)
                    {
                        KeHoachChiTra k = new KeHoachChiTra()
                        {
                            IdCTCT = ct.ID,
                            GiaiDoan = byte.Parse(i.Text),
                            Phi = int.Parse(i.SubItems[1].Text),
                            NgayTTTheoKH = DateTime.Parse(i.SubItems[2].Text),
                            ChiTietCT = ct
                        };
                        if (i.SubItems.Count > 3)
                            k.PhuongThucTT = i.SubItems[3].Text;
                        if (i.SubItems.Count > 4)
                            k.MoTaPhi = i.SubItems[4].Text;
                        keHoachChiTraBUS.Them(k);
                    }
                    hopDongBUS.LuuThayDoi();
                    log.GhiFile("Thêm mới 1 hợp đồng số: " + ct.ID);
                    cmbKhachHang_EditValueChanged(null, null);
                    MsgboxUtil.Success("Đã cập nhật vào CSDL");
                    ClearText();
                    txtID.Text = hopDongBUS.SinhMaTuDong();
                }
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void dateNgayBD_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                dateNgayKT.DateTime = dateNgayBD.DateTime;
                dateNgayTT.DateTime = dateNgayBD.DateTime.AddMonths(-1);
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem i=new ListViewItem(txtGiaiDoan.Text);
                i.SubItems.Add(numTienTT.Value.ToString());
                if (dateNgayTT.DateTime.CompareTo(dateNgayBD.DateTime) < 1)
                    if (lsvKeHoach.Items.Count != 0)
                    {
                        DateTime ngay = DateTime.Parse(lsvKeHoach.Items[lsvKeHoach.Items.Count - 1].SubItems[2].Text);
                        if (dateNgayTT.DateTime.CompareTo(ngay) > 0)
                            i.SubItems.Add(dateNgayTT.DateTime.ToString("dd/MM/yyyy"));
                        else
                        {
                            MsgboxUtil.Exclamation("Ngày bắt đầu giai đoạn này phải sau giai đoạn trước");
                            dateNgayTT.Focus();
                            return;
                        }
                    }
                    else
                        i.SubItems.Add(dateNgayTT.DateTime.ToString("dd/MM/yyyy"));
                else
                {
                    MsgboxUtil.Exclamation("Ngày thanh toán phải trước hoặc bằng ngày bắt đầu.");
                    dateNgayTT.Focus();
                    return;
                }
                i.SubItems.Add(txtPhuongThucTT.Text.Trim());
                if (!string.IsNullOrEmpty(txtMoTaPhi.Text))
                    i.SubItems.Add(txtMoTaPhi.Text.Trim());

                lsvKeHoach.Items.Add(i);
                txtGiaiDoan.Text = (int.Parse(txtGiaiDoan.Text) + 1).ToString();
                btnXoa_Click(null, null);

            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                numTienTT.Value = 100000;

                if (lsvKeHoach.Items.Count != 0)
                {
                    DateTime ngay = DateTime.Parse(lsvKeHoach.Items[lsvKeHoach.Items.Count - 1].SubItems[2].Text);
                    dateNgayTT.DateTime = ngay.AddDays(7);
                }
                else
                    dateNgayTT.DateTime = dateNgayBD.DateTime.AddMonths(-1);

                txtPhuongThucTT.Properties.NullText = "Tiền mặt";

                txtMoTaPhi.ResetText();

            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }
    }
}