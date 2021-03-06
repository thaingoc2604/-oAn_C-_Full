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
    public partial class frm_TRINHDOTINHOC : DevComponents.DotNetBar.Office2007Form
    {
        public frm_TRINHDOTINHOC()
        {
            InitializeComponent();
        }

        public int Index = 0;

        #region ctrlChucVu
        private TrinhDo_TinHocCtrl m_ctrlTrinhDoTinHoc;
        public TrinhDo_TinHocCtrl ctrlTrinhDoTinHoc
        {
            get { return m_ctrlTrinhDoTinHoc; }
            set { m_ctrlTrinhDoTinHoc = value; }
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

        #region Property
        private string m_Enable;
        public string An_Hien
        {
            get { return m_Enable; }
            set { m_Enable = value; }
        }
        #endregion

        #region PhanQuyen_Xem
        public void PhanQuyen_Xem_An()
        {
            this.itemThemMoi.Enabled = false;
            this.itemBoQua.Enabled = false;
            this.itemLuu.Enabled = false;
            this.itemXoa.Enabled = false;
        }
        public void PhanQuyen_Xem_Hien()
        {
            this.itemThemMoi.Enabled = true;
            this.itemBoQua.Enabled = true;
            this.itemLuu.Enabled = true;
            this.itemXoa.Enabled = true;
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


        #region CheckValid()
        private bool CheckValid()
        {
            if (this.txtMaTDTH.Text.Trim() == "")
            {
                MessageBoxEx.Show("Chưa Nhấn Nút Thêm Mới!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.itemThemMoi.Focus();
                return false;
            }
            if (this.txtTenTDTH.Text.Trim() == "" )
            {
                MessageBoxEx.Show("Chưa nhập Tên Trình Độ Tin Học!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtTenTDTH.Focus();
                return false;
            }
            
            return true;
        }
        #endregion

        #region ReloadData()
        private void ReloadData()
        {
            if (ctrlTrinhDoTinHoc == null)
            {
                ctrlTrinhDoTinHoc = new TrinhDo_TinHocCtrl();
            }
            ctrlTrinhDoTinHoc.HienThi_dsTrinhDoTinHoc(listViewExDanToc);
            if (listViewExDanToc.Items.Count > 0)
            {
                this.listViewExDanToc.Items[this.SelectedIndex].Selected = true;
                this.ctrlTrinhDoTinHoc.HienThiInfo(this.txtMaTDTH, this.txtTenTDTH, (TrinhDo_TinHocInfo)this.listViewExDanToc.Items[this.SelectedIndex].Tag);

                this.IsAddNew = false;
                //this.itemXoa.Enabled = true;
            }
            else
            {
                this.txtMaTDTH.Text = null;
                this.txtTenTDTH.Text = null;
               

                this.IsAddNew = true;
                this.txtMaTDTH.Focus();
                this.itemXoa.Enabled = false;
            }

        }
        #endregion

        #region frm_TRINHDOTINHOC_Load        
        
        private void frm_TRINHDOTINHOC_Load(object sender, EventArgs e)
        {
            if (An_Hien == "Xem")
            {
                this.PhanQuyen_Xem_An();
            }
            else
            {
                this.PhanQuyen_Xem_Hien();
            }

            if (ctrlTrinhDoTinHoc == null)
            {
                ctrlTrinhDoTinHoc = new TrinhDo_TinHocCtrl();
            }
            ctrlTrinhDoTinHoc.HienThi_dsTrinhDoTinHoc(listViewExDanToc);
            if (listViewExDanToc.Items.Count > 0)
            {
                this.listViewExDanToc.Items[this.SelectedIndex].Selected = true;
                this.ctrlTrinhDoTinHoc.HienThiInfo(this.txtMaTDTH, this.txtTenTDTH, (TrinhDo_TinHocInfo)this.listViewExDanToc.Items[this.SelectedIndex].Tag);

                this.IsAddNew = false;
                //this.itemXoa.Enabled = true;
            }
            else
            {
                this.txtMaTDTH.Text = null;
                this.txtTenTDTH.Text = null;


                this.IsAddNew = true;
                this.txtMaTDTH.Focus();
                this.itemXoa.Enabled = false;
            }
        }
        #endregion

        #region itemThemMoi_Click        
        
        private void itemThemMoi_Click(object sender, EventArgs e)
        {
            if (!this.IsAddNew)
            {
                this.txtMaTDTH.Text = null;
                this.txtTenTDTH.Text = null;
                

                this.IsAddNew = true;
            }
            ctrlTrinhDoTinHoc.Create(txtMaTDTH);
            this.txtTenTDTH.Focus();
        }
        #endregion


        #region itemBoQua_Click        
        
        private void itemBoQua_Click(object sender, EventArgs e)
        {
            if (this.listViewExDanToc.Items.Count > 0)
            {
                this.ctrlTrinhDoTinHoc.HienThiInfo(this.txtMaTDTH, this.txtTenTDTH, (TrinhDo_TinHocInfo)this.listViewExDanToc.Items[this.SelectedIndex].Tag);
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
                TrinhDo_TinHocInfo info = new TrinhDo_TinHocInfo(this.txtMaTDTH.Text, this.txtTenTDTH.Text);
                if (IsAddNew)
                {
                    if (ctrlTrinhDoTinHoc.Add(info))
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
                        ctrlTrinhDoTinHoc.Update(info, SelectedIndex);
                        this.ReloadData();
                    }
                    ctrlTrinhDoTinHoc.HienThiInfo(this.txtMaTDTH, this.txtTenTDTH, (TrinhDo_TinHocInfo)this.listViewExDanToc.Items[this.SelectedIndex].Tag);
                   
                }
            }
        }
        #endregion

        #region itemXoa_Click        
       
        private void itemXoa_Click(object sender, EventArgs e)
        {
            if (MessageBoxEx.Show("Bạn có chắc là xóa dòng này không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                IEnumerator ie = this.listViewExDanToc.SelectedItems.GetEnumerator();
                while (ie.MoveNext())
                {
                    ListViewItem item = (ListViewItem)ie.Current;
                    listViewExDanToc.Items.Remove(item);
                    if (ctrlTrinhDoTinHoc == null)
                        ctrlTrinhDoTinHoc = new TrinhDo_TinHocCtrl();
                    ctrlTrinhDoTinHoc.XoaTrinhDoTinHoc(item.SubItems[0].Text);
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
            if (this.listViewExDanToc.Items.Count > 0)
            {
                IEnumerator ie = this.listViewExDanToc.SelectedItems.GetEnumerator();
                if (ie.MoveNext())
                {
                    this.listViewExDanToc.Items[this.SelectedIndex].ImageIndex = -1;
                    this.listViewExDanToc.Items[this.SelectedIndex].BackColor = Color.White;
                    this.listViewExDanToc.Items[this.SelectedIndex].ForeColor = Color.Black;

                    ListViewItem item = (ListViewItem)ie.Current;
                    item.ImageIndex = 0;
                    item.BackColor = Color.FromArgb(100, 150, 255);
                    item.ForeColor = Color.White;

                    this.SelectedIndex = this.listViewExDanToc.Items.IndexOf(item);
                    ctrlTrinhDoTinHoc.HienThiInfo(this.txtMaTDTH, this.txtTenTDTH, (TrinhDo_TinHocInfo)this.listViewExDanToc.Items[this.SelectedIndex].Tag);
                }
            }
        }
        #endregion
    }
    }
