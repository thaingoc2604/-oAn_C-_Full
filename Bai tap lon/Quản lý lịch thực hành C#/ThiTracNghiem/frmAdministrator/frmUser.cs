using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace frmAdministrator
{
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }
        ToolTip tt = new ToolTip();
        frmManHinhDen fe = new frmManHinhDen();
        private void btnLamBai_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Title = "Open files | User";
            o.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            o.Filter = "Microstar files (*.mic)|*.mic";
            o.Multiselect = false;
            if (o.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    fe.Show();
                    frmLamBai f = new frmLamBai();
                    f.pa = new frmLamBai.pass(get);
                    f.import(o.FileName);
                    f.ShowDialog(fe);
                }
                catch { };
            }            
        }

        private void get()
        {
            fe.Hide();
        }
        private void frmUser_Load(object sender, EventArgs e)
        {
            this.tt.ToolTipTitle = this.Text;
            this.tt.ForeColor = Color.Lime;
            this.tt.BackColor = Color.Black;
        }

        #region Xử lý hiện Tooltip trên các Button chức năng
        private void btnLamBai_MouseHover(object sender, EventArgs e)
        {
            this.tt.Show("Mở đề thi đã được soạn sẵn", this.btnLamBai, new Point(1, -67));
        }

        private void btnLamBai_MouseLeave(object sender, EventArgs e)
        {
            this.tt.Hide(this.btnLamBai);
        }

        private void btnThoat_MouseHover(object sender, EventArgs e)
        {
            this.tt.Show("Thoát khỏi form làm bài", this.btnLamBai, new Point(1, -67));
        }

        private void btnThoat_MouseLeave(object sender, EventArgs e)
        {
            this.tt.Hide(this.btnThoat);
        }
        #endregion

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();

        }

    }
}
