using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

using BUS;
using DTO;
using System.IO;
using System.Reflection;
using System.Data.OleDb;
using DevComponents.DotNetBar;

namespace Accounting
{
    public partial class Form_DienGiai : Office2007Form
    {
        public Form_DienGiai()
        {
            InitializeComponent();
        }

        private void Form_DienGiai_Load(object sender, EventArgs e)
        {
            DienGiai_BUS dg_bus = new DienGiai_BUS();

            DienGiai_Grid.DataSource = dg_bus.GetDSDG();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void THEM_Click(object sender, EventArgs e)
        {
            if (txtdiengiai.Text != "")
            {
                DienGiai_BUS dg_Bus = new DienGiai_BUS();

                dg_Bus.ThemMaDG("", txtdiengiai.Text);

                MessageBoxEx.Show("Thêm thành công!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);

                DienGiai_Grid.DataSource = dg_Bus.GetDSDG();
            }
            else
            {
               
                errorProvider1.SetError(txtdiengiai, "Chưa nhập lý do!");

            }
            
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            DienGiai_BUS dg_Bus = new DienGiai_BUS();

            if ( txtdiengiai.Text != "" )
            {

                if (dg_Bus.SuaDG(txtmaDG.Text, txtdiengiai.Text) == true)
                {

                    MessageBoxEx.Show("Đã cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DienGiai_Grid.DataSource = dg_Bus.GetDSDG();
                }
                else
                    MessageBoxEx.Show("Cập nhật thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                errorProvider2.SetError(txtdiengiai, "Chưa nhập lý dol!");

            }
         

        }

        private void DienGiai_Grid_Click(object sender, EventArgs e)
        {
            if (DienGiai_Grid.SelectedRows.Count == 1)
            {
                DataGridViewRow myrow = DienGiai_Grid.SelectedRows[0];
                if (myrow.Cells["madg"].Value != null)
                {
                    txtdiengiai.Text = myrow.Cells["diengiai"].Value.ToString();
                    txtmaDG.Text = myrow.Cells["madg"].Value.ToString();
                }

            }
        }

      
       
    }
}