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
    public partial class frm_HOPDONGLAODONG : DevComponents.DotNetBar.Office2007Form
    {
        public frm_HOPDONGLAODONG()
        {
            InitializeComponent();
        }

        #region ctrlHopDongLaoDong
        private HopDongLaoDongCtrl m_ctrlHopDongLaoDong;
        public HopDongLaoDongCtrl ctrlHopDongLaoDong
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

        private HopDongLaoDongInfo m_HopDongLaoDongSelected;
        public HopDongLaoDongInfo HopDongLaoDongSelected
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
        public string LayMaNhanVien_HopDongLaoDong
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
            if (this.txtMaHD.Text.Trim() == "" )
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
            if (this.txtDiaDiemLamViec.Text.Trim() == "" )
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
            if (this.txtNgach.Text.Trim() == "")
            {
                MessageBoxEx.Show("Chưa nhập Mã Ngạch!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtNgach.Focus();
                return false;
            }
            if (this.dbBac.Text.Trim() == "")
            {
                MessageBoxEx.Show("Chưa nhập Bậc Lương!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.dbBac.Focus();
                return false;
            }
            if (this.dbHSLuong.Text.Trim() == "")
            {
                MessageBoxEx.Show("Chưa nhập Hệ Số Lương!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.dbHSLuong.Focus();
                return false;
            }
            if (this.txtNguoiKy.Text.Trim() == "")
            {
                MessageBoxEx.Show("Chưa nhập Người Ký Tên !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtNguoiKy.Focus();
                return false;
            }
            if (this.txtPhuCap.Text.Trim() == "")
            {
                MessageBoxEx.Show("Chưa nhập Phu cap !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtPhuCap.Focus();
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
                ctrlHopDongLaoDong = new HopDongLaoDongCtrl();
            }


            ctrlHopDongLaoDong.HienThi_dsHopDongLaoDong(this.listViewExQTDaoTao,this.LayMaNhanVien_HopDongLaoDong);
            if (this.listViewExQTDaoTao.Items.Count > 0)
            {
                this.SelectedIndex = 0;
                this.listViewExQTDaoTao.Items[this.SelectedIndex].Selected = true;
                ctrlHopDongLaoDong.HienThiInfo(this.checkBHXH,this.checkBHYT, this.txtMaHD, this.cboLoaiHopDongLD, this.dtTuNgay, this.dtDenNgay, this.txtDiaDiemLamViec, this.txtChucDanhChuyenMon, this.txtNhiemVu, this.txtThoiGianLamViec, this.txtTrangBiPT, this.txtNgach, this.dbBac, this.dbHSLuong, this.txtPhuCap, this.txtNguoiKy, this.cboChucVuNguoiKy, this.dtNgayKy, (HopDongLaoDongInfo)this.listViewExQTDaoTao.Items[this.SelectedIndex].Tag); 

                this.IsAddNew = false;
                this.itemXoa.Enabled = true;
            }
            else
            {

                this.txtMaHD.Text = null;
                this.dtTuNgay.Text = null;
                this.dtDenNgay.Text = null;
                this.dtNgayKy.Text = null;
                this.txtChucDanhChuyenMon.Text = null;
                this.txtDiaDiemLamViec.Text = null;
                this.dbBac.Text = "1";
                this.dbHSLuong.Text = "1";
                this.txtNgach.Text = null;
                this.txtNguoiKy.Text = null;
                this.txtPhuCap.Text = null;
                this.txtThoiGianLamViec.Text = null;
                this.txtTrangBiPT.Text = null;
                this.txtNhiemVu.Text = null;


                this.IsAddNew = true;
                this.txtDiaDiemLamViec.Focus();
                this.itemXoa.Enabled = false;
            }
        }
        #endregion

        #region frm_HOPDONGLAODONG_Load        
       
        private void frm_HOPDONGLAODONG_Load(object sender, EventArgs e)
        {
            

            if (An_Hien == "Xem")
            {
                this.PhanQuyen_Xem_An();
            }
            else
            {
                this.PhanQuyen_Xem_Hien();
            }

            //this.lbl_NhanVien.Text = "Nhân Viên" + ": " + this.LayTenNhanVien;


            if (ctrlHopDongLaoDong == null)
            {
                ctrlHopDongLaoDong = new HopDongLaoDongCtrl();
            }


            ctrlHopDongLaoDong.HienThi_dsHopDongLaoDong(this.listViewExQTDaoTao,this.LayMaNhanVien_HopDongLaoDong);
            if (this.listViewExQTDaoTao.Items.Count > 0)
            {
                HopDongLaoDongData datahopdong = new HopDongLaoDongData();
                datahopdong.lay_dsHopDongDS(LayMaNhanVien_HopDongLaoDong);
                DataTable Table = new DataTable();
                Table = datahopdong.lay_dsHopDongDS(LayMaNhanVien_HopDongLaoDong);
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
                ctrlHopDongLaoDong.HienThiInfo(this.checkBHXH, this.checkBHYT, this.txtMaHD, this.cboLoaiHopDongLD, this.dtTuNgay, this.dtDenNgay, this.txtDiaDiemLamViec, this.txtChucDanhChuyenMon, this.txtNhiemVu, this.txtThoiGianLamViec, this.txtTrangBiPT, this.txtNgach, this.dbBac, this.dbHSLuong, this.txtPhuCap, this.txtNguoiKy, this.cboChucVuNguoiKy, this.dtNgayKy, (HopDongLaoDongInfo)this.listViewExQTDaoTao.Items[this.SelectedIndex].Tag);
                if (dtDenNgay.Value.ToShortDateString() == System.DateTime.Now.ToShortDateString())
                {
                    MessageBox.Show("Hợp đồng lao động đã hết hạn");
                    
                }
                this.IsAddNew = false;
                this.itemXoa.Enabled = true;
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
                this.dbBac.Text = null;
                this.dbHSLuong.Text = null;
                this.txtNgach.Text = null;
                this.txtNguoiKy.Text = null;
                this.txtPhuCap.Text = null;
                this.txtThoiGianLamViec.Text = null;
                this.txtTrangBiPT.Text = null;
                this.txtNhiemVu.Text = null;
                

                this.IsAddNew = true;
                this.txtDiaDiemLamViec.Focus();
                this.itemXoa.Enabled = false;
            }
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
                this.dbHSLuong.Text = "1";
                this.dbBac.Text = "1";
                this.txtNgach.Text = null;
                this.txtNguoiKy.Text = null;
                this.txtPhuCap.Text = null;
                this.txtThoiGianLamViec.Text = null;
                this.txtTrangBiPT.Text = null;
                this.txtNhiemVu.Text = null;
                this.checkBHXH.Checked = false;
                this.checkBHYT.Checked = false;
            //    this.cboLoaiHopDongLD.Text = HopDongLaoDongSelected.LoaiHopDong;
              //  this.cboChucVuNguoiKy.Text = HopDongLaoDongSelected.ChucVu;


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
                ctrlHopDongLaoDong.HienThiInfo(this.checkBHXH, this.checkBHYT, this.txtMaHD, this.cboLoaiHopDongLD, this.dtTuNgay, this.dtDenNgay, this.txtDiaDiemLamViec, this.txtChucDanhChuyenMon, this.txtNhiemVu, this.txtThoiGianLamViec, this.txtTrangBiPT, this.txtNgach, this.dbBac, this.dbHSLuong, this.txtPhuCap, this.txtNguoiKy, this.cboChucVuNguoiKy, this.dtNgayKy, (HopDongLaoDongInfo)this.listViewExQTDaoTao.Items[this.SelectedIndex].Tag);  
                if (this.IsAddNew)
                    this.IsAddNew = false;
            }
        }
        #endregion


        #region itemLuu_Click        
       
        private void itemLuu_Click(object sender, EventArgs e)
        {
            if (this.CheckValid())
            {
                HopDongLaoDongInfo info = new HopDongLaoDongInfo();
                info.MaHopDongLaoDong = this.txtMaHD.Text;
                info.MaNhanVien = this.LayMaNhanVien_HopDongLaoDong;
                info.LoaiHopDong = this.cboLoaiHopDongLD.SelectedItem.ToString();
                info.TuNgay = this.dtTuNgay.Value;
                info.DenNgay = this.dtDenNgay.Value;
                info.DiaDiemLamViec = this.txtDiaDiemLamViec.Text;
                info.ChucDanhChuyenMon = this.txtChucDanhChuyenMon.Text;
                info.NhiemVu = this.txtNhiemVu.Text;
                info.ThoiGianLamViec = this.txtThoiGianLamViec.Text;
                info.TrangBiPhuongTien = this.txtTrangBiPT.Text;
                info.Ngach = this.txtNgach.Text;
                info.Bac = int.Parse(this.dbBac.Text);
                info.HeSoLuong = float.Parse(this.dbHSLuong.Text);
                info.PhuCap = this.txtPhuCap.Text;
                info.NguoiKy = this.txtNguoiKy.Text;
                info.ChucVu = this.cboChucVuNguoiKy.SelectedItem.ToString();
                info.NgayKy = this.dtNgayKy.Value;

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
                        ctrlHopDongLaoDong.CapNhatHopDongLaoDong(info, SelectedIndex);
                        this.ReloadData();
                    }
                    ctrlHopDongLaoDong.HienThiInfo(this.checkBHXH, this.checkBHYT, this.txtMaHD, this.cboLoaiHopDongLD, this.dtTuNgay, this.dtDenNgay, this.txtDiaDiemLamViec, this.txtChucDanhChuyenMon, this.txtNhiemVu, this.txtThoiGianLamViec, this.txtTrangBiPT, this.txtNgach, this.dbBac, this.dbHSLuong, this.txtPhuCap, this.txtNguoiKy, this.cboChucVuNguoiKy, this.dtNgayKy, (HopDongLaoDongInfo)this.listViewExQTDaoTao.Items[this.SelectedIndex].Tag);  

                }
            }
        }
        #endregion


        #region listViewExDanToc_SelectedIndexChanged        
        
        private void listViewExDanToc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listViewExQTDaoTao.Items.Count > 0)
            {
                IEnumerator ie = this.listViewExQTDaoTao.SelectedItems.GetEnumerator();
                if (ie.MoveNext())
                {
                    this.listViewExQTDaoTao.Items[this.SelectedIndex].ImageIndex = -1;
                    this.listViewExQTDaoTao.Items[this.SelectedIndex].BackColor = Color.White;
                    this.listViewExQTDaoTao.Items[this.SelectedIndex].ForeColor = Color.Black;

                    ListViewItem item = (ListViewItem)ie.Current;
                    item.ImageIndex = 0;
                    item.BackColor = Color.FromArgb(100, 150, 255);
                    item.ForeColor = Color.White;

                    this.SelectedIndex = this.listViewExQTDaoTao.Items.IndexOf(item);
                    ctrlHopDongLaoDong.HienThiInfo(this.checkBHXH, this.checkBHYT, this.txtMaHD, this.cboLoaiHopDongLD, this.dtTuNgay, this.dtDenNgay, this.txtDiaDiemLamViec, this.txtChucDanhChuyenMon, this.txtNhiemVu, this.txtThoiGianLamViec, this.txtTrangBiPT, this.txtNgach, this.dbBac, this.dbHSLuong, this.txtPhuCap, this.txtNguoiKy, this.cboChucVuNguoiKy, this.dtNgayKy, (HopDongLaoDongInfo)this.listViewExQTDaoTao.Items[this.SelectedIndex].Tag);  
                }
            }
        }
        #endregion

        #region itemXoa_Click        
       
        private void itemXoa_Click(object sender, EventArgs e)
        {
            if (MessageBoxEx.Show("Bạn có chắc là xóa dòng này không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                IEnumerator ie = this.listViewExQTDaoTao.SelectedItems.GetEnumerator();
                while (ie.MoveNext())
                {
                    ListViewItem item = (ListViewItem)ie.Current;
                    listViewExQTDaoTao.Items.Remove(item);
                    if (ctrlHopDongLaoDong == null)
                        ctrlHopDongLaoDong = new HopDongLaoDongCtrl();
                    ctrlHopDongLaoDong.Xoa_HopDongLaoDong(item.SubItems[0].Text);
                    if (this.SelectedIndex != 0)
                    {
                        this.SelectedIndex--;
                    }
                }
                this.ReloadData();
            }
        }
        #endregion

        #region itemThoat_Click        
       
        private void itemThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}