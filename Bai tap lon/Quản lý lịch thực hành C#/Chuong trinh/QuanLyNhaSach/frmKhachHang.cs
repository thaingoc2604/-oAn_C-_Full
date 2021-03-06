using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using QuanLyNhaSach.Control;
using QuanLyNhaSach.Builder_layer;

namespace QuanLyNhaSach
{
    public partial class frmKhachHang : DockContent
    {
        KhachHangCtrl kh_Ctrl = new KhachHangCtrl();
        CurrencyManager row;
        DataTable tbl_KhachHang;

        public frmKhachHang()
        {
            InitializeComponent();
            
            LoadTable();
            hienthilen_TextBox();
            an_TextBox();
        }      

        void LoadTable()
        {
            tbl_KhachHang = kh_Ctrl.Tbl_KhachHang();
            row = BindingContext[tbl_KhachHang] as CurrencyManager;
            dataGridView1.DataSource = tbl_KhachHang;
        }

      

        bool them = false;
        private void btnThem_Click(object sender, EventArgs e)
        {
            HienTextBox();
            XoaTextBox();
            them = true;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            kh_Ctrl.XoaKH(txtMaKH.Text);
            LoadTable();
            hienthilen_TextBox();
            an_TextBox();
        }

        bool sua = false;
        string maKH;
        private void btnSua_Click(object sender, EventArgs e)
        {
            HienTextBox();
            sua = true;
            maKH = txtMaKH.Text;
        }
        string gioitinh;
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text == "" || txtTenKH.Text == "" || txtDiaChi.Text == "" || txtDT.Text == "" || txtMST.Text == "")            
            {
                MessageBox.Show("Thông tin nhập ko được trống");
                txtMaKH.Focus();
            }
            else
            {           
                if (them)
                {
                    if(radioButton1.Checked == true)
                        gioitinh = "NAM";
                    else gioitinh = "NU";                    
                    kh_Ctrl.ThemKH(txtMaKH.Text, txtTenKH.Text, gioitinh, txtDiaChi.Text, txtDT.Text, txtMST.Text, txtGhiChu.Text);
                    them = false;                     
                }
                if (sua)
                {
                    KhachHangInfo kh_Info = new KhachHangInfo();
                    kh_Info.MaKhachHang = txtMaKH.Text;
                    kh_Info.TenKhachHang = txtTenKH.Text;
                    if (radioButton1.Checked == true)
                        kh_Info.Phai = "NAM";
                    else kh_Info.Phai = "NU";
                    kh_Info.DiaChi = txtDiaChi.Text;
                    kh_Info.DienThoai = txtDT.Text;
                    kh_Info.MaSoThue = txtMST.Text;
                    kh_Info.GhiChu = txtGhiChu.Text;
                    kh_Ctrl.UpdateKH(kh_Info, maKH);
                    sua = false;
                }
                LoadTable();
                an_TextBox();
            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            hienthilen_TextBox();
        }

        private void bntThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn đã chắc chắn thoát!", "QUANLYNHASACH", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        void hienthilen_TextBox()
        {
            txtMaKH.Text = tbl_KhachHang.Rows[row.Position]["MAKH"].ToString();
            txtTenKH.Text = tbl_KhachHang.Rows[row.Position]["HOTENKH"].ToString();
            if (tbl_KhachHang.Rows[row.Position]["PHAI"].ToString() == "NAM")
                radioButton1.Checked = true;
            else radioButton2.Checked = true;
            //txtPhai.Text = tbl_KhachHang.Rows[row.Position]["PHAI"].ToString();            
            txtDiaChi.Text = tbl_KhachHang.Rows[row.Position]["DIACHI"].ToString();
            txtDT.Text = tbl_KhachHang.Rows[row.Position]["DIENTHOAI"].ToString();
            txtMST.Text = tbl_KhachHang.Rows[row.Position]["MASOTHUE"].ToString();
            txtGhiChu.Text = tbl_KhachHang.Rows[row.Position]["GHICHU"].ToString();
        }

        void an_TextBox()
        {
            txtMaKH.Enabled = false;
            txtTenKH.Enabled = false;
            //txtPhai.Enabled = false;
            txtMST.Enabled = false;
            txtDiaChi.Enabled = false;
            txtDT.Enabled = false;
            txtGhiChu.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
        }

        void HienTextBox()
        {
            txtMaKH.Enabled = true;
            txtTenKH.Enabled = true;
            //txtPhai.Enabled = true;
            txtMST.Enabled = true;
            txtDiaChi.Enabled = true;
            txtDT.Enabled = true;
            txtGhiChu.Enabled = true;
            radioButton2.Enabled = true;
            radioButton1.Enabled = true;
        }

        void XoaTextBox()
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            //txtPhai.Text = "";
            txtMST.Text = "";
            txtDiaChi.Text = "";
            txtDT.Text = "";
            txtGhiChu.Text = "";
        }

        private void btnTKTC_Click(object sender, EventArgs e)
        {
            frmTimKhachHang tk = new frmTimKhachHang();
            tk.ShowDialog();
            if (tk.DialogResult == DialogResult.OK)
            {
                //-- tao moi doi tuong tra ve
                KhachHangInfo kh = tk.KH;

                //--bo thong tin vao cac object
                txtMaKH.Text = kh.MaKhachHang;
                txtTenKH.Text = kh.TenKhachHang;                
                if (radioButton1.Checked == true)
                    kh.Phai = "NAM";
                else
                    kh.Phai = "NU";
                txtDiaChi.Text = kh.DiaChi;
                txtDT.Text = kh.DienThoai;
                txtMST.Text = kh.MaSoThue;
                txtGhiChu.Text = kh.GhiChu;
            }
        }
    }
}