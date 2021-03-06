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
    public partial class frm_QUATRINHDAOTAO : DevComponents.DotNetBar.Office2007Form
    {
        public frm_QUATRINHDAOTAO()
        {
            InitializeComponent();
        }

        #region Property

        private QuaTrinhDaoTaoInfo m_QuaTrinhDaoTaoSelected;
        public QuaTrinhDaoTaoInfo QuaTrinhDaoTaoSelected
        {
            get { return m_QuaTrinhDaoTaoSelected; }
            set { m_QuaTrinhDaoTaoSelected = value; }
        }

        private string m_Open;
        public string Open
        {
            get { return m_Open; }
            set { m_Open = value; }
        }

        private string m_MANV;
        public string LayMaNhanVien_QTDaoTao
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

        #region ctrlQuaTrinhDaoTao
        private QuaTrinhDaoTaoCtrl m_ctrlQuaTrinhDaoTao;
        public QuaTrinhDaoTaoCtrl ctrlQuaTrinhDaoTao
        {
            get { return m_ctrlQuaTrinhDaoTao; }
            set { m_ctrlQuaTrinhDaoTao = value; }
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

        #region frm_QUATRINHDAOTAO_Load        
       
        private void frm_QUATRINHDAOTAO_Load(object sender, EventArgs e)
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

            if (ctrlQuaTrinhDaoTao == null)
            {
                ctrlQuaTrinhDaoTao = new QuaTrinhDaoTaoCtrl();
            }
            ctrlQuaTrinhDaoTao.HienThi_dsQuaTrinhDaoTao(this.listViewExQTDaoTao,this.LayMaNhanVien_QTDaoTao);
            if (this.listViewExQTDaoTao.Items.Count > 0)
            {
                this.SelectedIndex = 0;
                this.listViewExQTDaoTao.Items[this.SelectedIndex].Selected = true;
                ctrlQuaTrinhDaoTao.HienThiInfo(this.txtmaQTDT, this.txtNamNhapHoc, this.txtNamTotNghiep, this.txtNoiDaoTao, this.txtNganhDaoTao, this.txtHinhThucDT, this.txtBangDuocCap, (QuaTrinhDaoTaoInfo)this.listViewExQTDaoTao.Items[this.SelectedIndex].Tag);

                this.IsAddNew = false;
                this.itemXoa.Enabled = true;
            }
            else
            {
               
                this.txtmaQTDT.Text = null;
                this.txtNamNhapHoc.Text = null;
                this.txtNamTotNghiep.Text = null;
                this.txtNoiDaoTao.Text = null;
                this.txtNganhDaoTao.Text = null;
                this.txtHinhThucDT.Text = null;
                this.txtBangDuocCap.Text = null;

                this.IsAddNew = true;
                this.txtmaQTDT.Focus();
                this.itemXoa.Enabled = false;
            }
        }

        #endregion
        
        #region CheckValid()
        private bool CheckValid()
        {
            //Kiểm Tra mã quá trình đào tạo
            if (this.txtmaQTDT.Text.Trim() == "" )
            {
                MessageBoxEx.Show("Chưa nhập Mã Quá Trình Đào Tạo, Hãy Nhấn Nút Thêm Mới! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.itemThemMoi.Focus();
                return false;
            }
            
            //Kiểm tra năm nhập học
            if (this.txtNamNhapHoc.Text.Trim() != "")
            {
                if (this.txtNamNhapHoc.Text.Trim().Length != 4)
                {
                    MessageBoxEx.Show("Bạn đã nhập năm Nhập Học không đúng với thực tế", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtNamNhapHoc.Text = "";
                    this.txtNamNhapHoc.Focus();
                    return false;
                }
            }
            else
            {
                MessageBoxEx.Show("Chưa nhập Năm Nhập Học ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtNamNhapHoc.Focus();
                return false;
            }
            if (!Utility.IsNum(this.txtNamNhapHoc.Text))
            {
                MessageBoxEx.Show("Bạn đã nhập năm Nhập Học không đúng với thực tế", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtNamNhapHoc.Text = "";
                this.txtNamNhapHoc.Focus();
                return false;
            }

            //Kiểm tra năm tốt nghiệp
            if (this.txtNamTotNghiep.Text.Trim() != "")
            {
                if (this.txtNamTotNghiep.Text.Trim().Length != 4)
                {
                    MessageBoxEx.Show("Bạn đã nhập năm Tốt Nghiệp không đúng với thực tế", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtNamTotNghiep.Text = "";
                    this.txtNamTotNghiep.Focus();
                    return false;
                }
            }
            else
            {
                MessageBoxEx.Show("Chưa nhập Tốt Nghiệp Học ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtNamTotNghiep.Focus();
                return false;
            }
            //Kiểm tra nơi đào tạo
            if (this.txtNoiDaoTao.Text.Trim() == "")
            {
                MessageBoxEx.Show("Chưa nhập Nơi Đào Tạo! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtNoiDaoTao.Focus();
                return false;
            }
            //Kiểm tra ngành đào tạo
            if (this.txtNganhDaoTao.Text.Trim() == "")
            {
                MessageBoxEx.Show("Chưa nhập Ngành Đào Tạo ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtNganhDaoTao.Focus();
                return false;
            }
            //Kiểm tra hình thức đào tạo
            if (this.txtHinhThucDT.Text.Trim() == "")
            {
                MessageBoxEx.Show("Chưa nhập Hình Thức Đào Tạo ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtHinhThucDT.Focus();
                return false;
            }

            //Kiểm tra bằng được cấp
            if (this.txtBangDuocCap.Text.Trim() == "")
            {
                MessageBoxEx.Show("Chưa nhập Bằng Cấp ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtBangDuocCap.Focus();
                return false;
            }

            return true;
        }
        #endregion

        #region ReloadData()
        private void ReloadData()
        {
            if (ctrlQuaTrinhDaoTao == null)
            {
                ctrlQuaTrinhDaoTao = new QuaTrinhDaoTaoCtrl();
            }
            ctrlQuaTrinhDaoTao.HienThi_dsQuaTrinhDaoTao(this.listViewExQTDaoTao,this.LayMaNhanVien_QTDaoTao);
            if (this.listViewExQTDaoTao.Items.Count > 0)
            {
                this.SelectedIndex = 0;
                this.listViewExQTDaoTao.Items[this.SelectedIndex].Selected = true;
                ctrlQuaTrinhDaoTao.HienThiInfo(this.txtmaQTDT, this.txtNamNhapHoc, this.txtNamTotNghiep, this.txtNoiDaoTao, this.txtNganhDaoTao, this.txtHinhThucDT, this.txtBangDuocCap, (QuaTrinhDaoTaoInfo)this.listViewExQTDaoTao.Items[this.SelectedIndex].Tag);

                this.IsAddNew = false;
                this.itemXoa.Enabled = true;
            }
            else
            {

                this.txtmaQTDT.Text = null;
                this.txtNamNhapHoc.Text = null;
                this.txtNamTotNghiep.Text = null;
                this.txtNoiDaoTao.Text = null;
                this.txtNganhDaoTao.Text = null;
                this.txtHinhThucDT.Text = null;
                this.txtBangDuocCap.Text = null;

                this.IsAddNew = true;
                this.txtmaQTDT.Focus();
                this.itemXoa.Enabled = false;
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
                    ctrlQuaTrinhDaoTao.HienThiInfo(this.txtmaQTDT, this.txtNamNhapHoc, this.txtNamTotNghiep, this.txtNoiDaoTao, this.txtNganhDaoTao, this.txtHinhThucDT, this.txtBangDuocCap, (QuaTrinhDaoTaoInfo)this.listViewExQTDaoTao.Items[this.SelectedIndex].Tag);
                }
            }
        }
        #endregion

        
        #region itemThemMoi_Click        
       
        private void itemThemMoi_Click(object sender, EventArgs e)
        {
            if (!this.IsAddNew)
            {
                this.txtmaQTDT.Text = null;
                this.txtNamNhapHoc.Text = null;
                this.txtNamTotNghiep.Text = null;
                this.txtNoiDaoTao.Text = null;
                this.txtNganhDaoTao.Text = null;
                this.txtHinhThucDT.Text = null;
                this.txtBangDuocCap.Text = null;


                this.IsAddNew = true;
            }
            ctrlQuaTrinhDaoTao.Create(txtmaQTDT);
            this.txtNamNhapHoc.Focus();
        }
        #endregion

        #region itemBoQua_Click        
      
        private void itemBoQua_Click(object sender, EventArgs e)
        {
            if (this.listViewExQTDaoTao.Items.Count > 0)
            {
                ctrlQuaTrinhDaoTao.HienThiInfo(this.txtmaQTDT, this.txtNamNhapHoc, this.txtNamTotNghiep, this.txtNoiDaoTao, this.txtNganhDaoTao, this.txtHinhThucDT, this.txtBangDuocCap, (QuaTrinhDaoTaoInfo)this.listViewExQTDaoTao.Items[this.SelectedIndex].Tag);
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

                QuaTrinhDaoTaoInfo info = new QuaTrinhDaoTaoInfo();
                info.MaQuaTrinhDaoTao = this.txtmaQTDT.Text;
                info.MaNhanVien = this.LayMaNhanVien_QTDaoTao;
                info.NamNhapHoc = this.txtNamNhapHoc.Text;
                info.NamTotNghiep = this.txtNamTotNghiep.Text;
                info.NoiDaoTao = this.txtNoiDaoTao.Text;
                info.NganhDaoTao = this.txtNganhDaoTao.Text;
                info.HinhThucDaoTao = this.txtHinhThucDT.Text;
                info.BangDuocCap = this.txtBangDuocCap.Text;
                if (IsAddNew)
                {
                    if (ctrlQuaTrinhDaoTao.Add(info))
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
                        ctrlQuaTrinhDaoTao.CapNhatQuaTrinhDaoTao(info, SelectedIndex);
                        this.ReloadData();
                    }
                    ctrlQuaTrinhDaoTao.HienThiInfo(this.txtmaQTDT, this.txtNamNhapHoc, this.txtNamTotNghiep, this.txtNoiDaoTao, this.txtNganhDaoTao, this.txtHinhThucDT, this.txtBangDuocCap, (QuaTrinhDaoTaoInfo)this.listViewExQTDaoTao.Items[this.SelectedIndex].Tag);
                   
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
                    if (ctrlQuaTrinhDaoTao == null)
                        ctrlQuaTrinhDaoTao = new QuaTrinhDaoTaoCtrl();
                    ctrlQuaTrinhDaoTao.Xoa_QuaTrinhDaoTao(item.SubItems[0].Text);
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