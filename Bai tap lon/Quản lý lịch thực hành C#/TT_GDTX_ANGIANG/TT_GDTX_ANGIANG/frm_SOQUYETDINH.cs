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
    public partial class frm_SOQUYETDINH : DevComponents.DotNetBar.Office2007Form
    {
        public frm_SOQUYETDINH()
        {
            InitializeComponent();
        }

        #region ctrlSoQuyetDinh
        private SoQuyetDinhCtrl m_ctrlSoQuyetDinh;
        public SoQuyetDinhCtrl ctrlSoQuyetDinh
        {
            get { return m_ctrlSoQuyetDinh; }
            set { m_ctrlSoQuyetDinh = value; }
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
            if (this.txtMaSoQD.Text.Trim() == "" )
            {
                MessageBoxEx.Show("Chưa nhấn Nút Thêm Mới", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.itemThemMoi.Focus();
                return false;
            }
            if (this.txtNoiDung.Text.Trim() == "" )
            {
                MessageBox.Show("Chưa nhập Nội Dung!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtNoiDung.Focus();
                return false;
            }
            if (this.txtNguoiQD.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập Tên Người Quyết Định!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtNguoiQD.Focus();
                return false;
            }
            if (this.txtChucVu.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập Chức Vụ!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtChucVu.Focus();
                return false;
            }
            if (this.txtLoaiQD.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập Loại Quyết Định!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtLoaiQD.Focus();
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

            if (ctrlSoQuyetDinh == null)
            {
                ctrlSoQuyetDinh = new SoQuyetDinhCtrl();
            }
            ctrlSoQuyetDinh.HienThi_dsSoQuyetDinh(this.listViewExQTDaoTao);
            if (this.listViewExQTDaoTao.Items.Count > 0)
            {
                this.SelectedIndex = 0;
                this.listViewExQTDaoTao.Items[this.SelectedIndex].Selected = true;
                ctrlSoQuyetDinh.HienThiInfo(this.txtMaSoQD, this.dtNgayQD,this.txtLoaiQD, this.txtNoiDung,this.txtNguoiQD,this.txtChucVu, (SoQuyetDinhInfo)this.listViewExQTDaoTao.Items[this.SelectedIndex].Tag);

                this.IsAddNew = false;
                this.itemXoa.Enabled = true;
            }
            else
            {

                this.txtMaSoQD.Text = null;
                this.dtNgayQD.Text = null;
                this.txtLoaiQD.Text = null;
                this.txtNoiDung.Text = null;
                this.txtNguoiQD.Text = null;
                this.txtChucVu.Text = null;


                this.IsAddNew = true;
                this.txtMaSoQD.Focus();
                this.itemXoa.Enabled = false;
            }
        }
        #endregion


        #region frm_SOQUYETDINH_Load        
       
        private void frm_SOQUYETDINH_Load(object sender, EventArgs e)
        {
            if (An_Hien == "Xem")
            {
                this.PhanQuyen_Xem_An();
            }
            else
            {
                this.PhanQuyen_Xem_Hien();
            }

            if (An_Hien == "Xem")
            {
                this.PhanQuyen_Xem_An();
            }
            else
            {
                this.PhanQuyen_Xem_Hien();
            }

            if (ctrlSoQuyetDinh == null)
            {
                ctrlSoQuyetDinh = new SoQuyetDinhCtrl();
            }
            ctrlSoQuyetDinh.HienThi_dsSoQuyetDinh(this.listViewExQTDaoTao);
            if (this.listViewExQTDaoTao.Items.Count > 0)
            {
                this.SelectedIndex = 0;
                this.listViewExQTDaoTao.Items[this.SelectedIndex].Selected = true;
                ctrlSoQuyetDinh.HienThiInfo(this.txtMaSoQD, this.dtNgayQD, this.txtLoaiQD, this.txtNoiDung, this.txtNguoiQD, this.txtChucVu, (SoQuyetDinhInfo)this.listViewExQTDaoTao.Items[this.SelectedIndex].Tag);

                this.IsAddNew = false;
                this.itemXoa.Enabled = true;
            }
            else
            {

                this.txtMaSoQD.Text = null;
                this.dtNgayQD.Text = null;
                this.txtLoaiQD.Text = null;
                this.txtNoiDung.Text = null;
                this.txtNguoiQD.Text = null;
                this.txtChucVu.Text = null;


                this.IsAddNew = true;
                this.txtMaSoQD.Focus();
                this.itemXoa.Enabled = false;
            }
        }
        #endregion

        #region itemThemMoi_Click        
       
        private void itemThemMoi_Click(object sender, EventArgs e)
        {
            if (!this.IsAddNew)
            {
                this.txtMaSoQD.Text = null;
                this.dtNgayQD.Text = null;
                this.txtLoaiQD.Text = null;
                this.txtNoiDung.Text = null;
                this.txtNguoiQD.Text = null;
                this.txtChucVu.Text = null;


                this.IsAddNew = true;

            }
            ctrlSoQuyetDinh.Create(txtMaSoQD);
            this.txtNoiDung.Focus();
        }
        #endregion

        #region itemBoQua_Click        
       
        private void itemBoQua_Click(object sender, EventArgs e)
        {
            if (this.listViewExQTDaoTao.Items.Count > 0)
            {
                ctrlSoQuyetDinh.HienThiInfo(this.txtMaSoQD, this.dtNgayQD, this.txtLoaiQD, this.txtNoiDung, this.txtNguoiQD, this.txtChucVu, (SoQuyetDinhInfo)this.listViewExQTDaoTao.Items[this.SelectedIndex].Tag);
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
                SoQuyetDinhInfo info = new SoQuyetDinhInfo(this.txtMaSoQD.Text, this.dtNgayQD.Value, this.txtLoaiQD.Text, this.txtNoiDung.Text, this.txtNguoiQD.Text, this.txtChucVu.Text);
                if (IsAddNew)
                {
                    if (ctrlSoQuyetDinh .Add(info))
                    {
                        this.IsAddNew = false;
                        MessageBox.Show("Một dòng mới đã được thêm vào!", "Them thanh cong");
                    }
                    this.ReloadData();
                }
                else
                {
                    if (MessageBox.Show("Ban có chắc là cập nhật dòng này không?", "Cap nhat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        ctrlSoQuyetDinh.Update(info, SelectedIndex);
                        this.ReloadData();
                    }
                    ctrlSoQuyetDinh.HienThiInfo(this.txtMaSoQD, this.dtNgayQD, this.txtLoaiQD, this.txtNoiDung, this.txtNguoiQD, this.txtChucVu, (SoQuyetDinhInfo)this.listViewExQTDaoTao.Items[this.SelectedIndex].Tag);
                   
                }
            }
        }
        #endregion

        #region itemXoa_Click        
       
        private void itemXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là xóa dòng này không?", "Xoa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (ctrlSoQuyetDinh.Delete(this.SelectedIndex))
                {
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
                    ctrlSoQuyetDinh.HienThiInfo(this.txtMaSoQD, this.dtNgayQD, this.txtLoaiQD, this.txtNoiDung, this.txtNguoiQD, this.txtChucVu, (SoQuyetDinhInfo)this.listViewExQTDaoTao.Items[this.SelectedIndex].Tag);
                }
            }
        }
        #endregion

        
    }
}