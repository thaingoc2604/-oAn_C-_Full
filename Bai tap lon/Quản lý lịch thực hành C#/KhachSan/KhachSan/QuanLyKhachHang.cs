using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using KetNoiDL;

namespace KhachSan
{
    public partial class QuanLyKhachHang : Form
    {
        public QuanLyKhachHang()
        {
            InitializeComponent();
        }

        TTKetNoi tt = new TTKetNoi();
        string temTen, temCMND, tenSODT, temDC;

        private void QuanLyKhachHang_Load(object sender, EventArgs e)
        {
            Load_TTKH();
        }

        public void Load_TTKH()
        {
            OleDbDataReader re = tt.getDataReader("KhachHang");
            lvwKH.Items.Clear();
            while (re.Read())
            {
                ListViewItem i = new ListViewItem();
                i.Text = re["MaKH"].ToString();
                i.SubItems.Add(re["TenKH"].ToString());
                i.SubItems.Add(re["SoCMND"].ToString());
                i.SubItems.Add(re["SoDT"].ToString());
                i.SubItems.Add(re["DiaChi"].ToString());

                lvwKH.Items.Add(i);
            }
            
            if (lvwKH.Items.Count > 0)
            {
                txtMaKH.Text = lvwKH.Items[0].Text;
                txtTenKH.Text = lvwKH.Items[0].SubItems[1].Text;
                txtCMND.Text = lvwKH.Items[0].SubItems[2].Text;
                txtSDT.Text = lvwKH.Items[0].SubItems[3].Text;
                txtDC.Text = lvwKH.Items[0].SubItems[4].Text;

                temTen = txtTenKH.Text;
                tenSODT = txtSDT.Text;
                temCMND = txtCMND.Text;
                temDC = txtDC.Text;
            }
        }

        public bool KTThayDoi(string s1, string s2)
        {
            if (s1.Equals(s2))
                return false;
            return true;
        }

        private void lvwKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm Khách Hàng")
            {
                if (KTThayDoi(txtTenKH.Text, temTen) == true ||KTThayDoi(txtCMND.Text, temCMND) == true
                  || KTThayDoi(txtSDT.Text, tenSODT) == true || KTThayDoi(txtDC.Text, temDC) == true)
                {
                    temTen = txtTenKH.Text;
                    tenSODT = txtSDT.Text;
                    temCMND = txtCMND.Text;
                    temDC = txtDC.Text;
                    DialogResult d;
                    d = MessageBox.Show("Bạn có muốn lưu thông tin vừa thay đổi?", "Thông Báo", MessageBoxButtons.YesNo);
                    if (d == DialogResult.Yes)
                    {
                        tt.UpdateKhachHang(txtMaKH.Text, txtTenKH.Text, txtCMND.Text, txtSDT.Text, txtDC.Text);
                        Load_TTKH();
                    }
                }
            }

            foreach (ListViewItem i in lvwKH.SelectedItems)
            {
                txtMaKH.Text = i.Text;
                txtTenKH.Text = i.SubItems[1].Text;
                txtCMND.Text = i.SubItems[2].Text;
                txtSDT.Text = i.SubItems[3].Text;
                txtDC.Text = i.SubItems[4].Text;

                temTen = txtTenKH.Text;
                tenSODT = txtSDT.Text;
                temCMND = txtCMND.Text;
                temDC = txtDC.Text;
               
                btnThem.Text = "Thêm Khách Hàng";
            }
            txtMaKH.Enabled = false;
        }

        public bool KTmaKH(string ma)
        {
            if (tt.KTmaKH(ma) == false)
            {
                MessageBox.Show("Đã Có Mã Khách Hàng Này");
                return false;
            }
            if (txtMaKH.Text.Trim() == "" || txtMaKH.Text.Length > 50
                || txtTenKH.Text.Trim() == "" || txtTenKH.Text.Length > 50
                || txtCMND.Text.Trim() == "" || txtCMND.Text.Length > 50
                || txtSDT.Text.Trim() == "" || txtSDT.Text.Length > 50
                || txtDC.Text.Trim() == "" || txtDC.Text.Length > 50)
            {
                MessageBox.Show("Chưa Nhập Đủ Thông Tin Hoặc Nhập Quá Nhiều Kí Tự (<50)");
                return false;
            }
            return true;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text.Equals("Thêm Khách Hàng"))
            {
                txtMaKH.Text = "";
                txtTenKH.Text = "";
                txtCMND.Text = "";
                txtSDT.Text = "";
                txtDC.Text = "";

                btnThem.Text = "Lưu";
                txtMaKH.Enabled = true;
                txtMaKH.Focus();
            }
            else
            {
                if (KTmaKH(txtMaKH.Text) == true)
                {
                    tt.ThemKhachHang(txtMaKH.Text, txtTenKH.Text, txtCMND.Text, txtSDT.Text, txtDC.Text);
                    Load_TTKH();
                    txtMaKH.Enabled = false;
                    btnThem.Text = "Thêm Khách Hàng";
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Lưu" || lvwKH.SelectedItems.Count < 1)
                MessageBox.Show("Chưa Chọn Khách Hàng Cần Xóa");
            else
            {
                DialogResult d = MessageBox.Show("Xóa Dữ Liệu Này Có Thể Gây Mất Dữ Liệu Ở Bảng Khác \n Bạn Có Chắc Muốn Xóa?", "Thông Báo", MessageBoxButtons.YesNo);
                if (d == DialogResult.Yes)
                {
                    if (btnThem.Text == "Thêm Khách Hàng")
                    {
                        tt.XoaKhachHang(txtMaKH.Text);
                        Load_TTKH();
                    }
                }
            }
        }

       
        
    }
}