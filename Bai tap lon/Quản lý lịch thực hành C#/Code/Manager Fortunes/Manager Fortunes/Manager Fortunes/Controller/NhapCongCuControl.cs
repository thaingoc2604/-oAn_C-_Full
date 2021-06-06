using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


using Manager_Fortunes.Datalayer;
using Manager_Fortunes.BusinessObject;

namespace Manager_Fortunes.Controller
{
   public  class NhapCongCuControl
    {
       NhapCongCuData data = new NhapCongCuData();
       
       public void HienthiCombobox(ComboBox cbx)
       {
           DataTable tb = data.DSCongCu();
           cbx.DataSource = tb;
           cbx.DisplayMember = "MACONGCU";
           cbx.ValueMember = "MACONGCU";
       }
       public void HienthiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmb)
       {

           DataTable tbl = data.DSCongCu();
           cmb.DataSource = tbl;
           cmb.DisplayMember = "TENCONGCU";
           cmb.ValueMember = "MACONGCU";
           cmb.DataPropertyName = "MACONGCU";
           cmb.HeaderText = "Loại Khách Hàng";
       }
       public void HienThiDataGridView(DataGridView dg, BindingNavigator bn)
       {
           BindingSource bs = new BindingSource();
           bs.DataSource = data.DSCongCu();
           dg.DataSource = bs;
           bn.BindingSource = bs;
       }
       public void SinhMaCongCu(TextBox txtMaCongCu)
       {
           int max = Convert.ToInt32(this.LayMaCongCuMax()) + 1;
           string MaCongCu = "";
           if (max < 10)
               MaCongCu = "CC" + "000" + max;
           else
               if (max < 100)
                   MaCongCu  = "CC" + "00" + max;
               else if (max < 1000)
                   MaCongCu  = "CC" + "000" + max;
               else MaCongCu  = "CC" + max.ToString();
           txtMaCongCu.Text = MaCongCu ;
       }
       public string LayMaCongCuMax()
       {
           int Max = -1;
           int Current = 0;
           string MaCongCuMax = "0";
           DataTable table = data.MaCongCu("MACONGCU");
           foreach (DataRow row in table.Rows)
           {
               try
               {
                   Current = Convert.ToInt32(row["MACONGCU"].ToString().Trim().Substring(2));
                   if (Max < Current)
                   {
                       Max = Current;
                       MaCongCuMax = row["MACONGCU"].ToString().Trim().Substring(2);
                   }
               }
               catch
               {
                   MaCongCuMax = "0000";
               }
           }
           return MaCongCuMax;
       }
       public void NhapCongCu(TextBox SoHD,TextBox MaCC,ComboBox TenCC,ComboBox Manhom,ComboBox MaDVT,TextBox Sl,TextBox NG,ComboBox MKH,ComboBox DKH,ComboBox ConLai,
           TextBox NuocSX,TextBox HanSD,ComboBox LydoT,ComboBox NgayT,ComboBox NgayKH,ComboBox BPSD,ComboBox PhongBan,ComboBox Mucdichsd,RichTextBox ghichu)

       {
           CongCuInfo nhapCongCuInfo = new CongCuInfo();
           nhapCongCuInfo.Sohoadon = SoHD.Text;
           nhapCongCuInfo.Macongcu = MaCC.Text;
           nhapCongCuInfo.Tencongcu = TenCC.Text;
           nhapCongCuInfo.Manhom = Manhom.Text;
           nhapCongCuInfo.Madonvitinh = MaDVT.Text;
           //nhapCongCuInfo.Soluong = Sl.Text;
           nhapCongCuInfo.Soluong = Convert.ToInt32(Sl.Text);
           nhapCongCuInfo.Nguyengia = Convert.ToInt32 (NG.Text);
           nhapCongCuInfo.Muckhauhao =Convert.ToInt32 (MKH.Text);
           nhapCongCuInfo.Dakhauhao =Convert.ToInt32( DKH.Text);
           nhapCongCuInfo.Conlai = Convert.ToInt32(ConLai.Text);
           nhapCongCuInfo.NuocSX = NuocSX.Text;
           nhapCongCuInfo.Hansudung =Convert .ToInt32( HanSD.Text);
           nhapCongCuInfo.Lydotang = LydoT.Text;
           nhapCongCuInfo.Ngaytang =Convert .ToDateTime( NgayT.Text);
           nhapCongCuInfo.Ngaykhauhao = Convert.ToDateTime( NgayKH.Text);
           nhapCongCuInfo.Bophansudung = BPSD.Text;
           nhapCongCuInfo.Maphongban = PhongBan.Text;
           nhapCongCuInfo.Mucdichsudung = Mucdichsd.Text;
           nhapCongCuInfo.Ghichu = ghichu.Text;

           data.NhapCongCu(nhapCongCuInfo);
       }
    }
}
