using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace qlks
{
	/// <summary>
	/// Summary description for frmSearch.
	/// </summary>
	public class frmSearchKH : System.Windows.Forms.Form
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		DataTable dtKH;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtDiaChi;
		private System.Windows.Forms.TextBox txtTen;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtCMND;
		private System.Windows.Forms.DataGrid dtGrid;
		private System.Windows.Forms.Button cmdTim;
		private System.Windows.Forms.Button cmdThoat;
		DataView dv;

		public frmSearchKH()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			dtKH=SqlHelper.ExecuteQuery(
				"pr_list_KHSearch",
				CommandType.StoredProcedure);

			dv=dtKH.DefaultView;

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
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.cmdTim = new System.Windows.Forms.Button();
			this.cmdThoat = new System.Windows.Forms.Button();
			this.dtGrid = new System.Windows.Forms.DataGrid();
			this.label3 = new System.Windows.Forms.Label();
			this.txtDiaChi = new System.Windows.Forms.TextBox();
			this.txtTen = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtCMND = new System.Windows.Forms.TextBox();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.cmdTim);
			this.groupBox2.Controls.Add(this.cmdThoat);
			this.groupBox2.Controls.Add(this.dtGrid);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.txtDiaChi);
			this.groupBox2.Controls.Add(this.txtTen);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.txtCMND);
			this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox2.Location = new System.Drawing.Point(8, 5);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(456, 331);
			this.groupBox2.TabIndex = 11;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Thông tin cần tìm";
			// 
			// cmdTim
			// 
			this.cmdTim.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmdTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmdTim.Location = new System.Drawing.Point(320, 24);
			this.cmdTim.Name = "cmdTim";
			this.cmdTim.TabIndex = 18;
			this.cmdTim.Text = "Tìm";
			this.cmdTim.Click += new System.EventHandler(this.cmdTim_Click);
			// 
			// cmdThoat
			// 
			this.cmdThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cmdThoat.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmdThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmdThoat.Location = new System.Drawing.Point(320, 64);
			this.cmdThoat.Name = "cmdThoat";
			this.cmdThoat.TabIndex = 17;
			this.cmdThoat.Text = "Thoát";
			this.cmdThoat.Click += new System.EventHandler(this.cmdThoat_Click);
			// 
			// dtGrid
			// 
			this.dtGrid.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dtGrid.CaptionBackColor = System.Drawing.Color.FromArgb(((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			this.dtGrid.CaptionForeColor = System.Drawing.SystemColors.ControlText;
			this.dtGrid.CaptionText = "Danh sách khách hàng thỏa điều kiện";
			this.dtGrid.DataMember = "";
			this.dtGrid.GridLineColor = System.Drawing.SystemColors.ControlDark;
			this.dtGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dtGrid.Location = new System.Drawing.Point(8, 96);
			this.dtGrid.Name = "dtGrid";
			this.dtGrid.ParentRowsBackColor = System.Drawing.Color.Black;
			this.dtGrid.ReadOnly = true;
			this.dtGrid.Size = new System.Drawing.Size(440, 224);
			this.dtGrid.TabIndex = 16;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(8, 24);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(96, 24);
			this.label3.TabIndex = 14;
			this.label3.Text = "Tên khách hàng:";
			// 
			// txtDiaChi
			// 
			this.txtDiaChi.Location = new System.Drawing.Point(104, 48);
			this.txtDiaChi.Name = "txtDiaChi";
			this.txtDiaChi.Size = new System.Drawing.Size(168, 20);
			this.txtDiaChi.TabIndex = 12;
			this.txtDiaChi.Text = "";
			// 
			// txtTen
			// 
			this.txtTen.Location = new System.Drawing.Point(104, 24);
			this.txtTen.Name = "txtTen";
			this.txtTen.Size = new System.Drawing.Size(168, 20);
			this.txtTen.TabIndex = 10;
			this.txtTen.Text = "";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 24);
			this.label1.TabIndex = 15;
			this.label1.Text = "Địa chỉ:";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(8, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 24);
			this.label2.TabIndex = 13;
			this.label2.Text = "Số CMND:";
			// 
			// txtCMND
			// 
			this.txtCMND.Location = new System.Drawing.Point(104, 72);
			this.txtCMND.Name = "txtCMND";
			this.txtCMND.Size = new System.Drawing.Size(88, 20);
			this.txtCMND.TabIndex = 11;
			this.txtCMND.Text = "";
			// 
			// frmSearchKH
			// 
			this.AcceptButton = this.cmdTim;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CancelButton = this.cmdThoat;
			this.ClientSize = new System.Drawing.Size(472, 342);
			this.Controls.Add(this.groupBox2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "frmSearchKH";
			this.Text = "Tìm kiếm khách hàng";
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dtGrid)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void cmdTim_Click(object sender, System.EventArgs e)
		{
			string strSQL="";

			if (txtTen.Text!="")
				strSQL="HoTen like '%"+txtTen.Text.Trim()+"%'";
			if (txtCMND.Text!="")
				strSQL=strSQL+" and CMND='"+txtCMND.Text.Trim()+"'";
			if (txtDiaChi.Text!="")
				strSQL=strSQL+" and DiaChi like '"+txtDiaChi.Text.Trim()+"'";
			int n=strSQL.IndexOf("and");
			if (n==1)
				strSQL=strSQL.Substring(n+4);
			dv.RowFilter=strSQL;
			dtGrid.DataSource=dv;
		}

		private void cmdThoat_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}




	}
}
