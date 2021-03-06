using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using QUANLIKH.Data;
using DevComponents.DotNetBar.Controls;
using System.Windows.Forms;

namespace QUANLIKH.Controller
{
   public  class MucBaoHiemControl
    {
       MucBaoHiemData data = new MucBaoHiemData();
       public void HienThiListView(ListView dgv)
       {

          DataTable table= data.SelectAll();
          dgv.Items.Clear();
          foreach (DataRow row in table.Rows)
          {
              ListViewItem item = new ListViewItem(row["PHIBAOHIEM"].ToString());
              dgv.Items.Add(item);
          }
       }
       public void HienThi(DataGridViewX dgv,BindingNavigator bn,TextBox txtMaLoai,TextBox txtPhiBaoHiem,TextBox txtMucTrachNhiem,TextBox txtDienGiai)
   {
      
       BindingSource bs = new BindingSource();
       bs.DataSource = data.SelectAll();

       dgv.DataSource = bs;
       bn.BindingSource = bs;

       txtMaLoai.DataBindings.Clear();
       txtMaLoai.DataBindings.Add("Text", bs, "MALOAI");

       txtPhiBaoHiem.DataBindings.Clear();
       txtPhiBaoHiem.DataBindings.Add("Text", bs, "PHIBAOHIEM");

       txtMucTrachNhiem.DataBindings.Clear();
       txtMucTrachNhiem.DataBindings.Add("Text", bs, "MUCTRACHNHIEM");

       txtDienGiai.DataBindings.Clear();
       txtDienGiai.DataBindings.Add("Text", bs, "DIENGIAI");

       
   }
       public void CapNhat()
       {
           data.Update();
       }
       public DataGridViewComboBoxColumn LoadComboBoxColumnPhiTNDS()
       {
           DataGridViewComboBoxColumn col = new DataGridViewComboBoxColumn();
            col.DataSource = data.SelectAll();

           col.DisplayMember = "PHIBAOHIEM";
           col.ValueMember = "MALOAI";

           col.HeaderText = "Mức TNDS";
           col.Width = 100;
           col.DataPropertyName = "MALOAITNDS";

           return col;
       }
       public DataGridViewComboBoxColumn LoadComboBoxColumnPhiTNNN()
       {
           DataGridViewComboBoxColumn col = new DataGridViewComboBoxColumn();
           col.DataSource = data.SelectAll();

           col.DisplayMember = "PHIBAOHIEM";
           col.ValueMember = "MALOAI";

           col.HeaderText = "Mức TNNN/XE";
           col.Width = 100;
           col.DataPropertyName = "MALOAITNNN";

           return col;
       }
       //public void HienThiDataDridViewComboBoxComlumnTNNN(DataGridViewComboBoxColumn col)
       //{
       //    col.DataSource = data.SelectAll();
       //    col.DisplayMember = "PHIBAOHIEM";
       //    col.ValueMember = "MALOAI";
       //    col.DataPropertyName = "MALOAITNNN";
       //    col.HeaderText = "Mức TNNN/XE";
                   
       //}
       //public void HienThiDataDridViewComboBoxComlumnTNDS(DataGridViewComboBoxColumn col)
       //{
       //    col.DataSource = data.SelectAll();
       //    col.DisplayMember = "PHIBAOHIEM";
       //    col.ValueMember = "MALOAI";
       //    col.DataPropertyName = "MALOAITNDS";
       //    col.HeaderText = "Mức TNDS";
           

       //}

       //public DataGridViewComboBoxColumn LoadComboBoxColumn()
       //{
       //    DataGridViewComboBoxColumn col = new DataGridViewComboBoxColumn();
       //    col.DataSource = data.SelectAll();

       //    col.DisplayMember = "PHIBAOHIEM";
       //    col.ValueMember = "MALOAI";

       //    col.HeaderText = "Mức TNNN/XE";
       //    col.Width = 100;
       //    col.DataPropertyName = "MALOAITNNN";

       //    return col;
       //}

       public DataGridViewComboBoxColumn LoadComboBoxColumn()
       {
           DataGridViewComboBoxColumn col = new DataGridViewComboBoxColumn();
           col.DataSource = data.SelectAll();

           col.DisplayMember = "PHIBAOHIEM";
           col.ValueMember = "MALOAI";

           col.HeaderText = "Mức TNNN/XE";
           col.Width = 100;
           col.DataPropertyName = "MALOAI";

           return col;
       }
       internal void HienThiLenComboBox(ComboBoxEx cmb)
       {
           BindingSource bs = new BindingSource();
           //bs.DataSource = data.SelectAll();
           bs.DataSource = data.SelectAll();
           cmb.DataSource = bs;
           cmb.DisplayMember = "PHIBAOHIEM";
           cmb.ValueMember = "MALOAI";
       }
       //internal void HienThiLenComboBox(ComboBoxEx cmb)
       //{
       //    BindingSource bs = new BindingSource();
       //    //bs.DataSource = data.SelectAll();
       //    bs.DataSource = data.SelectAll();
       //    cmb.DataSource = bs;
       //    cmb.DisplayMember = "PHIBAOHIEM";
       //    cmb.ValueMember = "MALOAITNNN";
       //}
    }
}
