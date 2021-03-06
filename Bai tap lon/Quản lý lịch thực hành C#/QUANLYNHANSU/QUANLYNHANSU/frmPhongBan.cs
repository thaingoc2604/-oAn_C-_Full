using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using QUANLYNHANSU.Controller;
using QUANLYNHANSU.GetData;
using System.IO;

namespace QUANLYNHANSU
{
    public partial class frmPhongBan : Office2007Form
    {
        public frmPhongBan()
        {
            InitializeComponent();
        }
        clsPhongBanController control = new clsPhongBanController();
        clsToLamViecController tocontrol = new clsToLamViecController();
        clsNhanVienController nhanviencontrol = new clsNhanVienController();

        clsLayBangNhanVien nhanvien = new clsLayBangNhanVien();
        clsLayToLamViec to = new clsLayToLamViec();
        clsLayPhongBan phongban = new clsLayPhongBan();

        DataTable dtNvPhongBan = new DataTable();
        DataTable dtTo = new DataTable();
        DataTable dtToTheoPhong = new DataTable();
        DataTable dtNhanVien = new DataTable();
        DataTable dtNVTheoTo = new DataTable();
        DataTable dtPB = new DataTable();

        private void frmPhongBan_Load(object sender, EventArgs e)
        {
            control.HienThitruongphong(cmbTruongPhong);
            control.HienThiGridtruongphong(cmbcolTruongPhong);
            dtgPhongBan.Columns["cmbcolTruongPhong"].ReadOnly = true;

            nhanviencontrol.HienthiGridChucvu(cmbcolChucVu);
            nhanviencontrol.HienthiGridPhongban(cmbcolPhongBanNV);
            nhanviencontrol.HienthiGridTolamviec(cmbcolToNV);

            control.HienThiNgay(cmbcolNgayNhanChuc);
            control.HienThi(txtMaPhong, txtTenPhong, cmbTruongPhong, dteNgayNhanChuc, txtGhiChu, dtgPhongBan, bnPhongBan);

            
            tocontrol.HienThiPhongBan(cmbPhongBan);
            tocontrol.HienThiGridPhongBan(cmbcolPhongBan);

            tocontrol.HienThiToTruong(cmbToTruong);
            tocontrol.HienThiGridToTruong(cmbcolToTruong);

            tocontrol.HienThi(dtgPhongBan["maphong", dtgPhongBan.CurrentRow.Index].Value.ToString(), txtMaTo, txtTenTo, cmbToTruong, cmbPhongBan, txtghichuTo, dtgToLamViec, bnToLamViec);

            cmbChon.SelectedIndex = 0;
            bnPhongBan.BindingSource.MoveNext();
            bnToLamViec.BindingSource.MoveNext();
        }

        int cachhienthinhanvien = 0;

        private void dtgPhongBan_SelectionChanged(object sender, EventArgs e)
        {
            if (layroi == 0)
            {
                dtNhanVien = nhanvien.LayNhanVien();
                layroi = 1;
            }
            PhongChange();
        }

        public void PhongChange()
        {
            if (dtgPhongBan.CurrentRow != null)
            {
                tocontrol.HienThi(dtgPhongBan["maphong", dtgPhongBan.CurrentRow.Index].Value.ToString(), txtMaTo, txtTenTo, cmbToTruong, cmbPhongBan, txtghichuTo, dtgToLamViec, bnToLamViec);
                if (cachhienthinhanvien == 0)
                {
                    nhanviencontrol.HienthiNhanVienTheoPhong(dtgPhongBan["maphong", dtgPhongBan.CurrentRow.Index].Value.ToString(), dtgNhanVien, bnNhanVien);
                }
                //else
                //{
                //    dtToTheoPhong = to.LayToLamViecTheoPhong(dtgPhongBan["maphong", dtgPhongBan.CurrentRow.Index].Value.ToString());
                //    if (dtToTheoPhong.Rows.Count == 0)
                //        nhanviencontrol.HienthiNhanVienTheoTo(null, dtgNhanVien, bnNhanVien);
                //}

                if (dtgPhongBan["cmbcolTruongPhong", dtgPhongBan.CurrentRow.Index].Value.ToString().Length == 0)
                {
                    if (File.Exists(Application.StartupPath + "\\Images\\NoImage.bmp"))
                    {
                        PicHinh.SizeMode = PictureBoxSizeMode.StretchImage;
                        PicHinh.Image = Image.FromFile(Application.StartupPath + "\\Images\\NoImage.bmp");
                    }
                }

                dtNhanVien = nhanvien.LayNhanVien();
                foreach (DataRow dr in dtNhanVien.Rows)
                {
                    if (dtgPhongBan["cmbcolTruongPhong", dtgPhongBan.CurrentRow.Index].Value.ToString() == dr["manv"].ToString())
                    {
                        if (dr["hinhanh"].ToString().Length != 0)
                        {
                            byte[] Hinh = new byte[0];
                            Hinh = (byte[])dr["hinhanh"];
                            MemoryStream stream = new MemoryStream(Hinh);
                            PicHinh.SizeMode = PictureBoxSizeMode.Zoom;
                            PicHinh.Image = Image.FromStream(stream);

                            PicHinh.Refresh();
                        }
                        else
                        {
                            if (File.Exists(Application.StartupPath + "\\Images\\NoImage.bmp"))
                            {
                                PicHinh.SizeMode = PictureBoxSizeMode.StretchImage;
                                PicHinh.Image = Image.FromFile(Application.StartupPath + "\\Images\\NoImage.bmp");
                            }
                        }
                        break;
                    } 
                }
            }
        }

        public void ThemPhongBan()
        {
            string mapb = "PB";

            string masothutu;

            string thang = DateTime.Now.Month.ToString();
            if (thang.Length == 1)
                thang = "0" + thang;

            string nam = DateTime.Now.Year.ToString();
            string nam02 = nam[2].ToString() + nam[3].ToString();

            string thangnam = thang + nam02;

            int phantu = 0;
            int dong = dtgPhongBan.RowCount;
            dtPB = phongban.LayPhongBan();
            foreach (DataRow dr in dtPB.Rows)
            {
                string ma = dr["maphong"].ToString();
                string mathangnam = ma[2].ToString() + ma[3].ToString() + ma[4].ToString() + ma[5].ToString();
                string mathutu = ma[6].ToString() + ma[7].ToString() + ma[8].ToString() + ma[9].ToString();

                if (thangnam == mathangnam)
                {
                    int stt = Convert.ToInt32(mathutu);
                    if (stt > phantu)
                        phantu = stt;
                }
            }
            if (phantu != 0)
            {
                phantu++;

                if (phantu.ToString().Length == 1)
                    masothutu = "000" + phantu.ToString();
                else if (phantu.ToString().Length == 2)
                    masothutu = "00" + phantu.ToString();
                else if (phantu.ToString().Length == 3)
                    masothutu = "0" + phantu.ToString();
                else
                    masothutu = phantu.ToString();

                mapb = mapb + thangnam + masothutu;
            }
            else
            {
                mapb = mapb + thangnam + "0001";
            }

            DataRowView row = (DataRowView)bnPhongBan.BindingSource.AddNew();

            row["maphong"] = mapb;
            row["ngaythem"] = DateTime.Now.Date.ToString();

            string truongphong=null;
            if (cmbTruongPhong.Items.Count != 0)
            {
                cmbTruongPhong.SelectedIndex = 0;
                truongphong = cmbTruongPhong.SelectedValue.ToString();
            }

            string ngaythem = DateTime.Now.ToString();
            ngaythem = ngaythem[3].ToString() + ngaythem[4].ToString() + ngaythem[2].ToString() + ngaythem[0].ToString() + ngaythem[1].ToString() + ngaythem[5].ToString() + ngaythem[6].ToString() + ngaythem[7].ToString() + ngaythem[8].ToString() + ngaythem[9].ToString();
            phongban.ThemMoi(mapb, "Phong Ban", truongphong, ngaythem, null, ngaythem);
        }

        private void cmbChon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChon.SelectedItem.ToString() == "Phòng ban")
            {
                cachhienthinhanvien = 0;
                PhongChange();
            }
            if (cmbChon.SelectedItem.ToString() == "Tổ làm việc")
            {
                cachhienthinhanvien = 1;

                //dtToTheoPhong = to.LayToLamViecTheoPhong(dtgPhongBan["maphong", dtgPhongBan.CurrentRow.Index].Value.ToString());
                //if (dtToTheoPhong.Rows.Count == 0)
                //    nhanviencontrol.HienthiNhanVienTheoTo(null, dtgNhanVien, bnNhanVien);

                ToChange();
            }
        }

        public void Luu()
        {
            if (dtgPhongBan.RowCount != 0)
            {
                string ngaync=null;

                dtgPhongBan.EndEdit();
                if (dtgPhongBan.CurrentRow.Index != dtgPhongBan.RowCount - 1)
                    bnPhongBan.BindingSource.MoveNext();
                else
                    bnPhongBan.BindingSource.MovePrevious();

                for (int i = 0; i < dtgPhongBan.Rows.Count; i++)
                {
                    if (dtgPhongBan["cmbcolNgayNhanChuc", i].Value != null)
                    {
                        ngaync = dtgPhongBan["cmbcolNgayNhanChuc", i].Value.ToString();
                        ngaync = ngaync[3].ToString() + ngaync[4].ToString() + ngaync[2].ToString() + ngaync[0].ToString() + ngaync[1].ToString() + ngaync[5].ToString() + ngaync[6].ToString() + ngaync[7].ToString() + ngaync[8].ToString() + ngaync[9].ToString();
                    }
                    phongban.CapNhat(dtgPhongBan["maphong", i].Value.ToString(), dtgPhongBan["tenphong", i].Value.ToString(), dtgPhongBan["cmbcolTruongPhong", i].Value.ToString(), ngaync, dtgPhongBan["ghichu", i].Value.ToString());
                }
                MessageBoxEx.Show("Bạn đã lưu thành công", "Chúc mừng");
            }
           
        }

        int layroi = 0;

        private void dtgToLamViec_SelectionChanged(object sender, EventArgs e)
        {
            ToChange();
        }

        public void ToChange()
        {
            if (dtgToLamViec.CurrentRow != null)
            {
                if (cachhienthinhanvien == 1)
                {
                    if (dtNhanVien.Rows.Count != 0)
                    {
                        DataTable dt = new DataTable();
                        dt = dtNhanVien.Clone();
                        
                        foreach (DataRow dr in dtNhanVien.Rows)
                        {
                            if (dr["tophutrach"].ToString() == dtgToLamViec["mato", dtgToLamViec.CurrentRow.Index].Value.ToString())
                                dt.ImportRow(dr);
                        }
                        if (dt.Rows.Count != 0)
                            nhanviencontrol.HienthiNhanVienTheoTo(dt, dtgNhanVien, bnNhanVien);
                        else
                            nhanviencontrol.HienthiNhanVienTheoTo(null, dtgNhanVien, bnNhanVien);
                    }
                }
            }
        }

        private void bntXoaTo_Click(object sender, EventArgs e)
        {
            dtNVTheoTo = nhanvien.LayNhanVienTheoTo(dtgToLamViec["mato", dtgToLamViec.CurrentRow.Index].Value.ToString());
            if (dtNVTheoTo.Rows.Count == 0)
                bnToLamViec.BindingSource.RemoveCurrent();
            else
            {
                frmThongBaoXoaToLamViec xoato = new frmThongBaoXoaToLamViec(dtgToLamViec["mato", dtgToLamViec.CurrentRow.Index].Value.ToString());
                xoato.ShowDialog();
                if (xoato.dachuyen == 1)
                    bnToLamViec.BindingSource.RemoveCurrent();
            }
        }

        public void ThemToLamViec(string maphong)
        {
            string mato = "TO";

            string masothutu;

            string thang = DateTime.Now.Month.ToString();
            if (thang.Length == 1)
                thang = "0" + thang;

            string nam = DateTime.Now.Year.ToString();
            string nam02 = nam[2].ToString() + nam[3].ToString();

            string thangnam = thang + nam02;

            int phantu = 0;
            dtTo = to.LayToLamViec();

            foreach (DataRow dr in dtTo.Rows)
            {
                string ma = dr["mato"].ToString();
                string mathangnam = ma[2].ToString() + ma[3].ToString() + ma[4].ToString() + ma[5].ToString();
                string mathutu = ma[6].ToString() + ma[7].ToString() + ma[8].ToString() + ma[9].ToString();

                if (thangnam == mathangnam)
                {
                    int stt = Convert.ToInt32(mathutu);
                    if (stt > phantu)
                        phantu = stt;
                }
            }
            if (phantu != 0)
            {
                phantu++;

                if (phantu.ToString().Length == 1)
                    masothutu = "000" + phantu.ToString();
                else if (phantu.ToString().Length == 2)
                    masothutu = "00" + phantu.ToString();
                else if (phantu.ToString().Length == 3)
                    masothutu = "0" + phantu.ToString();
                else
                    masothutu = phantu.ToString();

                mato = mato + thangnam + masothutu;
            }
            else
            {
                mato = mato + thangnam + "0001";
            }
           
            DataRowView row = (DataRowView)bnToLamViec.BindingSource.AddNew();

            row["mato"] = mato;
            row["maphongban"] = maphong;
            row["ngaythem"] = DateTime.Now.Date.ToString();

            string ngaythem = DateTime.Now.ToString();
            ngaythem = ngaythem[3].ToString() + ngaythem[4].ToString() + ngaythem[2].ToString() + ngaythem[0].ToString() + ngaythem[1].ToString() + ngaythem[5].ToString() + ngaythem[6].ToString() + ngaythem[7].ToString() + ngaythem[8].ToString() + ngaythem[9].ToString();

            //to.ThemMoi(mato,"To Lam Viec",
        }

        public void ThemNhanVienTheoToPhong(string maphong, string matolam)
        {
            string manv = "NV";

            string masothutu;

            string thang = DateTime.Now.Month.ToString();
            if (thang.Length == 1)
                thang = "0" + thang;

            string nam = DateTime.Now.Year.ToString();
            string nam02 = nam[2].ToString() + nam[3].ToString();

            string thangnam = thang + nam02;

            int phantu = 0;
            dtNhanVien = nhanvien.LayNhanVien();

            foreach (DataRow dr in dtNhanVien.Rows)
            {
                string ma = dr["manv"].ToString();
                string mathangnam = ma[2].ToString() + ma[3].ToString() + ma[4].ToString() + ma[5].ToString();
                string mathutu = ma[6].ToString() + ma[7].ToString() + ma[8].ToString() + ma[9].ToString();

                if (thangnam == mathangnam)
                {
                    int stt = Convert.ToInt32(mathutu);
                    if (stt > phantu)
                        phantu = stt;
                }
            }
            if (phantu != 0)
            {
                phantu++;

                if (phantu.ToString().Length == 1)
                    masothutu = "000" + phantu.ToString();
                else if (phantu.ToString().Length == 2)
                    masothutu = "00" + phantu.ToString();
                else if (phantu.ToString().Length == 3)
                    masothutu = "0" + phantu.ToString();
                else
                    masothutu = phantu.ToString();

                manv = manv + thangnam + masothutu;
            }
            else
            {
                manv = manv + thangnam + "0001";
            }

            DataRowView row = (DataRowView)bnNhanVien.BindingSource.AddNew();

            row["manv"] = manv;
            row["tennv"] = "Name";
            row["ngaycap"] = DateTime.Now.Date.ToString();
            row["ngaysinh"] = DateTime.Now.Date.ToString();
            row["gioitinh"] = "Nam";
            row["tinhtranghonnhan"] = "Độc thân";
            row["tinhtranglamviec"] = "Đang làm việc";
            row["tinhtrangsuckhoe"] = "Tốt";
            row["hocvi"] = "Cử nhân";
            row["heso"] = 2.33;
            row["ngayvaolam"] = DateTime.Now.Date.ToString();
            row["thamnien"] = 1;
            row["cannang"] = 0;
            row["cao"] = 0;
            row["cmnd"] = "123456789";
            
            row["phongban"] = maphong;
            row["tophutrach"] = matolam;
            row["ngaythem"] = DateTime.Now.Date.ToString();


            string ngayhienhanh = DateTime.Now.Date.ToString();
            ngayhienhanh = ngayhienhanh[3].ToString() + ngayhienhanh[4].ToString() + ngayhienhanh[2].ToString() + ngayhienhanh[0].ToString() + ngayhienhanh[1].ToString() + ngayhienhanh[5].ToString() + ngayhienhanh[6].ToString() + ngayhienhanh[7].ToString() + ngayhienhanh[8].ToString() + ngayhienhanh[9].ToString();

            nhanvien.ThemMoi(manv, "Name", null, "123456789", ngayhienhanh, null, ngayhienhanh, "Nam", null, null, null, null, null, "Độc thân", maphong, matolam, null, ngayhienhanh, 1, 2.33, "Đang làm việc", null, null, null, "Cử nhân", null, null, 0, 0, "A", "Tốt", null, ngayhienhanh);
        }

        private void bntThemTo_Click(object sender, EventArgs e)
        {
            ThemToLamViec(dtgPhongBan["maphong", dtgPhongBan.CurrentRow.Index].Value.ToString());
        }

        private void bntXoaPhong_Click(object sender, EventArgs e)
        {
            if (dtgPhongBan.RowCount <= 1)
                MessageBoxEx.Show("Bạn không được xóa phòng ban này", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                dtNvPhongBan = nhanvien.LayNhanVienTheoPhongBan(dtgPhongBan["maphong", dtgPhongBan.CurrentRow.Index].Value.ToString());
                dtTo = to.LayToLamViecTheoPhong(dtgPhongBan["maphong", dtgPhongBan.CurrentRow.Index].Value.ToString());

                if (dtNvPhongBan.Rows.Count == 0)
                {
                    if (dtTo.Rows.Count != 0)
                    {
                        string[] tolam = new string[100];
                        int sttto = 0;
                        foreach (DataRow dr in dtTo.Rows)
                        {
                            tolam[sttto] = dr["mato"].ToString();
                            sttto++;
                        }
                        for (int i = 0; i < tolam.Length; i++)
                        {
                            if (tolam[i] != null)
                                to.XoaToLamViecTheoPhong(tolam[i]);
                            else
                                break;
                        }
                    }
                    bnPhongBan.BindingSource.RemoveCurrent();
                }
                else
                {
                    frmThongBaoXoaPhongBan xoa = new frmThongBaoXoaPhongBan(dtgPhongBan["maphong", dtgPhongBan.CurrentRow.Index].Value.ToString());
                    xoa.ShowDialog();
                    if (xoa.dachuyen == 1)
                    {
                        dtTo = to.LayToLamViecTheoPhong(dtgPhongBan["maphong", dtgPhongBan.CurrentRow.Index].Value.ToString());
                        if (dtTo.Rows.Count != 0)
                        {
                            string[] tolam = new string[100];
                            int sttto = 0;
                            foreach (DataRow dr in dtTo.Rows)
                            {
                                tolam[sttto] = dr["mato"].ToString();
                                sttto++;
                            }
                            for (int i = 0; i < tolam.Length; i++)
                            {
                                if (tolam[i] != null)
                                    to.XoaToLamViecTheoPhong(tolam[i]);
                                else
                                    break;
                            }
                        }
                        bnPhongBan.BindingSource.RemoveCurrent();
                    }
                }
                Luu();
            }
        }

        private void bntThemPhong_Click(object sender, EventArgs e)
        {
            ThemPhongBan();
        }

        private void bntThemNV_Click(object sender, EventArgs e)
        {
            if (dtgToLamViec.CurrentRow != null)
            {
                if (dtgNhanVien.RowCount != 0)
                    ThemNhanVienTheoToPhong(dtgPhongBan["maphong", dtgPhongBan.CurrentRow.Index].Value.ToString(), dtgToLamViec["mato", dtgToLamViec.CurrentRow.Index].Value.ToString());
            }
            else
                if (dtgNhanVien.RowCount != 0)
                    ThemNhanVienTheoToPhong(dtgPhongBan["maphong", dtgPhongBan.CurrentRow.Index].Value.ToString(), null);
        }

        private void bntLuuPB_Click(object sender, EventArgs e)
        {
            Luu();
        }

        public void LuuNV()
        {
            if (dtgNhanVien.RowCount != 0)
            {
                dtgNhanVien.EndEdit();
                if (dtgNhanVien.CurrentRow.Index != dtgNhanVien.RowCount - 1)
                    bnNhanVien.BindingSource.MoveNext();
                else
                    bnNhanVien.BindingSource.MovePrevious();

                for (int i = 0; i < dtgNhanVien.Rows.Count; i++)
                {
                    string gioitinh = "";
                    string mau = "";
                    string honnhan = "";
                    string ngaycapcmnd = "";
                    string ngaysinh = "";
                    string hocvi = "";

                    string chucvu = "";
                    string ngayvaolam = "";
                    string lamviec = null;

                    int thamnien = 0;
                    double heso = 0;
                    int cannang = 0;
                    double cao = 0;

                    if (dtgNhanVien["cmbcolGioiTinh", i].Value != null)
                        gioitinh = dtgNhanVien["cmbcolGioiTinh", i].Value.ToString();

                    if (dtgNhanVien["cmbcolNhomMau", i].Value != null)
                        mau = dtgNhanVien["cmbcolNhomMau", i].Value.ToString();

                    if (dtgNhanVien["cmbcolHonNhan", i].Value != null)
                        honnhan = dtgNhanVien["cmbcolHonnhan", i].Value.ToString();

                    if (dtgNhanVien["cmbcolLamViec", i].Value != null)
                        lamviec = dtgNhanVien["cmbcolLamViec", i].Value.ToString();

                    if (dtgNhanVien["calNgayCapNV", i].Value != null)
                    {
                        ngaycapcmnd = dtgNhanVien["calNgayCapNV", i].Value.ToString();
                        ngaycapcmnd = ngaycapcmnd[3].ToString() + ngaycapcmnd[4].ToString() + ngaycapcmnd[2].ToString() + ngaycapcmnd[0].ToString() + ngaycapcmnd[1].ToString() + ngaycapcmnd[5].ToString() + ngaycapcmnd[6].ToString() + ngaycapcmnd[7].ToString() + ngaycapcmnd[8].ToString() + ngaycapcmnd[9].ToString();
                    }

                    if (dtgNhanVien["calNgaySinhNV", i].Value != null)
                    {
                        ngaysinh = dtgNhanVien["calNgaySinhNV", i].Value.ToString();
                        ngaysinh = ngaysinh[3].ToString() + ngaysinh[4].ToString() + ngaysinh[2].ToString() + ngaysinh[0].ToString() + ngaysinh[1].ToString() + ngaysinh[5].ToString() + ngaysinh[6].ToString() + ngaysinh[7].ToString() + ngaysinh[8].ToString() + ngaysinh[9].ToString();
                    }

                    if (dtgNhanVien["cmbcolHocVi", i].Value != null)
                        hocvi = dtgNhanVien["cmbcolHocVi", i].Value.ToString();

                    if (dtgNhanVien["cmbcolChucVu", i].Value != null)
                        chucvu = dtgNhanVien["cmbcolChucVu", i].Value.ToString();

                    if (dtgNhanVien["cmbcolNgayVaoLam", i].Value != null)
                    {
                        ngayvaolam = dtgNhanVien["cmbcolNgayVaoLam", i].Value.ToString();
                        ngayvaolam = ngayvaolam[3].ToString() + ngayvaolam[4].ToString() + ngayvaolam[2].ToString() + ngaysinh[0].ToString() + ngaysinh[1].ToString() + ngayvaolam[5].ToString() + ngayvaolam[6].ToString() + ngayvaolam[7].ToString() + ngayvaolam[8].ToString() + ngayvaolam[9].ToString();
                    }

                    if (dtgNhanVien["thamnien", i].Value != null)
                        thamnien = Convert.ToInt32(dtgNhanVien["thamnien", i].Value.ToString());

                    if (dtgNhanVien["heso", i].Value != null)
                        heso = Convert.ToDouble(dtgNhanVien["heso", i].Value.ToString());

                    if (dtgNhanVien["cannang", i].Value != null)
                        cannang = Convert.ToInt32(dtgNhanVien["cannang", i].Value.ToString());

                    if (dtgNhanVien["cao", i].Value != null)
                        cao = Convert.ToDouble(dtgNhanVien["cao", i].Value.ToString());

                    nhanvien.CapNhat(dtgNhanVien["manv", i].Value.ToString(), dtgNhanVien["tennv", i].Value.ToString(), dtgNhanVien["bidanh", i].Value.ToString(), dtgNhanVien["cmnd", i].Value.ToString(), ngaycapcmnd, dtgNhanVien["noicap", i].Value.ToString(), ngaysinh, gioitinh, dtgNhanVien["diachi", i].Value.ToString(), dtgNhanVien["email", i].Value.ToString(), dtgNhanVien["sdtcty", i].Value.ToString(), dtgNhanVien["sdtrieng", i].Value.ToString(), dtgNhanVien["sdtnha", i].Value.ToString(), honnhan, dtgNhanVien["cmbcolPhongBanNV", i].Value.ToString(), dtgNhanVien["cmbcolToNV", i].Value.ToString(), chucvu, ngayvaolam, thamnien, heso, lamviec, dtgNhanVien["hinhthuctuyendung", i].Value.ToString(), dtgNhanVien["tinhoc", i].Value.ToString(), dtgNhanVien["ngoaingu", i].Value.ToString(), hocvi, dtgNhanVien["soBHXH", i].Value.ToString(), dtgNhanVien["soBHYT", i].Value.ToString(), cannang, cao, mau, dtgNhanVien["tinhtrangsuckhoe", i].Value.ToString(), dtgNhanVien["taikhoanNH", i].Value.ToString());
                }
                dtNhanVien = nhanvien.LayNhanVien();
                
                MessageBoxEx.Show("Bạn đã lưu thành công!!!", "Chúc mừng");
            }
        }

        private void bntLuuNV_Click(object sender, EventArgs e)
        {
            LuuNV();
        }

        private void dtgNhanVien_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgNhanVien.CurrentCell == dtgNhanVien["cmbcolPhongBanNV", dtgNhanVien.CurrentRow.Index])
            {
                dtToTheoPhong = to.LayToLamViecTheoPhong(dtgNhanVien["cmbcolPhongBanNV", dtgNhanVien.CurrentRow.Index].Value.ToString());
                if (dtToTheoPhong.Rows.Count == 0)
                    dtgNhanVien["cmbcolToNV", dtgNhanVien.CurrentRow.Index].Value = null;
            }
            if (dtgNhanVien.CurrentCell == dtgNhanVien["cmbcolToNV", dtgNhanVien.CurrentRow.Index])
            {
                dtTo = to.LayToLamViec();
                foreach (DataRow dr in dtTo.Rows)
                {
                    if (dtgNhanVien["cmbcolToNV", dtgNhanVien.CurrentRow.Index].Value.ToString() == dr["mato"].ToString())
                    {
                        dtgNhanVien["cmbcolPhongBanNV", dtgNhanVien.CurrentRow.Index].Value = dr["maphongban"].ToString();
                        break;
                    }
                }
            }
        }

        private void dtgPhongBan_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void dtgNhanVien_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //if (dtgNhanVien.CurrentRow != null)
            //{

            //    if (dtgNhanVien["hinhanh", dtgNhanVien.CurrentRow.Index].Value.ToString().Length != 0)
            //    {
            //        byte[] Hinh = new byte[0];
            //        Hinh = (byte[])dtgNhanVien["hinhanh", dtgNhanVien.CurrentRow.Index].Value;

            //        frmHienThiHinhTheoNhanVien hienthi = null;
            //        hienthi = new frmHienThiHinhTheoNhanVien(Hinh);
            //        hienthi.FormBorderStyle = FormBorderStyle.None;

            //        Point p = new Point(e.X+100,e.Y+100);
            //        hienthi.Location = p;

            //        hienthi.Show();

            //    }
            //}
        }
    }
}