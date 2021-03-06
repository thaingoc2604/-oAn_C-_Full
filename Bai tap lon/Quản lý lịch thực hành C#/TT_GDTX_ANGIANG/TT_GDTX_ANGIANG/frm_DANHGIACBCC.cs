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
    public partial class frm_DANHGIACBCC : DevComponents.DotNetBar.Office2007Form
    {
        public frm_DANHGIACBCC()
        {
            InitializeComponent();
        }

        #region ctrlDanhGiaCBCC
        private DanhGiaCBCCCtrl m_ctrlDanhGiaCBCC;
        public DanhGiaCBCCCtrl ctrlDanhGiaCBCC
        {
            get { return m_ctrlDanhGiaCBCC; }
            set { m_ctrlDanhGiaCBCC = value; }
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

        private DanhGiaCBCCInfo m_DanhGiaSelected;
        public DanhGiaCBCCInfo DanhGiaSelected
        {
            get { return m_DanhGiaSelected; }
            set { m_DanhGiaSelected = value; }
        }

        private string m_Open;
        public string Open
        {
            get { return m_Open; }
            set { m_Open = value; }
        }

        private string m_MANV;
        public string LayMaNhanVien_DanhGiaCB
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
            if (this.txtMaDG.Text.Trim() == "")
            {
                MessageBoxEx.Show("Chưa Nhấn Nút Thêm Mới!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.itemThemMoi.Focus();
                return false;
            }
            if (this.txtDotDG.Text.Trim() == "" )
            {
                MessageBoxEx.Show("Chưa nhập Tên quốc tịch!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtDotDG.Focus();
                return false;
            }
            if (this.cboSucKhoe.Text.Trim() == "")
            {
                MessageBoxEx.Show("Chưa Chọn Xếp Loại Sức Khỏe!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.cboSucKhoe.Focus();
                return false;
            }
            if (this.cboDaoDuc.Text.Trim() == "")
            {
                MessageBoxEx.Show("Chưa Chọn Xếp Loại Đạo Đức!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.cboDaoDuc.Focus();
                return false;
            }
            if (this.cboTrinhDoChuyenMon.Text.Trim() == "")
            {
                MessageBoxEx.Show("Chưa Chọn Xếp Loại Trình Độ Chuyên Môn!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.cboTrinhDoChuyenMon.Focus();
                return false;
            }
            if (this.cboXepLoaiChung.Text.Trim() == "")
            {
                MessageBoxEx.Show("Chưa Chọn Xếp Loại Chung!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.cboXepLoaiChung.Focus();
                return false;
            }
            if (this.txtNhatXet.Text.Trim() == "")
            {
                MessageBoxEx.Show("Chưa Có Nhận Xét Đánh Giá!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtNhatXet.Focus();
                return false;
            }



            return true;
        }
        #endregion

        #region ReloadData()
        private void ReloadData()
        {
            if (ctrlDanhGiaCBCC == null)
            {
                ctrlDanhGiaCBCC = new DanhGiaCBCCCtrl();
            }
            ctrlDanhGiaCBCC.HienThi_dsDanhGiaCBCC(this.listViewExQTDaoTao,this.LayMaNhanVien_DanhGiaCB);
            if (this.listViewExQTDaoTao.Items.Count > 0)
            {
                this.SelectedIndex = 0;
                this.listViewExQTDaoTao.Items[this.SelectedIndex].Selected = true;
                ctrlDanhGiaCBCC.HienThiInfo(this.txtMaDG, this.txtDotDG, this.dtNgayDG, this.cboSucKhoe, this.cboDaoDuc, this.cboTrinhDoChuyenMon, this.cboXepLoaiChung, this.txtNhatXet, (DanhGiaCBCCInfo)this.listViewExQTDaoTao.Items[this.SelectedIndex].Tag);

                this.IsAddNew = false;
                this.itemXoa.Enabled = true;
            }
            else
            {

                this.txtMaDG.Text = null;
                this.txtDotDG.Text = null;
                this.dtNgayDG.Text = null;
                this.txtNhatXet.Text = null;
                this.cboDaoDuc.Text = "Tốt";
                this.cboSucKhoe.Text = "Tốt";
                this.cboTrinhDoChuyenMon.Text = "Xuất Sắc";
                this.cboXepLoaiChung.Text = "Xuất Sắc";

                this.IsAddNew = true;
                this.txtDotDG.Focus();
                this.itemXoa.Enabled = false;
            }
        }
        #endregion

        private void frm_DANHGIACBCC_Load(object sender, EventArgs e)
        {
            if (An_Hien == "Xem")
            {
                this.PhanQuyen_Xem_An();
            }
            else
            {
                this.PhanQuyen_Xem_Hien();
            }

            if (ctrlDanhGiaCBCC == null)
            {
                ctrlDanhGiaCBCC = new DanhGiaCBCCCtrl();
            }
            ctrlDanhGiaCBCC.HienThi_dsDanhGiaCBCC(this.listViewExQTDaoTao,this.LayMaNhanVien_DanhGiaCB);
            if (this.listViewExQTDaoTao.Items.Count > 0)
            {
                this.SelectedIndex = 0;
                this.listViewExQTDaoTao.Items[this.SelectedIndex].Selected = true;
                ctrlDanhGiaCBCC.HienThiInfo(this.txtMaDG, this.txtDotDG, this.dtNgayDG, this.cboSucKhoe, this.cboDaoDuc, this.cboTrinhDoChuyenMon, this.cboXepLoaiChung, this.txtNhatXet, (DanhGiaCBCCInfo)this.listViewExQTDaoTao.Items[this.SelectedIndex].Tag);

                this.IsAddNew = false;
                this.itemXoa.Enabled = true;
            }
            else
            {

                this.txtMaDG.Text = null;
                this.txtDotDG.Text = null;
                this.dtNgayDG.Text = null;               
                this.txtNhatXet.Text = null;
                this.cboDaoDuc.Text = "Tốt";
                this.cboSucKhoe.Text = "Tốt";
                this.cboTrinhDoChuyenMon.Text = "Xuất Sắc";
                this.cboXepLoaiChung.Text = "Xuất Sắc";

                this.IsAddNew = true;
                this.txtDotDG.Focus();
                this.itemXoa.Enabled = false;
            }
        }

        private void itemThemMoi_Click(object sender, EventArgs e)
        {
            if (!this.IsAddNew)
            {
                this.txtMaDG.Text = null;
                this.txtDotDG.Text = null;
                this.dtNgayDG.Text = null;
                this.txtNhatXet.Text = null;
                this.cboDaoDuc.Text = "Tốt";
                this.cboSucKhoe.Text = "Tốt";
                this.cboTrinhDoChuyenMon.Text = "Xuất Sắc";
                this.cboXepLoaiChung.Text = "Xuất Sắc";

                this.IsAddNew = true;

            }
            ctrlDanhGiaCBCC.Create(txtMaDG);
            this.txtDotDG.Focus();
        }

        private void itemBoQua_Click(object sender, EventArgs e)
        {
            if (this.listViewExQTDaoTao.Items.Count > 0)
            {
                ctrlDanhGiaCBCC.HienThiInfo(this.txtMaDG, this.txtDotDG, this.dtNgayDG, this.cboSucKhoe, this.cboDaoDuc, this.cboTrinhDoChuyenMon, this.cboXepLoaiChung, this.txtNhatXet, (DanhGiaCBCCInfo)this.listViewExQTDaoTao.Items[this.SelectedIndex].Tag);
                if (this.IsAddNew)
                    this.IsAddNew = false;
            }
        }

        private void itemLuu_Click(object sender, EventArgs e)
        {

            if (this.CheckValid())
            {
                DanhGiaCBCCInfo info = new DanhGiaCBCCInfo();
                info.MaDanhGiaCBCC = this.txtMaDG.Text;
                info.MaNhanVien = this.LayMaNhanVien_DanhGiaCB;
                info.DotDanhGia = this.txtDotDG.Text;
                info.NgayDanhGia = this.dtNgayDG.Value;                
                info.XepLoaiSucKhoe = this.cboSucKhoe.Text;
                info.XepLoaiDaoDuc = this.cboDaoDuc.Text;
                info.XepLoaiTDChuyenMon = this.cboTrinhDoChuyenMon.Text;
                info.XepLoaiChung = this.cboXepLoaiChung.Text;
                info.NhanXet = this.txtNhatXet.Text;
                if (IsAddNew)
                {
                    if (ctrlDanhGiaCBCC.Add(info))
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
                        ctrlDanhGiaCBCC.CapNhatDanhGiaCanBoCongChuc(info, SelectedIndex);
                        this.ReloadData();
                    }
                    
                }
            }
        }

        private void itemXoa_Click(object sender, EventArgs e)
        {
            if (MessageBoxEx.Show("Bạn có chắc là xóa dòng này không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                IEnumerator ie = this.listViewExQTDaoTao.SelectedItems.GetEnumerator();
                while (ie.MoveNext())
                {
                    ListViewItem item = (ListViewItem)ie.Current;
                    listViewExQTDaoTao.Items.Remove(item);
                    if (ctrlDanhGiaCBCC == null)
                        ctrlDanhGiaCBCC = new DanhGiaCBCCCtrl();
                    ctrlDanhGiaCBCC.Xoa_DanhGia_CBCC(item.SubItems[0].Text);
                    if (this.SelectedIndex != 0)
                    {
                        this.SelectedIndex--;
                    }
                }
                this.ReloadData();
            }
        }

        private void itemThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listViewExDanToc_SelectedIndexChanged(object sender, EventArgs e)
        {
            IEnumerator ie = this.listViewExQTDaoTao.SelectedItems.GetEnumerator();
            if (ie.MoveNext())
            {
                this.listViewExQTDaoTao.Items[this.SelectedIndex].ImageIndex = -1;
                this.listViewExQTDaoTao.Items[this.SelectedIndex].BackColor = Color.White;
                this.listViewExQTDaoTao.Items[this.SelectedIndex].ForeColor = Color.Black;

                ListViewItem item = (ListViewItem)ie.Current;
                item.ImageIndex = 0;
                item.BackColor = Color.FromArgb(100, 160, 255);
                item.ForeColor = Color.White;

                this.SelectedIndex = this.listViewExQTDaoTao.Items.IndexOf(item);
                ctrlDanhGiaCBCC.HienThiInfo(this.txtMaDG, this.txtDotDG, this.dtNgayDG, this.cboSucKhoe, this.cboDaoDuc, this.cboTrinhDoChuyenMon, this.cboXepLoaiChung, this.txtNhatXet, (DanhGiaCBCCInfo)this.listViewExQTDaoTao.Items[this.SelectedIndex].Tag);
            }
        }
    }
}