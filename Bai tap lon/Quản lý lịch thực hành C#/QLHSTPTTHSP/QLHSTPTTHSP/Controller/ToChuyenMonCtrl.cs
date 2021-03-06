using System;
using System.Collections.Generic;
using System.Text;
using QLHSTPTTHSP.DataLayer;
using DevComponents.DotNetBar.Controls;
using System.Windows.Forms;
using System.Data;

namespace QLHSTPTTHSP.Controller
{
    public class ToChuyenMonCtrl
    {
        ToChuyenMonData toChuyenMonData = new ToChuyenMonData();

        public void HienThiDanhSachToChuyenMon(DataGridViewX dataGridView, BindingNavigator bindingNavigator)
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = toChuyenMonData.LayBangToChuyenMon();
            bindingNavigator.BindingSource = bindingSource;
            dataGridView.DataSource = bindingSource;
        }

        /// <summary>
        /// Lấy danh sách giáo viên thuộc tổ chuyên môn từ CSDL và hiển thị lên dataGridView
        /// </summary>
        public void HienThiDanhSachGiaoVienThuocTo(DataGridViewX dataGridView, DataGridViewX dataGridViewThuoc)
        {
            if (dataGridView.CurrentRow != null)
            {
                string maToChuyenMon = dataGridView.CurrentRow.Cells[0].Value.ToString();
                if (maToChuyenMon != "")
                {
                    dataGridViewThuoc.DataSource = new ToChuyenMonData().BangChiTietToChuyenMon(maToChuyenMon);
                }
            }
        }
        /// <summary>
        /// Hiển thị danh sách giáo viên không thuộc tổ
        /// </summary>
        /// <param name="dataGridView_DSGiaoVien"></param>
        public void HienThiDanhSachGiaoVienKhongThuocTo(DataGridViewX dataGridView, DataGridViewX dataGridView_DSGiaoVienKhongThuocTo)
        {
            if (dataGridView.CurrentRow != null)
            {
                string maToChuyenMon = dataGridView.CurrentRow.Cells[0].Value.ToString();
                if (maToChuyenMon != "")
                {
                    dataGridView_DSGiaoVienKhongThuocTo.DataSource = new ToChuyenMonData().BangGiaoVienKhongThuocTo(maToChuyenMon);
                }
            }
        }
        /// <summary>
        /// Sinh mã tổ chuyên môn
        /// </summary>
        /// <returns></returns>
        public string SinhMa()
        {
            int max = Convert.ToInt32(this.LayMaMaximum()) + 1;
            string ma = "";
            if (max < 10)
                ma = "00" + max.ToString();
            else
                if (max < 100)
                    ma = "0" + max.ToString();                
                else ma = max.ToString();
            return "TCM" + ma;
        }

        private string LayMaMaximum()
        {
            int Max = -1;
            int Current = 0;
            string MaMax = "0";
            DataTable table = new ToChuyenMonData().LayBangToChuyenMon("ma_to_chuyen_mon");
            foreach (DataRow row in table.Rows)
            {
                try
                {
                    Current = Convert.ToInt32(row["ma_to_chuyen_mon"].ToString().Trim().Substring(3));
                    if (Max < Current)
                    {
                        Max = Current;
                        MaMax = row["ma_to_chuyen_mon"].ToString().Trim().Substring(3);
                    }
                }
                catch
                {
                    MaMax = "000";
                }
            }
            return MaMax;
        }
        /// <summary>
        /// Thêm dòng mới vào bảng
        /// </summary>
        /// <returns></returns>
        public DataRow ThemDongMoi()
        {
            return toChuyenMonData.ThemDongMoi();
        }
        /// <summary>
        /// Thêm tổ chuyên môn
        /// </summary>
        /// <param name="row"></param>
        public void ThemToChuyenMon(DataRow row)
        {
            toChuyenMonData.ThemToChuyenMon(row);
        }
        /// <summary>
        /// Cập nhật cơ sở dữ liệu và trả về kết quả có bao nhiêu dòng bị tác động
        /// </summary>
        /// <returns></returns>
        public int CapNhat()
        {
            return toChuyenMonData.CapNhat();
        }
        /// <summary>
        /// Xóa những chi tiết của tổ chuyên môn
        /// </summary>
        /// <param name="maNienHoc"></param>
        public void XoaChiTietToChuyenMon(string maToChuyenMon)
        {
            toChuyenMonData.XoaChiTietToChuyenMon(maToChuyenMon);
        }
        public bool XoaGiaoVienKhoiToChuyenMon(string maToChuyenMon, string maGiaoVien)
        {
            return toChuyenMonData.XoaGiaoVienKhoiToChuyenMon(maToChuyenMon, maGiaoVien);
        }
        public bool ThemGiaoVienVaoToChuyenMon(string maToChuyenMon, string maGiaoVien)
        {
            return toChuyenMonData.ThemGiaoVienVaoToChuyenMon(maToChuyenMon, maGiaoVien);
        }
    }
}
