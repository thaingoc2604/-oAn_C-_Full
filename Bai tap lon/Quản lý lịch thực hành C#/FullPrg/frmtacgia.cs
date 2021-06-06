using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace FullPrg
{
    public partial class frmtacgia : Form
    {
        public frmtacgia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát không ?", "Thoát ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                this.Close();//this close
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //tao so ngau nhien
            Random r = new Random();
            //tao doi tuong ve tren form
            Graphics g = this.CreateGraphics();
            //tao doi tuong font
            Font f = new Font("Arial", 20);
            //tao d
            Brush brush = new LinearGradientBrush(new Point(0, 150), new Point(800, 150), Color.Red, Color.Yellow);

            Brush brush2 = new LinearGradientBrush(new Point(0, 0), new Point(80, 590), Color.Blue, Color.RosyBrown);
            Brush brush3 = new LinearGradientBrush(new Point(0, 0), new Point(80, 590), Color.Blue, Color.RosyBrown);

            //to mau
            g.FillEllipse(brush, ClientRectangle.Width / 2 - 150, ClientRectangle.Height / 2 - 150, 300, 300);
          //  g.FillEllipse(brush2, ClientRectangle.Width / 2, ClientRectangle.Height / 2 - 75, 150, 50);
          //  g.FillEllipse(brush3, ClientRectangle.Width / 4, ClientRectangle.Height / 2 - 75, 150, 50);

            for (int angle = 0; angle < 360; angle += 26)
            {
                //moi lan chay se la 1 mau ngau nhien
                //nhung can tao so ngau nhien nam ngoai vong lap
                Brush b = new SolidBrush(Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255)));
                //sau khi quay xong se tra lai vi tri cua hinh
                g.ResetTransform();
                //dat tam de xoay
                g.TranslateTransform(ClientRectangle.Width / 2, ClientRectangle.Height / 2);
                //goc do de xoay
                g.RotateTransform(angle);
                g.DrawString("                  T    i    n    1  6    g   t", f, b, 0, 0);
            }
        }

        private void frmtacgia_Resize(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(BackColor);
        }

        private void frmtacgia_Load(object sender, EventArgs e)
        {
            timer1.Start();
            this.TransparencyKey = this.BackColor;
        }

        private void frmtacgia_MouseHover(object sender, EventArgs e)
        {
            linkLabel1.Visible = true;

            linkLabel2.Visible = true;

            linkLabel3.Visible = true;

        }

        private void frmtacgia_MouseLeave(object sender, EventArgs e)
        {

            linkLabel1.Visible = false;
            linkLabel2.Visible = false;
            linkLabel3.Visible = false;
        }
    }
}
