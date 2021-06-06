using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Manager_Fortunes.Controller;

namespace Manager_Fortunes
{
    public partial class frm_NhapCongCu : DevComponents.DotNetBar.Office2007Form
    {
        NhapCongCuControl control = new NhapCongCuControl();
        public frm_NhapCongCu()
        {
            InitializeComponent();
        }

        private void frm_NhapCongCu_Load(object sender, EventArgs e)
        {
            control.HienThiDataGridView(dataGridNhapCongCu,bindingNavigatorNhapCongcu);
        }

        //private void buttonluu_Click(object sender, EventArgs e)
        //{
        //    control.NhapCongCu(this .txtsohoadon,this.txtmacongcu,cmbtencongcu,cmbtennhom,cmbtendonvitinh,txtsoluong,txtnguyengia,nummuckhauhao,numdakhauhao,numconlai,txtnuocsx,txthansudung,cmblydotang,datetimengaytang,dtngaykhauhao,cmbbophansudung,cmbphongban,cmbmucdichsudung,rtxtghichu);
        //}

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
       
    }
}