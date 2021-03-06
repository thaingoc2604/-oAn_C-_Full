using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using Manager_Fortunes.Datalayer;
using Manager_Fortunes.BusinessObject;

namespace Manager_Fortunes.Controller
{
   public  class Taisancontrol
    {
       Taisandata data = new Taisandata();
       //TaisanObject Obj = new TaisanObject();

        public void HienthiAutoComboBox(ComboBox cmb)
        {

            DataTable tbl = data.DanhSachTaiSan();
            cmb.DataSource = tbl;
            cmb.DisplayMember = "MATAISAN";
            cmb.ValueMember = "MATAISAN";
        }
        public void HienthiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmb)
        {

            DataTable tbl = data.DanhSachTaiSan();
            cmb.DataSource = tbl;
            cmb.DisplayMember = "TENTAISAN";
            cmb.ValueMember = "MATAISAN";
            cmb.DataPropertyName = "MATAISAN";
            cmb.HeaderText = "Loại Khách Hàng";

        }
       public void HienthiAutoComboBoxTenTaiSan(ComboBox cmb)
       {

           DataTable tbl = data.DanhSachTaiSan();
           cmb.DataSource = tbl;
           cmb.DisplayMember = "TENTAISAN";
           cmb.ValueMember = "TENTAISAN";
       }
        public void SinhMaTaiSan(TextBox txtmataisan)
        {
            int max = Convert.ToInt32(this.LayMaTaiSanMax()) + 1;
            string maTaiSan = "";
            if (max < 10)
                maTaiSan = "TS" + "000" + max;
            else
                if (max < 100)
                    maTaiSan = "TS" + "00" + max;
                else if (max < 1000)
                    maTaiSan = "TS" + "000" + max;
                else maTaiSan = "TS" + max.ToString();
            txtmataisan.Text = maTaiSan;
        }
        public string LayMaTaiSanMax()
        {
            int Max = -1;
            int Current = 0;
            string MaTSMax = "0";
            DataTable table = data.MaTaiSan("MATAISAN");
            foreach (DataRow row in table.Rows)
            {
                try
                {
                    Current = Convert.ToInt32(row["MATAISAN"].ToString().Trim().Substring(2));
                    if (Max < Current)
                    {
                        Max = Current;
                        MaTSMax = row["MATAISAN"].ToString().Trim().Substring(2);
                    }
                }
                catch
                {
                    MaTSMax = "0000";
                }
            }
            return MaTSMax;
        }
       //public void HienThiTaiSanDuocChon(DataGridViewX dataGridView1, TextBoxX txtsohoadon,TextBoxX txtmataisan ,
       //    ComboBoxEx cmbtentaisan ,ComboBoxEx cmbmanhom,ComboBoxEx cmbdonvitinh,TextBoxX txtnuocsx,
       //    DateTime datatimenamsx,TextBoxX txthansudung,ComboBoxEx cmblydotang, DateTime datetimengaytang,
       //    NumericUpDown numdieuchinhtang, NumericUpDown numgiatrisaukhitang, TextBoxX txtsoluong, TextBoxX txtnguyengia,
       //    NumericUpDown nummuckhauhao, NumericUpDown numdakhauhao, NumericUpDown numconlai, ComboBoxEx cmbbophansudung,
       //    ComboBoxEx cmbphongban,ComboBoxEx cmbmucdichsudung,RichTextBox rtxtghichu)
       //{           
       //     DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

       //     txtsohoadon.Text = row.Cells[0].Value.ToString();
       //     txtmataisan.Text = row.Cells[1].Value.ToString();
       //     cmbtentaisan.Text = row.Cells[2].Value.ToString();
       //     cmbmanhom.Text = row.Cells[3].Value.ToString();
       //     cmbdonvitinh.Text=row.Cells[4].Value.ToString();
       //     txtnuocsx.Text = row.Cells[5].Value.ToString();
       //     datatimenamsx.AddYears = row.Cells[6].Value.ToString();
       //     txthansudung.Text = row.Cells[7].Value.ToString();
       //     cmblydotang.Text = row.Cells[8].Value.ToString();
       //     datetimengaytang.AddDays=row.Cells[9].Value.ToString();
       //     numdieuchinhtang.Text = row.Cells[10].Value.ToString();
       //     numgiatrisaukhitang.Text = row.Cells[11].Value.ToString();
       //     txtsoluong.Text = row.Cells[12].Value.ToString();
       //     txtnguyengia.Text = row.Cells[13].Value.ToString();
       //     nummuckhauhao.Text = row.Cells[14].Value.ToString();
       //     numdakhauhao.Text = row.Cells[15].Value.ToString();
       //     numconlai.Text = row.Cells[16].Value.ToString();
       //     cmbbophansudung.Text = row.Cells[17].Value.ToString();
       //     cmbphongban.Text = row.Cells[18].Value.ToString();
       //     cmbmucdichsudung.Text = row.Cells[19].Value.ToString();
       //     rtxtghichu.Text = row.Cells[20].Value.ToString();

       //}
        public void HienThiDataGridView(DataGridView dg, BindingNavigator bn)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = data.DanhSachTaiSan();
            dg.DataSource = bs;
            bn.BindingSource = bs;
        }
       //public void SuaThongTinTaiSan(TaisanObject taisanObj)
       //{
       //    data.SuaThongTinTaiSan(taisanObj);
       //}
        public void TimTheoMaLoai(String ma)
        {
            data.TimTheoMa(ma);
        }
        public void TimTheoTenLoai(String ten)
        {
            data.TimTheoTen(ten);
        }
        public bool Save()
        {
            return data.Save();
        }
        public DataRow NewRow()
        {
            return data.NewRow();
        }
        public void Add(DataRow row)
        {
            data.Add(row);
        }
    }
}
