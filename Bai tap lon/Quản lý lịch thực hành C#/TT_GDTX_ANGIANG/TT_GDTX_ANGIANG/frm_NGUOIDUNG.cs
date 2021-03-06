using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing.Imaging;
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
    public partial class frm_NGUOIDUNG : DevComponents.DotNetBar.Office2007Form
    {
        public frm_NGUOIDUNG()
        {
            InitializeComponent();
        }
       

        #region
        private string m_XLDonVi;
        public string XuLy_DonVi
        {
            get { return m_XLDonVi; }
            set { m_XLDonVi = value; }
        }

        #endregion

        #region ctrlNguoiDung
        private NguoiDungCtrl m_ctrlNguoiDung;
        public NguoiDungCtrl ctrlNguoiDung
        {
            get { return m_ctrlNguoiDung; }
            set { m_ctrlNguoiDung = value; }
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

        private void frm_NGUOIDUNG_Load(object sender, EventArgs e)
        {
            #region HienThiComboBox
            PhongBanCtrl ctrlPhong = new PhongBanCtrl();
            ctrlPhong.HienThiComboBox(this.cboPHONGBAN);
            #endregion

            if (ctrlNguoiDung == null)
            {
                ctrlNguoiDung = new NguoiDungCtrl();
            }
            ctrlNguoiDung.HienThi_dsNguoiDung(this.listView);
            if (this.listView.Items.Count > 0)
            {
                this.SelectedIndex = 0;
                this.listView.Items[this.SelectedIndex].Selected = true;
                ctrlNguoiDung.HienThiInfo(txtMAND, cboPHONGBAN, txtTENDN, txtMATKHAU, txtHOTEN, txtGHICHU, (NguoiDungInfo)this.listView.Items[this.SelectedIndex].Tag);

                this.IsAddNew = false;
            }
            else
            {
                this.txtMAND.Text = null;
                this.txtTENDN.Text = null;
                this.txtMATKHAU.Text = null;
                this.txtMATKHAUNL.Text = null;
                this.txtHOTEN.Text = null;
                this.checkBoxToanQuyen.Checked = true;
                
                this.txtGHICHU.Text = null;

                this.IsAddNew = true;
                this.txtMAND.Focus();
            }
        }

        #region itemThemMoi_Click        
       
        private void itemThemMoi_Click(object sender, EventArgs e)
        {
            if (!this.IsAddNew)
            {
                this.txtMAND.Text = null;
                this.txtTENDN.Text = null;
                this.txtMATKHAU.Text = null;
                this.txtMATKHAUNL.Text = null;
                this.txtHOTEN.Text = null;
                this.checkBoxToanQuyen.Checked = true;

                this.txtGHICHU.Text = null;

                this.IsAddNew = true;
            }
            ctrlNguoiDung.Create(txtMAND);
            this.txtTENDN.Focus();
        }
        #endregion


        #region itemLuuLai_Click        
       
        private void itemLuuLai_Click(object sender, EventArgs e)
        {
            if (this.CheckValid())
            {
                NguoiDungInfo info = new NguoiDungInfo();
                info.MaNguoiDung = this.txtMAND.Text;

                PhongBanCtrl ctrlPH = new PhongBanCtrl();
                info.PhongBan = ctrlPH.GetPhongBan(this.cboPHONGBAN.SelectedValue.ToString());

              

                info.TenDangNhap = this.txtTENDN.Text;
                info.MatKhau = this.txtMATKHAU.Text;
                info.HoTen = this.txtHOTEN.Text;
                if (this.checkBoxToanQuyen.Checked == true)
                {
                   
                    info.PhanQuyen = "Toan quyen";

                }
                else if(this.checkBoxChiXemVaTimKiem.Checked==true)
                {
                   
                    info.PhanQuyen = "Chi xem";
                }
                else if (this.checkBoxNVPhongTaiVu.Checked == true)
                {
                    info.PhanQuyen = "Nhan Vien Phong Tai Vu";
                }
                else if (this.checkBoxNVPhongToChuc.Checked == true)
                {
                    info.PhanQuyen = "Nhan Vien Phong To Chuc";
                }

                info.GhiChu = this.txtGHICHU.Text;
                if (IsAddNew)
                {
                    if (ctrlNguoiDung.Add(info))
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
                        ctrlNguoiDung.Update(info, SelectedIndex);
                        this.ReloadData();
                    }
                    ctrlNguoiDung.HienThiInfo(txtMAND, cboPHONGBAN,  txtTENDN, txtMATKHAU, txtHOTEN, txtGHICHU, (NguoiDungInfo)this.listView.Items[this.SelectedIndex].Tag); 
                   
                }
            }
        }
        #endregion

        #region ReloadData()
        private void ReloadData()
        {
            if (ctrlNguoiDung == null)
            {
                ctrlNguoiDung = new NguoiDungCtrl();
            }
            ctrlNguoiDung.HienThi_dsNguoiDung(listView);
            if (listView.Items.Count > 0)
            {
                this.listView.Items[this.SelectedIndex].Selected = true;
                ctrlNguoiDung.HienThiInfo(txtMAND, cboPHONGBAN,  txtTENDN, txtMATKHAU, txtHOTEN, txtGHICHU, (NguoiDungInfo)this.listView.Items[this.SelectedIndex].Tag); 

                this.IsAddNew = false;
            }
            else
            {
                this.txtMAND.Text = null;
                this.txtTENDN.Text = null;
                this.txtMATKHAU.Text = null;
                this.txtMATKHAUNL.Text = null;
                this.txtHOTEN.Text = null;
                this.checkBoxToanQuyen.Checked = true;
                this.txtGHICHU.Text = null;

                this.IsAddNew = true;
                this.txtMAND.Focus();
            }
        }
         #endregion

        #region CheckValid()
        private bool CheckValid()
        {
            if (this.checkBoxNVPhongToChuc.Checked == true && this.checkBoxToanQuyen.Checked == true && this.checkBoxNVPhongTaiVu.Checked == true && this.checkBoxChiXemVaTimKiem.Checked == true)
            {
                MessageBoxEx.Show("Chỉ Được Chọn Một Trong Bốn Quyền!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.checkBoxToanQuyen.Focus();
                return false;
            }
            if ((this.checkBoxNVPhongToChuc.Checked == true && this.checkBoxToanQuyen.Checked == true) || (this.checkBoxToanQuyen.Checked == true && this.checkBoxChiXemVaTimKiem.Checked == true) || (this.checkBoxToanQuyen.Checked == true && this.checkBoxNVPhongTaiVu.Checked == true) || (this.checkBoxNVPhongTaiVu.Checked == true && this.checkBoxChiXemVaTimKiem.Checked == true)|| (this.checkBoxNVPhongTaiVu.Checked == true && this.checkBoxNVPhongToChuc.Checked == true)|| (this.checkBoxNVPhongToChuc.Checked == true && this.checkBoxChiXemVaTimKiem.Checked == true))
            {
                MessageBoxEx.Show("Chỉ Được Chọn Một Trong Bốn Quyền!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.checkBoxToanQuyen.Focus();
                return false;
            }
            if (this.txtTENDN.Text.Trim() == "" )
            {
                MessageBoxEx.Show("Tên đăng nhập không được phép rỗng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtTENDN.Focus();
                return false;
            }
            if (this.txtTENDN.Text.Length < 5)
            {
                MessageBoxEx.Show("Tên đăng nhập phải lớn 6 ký tự!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtTENDN.Text = "";
                this.txtTENDN.Focus();
                return false;
            }
            if (this.txtMATKHAU.Text.Trim() == "" )
            {
                MessageBoxEx.Show("Mật khẩu không được phép rỗng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtMATKHAU.Focus();
                return false;
            }
            if (this.txtMATKHAU.Text.Length < 5)
            {
                MessageBoxEx.Show("Mật khẩu phải lớn hơn 6 ký tự!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtMATKHAU.Text = "";
                this.txtMATKHAU.Focus();
                return false;
            }
            if (this.txtMATKHAU.Text != this.txtMATKHAUNL.Text)
            {
                MessageBoxEx.Show("Bạn đã quên mật khẩu. Xin vui lòng nhập lại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtMATKHAU.Text = "";
                this.txtMATKHAUNL.Text = "";
                this.txtMATKHAU.Focus();
                return false;
            }
            if (this.txtHOTEN.Text.Trim() == "" )
            {
                MessageBoxEx.Show("Họ tên không được phép rỗng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtHOTEN.Focus();
                return false;
            }
            
            
            return true;
        }
        #endregion

        #region itemBoQua_Click        
       
        private void itemBoQua_Click(object sender, EventArgs e)
        {
            if (this.listView.Items.Count > 0)
            {
                ctrlNguoiDung.HienThiInfo(txtMAND, cboPHONGBAN,  txtTENDN, txtMATKHAU, txtHOTEN, txtGHICHU, (NguoiDungInfo)this.listView.Items[this.SelectedIndex].Tag); 
                if (this.IsAddNew)
                    this.IsAddNew = false;
            }
        }
        #endregion

        #region itemXoa_Click        
       
        private void itemXoa_Click(object sender, EventArgs e)
        {
            if (MessageBoxEx.Show("Bạn có chắc là xóa dòng này không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (ctrlNguoiDung.Delete(this.SelectedIndex))
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


        #region listView_SelectedIndexChanged        
       
        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listView.Items.Count > 0)
            {
                IEnumerator ie = this.listView.SelectedItems.GetEnumerator();
                if (ie.MoveNext())
                {
                    this.listView.Items[this.SelectedIndex].ImageIndex = -1;
                    this.listView.Items[this.SelectedIndex].BackColor = Color.White;
                    this.listView.Items[this.SelectedIndex].ForeColor = Color.Black;

                    ListViewItem item = (ListViewItem)ie.Current;
                    item.ImageIndex = 0;
                    item.BackColor = Color.FromArgb(100, 150, 255);
                    item.ForeColor = Color.White;

                    this.SelectedIndex = this.listView.Items.IndexOf(item);
                    ctrlNguoiDung.HienThiInfo(txtMAND, cboPHONGBAN,  txtTENDN, txtMATKHAU, txtHOTEN, txtGHICHU, (NguoiDungInfo)this.listView.Items[this.SelectedIndex].Tag); 

                    if (item.SubItems[5].Text == "Toan quyen")
                    {
                        this.checkBoxToanQuyen.Checked = true;
                        this.checkBoxChiXemVaTimKiem.Checked = false;
                        this.checkBoxNVPhongTaiVu.Checked = false;
                        this.checkBoxNVPhongToChuc.Checked = false;
                    }
                 
                    if (item.SubItems[5].Text == "Chi xem")
                    {
                        this.checkBoxToanQuyen.Checked = false;
                        this.checkBoxChiXemVaTimKiem.Checked = true;
                        this.checkBoxNVPhongTaiVu.Checked = false;
                        this.checkBoxNVPhongToChuc.Checked = false;
                    }
                    if (item.SubItems[5].Text == "Nhan Vien Phong Tai Vu")
                    {
                        this.checkBoxToanQuyen.Checked = false;
                        this.checkBoxChiXemVaTimKiem.Checked = false;
                        this.checkBoxNVPhongTaiVu.Checked = true;
                        this.checkBoxNVPhongToChuc.Checked = false;
                    }
                    if (item.SubItems[5].Text == "Nhan Vien Phong To Chuc")
                    {
                        this.checkBoxToanQuyen.Checked = false;
                        this.checkBoxChiXemVaTimKiem.Checked = false;
                        this.checkBoxNVPhongTaiVu.Checked = false;
                        this.checkBoxNVPhongToChuc.Checked = true;
                    }

                }
            }
        }
        #endregion

        #region listView_Click        
       
        private void listView_Click(object sender, EventArgs e)
        {
            this.txtMATKHAUNL.Text = this.txtMATKHAU.Text;
        }
        #endregion

    }
}