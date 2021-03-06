using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using DevComponents.DotNetBar.Controls;
using System.Data;
using DevComponents.DotNetBar;
using System.Windows.Forms;
using QuanLyTienGuiTietKiem.DataLayer;

namespace QuanLyTienGuiTietKiem.Controller
{
    public class MoSoTietKiemCtrl
    {
        MoSoTietKiemData m_MoSoTietKiemData = new MoSoTietKiemData();
        public void LayLaiSuatTheoMaLoai(ComboBoxEx MaLoaiTK, TextBoxX MaLoai, TextBoxX LaiSuat)
        {
            MoSoTietKiemData data = new MoSoTietKiemData();
            DataTable tbl = data.LayLaiSuatTheoLoaiTK(MaLoaiTK.SelectedValue.ToString());

            DataRow row = tbl.Rows[0];

            MaLoai.Text = Convert.ToString(row["MaLoaiTietKiem"]);
            LaiSuat.Text = Convert.ToString(row["MucLaiSuat"]);
        }

        public void LayTheoMaNV(ComboBoxEx MaNV,TextBoxX MNV, TextBoxX MaQuayGiaoDich, TextBoxX MaPhongGiaoDich)
        {
            MoSoTietKiemData dt = new MoSoTietKiemData();
            DataTable tbl = dt.LayTheoMaNV(MaNV.SelectedValue.ToString());

            DataRow row = tbl.Rows[0];

            MNV.Text = Convert.ToString(row["MaNV"]);
            MaQuayGiaoDich.Text = Convert.ToString(row["MaQuayGiaoDich"]);
            MaPhongGiaoDich.Text = Convert.ToString(row["MaPhongGiaoDich"]);
        }

        //Kiem Tra Ngay Giao Dich
        public Boolean KTNgayGD(DateTime NgayGD)
        {
            SoTietKiemData data = new SoTietKiemData();
            DataTable tbl = data.LayTheoNgayDH(NgayGD);
            foreach (DataRow row in tbl.Rows)
            {
                if (row["NgayGiaoDich"].ToString()== row["NgayHieuLuc"].ToString())
                {
                    return false;
                }
            }
            return true;
        }

        public void KiemTraNgay(String MaLoatTK, DateTime NgayHieuLuc, DateTime NgayDenHan)
        {
            DateTime d1 = Convert.ToDateTime(NgayHieuLuc.ToString());
            DateTime d2 = Convert.ToDateTime(NgayDenHan.ToString());
            int SoNgay = Convert.ToInt32(d2.ToOADate() - d1.ToOADate());
            double KyHan = 0;
            int Ngay = SoNgay / 30;

            MoSoTietKiemData data = new MoSoTietKiemData();
            DataTable tbl = data.LayLaiSuatTheoLoaiTK(MaLoatTK);

            DataRow row = tbl.Rows[0];
            KyHan = Convert.ToDouble(row["KyHan"]);

            if (row["MaLoaiTietKiem"].ToString() != "TK423100")
            {
                if (Ngay != KyHan)
                {
                    MessageBoxEx.Show(Convert.ToString(row["TenLoaiTietKiem"]) + "\n Phải chọn ngày đúng kỳ hạn!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBoxEx.Show("Nhap dung!", "COMPLETED", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBoxEx.Show("Nhap dung!", "COMPLETED", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

    }
}
