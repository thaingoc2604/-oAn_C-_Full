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
    public partial class frm_KYLUAT : DevComponents.DotNetBar.Office2007Form
    {
        public frm_KYLUAT()
        {
            InitializeComponent();
        }


        #region ctrlKyLuat
        private KyLuatCtrl m_ctrlKyLuat;
        public KyLuatCtrl ctrlKyLuat
        {
            get { return m_ctrlKyLuat; }
            set { m_ctrlKyLuat = value; }
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

        private KyLuatInfo m_KyLuatSelected;
        public KyLuatInfo KyLuatSelected
        {
            get { return m_KyLuatSelected; }
            set { m_KyLuatSelected = value; }
        }

        private string m_Open;
        public string Open
        {
            get { return m_Open; }
            set { m_Open = value; }
        }

        private string m_MANV;
        public string LayMaNhanVien_BiKyLuat
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
            if (this.txtMaKT.Text.Trim() == "")
            {
                MessageBoxEx.Show("Chưa nhập Mã Kỷ Luật, Hãy Nhấn Nút Thêm Mới!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.itemThemMoi.Focus();
                return false;
            }

            if (this.txtCoQuanKT.Text.Trim() == "")
            {
                MessageBoxEx.Show("Chưa nhập Tên Cơ Quan Kỷ Luật!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtCoQuanKT.Focus();
                return false;
            }

            if (this.txtHinhThuc.Text.Trim() == "")
            {
                MessageBoxEx.Show("Chưa nhập Hình Thức Kỷ Luật!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtHinhThuc.Focus();
                return false;
            }

            if (this.txtLyDo.Text.Trim() == "")
            {
                MessageBoxEx.Show("Chưa nhập Lý Do Kỷ Luật!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtLyDo.Focus();
                return false;
            }

            if (this.txtNguoiKy.Text.Trim() == "")
            {
                MessageBoxEx.Show("Chưa nhập Tên Người Ký!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtNguoiKy.Focus();
                return false;
            }
            return true;
        }
        #endregion

        #region ReloadData()
        private void ReloadData()
        {
            if (ctrlKyLuat == null)
            {
                ctrlKyLuat = new KyLuatCtrl();
            }
            ctrlKyLuat.HienThi_dsKyLuat(this.listViewExQTDaoTao,this.LayMaNhanVien_BiKyLuat);
            if (this.listViewExQTDaoTao.Items.Count > 0)
            {
                this.SelectedIndex = 0;
                this.listViewExQTDaoTao.Items[this.SelectedIndex].Selected = true;
                ctrlKyLuat.HienThiInfo(this.txtMaKT, this.cboSoQD, this.dtNgayQD, this.txtCoQuanKT, this.txtHinhThuc, this.txtLyDo, this.txtNguoiKy, this.txtGhiChu, (KyLuatInfo)this.listViewExQTDaoTao.Items[this.SelectedIndex].Tag);

                this.IsAddNew = false;
                this.itemXoa.Enabled = true;
            }
            else
            {

                this.txtMaKT.Text = null;
                
                this.dtNgayQD.Text = null;
                this.txtCoQuanKT.Text = null;
                this.txtHinhThuc.Text = null;
                this.txtLyDo.Text = null;
                this.txtNguoiKy.Text = null;
                this.txtGhiChu.Text = null;

                this.IsAddNew = true;
                this.cboSoQD.Focus();
                this.itemXoa.Enabled = false;
            }
        }
        #endregion


        #region frm_KYLUAT_Load        
        
        private void frm_KYLUAT_Load(object sender, EventArgs e)
        {
            #region HienThiCombobox
            SoQuyetDinhCtrl ctrlPB = new SoQuyetDinhCtrl();
            ctrlPB.HienThiComboBox(cboSoQD);
            #endregion
            if (An_Hien == "Xem")
            {
                this.PhanQuyen_Xem_An();
            }
            else
            {
                this.PhanQuyen_Xem_Hien();
            }

            if (ctrlKyLuat == null)
            {
                ctrlKyLuat = new KyLuatCtrl();
            }
            ctrlKyLuat.HienThi_dsKyLuat(this.listViewExQTDaoTao,this.LayMaNhanVien_BiKyLuat);
            if (this.listViewExQTDaoTao.Items.Count > 0)
            {
                this.SelectedIndex = 0;
                this.listViewExQTDaoTao.Items[this.SelectedIndex].Selected = true;
                ctrlKyLuat.HienThiInfo(this.txtMaKT, this.cboSoQD, this.dtNgayQD, this.txtCoQuanKT, this.txtHinhThuc, this.txtLyDo, this.txtNguoiKy, this.txtGhiChu, (KyLuatInfo)this.listViewExQTDaoTao.Items[this.SelectedIndex].Tag);

                this.IsAddNew = false;
                this.itemXoa.Enabled = true;
            }
            else
            {

                this.txtMaKT.Text = null;
              
                this.dtNgayQD.Text = null;
                this.txtCoQuanKT.Text = null;
                this.txtHinhThuc.Text = null;
                this.txtLyDo.Text = null;
                this.txtNguoiKy.Text = null;
                this.txtGhiChu.Text = null;

                this.IsAddNew = true;
                this.cboSoQD.Focus();
                this.itemXoa.Enabled = false;
            }
        }
        #endregion

        #region itemThemMoi_Click       
       
        private void itemThemMoi_Click(object sender, EventArgs e)
        {
            if (!this.IsAddNew)
            {
                this.txtMaKT.Text = null;                
                this.dtNgayQD.Text = null;
                this.txtCoQuanKT.Text = null;
                this.txtHinhThuc.Text = null;
                this.txtLyDo.Text = null;
                this.txtNguoiKy.Text = null;
                this.txtGhiChu.Text = null;

                this.IsAddNew = true;

            }
            ctrlKyLuat.Create(txtMaKT);
            this.cboSoQD.Focus();
        }
        #endregion

        #region itemBoQua_Click        
       
        private void itemBoQua_Click(object sender, EventArgs e)
        {
            if (this.listViewExQTDaoTao.Items.Count > 0)
            {
                ctrlKyLuat.HienThiInfo(this.txtMaKT, this.cboSoQD, this.dtNgayQD, this.txtCoQuanKT, this.txtHinhThuc, this.txtLyDo, this.txtNguoiKy, this.txtGhiChu, (KyLuatInfo)this.listViewExQTDaoTao.Items[this.SelectedIndex].Tag);
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
                KyLuatInfo info = new KyLuatInfo();
                info.MaQuaTrinhKyLuat = this.txtMaKT.Text;
                info.MaNhanVien = this.LayMaNhanVien_BiKyLuat;

                SoQuyetDinhCtrl ctrl = new SoQuyetDinhCtrl();
                info.SoQuyetDinh = ctrl.GetSoQuyetDinh(this.cboSoQD.SelectedValue.ToString());

                info.NgayQuyetDinh = this.dtNgayQD.Value;
                info.CoQuanKyLuat = this.txtCoQuanKT.Text;
                info.HinhThuc = this.txtHinhThuc.Text;
                info.LyDo = this.txtLyDo.Text;
                info.NguoiKy = this.txtNguoiKy.Text;
                info.GhiChu = this.txtGhiChu.Text;

                if (IsAddNew)
                {
                    if (ctrlKyLuat.Add(info))
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
                        ctrlKyLuat.CapNhatQTKyLuat(info, SelectedIndex);
                        this.ReloadData();
                    }
                    ctrlKyLuat.HienThiInfo(this.txtMaKT, this.cboSoQD, this.dtNgayQD, this.txtCoQuanKT, this.txtHinhThuc, this.txtLyDo, this.txtNguoiKy, this.txtGhiChu, (KyLuatInfo)this.listViewExQTDaoTao.Items[this.SelectedIndex].Tag);
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
                    if (ctrlKyLuat == null)
                        ctrlKyLuat = new KyLuatCtrl();
                    ctrlKyLuat.Xoa_KyLuat(item.SubItems[0].Text);
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
                ctrlKyLuat.HienThiInfo(this.txtMaKT, this.cboSoQD, this.dtNgayQD, this.txtCoQuanKT, this.txtHinhThuc, this.txtLyDo, this.txtNguoiKy, this.txtGhiChu, (KyLuatInfo)this.listViewExQTDaoTao.Items[this.SelectedIndex].Tag);
            }
        }
        #endregion

        #region btThemQDinh_Click        
        
        private void btThemQDinh_Click(object sender, EventArgs e)
        {
            frm_SOQUYETDINH soQD = new frm_SOQUYETDINH();
            soQD.Show();
        }
        #endregion
    }
}