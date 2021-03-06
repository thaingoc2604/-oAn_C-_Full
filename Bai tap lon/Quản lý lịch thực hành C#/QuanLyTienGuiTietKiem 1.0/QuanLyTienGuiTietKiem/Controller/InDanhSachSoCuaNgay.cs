using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevComponents.Editors;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors.DateTimeAdv;
using QuanLyTienGuiTietKiem.DataLayer;
using QuanLyTienGuiTietKiem.Bussiness;
using QuanLyTienGuiTietKiem.General;

namespace QuanLyTienGuiTietKiem.Controller
{
    public class InDanhSachSoCuaNgayCtrl
    {
        public static IList<InPhieuLuuTienGuiInfo> LayPhieuLuuTietKiemTheoMaSo(String NgayGiaoDich)
        {
            InDanhSachSoTheoNgayData data = new InDanhSachSoTheoNgayData();
            DataTable tbl = data.LaySoTheoNgayGD(NgayGiaoDich);

            IList<InPhieuLuuTienGuiInfo> DSS = new List<InPhieuLuuTienGuiInfo>();

            foreach (DataRow row in tbl.Rows)
            {

                InPhieuLuuTienGuiInfo DS = new InPhieuLuuTienGuiInfo();

                KhachHangInfo m_KH = new KhachHangInfo();
                m_KH.HoTen = Convert.ToString(row["HoTen"]);

                ChiTietPhatSinhGDInfo m_PSGD = new ChiTietPhatSinhGDInfo();
                m_PSGD.SoTien = Convert.ToInt64(row["SoTien"]);

                LaiSuatTietKiemInfo m_LS = new LaiSuatTietKiemInfo();
                m_LS.MucLaiSuat = Convert.ToInt32(row["MucLaiSuat"]);

                SoDuTietKiemInfo m_SoDuInfo = new SoDuTietKiemInfo();
                m_SoDuInfo.SoDu = Convert.ToInt64(row["SoDu"]);

                SoTietKiemInfo m_STK = new SoTietKiemInfo();
                m_STK.MaSoTietKiem = Convert.ToString(row["MaSoTietKiem"]);

                LoaiTietKiemInfo m_LTK = new LoaiTietKiemInfo();
                m_LTK.TenLoaiTietKiem = Convert.ToString(row["TenLoaiTietKiem"]);

                DMLoaiTienInfo m_DMLT = new DMLoaiTienInfo();
                m_DMLT.LoaiTien = Convert.ToString(row["LoaiTien"]);

                DS.ChiTietPhatSinhGD = m_PSGD;
                DS.KhachHang = m_KH;
                DS.LaiSuatTietKiem = m_LS;
                DS.LoaiTietKiem = m_LTK;
                DS.SoDuTietKiem = m_SoDuInfo;
                DS.SoTietKiem = m_STK;
                DS.DMLoaiTien = m_DMLT;

                DSS.Add(DS);                
            }
            return DSS;
        }
    }
}
