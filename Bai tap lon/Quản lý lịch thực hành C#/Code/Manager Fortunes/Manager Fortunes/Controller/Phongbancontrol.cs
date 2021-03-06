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
   public class Phongbancontrol
    {
       
       Phongbandata data = new Phongbandata();
        public void HienthiAutoComboBox(ComboBox cmb)
        {

            DataTable tbl = data.DanhSachPhongBan();
            cmb.DataSource = tbl;
            cmb.DisplayMember = "MAPHONGBAN";
            cmb.ValueMember = "MAPHONGBAN";
        }
        public void HienthiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmb)
        {

            DataTable tbl = data.DanhSachPhongBan();
            cmb.DataSource = tbl;
            cmb.DisplayMember = "TENPHONGBAN";
            cmb.ValueMember = "MAPHONGBAN";
            cmb.DataPropertyName = "MAPHONGBAN";
            cmb.HeaderText = "Phòng ban";

        }
       public void HienthiAutoComboBoxTenPhongBan(ComboBox cmb)
       {

           DataTable tbl = data.DanhSachPhongBan();
           cmb.DataSource = tbl;
           cmb.DisplayMember = "TENPHONGBAN";
           cmb.ValueMember = "MAPHONGBAN";
       }
       public void HienthiAutoComboBoxTenDiaDiem(ComboBox cmb)
       {

           DataTable tbl = data.DanhSachPhongBan();
           cmb.DataSource = tbl;
           cmb.DisplayMember = "TENDIADIEM";
           cmb.ValueMember = "MADIADIEM";
       }
        public void SinhMaPhongBan(TextBox txtmaphongban)
        {
            int max = Convert.ToInt32(this.LayMaPhongBanMax()) + 1;
            string maPhongBan = "";
            if (max < 10)
                maPhongBan = "P" + "000" + max;
            else
                if (max < 100)
                    maPhongBan = "P" + "00" + max;
                else if (max < 1000)
                    maPhongBan = "P" + "000" + max;
                else maPhongBan = "P" + max.ToString();
            txtmaphongban.Text = maPhongBan;
        }
       

        public string LayMaPhongBanMax()
        {
            int Max = -1;
            int Current = 0;
            string MaPBMax = "0";
            DataTable table = data.MaPhongBan("MAPHONGBAN");
            foreach (DataRow row in table.Rows)
            {
                try
                {
                    Current = Convert.ToInt32(row["MAPHONGBAN"].ToString().Trim().Substring(1));
                    if (Max < Current)
                    {
                        Max = Current;
                        MaPBMax = row["MAPHONGBAN"].ToString().Trim().Substring(1);
                    }
                }
                catch
                {
                    MaPBMax = "0000";
                }
            }
            return MaPBMax;
        }
        public void HienThiDataGridView(DataGridView dg, BindingNavigator bn)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = data.DanhSachPhongBan();
            dg.DataSource = bs;
            bn.BindingSource = bs;
        }
       //public void SuaThongTinPhongBan(PhongbanObject phongbanObj)
       //{
       //    data.DanhSachPhongBan(phongbanObj);
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
