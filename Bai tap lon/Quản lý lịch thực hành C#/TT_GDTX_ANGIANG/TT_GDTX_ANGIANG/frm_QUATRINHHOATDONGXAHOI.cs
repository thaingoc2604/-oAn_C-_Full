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
    public partial class frm_QUATRINHHOATDONGXAHOI : DevComponents.DotNetBar.Office2007Form
    {
        public frm_QUATRINHHOATDONGXAHOI()
        {
            InitializeComponent();
        }

        #region ctrlQTHoatDongXaHoi
        private QuaTrinhHoatDongXaHoiCtrl m_ctrlQTHoatDongXaHoi;
        public QuaTrinhHoatDongXaHoiCtrl ctrlQTHoatDongXaHoi
        {
            get { return m_ctrlQTHoatDongXaHoi; }
            set { m_ctrlQTHoatDongXaHoi = value; }
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

        private QuaTrinhHoatDongXaHoiInfo m_QuaTrinhHoatDongXHSelected;
        public QuaTrinhHoatDongXaHoiInfo QuaTrinhHoatDongXHSelected
        {
            get { return m_QuaTrinhHoatDongXHSelected; }
            set { m_QuaTrinhHoatDongXHSelected = value; }
        }

        private string m_Open;
        public string Open
        {
            get { return m_Open; }
            set { m_Open = value; }
        }

        private string m_MANV;
        public string LayMaNhanVien_QTHoatDongXH
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
            //Kiểm tra mã
            if (this.txtMAQTHDXH.Text.Trim() == "" )
            {
                MessageBox.Show("Chưa nhập Mã Quá Trình Hoạt Động Xã Hội, Hãy Nhấn Nút Thêm Mới!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.itemThemMoi.Focus();
                return false;
            }
            //Kiểm tra ngày
            if (this.dtTuNgay.Value.Date >= this.dtDenNgay.Value.Date)
            {
                MessageBoxEx.Show("Ngày Kết Thúc phải lớn hơn ngày Bắt Đầu!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.dtDenNgay.Focus();
                return false;
            }
            //kiểm tra nội dung
            if (this.txtNoiDung.Text.Trim() == "" )
            {
                MessageBox.Show("Chưa nhập Nội Dung Diễn Giải!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            if (ctrlQTHoatDongXaHoi == null)
            {
                ctrlQTHoatDongXaHoi = new QuaTrinhHoatDongXaHoiCtrl();
            }
            ctrlQTHoatDongXaHoi.HienThi_dsQTHoatDongXaHoi(this.listViewExQTDaoTao,this.LayMaNhanVien_QTHoatDongXH);
            if (this.listViewExQTDaoTao.Items.Count > 0)
            {
                this.SelectedIndex = 0;
                this.listViewExQTDaoTao.Items[this.SelectedIndex].Selected = true;
                ctrlQTHoatDongXaHoi.HienThiInfo(this.txtMAQTHDXH, this.dtTuNgay, this.dtDenNgay, this.txtNoiDung, (QuaTrinhHoatDongXaHoiInfo)this.listViewExQTDaoTao.Items[this.SelectedIndex].Tag);

                this.IsAddNew = false;
                this.itemXoa.Enabled = true;
            }
            else
            {

                this.txtMAQTHDXH.Text = null;
                this.dtTuNgay.Text = null;
                this.dtDenNgay.Text = null;
                this.txtNoiDung.Text = null;


                this.IsAddNew = true;
                this.txtMAQTHDXH.Focus();
                this.itemXoa.Enabled = false;
            }
        }
        #endregion

        #region frm_QUATRINHHOATDONGXAHOI_Load        
       
        private void frm_QUATRINHHOATDONGXAHOI_Load(object sender, EventArgs e)
        {
            if (An_Hien == "Xem")
            {
                this.PhanQuyen_Xem_An();
            }
            else
            {
                this.PhanQuyen_Xem_Hien();
            }

            if (ctrlQTHoatDongXaHoi == null)
            {
                ctrlQTHoatDongXaHoi = new QuaTrinhHoatDongXaHoiCtrl();
            }
            ctrlQTHoatDongXaHoi.HienThi_dsQTHoatDongXaHoi(this.listViewExQTDaoTao,LayMaNhanVien_QTHoatDongXH);
            if (this.listViewExQTDaoTao.Items.Count > 0)
            {
                this.SelectedIndex = 0;
                this.listViewExQTDaoTao.Items[this.SelectedIndex].Selected = true;
                ctrlQTHoatDongXaHoi.HienThiInfo(this.txtMAQTHDXH, this.dtTuNgay, this.dtDenNgay, this.txtNoiDung, (QuaTrinhHoatDongXaHoiInfo)this.listViewExQTDaoTao.Items[this.SelectedIndex].Tag);

                this.IsAddNew = false;
                this.itemXoa.Enabled = true;
            }
            else
            {

                this.txtMAQTHDXH.Text = null;
                this.dtTuNgay.Text = null;
                this.dtDenNgay.Text = null;
                this.txtNoiDung.Text = null;


                this.IsAddNew = true;
                this.txtMAQTHDXH.Focus();
                this.itemXoa.Enabled = false;
            }
        }
        #endregion

        #region itemThemMoi_Click        
       
        private void itemThemMoi_Click(object sender, EventArgs e)
        {
            if (!this.IsAddNew)
            {
                this.txtMAQTHDXH.Text = null;
                this.dtTuNgay.Text = null;
                this.dtDenNgay.Text = null;
                this.txtNoiDung.Text = null;


                this.IsAddNew = true;

            }
            ctrlQTHoatDongXaHoi.Create(txtMAQTHDXH);
            this.txtNoiDung.Focus();
        }
        #endregion

        #region itemBoQua_Click        
       
        private void itemBoQua_Click(object sender, EventArgs e)
        {
            if (this.listViewExQTDaoTao.Items.Count > 0)
            {
                ctrlQTHoatDongXaHoi.HienThiInfo(this.txtMAQTHDXH, this.dtTuNgay, this.dtDenNgay, this.txtNoiDung, (QuaTrinhHoatDongXaHoiInfo)this.listViewExQTDaoTao.Items[this.SelectedIndex].Tag);
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
                QuaTrinhHoatDongXaHoiInfo info = new QuaTrinhHoatDongXaHoiInfo();
                info.MaQTHoatDongXaHoi = this.txtMAQTHDXH.Text;
                info.MaNhanVien = this.LayMaNhanVien_QTHoatDongXH;
                info.TuNgay = this.dtTuNgay.Value;
                info.DenNgay = this.dtDenNgay.Value;
                info.NoiDung = this.txtNoiDung.Text;
               
                if (IsAddNew)
                {
                    if (ctrlQTHoatDongXaHoi.Add(info))
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
                        ctrlQTHoatDongXaHoi.CapNhatQTHoatDongXaHoi(info, SelectedIndex);
                        this.ReloadData();
                    }
                    ctrlQTHoatDongXaHoi.HienThiInfo(this.txtMAQTHDXH, this.dtTuNgay, this.dtDenNgay, this.txtNoiDung, (QuaTrinhHoatDongXaHoiInfo)this.listViewExQTDaoTao.Items[this.SelectedIndex].Tag);
                   
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
                    if (ctrlQTHoatDongXaHoi == null)
                        ctrlQTHoatDongXaHoi = new QuaTrinhHoatDongXaHoiCtrl();
                    ctrlQTHoatDongXaHoi.Xoa_QuaTrinhHoatDongXaHoi(item.SubItems[0].Text);
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

        #region  #endregion        
        

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
                    ctrlQTHoatDongXaHoi.HienThiInfo(this.txtMAQTHDXH, this.dtTuNgay, this.dtDenNgay, this.txtNoiDung, (QuaTrinhHoatDongXaHoiInfo)this.listViewExQTDaoTao.Items[this.SelectedIndex].Tag);
                }
            }
        }
        #endregion
    }
}