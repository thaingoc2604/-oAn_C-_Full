using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MDS.BussinessRule;
using System.Configuration;
namespace AnTCafe
{
    public partial class frmChonBan : Form
    {
        clsBLoaiKhachLoai objLoaiKhachHang = new clsBLoaiKhachLoai();
        clsBBan objBan = new clsBBan();
        clsBPhieuXuat objPhieuXuat = new clsBPhieuXuat();
        clsCommonUI objCommon = new clsCommonUI();

        DataTable tblLoaiKhachHang = new DataTable();
        DataTable tblBan = new DataTable();
        DataTable tblPhieuXuat = new DataTable();
        DataTable tblTmp = new DataTable();

        public frmChonBan()
        {
            InitializeComponent();
            string con_str = Program.ConnectionString;
            objLoaiKhachHang.ConnectionString = con_str;
            objLoaiKhachHang.Initialize();
            objBan.ConnectionString = con_str;
            objBan.Initialize();
            objPhieuXuat.ConnectionString = con_str;
            objPhieuXuat.Initialize();
            
        }

        private void frmChonBan_Activated(object sender, EventArgs e)
        {
            LoadlstDSBan();
            txtMaBan.Focus();
        }

        public void KhoiGan()
        {
            LoadlstDSBan();
            txtMaBan.Text = "";
            txtLoaiKH.Text = "";
            txtLoaiKH.Enabled = false;
            
        }

        public void LoadlstDSBan() {
            ListViewItem lvi;
            lstDSBan.Items.Clear();
            tblBan = objBan.SELECT_ALL();
            foreach (DataRow dr in tblBan.Rows)
            {
                if (objPhieuXuat.DA_THANH_TOAN(dr["MaBan"].ToString()) == true)
                    lvi = new ListViewItem(dr["Ten"].ToString() + "[" + dr["MaBan"].ToString() + "]", 1);
                else
                    lvi = new ListViewItem(dr["Ten"].ToString() + "[" + dr["MaBan"].ToString() + "]", 0);
                lstDSBan.Items.Add(lvi);
            }
        }
        
        private void btnThucHien(string strThanhToan)
        {
            frmXuatHang fXuatHang = new frmXuatHang();
            fXuatHang.LoaiKH = txtLoaiKH.Text;
            fXuatHang.MaBan = txtMaBan.Text;
            if (strThanhToan == "new")//tao phieu moi
            {
                fXuatHang.SoPhieuXuat = "";
            }
            else //chua thanh toan
            {
                fXuatHang.SoPhieuXuat = strThanhToan;
            }
            fXuatHang.passData = new frmXuatHang.PassData(KhoiGan);
            fXuatHang.ShowDialog();
            txtMaBan.Focus();
        }


        private void txtMaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r") 
            {
                if (objCommon.isDuplicate(txtMaBan.Text, "MaBan", "Ban") == 1)
                {
                    tblTmp.Clear();
                    objPhieuXuat.MaBan = txtMaBan.Text;
                    tblTmp = objPhieuXuat.GET_LAST_BY_BAN();
                    if (tblTmp.Rows.Count > 0)
                    {
                        if ((int)tblTmp.Rows[0]["ThanhToan"] == 1)//Da thanh toan -> tao phieu moi
                        {
                            txtLoaiKH.Enabled = true;
                            txtLoaiKH.Focus();
                        }
                        else //Chua thanh toan
                            btnThucHien(tblTmp.Rows[0]["SoPhieuXuat"].ToString());
                    }
                    else//Thuc hien lan dau
                    {
                        txtLoaiKH.Enabled = true;
                        txtLoaiKH.Focus();
                    }
                }
                else
                    MessageBox.Show("Không tồn tại số bàn này");            
            }


        }

        private void txtLoaiKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
                if (objCommon.isDuplicate(txtLoaiKH.Text, "LoaiKH", "LoaiKhachHang") == 1)
                    btnThucHien("new");
                else
                    MessageBox.Show("Không tồn tại loại khách hàng này");
                
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}