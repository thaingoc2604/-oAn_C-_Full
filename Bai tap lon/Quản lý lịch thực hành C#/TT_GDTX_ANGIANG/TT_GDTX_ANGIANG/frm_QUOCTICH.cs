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
    public partial class frm_QUOCTICH : DevComponents.DotNetBar.Office2007Form
    {
        public frm_QUOCTICH()
        {
            InitializeComponent();
        }
        public int Index = 0;

        #region ctrlQuocTich
        private QuocTichCtrl m_ctrlQuocTich;
        public QuocTichCtrl ctrlQuocTich
        {
            get { return m_ctrlQuocTich; }
            set { m_ctrlQuocTich = value; }
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

        #region Property
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
            if (this.txtMAQT.Text.Trim() == "" )
            {
                MessageBoxEx.Show("Bạn chưa nhấn nút Thêm Mới!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.itemThemMoi.Focus();
                return false;
            }
            if (this.txtTENQT.Text.Trim() == "" )
            {
                MessageBoxEx.Show("Chưa nhập Tên quốc tịch!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtTENQT.Focus();
                return false;
            }
            return true;
        }
        #endregion

        #region ReloadData()
        private void ReloadData()
        {
            if (ctrlQuocTich == null)
            {
                ctrlQuocTich = new QuocTichCtrl();
            }
            ctrlQuocTich.HienThi_dsQuocTich(listViewExTonGiao);
            if (listViewExTonGiao.Items.Count > 0)
            {
                this.listViewExTonGiao.Items[this.SelectedIndex].Selected = true;
                this.ctrlQuocTich.HienThiInfo(this.txtMAQT, this.txtTENQT, this.txtGHICHU, (QuocTichInfo)this.listViewExTonGiao.Items[this.SelectedIndex].Tag);

                this.IsAddNew = false;
                //this.itemXoa.Enabled = true;
            }
            else
            {
                this.txtMAQT.Text = null;
                this.txtTENQT.Text = null;
                this.txtGHICHU.Text = null;

                this.IsAddNew = true;
                this.txtMAQT.Focus();
                this.itemXoa.Enabled = false;
            }
        }
        #endregion

        #region frm_DM_QUOCTICH_Load        
      
        private void frm_DM_QUOCTICH_Load(object sender, EventArgs e)
        {
           
            if (An_Hien == "Xem")
            {
                this.PhanQuyen_Xem_An();
            }
            else
            {
                this.PhanQuyen_Xem_Hien();
            }

            if (ctrlQuocTich == null)
            {
                ctrlQuocTich = new QuocTichCtrl();
            }
            ctrlQuocTich.HienThi_dsQuocTich(this.listViewExTonGiao);
            if (this.listViewExTonGiao.Items.Count > 0)
            {
                this.SelectedIndex = 0;
                this.listViewExTonGiao.Items[this.SelectedIndex].Selected = true;
                ctrlQuocTich.HienThiInfo(this.txtMAQT, this.txtTENQT, this.txtGHICHU, (QuocTichInfo)this.listViewExTonGiao.Items[this.SelectedIndex].Tag);

                this.IsAddNew = false;
                //this.itemXoa.Enabled = true;
            }
            else
            {
                this.txtMAQT.Text = null;
                this.txtTENQT.Text = null;
                this.txtGHICHU.Text = null;

                this.IsAddNew = true;
                this.txtMAQT.Focus();
                this.itemXoa.Enabled = false;
            }
        }
        #endregion


        #region itemThemMoi_Click        
       
        private void itemThemMoi_Click(object sender, EventArgs e)
        {
           
            if (!this.IsAddNew)
            {
                this.txtMAQT.Text = null;
                this.txtTENQT.Text = null;
                this.txtGHICHU.Text = null;
                this.IsAddNew = true;
            }
            ctrlQuocTich.Create(txtMAQT);
            this.txtTENQT.Focus();
        }
        #endregion

        #region itemBoQua_Click        
        
        private void itemBoQua_Click(object sender, EventArgs e)
        {
            if (this.listViewExTonGiao.Items.Count > 0)
            {
                ctrlQuocTich.HienThiInfo(this.txtMAQT, this.txtTENQT, this.txtGHICHU, (QuocTichInfo)this.listViewExTonGiao.Items[this.SelectedIndex].Tag);
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
                QuocTichInfo info = new QuocTichInfo(this.txtMAQT.Text, this.txtTENQT.Text, this.txtGHICHU.Text);
                if (IsAddNew)
                {
                    if (ctrlQuocTich.Add(info))
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
                        ctrlQuocTich.Update(info, SelectedIndex);
                        this.ReloadData();
                    }
                    ctrlQuocTich.HienThiInfo(this.txtMAQT, this.txtTENQT, this.txtGHICHU, (QuocTichInfo)this.listViewExTonGiao.Items[this.SelectedIndex].Tag);
                    
                }
            }
        }
        #endregion

        #region itemXoa_Click        
        
        private void itemXoa_Click(object sender, EventArgs e)
        {
            if (MessageBoxEx.Show("Bạn có chắc là xóa dòng này không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                IEnumerator ie = this.listViewExTonGiao.SelectedItems.GetEnumerator();
                while (ie.MoveNext())
                {
                    ListViewItem item = (ListViewItem)ie.Current;
                    listViewExTonGiao.Items.Remove(item);
                    if (ctrlQuocTich == null)
                        ctrlQuocTich = new QuocTichCtrl();
                    ctrlQuocTich.XoaQuocTich(item.SubItems[0].Text);
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
            if (this.listViewExTonGiao.Items.Count > 0)
            {
                IEnumerator ie = this.listViewExTonGiao.SelectedItems.GetEnumerator();
                if (ie.MoveNext())
                {
                    this.listViewExTonGiao.Items[this.SelectedIndex].ImageIndex = -1;
                    this.listViewExTonGiao.Items[this.SelectedIndex].BackColor = Color.White;
                    this.listViewExTonGiao.Items[this.SelectedIndex].ForeColor = Color.Black;

                    ListViewItem item = (ListViewItem)ie.Current;
                    item.ImageIndex = 0;
                    item.BackColor = Color.FromArgb(100, 150, 255);
                    item.ForeColor = Color.White;

                    this.SelectedIndex = this.listViewExTonGiao.Items.IndexOf(item);
                    ctrlQuocTich.HienThiInfo(this.txtMAQT, this.txtTENQT, this.txtGHICHU, (QuocTichInfo)item.Tag);
                }
            }
        }
        #endregion



    }
}