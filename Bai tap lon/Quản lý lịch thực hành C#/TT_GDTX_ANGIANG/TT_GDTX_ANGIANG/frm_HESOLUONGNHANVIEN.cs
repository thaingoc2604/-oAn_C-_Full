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
    public partial class frm_HESOLUONGNHANVIEN : DevComponents.DotNetBar.Office2007Form
    {
        public frm_HESOLUONGNHANVIEN()
        {
            InitializeComponent();
        }

        #region ctrlHSLuongNhanVien
        private HeSoLuongNhanVienCtrl m_ctrlHSLuongNhanVien;
        public HeSoLuongNhanVienCtrl ctrlHSLuongNhanVien
        {
            get { return m_ctrlHSLuongNhanVien; }
            set { m_ctrlHSLuongNhanVien = value; }
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
            if (this.txtMaHSLuong.Text.Trim() == "" )
            {
                MessageBoxEx.Show("Chưa Nhấn Nút Thêm Mới!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.itemThemMoi.Focus();
                return false;
            }
            if (double.Parse(this.dbHeSoLuong.Text) <0)
            {
                MessageBoxEx.Show("Chưa nhập hệ số lương !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.dbHeSoLuong.Focus();
                return false;
            }
            return true;
        }
        #endregion

        #region ReloadData()
        private void ReloadData()
        {
            if (ctrlHSLuongNhanVien == null)
            {
                ctrlHSLuongNhanVien = new HeSoLuongNhanVienCtrl();
            }
            ctrlHSLuongNhanVien.HienThi_dsHSLuongNhanVien(listViewExDanToc);
            if (listViewExDanToc.Items.Count > 0)
            {
                this.listViewExDanToc.Items[this.SelectedIndex].Selected = true;
                this.ctrlHSLuongNhanVien.HienThiInfo(this.txtMaHSLuong, this.cboTenNgach, this.cboTenBac, this.dbHeSoLuong, (HeSoLuongNhanVienInfo)this.listViewExDanToc.Items[this.SelectedIndex].Tag);

                this.IsAddNew = false;
                this.itemXoa.Enabled = true;
            }
            else
            {
                this.txtMaHSLuong.Text = null;
                this.dbHeSoLuong.Text = "0.0";       

                this.IsAddNew = true;
                this.txtMaHSLuong.Focus();
                this.itemXoa.Enabled = false;
            }

        }
        #endregion



        #region itemThemMoi_Click       
       

        private void itemThemMoi_Click(object sender, EventArgs e)
        {
            if (!this.IsAddNew)
            {
                this.txtMaHSLuong.Text = null;
               

                this.IsAddNew = true;
            }
            ctrlHSLuongNhanVien.Create(txtMaHSLuong);
            this.cboTenNgach.Focus();
        }
        #endregion

        #region itemBoQua_Click        
       
        private void itemBoQua_Click(object sender, EventArgs e)
        {
            if (this.listViewExDanToc.Items.Count > 0)
            {
                this.ctrlHSLuongNhanVien.HienThiInfo(this.txtMaHSLuong, this.cboTenNgach, this.cboTenBac, this.dbHeSoLuong, (HeSoLuongNhanVienInfo)this.listViewExDanToc.Items[this.SelectedIndex].Tag);
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
                HeSoLuongNhanVienInfo info = new HeSoLuongNhanVienInfo();


                info.MaHeSoLuong = this.txtMaHSLuong.Text;
                info.HeSoLuong = float.Parse(this.dbHeSoLuong.Text);

                NgachCtrl ctrl_Ngach = new NgachCtrl();
                info.TenNgach = ctrl_Ngach.GetNgach(this.cboTenNgach.SelectedValue.ToString());

                BacCtrl ctrl_Bac = new BacCtrl();
                info.TenBac = ctrl_Bac.GetBac(this.cboTenBac.SelectedValue.ToString());

               

                if (IsAddNew)
                {
                    if (ctrlHSLuongNhanVien.Add(info))
                    {
                        this.IsAddNew = false;
                        MessageBoxEx.Show("Một dòng mới đã được thêm vào!", "Thêm thành công");
                    }
                    this.ReloadData();
                }
                else
                {
                    if (MessageBoxEx.Show("Ban có chắc là cập nhật dòng này không?", "Cập Nhật", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        ctrlHSLuongNhanVien.CapNhatHeSoLuongNhanVien(info, SelectedIndex);
                        this.ReloadData();
                    }
                    ctrlHSLuongNhanVien.HienThiInfo(this.txtMaHSLuong, this.cboTenNgach, this.cboTenBac, this.dbHeSoLuong, (HeSoLuongNhanVienInfo)this.listViewExDanToc.Items[this.SelectedIndex].Tag);

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
                    if (ctrlHSLuongNhanVien == null)
                        ctrlHSLuongNhanVien = new HeSoLuongNhanVienCtrl();
                    ctrlHSLuongNhanVien.XoaHeSoLuongNhanVien(item.SubItems[0].Text);
                    if (this.SelectedIndex != 0)
                    {
                        this.SelectedIndex--;
                    }
                }
                this.ReloadData();
            }
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
                    item.BackColor = Color.FromArgb(100, 160, 255);
                    item.ForeColor = Color.White;

                    this.SelectedIndex = this.listViewExDanToc.Items.IndexOf(item);
                    this.ctrlHSLuongNhanVien.HienThiInfo(this.txtMaHSLuong, this.cboTenNgach, this.cboTenBac, this.dbHeSoLuong, (HeSoLuongNhanVienInfo)this.listViewExDanToc.Items[this.SelectedIndex].Tag);
                }
            }
        }
        #endregion

        #region itemThoat_Click        
       
        private void itemThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region frm_HESOLUONGNHANVIEN_Load

        private void frm_HESOLUONGNHANVIEN_Load(object sender, EventArgs e)
        {
            #region HienThi Combobox

            NgachCtrl ctrlNgach = new NgachCtrl();
            ctrlNgach.HienThiComboBox(this.cboTenNgach);

            BacCtrl ctrlBac = new BacCtrl();
            ctrlBac.HienThiComboBox(this.cboTenBac);      
                        
            #endregion
            
            if (An_Hien == "Xem")
            {
                this.PhanQuyen_Xem_An();
            }
            else
            {
                this.PhanQuyen_Xem_Hien();
            }

            if (ctrlHSLuongNhanVien == null)
            {
                ctrlHSLuongNhanVien = new HeSoLuongNhanVienCtrl();
            }
            ctrlHSLuongNhanVien.HienThi_dsHSLuongNhanVien(listViewExDanToc);
            if (listViewExDanToc.Items.Count > 0)
            {
                this.listViewExDanToc.Items[this.SelectedIndex].Selected = true;
                this.ctrlHSLuongNhanVien.HienThiInfo(this.txtMaHSLuong, this.cboTenNgach, this.cboTenBac, this.dbHeSoLuong, (HeSoLuongNhanVienInfo)this.listViewExDanToc.Items[this.SelectedIndex].Tag);

                this.IsAddNew = false;
                this.itemXoa.Enabled = true;
            }
            else
            {
                this.txtMaHSLuong.Text = null;
                this.dbHeSoLuong.Text = "0.0";
                this.IsAddNew = true;
                this.txtMaHSLuong.Focus();
                this.itemXoa.Enabled = false;
            }
        }
        #endregion
    }
}