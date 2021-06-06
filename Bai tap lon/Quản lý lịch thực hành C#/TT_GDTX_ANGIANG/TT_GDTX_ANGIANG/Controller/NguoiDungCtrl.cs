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
    public class NguoiDungCtrl
    {
        #region Property
        private int m_PhanQuyen;
        public int PhanQuyen
        {
            get { return m_PhanQuyen; }
            set { m_PhanQuyen = value; }
        }
        #endregion

        #region data_NguoiDung
        private NguoiDungData m_dataNguoiDung;
        public NguoiDungData data_NguoiDung
        {
            get { return m_dataNguoiDung; }
            set { m_dataNguoiDung = value; }
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

        #region HienThi_dsNguoiDung()
        public void HienThi_dsNguoiDung(ListView listView)
        {
            if (data_NguoiDung == null)
            {
                data_NguoiDung = new NguoiDungData();
            }
            Table = data_NguoiDung.lay_dsNguoiDung();
            IEnumerator ie = Table.Rows.GetEnumerator();
            listView.Items.Clear();
            while (ie.MoveNext())
            {
                DataRow row = (DataRow)ie.Current;
                NguoiDungInfo info = new NguoiDungInfo();
                info.MaNguoiDung = row["MAND"].ToString();

                PhongBanCtrl ctrlPH = new PhongBanCtrl();
                info.PhongBan = ctrlPH.GetPhongBan(row["PHONGBAN"].ToString());

               
              

                info.TenDangNhap = row["TENDN"].ToString();
                info.MatKhau = row["MATKHAU"].ToString();
                info.HoTen = row["HOTEN"].ToString();
                info.PhanQuyen = row["PHANQUYEN"].ToString();
                info.GhiChu = row["GHICHU"].ToString();

                ListViewItem item = new ListViewItem();
                item.Text = info.MaNguoiDung;
                item.SubItems.Add(info.PhongBan.TenPhong);              
                item.SubItems.Add(info.TenDangNhap);
                item.SubItems.Add(info.MatKhau);
                item.SubItems.Add(info.HoTen);
                item.SubItems.Add(info.PhanQuyen);               
                item.Tag = info;

                listView.Items.Add(item);
            }
        }
        #endregion

        #region HienThiInfo()
        public void HienThiInfo(TextBox txtMaND, ComboBox cboPhongBan,  TextBox txtTenDN, TextBox txtMatKhau, TextBox txtHoTen, TextBox txtGhiChu, NguoiDungInfo info)
        {
            txtMaND.Text = info.MaNguoiDung;
            cboPhongBan.Text = info.PhongBan.TenPhong;
            
            txtTenDN.Text = info.TenDangNhap;
            txtMatKhau.Text = info.MatKhau;
            txtHoTen.Text = info.HoTen;
            txtGhiChu.Text = info.GhiChu;
        }
        #endregion

        #region Add()
        public bool Add(NguoiDungInfo info)
        {
            if (data_NguoiDung == null)
            {
                data_NguoiDung = new NguoiDungData();
            }
            Table = data_NguoiDung.lay_dsNguoiDung();
            DataRow row = Table.NewRow();
            row["MAND"] = info.MaNguoiDung;
            row["PHONGBAN"] = info.PhongBan.MaPhong;           

            row["TENDN"] = info.TenDangNhap;
            row["MATKHAU"] = info.MatKhau;
            row["HOTEN"] = info.HoTen;
            row["PHANQUYEN"] = info.PhanQuyen;
            row["GHICHU"] = info.GhiChu;

            Table.Rows.Add(row);
            if (this.data_NguoiDung.Update())
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

        #region Update()
        public void Update(NguoiDungInfo info, int index)
        {
            if (data_NguoiDung == null)
            {
                data_NguoiDung = new NguoiDungData();
            }
            Table = data_NguoiDung.lay_dsNguoiDung();
            this.Table.Rows[index]["MAND"] = info.MaNguoiDung;
            this.Table.Rows[index]["PHONGBAN"] = info.PhongBan.MaPhong;            

            this.Table.Rows[index]["TENDN"] = info.TenDangNhap;
            this.Table.Rows[index]["MATKHAU"] = info.MatKhau;
            this.Table.Rows[index]["HOTEN"] = info.HoTen;
            this.Table.Rows[index]["PHANQUYEN"] = info.PhanQuyen;
            this.Table.Rows[index]["GHICHU"] = info.GhiChu;

            this.data_NguoiDung.Update();
        }
        #endregion

        #region Delete()
        public bool Delete(int index)
        {
            this.Table.Rows[index].Delete();

            return this.data_NguoiDung.Update();
        }
        #endregion

        #region Create()
        public void Create(TextBox txtMaND)
        {
            if (data_NguoiDung == null)
                data_NguoiDung = new NguoiDungData();
            Table = data_NguoiDung.lay_dsNguoiDung();
            bool b = true;
            int i = 0;
            int t = 1;
            if (Table.Rows.Count == 0)
            {
                txtMaND.Text = "ID1";
                return;
            }
            while (b)
            {
                string s1 = string.Concat("ID", t.ToString());
                if (Table.Rows[i][0].ToString() == s1)
                {
                    t++;
                    i = 0;
                    continue;
                }
                if (i == (Table.Rows.Count - 1))
                {
                    txtMaND.Text = s1;
                    b = false;
                }
                i++;
            }
        }
        #endregion

        #region DangNhap(username,password)
        public int DangNhap(String username, String password)
        {
            if (data_NguoiDung == null)
                data_NguoiDung = new NguoiDungData();
            Table = data_NguoiDung.lay_TenDangNhap(username);
            if (Table.Rows.Count == 0)
            {
                return 0; //Nguoi dung khong ton tai
            }
            NguoiDungInfo info = new NguoiDungInfo();
            String strMatKhau = Table.Rows[0]["MATKHAU"].ToString();
            String strPhanQuyen = Table.Rows[0]["PHANQUYEN"].ToString();
            String strHoTen = Table.Rows[0]["HOTEN"].ToString();
            String ma_NguoiDung = Table.Rows[0]["MAND"].ToString();

            if (strMatKhau == password)
            {
                info.HoTen = strHoTen;
                info.MaNguoiDung = ma_NguoiDung;
                Utility.NGUOIDUNG = info;

                if (strPhanQuyen == "Toan quyen")
                {
                    m_PhanQuyen = 1;

                    //////////////////////
                   
                    //////////////////////
                }
                if (strPhanQuyen == "Chi xem")
                {
                    m_PhanQuyen = 2;
                }
                if (strPhanQuyen == "Nhan Vien Phong Tai Vu")
                {
                    m_PhanQuyen = 3;
                }
                if (strPhanQuyen == "Nhan Vien Phong To Chuc")
                {
                    m_PhanQuyen = 4;
                }
                return 1; //Dang Nhap Thanh Cong
            }
            else
            {
                return 2; //Sai Mat Khau
            }
        }
        #endregion

        #region DoiMatKhau
        public int DoiMatKhau(String matkhau_old, String matkhau_new)
        {
            if (data_NguoiDung == null)
                data_NguoiDung = new NguoiDungData();
            Table = data_NguoiDung.lay_MatKhau(matkhau_old);

            if (Table.Rows.Count != 0)
            {
                String pass = Table.Rows[0]["MATKHAU"].ToString();
                if (pass == matkhau_old)
                {
                    DataTable nd = data_NguoiDung.DoiMatKhau(matkhau_old, matkhau_new);
                    return 0; //Doi mat khau
                }
                else
                {
                    return 1; //Khong cho doi mat khau
                }
            }
            return 2; //Khong cho doi mat khau
        }
        #endregion

        #region KiemTra_NguoiDung(String tenDN)
        public int KiemTra_NguoiDung(String tenDN)
        {
            if (data_NguoiDung == null)
                data_NguoiDung = new NguoiDungData();
            Table = data_NguoiDung.lay_TenDangNhap(tenDN);
            if (Table.Rows.Count != 0)
            {
                return 1; //Ton tai
            }
            else
            {
                return 2; //Khong ton tai
            }
        }
        #endregion
    }
}
