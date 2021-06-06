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
    public class SoQuyetDinhCtrl
    {

        #region data_SoQuyetDinh
        private SoQuyetDinhData m_data_SoQuyetDinh;
        public SoQuyetDinhData data_SoQuyetDinh
        {
            get { return m_data_SoQuyetDinh; }
            set { m_data_SoQuyetDinh = value; }
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

        #region HienThi_dsSoQuyetDinh()
        public void HienThi_dsSoQuyetDinh(ListView listView)
        {
            if (data_SoQuyetDinh == null)
            {
                data_SoQuyetDinh = new SoQuyetDinhData();
            }
            Table = data_SoQuyetDinh.lay_dsSoQuyetDinh();
            IEnumerator ie = Table.Rows.GetEnumerator();
            listView.Items.Clear();

            while (ie.MoveNext())
            {
                DataRow row = (DataRow)ie.Current;
                SoQuyetDinhInfo info = new SoQuyetDinhInfo();


                info.MaSoQuyetDinh = row["MASQD"].ToString();
                info.NgayQuyetDinh = (DateTime)row["NGAYQD"];
                info.LoaiQuyetDinh = row["LOAIQD"].ToString();
                info.NoiDung = row["NOIDUNG"].ToString();
                info.NguoiQuyetDinh = row["NGUOIQD"].ToString();
                info.ChucVu = row["CHUCVU"].ToString();


                ListViewItem item = new ListViewItem();

                item.Text = info.MaSoQuyetDinh;
                item.SubItems.Add(info.NgayQuyetDinh.ToShortDateString());
                item.SubItems.Add(info.LoaiQuyetDinh);
                item.SubItems.Add(info.NoiDung);
                item.SubItems.Add(info.NguoiQuyetDinh);
                item.SubItems.Add(info.ChucVu);
                item.Tag = info;

                listView.Items.Add(item);
            }
        }
        #endregion

        #region HienThiInfo()
        public void HienThiInfo(TextBox txtmasoQD, DateTimePicker dtNgayQD,TextBox txtloaiQD, TextBox txtNoiDung, TextBox txtNguoiQD, TextBox txtChucVu, SoQuyetDinhInfo info)
        {

            txtmasoQD.Text = info.MaSoQuyetDinh;
            dtNgayQD.Text = info.NgayQuyetDinh.ToShortDateString();
            txtloaiQD.Text = info.LoaiQuyetDinh;
            txtNoiDung.Text = info.NoiDung;
            txtNguoiQD.Text = info.NguoiQuyetDinh;
            txtChucVu.Text = info.ChucVu;

        }
        #endregion

        #region Add()
        public bool Add(SoQuyetDinhInfo info)
        {
            DataRow row = Table.NewRow();

            row["MASQD"] = info.MaSoQuyetDinh;
            row["NGAYQD"] = info.NgayQuyetDinh;
            row["LOAIQD"] = info.LoaiQuyetDinh;
            row["NOIDUNG"] = info.NoiDung;
            row["NGUOIQD"] = info.NguoiQuyetDinh;
            row["CHUCVU"] = info.ChucVu;


            Table.Rows.Add(row);
            if (this.data_SoQuyetDinh.Update())
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
        public void Update(SoQuyetDinhInfo info, int index)
        {
            ////this.Table.Rows[index]["MAQT"] = info.MaQuocTich;

            this.Table.Rows[index]["NGAYQD"] = info.NgayQuyetDinh;
            this.Table.Rows[index]["LOAIQD"] = info.LoaiQuyetDinh;
            this.Table.Rows[index]["NOIDUNG"] = info.NoiDung;
            this.Table.Rows[index]["NGUOIQD"] = info.NguoiQuyetDinh;
            this.Table.Rows[index]["CHUCVU"] = info.ChucVu;


            this.data_SoQuyetDinh.Update();
        }
        #endregion

        #region Delete()
        public bool Delete(int index)
        {
            this.Table.Rows[index].Delete();

            return this.data_SoQuyetDinh.Update();
        }
        #endregion

        #region Create()
        public void Create(TextBox txtMaQT)
        {
            Table = data_SoQuyetDinh.lay_dsSoQuyetDinh();
            bool b = true;
            int i = 0;
            int t = 1;
            if (Table.Rows.Count == 0)
            {
                txtMaQT.Text = "QD001";
                return;
            }
            while (b)
            {
                string s1 = string.Concat("QD00", t.ToString());
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

        #region HienThiComboBox()
        public void HienThiComboBox(ComboBox cmb)
        {
            if (this.data_SoQuyetDinh == null)
            {
                data_SoQuyetDinh = new SoQuyetDinhData();
            }
            this.Table = this.data_SoQuyetDinh.lay_dsSoQuyetDinh();
            cmb.DataSource = this.Table;
            cmb.DisplayMember = "MASQD";
            cmb.ValueMember = "MASQD";
        }
        #endregion

        #region GetSoQuyetDinh()
        public SoQuyetDinhInfo GetSoQuyetDinh(string maPB)
        {
            if (this.data_SoQuyetDinh == null)
            {
                this.data_SoQuyetDinh = new SoQuyetDinhData();
            }
            return this.data_SoQuyetDinh.GetSoQuyetDinh(maPB);
        }
        #endregion       

        
    }
}
