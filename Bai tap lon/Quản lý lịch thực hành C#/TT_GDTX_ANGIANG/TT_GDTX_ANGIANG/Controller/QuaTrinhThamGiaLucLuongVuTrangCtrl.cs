using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using TT_GDTX_ANGIANG.BusinessObject;
using TT_GDTX_ANGIANG.DataLayer;
using System.Windows.Forms;
using System.Data;

namespace TT_GDTX_ANGIANG.Controller
{
    public class QuaTrinhThamGiaLucLuongVuTrangCtrl
    {
        #region data_QTTGLucLuongVuTrang
        private QuaTrinhThamGiaLucLuongVuTrangData m_data_QTTGLucLuongVuTrang;
        public QuaTrinhThamGiaLucLuongVuTrangData data_QTTGLucLuongVuTrang
        {
            get { return m_data_QTTGLucLuongVuTrang; }
            set { m_data_QTTGLucLuongVuTrang = value; }
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

        #region HienThi_dsQTTGLucLuongVuTrang()
        public void HienThi_dsQTTGLucLuongVuTrang(ListView listView, string manv)
        {
            if (data_QTTGLucLuongVuTrang == null)
            {
                data_QTTGLucLuongVuTrang = new QuaTrinhThamGiaLucLuongVuTrangData();
            }
            Table = data_QTTGLucLuongVuTrang.lay_dsQTTGLucLuongVuTrang(manv);
            IEnumerator ie = Table.Rows.GetEnumerator();
            listView.Items.Clear();

            while (ie.MoveNext())
            {
                DataRow row = (DataRow)ie.Current;
                QuaTrinhThamGiaLucLuongVuTrangInfo info = new QuaTrinhThamGiaLucLuongVuTrangInfo();


                info.MaQuaTrinhThamGiaLucLuongVuTrang = row["MAQTTGLLVT"].ToString();
                info.MaNhanVien = row["MANHANVIEN"].ToString();
                info.NgayNN = (DateTime)row["NGAYNN"];
                info.NgayXN = (DateTime)row["NGAYXN"];
                info.ChucVu = row["CHUCVUVUTRANG"].ToString();
                info.QuanHamCaoNhat = row["QUANHAM"].ToString();
               

                ListViewItem item = new ListViewItem();

                item.Text = info.MaQuaTrinhThamGiaLucLuongVuTrang;                
                item.SubItems.Add(info.NgayNN.ToShortDateString());
                item.SubItems.Add(info.NgayXN.ToShortDateString());
                item.SubItems.Add(info.ChucVu);
                item.SubItems.Add(info.QuanHamCaoNhat);                
                item.Tag = info;

                listView.Items.Add(item);
            }
        }
        #endregion

        #region HienThiInfo()
        public void HienThiInfo(TextBox txtMaLLVT,  DateTimePicker dtNgayNN, DateTimePicker dtNgayXN, TextBox txtChucVu, TextBox txtQuanHam, QuaTrinhThamGiaLucLuongVuTrangInfo info)
        {

            txtMaLLVT.Text = info.MaQuaTrinhThamGiaLucLuongVuTrang;
            dtNgayNN.Text = info.NgayNN.ToShortDateString();
            dtNgayXN.Text = info.NgayXN.ToShortDateString();          
            txtChucVu.Text = info.ChucVu;
            txtQuanHam.Text = info.QuanHamCaoNhat;            

        }
        #endregion

        #region Add()
        public bool Add(QuaTrinhThamGiaLucLuongVuTrangInfo info)
        {
            DataRow row = Table.NewRow();
            row["MAQTTGLLVT"] = info.MaQuaTrinhThamGiaLucLuongVuTrang;
            row["MANHANVIEN"] = info.MaNhanVien;
            row["NGAYNN"] = info.NgayNN;
            row["NGAYXN"] = info.NgayXN;
            row["CHUCVUVUTRANG"] = info.ChucVu;
            row["QUANHAM"] = info.QuanHamCaoNhat;          


            Table.Rows.Add(row);
            if (this.data_QTTGLucLuongVuTrang.Update())
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

        #region CapNhatQuaTrinhThamGiaHoatDongVuTrang()
        public void CapNhatQuaTrinhThamGiaHoatDongVuTrang(QuaTrinhThamGiaLucLuongVuTrangInfo info, int index)
        {

            this.Table.Rows[index]["NGAYNN"] = info.NgayNN;
            this.Table.Rows[index]["NGAYXN"] = info.NgayXN;
            this.Table.Rows[index]["CHUCVUVUTRANG"] = info.ChucVu;
            this.Table.Rows[index]["QUANHAM"] = info.QuanHamCaoNhat;
           

            this.data_QTTGLucLuongVuTrang.CapNhatQuaTrinhThamGiaHoatDongVuTrang(info);
        }
        #endregion

        #region Delete()
        public bool Delete(int index)
        {

            this.Table.Rows[index].Delete();

            return this.data_QTTGLucLuongVuTrang.Update();
        }
        #endregion

        #region Create()
        public void Create(TextBox txtMaQT)
        {
            Table = data_QTTGLucLuongVuTrang.lay_dsQTTGLucLuongVuTrang();
            bool b = true;
            int i = 0;
            int t = 1;
            if (Table.Rows.Count == 0)
            {
                txtMaQT.Text = "LLVT1";
                return;
            }
            while (b)
            {
                string s1 = string.Concat("LLVT", t.ToString());
                if (Table.Rows[i][0].ToString() == s1)
                {
                    t++;
                    i = 0;
                    continue;
                }
                if (i == (Table.Rows.Count - 1))
                {
                    txtMaQT.Text = s1;
                    b = false;
                }
                i++;
            }
        }
        #endregion

        #region Xoa_QuaTrinhTGLLVuTrang

        public void Xoa_QuaTrinhTGLLVuTrang(String maQTDT)
        {
            if (data_QTTGLucLuongVuTrang == null)
                data_QTTGLucLuongVuTrang = new QuaTrinhThamGiaLucLuongVuTrangData();
            data_QTTGLucLuongVuTrang.Xoa_QuaTrinhThamGiaLLVT(maQTDT);
        }
        #endregion

        #region Xoa_QuaTrinhTGLLVuTrangNV

        public void Xoa_QuaTrinhTGLLVuTrangNV(String maNV)
        {
            if (data_QTTGLucLuongVuTrang == null)
                data_QTTGLucLuongVuTrang = new QuaTrinhThamGiaLucLuongVuTrangData();
            data_QTTGLucLuongVuTrang.Xoa_QuaTrinhThamGiaLLVT_NHANVIEN(maNV);
        }
        #endregion
    }
}
