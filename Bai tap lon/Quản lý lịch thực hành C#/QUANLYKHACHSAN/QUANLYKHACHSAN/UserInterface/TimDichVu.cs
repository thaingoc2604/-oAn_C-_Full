using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QUANLYKHACHSAN.UserInterface
{
    public partial class TimDichVu : Form
    {
        public TimDichVu()
        {
            InitializeComponent();
        }

        private void TimDichVu_Load(object sender, EventArgs e)
        {
            QUANLYKHACHSAN.Controller.DichVuControl ctrl = new QUANLYKHACHSAN.Controller.DichVuControl();
            ctrl.HienThiCombobox(cmbTimDVu);
        }
    }
}