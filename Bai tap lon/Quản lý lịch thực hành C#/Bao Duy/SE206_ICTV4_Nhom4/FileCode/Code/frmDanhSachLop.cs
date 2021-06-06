using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Linq;
namespace DeTai_QuanLySinhVien
{
    public partial class frmDanhSachLop : DevComponents.DotNetBar.Office2007Form
    {
        string malop;
        string tenlop;
        public frmDanhSachLop()
        {
            InitializeComponent();
        }

        private void pnDanhSachLop_Click(object sender, EventArgs e)
        {

        }
        QuanLySinhVienDataContext db = new QuanLySinhVienDataContext();
        private void frmDanhSachLop_Load(object sender, EventArgs e)
        {
            try
            {
                HienThiDSKhoa();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chưa Kết nối CSDL "+ ex.Message );
            }
           
        }

        private void HienThiDSKhoa()
        {
            cbDanhSachKhoa.DataSource = db.Khoas;
            cbDanhSachKhoa.DisplayMember = "TenKhoa";
            cbDanhSachKhoa.ValueMember = "Khoa_ID";
            cbDanhSachKhoa.SelectedIndex = -1;
        }

        private void btnHienThiDSLop_Click(object sender, EventArgs e)
        {
            lsvDanhSachLop.Items.Clear();
            if (cbDanhSachKhoa.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn Chưa chọn danh sách khoa để hiển thị danh sách lớp");
            }
            else
            {
                try
                {
                    HienThiDanhSachLop();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Chưa Kết nối CSDL " + ex.Message);
                }
               
                
            }
        }

        private void HienThiDanhSachLop()
        {
            lsvDanhSachLop.Items.Clear();
            string maKhoa = cbDanhSachKhoa.Tag.ToString();
            var DSLop = from Lop in db.Lops
                        where Lop.ID_Khoa == maKhoa
                        select new
                        {
                            Lop_ID = Lop.Lop_ID,
                            TenLop = Lop.TenLop
                        };
            foreach (var ds in DSLop)
            {
                ListViewItem li = lsvDanhSachLop.Items.Add(ds.Lop_ID);
                li.SubItems.Add(ds.TenLop);
            }
        }

        private void cbDanhSachKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            lsvDanhSachLop.Items.Clear();
            if (cbDanhSachKhoa.SelectedIndex >= 0)
            {
                string maKhoa = cbDanhSachKhoa.SelectedValue.ToString();
                var maLop = from Khoa in db.Khoas
                            where Khoa.Khoa_ID == maKhoa
                            select new
                            {
                                ID_Khoa = Khoa.Khoa_ID
                            };
                foreach (var item in maLop)
                {
                    cbDanhSachKhoa.Tag = item.ID_Khoa;
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaLop.ReadOnly = false;
            if (cbDanhSachKhoa.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn thông tin khoa ");
            }
            else
            {
                //frmThemLop f = new frmThemLop(cbDanhSachKhoa.Tag.ToString());
                //f.Show();
                if (txtMaLop.Text.Trim() == "" || txtTenLop.Text.Trim() == "")
                {
                    MessageBox.Show("Bạn Chưa nhập đủ thông tin lớp !", " Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }
                else 
                {
                    ThemLop();
                }
                
            }
        }
        public bool ktMa()
        {
            var kt = from Lop in db.Lops
                     where Lop.Lop_ID == txtMaLop.Text.Trim()
                     select Lop;
            foreach (var item in kt)
            {
                return true;
            }
            return false;
        }
        private void ThemLop()
        {
            try
            {
                if (ktMa())
                {
                    MessageBox.Show("Mã bị trùng mời nhập lại");
                    txtMaLop.Text = "";
                    txtTenLop.Text = "";
                    txtMaLop.Focus();
                }
                else
                {
                    Lop themlop = new Lop();
                    themlop.Lop_ID = txtMaLop.Text.Trim();
                    themlop.TenLop = txtTenLop.Text.Trim();
                    themlop.ID_Khoa = cbDanhSachKhoa.Tag.ToString();
                    db.Lops.InsertOnSubmit(themlop);
                    DialogResult dl = MessageBox.Show("Bạn đã thêm Lớp thành công !!", " Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dl == DialogResult.Yes)
                    {
                        db.SubmitChanges();
                        HienThiDanhSachLop();
                        txtMaLop.Text = "";
                        txtTenLop.Text = "";
                        txtMaLop.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
        private void frmDanhSachLop_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có muốn thoát chương trình không ?", " Thông báo !!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dl == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lsvDanhSachLop.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Bạn phải chọn thông tin cần xóa từ danh sách khoa !!", " Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            else
            {
                try
                {
                    var del = db.Lops.Single(c => c.Lop_ID == malop);
                    db.Lops.DeleteOnSubmit(del);
                    DialogResult dl = MessageBox.Show("Bạn đã xóa thành công !!", " Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dl == DialogResult.Yes)
                    {
                        db.SubmitChanges();
                        HienThiDanhSachLop();
                        txtMaLop.Text = "";
                        txtTenLop.Text = "";
                        txtMaLop.Focus();
                        txtMaLop.ReadOnly = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lsvDanhSachLop.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Bạn phải chọn thông tin cần xóa từ danh sách khoa !!", " Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            else
            {
                //frmSuaThongTinLop f = new frmSuaThongTinLop(malop,tenlop);
                //f.Show();
                SuaThongTinLops();
            }
        }
        private void SuaThongTinLops()
        {
            var editKhoa = db.Lops.Single(c => c.Lop_ID == malop);
            editKhoa.TenLop= txtTenLop.Text.Trim();
            DialogResult dl = MessageBox.Show("Bạn đã Sửa thành công !!", " Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
            {
                db.SubmitChanges();
                HienThiDanhSachLop();
                txtMaLop.Text = "";
                txtTenLop.Text = "";
            }
        }
        private void lsvDanhSachLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvDanhSachLop.SelectedItems.Count > 0)
            {
                txtMaLop.ReadOnly = true;
                ListViewItem li = lsvDanhSachLop.SelectedItems[0];
                malop = li.SubItems[0].Text.Trim();
                tenlop = li.SubItems[1].Text.Trim();
                var hienthilentexBox = from Lop in db.Lops
                                       where Lop.Lop_ID == malop
                                       select Lop;
                foreach (var item in hienthilentexBox)
                {
                    txtMaLop.Text = item.Lop_ID;
                    txtTenLop.Text = item.TenLop;
                }
            }
        }
    }
}