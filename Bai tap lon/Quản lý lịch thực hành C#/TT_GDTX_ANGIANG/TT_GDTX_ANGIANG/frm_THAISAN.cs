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
    public partial class frm_THAISAN : DevComponents.DotNetBar.Office2007Form
    {
        public frm_THAISAN()
        {
            InitializeComponent();
        }

        #region ctrlThaiSan
        private ThaiSanCtrl m_ctrlThaiSan;
        public ThaiSanCtrl ctrlThaiSan
        {
            get { return m_ctrlThaiSan; }
            set { m_ctrlThaiSan = value; }
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

        private ThaiSanInfo m_ThaiSanSelected;
        public ThaiSanInfo ThaiSanSelected
        {
            get { return m_ThaiSanSelected; }
            set { m_ThaiSanSelected = value; }
        }

        private string m_Open;
        public string Open
        {
            get { return m_Open; }
            set { m_Open = value; }
        }

        private string m_MANV;
        public string LayMaNhanVien_ThaiSan
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
            if (this.txtMaTS.Text.Trim() == "" )
            {
                MessageBoxEx.Show("Chưa Nhấn Nút Thêm Mới!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.itemThemMoi.Focus();
                return false;
            }
            //if (int.Parse(this.txtSinhConThu.Text) < 0 || int.Parse(this.txtSinhConThu.Text) > 10)
            //{
            //    MessageBoxEx.Show("Hệ Số Chức Vụ không được phép âm Hay lớn hơn 10!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    this.txtSinhConThu.Focus();
            //    return false;
            //}

            if (this.txtSinhConThu.Text.Trim() != "")
            {
                if (this.txtSinhConThu.Text.Trim().Length != 1 )
                {

                    MessageBoxEx.Show("Bạn đã nhập số Sinh Con Thư Mấy không đúng với thực tế", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtSinhConThu.Text = "";
                    this.txtSinhConThu.Focus();
                    return false;
                }
            }
            else
            {
                MessageBoxEx.Show("Chưa nhập Sinh Con Thứ Mấy ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtSinhConThu.Focus();
                return false;
            }

            if (int.Parse(this.txtSinhConThu.Text) < 1 || int.Parse(this.txtSinhConThu.Text) > 10)
            {
                MessageBoxEx.Show("Nhập Số Con trong khoảng 1 đến 9!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtSinhConThu.Text = "";
                this.txtSinhConThu.Focus();
                return false;
            }
            
            if (this.dtNgayBD.Value.Date >= this.dtNgayKT.Value.Date)
            {
                MessageBoxEx.Show("Ngày Kết Thúc phải lớn hơn ngày Bắt Đầu!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.dtNgayKT.Focus();
                return false;
            }
            if (this.txtNguoiKy.Text.Trim() == "" )
            {
                MessageBoxEx.Show("Chưa nhập Tên Người Ký!", "Thôg Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtNguoiKy.Focus();
                return false;
            }
            if (this.txtNoiDung.Text.Trim() == "")
            {
                MessageBoxEx.Show("Chưa nhập Nội Dung!", "Thôg Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtNoiDung.Focus();
                return false;
            }
            return true;
        }
        #endregion

        #region ReloadData()
        private void ReloadData()
        {
            if (ctrlThaiSan == null)
            {
                ctrlThaiSan = new ThaiSanCtrl();
            }
            ctrlThaiSan.HienThi_dsThaiSan(this.listViewExQTDaoTao,LayMaNhanVien_ThaiSan);
            if (this.listViewExQTDaoTao.Items.Count > 0)
            {
                this.SelectedIndex = 0;
                this.listViewExQTDaoTao.Items[this.SelectedIndex].Selected = true;
                ctrlThaiSan.HienThiInfo(this.txtMaTS, this.cboSoQD, this.dtNgayQD, this.txtSinhConThu, this.dtNgayBD, this.dtNgayKT, this.txtNguoiKy, this.txtNoiDung, (ThaiSanInfo)this.listViewExQTDaoTao.Items[this.SelectedIndex].Tag);

                this.IsAddNew = false;
                this.itemXoa.Enabled = true;
            }
            else
            {

                this.txtMaTS.Text = null;
                
                this.dtNgayQD.Text = null;
                this.txtSinhConThu.Text = "1";
                this.dtNgayBD.Text = null;
                this.dtNgayKT.Text = null;
                this.txtNguoiKy.Text = null;
                this.txtNoiDung.Text = null;
              
                this.IsAddNew = true;
                this.cboSoQD.Focus();
                this.itemXoa.Enabled = false;
            }
        }
        #endregion

        #region frm_THAISAN_Load        
       
        private void frm_THAISAN_Load(object sender, EventArgs e)
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

            if (ctrlThaiSan == null)
            {
                ctrlThaiSan = new ThaiSanCtrl();
            }
            ctrlThaiSan.HienThi_dsThaiSan(this.listViewExQTDaoTao,LayMaNhanVien_ThaiSan);
            if (this.listViewExQTDaoTao.Items.Count > 0)
            {
                this.SelectedIndex = 0;
                this.listViewExQTDaoTao.Items[this.SelectedIndex].Selected = true;
                ctrlThaiSan.HienThiInfo(this.txtMaTS, this.cboSoQD, this.dtNgayQD, this.txtSinhConThu, this.dtNgayBD, this.dtNgayKT, this.txtNguoiKy, this.txtNoiDung, (ThaiSanInfo)this.listViewExQTDaoTao.Items[this.SelectedIndex].Tag);

                this.IsAddNew = false;
                this.itemXoa.Enabled = true;
            }
            else
            {

                this.txtMaTS.Text = null;               
                this.dtNgayQD.Text = null;
                this.txtSinhConThu.Text = "1";
                this.dtNgayBD.Text = null;
                this.dtNgayKT.Text = null;
                this.txtNguoiKy.Text = null;
                this.txtNoiDung.Text = null;

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
                this.txtMaTS.Text = null;               
                this.dtNgayQD.Text = null;
                this.txtSinhConThu.Text = "1";
                this.dtNgayBD.Text = null;
                this.dtNgayKT.Text = null;
                this.txtNguoiKy.Text = null;
                this.txtNoiDung.Text = null;

                this.IsAddNew = true;

            }
            ctrlThaiSan.Create(txtMaTS);
            this.cboSoQD.Focus();
        }
        #endregion

        #region itemBoQua_Click        
       
        private void itemBoQua_Click(object sender, EventArgs e)
        {
            if (this.listViewExQTDaoTao.Items.Count > 0)
            {
                ctrlThaiSan.HienThiInfo(this.txtMaTS, this.cboSoQD, this.dtNgayQD, this.txtSinhConThu, this.dtNgayBD, this.dtNgayKT, this.txtNguoiKy, this.txtNoiDung, (ThaiSanInfo)this.listViewExQTDaoTao.Items[this.SelectedIndex].Tag);
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
                ThaiSanInfo info = new ThaiSanInfo();
                info.MaQuaTrinhThaiSan = this.txtMaTS.Text;
                info.MaNhanVien = this.LayMaNhanVien_ThaiSan.ToString();

                SoQuyetDinhCtrl ctrl = new SoQuyetDinhCtrl();
                info.SoQuyetDinh = ctrl.GetSoQuyetDinh(this.cboSoQD.SelectedValue.ToString());

                info.NgayQuyetDinh = this.dtNgayQD.Value;
                info.SinhConThuMay = int.Parse(this.txtSinhConThu.Text);
                info.NgayBatDau = this.dtNgayBD.Value;
                info.NgayKetThuc = this.dtNgayKT.Value;
                info.NguoiKy = this.txtNguoiKy.Text;
                info.NoiDung = this.txtNoiDung.Text;

                if (IsAddNew)
                {
                    if (ctrlThaiSan.Add(info))
                    {
                        this.IsAddNew = false;
                        MessageBoxEx.Show("Một dòng mới đã được thêm vào!", "Them thanh cong");
                    }
                    this.ReloadData();
                }
                else
                {
                    if (MessageBoxEx.Show("Ban có chắc là cập nhật dòng này không?", "Cap nhat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        ctrlThaiSan.CapNhatQTThaiSan(info, SelectedIndex);
                        this.ReloadData();
                    }
                    ctrlThaiSan.HienThiInfo(this.txtMaTS, this.cboSoQD, this.dtNgayQD, this.txtSinhConThu, this.dtNgayBD, this.dtNgayKT, this.txtNguoiKy, this.txtNoiDung, (ThaiSanInfo)this.listViewExQTDaoTao.Items[this.SelectedIndex].Tag);
                   
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
                    if (ctrlThaiSan == null)
                        ctrlThaiSan = new ThaiSanCtrl();
                    ctrlThaiSan.Xoa_ThaiSan(item.SubItems[0].Text);
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
                ctrlThaiSan.HienThiInfo(this.txtMaTS, this.cboSoQD, this.dtNgayQD, this.txtSinhConThu, this.dtNgayBD, this.dtNgayKT, this.txtNguoiKy, this.txtNoiDung, (ThaiSanInfo)this.listViewExQTDaoTao.Items[this.SelectedIndex].Tag);
            }
        }
        #endregion

        
    }
}