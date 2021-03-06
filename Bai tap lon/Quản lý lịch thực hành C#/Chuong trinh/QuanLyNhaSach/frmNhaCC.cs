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
    public partial class frmNhaCC : DockContent
    {
        NhaCungCapCtrl ncc_Ctrl = new NhaCungCapCtrl();
        CurrencyManager row;
        DataTable tbl_NhaCungCap;      
        public frmNhaCC()
        {
            InitializeComponent();

            LoadTable();
            hienthilen_TextBox();
            an_TextBox();
        }

        void LoadTable()
        {
            tbl_NhaCungCap = ncc_Ctrl.Tbl_NhaCungCap();
            row = BindingContext[tbl_NhaCungCap] as CurrencyManager;
            dataGridView1.DataSource = tbl_NhaCungCap;
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
            ncc_Ctrl.XoaNV(txtMaNCC.Text);
            LoadTable();
            hienthilen_TextBox();
            an_TextBox();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaNCC.Text == "" || txtTenNCC.Text == "" || txtDiaChi.Text == "" || txtDT.Text == "" || txtMST.Text == "")
            {
                MessageBox.Show("Thông tin nhập ko được trống");
                txtMaNCC.Focus();
            }
            else
            {
                if (them)
                {
                    ncc_Ctrl.ThemNV(txtMaNCC.Text, txtTenNCC.Text, txtDiaChi.Text, txtDT.Text, txtMST.Text, txtGhiChu.Text);
                    them = false;
                }
                if (sua)
                {
                    NhaCungCapInfo ncc_Info = new NhaCungCapInfo();
                    ncc_Info.MaNhaCungCap = txtMaNCC.Text;
                    ncc_Info.TenNhaCungCap = txtTenNCC.Text;
                    ncc_Info.DiaChi = txtDiaChi.Text;
                    ncc_Info.DienThoai = txtDT.Text;
                    ncc_Info.MaSoThue = txtMST.Text;
                    ncc_Info.GhiChu = txtGhiChu.Text;
                    ncc_Ctrl.UpdateNV(ncc_Info, maNCC);
                    sua = false;
                }
                LoadTable();
                an_TextBox();
            }
        }

        bool sua = false;
        string maNCC;
        private void btnSua_Click(object sender, EventArgs e)
        {
            HienTextBox();
            sua = true;
            maNCC = txtMaNCC.Text;
        }

        private void bntThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn đã chắc chắn thoát!", "QUANLYNHASACH", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {

            hienthilen_TextBox();
        }

        void hienthilen_TextBox()
        {
            txtMaNCC.Text = tbl_NhaCungCap.Rows[row.Position]["MANCC"].ToString();
            txtTenNCC.Text = tbl_NhaCungCap.Rows[row.Position]["TENNCC"].ToString();
            txtDiaChi.Text = tbl_NhaCungCap.Rows[row.Position]["DIACHI"].ToString();
            txtDT.Text = tbl_NhaCungCap.Rows[row.Position]["DIENTHOAI"].ToString();
            txtMST.Text = tbl_NhaCungCap.Rows[row.Position]["MASOTHUE"].ToString();
            txtGhiChu.Text = tbl_NhaCungCap.Rows[row.Position]["GHICHU"].ToString();
        }

        void an_TextBox()
        {
            txtMaNCC.Enabled = false;
            txtTenNCC.Enabled = false;
            txtDiaChi.Enabled = false;
            txtDT.Enabled = false;
            txtMST.Enabled = false;
            txtGhiChu.Enabled = false;
        }

        void HienTextBox()
        {
            txtMaNCC.Enabled = true;
            txtTenNCC.Enabled = true;
            txtDiaChi.Enabled = true;
            txtDT.Enabled = true;
            txtMST.Enabled = true;
            txtGhiChu.Enabled = true;
        }

        void XoaTextBox()
        {
            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtDiaChi.Text = "";
            txtDT.Text = "";
            txtMST.Text = "";
            txtGhiChu.Text = "";
        }

        private void btnTKTC_Click(object sender, EventArgs e)
        {
            frmTimKiemNhaCC tk = new frmTimKiemNhaCC();
            tk.ShowDialog();

            if (tk.DialogResult == DialogResult.OK)
            {
                //-- tao moi doi tuong tra ve
                NhaCungCapInfo ncc = tk.NCC;

                //--bo thong tin vao cac object
                txtMaNCC.Text = ncc.MaNhaCungCap;
                txtTenNCC.Text = ncc.TenNhaCungCap;
                txtDiaChi.Text = ncc.DiaChi;
                txtDT.Text = ncc.DienThoai;
                txtMST.Text = ncc.MaSoThue;
                txtGhiChu.Text = ncc.GhiChu;
            }
        }

       
    }
}