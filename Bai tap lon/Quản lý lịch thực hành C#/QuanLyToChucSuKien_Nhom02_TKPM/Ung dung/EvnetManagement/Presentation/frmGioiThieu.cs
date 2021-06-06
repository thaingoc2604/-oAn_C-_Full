using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace EventManager.Presentation
{
    public partial class frmGioiThieu : XtraForm
    {
        public frmGioiThieu()
        {
            InitializeComponent();
            labelControl1.Text = string.Format("{0}{1}", labelControl1.Text, GetYearString());
            Timer tmr = new Timer();
            tmr.Interval = 400;
            tmr.Tick += new EventHandler(tmr_Tick);
            tmr.Start();
        }

        int dotCount = 0;
        int soLan = 0;

        void tmr_Tick(object sender, EventArgs e) 
        {
            if(++dotCount > 3) 
                dotCount = 0;
            labelControl2.Text = string.Format("{1}{0}", GetDots(dotCount), "Chờ tý nhá");
            soLan++;
            if (soLan >= 15)
                this.Opacity -= 0.01;
            if (this.Opacity <= 0.7)
                Close();
        }

        string GetDots(int count) 
        {
            string ret = string.Empty;
            for(int i = 0; i < count; i++) ret += ".";
            return ret;
        }

        int GetYearString() 
        {
            int ret = DateTime.Now.Year;
            return (ret < 2014 ? 2014 : ret);
        }
    }
}