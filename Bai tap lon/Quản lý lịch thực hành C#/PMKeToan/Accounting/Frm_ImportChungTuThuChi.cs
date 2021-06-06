using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


using BUS;
using DTO;

namespace Accounting
{
    public partial class Frm_ImportChungTuThuChi : Form
    {
        TKThuChi_BUS _tc_BUS;

        PHIEUCHI_DTO _PhieuChi;

        PHIEUTHU_DTO _PhieuThu;

        PHIEUCHI_BUS _phieuchi_BUS;

        PhieuThu_BUS _phieuthu_BUS;

        string _filename;

        public Frm_ImportChungTuThuChi()
        {
            InitializeComponent();

            _phieuthu_BUS = new PhieuThu_BUS();

            _phieuchi_BUS = new PHIEUCHI_BUS();

            _tc_BUS = new TKThuChi_BUS();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = openFileDialog1.FileName;

                _filename = txtPath.Text;

                DataTable tb = _tc_BUS.LayDanhSachSPExel(_filename);

                tb.Rows.RemoveAt(0);

                dataGridView1.DataSource = tb;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable tb = dataGridView1.DataSource as DataTable;

            for (int i = 0; i < tb.Rows.Count; i++)
            {
                PHIEUTHU_DTO phieuthu_DTO = new PHIEUTHU_DTO();

                PHIEUCHI_DTO phieuchi_DTO = new PHIEUCHI_DTO();

                if (tb.Rows[i]["maphieuchi"].ToString() != "")
                {
                    phieuchi_DTO.Maphieuchi = int.Parse(tb.Rows[i]["maphieuchi"].ToString());
                    phieuchi_DTO.Diachi = tb.Rows[i]["maphieuchi"].ToString();
                    phieuchi_DTO.Maloaiphieu = 2;
                    phieuchi_DTO.Sotien = Int64.Parse(tb.Rows[i]["sotienchi"].ToString());
                    
                    phieuchi_DTO.Ngaylap = DateTime.Parse(tb.Rows[i]["ngaythang"].ToString());
                    phieuchi_DTO.Ton = 0;
                    phieuchi_DTO.Diengiai = tb.Rows[i]["diengiai"].ToString();

                    //MessageBox.Show(phieuchi_DTO.Maphieuchi.ToString());
                    _phieuchi_BUS.LapPhieu(phieuchi_DTO);
                }

                if (tb.Rows[i]["maphieuthu"].ToString() != "")
                {
                    phieuthu_DTO.Maphieuthu = int.Parse(tb.Rows[i]["maphieuthu"].ToString());
                    phieuthu_DTO.Diachi = tb.Rows[i]["maphieuchi"].ToString();
                    phieuthu_DTO.Maloaiphieu = 1;
                    //MessageBox.Show(phieuthu_DTO.Maphieuthu.ToString() + "," + tb.Rows[i]["sotienthu"].ToString());
                    phieuthu_DTO.Sotien = Int64.Parse(tb.Rows[i]["sotienthu"].ToString());
                    phieuthu_DTO.Ngaylap = DateTime.Parse(tb.Rows[i]["ngaythang"].ToString());
                    phieuthu_DTO.Ton = 0;
                    phieuthu_DTO.Diengiai = tb.Rows[i]["diengiai"].ToString();


                    _phieuthu_BUS.LapPhieu(phieuthu_DTO);
                }

             

            }

            MessageBox.Show("Done!!");
        }
    }
}