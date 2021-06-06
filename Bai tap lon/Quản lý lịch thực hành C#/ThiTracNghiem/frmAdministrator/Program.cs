using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace frmAdministrator
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
            frmSplash fr = new frmSplash();
            fr.ShowDialog();
            if (fr.DialogResult == DialogResult.OK)
                Application.Run(new frmLogin());
        }
    }
}
