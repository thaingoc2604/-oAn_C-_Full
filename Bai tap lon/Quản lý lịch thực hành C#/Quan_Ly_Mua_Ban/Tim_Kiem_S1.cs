using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Quan_Ly_Mua_Ban
{
	/// <summary>
	/// Summary description for Tim_Kiem.
	/// </summary>
	public class Tim_Kiem : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button btTim;
		private System.Windows.Forms.Button btHTKH1;
		private System.Windows.Forms.Button btMKH2;
		private System.Windows.Forms.Button btSHD3;
		private System.Windows.Forms.DataGrid dataGrid_Tim;
		private System.Windows.Forms.TextBox txtTim;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Tim_Kiem()
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtTim = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btTim = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.btHTKH1 = new System.Windows.Forms.Button();
			this.btMKH2 = new System.Windows.Forms.Button();
			this.btSHD3 = new System.Windows.Forms.Button();
			this.dataGrid_Tim = new System.Windows.Forms.DataGrid();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid_Tim)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(112, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tìm Kiếm";
			// 
			// txtTim
			// 
			this.txtTim.Location = new System.Drawing.Point(320, 40);
			this.txtTim.Name = "txtTim";
			this.txtTim.Size = new System.Drawing.Size(184, 20);
			this.txtTim.TabIndex = 1;
			this.txtTim.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(96, 72);
			this.label2.Name = "label2";
			this.label2.TabIndex = 3;
			this.label2.Text = "&Mã Khách Hàng";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(96, 104);
			this.label3.Name = "label3";
			this.label3.TabIndex = 4;
			this.label3.Text = "&Số Hợp Đồng:";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(96, 40);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(112, 23);
			this.label4.TabIndex = 5;
			this.label4.Text = "&Họ Tên Khách Hàng:";
			// 
			// btTim
			// 
			this.btTim.Location = new System.Drawing.Point(232, 40);
			this.btTim.Name = "btTim";
			this.btTim.TabIndex = 8;
			this.btTim.Text = "&Tìm";
			this.btTim.Click += new System.EventHandler(this.btTim_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(232, 72);
			this.button2.Name = "button2";
			this.button2.TabIndex = 9;
			this.button2.Text = "&Hủy bỏ";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// btHTKH1
			// 
			this.btHTKH1.Location = new System.Drawing.Point(16, 40);
			this.btHTKH1.Name = "btHTKH1";
			this.btHTKH1.TabIndex = 8;
			this.btHTKH1.Text = "Tìm Theo";
			this.btHTKH1.Click += new System.EventHandler(this.btHTKH1_Click);
			// 
			// btMKH2
			// 
			this.btMKH2.Location = new System.Drawing.Point(16, 72);
			this.btMKH2.Name = "btMKH2";
			this.btMKH2.TabIndex = 8;
			this.btMKH2.Text = "Tìm Theo";
			this.btMKH2.Click += new System.EventHandler(this.btMKH2_Click);
			// 
			// btSHD3
			// 
			this.btSHD3.Location = new System.Drawing.Point(16, 104);
			this.btSHD3.Name = "btSHD3";
			this.btSHD3.TabIndex = 8;
			this.btSHD3.Text = "Tìm Theo";
			this.btSHD3.Click += new System.EventHandler(this.btSHD3_Click);
			// 
			// dataGrid_Tim
			// 
			this.dataGrid_Tim.CaptionText = "Kết quả tìm kiếm";
			this.dataGrid_Tim.DataMember = "";
			this.dataGrid_Tim.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dataGrid_Tim.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid_Tim.Location = new System.Drawing.Point(0, 110);
			this.dataGrid_Tim.Name = "dataGrid_Tim";
			this.dataGrid_Tim.Size = new System.Drawing.Size(632, 192);
			this.dataGrid_Tim.TabIndex = 10;
			// 
			// Tim_Kiem
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(632, 302);
			this.Controls.Add(this.dataGrid_Tim);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.btTim);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtTim);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btHTKH1);
			this.Controls.Add(this.btMKH2);
			this.Controls.Add(this.btSHD3);
			this.Name = "Tim_Kiem";
			this.Text = "Tim_Kiem";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Tim_Kiem_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid_Tim)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion
		connet ket_noi = new connet();
		DataTable dtTenKH = new DataTable();
		DataTable dtMaKH = new DataTable();
		DataTable dtSHD = new DataTable();
		int n=0;
		public void GetString()
		{
			ket_noi.TimString = txtTim.Text;
		}

		public void TimHoTen()
		{
			string sqlTimTen = "exec Stor_TimKiemOFKH @Xet='1',@TenKH='"+txtTim.Text+"'";
			dtTenKH=ket_noi.getDataTable(sqlTimTen);
			dataGrid_Tim.DataSource=dtTenKH;
		}
		public void TimMaKH()
		{
			string sqlTimMaKH = "exec Stor_TimKiemOFKH @Xet='2',@MaKH='"+txtTim.Text+"'";
			dtMaKH=ket_noi.getDataTable(sqlTimMaKH);
			dataGrid_Tim.DataSource=dtMaKH;
		}
		public void TimSoHd()
		{
			string sqlTimSHD = "exec Stor_TimKiemOFKH @Xet='3',@SoHD='"+txtTim.Text+"'";
			dtSHD=ket_noi.getDataTable(sqlTimSHD);
			dataGrid_Tim.DataSource=dtSHD;
		}
		public void TatButton()
		{
			btHTKH1.Enabled=true;
			btMKH2.Enabled=true;
			btSHD3.Enabled=true;
			txtTim.Enabled=true;
			btTim.Enabled=true;
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void btHTKH1_Click(object sender, System.EventArgs e)
		{
			n=1;
			TatButton();
			btHTKH1.Enabled=false;
			
		}

		private void btMKH2_Click(object sender, System.EventArgs e)
		{
			n=2;
			TatButton();
			btMKH2.Enabled=false;
		}

		private void btSHD3_Click(object sender, System.EventArgs e)
		{
			n=3;
			TatButton();
			btSHD3.Enabled=false;
		}

		private void Tim_Kiem_Load(object sender, System.EventArgs e)
		{
			txtTim.Enabled=false;
			btTim.Enabled=false;
		}

		private void btTim_Click(object sender, System.EventArgs e)
		{
			GetString();
			if(n==1)
			{
				TimHoTen();
			}
			if(n==2)
			{
				TimMaKH();
			}
			if(n==3)
			{
				TimSoHd();
			}
		}
	}
}
