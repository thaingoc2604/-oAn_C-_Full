using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GUI_Tier
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            PlashScreen plash = new PlashScreen();
            if (plash.ShowDialog() == DialogResult.OK)
            {
                DangNhap dangnhap = new DangNhap();
                DialogResult rs = dangnhap.ShowDialog();
                if (rs == DialogResult.Yes)
                {
                    Teacher tea = new Teacher();
                    tea.ShowDialog();
                }
                else if (dangnhap.DialogResult == DialogResult.Abort)
                {
                    Admin adm = new Admin();
                    adm.ShowDialog();
                }
                else if (dangnhap.DialogResult == DialogResult.OK)
                {
                    Student stu = new Student();
                    if (stu.ShowDialog() == DialogResult.OK)
                    {
                        LamBai_Thi baithi = new LamBai_Thi();
                        baithi.ShowDialog();
                    }
                }
            }
        }
    }
}
