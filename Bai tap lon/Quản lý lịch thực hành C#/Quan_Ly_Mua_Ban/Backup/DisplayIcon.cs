using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;


namespace Quan_Ly_Mua_Ban
{
	public class DisplayIcon
	{
		// Define the system tray icon control.
		private NotifyIcon appIcon = new NotifyIcon();

		// Define the menu.
		private ContextMenu sysTrayMenu = new ContextMenu();
		private MenuItem About = new MenuItem("About us");
		private MenuItem Display = new MenuItem("Help");
		private MenuItem exitApp = new MenuItem("Exit");

		private FileSystemWatcher watch = new FileSystemWatcher();

		public void Start()
		{
			// Configure the system tray icon.
			Icon ico = new Icon("PicIcon.ico");
			appIcon.Icon = ico;
			appIcon.Text = "Quản Lý Bán Hàng Application";

			sysTrayMenu.MenuItems.Add(About);
			sysTrayMenu.MenuItems.Add(Display);
			sysTrayMenu.MenuItems.Add(exitApp);
			appIcon.ContextMenu = sysTrayMenu;

			MoIcon();

			// Hook up the file watcher.
			watch.Path = "c:\\";
			watch.IncludeSubdirectories = true;
			watch.EnableRaisingEvents = true;

			// Attach event handlers.

			About.Click += new EventHandler(AboutUs);
			exitApp.Click += new EventHandler(ExitApp);
			Display.Click += new EventHandler(DisplayPG);

		}
		public void DongIcon()
		{
			appIcon.Visible = false;
		}
		public void MoIcon()
		{
			appIcon.Visible = true;
		}
		private void AboutUs(object sender, System.EventArgs e)
		{			
			frmAbout ab = new frmAbout();
			ab.ShowDialog();
		}
		private void ExitApp(object sender, System.EventArgs e)
		{
		//	sysTrayMenu.MenuItems.Remove();
			appIcon.Dispose();
			Application.Exit();
		}

		private void DisplayPG(object sender, System.EventArgs e)
		{			
			try
			{
				System.Diagnostics.Process a = new System.Diagnostics.Process();
				a.StartInfo.FileName=@"C:\help.chm";
				a.StartInfo.Verb="Open";
				//			a.StartInfo.Arguments=@" "+txtDiaChiHD.Text+" ";
				a.Start();
			}
			catch
			{
				MessageBox.Show("Files help không có ở địa chỉ này!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);									
			}
		}
	}


}
