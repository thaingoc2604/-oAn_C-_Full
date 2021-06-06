using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using DevComponents.DotNetBar;
using System.Windows.Forms;
using System.Data;
using TT_GDTX_ANGIANG.BusinessObject;
using TT_GDTX_ANGIANG.DataLayer;
using System.Drawing;

namespace TT_GDTX_ANGIANG.Controller
{
    public class NghiViecCtrl
    {
        #region data_NghiViec
        private NghiViecData m_dataNghiViec;
        public NghiViecData data_NghiViec
        {
            get { return m_dataNghiViec; }
            set { m_dataNghiViec = value; }
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
        
        #region Add()
        public bool Add(NghiViecInfo info)
        {
            if (data_NghiViec == null)
                data_NghiViec = new NghiViecData();
            Table = data_NghiViec.lay_dsNghiViec();

            DataRow row = Table.NewRow();
            row["MANGHIVIEC"] = info.MaNghiViec;
            row["MANHANVIEN"] = info.MaNhanVien;
            row["SOQD"] = info.SoQuyetDinh;
            row["NGAYQD"] = info.NgayQuyetDinh;
            row["NGUOIKY"] = info.NguoiKy;
            row["CHUCVU"] = info.ChucVu.MaChucVu;
            row["NGAYTV"] = info.NgayThoiViec;
            row["LYDOTV"] = info.LyDoTV;            
            

            Table.Rows.Add(row);
            if (this.data_NghiViec.Update())
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
        public void Update(NghiViecInfo info, int index)
        {
            if (data_NghiViec == null)
                data_NghiViec = new NghiViecData();
            Table = data_NghiViec.lay_dsNghiViec();
            
            this.Table.Rows[index]["MANHANVIEN"] = info.MaNhanVien;
            this.Table.Rows[index]["SOQD"] = info.SoQuyetDinh;
            this.Table.Rows[index]["NGAYQD"] = info.NgayQuyetDinh;
            this.Table.Rows[index]["NGUOIKY"] = info.NguoiKy;
            this.Table.Rows[index]["CHUCVU"] = info.ChucVu.MaChucVu;
            this.Table.Rows[index]["NGAYTV"] = info.NgayThoiViec;
            this.Table.Rows[index]["LYDOTV"] = info.LyDoTV;
                      

            this.data_NghiViec.Update();
        }
        #endregion

        #region Delete()
        public bool Delete(int index)
        {
            this.Table.Rows[index].Delete();

            return this.data_NghiViec.Update();
        }
        #endregion

        #region Create()
        public void Create(TextBox txtMaTV)
        {
            if (data_NghiViec == null)
                data_NghiViec = new NghiViecData();
            Table = data_NghiViec.lay_dsNghiViec();
            bool b = true;
            int i = 0;
            int t = 1;
            if (Table.Rows.Count == 0)
            {
                txtMaTV.Text = "TV1";
                return;
            }
            while (b)
            {
                string s1 = string.Concat("TV", t.ToString());
                if (Table.Rows[i][0].ToString() == s1)
                {
                    t++;
                    i = 0;
                    continue;
                }
                if (i == (Table.Rows.Count - 1))
                {
                    txtMaTV.Text = s1;
                    b = false;
                }
                i++;
            }
        }
        #endregion


        #region Tim_MaNghiViec        
        
        public void Tim_MaNghiViec(string txtMaNV, TextBox txtSoQD, DateTimePicker dateNgayQD, TextBox txtNguoiKy,ComboBox txtChucVu, DateTimePicker dateNgayTV, TextBox cboLYDO)
        {
            if (data_NghiViec == null)
                data_NghiViec = new NghiViecData();
            DataTable dt = data_NghiViec.Tim_MaNghiViec(txtMaNV);

            DataRow row = dt.Rows[0];
            txtSoQD.Text = row["SOQD"].ToString();
            dateNgayQD.Value = (DateTime)row["NGAYQD"];
            txtNguoiKy.Text = row["NGUOIKY"].ToString();
            txtChucVu.Text = row["CHUCVU"].ToString();
            dateNgayTV.Value = (DateTime)row["NGAYTV"];
            cboLYDO.Text = row["LYDOTV"].ToString();


        }
        #endregion

        #region KiemTra()
        public int KiemTra(String manv)
        {
            if (data_NghiViec == null)
                data_NghiViec = new NghiViecData();
            DataTable temp = data_NghiViec.lay_MaNhanVien(manv);
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

        #region Xoa_NhanVienNghiViec

        public void Xoa_NhanVienNghiViec(String MaNV)
        {
            if (data_NghiViec == null)
                data_NghiViec = new NghiViecData();
            data_NghiViec.Xoa_NhanVienNghiViec(MaNV);
        }
        #endregion
    }
}
