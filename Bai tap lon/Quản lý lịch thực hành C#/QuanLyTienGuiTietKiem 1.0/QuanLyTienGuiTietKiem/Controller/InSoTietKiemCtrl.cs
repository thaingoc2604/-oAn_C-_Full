using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DevComponents.DotNetBar;
using System.Windows.Forms;
using QuanLyTienGuiTietKiem.Bussiness;
using QuanLyTienGuiTietKiem.DataLayer;
using QuanLyTienGuiTietKiem.Report;

namespace QuanLyTienGuiTietKiem.Controller
{
    public class InSoTietKiemCtrl
    {
        #region STK không kỳ han

        public static IList<SoTietKiemInfo> LayDsSoTietKiemTheoMa(String MaSoTK)
        {
            IList<SoTietKiemInfo> ds = new List<SoTietKiemInfo>();

            SoTietKiemData data = new SoTietKiemData();
            DataTable tbl = data.LaySoTheoMa(MaSoTK);

            IList<SoTietKiemInfo> STK = new List<SoTietKiemInfo>();

            foreach (DataRow row in tbl.Rows)
            {
                
                SoTietKiemInfo S = new SoTietKiemInfo();
                if (row["MaLoaiTietKiem"].ToString() != "TK423100")
                {
                    MessageBoxEx.Show("Bạn đang sư dụng chức năng in sổ không kỳ hạn!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
                else
                {
                    KhachHangInfo m_KH = new KhachHangInfo();
                    m_KH.HoTen = Convert.ToString(row["HoTen"]);
                    m_KH.CMND = Convert.ToString(row["CMND"]);
                    m_KH.DiaChi = Convert.ToString(row["DiaChi"]);
                    m_KH.NgayCap = Convert.ToDateTime(row["NgayCap"]);
                    m_KH.NoiCap = Convert.ToString(row["NoiCap"]);

                    ChiTietPhatSinhGDInfo m_PSGD = new ChiTietPhatSinhGDInfo();
                    m_PSGD.SoTien = Convert.ToInt64(row["SoTien"]);

                    LaiSuatTietKiemInfo m_LS = new LaiSuatTietKiemInfo();
                    m_LS.MucLaiSuat = Convert.ToInt32(row["MucLaiSuat"]);

                    SoDuTietKiemInfo m_SoDuInfo = new SoDuTietKiemInfo();
                    m_SoDuInfo.SoDu = Convert.ToInt64(row["SoDu"]);

                    S.MaSoTietKiem = Convert.ToString(row["MaSoTietKiem"]);
                    S.LaiSuatTK = m_LS;
                    S.MaKH = m_KH;
                    S.ChiTietPSGD = m_PSGD;
                    S.SoDuTK = m_SoDuInfo;
                }
                STK.Add(S);
            }
            return STK;
        }

        //public static String LaySoTienTheoMa(String MaSoTK)
        //{
        //    InPhieuThuData data = new InPhieuThuData();
        //    DataTable tbl = data.LaySoTheoMa(MaSoTK);

        //    String soTien = Convert.ToString(tbl.Rows[0]["SoTien"]);

        //    return soTien;
        //}

        #endregion

        #region STK co kỳ hạn

        public static IList<SoTietKiemInfo> LayDsSoTKCoKyHan(String MaSoTK)
        {
            IList<SoTietKiemInfo> ds = new List<SoTietKiemInfo>();

            SoTietKiemData data = new SoTietKiemData();
            DataTable tbl = data.LaySoTheoMa(MaSoTK);

            IList<SoTietKiemInfo> STK = new List<SoTietKiemInfo>();

            foreach (DataRow row in tbl.Rows)
            {

                SoTietKiemInfo S = new SoTietKiemInfo();
                if (row["MaLoaiTietKiem"].ToString() == "TK423100")
                {
                    MessageBoxEx.Show("Bạn đang sư dụng chức năng in sổ không co ky han!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
                else
                {
                    KhachHangInfo m_KH = new KhachHangInfo();
                    m_KH.HoTen = Convert.ToString(row["HoTen"]);
                    m_KH.CMND = Convert.ToString(row["CMND"]);
                    m_KH.DiaChi = Convert.ToString(row["DiaChi"]);
                    m_KH.NgayCap = Convert.ToDateTime(row["NgayCap"]);
                    m_KH.NoiCap = Convert.ToString(row["NoiCap"]);

                    ChiTietPhatSinhGDInfo m_PSGD = new ChiTietPhatSinhGDInfo();
                    m_PSGD.SoTien = Convert.ToInt64(row["SoTien"]);

                    LaiSuatTietKiemInfo m_LS = new LaiSuatTietKiemInfo();
                    m_LS.MucLaiSuat = Convert.ToInt32(row["MucLaiSuat"]);

                    SoDuTietKiemInfo m_SoDuInfo = new SoDuTietKiemInfo();
                    m_SoDuInfo.SoDu = Convert.ToInt64(row["SoDu"]);

                    LoaiTietKiemInfo m_LTK = new LoaiTietKiemInfo();
                    m_LTK.KyHan = Convert.ToInt32(row["KyHan"]);

                    PhongGiaoDichInfo m_PGD = new PhongGiaoDichInfo();
                    m_PGD.MaPhongGD = Convert.ToString(row["MaPhongGiaoDich"]);

                    DMKyLaiTKInfo m_DMKyLaiTK = new DMKyLaiTKInfo();
                    m_DMKyLaiTK.LoaiKyTinhLai = Convert.ToString(row["LoaiKyTinhLai"]);

                    S.MaSoTietKiem = Convert.ToString(row["MaSoTietKiem"]);
                    S.NgayHieuLuc = Convert.ToDateTime(row["NgayHieuLuc"]);
                    S.NgayDenHan = Convert.ToDateTime(row["NgayDenHan"]);


                    S.LaiSuatTK = m_LS;
                    S.MaKH = m_KH;
                    S.ChiTietPSGD = m_PSGD;
                    S.SoDuTK = m_SoDuInfo;
                    S.PhongGiaoDich = m_PGD;
                    S.DMKyTinhLai = m_DMKyLaiTK;
                    S.MaLoaiTietKiem = m_LTK;
                }
                STK.Add(S);
            }
            return STK;
        }
        #endregion

        #region In so khong doi so
        public static IList<SoTietKiemInfo> LayDsSoTKCoKyHan()
        {
            IList<SoTietKiemInfo> ds = new List<SoTietKiemInfo>();

            SoTietKiemData data = new SoTietKiemData();
            DataTable tbl = data.LaySoTheoMa();

            IList<SoTietKiemInfo> STK = new List<SoTietKiemInfo>();

            foreach (DataRow row in tbl.Rows)
            {

                SoTietKiemInfo S = new SoTietKiemInfo();
                if (row["MaLoaiTietKiem"].ToString() == "TK423100")
                {
                    MessageBoxEx.Show("Bạn đang sư dụng chức năng in sổ không co ky han!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
                else
                {
                    KhachHangInfo m_KH = new KhachHangInfo();
                    m_KH.HoTen = Convert.ToString(row["HoTen"]);
                    m_KH.CMND = Convert.ToString(row["CMND"]);
                    m_KH.DiaChi = Convert.ToString(row["DiaChi"]);
                    m_KH.NgayCap = Convert.ToDateTime(row["NgayCap"]);
                    m_KH.NoiCap = Convert.ToString(row["NoiCap"]);

                    ChiTietPhatSinhGDInfo m_PSGD = new ChiTietPhatSinhGDInfo();
                    m_PSGD.SoTien = Convert.ToInt64(row["SoTien"]);

                    LaiSuatTietKiemInfo m_LS = new LaiSuatTietKiemInfo();
                    m_LS.MucLaiSuat = Convert.ToInt32(row["MucLaiSuat"]);

                    SoDuTietKiemInfo m_SoDuInfo = new SoDuTietKiemInfo();
                    m_SoDuInfo.SoDu = Convert.ToInt64(row["SoDu"]);

                    LoaiTietKiemInfo m_LTK = new LoaiTietKiemInfo();
                    m_LTK.KyHan = Convert.ToInt32(row["KyHan"]);

                    PhongGiaoDichInfo m_PGD = new PhongGiaoDichInfo();
                    m_PGD.MaPhongGD = Convert.ToString(row["MaPhongGiaoDich"]);

                    DMKyLaiTKInfo m_DMKyLaiTK = new DMKyLaiTKInfo();
                    m_DMKyLaiTK.LoaiKyTinhLai = Convert.ToString(row["LoaiKyTinhLai"]);

                    S.MaSoTietKiem = Convert.ToString(row["MaSoTietKiem"]);
                    S.NgayHieuLuc = Convert.ToDateTime(row["NgayHieuLuc"]);
                    S.NgayDenHan = Convert.ToDateTime(row["NgayDenHan"]);


                    S.LaiSuatTK = m_LS;
                    S.MaKH = m_KH;
                    S.ChiTietPSGD = m_PSGD;
                    S.SoDuTK = m_SoDuInfo;
                    S.PhongGiaoDich = m_PGD;
                    S.DMKyTinhLai = m_DMKyLaiTK;
                    S.MaLoaiTietKiem = m_LTK;
                }
                STK.Add(S);
            }
            return STK;
        }
        #endregion 
    }
}
