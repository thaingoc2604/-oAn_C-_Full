using System;
using System.Collections.Generic;
using System.Text;
using QUANLIKH.Data;
using DevComponents.DotNetBar.Controls;
using System.Windows.Forms;

namespace QUANLIKH.Controller
{
   public  class QuyenSoControl
    {
       QuyenSoData data = new QuyenSoData();
       public void HienThi(DataGridViewX dgv, BindingNavigator bn, TextBox txtMaQuyen, String MaDaiLy, DateTimePicker dtNgayNhan, DateTimePicker dtNgayQuyetToan, TextBox txtTuSo, TextBox txtDenSo, TextBox txtMaSoThanhToan, TextBox txtGhiChi)
       {
           
           BindingSource bs = new BindingSource();
           bs.DataSource = data.SelectAll(MaDaiLy);

           dgv.DataSource = bs;
           bn.BindingSource = bs;

           txtMaQuyen.DataBindings.Clear();
           txtMaQuyen.DataBindings.Add("Text", bs, "MAQUYEN");

           dtNgayNhan.DataBindings.Clear();
           dtNgayNhan.DataBindings.Add("Text", bs, "NGAYNHAN");

           dtNgayQuyetToan.DataBindings.Clear();
           dtNgayQuyetToan.DataBindings.Add("Text", bs, "NGAYQUYETTOAN");

           txtTuSo.DataBindings.Clear();
           txtTuSo.DataBindings.Add("Text", bs, "TUSO");

           txtDenSo.DataBindings.Clear();
           txtDenSo.DataBindings.Add("Text", bs, "DENSO");

           txtMaSoThanhToan.DataBindings.Clear();
           txtMaSoThanhToan.DataBindings.Add("Text", bs, "MASOTHANHTOAN");

           txtGhiChi.DataBindings.Clear();
           txtGhiChi.DataBindings.Add("Text", bs, "GHICHU");

                      
       }
       public void CapNhat()
       {
           data.Update();
       }
       public void HienThiLenComboBox(ComboBox cmb)
      {
          //moc du lieu
          BindingSource bs = new BindingSource();
          bs.DataSource = data.SelectAll();


          cmb.DataSource = bs;
          cmb.DisplayMember = "MAQUYEN";
          cmb.ValueMember = "MAQUYEN";

      }
       public DataGridViewComboBoxColumn LoadComboBoxColumn()
       {
           DataGridViewComboBoxColumn col = new DataGridViewComboBoxColumn();
           col.DataSource = data.SelectAll();

           col.DisplayMember = "MAQUYEN";
           col.ValueMember = "MAQUYEN";

           col.HeaderText = "Mã Quyển";
           col.Width = 100;
           col.DataPropertyName = "MAQUYEN";

           return col;
       }

       internal void HienThiLenComboBox(ComboBoxEx cmbQuyenSo, string madaily)
       {
           //throw new Exception("The method or operation is not implemented.");
           BindingSource bs = new BindingSource();
           bs.DataSource = data.SelectAll(madaily);


           cmbQuyenSo.DataSource = bs;
           cmbQuyenSo.DisplayMember = "MAQUYEN";
           cmbQuyenSo.ValueMember = "MAQUYEN";

       }
   }
}
