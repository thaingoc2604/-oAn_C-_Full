using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.Windows.Forms;
using System.ServiceProcess;
using DevComponents.DotNetBar;
using Janus.Windows.GridEX.EditControls;

namespace BankManagement
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
            Application.Run(new frmMain());
        }

        public static void ShowMsg(string msg)
        {
            MessageBoxEx.Show(msg, "Quản lý ngân hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ShowMsg(string msg, bool err)
        {
            MessageBoxEx.Show(msg, "Quản lý ngân hàng", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static bool StartSQLService()
        {
            string serviceName = "MSSQLSERVER";
            try
            {
                ServiceController controller = new ServiceController(serviceName);
                if (controller.Status == ServiceControllerStatus.Stopped)
                {
                    controller.Start();
                    controller.WaitForStatus(ServiceControllerStatus.Running);
                }
                return true;
            }
            catch (Exception ex)
            {
                Program.ShowMsg(ex.Message, true);
                return false;
            }
        }

        public static bool RunExe(string path)
        {
            if (File.Exists(path))
            {
                try { Process.Start(path); }
                catch { return false; }
                return true;
            }
            return false;
        }

        public static void Clear(params EditBox[] txts)
        {
            foreach (EditBox txt in txts) txt.Clear();
        }
    }
}