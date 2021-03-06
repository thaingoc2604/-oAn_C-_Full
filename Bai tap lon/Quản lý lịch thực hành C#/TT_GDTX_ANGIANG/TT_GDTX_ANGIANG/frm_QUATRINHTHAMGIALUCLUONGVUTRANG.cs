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
    public partial class frm_QUATRINHTHAMGIALUCLUONGVUTRANG : DevComponents.DotNetBar.Office2007Form
    {
        public frm_QUATRINHTHAMGIALUCLUONGVUTRANG()
        {
            InitializeComponent();
        }

        #region ctrlQTTGLucLuongVuTrang
        private QuaTrinhThamGiaLucLuongVuTrangCtrl m_ctrlQTTGLucLuongVuTrang;
        public QuaTrinhThamGiaLucLuongVuTrangCtrl ctrlQTTGLucLuongVuTrang
        {
            get { return m_ctrlQTTGLucLuongVuTrang; }
            set { m_ctrlQTTGLucLuongVuTrang = value; }
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

        private QuaTrinhThamGiaLucLuongVuTrangInfo m_QuaTrinhVuTrangSelected;
        public QuaTrinhThamGiaLucLuongVuTrangInfo QuaTrinhVuTrangSelected
        {
            get { return m_QuaTrinhVuTrangSelected; }
            set { m_QuaTrinhVuTrangSelected = value; }
        }

        private string m_Open;
        public string Open
        {
            get { return m_Open; }
            set { m_Open = value; }
        }

        private string m_MANV;
        public string LayMaNhanVien_QTVuTrang
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
            //Kiểm Tra Mã LL vũ trang
            if (this.txtMaLLVT.Text.Trim() == "" )
            {
                MessageBoxEx.Show("Chưa nhập Mã Lưc Lượng Vũ Trang, Hãy Nhấn Nút Thêm Mới!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.itemThemMoi.Focus();
                return false;
            }
            // Kiểm tra ngày
            if (this.dtNgayNN.Value.Date >= this.dtNgayXN.Value.Date)
            {
                MessageBoxEx.Show("Ngày Xuất Ngũ Thúc phải lớn hơn ngày Nhập Ngũ!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.dtNgayXN.Focus();
                return false;
            }
            //Kiểm tra chức vụ
            if (this.txtChucVu.Text.Trim() == "" )
            {
                MessageBox.Show("Chưa nhập Chức Vụ!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtChucVu.Focus();
                return false;
            }
            return true;
        }
        #endregion

        #region ReloadData()
        private void ReloadData()
        {
            if (ctrlQTTGLucLuongVuTrang == null)
            {
                ctrlQTTGLucLuongVuTrang = new QuaTrinhThamGiaLucLuongVuTrangCtrl();
            }
            ctrlQTTGLucLuongVuTrang.HienThi_dsQTTGLucLuongVuTrang(this.listViewExQTDaoTao,this.LayMaNhanVien_QTVuTrang);
            if (this.listViewExQTDaoTao.Items.Count > 0)
            {
                this.SelectedIndex = 0;
                this.listViewExQTDaoTao.Items[this.SelectedIndex].Selected = true;
                ctrlQTTGLucLuongVuTrang.HienThiInfo(this.txtMaLLVT, this.dtNgayNN, this.dtNgayXN , this.txtChucVu, this.txtQuanHam, (QuaTrinhThamGiaLucLuongVuTrangInfo)this.listViewExQTDaoTao.Items[this.SelectedIndex].Tag);

                this.IsAddNew = false;
                this.itemXoa.Enabled = true;
            }
            else
            {

                this.txtMaLLVT.Text = null;
                this.dtNgayNN.Text = null;
                this.dtNgayXN.Text = null;
                this.txtChucVu.Text = null;
                this.txtQuanHam.Text = null;                

                this.IsAddNew = true;
                this.txtMaLLVT.Focus();
                this.itemXoa.Enabled = false;
            }
        }
        #endregion


        #region frm_QUATRINHTHAMGIALUCLUONGVUTRANG_Load        
        
        private void frm_QUATRINHTHAMGIALUCLUONGVUTRANG_Load(object sender, EventArgs e)
        {
            if (An_Hien == "Xem")
            {
                this.PhanQuyen_Xem_An();
            }
            else
            {
                this.PhanQuyen_Xem_Hien();
            }

            if (ctrlQTTGLucLuongVuTrang == null)
            {
                ctrlQTTGLucLuongVuTrang = new QuaTrinhThamGiaLucLuongVuTrangCtrl();
            }
            ctrlQTTGLucLuongVuTrang.HienThi_dsQTTGLucLuongVuTrang(this.listViewExQTDaoTao,this.LayMaNhanVien_QTVuTrang);
            if (this.listViewExQTDaoTao.Items.Count > 0)
            {
                this.SelectedIndex = 0;
                this.listViewExQTDaoTao.Items[this.SelectedIndex].Selected = true;
                ctrlQTTGLucLuongVuTrang.HienThiInfo(this.txtMaLLVT, this.dtNgayNN, this.dtNgayXN, this.txtChucVu, this.txtQuanHam, (QuaTrinhThamGiaLucLuongVuTrangInfo)this.listViewExQTDaoTao.Items[this.SelectedIndex].Tag);

                this.IsAddNew = false;
                this.itemXoa.Enabled = true;
            }
            else
            {

                this.txtMaLLVT.Text = null;
                this.dtNgayNN.Text = null;
                this.dtNgayXN.Text = null;
                this.txtChucVu.Text = null;
                this.txtQuanHam.Text = null;

                this.IsAddNew = true;
                this.txtMaLLVT.Focus();
                this.itemXoa.Enabled = false;
            }
        }
        #endregion


        #region itemThemMoi_Click        
        
        private void itemThemMoi_Click(object sender, EventArgs e)
        {
            if (!this.IsAddNew)
            {
                this.txtMaLLVT.Text = null;
                this.dtNgayNN.Text = null;
                this.dtNgayXN.Text = null;
                this.txtChucVu.Text = null;
                this.txtQuanHam.Text = null;

                this.IsAddNew = true;

            }
            ctrlQTTGLucLuongVuTrang.Create(txtMaLLVT);
            this.txtMaLLVT.Focus();
        }
        #endregion


        #region itemBoQua_Click        
      
        private void itemBoQua_Click(object sender, EventArgs e)
        {
            if (this.listViewExQTDaoTao.Items.Count > 0)
            {
                ctrlQTTGLucLuongVuTrang.HienThiInfo(this.txtMaLLVT, this.dtNgayNN, this.dtNgayXN, this.txtChucVu, this.txtQuanHam, (QuaTrinhThamGiaLucLuongVuTrangInfo)this.listViewExQTDaoTao.Items[this.SelectedIndex].Tag);
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
                QuaTrinhThamGiaLucLuongVuTrangInfo info = new QuaTrinhThamGiaLucLuongVuTrangInfo();
                info.MaQuaTrinhThamGiaLucLuongVuTrang = this.txtMaLLVT.Text;
                info.MaNhanVien = this.LayMaNhanVien_QTVuTrang;
                info.NgayNN = this.dtNgayNN.Value;
                info.NgayXN = this.dtNgayXN.Value;
                info.ChucVu = this.txtChucVu.Text;
                info.QuanHamCaoNhat = this.txtQuanHam.Text;
                
                if (IsAddNew)
                {
                    if (ctrlQTTGLucLuongVuTrang.Add(info))
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
                        ctrlQTTGLucLuongVuTrang.CapNhatQuaTrinhThamGiaHoatDongVuTrang(info, SelectedIndex);
                        this.ReloadData();
                    }
                    ctrlQTTGLucLuongVuTrang.HienThiInfo(this.txtMaLLVT, this.dtNgayNN, this.dtNgayXN, this.txtChucVu, this.txtQuanHam, (QuaTrinhThamGiaLucLuongVuTrangInfo)this.listViewExQTDaoTao.Items[this.SelectedIndex].Tag);
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
                    if (ctrlQTTGLucLuongVuTrang == null)
                        ctrlQTTGLucLuongVuTrang = new QuaTrinhThamGiaLucLuongVuTrangCtrl();
                    ctrlQTTGLucLuongVuTrang.Xoa_QuaTrinhTGLLVuTrang(item.SubItems[0].Text);
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
                    ctrlQTTGLucLuongVuTrang.HienThiInfo(this.txtMaLLVT, this.dtNgayNN, this.dtNgayXN, this.txtChucVu, this.txtQuanHam, (QuaTrinhThamGiaLucLuongVuTrangInfo)this.listViewExQTDaoTao.Items[this.SelectedIndex].Tag);
                }
            }
        }
        #endregion
    }
}