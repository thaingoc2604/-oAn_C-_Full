using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QUANLYKHACHSAN.Controller;

namespace QUANLYKHACHSAN.UserInterface
{
    public partial class TimPhieuNhan : Form
    {
        public TimPhieuNhan()
        {
            InitializeComponent();
        }

        private void TimPhieuNhan_Load(object sender, EventArgs e)
        {
            PhieuNhanPhongControl ctrl = new PhieuNhanPhongControl();
            ctrl.HienthiComboBoxMaPhieuNhan(cmbTimPhieuNhan);
        }
    }
}