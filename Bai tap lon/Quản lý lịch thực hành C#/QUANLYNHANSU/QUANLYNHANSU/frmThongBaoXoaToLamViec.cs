using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using QUANLYNHANSU.GetData;

namespace QUANLYNHANSU
{
    public partial class frmThongBaoXoaToLamViec : Office2007Form
    {
        public frmThongBaoXoaToLamViec(string mato)
        {
            InitializeComponent();
            matoxoa = mato;
        }
        clsLayPhongBan phongban = new clsLayPhongBan();
        clsLayToLamViec to = new clsLayToLamViec();
        clsLayBangNhanVien nhanvien = new clsLayBangNhanVien();
        DataTable dtTo = new DataTable();

        public string matoxoa = null;
        public int dachuyen = 0;

        private void frmThongBaoXoaToLamViec_Load(object sender, EventArgs e)
        {
            cmbPhongBan.DataSource = phongban.LayPhongBan();
            cmbPhongBan.DisplayMember = "tenphong";
            cmbPhongBan.ValueMember = "maphong";

            dtTo = to.LayToLamViecTheoPhongLoaiTruToXoa(cmbPhongBan.SelectedValue.ToString(), matoxoa);
            if (dtTo.Rows.Count != 0)
            {
                cmbToLamViec.DataSource = dtTo;
                cmbToLamViec.DisplayMember = "tento";
                cmbToLamViec.ValueMember = "mato";
                cmbToLamViec.Enabled = true;
            }
            else
            {
                cmbToLamViec.Enabled = false;
            }

            dtgNhanVien.DataSource = nhanvien.LayNhanVienTheoTo(matoxoa);
        }

        private void cmbphongban_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPhongBan.SelectedValue != null)
            {
                dtTo = to.LayToLamViecTheoPhongLoaiTruToXoa(cmbPhongBan.SelectedValue.ToString(), matoxoa);
                if (dtTo.Rows.Count != 0)
                {
                    cmbToLamViec.DataSource = dtTo;
                    cmbToLamViec.DisplayMember = "tento";
                    cmbToLamViec.ValueMember = "mato";
                    cmbToLamViec.Enabled = true;
                }
                else
                {
                    cmbToLamViec.Enabled = false;
                }
            }
        }

        private void bntChuyenHet_Click(object sender, EventArgs e)
        {
            if (cmbPhongBan.SelectedValue != null)
            {
                if (cmbToLamViec.SelectedValue != null)
                {
                    string[] manv = new string[10];
                    int stt = 0;
                    for (int i = 0; i < dtgNhanVien.RowCount; i++)
                    {
                        manv[stt] = dtgNhanVien["manv", i].Value.ToString();
                        stt++;
                    }
                    for (int i = 0; i < manv.Length; i++)
                    {
                        if (manv[i] != null)
                            nhanvien.UpdatePhongBanMoi(cmbPhongBan.SelectedValue.ToString(), cmbToLamViec.SelectedValue.ToString(), manv[i]);
                        else
                            break;
                    }
                    dtgNhanVien.DataSource = nhanvien.LayNhanVienTheoTo(matoxoa);
                    MessageBoxEx.Show("Bạn đã chuyển nhân viên thành công", "Thông Báo");
                    dachuyen = 1;
                    this.Close();
                }
                else
                {
                    string[] manv = new string[10];
                    int stt = 0;
                    for (int i = 0; i < dtgNhanVien.RowCount; i++)
                    {
                        manv[stt] = dtgNhanVien["manv", i].Value.ToString();
                        stt++;
                    }
                    for (int i = 0; i < manv.Length; i++)
                    {
                        if (manv[i] != null)
                            nhanvien.UpdatePhongBanMoi(cmbPhongBan.SelectedValue.ToString(), null, manv[i]);
                        else
                            break;
                    }
                    dtgNhanVien.DataSource = nhanvien.LayNhanVienTheoTo(matoxoa);
                    MessageBoxEx.Show("Bạn đã chuyển nhân viên thành công", "Thông Báo");
                    dachuyen = 1;
                    this.Close();
                }
            }
        }

        private void bntChuyenTuyChon_Click(object sender, EventArgs e)
        {
            if (cmbPhongBan.SelectedValue != null)
            {
                if (cmbToLamViec.SelectedValue != null)
                {
                    string[] manv = new string[10];
                    int stt = 0;
                    for (int i = 0; i < dtgNhanVien.SelectedRows.Count; i++)
                    {
                        manv[stt] = dtgNhanVien["manv", dtgNhanVien.SelectedRows[i].Index].Value.ToString();
                        stt++;
                    }
                    for (int i = 0; i < manv.Length; i++)
                    {
                        if (manv[i] != null)
                            nhanvien.UpdatePhongBanMoi(cmbPhongBan.SelectedValue.ToString(), cmbToLamViec.SelectedValue.ToString(), manv[i]);
                        else
                            break;
                    }

                    dtgNhanVien.DataSource = nhanvien.LayNhanVienTheoPhongBan(matoxoa);
                    MessageBoxEx.Show("Bạn đã chuyển nhân viên thành công", "Thông Báo");
                    if (dtgNhanVien.RowCount == 0)
                    {
                        dachuyen = 1;
                        this.Close();
                    }
                }
                else
                {
                    string[] manv = new string[10];
                    int stt = 0;
                    for (int i = 0; i < dtgNhanVien.SelectedRows.Count; i++)
                    {
                        manv[stt] = dtgNhanVien["manv", dtgNhanVien.SelectedRows[i].Index].Value.ToString();
                        stt++;
                    }
                    for (int i = 0; i < manv.Length; i++)
                    {
                        if (manv[i] != null)
                            nhanvien.UpdatePhongBanMoi(cmbPhongBan.SelectedValue.ToString(), null, manv[i]);
                        else
                            break;
                    }

                    dtgNhanVien.DataSource = nhanvien.LayNhanVienTheoPhongBan(matoxoa);
                    MessageBoxEx.Show("Bạn đã chuyển nhân viên thành công", "Thông Báo");
                    if (dtgNhanVien.RowCount == 0)
                    {
                        dachuyen = 1;
                        this.Close();
                    }
                }
            }
        }

        private void bntKoChuyen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}