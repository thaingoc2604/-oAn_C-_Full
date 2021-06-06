using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace FullPrg
{
    public partial class frmsoft : Form
    {
        public frmsoft()
        {
            InitializeComponent();
        }
        public void buzz(int rate)
        {
            // vị trí lúc đầu của Form
            int _locationX = this.Location.X;
            int _locationY = this.Location.Y;

            for (int i = 0; i < rate; i++)
            {
                this.Location = new Point(_locationX + 5, _locationY + 5);
                System.Threading.Thread.Sleep(50);
                this.Location = new Point(_locationX + 10, _locationY + 10);
                System.Threading.Thread.Sleep(50);
                this.Location = new Point(_locationX + 7, _locationY + 3);
                System.Threading.Thread.Sleep(50);
                this.Location = new Point(_locationX, _locationY);

            }
        }
        private void frmsoft_Load(object sender, EventArgs e)
        {
            //ProgressBar progressBar1 = new ProgressBar();
            //progressBar1.Maximum = 60;
            //for (int i = 0; i < progressBar1.Maximum; i++)
            //{
            //    progressBar1.Value++;
            //    Thread.Sleep(100);
            //    int itime = 5;
            //    label1.Left = itime;
            //    //thread.sleep
            //    itime = itime + 10; //cái này mình khai báo nha
            //    Application.DoEvents();
            //}   

            buzz(6);
            timer1.Start();
            this.TransparencyKey = this.BackColor;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //this.Opacity -= 0.05;
            //if (this.Opacity == 10)
            //{
            //    Application.Exit();
            //}
        }

        private void frmsoft_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.timer2.Enabled = true;
            ////  Application.Exit();

            //e.Cancel = true;
            //if (this.Opacity == 10)
            //{
            //    Application.Exit();
            //}
          //  buzz(6);
        }
        const int STEP = 15;
        bool flag = false;
        private void timer3_Tick(object sender, EventArgs e)
        {
     
     
           if (flag)
            label1.Left+=STEP;
           else 
            label1.Left-=STEP;            

          if (label1.Left<=0) 
             flag=true;
              //label1
              //Form
          else if (label1.Left + label1.Width >= this.Width)
            flag=false;
      
            
       
        }

        private void frmsoft_MouseHover(object sender, EventArgs e)
        {
            this.Opacity = 56;

        }
    }
}
