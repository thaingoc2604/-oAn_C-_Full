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
    public partial class frmThongBaoXoaPhongBan : Office2007Form
    {
        string maphongxoa = null;
        public frmThongBaoXoaPhongBan(string maphong)
        {
            InitializeComponent();
            maphongxoa = maphong;
        }

        clsLayPhongBan phongban = new clsLayPhongBan();
        clsLayBangNhanVien nhanvien = new clsLayBangNhanVien();
        clsLayToLamViec to = new clsLayToLamViec();
        DataTable dt = new DataTable();
           
        private void frmThongBaoXoaPhongBan_Load(object sender, EventArgs e)
        {
            cmbPhongBan.DataSource = phongban.LayPhongBanLoaiTruPhongXoa(maphongxoa);
            cmbPhongBan.DisplayMember = "tenphong";
            cmbPhongBan.ValueMember = "maphong";

            dt = to.LayToLamViecTheoPhong(cmbPhongBan.SelectedValue.ToString());
            if (dt.Rows.Count != 0)
            {
                cmbToLamViec.DataSource = dt;
                cmbToLamViec.DisplayMember = "tento";
                cmbToLamViec.ValueMember = "mato";
                cmbToLamViec.Enabled = true;
            }
            else
            {
                cmbToLamViec.Enabled = false;
            }

            dtgNhanVien.DataSource = nhanvien.LayNhanVienTheoPhongBan(maphongxoa);
        }

        public int dachuyen = 0;

        
        private void cmbPhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPhongBan.SelectedValue != null)
            {
                dt = to.LayToLamViecTheoPhong(cmbPhongBan.SelectedValue.ToString());
                if (dt.Rows.Count != 0)
                {
                    cmbToLamViec.DataSource = dt;
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
                    dtgNhanVien.DataSource = nhanvien.LayNhanVienTheoPhongBan(maphongxoa);
                    MessageBoxEx.Show("Bạn đã chuyển nhân viên thành công","Thông Báo");
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
                    dtgNhanVien.DataSource = nhanvien.LayNhanVienTheoPhongBan(maphongxoa);
                    MessageBoxEx.Show("Bạn đã chuyển nhân viên thành công", "Thông Báo");
                    dachuyen = 1;
                    this.Close();
                }
            }
        }

        private void bntTuyChon_Click(object sender, EventArgs e)
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
                    
                    dtgNhanVien.DataSource = nhanvien.LayNhanVienTheoPhongBan(maphongxoa);
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

                    dtgNhanVien.DataSource = nhanvien.LayNhanVienTheoPhongBan(maphongxoa);
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