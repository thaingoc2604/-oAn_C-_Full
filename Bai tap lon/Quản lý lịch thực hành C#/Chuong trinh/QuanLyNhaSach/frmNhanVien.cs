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
    public partial class frmNhanVien : DockContent
    {
        NhanVienCtrl nv_Ctrl = new NhanVienCtrl();
        NhanVienInfo nv_Info = new NhanVienInfo();
        CurrencyManager row;
        DataTable tbl_NhanVien;
        
        public frmNhanVien()
        {
            InitializeComponent();
            LoadTable();
            hienthilen_TextBox();
            an_TextBox();
        }

        void LoadTable()
        {
            tbl_NhanVien = nv_Ctrl.Tbl_NhanVien();
            row = BindingContext[tbl_NhanVien] as CurrencyManager;
            dataGridView1.DataSource = tbl_NhanVien;
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
            nv_Ctrl.XoaNV(txtManv.Text);
            LoadTable();
            hienthilen_TextBox();
            an_TextBox();
           
        }   

        bool sua = false;
        string maNV;
        private void btnSua_Click(object sender, EventArgs e)
        {
            HienTextBox();
            sua = true;
            maNV = txtManv.Text;
        }

        private void bntThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn đã chắc chắn thoát!", "QUANLYNHASACH", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        string gioitinh;
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtManv.Text == ""||txtHoTenNV.Text == "" ||txtChucVu.Text==""||txtDiaChi.Text ==""||txtDT.Text =="")            
            {
                MessageBox.Show("Thông tin nhập ko được trống");
                txtManv.Focus();
            }
            else
            {
                if (them)
                {

                    if(radioButton1.Checked == true)
                        gioitinh = "NAM";
                    else gioitinh = "NU";
                        nv_Ctrl.ThemNV(txtManv.Text, txtHoTenNV.Text,gioitinh, txtChucVu.Text, txtDiaChi.Text, txtDT.Text);
                        them = false;                      
                    
                    
                }
                if (sua)
                {
                    NhanVienInfo nv_Info = new NhanVienInfo();
                    nv_Info.MaNhanVien = txtManv.Text;
                    nv_Info.TenNhanVien = txtHoTenNV.Text;
                    if (radioButton1.Checked == true)
                        nv_Info.Phai = "NAM";
                    else nv_Info.Phai = "NU";
                    //nv_Info.Phai = txtPhai.Text;
                    nv_Info.ChucVu = txtChucVu.Text;
                    nv_Info.DiaChi = txtDiaChi.Text;
                    nv_Info.DienThoai = txtDT.Text;                
                    nv_Ctrl.UpdateNV(nv_Info, maNV);
                    sua = false;
                }
                LoadTable();
                an_TextBox();
            }
            
        }

       

        void hienthilen_TextBox()
        {            
            txtManv.Text = tbl_NhanVien.Rows[row.Position]["MANV"].ToString();
            txtHoTenNV.Text = tbl_NhanVien.Rows[row.Position]["HOTENNV"].ToString();
            if (tbl_NhanVien.Rows[row.Position]["PHAI"].ToString() == "NAM")
                radioButton1.Checked = true;
            else radioButton2.Checked = true;
            //txtPhai.Text = tbl_NhanVien.Rows[row.Position]["PHAI"].ToString();
            txtChucVu.Text = tbl_NhanVien.Rows[row.Position]["CHUCVU"].ToString();
            txtDiaChi.Text = tbl_NhanVien.Rows[row.Position]["DIACHI"].ToString();
            txtDT.Text = tbl_NhanVien.Rows[row.Position]["DIENTHOAI"].ToString();
        }

        void an_TextBox()
        {
            
            txtManv.Enabled = false;            
            txtHoTenNV.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            txtChucVu.Enabled = false;
            txtDiaChi.Enabled = false;            
            txtDT.Enabled = false;
        }

        void HienTextBox()
        {
            
            txtManv.Enabled = true;
            txtHoTenNV.Enabled = true;
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            txtChucVu.Enabled = true;
            txtDiaChi.Enabled = true;
            txtDT.Enabled = true;
        }

        void XoaTextBox()
        {           
            txtManv.Text = "";
            txtHoTenNV.Text = "";
            txtDiaChi.Text = "";
            txtChucVu.Text = "";            
            txtDT.Text = "";
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            row.Position--;
            hienthilen_TextBox();
        }

        private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
        {
            row.Position++;
            hienthilen_TextBox();
        }
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            hienthilen_TextBox();
        }
        private void btnTKTC_Click(object sender, EventArgs e)
        {
            frmTimKiemNhanVien tk = new frmTimKiemNhanVien();
            tk.ShowDialog();         

            if (tk.DialogResult == DialogResult.OK)
            {
                //-- tao moi doi tuong tra ve
                NhanVienInfo nv = tk.NV;

                //--bo thong tin vao cac object
                txtManv.Text = nv.MaNhanVien;
                txtHoTenNV.Text = nv.TenNhanVien;
                if (radioButton1.Checked == true)
                    nv_Info.Phai = "NAM";
                else
                    nv_Info.Phai = "NU";
                txtDiaChi.Text = nv.DiaChi;
                txtChucVu.Text = nv.ChucVu;
                txtDT.Text = nv.DienThoai;
            }
            
        }
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            nv_Ctrl.load_data(txtManv, txtHoTenNV, radioButton1,radioButton2, txtChucVu, txtDiaChi, txtDT, dataGridView1.Rows[e.RowIndex]);
        }

        private void txtDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 'z' || e.KeyChar > 'a')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("So điện thoại chỉ là số");
            }
        }
    }
}