using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace qlks
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class frmLogin : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button cmdCancel;
		private System.Windows.Forms.Button cmdLogin;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtUserName;
		private System.Windows.Forms.TextBox txtPassWord;
		private System.Windows.Forms.Label label2;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmLogin()
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
				if (components != null) 
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
			this.cmdCancel = new System.Windows.Forms.Button();
			this.cmdLogin = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.txtPassWord = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// cmdCancel
			// 
			this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmdCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmdCancel.Location = new System.Drawing.Point(144, 104);
			this.cmdCancel.Name = "cmdCancel";
			this.cmdCancel.Size = new System.Drawing.Size(80, 24);
			this.cmdCancel.TabIndex = 3;
			this.cmdCancel.Text = "Thoát";
			this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
			// 
			// cmdLogin
			// 
			this.cmdLogin.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmdLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmdLogin.Location = new System.Drawing.Point(40, 104);
			this.cmdLogin.Name = "cmdLogin";
			this.cmdLogin.Size = new System.Drawing.Size(80, 24);
			this.cmdLogin.TabIndex = 2;
			this.cmdLogin.Text = "Đăng nhập";
			this.cmdLogin.Click += new System.EventHandler(this.cmdLogin_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtUserName);
			this.groupBox1.Controls.Add(this.txtPassWord);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Location = new System.Drawing.Point(8, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(240, 88);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(16, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 24);
			this.label1.TabIndex = 5;
			this.label1.Text = "Mã số NV:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtUserName
			// 
			this.txtUserName.Location = new System.Drawing.Point(88, 24);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(144, 20);
			this.txtUserName.TabIndex = 0;
			this.txtUserName.Text = "";
			// 
			// txtPassWord
			// 
			this.txtPassWord.Location = new System.Drawing.Point(88, 56);
			this.txtPassWord.Name = "txtPassWord";
			this.txtPassWord.PasswordChar = '*';
			this.txtPassWord.Size = new System.Drawing.Size(144, 20);
			this.txtPassWord.TabIndex = 1;
			this.txtPassWord.Text = "";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(16, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 32);
			this.label2.TabIndex = 4;
			this.label2.Text = "Mật khẩu:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// frmLogin
			// 
			this.AcceptButton = this.cmdLogin;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CancelButton = this.cmdCancel;
			this.ClientSize = new System.Drawing.Size(258, 136);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.cmdCancel);
			this.Controls.Add(this.cmdLogin);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Đăng nhập";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>


		private void cmdCancel_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		private void cmdLogin_Click(object sender, System.EventArgs e)
		{
			
			DataTable dtNV = SqlHelper.ExecuteQuery(
					"pr_check_login",
					CommandType.StoredProcedure,
					"@MSNV",txtUserName.Text,"@password",txtPassWord.Text);
			if (dtNV.Rows.Count==0)
			{
				MessageBox.Show("Đăng nhập không hợp lệ!.","Lỗi...");
			}
			else
			{
				frmMain f = new frmMain();
				f.enableFormMain( dtNV.Rows[0]["MSNV"].ToString());
				f.Show();
				this.Close();
			}
		}
	}
}
