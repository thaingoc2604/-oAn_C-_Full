﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QUANLYHOSONHANVIEN.DataLayer;
using System.Data;

namespace QUANLYHOSONHANVIEN.Controller
{
    public class DanhSachNgheNghiepCtr
    {
        DanhSachNgheNghiepData data = new DanhSachNgheNghiepData();
        public void HienthiDanhSachNgheNghiepDataGridview(System.Windows.Forms.DataGridView dg, string manv)
        {
            System.Windows.Forms.BindingSource bs = new System.Windows.Forms.BindingSource();
            DataTable tbl = data.DANHSACHNGHENGHIEP(manv);
            bs.DataSource = tbl;
            //bn.BindingSource = bs;
            dg.DataSource = bs;
        }
    }
}
