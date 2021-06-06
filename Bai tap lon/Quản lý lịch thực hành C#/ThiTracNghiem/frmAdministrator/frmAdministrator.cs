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
    public partial class frmAdministrator : Form
    {
        public frmAdministrator()
        {
            InitializeComponent();
        }
        System.Windows.Forms.ToolTip tt = new System.Windows.Forms.ToolTip();
        private void frmAdministrator_Load(object sender, EventArgs e)
        {
            this.tt.ToolTipTitle = this.Text;
            this.tt.ForeColor = Color.Lime;
            this.tt.BackColor = Color.Black;

        }

        private void btnThuVien_Click(object sender, EventArgs e)
        {
            frmThuVien frmtv = new frmThuVien();
            frmtv.ShowDialog(this);
        }

        private void btnTaoDe_Click(object sender, EventArgs e)
        {
            frmTaoDeThi frmtd = new frmTaoDeThi();
            frmtd.ShowDialog(this);
        }

        private void btnTacGia_Click(object sender, EventArgs e)
        {
            frmAbout frmab = new frmAbout();
            frmab.ShowDialog(this);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có chắc là bạn muốn thoát ?", "Thông Báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
                this.Close();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLogin frlg = new frmLogin();
            this.Hide();
            frlg.Show();
        }
        #region Xử lý hiện Tooltip trên các Button chức năng
            private void btnThuVien_MouseHover(object sender, EventArgs e)
            {
                this.tt.Show("Mở thư viên câu hỏi từ database", this.btnThuVien, new Point(1, -67));
            }

            private void btnThuVien_MouseLeave(object sender, EventArgs e)
            {
                this.tt.Hide(this.btnThuVien);
            }

            private void btnTaoDe_MouseHover(object sender, EventArgs e)
            {
                this.tt.Show("Mở cửa sổ tạo bộ đề thi !", this.btnTaoDe, new Point(1, -67));
            }

            private void btnTaoDe_MouseLeave(object sender, EventArgs e)
            {
                this.tt.Hide(this.btnTaoDe);
            }

            private void btnTacGia_MouseHover(object sender, EventArgs e)
            {
                this.tt.Show("Giớ thiệu tác giả chương trình !", this.btnTacGia, new Point(1, -67));
            }

            private void btnTacGia_MouseLeave(object sender, EventArgs e)
            {
                this.tt.Hide(this.btnTacGia);
            }

            private void btnExit_MouseHover(object sender, EventArgs e)
            {
                this.tt.Show("Thoát chương trình !", this.btnExit, new Point(1, -67));
            }

            private void btnExit_MouseLeave(object sender, EventArgs e)
            {
                this.tt.Hide(this.btnExit);
            }
        #endregion

            
         
    }
}
