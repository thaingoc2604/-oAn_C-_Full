using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar;
using DevComponents.Editors.DateTimeAdv;
using QuanLyTienGuiTietKiem.DataLayer;
using QuanLyTienGuiTietKiem.General;
using QuanLyTienGuiTietKiem.Bussiness;

namespace QuanLyTienGuiTietKiem.Controller
{
    public class RutTietKiemCtrl
    {
        RutTietKiemData m_RutTietKiemData = new RutTietKiemData();
        SoTietKiemData m_SoTietKiemData = new SoTietKiemData();
        CDate m_Date = new CDate();

        public void LayRutTietKiem(ComboBoxEx MaSoTK, TextBoxX MaKH, TextBoxX TenKH, TextBoxX SoDu, TextBoxX LoaiTienGui, TextBoxX LoaiTietKiem, TextBoxX LaiSuat, TextBoxX NgayHieuLuc, TextBoxX NgayDenHan, TextBoxX SoButToan)
        {
            RutTietKiemData data1 = new RutTietKiemData();
            DataTable tbl = data1.LayDSSo(MaSoTK.SelectedValue.ToString());

            DataRow row = tbl.Rows[0];

            MaKH.Text = Convert.ToString(row["MaKH"]);
            TenKH.Text = Convert.ToString(row["HoTen"]);
            SoDu.Text = Convert.ToString(row["SoDu"]);
            LoaiTienGui.Text = Convert.ToString(row["LoaiTien"]);
            LoaiTietKiem.Text = Convert.ToString(row["TenLoaiTietKiem"]);
            LaiSuat.Text = Convert.ToString(row["MucLaiSuat"]);
            NgayDenHan.Text = Convert.ToString(row["NgayHieuLuc"]);
            NgayHieuLuc.Text = Convert.ToString(row["NgayDenHan"]);
            SoButToan.Text = Convert.ToString(row["SoButToan"]);
        }
       
        #region Tinh ngay
        public int TinhNgay(String MaSo)
        {
            RutTietKiemData dataRut = new RutTietKiemData();
            DataTable data = dataRut.LayDSSo(MaSo);
            DataRow row = data.Rows[0];
            DateTime d1 = Convert.ToDateTime(row["NgayHieuLuc"].ToString());
            DateTime d2 = Convert.ToDateTime(row["NgayDenHan"].ToString());
            int SoNgay = Convert.ToInt32(d2.ToOADate() - d1.ToOADate());
            return SoNgay;

        }
        //Tinh so ngay hien tai voi ngay hieu luc
        public int KhoanCachNgay(String MaSo)
        {
            RutTietKiemData dtRut = new RutTietKiemData();
            DataTable data = dtRut.LayDSSo(MaSo);
            DataRow row = data.Rows[0];
            DateTime d1 = Convert.ToDateTime(row["NgayHieuLuc"].ToString());
            DateTime d2 = DateTime.Today;
            //DateTime d2 = Convert.ToDateTime(row["NgayDenHan"].ToString());
            int SoNgay = Convert.ToInt32(d2.ToOADate() - d1.ToOADate());
            return SoNgay;
        }
        //Lai so ngay le
        public int NgayLe(String MaSo)
        {
            int NgayLe = KhoanCachNgay(MaSo) % 30;
            return NgayLe;
        }

        public int TinhThang(String MaSo)
        {
            int TinhThang = KhoanCachNgay(MaSo) / 30;
            return TinhThang;
        }
        #endregion 

        #region Tinh Lai
        //Tinh lai so co ky han
        public double  RutLaiSoCoKyHan(String MaSo)
        {
            double m_tienLai = 0;
            DataTable data = m_RutTietKiemData.LayDSSo(MaSo);
            DataRow row = data.Rows[0];
            m_tienLai += Convert.ToDouble(row["MucLaiSuat"])* Convert.ToInt64(row["SoDu"]) * Convert.ToInt32(row["KyHan"]);
            return m_tienLai / 100;
        }

        //Tinh lai khong ky han
        public double RutLaiKhongKyHan(String MaSo)
        {
            double m_tienLai = 0;
            double m_LaiSuat = 0;

            DataTable data = m_RutTietKiemData.LayDSSo(MaSo);
            DataRow row = data.Rows[0];
            m_LaiSuat += Convert.ToDouble(row["MucLaiSuat"]) / 100;
            return m_tienLai +=( Convert.ToInt64(row["SoDu"]) * m_LaiSuat)/30* KhoanCachNgay(MaSo);// * TinhNgay(MaSo);
        }
      
        //Tinh rut von khong ky han, Rut truoc han
        public double RutVonTruocHan(String MaSo, String SoTienRut)
        {
            double m_TienLai = 0;
            double m_LaiCuaThang = 0;
            double m_LaiCuaNgay = 0;
            double m_LaiSuat = 0;

            double TienRut =  Convert.ToDouble(SoTienRut);

            DataTable data2 = m_RutTietKiemData.LayDSSo(MaSo);
            DataRow row = data2.Rows[0];
            m_LaiSuat += Convert.ToDouble(row["MucLaiSuat"]) / 100;

            m_LaiCuaThang += Convert.ToInt64(row["SoDu"]) * TinhThang(MaSo) * m_LaiSuat;

            m_LaiCuaNgay += (Convert.ToInt64(row["SoDu"]) * m_LaiSuat) /30  * NgayLe(MaSo);

            return m_TienLai += m_LaiCuaThang + m_LaiCuaNgay;
        }

        //Tat toan
        public double TatToan(String MaSo)
        {
            double m_LaiSuat = 0;
            double m_TienLai = 0;
            double m_TongTien = 0;
            DataTable data = m_RutTietKiemData.LayDSSo(MaSo);
            foreach (DataRow row in data.Rows)
            {   
                if (row["MaLoaiTietKiem"].ToString() != "TK423100")
                {
                    m_TienLai += (Convert.ToDouble(row["MucLaiSuat"]) * Convert.ToInt64(row["SoDu"]) * Convert.ToInt32(row["KyHan"])) / 100;
                    m_TongTien += m_TienLai + Convert.ToInt64(row["SoDu"]);
                }
                else
                {
                    m_LaiSuat += Convert.ToDouble(row["MucLaiSuat"]) / 30;
                    m_TienLai += (Convert.ToInt64(row["SoDu"]) * m_LaiSuat * TinhNgay(MaSo));
                    m_TongTien += m_TienLai + Convert.ToInt64(row["SoDu"]);
                }
            }
            return m_TongTien;
        }
        #endregion

        #region Luu
        public void LuuSoDu(String MaSo, String SoTienRut)
        {
            float SoDuConLai = 0;
            float TienRut = Convert.ToInt64(SoTienRut);

            DataTable data = m_RutTietKiemData.LayDSSo(MaSo);
            DataRow row = data.Rows[0];
            SoDuConLai += Convert.ToInt64(row["SoDu"]) - TienRut;

            m_RutTietKiemData.LuuSoDu(MaSo, SoDuConLai);
            MessageBoxEx.Show("Đã lưu thành công!", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void LuuTatToan(String MaSo, String SoDu, DateTime NgayTatToan)
        {
            bool phongToa = true;
            float SoDuConLai = 0;
            float SoDu1 = Convert.ToInt64(SoDu);

            DataTable data = m_RutTietKiemData.LayDSSo(MaSo);
            DataRow row = data.Rows[0];
            SoDuConLai += Convert.ToInt64(row["SoDu"]) - SoDu1;

            m_RutTietKiemData.LuuTatToan(MaSo, NgayTatToan, phongToa);
            m_RutTietKiemData.LuuSoDu(MaSo, SoDuConLai);
            MessageBoxEx.Show("Đã lưu thành công!", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public void LuuThayDoiSTK_RutLai(String MaSo, DateTime NgayTinhLaiGanNhat, String LaiDaTra)
        {
            m_RutTietKiemData.LuuThayDoiSTK_RutLai(MaSo, NgayTinhLaiGanNhat, LaiDaTra);
            MessageBoxEx.Show("Đã lưu thành công!", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void LuuThayDoiSTK_RutLaiKhongKH(String MaSo, DateTime NgayTinhLaiGanNhat, String LaiDaTra)
        {
            m_RutTietKiemData.LuuThayDoiSTK_RutLai(MaSo, NgayTinhLaiGanNhat, LaiDaTra);
            MessageBoxEx.Show("Đã lưu thành công!", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region kiem tra
        public Boolean KiemTraKhongKH(String MaSo)
        {
            DataTable dataKKH = m_RutTietKiemData.LayDSSo(MaSo);
            DataRow row = dataKKH.Rows[0];

            if (row["MaLoaiTietKiem"].ToString() == "TK423100")
            {
                return true;
                //MessageBoxEx.Show("Luu Thanh Cong");
            }
            else
            {
                return false;
            }
        }

        public void KiemTraSo(String MaSo)
        {
            //RutTietKiemData Dt = new RutTietKiemData();
            DataTable dt = m_RutTietKiemData.LayDSSo(MaSo);
            DataRow row = dt.Rows[0];

            if (Convert.ToBoolean(row["PhongToa"]) == true)
            {
                MessageBoxEx.Show("Sổ đã tất toán!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion
    }
}

