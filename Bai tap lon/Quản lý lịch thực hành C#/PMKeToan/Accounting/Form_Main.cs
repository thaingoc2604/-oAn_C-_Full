using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

using Janus.Windows.UI;
using Janus.Windows.UI.Dock;
using Janus.Windows.UI.CommandBars;

using BUS;
using DTO;
using System.IO;
using System.Reflection;
using System.Data.OleDb;
using DevComponents.DotNetBar;

namespace Accounting
{
    public partial class Form_Main : Office2007Form
    {
        static NguoiDung_DTO _ngdung_DTO;
        static NguoiDung_Bus _ngdung_BUS;
        TKThuChi_BUS tk_bus;
        SODu_BUS _sd_BUS ;
        DataSet _ds;
        XtraReport _rp;

        HeThong_BUS _th_BUS;

        TKThuChi_DTO _tk_DTO;
        Int64 tongthu = 0;
        Int64 tongchi = 0;

        static NguoiDung_DTO _user_DTO;

        public Form_Main()
        {
            InitializeComponent();

            _tk_DTO = new TKThuChi_DTO();

            tk_bus = new TKThuChi_BUS();

            _ngdung_BUS = new NguoiDung_Bus();

            _ngdung_DTO = new NguoiDung_DTO();

            _sd_BUS = new SODu_BUS();

            _ds = new DataSet();

            _th_BUS = new HeThong_BUS();

           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Frm_DangNhap frmDangNhap = new Frm_DangNhap();

            if (frmDangNhap.ShowDialog() == DialogResult.Yes)
            {
                _user_DTO = Frm_DangNhap.Ngdung_DTO;

                if (tk_bus != null)
                {
                    errorProvider1.Clear();

                    calendarCombo1.Value = DateTime.Now;

                    TKThuChiGrid.DataSource = tk_bus.GetDSTK_ThuChi_TheoNgay(calendarCombo1.Value);

                    if (TKThuChiGrid.RowCount == 0)
                    {
                        errorProvider1.SetError(bttKetChuyen, "Luu y nho' bam ket chuyen!");

                        bttKetChuyen.ForeColor = Color.Red;
                    }
                    else
                    {
                        errorProvider1.Clear();
                        bttKetChuyen.ForeColor = Color.WhiteSmoke;
                    }

                    //MessageBox.Show(calendarCombo1.Value.Month.ToString());

                    DateTime ngaythang = new DateTime(calendarCombo1.Value.AddDays(-1).Year, calendarCombo1.Value.AddDays(-1).Month, calendarCombo1.Value.AddDays(-1).Day); ;

                    Int64 sodukytruoc = _sd_BUS.get_So_Du_Theo_Ngay(ngaythang);

                    Int64 sothukytruoc = 0;

                    Int64 sochikytruoc = 0;

                    intSoDu.Text = sodukytruoc.ToString();

                    intSoChi.Text = sochikytruoc.ToString();

                    intSoThu.Text = sothukytruoc.ToString();

                    if (_user_DTO.IsAdmin == -1)
                    {
                        SetPermitforGuest();
                    }

                    if (_user_DTO.IsAdmin == 0)
                    {
                        SetPermitforUser();
                    }

                    if (_user_DTO.IsAdmin == 1)
                    {
                        SetPermitforAdmin();
                    }

                    if (tk_bus.KT_PhatSinh(calendarCombo1.Value) > 0 && _user_DTO.IsAdmin!=-1)
                    {
                        bttKetChuyen.Enabled = false;
                        btt_TinhTon.Enabled = true;
                        //  bttKetChuyen.ForeColor = Color.WhiteSmoke;

                    }
                    else
                    {
                        if (_user_DTO.IsAdmin != -1)
                        {
                            bttKetChuyen.Enabled = true;
                            btt_TinhTon.Enabled = false;
                        }
                    }
            //        ThemDongMangSang();
                }
                else
                    Close();
            }
            else
                Close();
        }

        private void SetPermitforGuest()
        {
            SoDuToolStripMenuItem.Enabled = false;

            DSPhieuHuyToolStripMenuItem.Visible = false;

            QuanTriToolStripMenuItem.Enabled = false;

            PhieuThuToolStripMenuItem.Enabled = false;

            PhieuChiToolStripMenuItem.Enabled = false;

            đổiMậtKhẩuToolStripMenuItem.Enabled = false;

            dSMãDGToolStripMenuItem.Enabled = false;

            importToolStripMenuItem.Enabled = false;

            exportToolStripMenuItem.Enabled = false;

            btt_TinhTon.Enabled = false;

            bttKetChuyen.Enabled = false;

            BaoCaoThangToolStripMenu.Enabled = true;

            báoCáoToolStripMenuItem.Enabled = true;

        }

        private void SetPermitforUser()
        {
            SoDuToolStripMenuItem.Enabled = true;

            PhieuThuToolStripMenuItem.Enabled = true;

            PhieuChiToolStripMenuItem.Enabled = true;

            đổiMậtKhẩuToolStripMenuItem.Enabled = true;

            dSMãDGToolStripMenuItem.Enabled = true;

            importToolStripMenuItem.Enabled = true;

            exportToolStripMenuItem.Enabled = true;

            btt_TinhTon.Enabled = true;

            bttKetChuyen.Enabled = true;

            QuanTriToolStripMenuItem.Enabled = false;

            DSPhieuHuyToolStripMenuItem.Visible = false;

            BaoCaoThangToolStripMenu.Enabled = true;

            báoCáoToolStripMenuItem.Enabled = true;
        }


        private void SetPermitforAdmin()
        {
            SoDuToolStripMenuItem.Enabled = false;

            DSPhieuHuyToolStripMenuItem.Visible = true;

            QuanTriToolStripMenuItem.Enabled = true;

            PhieuThuToolStripMenuItem.Enabled = false;

            PhieuChiToolStripMenuItem.Enabled = false;

            đổiMậtKhẩuToolStripMenuItem.Enabled = false;

            dSMãDGToolStripMenuItem.Enabled = false;

            importToolStripMenuItem.Enabled = false;

            exportToolStripMenuItem.Enabled = false;

            btt_TinhTon.Enabled = false;

            bttKetChuyen.Enabled = false;

            BaoCaoThangToolStripMenu.Enabled = false;

            báoCáoToolStripMenuItem.Enabled = false;
        }

        private void ThemDongMangSang()
        {
            DataTable tb = TKThuChiGrid.DataSource as DataTable;

            DateTime ngaythang = new DateTime(calendarCombo1.Value.Year, calendarCombo1.Value.Month, calendarCombo1.Value.Day - 1); ;

            Int64 sodukytruoc = _sd_BUS.get_So_Du_Theo_Ngay(ngaythang);

        
            DataRow row = tb.NewRow();
            row["DienGiai"] = "Mang Sang";
            row["Soton"] = sodukytruoc.ToString();



            tb.Rows.InsertAt(row, 0);

            

            //Janus.Windows.GridEX.GridEXRow Gridrow = TKThuChiGrid.GetRow(0);

            //Janus.Windows.GridEX.GridEXCell cell = Gridrow.Cells["ngaythang"];
            //Janus.Windows.GridEX.GridEXFormatStyle style = new Janus.Windows.GridEX.GridEXFormatStyle();
            //cell.FormatStyle = style;

            //cell.FormatStyle.Appearance = Janus.Windows.GridEX.Appearance.Flat;
            //cell.FormatStyle.BackColor = Color.WhiteSmoke;

            //cell = Gridrow.Cells["diengiai"];

            //cell.FormatStyle = style;

            //cell.FormatStyle.BackColor = Color.WhiteSmoke;

            //cell = Gridrow.Cells["sotienchi"];

            //cell.FormatStyle = style;

            //cell.FormatStyle.BackColor = Color.WhiteSmoke;

            //cell = Gridrow.Cells["sotienthu"];

            //cell.FormatStyle = style;

            //cell.FormatStyle.BackColor = Color.WhiteSmoke;

            //cell = Gridrow.Cells["maphieuthu"];

            //cell.FormatStyle = style;

            //cell.FormatStyle.BackColor = Color.WhiteSmoke;

            //cell = Gridrow.Cells["maphieuchi"];

            //cell.FormatStyle = style;

            //cell.FormatStyle.BackColor = Color.WhiteSmoke;

            //cell = Gridrow.Cells["diengiai"];

            //cell.FormatStyle = style;

            //cell.FormatStyle.BackColor = Color.WhiteSmoke;

            //cell = Gridrow.Cells["soton"];

            //cell.FormatStyle = style;

            //cell.FormatStyle.BackColor = Color.WhiteSmoke;
        }

        private void ThemDongTongCong(int tongthu, int tongchi)
        {
            DataTable tb = TKThuChiGrid.DataSource as DataTable;

            //MessageBox.Show(tb.Rows.Count.ToString());

            DateTime ngaythang = new DateTime(calendarCombo1.Value.Year, calendarCombo1.Value.Month, calendarCombo1.Value.Day - 1); ;


            Int64 sodukytruoc = _sd_BUS.get_So_Du_Theo_Ngay(ngaythang);

            DataRow row = tb.NewRow();
            row["DienGiai"] = "Tæng Céng";
            row["sotienthu"] = tongthu.ToString();

            row["sotienchi"] = tongchi.ToString();

            row["soton"] = tb.Rows[tb.Rows.Count-1]["soton"];

            tb.Rows.InsertAt(row, tb.Rows.Count);

            Cap_Nhat_So_Du(int.Parse(row["soton"].ToString()));
        }


        private void TKThuChiGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //bttHuy.Enabled = true;
            //bttCapnhat.Enabled = true;
            //bttThuchien.Enabled = false;
            
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dSMãDGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_DienGiai frm_dg = new Form_DienGiai();

            frm_dg.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void THEM_Click(object sender, EventArgs e)
        {
            //THEM.Text = "Ok";
            //DienGiai_BUS dg_BUS = new DienGiai_BUS();
            //MaDG_Combo.DataSource=dg_BUS.GetDSDG();
            //THEM.Text = "Lập phiếu";
            
        }

        private void ribbonClientPanel1_Click(object sender, EventArgs e)
        {

        }

      

        private void SoTienChu_InputInt_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TKThuChiGrid_Click(object sender, EventArgs e)
        {
            //if (TKThuChiGrid.SelectedRows.Count == 1)
            //{
            //    DataGridViewRow myrow = TKThuChiGrid.SelectedRows[0];
            //    if (myrow.Cells["maso"].Value != null)
            //    {
            //        if (myrow.Cells["slpchi"].Value.ToString() != "")
            //            SoPhieuChi_Inputint.Text = myrow.Cells["slpchi"].Value.ToString();
            //        if (myrow.Cells["slpthu"].Value.ToString()!="")
            //            SoPhieuThu_InputInt.Text = myrow.Cells["slpthu"].Value.ToString();
            //        if (myrow.Cells["SlTienThu"].Value.ToString() != "")
            //            SoTienthu_InputInt.Text = myrow.Cells["SlTienThu"].Value.ToString();
            //        if (myrow.Cells["SlTienChi"].Value.ToString() != "")
            //            SoTienChi_InputInt.Text = myrow.Cells["sltienchi"].Value.ToString();
            //    }

            //}
        }

        

        

        private void PhieuThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_LapPhieuThu frm = new Frm_LapPhieuThu();
            frm.Show();
        }

        private void PhieuChiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_LapPhieuChi frm = new Frm_LapPhieuChi();
            frm.Show();
        }

        private void TKThuChiGrid_FormattingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        {

        }

        private void calendarCombo1_ValueChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            TKThuChiGrid.DataSource = tk_bus.GetDSTK_ThuChi_TheoNgay(calendarCombo1.Value);

            if (TKThuChiGrid.RowCount == 0)
            {
                errorProvider1.SetError(bttKetChuyen, "Luu y nho' bam ket chuyen!");
                bttKetChuyen.ForeColor = Color.Red;
            }
            else
            {
                bttKetChuyen.ForeColor = Color.WhiteSmoke;
            }


            DateTime ngaythangkytruoc = new DateTime(calendarCombo1.Value.AddDays(-1).Year, calendarCombo1.Value.AddDays(-1).Month, calendarCombo1.Value.AddDays(-1).Day); ;

            Int64 sodukytruoc = _sd_BUS.get_So_Du_Theo_Ngay(ngaythangkytruoc);

            Int64 sothukytruoc = _sd_BUS.get_So_Thu_Theo_Ngay(ngaythangkytruoc);

            Int64 sochikytruoc = _sd_BUS.get_So_Chi_Theo_Ngay(ngaythangkytruoc);

            intSoDu.Text = sodukytruoc.ToString();

            intSoChi.Text = sochikytruoc.ToString();

            intSoThu.Text = sothukytruoc.ToString();
            //ThemDongMangSang();

            if (tk_bus.KT_PhatSinh(calendarCombo1.Value) > 0 && _user_DTO.IsAdmin!= -1)
            {
                bttKetChuyen.Enabled = false;
                btt_TinhTon.Enabled = true;
                //    bttKetChuyen.ForeColor = Color.WhiteSmoke;
            }
            else
            {
                if (_user_DTO.IsAdmin != -1)
                {
                    bttKetChuyen.Enabled = true;

                    btt_TinhTon.Enabled = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
       

            
        }

     

        private void btt_TinhTon_Click(object sender, EventArgs e)
        {
            TinhTon();
          

            //ThemDongTongCong(tongthu, tongchi);
        }

        void Cap_Nhat_So_Du(Int64 sodu)
        {
            
            if (_sd_BUS.kt_ton_tai_so_Du_Theo_Ngay(calendarCombo1.Value,sodu) == 0)
            {
                if(_sd_BUS.ThemSoDu(calendarCombo1.Value,sodu)!=1)
                {
                    MessageBox.Show("Thêm mới thất bại!!");
                }
            }
            else
            {
                if (_sd_BUS.CapNhatSODu(calendarCombo1.Value,sodu) != 1)
                {
                    MessageBox.Show("Cập nhật thất bại!!");
                }
            }

        }

        void Cap_Nhat_So_Thu(Int64 sothu)
        {
            //MessageBox.Show(sothu.ToString());
            if (_sd_BUS.kt_ton_tai_so_Du_Theo_Ngay(calendarCombo1.Value, sothu) == 0)
            {
                if (_sd_BUS.ThemSoThu(calendarCombo1.Value, sothu) != 1)
                {
                    MessageBox.Show("Thêm mới thất bại!!");
                }
            }
            else
            {
                if (_sd_BUS.CapNhatSOThu(calendarCombo1.Value, sothu) != 1)
                {
                    MessageBox.Show("Cập nhật thất bại!!");
                }
            }

        }

        void Cap_Nhat_So_Chi(Int64 sochi)
        {
            //MessageBox.Show(sochi.ToString());
            if (_sd_BUS.kt_ton_tai_so_Du_Theo_Ngay(calendarCombo1.Value, sochi) == 0)
            {
                if (_sd_BUS.ThemSoChi(calendarCombo1.Value, sochi) != 1)
                {
                    MessageBox.Show("Thêm mới thất bại!!");
                }
            }
            else
            {
                if (_sd_BUS.CapNhatSOChi(calendarCombo1.Value, sochi) != 1)
                {
                    MessageBox.Show("Cập nhật thất bại!!");
                }
            }

        }
        private void TinhTon()
        {
            DataTable tb = new DataTable();

            tb = TKThuChiGrid.DataSource as DataTable;

            DataRow temp = tb.Rows[0];

            Int64 sotienthu;
            Int64 sotienchi;

            if (temp["sotienTHu"].ToString() != "")
            {
                sotienthu = Int64.Parse(decimal.Parse(temp["sotienTHu"].ToString()).ToString("0.#"));
            }
            else
                sotienthu = 0;

            if (temp["sotienchi"].ToString() != "" )
            {
                sotienchi = Int64.Parse(decimal.Parse(temp["sotienchi"].ToString()).ToString("0.#"));
            }
            else
                sotienchi = 0;

            //MessageBox.Show(intSoDu.Value.ToString());

            Int64 sodukytruoc = int.Parse(intSoDu.Value.ToString());

            tongthu = sotienthu;

            tongchi = sotienchi;

           
         

            temp["SOTON"] = sodukytruoc + sotienthu - sotienchi;

            if (int.Parse(temp["maloaiphieu"].ToString()) == 1)
                tk_bus.Cap_Nhat_SO_Ton_Phieu_Thu(int.Parse(temp["maphieuthu"].ToString()), sodukytruoc + sotienthu - sotienchi);

            if (int.Parse(temp["maloaiphieu"].ToString()) == 2)
                tk_bus.Cap_Nhat_SO_Ton_Phieu_Chi(int.Parse(temp["maphieuchi"].ToString()), sodukytruoc + sotienthu - sotienchi);


            for (int i = 1; i < tb.Rows.Count; i++)
            {
                temp = tb.Rows[i];

                if (temp["sotienTHu"].ToString() != "")
                {
                    //MessageBox.Show(temp["sotienTHu"].ToString());
                    sotienthu = Int64.Parse(decimal.Parse(temp["sotienTHu"].ToString()).ToString("0.#"));
                }
                else
                    sotienthu = 0;

                if (temp["sotienchi"].ToString() != "")
                {
                    sotienchi = Int64.Parse(decimal.Parse(temp["sotienchi"].ToString()).ToString("0.#"));
                }
                else
                    sotienchi = 0;

                sodukytruoc = Int64.Parse(tb.Rows[i - 1]["soTON"].ToString());

            


                temp["SOTON"] = sodukytruoc + sotienthu - sotienchi;
                if (int.Parse(temp["maloaiphieu"].ToString()) == 1)
                    tk_bus.Cap_Nhat_SO_Ton_Phieu_Thu(int.Parse(temp["maphieuthu"].ToString()), sodukytruoc + sotienthu - sotienchi);

                if (int.Parse(temp["maloaiphieu"].ToString()) == 2)
                    tk_bus.Cap_Nhat_SO_Ton_Phieu_Chi(int.Parse(temp["maphieuchi"].ToString()), sodukytruoc + sotienthu - sotienchi);


                tongthu += sotienthu;

                tongchi += sotienchi;

                //MessageBox.Show(temp["sotienthu"].ToString() + "," + temp["sotienchi"].ToString());
            }

            tb = TKThuChiGrid.DataSource as DataTable;

            //MessageBox.Show(tb.Rows.Count.ToString());

            Cap_Nhat_So_Du(Int64.Parse(tb.Rows[tb.Rows.Count - 1]["soton"].ToString()));

            
            Cap_Nhat_So_Chi(tongchi);

            Cap_Nhat_So_Thu(tongthu);

            MessageBoxEx.Show("Hoàn tất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void TKThuChiGrid_DoubleClick(object sender, EventArgs e)
        {
            //MessageBox.Show("HI!!");
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBoxEx.Show("Bill Management Sytem Ver 1.5. Copyright @ DucNguyen BHXH Gò Vấp.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void nmrSoDu_Click(object sender, EventArgs e)
        {

        }

        private void bttImport_Click(object sender, EventArgs e)
        {
           
        }


        void LoadReportFromFile(XtraReport report, string filePath)
        {
            if (File.Exists(filePath))
            {
                report.LoadLayout(filePath);
            }
            else
            {
                MessageBoxEx.Show("Không tìm thấy Report!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //private void BaoCaoThangToolStripMenuItem_Click(object sender, EventArgs e)
        //{
            
        //     DateTime ngaythang = new DateTime(calendarCombo1.Value.Year, calendarCombo1.Value.Month, calendarCombo1.Value.Day);

        //    _rp = new XtraReport(, String.Format("{0:0,0}", intSoDu.Text),1,_th_BUS.LayTenCty(),_th_BUS.LayTenCtyChuQuan());

        //    string filepath = Application.StartupPath + "/Repo/BaoCaoNgay.repx";

        //    LoadReportFromFile(_rp, filepath);

        //    if (_ds.Tables.Count >= 1)
        //    {
        //        _ds.Tables.RemoveAt(0);

        //    }

        //    DataTable tb_TongHop = TKThuChiGrid.DataSource as DataTable;


        //    _ds.Tables.Add(tb_TongHop);

        //    _rp.DataSource = _ds.Tables[0];

        //    Frm_PrintDialog frm_rpdlg = new Frm_PrintDialog(_rp);

        //    frm_rpdlg.ShowDialog();
        //}

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream sw = File.Open("d:\\export.xls", FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
            gridEXExporter1.Export(sw);
            MessageBox.Show("Đã xuất file export.xls vào thư mục D!");
        }

        private void bttKetChuyen_Click(object sender, EventArgs e)
        {
            Cap_Nhat_So_Du(intSoDu.Value);

            Cap_Nhat_So_Chi(intSoChi.Value);

            Cap_Nhat_So_Thu(intSoThu.Value);

            MessageBoxEx.Show("Hoàn tất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void TKThuChiGrid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (_user_DTO.IsAdmin == -1)
            {
                MessageBoxEx.Show("Không có quyền sửa thông tin! :", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DataTable tb = new DataTable();

                tb = TKThuChiGrid.DataSource as DataTable;

                DataRow row = tb.Rows[TKThuChiGrid.Row];



                _tk_DTO.Maso = int.Parse(row["stt"].ToString());

                _tk_DTO.DG = row["diengiai"].ToString();

                if (row["Maphieuchi"].ToString() != "")
                    _tk_DTO.Maphieuchi = int.Parse(row["Maphieuchi"].ToString());

                if (row["Maphieuthu"].ToString() != "")
                    _tk_DTO.Maphieuthu = int.Parse(row["Maphieuthu"].ToString());

                if (row["Sotienchi"].ToString() != "")
                    _tk_DTO.TienChi = int.Parse(decimal.Parse(row["sotienchi"].ToString()).ToString("0.#"));

                if (row["Sotienthu"].ToString() != "")
                    _tk_DTO.TienThu = int.Parse(decimal.Parse(row["sotienthu"].ToString()).ToString("0.#"));

                _tk_DTO.Maloaiphieu = int.Parse(row["Maloaiphieu"].ToString());

                _tk_DTO.Ngaythang = DateTime.Parse(row["NgayThang"].ToString());

                Form_ThongtinPhieu frm = new Form_ThongtinPhieu(_tk_DTO);
                DialogResult rs = frm.ShowDialog();
                if (rs == DialogResult.OK)
                {

                    row["stt"] = _tk_DTO.Maso.ToString();

                    row["diengiai"] = _tk_DTO.DG + " ," + _tk_DTO.Hoten + " ," + _tk_DTO.DiaChi;

                    if (_tk_DTO.Maloaiphieu == 2)
                    {
                        row["Maphieuchi"] = _tk_DTO.Maphieuchi;
                    }
                    if (_tk_DTO.Maloaiphieu == 1)
                    {
                        row["Maphieuthu"] = _tk_DTO.Maphieuthu;
                    }
                    if (_tk_DTO.Maloaiphieu == 2)
                    {
                        row["Sotienchi"] = _tk_DTO.TienChi;
                    }
                    if (_tk_DTO.Maloaiphieu == 1)
                    {
                        row["Sotienthu"] = _tk_DTO.TienThu;
                    }
                }
                if (rs == DialogResult.Abort)
                {
                    tb.Rows.Remove(row);
                }
            }
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Info frm = new Form_Info(_user_DTO);

            frm.Show();
        }

        private void BaoCaoThangToolStripMenu_Click(object sender, EventArgs e)
        {
            Frm_BaoCao frm = new Frm_BaoCao();

            frm.ShowDialog();
        }

        private void VaoHeThongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_DangNhap frmDangNhap = new Frm_DangNhap();

            if (frmDangNhap.ShowDialog() == DialogResult.Yes)
            {
                _user_DTO = Frm_DangNhap.Ngdung_DTO;

                if (tk_bus != null)
                {
                    calendarCombo1.Value = DateTime.Now;

                    TKThuChiGrid.DataSource = tk_bus.GetDSTK_ThuChi();

                    //MessageBox.Show(calendarCombo1.Value.Month.ToString());

                    DateTime ngaythang = new DateTime(calendarCombo1.Value.AddDays(-1).Year, calendarCombo1.Value.AddDays(-1).Month, calendarCombo1.Value.AddDays(-1).Day); ;

                    Int64 sodukytruoc = _sd_BUS.get_So_Du_Theo_Ngay(ngaythang);

                    Int64 sothukytruoc = 0;

                    Int64 sochikytruoc = 0;

                    intSoDu.Text = sodukytruoc.ToString();

                    intSoChi.Text = sochikytruoc.ToString();

                    intSoThu.Text = sothukytruoc.ToString();

                    if (_user_DTO.IsAdmin == -1)
                    {
                        SetPermitforGuest();
                    }

                    if (_user_DTO.IsAdmin == 0)
                    {
                        SetPermitforUser();
                    }
                    if (_user_DTO.IsAdmin == 1)
                    {
                        SetPermitforAdmin();
                    }
                    if (tk_bus.KT_PhatSinh(calendarCombo1.Value) > 0)
                    {
                        bttKetChuyen.Enabled = false;
                        btt_TinhTon.Enabled = true;
                        //  bttKetChuyen.ForeColor = Color.WhiteSmoke;

                    }
                    else
                    {
                        bttKetChuyen.Enabled = true;
                        btt_TinhTon.Enabled = false;
                    }
                    //        ThemDongMangSang();
                }
                else
                    Close();
            }
            else
                Close();
        }

        private void QuanTriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_UserList frm = new Form_UserList();

            frm.ShowDialog();
        }

        private void DSPhieuHuyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frrm_DSPhieuHuy frm = new Frrm_DSPhieuHuy();

            frm.ShowDialog();
        }

        private void bttEditreport_Click(object sender, EventArgs e)
        {
            _rp.ShowDesigner();
        }

        private void SoDuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_MangSang frm = new Frm_MangSang();

            frm.ShowDialog();
        }

        private void SOQUYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ImportChungTuThuChi frm = new Frm_ImportChungTuThuChi();

            frm.ShowDialog();
        }

      
      
      
    }
}