using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace Quanlydoanvien
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }
        private void Welcome_Load(object sender, EventArgs e)
        {
            try
            {
                timer1.Enabled = true;
                timer1.Interval = 100;
            }
            catch (Exception)
            {
                MessageBoxEx.Show("Không tìm thấy sự có mặt của NetFramework 2.0 hoặc 3.5 và cũng có thể file DevComponents.DotNetBar2.dll 8.3.7 bị mất(trong thư mục cài đặt)!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                      
        }
        
        private void buttonX1_Click(object sender, EventArgs e)
        {            
                      
        }
        int z;
        frmLogin dn = new frmLogin();
        private void timer1_Tick(object sender, EventArgs e)
        {
              
            z += 1;
            if (z > 40)
            {
                for (int i = 0; i < 100; i++)
                {
                   
                   
                  
                }            
                this.timer1.Enabled = false;
                dn.Show();
                this.Hide();              
                return;
                
            }                  
            
        }      
        
    }
}