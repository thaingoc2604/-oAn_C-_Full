using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Manager_Fortunes.PresentationLayer;

namespace Manager_Fortunes
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
         //   Application.Run(new MainForm_Manager());
           Application.Run(new frm_NhapCongCu());
         //   Application.Run(new frm_SuaCongCu());
          //  Application.Run(new frm_DatMuaCongCu());
        }
    }
}