using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DTO;

namespace DoAn_K32
{
    public partial class dmXemLich : DevExpress.XtraEditors.XtraUserControl
    {
        public dmXemLich()
        {
            InitializeComponent();
        }
        private LichHocTuan Lich;

        private void ViewLich(LichHocTuan lich)
        {
            string t2 = "";
            string t3 = "";
            string t4 = "";
            string t5 = "";
            string t6 = "";
            string t7 = "";
            string cn = "";
            foreach (LichThu li in lich.T2)
            {
                t2 += li;
                t2 += "\n------------------------\n";
            }
            foreach (LichThu li in lich.T3)
            {
                t3 += li;
                t3 += "\n------------------------\n";
            }
            foreach (LichThu li in lich.T4)
            {
                t4 += li;
                t4 += "\n------------------------\n";
            }
            foreach (LichThu li in lich.T5)
            {
                t5 += li;
                t5 += "\n------------------------\n";
            }
            foreach (LichThu li in lich.T6)
            {
                t6 += li;
                t6 += "\n------------------------\n";
            }
            foreach (LichThu li in lich.T7)
            {
                t7 += li;
                t7 += "\n------------------------\n";
            }
            foreach (LichThu li in lich.CN)
            {
                cn += li;
                cn += "\n------------------------\n";
            }
            lbThu2.Text = t2;
            lbThu3.Text = t3;
            lbThu4.Text = t4;
            lbThu5.Text = t5;
            lbThu6.Text = t6;
            lbThu7.Text = t7;
            lbChuNhat.Text = cn;
        }


        
        private void btnXem_Click(object sender, EventArgs e)
        {
            Lich = BussinessLayer.LichBus.LoadLich(this.cbbLop.Text, int.Parse(this.cbbTuan.Text));
            ViewLich(Lich);
            //DateTime first = Lich.Ngay;
            //DateTime last = Day(first)+6;
            
            grLichTuan.Text ="Lich thực hành lớp "+cbbLop.Text+" - "+ Lich.Ngay.ToShortDateString();
        }
    }
}
