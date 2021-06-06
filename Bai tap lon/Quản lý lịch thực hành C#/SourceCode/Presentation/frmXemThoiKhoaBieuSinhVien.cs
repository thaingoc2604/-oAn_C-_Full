﻿using System;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using QuanLyDaoTao.Utilities;
using QuanLyDaoTao.Enums;
using QuanLyDaoTao.Business;

namespace QuanLyDaoTao.Presentation
{
    public partial class frmXemThoiKhoaBieuSinhVien : XtraForm
    {
        public frmXemThoiKhoaBieuSinhVien()
        {
            InitializeComponent();
        }

        private void Set_cmbGiangVien()
        {
            try
            {
                cmbSinhVien.Properties.DataSource = SinhVienBUS.LayDuLieu();
                //neu dang nhap bang quyen sinh vien
                if (StaticClass.User.Quyen == (int)QuyenNguoiDung.SinhVien)
                {
                    xemThoiKhoaBieuSinhVien1.MSSV = StaticClass.User.TenDangNhap.ToUpper();
                    cmbSinhVien.EditValue = StaticClass.User.TenDangNhap.ToUpper();
                    cmbSinhVien.Properties.ReadOnly = true;
                }
                else//dang nhap bang quyen admin
                {
                    cmbSinhVien.Properties.ReadOnly = false;
                    cmbSinhVien.EditValue = cmbSinhVien.Properties.GetDataSourceValue("MSSV", 0);
                    xemThoiKhoaBieuSinhVien1.MSSV = cmbSinhVien.EditValue.ToString();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Set_numHocKy()
        {
            try
            {
                int thang = DateTime.Today.Month;
                if (thang >= 8)//hoc ky 1
                    numHocKy.Value = 1;
                else if (thang >= 1 && thang <= 5)//hoc ky 2
                    numHocKy.Value = 2;
                else
                    numHocKy.Value = 3;
                   
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Set_cmbTuan()
        {
            try
            {
                cmbTuan.Properties.Items.Clear();
                if (numHocKy.Value == 1)
                {
                    for (int i = 8; i <= 12; i++)
                    {
                        DateTime dauThang = new DateTime(dateNamHoc.DateTime.Year, i, 1);
                        List<DateTime> ngayDauTuan = dauThang.GetWeeks();
                        foreach (DateTime d in ngayDauTuan)
                        {
                            cmbTuan.Properties.Items.Add("Từ " + d.ToString("dd/MM/yyyy") + " -- Đến " + d.AddDays(6).ToString("dd/MM/yyyy"));
                        }
                    }
                }
                else if (numHocKy.Value == 2)
                {
                    for (int i = 1; i <= 5; i++)
                    {
                        DateTime dauThang = new DateTime(dateNamHoc.DateTime.Year, i, 1);
                        List<DateTime> ngayDauTuan = dauThang.GetWeeks();
                        foreach (DateTime d in ngayDauTuan)
                        {
                            cmbTuan.Properties.Items.Add("Từ " + d.ToString("dd/MM/yyyy") + " -- Đến " + d.AddDays(6).ToString("dd/MM/yyyy"));
                        }
                    }
                }
                else
                {
                    for (int i = 6; i <= 7; i++)
                    {
                        DateTime dauThang = new DateTime(dateNamHoc.DateTime.Year, i, 1);
                        List<DateTime> ngayDauTuan = dauThang.GetWeeks();
                        foreach (DateTime d in ngayDauTuan)
                        {
                            cmbTuan.Properties.Items.Add("Từ " + d.ToString("dd/MM/yyyy") + " -- Đến " + d.AddDays(6).ToString("dd/MM/yyyy"));
                        }
                    }
                }
                cmbTuan.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void frmThemDeNghi_Load(object sender, EventArgs e)
        {
            try
            {
                //cmbSinhVien
                Set_cmbGiangVien();

                //num Hoc kỳ
                Set_numHocKy();

                //dateNamHoc
                dateNamHoc.DateTime = DateTime.Now;

                //cmbTuan
                Set_cmbTuan();
                DateTime ngayNay = DateTime.Now.GetWeek();
                cmbTuan.SelectedIndex = cmbTuan.Properties.Items.IndexOf("Từ " + ngayNay.ToString("dd/MM/yyyy") + " -- Đến " + ngayNay.AddDays(6).ToString("dd/MM/yyyy"));
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void cmbGiangVien_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                xemThoiKhoaBieuSinhVien1.MSSV = cmbSinhVien.EditValue.ToString();
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void cmbTuan_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                xemThoiKhoaBieuSinhVien1.NgayDauTuan = DateTime.Parse(cmbTuan.SelectedItem.ToString().Substring(3, 10));
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void numHocKy_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Set_cmbTuan();
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }
    }
}