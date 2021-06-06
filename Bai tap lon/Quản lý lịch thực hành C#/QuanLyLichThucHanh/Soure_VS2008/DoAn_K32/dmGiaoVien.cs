using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DTO;
using BussinessLayer;
using System.Threading;

namespace DoAn_K32
{
    public partial class dmGiaoVien : DevExpress.XtraEditors.XtraUserControl
    {
        public dmGiaoVien()
        {
            InitializeComponent();
        }

        
        private void LoadDuLieu()
        {
            grDanhSachGV.DataSource = BussinessLayer.GiaoVienBus.LoadGiaoVien();
            //DataGridViewComboBoxColumn objCol = CreateComboboxColumn("STTSV", "STTSV", BussinessLayer.GiaoVienBus.LoadGiaoVien(), "STT");
            //DataTable tb = new DataTable();
            dxeMa.SetError(txtMaGV, "Mã có cấu trúc GV__");
            dxeHo.SetError(txtHoGV, "Hãy nhập họ ");
            dxeTenGV.SetError(txtTenGV, "Nhập tên giáo viên");
            dxeNgaySinh.SetError(dtNgaySinh, "Ngày phải trên 18 tuổi");
            dxeDiaChi.SetError(txtDiaChi, "Chưa nhập địa chỉ");
           //dxeDienThoai.SetError(txtSoDT, "Chưa Nhập Số Điện thoại");
            dxeDienThoai.SetError(txtSoDT, "Chưa nhập số điện thoại");
            //dxErrorProvider1.SetError(txtTenGV, "đấ");

        }
        //Nhap so thuc
        private void NhapSoThuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            string decimalString = Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator;
            char decimalChar = Convert.ToChar(decimalString);

            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            { }
            else
            {
                if (e.KeyChar == Convert.ToChar(decimalString) && txtSoDT.Text.IndexOf(decimalString) == -1)
                { }
                else
                {
                    e.Handled = true;
                }
            }


            // Chú thích :
            // Char.IsDigit(e.KeyChar) --> kiểm tra xem phím vừa nhập vào textbox có phải là ký tự số hay không, hàm này trả về kiểu bool 
            // Char.IsContro(e.KeyChar) --> kiểm tra xem phím vừa nhập vào textbox có phải là các ký tự điều khiển 
            // (các phím mũi tên,Delete,Insert,backspace,space bar) hay không, mục đích dùng hàm này là để cho phép người dùng xóa số trong trường hợp nhập sai.
            // Handled=true -->để chặn các cú nhấn phím không hợp lệ
        }

        internal static DataGridViewComboBoxColumn CreateComboboxColumn(String ColumnName, String HeaderText, DataTable pTable, String ColumnNameDisplay)
        {
            DataGridViewComboBoxColumn objColumn = new DataGridViewComboBoxColumn();
            objColumn.Name = ColumnName;
            objColumn.HeaderText = HeaderText;
            objColumn.DataPropertyName = ColumnName;
            objColumn.DropDownWidth = 160;
            objColumn.Width = 100;
            objColumn.MaxDropDownItems = 10;
            objColumn.FlatStyle = FlatStyle.Standard;
            objColumn.DataSource = pTable;
            objColumn.DisplayMember = ColumnNameDisplay;
            return objColumn;
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            if (this.txtMaGV.Text.Length == 5)
            {
                try
                {
                    BussinessLayer.GiaoVienBus.Them_GiaoVien(GetGiaoVien());
                    MessageBox.Show("Thêm thành công !");
                    LoadDuLieu();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Không thêm được");
                }
            }
            else
                MessageBox.Show("Nhập mã giáo viên chưa hợp lệ");
        }
        private GiaoVien_Info GetGiaoVien()
        {
            GiaoVien_Info gv = new GiaoVien_Info();
            gv.MaGV = this.txtMaGV.Text;
            gv.HoGV = this.txtHoGV.Text;
            gv.TenGV = this.txtTenGV.Text;
            gv.GioiTinh = this.cbbGioiTinh.Text;
            gv.NgaySinh = this.dtNgaySinh.DateTime;
            gv.ChuyenNganh = this.cbbChuyenNganh.Text;
            gv.DiaChi = this.txtDiaChi.Text;
            gv.SoDT = this.txtSoDT.Text;
            return gv;

        }

        private void dmGiaoVien_Load_1(object sender, EventArgs e)
        {
            LoadDuLieu();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (rdMaGV.Checked)
            {
                grDanhSachGV.DataSource = BussinessLayer.GiaoVienBus.TimTheoMa(txtThongTin.Text);
            }
            else
                grDanhSachGV.DataSource = BussinessLayer.GiaoVienBus.TimTheoTen(txtThongTin.Text);

        }

        private void txtThongTin_EditValueChanged(object sender, EventArgs e)
        {
            if (rdMaGV.Checked)
            {
                grDanhSachGV.DataSource = BussinessLayer.GiaoVienBus.TimTheoMa(txtThongTin.Text);
            }
            else
                grDanhSachGV.DataSource = BussinessLayer.GiaoVienBus.TimTheoTen(txtThongTin.Text);
        }

        private void grDanhSachGV_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void txtMaXoa_TextChanged(object sender, EventArgs e)
        {
            if (rdMaGV.Checked)
            {
                grDanhSachGV.DataSource = BussinessLayer.GiaoVienBus.TimTheoMa(txtMaXoa.Text);
            }
            else
                grDanhSachGV.DataSource = BussinessLayer.GiaoVienBus.TimTheoTen(txtMaXoa.Text);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (BussinessLayer.GiaoVienBus.Xoa_GiaoVien(txtMaXoa.Text))
            {
                MessageBox.Show("Xóa thành công.");
                LoadDuLieu();
            }
            else
                MessageBox.Show("Không xóa được !");
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (KiemTraNhap() && KiemTraSDT(txtSoDT.Text) && KiemTraNgaySinhs(dtNgaySinh))
            {
                GiaoVien_Info giaovien = new GiaoVien_Info(txtMaGV.Text, txtHoGV.Text, txtTenGV.Text, cbbGioiTinh.Text, DateTime.Parse(dtNgaySinh.EditValue.ToString()), cbbChuyenNganh.Text, txtDiaChi.Text, txtSoDT.Text);
                if (GiaoVienBus.ThemGV(giaovien))
                {
                    MessageBox.Show("Thêm Thành Công");
                    LoadDuLieu();
                }
                else
                {
                    MessageBox.Show("Mã Giáo Viên Đã Tồn Tại");
                }
            }
            else
            {
                MessageBox.Show("Thông Tin Bạn Điền chưa chính xác");
            }
        }
        private void KiemTraThongTinNhap()
        {
            if (txtMaGV.Text == " ")
            {
                dxeMa.SetError(txtMaGV, "Mã Giáo Viên Cấu Trúc GV__ ");
            }
        }
        //kiem tra ma giao vien
        private bool KiemTraMaGV(string maGV)
        {
            int n = maGV.Length;
            if (n == 5)
            {
                return true;
            }
            return false;
        }
        private bool KiemTraSDT(string sdt)
        {
            int n = sdt.Length;
            if (12 > n && n >9 )
                return true;
            return false;
        }
        //private bool KiemTra2()
        //{
        //    bool kq;
        //    if (dxeDienThoai.ClearErrors()==true)
        //    {
                
        //    }
        //}
        private bool KiemTraNhap()
        {
            bool kq;

            if (txtMaGV.Text == "" || txtHoGV.Text == "" || txtTenGV.Text == "" ||dtNgaySinh.Text==""||txtDiaChi.Text==""||txtSoDT.Text=="")
            {
                kq = false;
                ////kq = true;
                ////if (txtTenGV.Text ==" ")
                ////{
                ////   // errorProvider1.SetError(txtTenGV, "Mã giáo viên chưa nhập");

                ////}
                //if (txtMaGV.Text == "")
                //{
                //    dxErrorProvider1.SetError(txtMaGV, "dadasda");
                //}
                //kq = false;
            }
          
            else
            {
               // if (txtMaGV.Text != "")
               // {
                    kq = true;
               // }

            }
            return kq;
        }

        private void dockPanel1_Click(object sender, EventArgs e)
        {

        }

        private void txtMaGV_TextChanged(object sender, EventArgs e)
        {
            if (txtMaGV.Text.Length == 5)
            {
                dxeMa.ClearErrors();
               // dxValidationProvider1.RemoveControlError(dxeMa);
            }
            else
            {
                dxeMa.SetError(txtMaGV, "Nhập mã sai");
            }
        }

        private void txtHoGV_TextChanged(object sender, EventArgs e)
        {
            if (txtHoGV.Text != "")
            {
                dxeHo.ClearErrors();
            }
            else
            {
                dxeHo.SetError(txtHoGV, "Nhập họ Giáo Viên");
            }
        }

        private void txtTenGV_TextChanged(object sender, EventArgs e)
        {
            if (txtTenGV.Text != "")
            {
                dxeTenGV.ClearErrors();
            }
            else
            {
                dxeTenGV.SetError(txtTenGV, "Chưa Nhập Tên Giáo Viên");
            }
        }
        
        //Kiem tra ngay sinh
          private bool KiemTraNgaySinh(DateTimePicker dtp)
        {
            if (dtp.Value.Year < (DateTime.Today.Year - 18))
                return true;
            else
                return false;
        }
        //Kiem tra ngay sinh
          private bool KiemTraNgaySinhs(DateEdit d)
          {
              if (DateTime.Parse(d.EditValue.ToString()).Year < (DateTime.Today.Year - 18))
              {
                  return true;
              }
              else
                  return false;
          }
          private void dtNgaySinh_TextChanged(object sender, EventArgs e)
          {
              if (DateTime.Parse(dtNgaySinh.EditValue.ToString()).Year < (DateTime.Today.Year - 18))
              {
                  dxeNgaySinh.ClearErrors();
              }
              else
              {
                  dxeNgaySinh.SetError(dtNgaySinh, "Ngày sinh phải trên 18 tuổi");    
              }
          }

          private void txtDiaChi_TextChanged(object sender, EventArgs e)
          {
              if (txtDiaChi.Text != "")
              {
                  dxeDiaChi.ClearErrors();
              }
              else
              {
                  dxeDiaChi.SetError(txtDiaChi, "Chưa nhập địa chỉ");
              }
          }

          private void txtSoDT_TextChanged(object sender, EventArgs e)
          {
              if (txtSoDT.Text != "")
              {
                  dxeDienThoai.ClearErrors();
              }
              else
              {
                  dxeDienThoai.SetError(txtSoDT, "Chưa Nhập Số Điện thoại");
              }
          }

          private void groupControl1_Paint(object sender, PaintEventArgs e)
          {

          }

          private void txtSoDT_TextChanged_1(object sender, EventArgs e)
          {
              if (txtSoDT.Text != ""&&txtSoDT.Text.Length>9&&txtSoDT.Text.Length<12)
              {
                  dxeDienThoai.ClearErrors();
              }
              else
              {
                  dxeDienThoai.SetError(txtSoDT, "Nhập Số Điện thoại từ 9 đến 12 số");
              }
          }

          private void txtMaGV_EditValueChanged(object sender, EventArgs e)
          {

          }


        
    }
}
