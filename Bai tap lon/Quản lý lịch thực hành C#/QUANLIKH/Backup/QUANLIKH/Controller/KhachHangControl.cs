using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using QUANLIKH.Data;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;

namespace QUANLIKH.Controller
{
   public  class KhachHangControl
    {
       KhachHangData data = new KhachHangData();

       public void HienThi(DataGridViewX dgv, BindingNavigator bn, TextBox txtMaKhachHang, TextBox txtHoTen, TextBox txtBienSo, TextBox txtSoKhung, TextBox txtSoMay, TextBox txtDiaChi)
       {
           BindingSource bs = new BindingSource();
           bs.DataSource = data.SelectAll();

           //dâtgridview va bindingNaviagtor
           dgv.DataSource = bs;
           bn.BindingSource = bs;

           txtMaKhachHang.DataBindings.Clear();
           txtMaKhachHang.DataBindings.Add("Text", bs, "MAKH");

           txtHoTen.DataBindings.Clear();
           txtHoTen.DataBindings.Add("Text", bs, "HOVATEN");

           txtBienSo.DataBindings.Clear();
           txtBienSo.DataBindings.Add("Text", bs, "BIENSO");

           txtSoKhung.DataBindings.Clear();
           txtSoKhung.DataBindings.Add("Text", bs, "SOKHUNG");

           txtSoMay.DataBindings.Clear();
           txtSoMay.DataBindings.Add("Text", bs, "SOMAY");

           txtDiaChi.DataBindings.Clear();
           txtDiaChi.DataBindings.Add("Text", bs, "DIACHI");


       }

       public DataGridViewComboBoxColumn LoadComboBoxColumn()
       {
           DataGridViewComboBoxColumn col = new DataGridViewComboBoxColumn();
            col.DataSource = data.SelectAll();

           col.DisplayMember = "HOVATEN";
           col.ValueMember = "MAKH";

           col.HeaderText = "Tên Khách Hàng";
           col.Width = 120;
           col.DataPropertyName = "MAKH";

           return col;
       }
       internal void HienThiLenComboBox(ComboBoxEx cmb)
       {
           BindingSource bs = new BindingSource();
           //bs.DataSource = data.SelectAll();
           bs.DataSource = data.SelectAll();
           cmb.DataSource = bs;
           cmb.DisplayMember = "HOVATEN";
           cmb.ValueMember = "MAKH";
       }

       public void CapNhat()
       {
           data.Update();
       }
     
       internal void TimKhachHang(DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewTimKiemKhachHang, BindingNavigator bindingNavigatorTimKiemKhachHang, DevComponents.DotNetBar.Controls.TextBoxX textBoxHoTenKhachHang, ComboBox cmbChonDiaChi, DevComponents.DotNetBar.Controls.TextBoxX textBoxDiaChi, ComboBox cmbChonBienSo, DevComponents.DotNetBar.Controls.TextBoxX textBoxBienSo, ComboBox cmbChonSoKhung, DevComponents.DotNetBar.Controls.TextBoxX textBoxSoKhung, ComboBox cmbSoMay, DevComponents.DotNetBar.Controls.TextBoxX textBoxSoMay)

       {
           BindingSource bs = new BindingSource();
           bs.DataSource = data.Find(textBoxHoTenKhachHang.Text, cmbChonDiaChi.SelectedItem.ToString(), textBoxDiaChi.Text, cmbChonBienSo.SelectedItem.ToString(), textBoxBienSo.Text, cmbChonSoKhung.SelectedItem.ToString(), textBoxSoKhung.Text, cmbSoMay.SelectedItem.ToString(), textBoxSoMay.Text);

           dataGridViewTimKiemKhachHang.DataSource = bs;
           if (dataGridViewTimKiemKhachHang.RowCount ==0)
               MessageBox.Show("Không tìm được khách hàng theo yêu cầu tìm kiếm của bạn", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
           bindingNavigatorTimKiemKhachHang.BindingSource = bs;
           } 

      
         
    }
}

