using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Manager_Fortunes.Controller;

namespace Manager_Fortunes.PresentationLayer
{
    public partial class frm_SuaCongCu : DevComponents.DotNetBar.Office2007Form
    {
        NhapCongCuControl control = new NhapCongCuControl();
        public frm_SuaCongCu()
        {
            InitializeComponent();
        }

        private void timMacongcu_Click(object sender, EventArgs e)
        {

        }

        private void timTencongcu_Click(object sender, EventArgs e)
        {

        }

        private void frm_SuaCongCu_Load(object sender, EventArgs e)
        {
            control.HienThiDataGridView(dataGridsuacongcu,bindingsuacongcu);
        }

        private void toolStripthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
       
       
    }
}