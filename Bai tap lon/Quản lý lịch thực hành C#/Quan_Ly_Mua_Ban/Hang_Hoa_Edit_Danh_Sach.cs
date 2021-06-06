using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Quan_Ly_Mua_Ban.Hang_hoa
{
	/// <summary>
	/// Summary description for Edit_Danh_Sach.
	/// </summary>
	public class Edit_Danh_Sach_Hang_Hoa : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Edit_Danh_Sach_Hang_Hoa()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(24, 16);
			this.button1.Name = "button1";
			this.button1.TabIndex = 0;
			this.button1.Text = "Thêm";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(109, 122);
			this.button2.Name = "button2";
			this.button2.TabIndex = 1;
			this.button2.Text = "Sửa";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(200, 80);
			this.button3.Name = "button3";
			this.button3.TabIndex = 2;
			this.button3.Text = "Lưu";
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(136, 32);
			this.button4.Name = "button4";
			this.button4.TabIndex = 3;
			this.button4.Text = "Xóa";
			// 
			// Edit_Danh_Sach_Hang_Hoa
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 266);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Name = "Edit_Danh_Sach_Hang_Hoa";
			this.Text = "Edit_Danh_Sach_Hang_Hoa";
			this.ResumeLayout(false);

		}
		#endregion
	}
}
