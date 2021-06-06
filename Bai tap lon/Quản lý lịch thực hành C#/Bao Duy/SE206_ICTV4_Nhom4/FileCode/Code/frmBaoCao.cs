using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Linq;
namespace DeTai_QuanLySinhVien
{
    public partial class frmBaoCao : DevComponents.DotNetBar.Office2007Form
    {
        public frmBaoCao()
        {
            InitializeComponent();
        }
       
        private void frmBaoCao_Load(object sender, EventArgs e)
        {
           
            // TODO: This line of code loads data into the 'QuanLySinhVienDataSet.SinhVien' table. You can move, or remove it, as needed.
            this.SinhVienTableAdapter.Fill(this.QuanLySinhVienDataSet.SinhVien);
            this.reportViewer1.RefreshReport();
                      
        }  
    }
}