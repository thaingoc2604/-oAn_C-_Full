using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Accounting
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
          //  if (DAO.DataProvider.ResetConnectionString() != "")
            {
                Application.Run(new Form_Main());
            }
        }
    }
}