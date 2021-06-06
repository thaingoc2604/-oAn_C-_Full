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
    public partial class Frm_MangSang : Office2007Form
    {
        SODu_BUS _sodu_BUS;

        public Frm_MangSang()
        {
            InitializeComponent();

            _sodu_BUS = new SODu_BUS();
        }

        private void Frm_MangSang_Load(object sender, EventArgs e)
        {

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Them_btt_Click(object sender, EventArgs e)
        {
            if (intSoDu.Text != "")
            {
                if (_sodu_BUS.kt_ton_tai_so_Du_Theo_Ngay(calendarCombo1.Value, intSoDu.Value) == 0)
                {
                    errorProvider1.Clear();

                    if (_sodu_BUS.ThemSoDu(calendarCombo1.Value, intSoDu.Value) != 1)
                    {
                        MessageBox.Show("Thêm mới thất bại!!");
                    }
                    else
                    {
                        MessageBoxEx.Show("Đã cập nhật số dư trong ngày " + calendarCombo1.Value.ToShortDateString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Grid_MangSang.DataSource = _sodu_BUS.DsSoTon_Theo_Thang(calendarCombo1.Value.Month, calendarCombo1.Value.Year);

                    }

                }
                else
                {
                    errorProvider1.SetError(calendarCombo1, "Đã phát sinh số dư trong ngày " + calendarCombo1.Value.ToShortDateString());
                }
            
            
            }
            else
            {

                errorProvider1.SetError(intSoDu, "Chưa nhập tiền!");

            }

        }

      

        private void bttBaoCao_Click(object sender, EventArgs e)
        {
            int thang = 0;

            try
            {
                thang = int.Parse(mtxtThang.Text.ToString().Substring(0, 2));
            }
            catch (Exception loi)
            {
                errorProvider1.SetError(mtxtThang, "Phải nhập đúng định dạng MM/yyy");
            }
                
               
            if (thang <= 12 && thang >0)
            {

                DateTime ngaythang = new DateTime(int.Parse(mtxtThang.Text.ToString().Substring(3, 4)), int.Parse(mtxtThang.Text.ToString().Substring(0, 2)), 1);

                errorProvider1.Clear();

                DataTable tb = _sodu_BUS.DsSoTon_Theo_Thang(ngaythang.Month, ngaythang.Year);

                Grid_MangSang.DataSource = tb;
            }
            else
                errorProvider1.SetError(mtxtThang, "Ngày tháng không hợp lệ!");
        }

        private void Frm_MangSang_Activated(object sender, EventArgs e)
        {
            mtxtThang.Focus();
        }

        private void mtxtThang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                bttBaoCao.Focus();
            }
        }

        private void Grid_MangSang_Click(object sender, EventArgs e)
        {
            if (Grid_MangSang.SelectedRows.Count == 1)
            {
                DataGridViewRow myrow = Grid_MangSang.SelectedRows[0];
                if (myrow.Cells["ID"].Value != null)
                {
                    intSoDu.Text = Int64.Parse(decimal.Parse(myrow.Cells["soton"].Value.ToString()).ToString("0.#")).ToString();
                  
                    calendarCombo1.Value = DateTime.Parse(myrow.Cells["ngaythang"].Value.ToString());
                }

            }
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            DienGiai_BUS dg_Bus = new DienGiai_BUS();

            if (intSoDu.Text != "")
            {
                Form_Confirm frm = new Form_Confirm("Bạn có muốn cập nhật?");

                DialogResult rs = frm.ShowDialog();

                if (rs == DialogResult.Yes)
                {
                    if (_sodu_BUS.CapNhatSODu(calendarCombo1.Value, intSoDu.Value) != 1)
                    {
                        MessageBoxEx.Show("Cập nhật thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBoxEx.Show("Đã tạo số dư trong ngày " + calendarCombo1.Value.ToShortDateString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Grid_MangSang.DataSource = _sodu_BUS.DsSoTon_Theo_Thang(calendarCombo1.Value.Month, calendarCombo1.Value.Year);
                    }
                }
           
            }
            else
            {
                errorProvider1.SetError(intSoDu, "Chưa nhập tiền!!");

            }
        }

       
    }
}