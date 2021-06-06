using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AnTCafe
{
    static class Program
    {
        public static string ConnectionString = "Data Source=.;Initial Catalog=CafeManager;Integrated Security=True";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }
    }
}