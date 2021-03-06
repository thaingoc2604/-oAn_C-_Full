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
    public partial class frm_LICHSUBANTHAN : DevComponents.DotNetBar.Office2007Form
    {
        public frm_LICHSUBANTHAN()
        {
            InitializeComponent();
        }

        #region ctrlLichSuBanThan
        private LichSuBanThanCtrl m_ctrlLichSuBanThan;
        public LichSuBanThanCtrl ctrlLichSuBanThan
        {
            get { return m_ctrlLichSuBanThan; }
            set { m_ctrlLichSuBanThan = value; }
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

        private LichSuBanThanInfo m_LichSuBanThanSelected;
        public LichSuBanThanInfo LichSuBanThanSelected
        {
            get { return m_LichSuBanThanSelected; }
            set { m_LichSuBanThanSelected = value; }
        }

        private string m_Open;
        public string Open
        {
            get { return m_Open; }
            set { m_Open = value; }
        }

        private string m_MANV;
        public string LayMaNhanVien_LichSuBanThan
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

            if (this.txtMaLSBT.Text.Trim() == "")
            {
                MessageBoxEx.Show("Bạn Chưa Nhập Mã Lịch Sử Bản Thân, Hãy Nhấn Nút Thêm Mới!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.itemThemMoi.Focus();
                return false;
            }
            if (this.dtTuNgay.Value.Date >= this.dtDenNgay.Value.Date)
            {
                MessageBoxEx.Show("Ngày Kết Thúc phải lớn hơn ngày Bắt Đầu!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.dtDenNgay.Focus();
                return false;
            }
            if (this.txtNoiDung.Text.Trim() == "" )
            {
                MessageBoxEx.Show("Chưa nhập Nội Dung!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtNoiDung.Focus();
                return false;
            }
            return true;
        }
        #endregion

        #region ReloadData()
        private void ReloadData()
        {
            if (An_Hien == "Xem")
            {
                this.PhanQuyen_Xem_An();
            }
            else
            {
                this.PhanQuyen_Xem_Hien();
            }

            if (ctrlLichSuBanThan == null)
            {
                ctrlLichSuBanThan = new LichSuBanThanCtrl();
            }
            ctrlLichSuBanThan.HienThi_dsLichSuBanThan(this.listViewExQTDaoTao,this.LayMaNhanVien_LichSuBanThan);
            if (this.listViewExQTDaoTao.Items.Count > 0)
            {
                this.SelectedIndex = 0;
                this.listViewExQTDaoTao.Items[this.SelectedIndex].Selected = true;
                ctrlLichSuBanThan.HienThiInfo(this.txtMaLSBT, this.dtTuNgay, this.dtDenNgay, this.txtNoiDung, (LichSuBanThanInfo)this.listViewExQTDaoTao.Items[this.SelectedIndex].Tag);

                this.IsAddNew = false;
                this.itemXoa.Enabled = true;
            }
            else
            {

                this.txtMaLSBT.Text = null;
                this.dtTuNgay.Text = null;
                this.dtDenNgay.Text = null;
                this.txtNoiDung.Text = null;


                this.IsAddNew = true;
                this.txtMaLSBT.Focus();
                this.itemXoa.Enabled = false;
            }
        }
        #endregion


        #region frm_LICHSUBANTHAN_Load        
       
        private void frm_LICHSUBANTHAN_Load(object sender, EventArgs e)
        {
            if (An_Hien == "Xem")
            {
                this.PhanQuyen_Xem_An();
            }
            else
            {
                this.PhanQuyen_Xem_Hien();
            }

            if (ctrlLichSuBanThan == null)
            {
                ctrlLichSuBanThan = new LichSuBanThanCtrl();
            }
            ctrlLichSuBanThan.HienThi_dsLichSuBanThan(this.listViewExQTDaoTao,this.LayMaNhanVien_LichSuBanThan);
            if (this.listViewExQTDaoTao.Items.Count > 0)
            {
                this.SelectedIndex = 0;
                this.listViewExQTDaoTao.Items[this.SelectedIndex].Selected = true;
                ctrlLichSuBanThan.HienThiInfo(this.txtMaLSBT,this.dtTuNgay,this.dtDenNgay, this.txtNoiDung, (LichSuBanThanInfo)this.listViewExQTDaoTao.Items[this.SelectedIndex].Tag);

                this.IsAddNew = false;
                this.itemXoa.Enabled = true;
            }
            else
            {

                this.txtMaLSBT.Text = null;
                this.dtTuNgay.Text = null;
                this.dtDenNgay.Text = null;
                this.txtNoiDung.Text = null;            
               

                this.IsAddNew = true;
                this.txtMaLSBT.Focus();
                this.itemXoa.Enabled = false;
            }
        }
        #endregion


        #region itemThemMoi_Click        
      
        private void itemThemMoi_Click(object sender, EventArgs e)
        {
            if (!this.IsAddNew)
            {
                this.txtMaLSBT.Text = null;
                this.dtTuNgay.Text = null;
                this.dtDenNgay.Text = null; 
                this.txtNoiDung.Text = null;                             

                this.IsAddNew = true;

            }
            ctrlLichSuBanThan.Create(txtMaLSBT);
            this.dtTuNgay.Focus();
        }
        #endregion

        #region itemBoQua_Click        
       
        private void itemBoQua_Click(object sender, EventArgs e)
        {
            if (this.listViewExQTDaoTao.Items.Count > 0)
            {
                ctrlLichSuBanThan.HienThiInfo(this.txtMaLSBT, this.dtTuNgay, this.dtDenNgay, this.txtNoiDung, (LichSuBanThanInfo)this.listViewExQTDaoTao.Items[this.SelectedIndex].Tag);
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
                LichSuBanThanInfo info = new LichSuBanThanInfo();
                info.MaLichSuBanThan = this.txtMaLSBT.Text;
                info.MaNhanVien = this.LayMaNhanVien_LichSuBanThan;
                info.TuNgay = this.dtTuNgay.Value;
                info.DenNgay = this.dtDenNgay.Value;
                info.NoiDung = this.txtNoiDung.Text;
                
                if (IsAddNew)
                {
                    if (ctrlLichSuBanThan.Add(info))
                    {
                        this.IsAddNew = false;
                        MessageBoxEx.Show("Một dòng mới đã được thêm vào!", "Thêm Thành Công");
                    }
                    this.ReloadData();
                }
                else
                {
                    if (MessageBoxEx.Show("Bạn có chắc là cập nhật dòng này không?", "Cập Nhật", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        ctrlLichSuBanThan.CapNhatLichSuBanThan(info, SelectedIndex);
                        this.ReloadData();
                    }
                    ctrlLichSuBanThan.HienThiInfo(this.txtMaLSBT, this.dtTuNgay, this.dtDenNgay, this.txtNoiDung, (LichSuBanThanInfo)this.listViewExQTDaoTao.Items[this.SelectedIndex].Tag);
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
                    if (ctrlLichSuBanThan == null)
                        ctrlLichSuBanThan = new LichSuBanThanCtrl();
                    ctrlLichSuBanThan.Xoa_LichSuBanThan(item.SubItems[0].Text);
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
                    ctrlLichSuBanThan.HienThiInfo(this.txtMaLSBT, this.dtTuNgay, this.dtDenNgay, this.txtNoiDung, (LichSuBanThanInfo)this.listViewExQTDaoTao.Items[this.SelectedIndex].Tag);
                }
            }
        }
        #endregion
    }
}