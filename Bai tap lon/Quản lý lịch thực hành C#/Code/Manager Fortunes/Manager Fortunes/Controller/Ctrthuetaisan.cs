using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Quanlytaisan.Data;
using System.Data.SqlClient;
using System.Data;
using Manager_Fortunes.BusinessObject;
using Manager_Fortunes.Datalayer;
namespace Manager_Fortunes.Controller
{
    public class Ctrthuetaisan :DevComponents.DotNetBar.Office2007Form
    {
        DataThuetaisan data = new DataThuetaisan();

        ThueTaiSan ts = new ThueTaiSan();
        DataNhom datanhom = new DataNhom();

        DaTaDVT datadvt = new DaTaDVT();
        DataPhongBan dataphongban = new DataPhongBan();
        DaTaDiaDiem datadiadiem = new DaTaDiaDiem();
        DataThuetaisan datathue = new DataThuetaisan();
        public Ctrthuetaisan()
        {

        }

        public void HienThi(DataGridView dg, BindingNavigator bn)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = data.LayDSThueTaiSan();
            dg.DataSource = bs;
            bn.BindingSource = bs;

        }
        public void LuuTaiSanThue(ThueTaiSan ts)
        {
            data.LuuTaiSanThue(ts);
        }

        public void CapNhat(ThueTaiSan ts)
        {

        }
        public void XoaTaiSanThue(ThueTaiSan taisan)
        {
           data.XoaTaiSanThue(taisan);
        }
        public void HienThi_MaNhom(ComboBox cbmanhom)
        {
            cbmanhom.DataSource = datanhom.LayDSNhomTaiSan();
            cbmanhom.DisplayMember="TENNHOM";
            cbmanhom.ValueMember = "MANHOM";
        }
        public void HienThi_LyDo(ComboBox cbmalydo)
        {
            cbmalydo.DataSource = datathue.LayDSLyDo();
            cbmalydo.DisplayMember = "TENLYDO";
            cbmalydo.ValueMember = "MALYDO";
        }
        public void HienThi_MaDVT(ComboBox cbmaDVT)
        {
            cbmaDVT.DataSource = datadvt.LayDSDonViTinh();
            cbmaDVT.DisplayMember = "TENDONVITINH";
            cbmaDVT.ValueMember = "MADONVITINH";
        }

        public void HienThi_MaDiaDiem(ComboBox cbmaDiaDiem)
        {
            cbmaDiaDiem.DataSource = datadiadiem.LayDSDiaDiem();
            cbmaDiaDiem.DisplayMember = "TENDIADIEM";
            cbmaDiaDiem.ValueMember = "MADIADIEM";
        }
        public void HienThi_MaPhongBan(ComboBox cbmaPhongBan)
        {
            cbmaPhongBan.DataSource = dataphongban.LayDSPhongBan();
            cbmaPhongBan.DisplayMember = "TENPHONG";
            cbmaPhongBan.ValueMember = "MAPHONGBAN";
        }

        public void TimKiemTaiSan(TextBox tentaisan,DevComponents.DotNetBar.Controls.CheckBoxX chonnhom,string manhom,DevComponents.Editors.DateTimeAdv.DateTimeInput tungay,DevComponents.Editors.DateTimeAdv.DateTimeInput denngay,DevComponents.Editors.DateTimeAdv.DateTimeInput hansudungtu,DevComponents.Editors.DateTimeAdv.DateTimeInput hansudungden,ComboBox diadiem,ComboBox phongban,DataGridView dg)
        {
             DataTable tb = data.TimKiemTaiSan(tentaisan.Text,chonnhom,manhom, tungay.Value, denngay.Value, hansudungtu.Value, hansudungden.Value, diadiem.SelectedValue.ToString(), phongban.SelectedValue.ToString());

             dg.DataSource = tb;
        }
    }
}
