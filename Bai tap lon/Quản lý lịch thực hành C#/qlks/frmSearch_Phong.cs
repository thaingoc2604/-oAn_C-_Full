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
	public class frmSearchPhong : System.Windows.Forms.Form
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		DataTable dtP;
		DataView dv;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGrid dtGrid;
		private System.Windows.Forms.Button cmdTim;
		private System.Windows.Forms.Button cmdThoat;
		private System.Windows.Forms.ComboBox cboLoaiP;
		private System.Windows.Forms.TextBox txtMaP;
		private System.Windows.Forms.CheckBox chkTrong;

		public frmSearchPhong()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            //Download source code tại Sharecode.vn
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			dtP=SqlHelper.ExecuteQuery(
				"pr_list_PhongSearch",
				CommandType.StoredProcedure);

			dv=dtP.DefaultView;
			Load_LoaiP();

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
			this.cboLoaiP = new System.Windows.Forms.ComboBox();
			this.chkTrong = new System.Windows.Forms.CheckBox();
			this.cmdTim = new System.Windows.Forms.Button();
			this.cmdThoat = new System.Windows.Forms.Button();
			this.dtGrid = new System.Windows.Forms.DataGrid();
			this.label3 = new System.Windows.Forms.Label();
			this.txtMaP = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.cboLoaiP);
			this.groupBox2.Controls.Add(this.chkTrong);
			this.groupBox2.Controls.Add(this.cmdTim);
			this.groupBox2.Controls.Add(this.cmdThoat);
			this.groupBox2.Controls.Add(this.dtGrid);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.txtMaP);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox2.Location = new System.Drawing.Point(8, 5);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(456, 331);
			this.groupBox2.TabIndex = 11;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Thông tin cần tìm";
			// 
			// cboLoaiP
			// 
			this.cboLoaiP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboLoaiP.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cboLoaiP.Location = new System.Drawing.Point(106, 48);
			this.cboLoaiP.Name = "cboLoaiP";
			this.cboLoaiP.Size = new System.Drawing.Size(144, 22);
			this.cboLoaiP.TabIndex = 20;
			// 
			// chkTrong
			// 
			this.chkTrong.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.chkTrong.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.chkTrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.chkTrong.Location = new System.Drawing.Point(8, 72);
			this.chkTrong.Name = "chkTrong";
			this.chkTrong.Size = new System.Drawing.Size(112, 16);
			this.chkTrong.TabIndex = 19;
			this.chkTrong.Text = "Phòng trống";
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
			this.dtGrid.CaptionText = "Danh sách phòng thỏa điều kiện";
			this.dtGrid.DataMember = "";
			this.dtGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dtGrid.Location = new System.Drawing.Point(8, 96);
			this.dtGrid.Name = "dtGrid";
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
			this.label3.Text = "Mã số phòng:";
			// 
			// txtMaP
			// 
			this.txtMaP.Location = new System.Drawing.Point(106, 24);
			this.txtMaP.Name = "txtMaP";
			this.txtMaP.Size = new System.Drawing.Size(142, 20);
			this.txtMaP.TabIndex = 10;
			this.txtMaP.Text = "";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 24);
			this.label1.TabIndex = 15;
			this.label1.Text = "Loại phòng:";
			// 
			// frmSearchPhong
			// 
			this.AcceptButton = this.cmdTim;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CancelButton = this.cmdThoat;
			this.ClientSize = new System.Drawing.Size(472, 342);
			this.Controls.Add(this.groupBox2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "frmSearchPhong";
			this.Text = "Tìm kiếm phòng";
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dtGrid)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion
		void Load_LoaiP()
		{
			try
			{
				DataTable dtLoaiP=SqlHelper.ExecuteQuery(
					"pr_list_LoaiPhong",
					CommandType.StoredProcedure);
				cboLoaiP.Items.Add(String.Format("Tất cả loại phòng"));
				if (dtLoaiP.Rows.Count>0)
				{
					foreach (DataRow row in dtLoaiP.Rows)
						cboLoaiP.Items.Add(row["LOAIPHONG"].ToString());
				}
				cboLoaiP.SelectedIndex=0;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		private void cmdTim_Click(object sender, System.EventArgs e)
		{
			string strSQL="";

			if (txtMaP.Text!="")
				strSQL="MaPhong='"+txtMaP.Text.Trim()+"'";
			if (cboLoaiP.Text!="Tất cả loại phòng")
				strSQL=strSQL+" and LoaiPhong='"+cboLoaiP.Text+"'";
			if (chkTrong.Checked)
				strSQL=strSQL+" and TinhTrangTrong='1'";
			else
				strSQL=strSQL+" and TinhTrangTrong='0'";
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
