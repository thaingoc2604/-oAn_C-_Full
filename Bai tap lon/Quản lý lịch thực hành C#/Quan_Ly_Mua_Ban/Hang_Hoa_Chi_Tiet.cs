using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Quan_Ly_Mua_Ban.Hang_hoa
{
	/// <summary>
	/// Summary description for Chi_Tiet_K_Hang.
	/// </summary>
	public class Chi_Tiet_Hang_Hoa : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Chi_Tiet_Hang_Hoa()
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
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(40, 144);
			this.button4.Name = "button4";
			this.button4.TabIndex = 5;
			this.button4.Text = "Xóa";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(141, 146);
			this.button3.Name = "button3";
			this.button3.TabIndex = 4;
			this.button3.Text = "Cập nhật";
			// 
			// Chi_Tiet_Hang_Hoa
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 266);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Name = "Chi_Tiet_Hang_Hoa";
			this.Text = "Chi_Tiet_Hang_Hoa";
			this.ResumeLayout(false);

		}
		#endregion
	}
}
