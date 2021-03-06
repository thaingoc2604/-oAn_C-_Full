using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using DevComponents.DotNetBar;
using TT_GDTX_ANGIANG.BusinessObject;
using TT_GDTX_ANGIANG.DataLayer;
using System.Windows.Forms;
using System.Data;

namespace TT_GDTX_ANGIANG.Controller
{
    public class QuaTrinhDaoTaoCtrl
    {
        #region data_QuocTich
        private QuaTrinhDaoTaoData m_dataQuaTrinhDaoTao;
        public QuaTrinhDaoTaoData data_QuaTrinhDaoTao
        {
            get { return m_dataQuaTrinhDaoTao; }
            set { m_dataQuaTrinhDaoTao = value; }
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

        #region HienThi_dsQuaTrinhDaoTao()
        public void HienThi_dsQuaTrinhDaoTao(ListView listView,string manv)
        {
            if (data_QuaTrinhDaoTao == null)
            {
                data_QuaTrinhDaoTao = new QuaTrinhDaoTaoData();
            }
            Table = data_QuaTrinhDaoTao.lay_dsQuaTrinhDaoTao(manv);
            IEnumerator ie = Table.Rows.GetEnumerator();
            listView.Items.Clear();

            while (ie.MoveNext())
            {
                DataRow row = (DataRow)ie.Current;
                QuaTrinhDaoTaoInfo info = new QuaTrinhDaoTaoInfo();

               
                info.MaQuaTrinhDaoTao = row["MAQTDT"].ToString();
                info.MaNhanVien = row["MANHANVIEN"].ToString();
                try
                {
                    info.NamNhapHoc = row["NAMNHAPHOC"].ToString();
                }
                catch
                {
                    MessageBoxEx.Show("Lỗi Năm Nhập Học", "Thông Báo");
                }
                try
                {
                    info.NamTotNghiep = row["TOTNGHIEPNAM"].ToString();
                }
                catch
                {
                    MessageBoxEx.Show("Lỗi Năm Tốt Nghiệp", "Thông Báo");
                }
                info.NoiDaoTao = row["NOIDT"].ToString();
                info.NganhDaoTao = row["NGANHDT"].ToString();
                info.HinhThucDaoTao= row["HINHTHUCDT"].ToString();
                info.BangDuocCap = row["BANGDUOCCAP"].ToString();

                ListViewItem item = new ListViewItem();                
                item.Text = info.MaQuaTrinhDaoTao;
                item.SubItems.Add(info.NamNhapHoc);
                item.SubItems.Add(info.NamTotNghiep);
                item.SubItems.Add(info.NoiDaoTao);
                item.SubItems.Add(info.NganhDaoTao);
                item.SubItems.Add(info.HinhThucDaoTao);
                item.SubItems.Add(info.BangDuocCap);
                item.Tag = info;

                listView.Items.Add(item);
            }
        }
        #endregion

        #region HienThiInfo()
        public void HienThiInfo(TextBox txtMaQTDT, TextBox txtNamNhapHoc, TextBox txtNamTotNghiep, TextBox txtNoiDaoTao, TextBox txtNganhDaoTao, TextBox txtHinhThucDaoTao, TextBox txtBangDuocCap, QuaTrinhDaoTaoInfo info)
        {
           
            txtMaQTDT.Text = info.MaQuaTrinhDaoTao;
            txtNamNhapHoc.Text = info.NamNhapHoc;
            txtNamTotNghiep.Text = info.NamTotNghiep;
            txtNoiDaoTao.Text = info.NoiDaoTao;
            txtNganhDaoTao.Text = info.NganhDaoTao;
            txtHinhThucDaoTao.Text = info.HinhThucDaoTao;
            txtBangDuocCap.Text = info.BangDuocCap;

        }
        #endregion

        #region Add()
        public bool Add(QuaTrinhDaoTaoInfo info)
        {
            DataRow row = Table.NewRow();
            
            row["MAQTDT"] = info.MaQuaTrinhDaoTao;
            row["MANHANVIEN"] = info.MaNhanVien;
            row["NAMNHAPHOC"] = info.NamNhapHoc;
            row["TOTNGHIEPNAM"] = info.NamTotNghiep;
            row["NOIDT"] = info.NoiDaoTao;
            row["NGANHDT"] = info.NganhDaoTao;
            row["HINHTHUCDT"] = info.HinhThucDaoTao;
            row["BANGDUOCCAP"] = info.BangDuocCap;

            Table.Rows.Add(row);
            if (this.data_QuaTrinhDaoTao.Update())
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
        public void Update(QuaTrinhDaoTaoInfo info, int index)
        {
           
            this.Table.Rows[index]["NAMNHAPHOC"] = info.NamNhapHoc;
            //this.Table.Rows[index]["NAMTN"] = info.NamTotNghiep;
            this.Table.Rows[index]["NOIDT"] = info.NoiDaoTao;
            this.Table.Rows[index]["NGANHDT"] = info.NganhDaoTao;
            this.Table.Rows[index]["HINHTHUCDT"] = info.HinhThucDaoTao;
            this.Table.Rows[index]["BANGDUOCCAP"] = info.BangDuocCap;


            this.data_QuaTrinhDaoTao.Update();
        }
        #endregion

        #region CapNhatQuaTrinhDaoTao()
        public void CapNhatQuaTrinhDaoTao(QuaTrinhDaoTaoInfo info, int index)
        {

            this.Table.Rows[index]["NAMNHAPHOC"] = info.NamNhapHoc;
            this.Table.Rows[index]["TOTNGHIEPNAM"] = info.NamTotNghiep;
            this.Table.Rows[index]["NOIDT"] = info.NoiDaoTao;
            this.Table.Rows[index]["NGANHDT"] = info.NganhDaoTao;
            this.Table.Rows[index]["HINHTHUCDT"] = info.HinhThucDaoTao;
            this.Table.Rows[index]["BANGDUOCCAP"] = info.BangDuocCap;


            this.data_QuaTrinhDaoTao.CapNhatQuaTrinhDaoTao(info);
        }
        #endregion

        #region Delete()
        public bool Delete(int index)
        {
            this.Table.Rows[index].Delete();

            return this.data_QuaTrinhDaoTao.Update();
        }
        #endregion

        #region Create()
        public void Create(TextBox txtMaQT)
        {
            Table = data_QuaTrinhDaoTao.lay_dsQuaTrinhDaoTao();
            bool b = true;
            int i = 0;
            int t = 1;
            if (Table.Rows.Count == 0)
            {
                txtMaQT.Text = "QTDT1";
                return;
            }
            while (b)
            {
                string s1 = string.Concat("QTDT", t.ToString());
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

        #region Xoa_QuaTrinhDaoTao      

        public void Xoa_QuaTrinhDaoTao(String maQTDT)
        {
            if (data_QuaTrinhDaoTao == null)
                data_QuaTrinhDaoTao = new QuaTrinhDaoTaoData();
            data_QuaTrinhDaoTao.Xoa_QTDaoTao(maQTDT);
        }
        #endregion

        #region Xoa_QuaTrinhDaoTaoNV

        public void Xoa_QuaTrinhDaoTaoNV(String maNV)
        {
            if (data_QuaTrinhDaoTao == null)
                data_QuaTrinhDaoTao = new QuaTrinhDaoTaoData();
            data_QuaTrinhDaoTao.Xoa_QuaTrinhDaoTaoNV(maNV);
        }
        #endregion

       
    }
}
