using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DETAI
{
    public partial class frmtracuutrinhdo : Form
    {
        clsdmchuyenmon cdmcm = new clsdmchuyenmon();
        clsdmtrinhdo cdmtd = new clsdmtrinhdo();
        clsdmngoaingu cdmnn = new clsdmngoaingu();
        public frmtracuutrinhdo()
        {
            InitializeComponent();
            cbodmcm.DataSource = cdmcm.taocombocm();
            cbodmcm.DisplayMember = "TenChuyenMon";
            cbodmcm.ValueMember = "MaChuyenMon";
            cbodmnn.DataSource = cdmnn.taocombonn();
            cbodmnn.DisplayMember = "TenNgoaiNgu";
            cbodmnn.ValueMember = "MaNgoaiNgu";
            cbodmtd.DataSource = cdmtd.taocombotd();
            cbodmtd.DisplayMember = "TenTrinhDo";
            cbodmtd.ValueMember = "MaTrinhDo";

        }

        private void frmtracuutrinhdo_Load(object sender, EventArgs e)
        {

        }
    }
}