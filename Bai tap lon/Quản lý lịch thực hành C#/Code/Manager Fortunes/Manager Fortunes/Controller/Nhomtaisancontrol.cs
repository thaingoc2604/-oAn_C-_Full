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
   public class Nhomtaisancontrol
    {
       Nhomtaisandata data = new Nhomtaisandata();
        public void HienthiAutoComboBox(ComboBox cmb)
        {

            DataTable tbl = data.DanhSachNhomTaiSan();
            cmb.DataSource = tbl;
            cmb.DisplayMember = "MANHOMTAISAN";
            cmb.ValueMember = "MANHOMTAISAN";
        }
        public void HienthiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmb)
        {

            DataTable tbl = data.DanhSachNhomTaiSan();
            cmb.DataSource = tbl;
            cmb.DisplayMember = "TENNHOMTAISAN";
            cmb.ValueMember = "MANHOMTAISAN";
            cmb.DataPropertyName = "MANHOMTAISAN";
            cmb.HeaderText = "Địa điểm";

        }
        public void HienthiAutoComboBoxTenNhomTaiSan(ComboBox cmb)
        {
            DataTable tbl = data.DanhSachNhomTaiSan();
            cmb.DataSource = tbl;
            cmb.DisplayMember = "TENNHOMTAISAN";
            cmb.ValueMember = "MASOTAISAN";
        }

        //public void SinhMaTaiSan(TextBox txtmataisan)
        //{
        //    int max = Convert.ToInt32(this.LayMaTaiSanMax()) + 1;
        //    string maTaiSan = "";
        //    if (max < 10)
        //        maTaiSan = "TS" + "000" + max;
        //    else
        //        if (max < 100)
        //            maTaiSan = "TS" + "00" + max;
        //        else if (max < 1000)
        //            maTaiSan = "TS" + "000" + max;
        //        else maTaiSan = "TS" + max.ToString();
        //    txtmataisan.Text = maTaiSan;
        //}
        //public string LayMaTaiSanMax()
        //{
        //    int Max = -1;
        //    int Current = 0;
        //    string MaTSMax = "0";
        //    DataTable table = data.MaTaiSan("MATAISAN");
        //    foreach (DataRow row in table.Rows)
        //    {
        //        try
        //        {
        //            Current = Convert.ToInt32(row["MATAISAN"].ToString().Trim().Substring(2));
        //            if (Max < Current)
        //            {
        //                Max = Current;
        //                MaTSMax = row["MATAISAN"].ToString().Trim().Substring(2);
        //            }
        //        }
        //        catch
        //        {
        //            MaTSMax = "0000";
        //        }
        //    }
        //    return MaTSMax;
        //}
        public void HienThiDataGridView(DataGridView dg, BindingNavigator bn)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = data.DanhSachNhomTaiSan();
            dg.DataSource = bs;
            bn.BindingSource = bs;
        }

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
