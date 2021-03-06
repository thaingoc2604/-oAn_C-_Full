using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevComponents.Editors;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors.DateTimeAdv;
using QuanLyTienGuiTietKiem.DataLayer;
using QuanLyTienGuiTietKiem.Bussiness;
using QuanLyTienGuiTietKiem.General;

namespace QuanLyTienGuiTietKiem.Controller
{
    public class SoTietKiemCtrl
    {
        SoTietKiemData m_SoTietKiemData = new SoTietKiemData();
        RutTietKiemData m_RutTietKiemData = new RutTietKiemData();
        RutTietKiemCtrl m_RutTienTietCtrl = new RutTietKiemCtrl();
        QuyDinh m_QuyDinh = new QuyDinh();
        CDate cd = new CDate();
        #region Hien thi ComboBox
        public void HienThiComboBox(ComboBox cbx)
        {
            DataTable m_DT = m_SoTietKiemData.LaySoTietKiem();
            cbx.DataSource = m_DT;
            cbx.DisplayMember = "MaSoTietKiem";
            cbx.ValueMember = "MaSoTietKiem";
        }
        //Hien thi danh sach theo ngay den han

        public void HienThiDSTheoNgayDH(DateTime NgayDenHan, ListViewEx lV)
        {
            DataTable m_DT = m_SoTietKiemData.LayTheoHetHan(NgayDenHan);

            lV.Items.Clear();
            foreach (DataRow Row in m_DT.Rows)
            {
                ListViewItem item = new ListViewItem();

                item.Text = Row["MaSoTietKiem"].ToString();
                item.SubItems.Add(Row["HoTen"].ToString());
                item.SubItems.Add(Row["TenLoaiTietKiem"].ToString());
                item.SubItems.Add(Row["SoDu"].ToString());
                item.SubItems.Add(Row["LoaiTien"].ToString());

                lV.Items.Add(item);
            }
        }

        public int KiemTraNgayDenHan()
        {
            int SoNgay = 0;
            SoTietKiemData STK1 = new SoTietKiemData();
            DataTable m_DT2 = STK1.LayTheoNgayDH();
            foreach (DataRow row in m_DT2.Rows)
            {
                //DateTime d1 = new DateTime(2009,5,2);
                DateTime d1 = Convert.ToDateTime(row["NgayDenHan"].ToString());
                DateTime d2 = DateTime.Today;
                SoNgay = Convert.ToInt32(d1.ToOADate() - d2.ToOADate());
            }
            return SoNgay;
        }

        public void HienThiComboBoxTheoNgay(ComboBox cbx)
        {
            SoTietKiemData STK = new SoTietKiemData();
            NgayGiaoDichData NGD = new NgayGiaoDichData();
            DataTable m_DT1 = STK.LayTheoNgayDH();

            cbx.DataSource = m_DT1;
            cbx.DisplayMember = "NgayGiaoDich";
            cbx.ValueMember = "NgayGiaoDich";

        }

        public void HienThiComboBox(String MaLoaiSo, ComboBox cmb)
        {
            DataTable m_DT = m_SoTietKiemData.LayTheoMaLoai(MaLoaiSo);
            cmb.DataSource = m_DT;
            cmb.DisplayMember = "MaSoTietKiem";
            cmb.ValueMember = "MaSoTietKiem";
        }

        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_SoTietKiemData.LaySoTietKiem();
            cmbColumn.DisplayMember = "MaLoaiSoTietKiem";
            cmbColumn.ValueMember = "MaTietKiem";
            cmbColumn.DataPropertyName = "MaTietKiem";
            cmbColumn.HeaderText = "Tên Phát Sinh Tiết Kiệm";
        }
        #endregion

        #region Tinh lai nhap von
        public double TinhLaiNhapVon(DateTime NgayGD)
        {
            double tong = 0;
            DataTable data = m_SoTietKiemData.LayTheoNgayDH(NgayGD);
            foreach (DataRow row in data.Rows)
            {
                String MaSo = Convert.ToString(row["MaSoTietKiem"]);
                if (row["MaLoaiTietKiem"].ToString() != "TK423100")
                {
                   tong =  m_RutTienTietCtrl.RutLaiSoCoKyHan(MaSo);
                }
                else
                {
                   tong = m_RutTienTietCtrl.RutLaiKhongKyHan(MaSo);
                }
            }
            return tong;
        }

        //Tinh Ngay den han
        public DateTime NgayDH(DateTime NgayGD)
        {
            int KyHan;
            DataTable data1 = m_SoTietKiemData.LayTheoNgayDH(NgayGD);
            DataRow row = data1.Rows[0];
            KyHan = Convert.ToInt32(row["KyHan"]) * 30;

            DateTime dt= new DateTime();
            dt = Convert.ToDateTime(row["NgayDenHan"]);

            cd = new CDate(dt);
            cd.IncDay(KyHan);

            return cd.ToDateTime;
        }

        public void LuuNhapVon(DateTime NgayGD)
        {
            double Tong = 0;
            DataTable data = m_SoTietKiemData.LayTheoNgayDH(NgayGD);
            foreach (DataRow row in data.Rows)
            {
                String MaSo = Convert.ToString(row["MaSoTietKiem"]);
                DateTime NgayNhapVon = DateTime.Today;
                double LaiNhapVon = TinhLaiNhapVon(NgayGD);//Convert.ToDouble(row["LaiNhapVon"]);
                DateTime NgayDenHan = NgayDH(NgayGD);//Convert.ToDateTime(row["NgayDenHan"]);
                float SoDu = Convert.ToInt64(row["SoDu"]);

                Tong = TinhLaiNhapVon(NgayGD) + SoDu;

                m_SoTietKiemData.LuuThayDoi(MaSo, NgayDenHan, NgayNhapVon, Convert.ToInt64(LaiNhapVon));
                m_RutTietKiemData.LuuSoDu(MaSo, Convert.ToInt64(Tong));
            }
        }
        #endregion 

        #region Hien thi

        public String LayMaSoTietKiem()
        {
            String MaSo = "";
            SoTietKiemData data = new SoTietKiemData();
            DataTable tbl = data.LaySoTietKiem();
            foreach (DataRow row in tbl.Rows)
            {
                String chuoi = row["MaSoTietKiem"].ToString();
                string so = chuoi.Substring(3, 6);
                int TT = Convert.ToInt32(so);
                MaSo = "STK" + (m_QuyDinh.LaySTT(TT + 1));
            }
            return MaSo;
        }

        public void HienThi(DataGridView Dgv, BindingNavigator bvn)
        {
            BindingSource bs = new BindingSource();

            bs.DataSource = m_SoTietKiemData.LaySoTietKiem();
            bvn.BindingSource = bs;
            Dgv.DataSource = bs;
        }

        public void HienThi(DataGridViewX dGV,
                            BindingNavigator bN,
                            TextBoxX txtMaSoTietKiem,
                            ComboBoxEx cmbMaLoaiTietKiem,
                            ComboBoxEx cmbMaKH,
                            DateTimeInput dtNgayMoSo,
                            DateTimeInput dtNgayHieuLuc,
                            DateTimeInput dtNgayDenHan,
                            DateTimeInput dtNgayTinhLai,
                            DateTimeInput dtNgayTaiKyGui,
                            TextBoxX txtLaiDaTra,
                            TextBoxX txtLaiNhapVon,
                            DateTimeInput dtNgayNhapVon,
                            TextBoxX txtPhongToa,
                            CheckBoxX cbPhongToa,
                            DateTimeInput dtNgayTatToan)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_SoTietKiemData.LaySoTietKiem();
            DataTable DT = m_SoTietKiemData.LaySoTietKiem();
            bool PhongToa = Convert.ToBoolean(DT.Rows[0]["PhongToa"]);

            if (PhongToa)
                cbPhongToa.Checked = true;

            txtMaSoTietKiem.DataBindings.Clear();
            txtMaSoTietKiem.DataBindings.Add("Text", bS, "MaSoTietKiem");

            cmbMaLoaiTietKiem.DataBindings.Clear();
            cmbMaLoaiTietKiem.DataBindings.Add("SelectedValue", bS, "MaLoaiTietKiem");

            cmbMaKH.DataBindings.Clear();
            cmbMaKH.DataBindings.Add("SelectedValue", bS, "MaKH");

            dtNgayMoSo.DataBindings.Clear();
            dtNgayMoSo.DataBindings.Add("Value", bS, "NgayMoSo");

            dtNgayHieuLuc.DataBindings.Clear();
            dtNgayHieuLuc.DataBindings.Add("Value", bS, "NgayHieuLuc");

            dtNgayDenHan.DataBindings.Clear();
            dtNgayDenHan.DataBindings.Add("Value", bS, "NgayDenHan");

            dtNgayTinhLai.DataBindings.Clear();
            dtNgayTinhLai.DataBindings.Add("Value", bS, "NgayTinhLaiGanNhat");

            dtNgayTaiKyGui.DataBindings.Clear();
            dtNgayTaiKyGui.DataBindings.Add("Value", bS, "NgayTaiKyGui");

            txtLaiDaTra.DataBindings.Clear();
            txtLaiDaTra.DataBindings.Add("Text", bS, "LaiDaTra");

            txtLaiNhapVon.DataBindings.Clear();
            txtLaiNhapVon.DataBindings.Add("Text", bS, "LaiNhapVon");

            dtNgayNhapVon.DataBindings.Clear();
            dtNgayNhapVon.DataBindings.Add("Value", bS, "NgayNhapVon");

            cbPhongToa.DataBindings.Clear();
            cbPhongToa.DataBindings.Add("checked", bS, "PhongToa");

            dtNgayTatToan.DataBindings.Clear();
            dtNgayTatToan.DataBindings.Add("Value", bS, "NgayTatToan");

            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        #endregion

        #region Them moi
        public DataRow ThemDongMoi()
        {
            return m_SoTietKiemData.ThemDongMoi();
        }
        public void ThemMoi(DataRow m_Row)
        {
            m_SoTietKiemData.ThemSoTietKiem(m_Row);
        }
        #endregion

        #region Luu
        public bool LuuSoTietKiem()
        {
            return m_SoTietKiemData.LuuSoTietKiem();
        }

        public void LuuSoMoTK(String MaLoaiTK, String MaSoTK, DateTime NgayMoSo, DateTime NgayHieuLuc, DateTime NgayDenHan, DateTime NgayTinhLaiGanNhat, DateTime NgayTaiKyGui, float LaiDatra, float LaiNhapVon, DateTime NgayNhapVon, Boolean PhongToa, DateTime NgayHoanTat, String MaKH)
        {
            m_SoTietKiemData.LuuSoTK(MaLoaiTK, MaSoTK, NgayMoSo, NgayHieuLuc, NgayDenHan, NgayTinhLaiGanNhat, NgayTaiKyGui, LaiDatra, LaiNhapVon, NgayNhapVon,PhongToa, NgayHoanTat, MaKH);
        }

        #endregion 

        #region Xoa
        public void XoaSoMoTK(String MaLoaiTK, String MaSoTK, DateTime NgayMoSo, DateTime NgayHieuLuc, DateTime NgayDenHan, DateTime NgayTinhLaiGanNhat, DateTime NgayTaiKyGui, float LaiDatra, float LaiNhapVon, DateTime NgayNhapVon, Boolean PhongToa, DateTime NgayHoanTat, String MaKH)
        {
            m_SoTietKiemData.XoaSoTK(MaLoaiTK, MaSoTK, NgayMoSo, NgayHieuLuc, NgayDenHan, NgayTinhLaiGanNhat, NgayTaiKyGui, LaiDatra, LaiNhapVon, NgayNhapVon, PhongToa, NgayHoanTat, MaKH);
        }
        #endregion

        #region tim kiem

        public void TimSoTietKiem(TextBoxX txtMaSoTietKiem,
                                   ComboBoxEx cmbTheoHoTen,
                                   ComboBoxEx cmbHoTen,
                                   ComboBoxEx cmbTheoDiaChi,
                                   ComboBoxEx cmbDiaChi,
                                   ComboBoxEx cmbTheoCMND,
                                   ComboBoxEx cmbCMND,
                                   DataGridViewX dGV,
                                   BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_SoTietKiemData.TimSoTietKiem(txtMaSoTietKiem.Text, cmbTheoHoTen.Text, cmbHoTen.Text, cmbTheoDiaChi.Text, cmbDiaChi.Text, cmbTheoCMND.Text, cmbCMND.Text);

            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }

        public void TimTheoTen(String m_Ten)
        {
            m_SoTietKiemData.LayTenKH(m_Ten);
        }

        public void TimTheoMaSo(String m_MaSo)
        {
            m_SoTietKiemData.LayMaSo(m_MaSo);
        }
        #endregion

        public void ThemSoKKH(ComboBoxEx MaSoTK, TextBoxX TenKH, TextBoxX LoaiTietKiem, TextBoxX LaiSuat, TextBoxX SoDu, TextBoxX NgayDenHan, TextBoxX SoButToan, TextBoxX SoHieuTaiKhoanCo, TextBoxX SoHieuTaiKhoanCo1)
        {
            SoTietKiemData data = new SoTietKiemData();
            DataTable tbl = data.ThemSoKKH(MaSoTK.SelectedValue.ToString());

            foreach (DataRow row in tbl.Rows)
            {
                if (row["MaLoaiTietKiem"].ToString() != "TK423100")
                {

                }
                else
                {
                    TenKH.Text = Convert.ToString(row["HoTen"]);
                    LoaiTietKiem.Text = Convert.ToString(row["TenLoaiTietKiem"]);
                    LaiSuat.Text = Convert.ToString(row["MucLaiSuat"]);
                    SoDu.Text = Convert.ToString(row["SoDu"]);
                    NgayDenHan.Text = Convert.ToString(row["NgayDenHan"]);
                    SoButToan.Text = Convert.ToString(row["SoButToan"]);
                    SoHieuTaiKhoanCo.Text = Convert.ToString(row["SoHieuTaiKhoan"]);
                    SoHieuTaiKhoanCo1.Text = Convert.ToString(row["SoHieuTaiKhoanCo"]);
                    
                }
            }
        }

        


    }
}
