using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Windows.Forms;
using System.Data;
using TT_GDTX_ANGIANG.BusinessObject;
using TT_GDTX_ANGIANG.DataLayer;

namespace TT_GDTX_ANGIANG.Controller
{
    public class HopDongLaoDong_ThoiViec_Ctrl
    {
        #region data_HopDongLaoDong
        private HopDongLaoDong_ThoiViec_Data m_data_HopDongLaoDong;
        public HopDongLaoDong_ThoiViec_Data data_HopDongLaoDong
        {
            get { return m_data_HopDongLaoDong; }
            set { m_data_HopDongLaoDong = value; }
        }
        #endregion

        #region Table
        private DataTable m_Table;
        public DataTable Table
        {
            get { return m_Table; }
            set { m_Table = value; }
        }

        #endregion

        #region HienThi_dsHopDongLaoDong_ThoiViec()
        public void HienThi_dsHopDongLaoDong_ThoiViec(ListView listView, string manv)
        {
            if (data_HopDongLaoDong == null)
            {
                data_HopDongLaoDong = new HopDongLaoDong_ThoiViec_Data();
            }
            Table = data_HopDongLaoDong.lay_dsHopDongLaoDong_ThoiViec(manv);
            IEnumerator ie = Table.Rows.GetEnumerator();
            listView.Items.Clear();

            while (ie.MoveNext())
            {
                DataRow row = (DataRow)ie.Current;
                HopDongLaoDong_ThoiViec_Info info = new HopDongLaoDong_ThoiViec_Info();



                info.MaHopDongLaoDong = row["MAHD"].ToString();
                info.MaNhanVien = row["MANHANVIEN"].ToString();
                info.LoaiHopDong = row["LOAIHD"].ToString();
                info.TuNgay = (DateTime)row["TUNGAY"];
                info.DenNgay = (DateTime)row["DENNGAY"];
                info.DiaDiemLamViec = row["DIADIEMLAMVIEC"].ToString();
                info.ChucDanhChuyenMon = row["CHUCDANHCHUYENMON"].ToString();
                info.NhiemVu = row["NHIEMVU"].ToString();
                info.ThoiGianLamViec = row["THOIGIANLAMVIEC"].ToString();
                info.TrangBiPhuongTien = row["TRANGBIPHUONGTIEN"].ToString();                
                info.NguoiKy = row["NGUOIKY"].ToString();
                info.ChucVu = row["CHUCVU"].ToString();
                info.NgayKy = (DateTime)row["NGAYKY"];
                info.ChonBHXH = int.Parse(row["BHXH"].ToString());
                info.ChonBHYT = int.Parse(row["BHYT"].ToString());

                info.SoQuyetDinh = row["SOQDINH"].ToString();
                info.NgayQuyetDinh = (DateTime)row["NGAYQD"];
                info.NguoiKyThoiViec = row["NGUOIKYTV"].ToString();
                info.NgayThoiViec = (DateTime)row["NGAYTV"];
                info.LyDoTV = row["LYDOTV"].ToString();

                ListViewItem item = new ListViewItem();

                item.Text = info.MaHopDongLaoDong;
                item.SubItems.Add(info.LoaiHopDong);
                item.SubItems.Add(info.TuNgay.ToShortDateString());
                item.SubItems.Add(info.DenNgay.ToShortDateString());
                item.SubItems.Add(info.NguoiKy);
                item.SubItems.Add(info.ChucVu);
                item.Tag = info;

                listView.Items.Add(item);
            }
        }
        #endregion

        #region HienThiInfo()
        public void HienThiInfo(DevComponents.DotNetBar.Controls.CheckBoxX chonBHXH, DevComponents.DotNetBar.Controls.CheckBoxX chonBHYT, TextBox txtMaHD, ComboBox cboLoaiHD, DateTimePicker dtTuNgay, DateTimePicker dtDenNgay, TextBox txtDiaDiemLamViec, TextBox txtChucDanh, TextBox txtNhiemVu, TextBox txtTGLamViec, TextBox txtTrangBi,  TextBox txtNguoiKy, ComboBox cboChucVu, DateTimePicker dtNgayKy, TextBox txtsoQD, DateTimePicker dtngayQD, TextBox txtnguoiKyThoiViec, DateTimePicker dtngayKyThoiViec, TextBox txtlydoThoiViec, HopDongLaoDong_ThoiViec_Info info)
        {

            chonBHXH.Checked = info.ChonBHXH.Equals(1);
            chonBHYT.Checked = info.ChonBHYT.Equals(1);
            txtMaHD.Text = info.MaHopDongLaoDong;
            cboLoaiHD.Text = info.LoaiHopDong;
            dtTuNgay.Text = info.TuNgay.ToShortDateString();
            dtDenNgay.Text = info.DenNgay.ToShortDateString();
            txtDiaDiemLamViec.Text = info.DiaDiemLamViec;
            txtChucDanh.Text = info.ChucDanhChuyenMon;
            txtNhiemVu.Text = info.NhiemVu;
            txtTGLamViec.Text = info.ThoiGianLamViec;
            txtTrangBi.Text = info.TrangBiPhuongTien;          
            txtNguoiKy.Text = info.NguoiKy;
            cboChucVu.Text = info.ChucVu;
            dtNgayKy.Text = info.NgayKy.ToShortDateString();

            /////////////
            txtsoQD.Text = info.SoQuyetDinh;
            dtngayQD.Text = info.NgayQuyetDinh.ToShortDateString();
            txtnguoiKyThoiViec.Text = info.NguoiKyThoiViec;
            dtngayKyThoiViec.Text = info.NgayThoiViec.ToShortDateString();
            txtlydoThoiViec.Text = info.LyDoTV;


        }
        #endregion

        #region Add()
        public bool Add(HopDongLaoDong_ThoiViec_Info info)
        {
            DataRow row = Table.NewRow();

            row["MAHD"] = info.MaHopDongLaoDong;
            row["MANHANVIEN"] = info.MaNhanVien;
            row["LOAIHD"] = info.LoaiHopDong;
            row["TUNGAY"] = info.TuNgay;
            row["DENNGAY"] = info.DenNgay;
            row["DIADIEMLAMVIEC"] = info.DiaDiemLamViec;
            row["CHUCDANHCHUYENMON"] = info.ChucDanhChuyenMon;
            row["NHIEMVU"] = info.NhiemVu;
            row["THOIGIANLAMVIEC"] = info.ThoiGianLamViec;
            row["TRANGBIPHUONGTIEN"] = info.TrangBiPhuongTien;            
            row["NGUOIKY"] = info.NguoiKy;
            row["CHUCVU"] = info.ChucVu;
            row["NGAYKY"] = info.NgayKy;
            row["BHXH"] = info.ChonBHXH;
            row["BHYT"] = info.ChonBHYT;
            ///////////////

            row["SOQDINH"] = info.SoQuyetDinh;
            row["NGAYQD"] = info.NgayQuyetDinh;
            row["NGUOIKYTV"] = info.NguoiKyThoiViec;
            row["NGAYTV"] = info.NgayThoiViec;
            row["LYDOTV"] = info.LyDoTV;
            //////////////////

            Table.Rows.Add(row);
            if (this.data_HopDongLaoDong.Update())
            {
                return true;
            }
            else
            {
                Table.Rows.Remove(row);
                return false;
            }
        }
        #endregion



        #region CapNhatHopDongLaoDong_ThoiViec()
        public void CapNhatHopDongLaoDong_ThoiViec(HopDongLaoDong_ThoiViec_Info info, int index)
        {
            //this.Table.Rows[index]["MAQTBD"] = info.MaHopDongLaoDong;
            this.Table.Rows[index]["MANHANVIEN"] = info.MaNhanVien;
            this.Table.Rows[index]["LOAIHD"] = info.LoaiHopDong;
            this.Table.Rows[index]["TUNGAY"] = info.TuNgay;
            this.Table.Rows[index]["DENNGAY"] = info.DenNgay;
            this.Table.Rows[index]["DIADIEMLAMVIEC"] = info.DiaDiemLamViec;
            this.Table.Rows[index]["CHUCDANHCHUYENMON"] = info.ChucDanhChuyenMon;
            this.Table.Rows[index]["NHIEMVU"] = info.NhiemVu;
            this.Table.Rows[index]["THOIGIANLAMVIEC"] = info.ThoiGianLamViec;
            this.Table.Rows[index]["TRANGBIPHUONGTIEN"] = info.TrangBiPhuongTien;           
            this.Table.Rows[index]["NGUOIKY"] = info.NguoiKy;
            this.Table.Rows[index]["CHUCVU"] = info.ChucVu;
            this.Table.Rows[index]["NGAYKY"] = info.NgayKy;
            this.Table.Rows[index]["BHXH"] = info.ChonBHXH;
            this.Table.Rows[index]["BHYT"] = info.ChonBHYT;

            ///////////////////////////
            this.Table.Rows[index]["SOQDINH"] = info.SoQuyetDinh;
            this.Table.Rows[index]["NGAYQD"] = info.NgayQuyetDinh;
            this.Table.Rows[index]["NGUOIKYTV"] = info.NguoiKyThoiViec;
            this.Table.Rows[index]["NGAYTV"] = info.NgayThoiViec;
            this.Table.Rows[index]["LYDOTV"] = info.LyDoTV;
            /////////////////////////////

            this.data_HopDongLaoDong.CapNhatHopDongLaoDong_ThoiViec(info);
        }
        #endregion

        #region Delete()
        public bool Delete(int index)
        {
            this.Table.Rows[index].Delete();

            return this.data_HopDongLaoDong.Update();
        }
        #endregion

        #region Create()
        public void Create(TextBox txtMaQT)
        {
            Table = data_HopDongLaoDong.lay_dsHopDongLaoDong_ThoiViec();
            bool b = true;
            //int i = 0;
            // int t = 1;
            int max = 0;
            int[] a = new int[1000];
            if (Table.Rows.Count == 0)
            {
                txtMaQT.Text = "HDLD1";
                return;
            }
            while (b)
            {
                for (int i = 0; i < Table.Rows.Count; i++)
                {
                    if (Table.Rows[i][0].ToString().Length == 5)
                    {
                        if ((a[i] = Convert.ToInt16(Table.Rows[i][0].ToString().Substring(4, 1))) > max)
                        {
                            max = a[i];
                        }
                    }
                    if (Table.Rows[i][0].ToString().Length == 6)
                    {
                        if ((a[i] = Convert.ToInt16(Table.Rows[i][0].ToString().Substring(4, 2))) > max)
                        {
                            max = a[i];
                        }
                    }
                    if (Table.Rows[i][0].ToString().Length == 7)
                    {
                        if ((a[i] = Convert.ToInt16(Table.Rows[i][0].ToString().Substring(4, 3))) > max)
                        {
                            max = a[i];
                        }
                    }
                    if (Table.Rows[i][0].ToString().Length == 8)
                    {
                        if ((a[i] = Convert.ToInt16(Table.Rows[i][0].ToString().Substring(4, 4))) > max)
                        {
                            max = a[i];
                        }
                    }

                }
                int endmax = max + 1;
                string s1 = string.Concat("HDLD", endmax.ToString());
                txtMaQT.Text = s1;
                b = false;

            }
        }
        #endregion

        #region Xoa_HopDongLaoDong_ThoiViec

        public void Xoa_HopDongLaoDong_ThoiViec(String MaHDLD)
        {
            if (data_HopDongLaoDong == null)
                data_HopDongLaoDong = new HopDongLaoDong_ThoiViec_Data();
            data_HopDongLaoDong.Xoa_HopDongLaoDong_ThoiViec(MaHDLD);
        }
        #endregion

        #region Xoa_HopDongLaoDong_ThoiViec_NhanVien

        public void Xoa_HopDongLaoDong_ThoiViec_NhanVien(String MaNV)
        {
            if (data_HopDongLaoDong == null)
                data_HopDongLaoDong = new HopDongLaoDong_ThoiViec_Data();
            data_HopDongLaoDong.Xoa_HopDongLaoDong_ThoiViec_NhanVien(MaNV);
        }
        #endregion


        #region BENCHAMDUTHOPDONGLAODONG        
      

      

        #region KiemTra()
        public int KiemTra(String manv)
        {
            if (data_HopDongLaoDong == null)
                data_HopDongLaoDong = new HopDongLaoDong_ThoiViec_Data();
            DataTable temp = data_HopDongLaoDong.lay_MaNhanVien(manv);
            if (temp.Rows.Count != 0)
            {
                return 1; //Ton tai
            }
            else
            {
                return 2; //Khong ton tai
            }
        }
        #endregion

        #endregion
    }
}
