using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using DevComponents.DotNetBar;
using System.Windows.Forms;
using System.Collections;
using TT_GDTX_ANGIANG.BusinessObject;
using TT_GDTX_ANGIANG.Controller;
using TT_GDTX_ANGIANG.DataLayer;


namespace TT_GDTX_ANGIANG
{
    public partial class frm_HOPDONGLAODONG_THOIVIEC : DevComponents.DotNetBar.Office2007Form
    {
        public frm_HOPDONGLAODONG_THOIVIEC()
        {
            InitializeComponent();
        }
        #region ctrlHopDongLaoDong
        private HopDongLaoDong_ThoiViec_Ctrl m_ctrlHopDongLaoDong;
        public HopDongLaoDong_ThoiViec_Ctrl ctrlHopDongLaoDong
        {
            get { return m_ctrlHopDongLaoDong; }
            set { m_ctrlHopDongLaoDong = value; }
        }
        #endregion

        #region SelectedIndex
        /// <summary>
        /// Vi tri dong da chon
        /// </summary>
        private int m_SelectedIndex;
        public int SelectedIndex
        {
            get { return m_SelectedIndex; }
            set { m_SelectedIndex = value; }
        }
        #endregion

        #region IsAddNew
        /// <summary>
        /// True trong khi chon Them, sau do chon Save.
        /// </summary>
        private bool m_IsAddNew;
        public bool IsAddNew
        {
            get { return m_IsAddNew; }
            set { m_IsAddNew = value; }
        }
        #endregion

        #region PhanQuyen_Xem
        public void PhanQuyen_Xem_An()
        {
            //this.itemThemMoi.Enabled = false;
            //this.itemBoQua.Enabled = false;
            //this.itemLuu.Enabled = false;
            //this.itemXoa.Enabled = false;
        }
        public void PhanQuyen_Xem_Hien()
        {
            //this.itemThemMoi.Enabled = true;
            //this.itemBoQua.Enabled = true;
            //this.itemLuu.Enabled = true;
            //this.itemXoa.Enabled = true;
        }
        #endregion

        #region Property

        private HopDongLaoDong_ThoiViec_Info m_HopDongLaoDongSelected;
        public HopDongLaoDong_ThoiViec_Info HopDongLaoDongSelected
        {
            get { return m_HopDongLaoDongSelected; }
            set { m_HopDongLaoDongSelected = value; }
        }

        private string m_Open;
        public string Open
        {
            get { return m_Open; }
            set { m_Open = value; }
        }

        private string m_MANV;
        public string LayMaNhanVien_HopDongLaoDong_ThoiViec
        {
            get { return m_MANV; }
            set { m_MANV = value; }
        }
        private string m_HOTEN;
        public string LayTenNhanVien
        {
            get { return m_HOTEN; }
            set { m_HOTEN = value; }
        }


        private string m_Enable;
        public string An_Hien
        {
            get { return m_Enable; }
            set { m_Enable = value; }
        }
        #endregion

        #region CheckValid()
        private bool CheckValid()
        {
            if (this.txtMaHD.Text.Trim() == "")
            {
                MessageBoxEx.Show("Chưa Nhấn Nút Thêm Mới!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.itemThemMoi.Focus();
                return false;
            }
            if (this.cboLoaiHopDongLD.Text.Trim() == "")
            {
                MessageBoxEx.Show("Chưa Chọn Loại Hợp Đồng Lao Động!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.cboLoaiHopDongLD.Focus();
                return false;
            }
            //kiểm tra ngày
            if (this.dtTuNgay.Value.Date >= this.dtDenNgay.Value.Date)
            {
                MessageBoxEx.Show("Ngày Kết Thúc phải lớn hơn ngày Bắt Đầu!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.dtTuNgay.Focus();
                return false;
            }
            if (this.txtDiaDiemLamViec.Text.Trim() == "")
            {
                MessageBoxEx.Show("Chưa nhập Dia diem lam viec!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtDiaDiemLamViec.Focus();
                return false;
            }
            if (this.txtChucDanhChuyenMon.Text.Trim() == "")
            {
                MessageBoxEx.Show("Chưa nhập Chức Danh Chuyên Môn!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtChucDanhChuyenMon.Focus();
                return false;
            }
            if (this.txtNhiemVu.Text.Trim() == "")
            {
                MessageBoxEx.Show("Chưa nhập Nhiệm Vụ!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtNhiemVu.Focus();
                return false;
            }
            if (this.txtThoiGianLamViec.Text.Trim() == "")
            {
                MessageBoxEx.Show("Chưa nhập Thời Gian Làm Việc!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtThoiGianLamViec.Focus();
                return false;
            }
            if (this.txtTrangBiPT.Text.Trim() == "")
            {
                MessageBoxEx.Show("Chưa nhập Trang Thiết Bị!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtTrangBiPT.Focus();
                return false;
            }


            if (this.txtNguoiKy.Text.Trim() == "")
            {
                MessageBoxEx.Show("Chưa nhập Người Ký Tên !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtNguoiKy.Focus();
                return false;
            }

            if (this.cboChucVuNguoiKy.Text.Trim() == "")
            {
                MessageBoxEx.Show("Chưa nhập Chuc vu nguoi ky !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.cboChucVuNguoiKy.Focus();
                return false;
            }

            if (this.cboLoaiHopDongLD.Text.Trim() == "")
            {
                MessageBoxEx.Show("Chưa nhập Loai hop dong lao dong !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.cboLoaiHopDongLD.Focus();
                return false;
            }
            return true;
        }
        #endregion

        #region ReloadData()
        private void ReloadData()
        {
            if (ctrlHopDongLaoDong == null)
            {
                ctrlHopDongLaoDong = new HopDongLaoDong_ThoiViec_Ctrl();
            }


            ctrlHopDongLaoDong.HienThi_dsHopDongLaoDong_ThoiViec(this.listViewExQTDaoTao, this.LayMaNhanVien_HopDongLaoDong_ThoiViec);
            if (this.listViewExQTDaoTao.Items.Count > 0)
            {
                this.SelectedIndex = 0;
                this.listViewExQTDaoTao.Items[this.SelectedIndex].Selected = true;
                ctrlHopDongLaoDong.HienThiInfo(this.checkBHXH, this.checkBHYT, this.txtMaHD, this.cboLoaiHopDongLD, this.dtTuNgay, this.dtDenNgay, this.txtDiaDiemLamViec, this.txtChucDanhChuyenMon, this.txtNhiemVu, this.txtThoiGianLamViec, this.txtTrangBiPT, this.txtNguoiKy, this.cboChucVuNguoiKy, this.dtNgayKy, this.txtSOQD, dtNGAYQD, this.txtNguoiKyThoiViec, this.dtNGAYTV, this.txtLyDoThoiViec, (HopDongLaoDong_ThoiViec_Info)this.listViewExQTDaoTao.Items[this.SelectedIndex].Tag);

                this.IsAddNew = false;
                this.itemXoaHopDong.Enabled = true;
            }
            else
            {

                this.txtMaHD.Text = null;
                this.dtTuNgay.Text = null;
                this.dtDenNgay.Text = null;
                this.dtNgayKy.Text = null;
                this.txtChucDanhChuyenMon.Text = null;
                this.txtDiaDiemLamViec.Text = null;

                this.txtThoiGianLamViec.Text = null;
                this.txtTrangBiPT.Text = null;
                this.txtNhiemVu.Text = null;


                this.IsAddNew = true;
                this.txtDiaDiemLamViec.Focus();
                this.itemXoaHopDong.Enabled = false;
            }
        }
        #endregion

        #region frm_HOPDONGLAODONG_THOIVIEC_Load        
       
        NhanVienCtrl ctrlNV = null;
        private void frm_HOPDONGLAODONG_THOIVIEC_Load(object sender, EventArgs e)
        {
            #region BENHOPDONGLAODONG


            this.ChamDutHopDonggroupPanel.Enabled = false;

            if (An_Hien == "Xem")
            {
                this.PhanQuyen_Xem_An();
            }
            else
            {
                this.PhanQuyen_Xem_Hien();
            }


            if (ctrlHopDongLaoDong == null)
            {
                ctrlHopDongLaoDong = new HopDongLaoDong_ThoiViec_Ctrl();
            }


            ctrlHopDongLaoDong.HienThi_dsHopDongLaoDong_ThoiViec(this.listViewExQTDaoTao, this.LayMaNhanVien_HopDongLaoDong_ThoiViec);
            if (this.listViewExQTDaoTao.Items.Count > 0)
            {
                HopDongLaoDong_ThoiViec_Data datahopdong = new HopDongLaoDong_ThoiViec_Data();
                datahopdong.lay_dsHopDong_ThoiViecDS(LayMaNhanVien_HopDongLaoDong_ThoiViec);
                DataTable Table = new DataTable();
                Table = datahopdong.lay_dsHopDong_ThoiViecDS(LayMaNhanVien_HopDongLaoDong_ThoiViec);
                bool b = true; int max = 0; int[] a = new int[100]; int k = 0;
                while (b)
                {
                    for (int i = 0; i < Table.Rows.Count; i++)
                    {
                        if (Table.Rows[i][0].ToString().Length == 5)
                        {
                            if ((a[i] = Convert.ToInt16(Table.Rows[i][0].ToString().Substring(4, 1))) > max)
                            {
                                max = a[i]; k = i;
                            }
                        }
                        if (Table.Rows[i][0].ToString().Length == 6)
                        {
                            if ((a[i] = Convert.ToInt16(Table.Rows[i][0].ToString().Substring(4, 2))) > max)
                            {
                                max = a[i]; k = i;
                            }
                        }
                        if (Table.Rows[i][0].ToString().Length == 7)
                        {
                            if ((a[i] = Convert.ToInt16(Table.Rows[i][0].ToString().Substring(4, 3))) > max)
                            {
                                max = a[i]; k = i;
                            }
                        }
                        if (Table.Rows[i][0].ToString().Length == 8)
                        {
                            if ((a[i] = Convert.ToInt16(Table.Rows[i][0].ToString().Substring(4, 4))) > max)
                            {
                                max = a[i]; k = i;
                            }
                        }

                    }

                    this.SelectedIndex = k;
                    b = false;
                }
                this.listViewExQTDaoTao.Items[this.SelectedIndex].Selected = true;
                ctrlHopDongLaoDong.HienThiInfo(this.checkBHXH, this.checkBHYT, this.txtMaHD, this.cboLoaiHopDongLD, this.dtTuNgay, this.dtDenNgay, this.txtDiaDiemLamViec, this.txtChucDanhChuyenMon, this.txtNhiemVu, this.txtThoiGianLamViec, this.txtTrangBiPT, this.txtNguoiKy, this.cboChucVuNguoiKy, this.dtNgayKy, this.txtSOQD, dtNGAYQD, this.txtNguoiKyThoiViec, this.dtNGAYTV, this.txtLyDoThoiViec, (HopDongLaoDong_ThoiViec_Info)this.listViewExQTDaoTao.Items[this.SelectedIndex].Tag);

                if ((dtDenNgay.Value.DayOfYear <= System.DateTime.Now.DayOfYear) && (dtDenNgay.Value.Year <= System.DateTime.Now.Year))
                {
                    MessageBoxEx.Show("Hợp đồng lao động đã hết hạn.");

                }
                this.IsAddNew = false;
                this.itemXoaHopDong.Enabled = true;
            }
            else
            {

                this.txtMaHD.Text = null;
                try
                {
                    this.cboLoaiHopDongLD.Text = HopDongLaoDongSelected.LoaiHopDong;
                    this.cboChucVuNguoiKy.Text = HopDongLaoDongSelected.ChucVu;
                }
                catch
                {
                    this.cboChucVuNguoiKy.Text = null;
                    this.cboLoaiHopDongLD.Text = null;
                }
                this.dtTuNgay.Value = DateTime.Now;
                this.dtDenNgay.Value = DateTime.Now;
                this.dtNgayKy.Value = DateTime.Now;
                this.txtChucDanhChuyenMon.Text = null;
                this.txtDiaDiemLamViec.Text = null;
                this.txtThoiGianLamViec.Text = null;
                this.txtTrangBiPT.Text = null;
                this.txtNhiemVu.Text = null;
                this.checkBHXH.Checked = false;
                this.checkBHYT.Checked = false;
                this.cboLoaiHopDongLD.Text = "Có Thời Hạn";
                this.cboChucVuNguoiKy.Text = "Giám Đốc";
                this.txtNguoiKy.Text = null;
                ///
                this.txtSOQD.Text = null;
                this.dtNGAYQD.Value = DateTime.Now;
                this.txtNguoiKyThoiViec.Text = null;
                this.dtNGAYTV.Value = DateTime.Now;
                this.txtLyDoThoiViec.Text = null;


                this.IsAddNew = true;
                this.txtDiaDiemLamViec.Focus();
                this.itemXoaHopDong.Enabled = false;
            }
            #endregion

            #region BENCHAMDUTHOPDONGLAODONG

            if (ctrlNV == null)
                ctrlNV = new NhanVienCtrl();
            int kq = ctrlNV.TimNV_NghiViec(this.LayMaNhanVien_HopDongLaoDong_ThoiViec, 0);

            if (kq == 1)//Ton tai Nhan vien bi cham dut hop dong
            {
                //this.txtMANGHIVIEC.Text = LayMaNhanVien_NghiViec;
                //this.IsAddNew = false;

                if (ctrlHopDongLaoDong == null)
                    ctrlHopDongLaoDong = new HopDongLaoDong_ThoiViec_Ctrl();
                int kt = ctrlHopDongLaoDong.KiemTra(this.LayMaNhanVien_HopDongLaoDong_ThoiViec);

                if (kt == 1)//Ton tai Nhan vien bi cham dut hop dong
                {
                    this.chkChapNhan.Checked = true;
                }

            }
            else //Khong ton tai
            {

            }
            #endregion
        }
        #endregion

        #region itemThemMoi_Click        
       
        private void itemThemMoi_Click(object sender, EventArgs e)
        {
            if (!this.IsAddNew)
            {
                this.txtMaHD.Text = null;
                this.dtTuNgay.Value = DateTime.Now;
                this.dtDenNgay.Value = DateTime.Now;
                this.dtNgayKy.Value = DateTime.Now;
                this.txtChucDanhChuyenMon.Text = null;
                this.txtDiaDiemLamViec.Text = null;
                this.txtThoiGianLamViec.Text = null;
                this.txtTrangBiPT.Text = null;
                this.txtNhiemVu.Text = null;
                this.checkBHXH.Checked = false;
                this.checkBHYT.Checked = false;
                this.cboLoaiHopDongLD.Text = "Có Thời Hạn";
                this.cboChucVuNguoiKy.Text = "Giám Đốc";
                this.txtNguoiKy.Text = null;
                ///
                this.txtSOQD.Text = null;
                this.dtNGAYQD.Value = DateTime.Now;
                this.txtNguoiKyThoiViec.Text = null;
                this.dtNGAYTV.Value = DateTime.Now;
                this.txtLyDoThoiViec.Text = null;


                this.IsAddNew = true;
            }
            ctrlHopDongLaoDong.Create(txtMaHD);
            this.cboLoaiHopDongLD.Focus();
        }
        #endregion

        #region itemBoQua_Click        
        
        private void itemBoQua_Click(object sender, EventArgs e)
        {
            if (this.listViewExQTDaoTao.Items.Count > 0)
            {
                ctrlHopDongLaoDong.HienThiInfo(this.checkBHXH, this.checkBHYT, this.txtMaHD, this.cboLoaiHopDongLD, this.dtTuNgay, this.dtDenNgay, this.txtDiaDiemLamViec, this.txtChucDanhChuyenMon, this.txtNhiemVu, this.txtThoiGianLamViec, this.txtTrangBiPT, this.txtNguoiKy, this.cboChucVuNguoiKy, this.dtNgayKy, this.txtSOQD, dtNGAYQD, this.txtNguoiKyThoiViec, this.dtNGAYTV, this.txtLyDoThoiViec, (HopDongLaoDong_ThoiViec_Info)this.listViewExQTDaoTao.Items[this.SelectedIndex].Tag);
                if (this.IsAddNew)
                    this.IsAddNew = false;
            }
        }
        #endregion

        #region itemLuuHopDong_Click        
       
        private void itemLuuHopDong_Click(object sender, EventArgs e)
        {
            if (this.CheckValid())
            {
                HopDongLaoDong_ThoiViec_Info info = new HopDongLaoDong_ThoiViec_Info();
                info.MaHopDongLaoDong = this.txtMaHD.Text;
                info.MaNhanVien = this.LayMaNhanVien_HopDongLaoDong_ThoiViec;
                info.LoaiHopDong = this.cboLoaiHopDongLD.SelectedItem.ToString();
                info.TuNgay = this.dtTuNgay.Value;
                info.DenNgay = this.dtDenNgay.Value;
                info.DiaDiemLamViec = this.txtDiaDiemLamViec.Text;
                info.ChucDanhChuyenMon = this.txtChucDanhChuyenMon.Text;
                info.NhiemVu = this.txtNhiemVu.Text;
                info.ThoiGianLamViec = this.txtThoiGianLamViec.Text;
                info.TrangBiPhuongTien = this.txtTrangBiPT.Text;
                info.NguoiKy = this.txtNguoiKy.Text;
                info.ChucVu = this.cboChucVuNguoiKy.SelectedItem.ToString();
                info.NgayKy = this.dtNgayKy.Value;

                //////
                info.SoQuyetDinh = this.txtSOQD.Text;
                info.NgayQuyetDinh = this.dtNGAYQD.Value;
                info.NguoiKyThoiViec = this.txtNguoiKyThoiViec.Text;
                info.NgayThoiViec = this.dtNGAYTV.Value;
                info.LyDoTV = this.txtLyDoThoiViec.Text;

                ///////

                if (this.checkBHYT.Checked == true)
                {
                    info.ChonBHYT = int.Parse("1");
                }
                else
                {
                    info.ChonBHYT = int.Parse("0");
                }

                if (this.checkBHXH.Checked == true)
                {
                    info.ChonBHXH = int.Parse("1");
                }
                else
                {
                    info.ChonBHXH = int.Parse("0");
                }

                if (IsAddNew)
                {
                    if (ctrlHopDongLaoDong.Add(info))
                    {
                        this.IsAddNew = false;
                        MessageBoxEx.Show("Một dòng mới đã được thêm vào!", "Thêm Thành Công");
                    }
                    this.ReloadData();
                }
                else
                {
                    if (MessageBoxEx.Show("Ban có chắc là cập nhật dòng này không?", "Cập Nhật", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        ctrlHopDongLaoDong.CapNhatHopDongLaoDong_ThoiViec(info, SelectedIndex);
                        this.ReloadData();
                    }
                    ctrlHopDongLaoDong.HienThiInfo(this.checkBHXH, this.checkBHYT, this.txtMaHD, this.cboLoaiHopDongLD, this.dtTuNgay, this.dtDenNgay, this.txtDiaDiemLamViec, this.txtChucDanhChuyenMon, this.txtNhiemVu, this.txtThoiGianLamViec, this.txtTrangBiPT, this.txtNguoiKy, this.cboChucVuNguoiKy, this.dtNgayKy, this.txtSOQD, dtNGAYQD, this.txtNguoiKyThoiViec, this.dtNGAYTV, this.txtLyDoThoiViec, (HopDongLaoDong_ThoiViec_Info)this.listViewExQTDaoTao.Items[this.SelectedIndex].Tag);

                }
            }
        }
        #endregion

        #region itemXoaHopDong_Click        
       
        private void itemXoaHopDong_Click(object sender, EventArgs e)
        {
            if (MessageBoxEx.Show("Bạn có chắc là xóa dòng này không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                IEnumerator ie = this.listViewExQTDaoTao.SelectedItems.GetEnumerator();
                while (ie.MoveNext())
                {
                    ListViewItem item = (ListViewItem)ie.Current;
                    listViewExQTDaoTao.Items.Remove(item);
                    if (ctrlHopDongLaoDong == null)
                        ctrlHopDongLaoDong = new HopDongLaoDong_ThoiViec_Ctrl();
                    ctrlHopDongLaoDong.Xoa_HopDongLaoDong_ThoiViec(item.SubItems[0].Text);
                    if (this.SelectedIndex != 0)
                    {
                        this.SelectedIndex--;
                    }
                }
                this.ReloadData();
            }
        }
        #endregion

        #region itemThoatHopDong_Click        
       
        private void itemThoatHopDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region checkBoxThoiViec_CheckedChanged        
       
        private void checkBoxThoiViec_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxThoiViec.Checked == true)
            {

                if (this.listViewExQTDaoTao.Items.Count == 0)
                {
                    MessageBoxEx.Show("Không Thể Chấm dứt Hợp đồng lao động vì Chưa Ký Hợp Đồng Lao Động!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    checkBoxThoiViec.Checked = false;
                }
                else
                {
                    this.ChamDutHopDonggroupPanel.Enabled = true;
                    this.HopDongLaoDonggroupPanel.Enabled = false;
                    this.itemBoQua.Enabled = false;
                    this.itemLuuHopDong.Enabled = false;
                    this.itemThemMoi.Enabled = false;
                    this.itemThoatHopDong.Enabled = false;
                    this.itemXoaHopDong.Enabled = false;
                }

            }
            else
            {
                this.ChamDutHopDonggroupPanel.Enabled = false;
                this.HopDongLaoDonggroupPanel.Enabled = true;
                this.itemBoQua.Enabled = true;
                this.itemLuuHopDong.Enabled = true;
                this.itemThemMoi.Enabled = true;
                this.itemThoatHopDong.Enabled = true;
                this.itemXoaHopDong.Enabled = true;
                this.txtSOQD.Text = null;
                this.txtNguoiKyThoiViec.Text = null;
                this.txtLyDoThoiViec.Text = null;
                this.chkChapNhan.Checked = false;
            }
        }
        #endregion



        #region BENPHANCHAMDUTHOPDONGLAODONG        
        
        #region itemLuuChamDutHopDong_Click        
        
        private void itemLuuChamDutHopDong_Click(object sender, EventArgs e)
        {
            if (this.KiemTraChamDutHopDong())
            {
                HopDongLaoDong_ThoiViec_Info info = new HopDongLaoDong_ThoiViec_Info();
                info.MaHopDongLaoDong = this.txtMaHD.Text;
                info.MaNhanVien = this.LayMaNhanVien_HopDongLaoDong_ThoiViec;
                info.LoaiHopDong = this.cboLoaiHopDongLD.SelectedItem.ToString();
                info.TuNgay = this.dtTuNgay.Value;
                info.DenNgay = this.dtDenNgay.Value;
                info.DiaDiemLamViec = this.txtDiaDiemLamViec.Text;
                info.ChucDanhChuyenMon = this.txtChucDanhChuyenMon.Text;
                info.NhiemVu = this.txtNhiemVu.Text;
                info.ThoiGianLamViec = this.txtThoiGianLamViec.Text;
                info.TrangBiPhuongTien = this.txtTrangBiPT.Text;
                info.NguoiKy = this.txtNguoiKy.Text;
                info.ChucVu = this.cboChucVuNguoiKy.SelectedItem.ToString();
                info.NgayKy = this.dtNgayKy.Value;

                //////
                info.SoQuyetDinh = this.txtSOQD.Text;
                info.NgayQuyetDinh = this.dtNGAYQD.Value;
                info.NguoiKyThoiViec = this.txtNguoiKyThoiViec.Text;
                info.NgayThoiViec = this.dtNGAYTV.Value;
                info.LyDoTV = this.txtLyDoThoiViec.Text;

                ///////

                if (this.checkBHYT.Checked == true)
                {
                    info.ChonBHYT = int.Parse("1");
                }
                else
                {
                    info.ChonBHYT = int.Parse("0");
                }

                if (this.checkBHXH.Checked == true)
                {
                    info.ChonBHXH = int.Parse("1");
                }
                else
                {
                    info.ChonBHXH = int.Parse("0");
                }

                if (IsAddNew)
                {
                    if (ctrlHopDongLaoDong.Add(info))
                    {
                        this.IsAddNew = false;
                        MessageBoxEx.Show("Một dòng mới đã được thêm vào!", "Thêm Thành Công");
                    }
                    this.ReloadData();
                }
                else
                {

                    if (MessageBoxEx.Show("Ban có chắc là Chấm Dứt Hợp Đồng Lao Động Không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (ctrlNV == null)
                            ctrlNV = new NhanVienCtrl();
                        ctrlNV.Update_NhanVien(this.LayMaNhanVien_HopDongLaoDong_ThoiViec, 0);
                        //this.ReloadData();
                        MessageBoxEx.Show("Lưu Thành Công!", "Lưu Thành Công");
                    }
                    //ctrlHopDongLaoDong.HienThiInfo(this.checkBHXH, this.checkBHYT, this.txtMaHD, this.cboLoaiHopDongLD, this.dtTuNgay, this.dtDenNgay, this.txtDiaDiemLamViec, this.txtChucDanhChuyenMon, this.txtNhiemVu, this.txtThoiGianLamViec, this.txtTrangBiPT, this.txtNguoiKy, this.cboChucVuNguoiKy, this.dtNgayKy, this.txtSOQD, dtNGAYQD, this.txtNguoiKyThoiViec, this.dtNGAYTV, this.txtLyDoThoiViec, (HopDongLaoDong_ThoiViec_Info)this.listViewExQTDaoTao.Items[this.SelectedIndex].Tag);


                }
            }
        }
        #endregion

        #region KiemTraChamDutHopDong()
        private bool KiemTraChamDutHopDong()
        {

            if (this.txtSOQD.Text.Trim() == "")
            {
                MessageBoxEx.Show("Số quyết định không được phép rỗng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtSOQD.Focus();
                return false;
            }
            if (this.txtNguoiKyThoiViec.Text.Trim() == "")
            {
                MessageBoxEx.Show("Người ký quyết định Thôi Việc không được phép rỗng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtNguoiKyThoiViec.Focus();
                return false;
            }

            if (this.txtLyDoThoiViec.Text.Trim() == "")
            {
                MessageBoxEx.Show("Lý Do Thôi Việc không được phép rỗng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtLyDoThoiViec.Focus();
                return false;
            }
            if (this.dtNGAYTV.Value.Date < this.dtNGAYQD.Value.Date)
            {
                MessageBoxEx.Show("Ngày Thôi việc không được nhỏ hơn Ngày quyết định thôi việc !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.dtNGAYTV.Focus();
                return false;
            }

            if (this.chkChapNhan.Checked == false)
            {
                MessageBoxEx.Show("Bạn hãy check vào Ô xác nhận Chấm dứt Hợp đồng lao động !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            //if (this.listViewExQTDaoTao.Items.Count == 0)
            //{
            //    MessageBoxEx.Show("Không Thể Chấm dứt Hợp đồng lao động vì Chưa Ký Hợp Đồng Lao Động!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return false;
            //}

            return true;
        }
        #endregion

        #region itemThoat_Click        
       
        private void itemThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #endregion
    }
}