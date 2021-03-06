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
	/// Summary description for Form2.
	/// </summary>
	public class frmKH : System.Windows.Forms.Form
	{
		#region User Varibles
		string msPhong="", maHDTPhong="";
		int pos=0; bool trang_thai_trong=true;
		#endregion
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button cmdSave;
		private System.Windows.Forms.Button cmdExit;
		private System.Windows.Forms.Button cmdAdd;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ListView lView;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtCMND;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtDChi;
		private System.Windows.Forms.TextBox txtDThoai;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.CheckBox chkVaiTro;
		private System.Windows.Forms.ColumnHeader CMND;
		private System.Windows.Forms.ColumnHeader GT;
		private System.Windows.Forms.ColumnHeader DC;
		private System.Windows.Forms.ColumnHeader DT;
		private System.Windows.Forms.ColumnHeader VAITRO;
		private System.Windows.Forms.DateTimePicker dTPicker_Thue;
		private System.Windows.Forms.DateTimePicker dTPicker_Tra;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Panel panP;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtNV;
		private System.Windows.Forms.RadioButton optNam;
		private System.Windows.Forms.RadioButton optNu;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.GroupBox grpFunction;
		private System.Windows.Forms.Button cmdDeleteNV;
		private System.Windows.Forms.Button cmdEditNV;
		private System.Windows.Forms.Button cmdAddNV;
		private System.Windows.Forms.ColumnHeader MSKH;
		private System.Windows.Forms.TextBox txtTen;
		private System.Windows.Forms.ColumnHeader TENKH;


		private System.ComponentModel.Container components = null;

		public frmKH()
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
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtNV = new System.Windows.Forms.TextBox();
			this.panP = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.dTPicker_Thue = new System.Windows.Forms.DateTimePicker();
			this.dTPicker_Tra = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.grpFunction = new System.Windows.Forms.GroupBox();
			this.cmdDeleteNV = new System.Windows.Forms.Button();
			this.cmdEditNV = new System.Windows.Forms.Button();
			this.cmdAddNV = new System.Windows.Forms.Button();
			this.optNam = new System.Windows.Forms.RadioButton();
			this.optNu = new System.Windows.Forms.RadioButton();
			this.lView = new System.Windows.Forms.ListView();
			this.MSKH = new System.Windows.Forms.ColumnHeader();
			this.CMND = new System.Windows.Forms.ColumnHeader();
			this.GT = new System.Windows.Forms.ColumnHeader();
			this.DC = new System.Windows.Forms.ColumnHeader();
			this.DT = new System.Windows.Forms.ColumnHeader();
			this.VAITRO = new System.Windows.Forms.ColumnHeader();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtCMND = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtDChi = new System.Windows.Forms.TextBox();
			this.txtDThoai = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.chkVaiTro = new System.Windows.Forms.CheckBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtTen = new System.Windows.Forms.TextBox();
			this.cmdSave = new System.Windows.Forms.Button();
			this.cmdExit = new System.Windows.Forms.Button();
			this.cmdAdd = new System.Windows.Forms.Button();
			this.label11 = new System.Windows.Forms.Label();
			this.TENKH = new System.Windows.Forms.ColumnHeader();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.grpFunction.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txtNV);
			this.groupBox2.Controls.Add(this.panP);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.dTPicker_Thue);
			this.groupBox2.Controls.Add(this.dTPicker_Tra);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.groupBox1);
			this.groupBox2.Controls.Add(this.cmdSave);
			this.groupBox2.Controls.Add(this.cmdExit);
			this.groupBox2.Controls.Add(this.cmdAdd);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(8, 8);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(544, 504);
			this.groupBox2.TabIndex = 14;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Hợp đồng thuê phòng";
			// 
			// txtNV
			// 
			this.txtNV.Enabled = false;
			this.txtNV.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtNV.Location = new System.Drawing.Point(16, 64);
			this.txtNV.Name = "txtNV";
			this.txtNV.Size = new System.Drawing.Size(112, 20);
			this.txtNV.TabIndex = 26;
			this.txtNV.Text = "";
			// 
			// panP
			// 
			this.panP.AutoScroll = true;
			this.panP.Location = new System.Drawing.Point(16, 120);
			this.panP.Name = "panP";
			this.panP.Size = new System.Drawing.Size(512, 48);
			this.panP.TabIndex = 25;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(16, 96);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 24);
			this.label1.TabIndex = 24;
			this.label1.Text = "Chọn phòng:";
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.LightGreen;
			this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label9.Location = new System.Drawing.Point(120, 96);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(72, 16);
			this.label9.TabIndex = 22;
			this.label9.Text = "Phòng trống";
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.Red;
			this.label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label10.Location = new System.Drawing.Point(200, 96);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(80, 16);
			this.label10.TabIndex = 23;
			this.label10.Text = "Phòng đã thuê";
			// 
			// dTPicker_Thue
			// 
			this.dTPicker_Thue.CustomFormat = "\"dd mm yyyy\"";
			this.dTPicker_Thue.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dTPicker_Thue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dTPicker_Thue.Location = new System.Drawing.Point(176, 64);
			this.dTPicker_Thue.Name = "dTPicker_Thue";
			this.dTPicker_Thue.Size = new System.Drawing.Size(96, 20);
			this.dTPicker_Thue.TabIndex = 20;
			this.dTPicker_Thue.ValueChanged += new System.EventHandler(this.dTPicker_Thue_ValueChanged);
			// 
			// dTPicker_Tra
			// 
			this.dTPicker_Tra.CustomFormat = "d m yy";
			this.dTPicker_Tra.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dTPicker_Tra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dTPicker_Tra.Location = new System.Drawing.Point(312, 64);
			this.dTPicker_Tra.Name = "dTPicker_Tra";
			this.dTPicker_Tra.Size = new System.Drawing.Size(96, 20);
			this.dTPicker_Tra.TabIndex = 21;
			this.dTPicker_Tra.ValueChanged += new System.EventHandler(this.dTPicker_Tra_ValueChanged);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(176, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 24);
			this.label2.TabIndex = 18;
			this.label2.Text = "Ngày thuê:";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label7.Location = new System.Drawing.Point(312, 40);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(104, 24);
			this.label7.TabIndex = 19;
			this.label7.Text = "Dự kiến ngày trả:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.grpFunction);
			this.groupBox1.Controls.Add(this.optNam);
			this.groupBox1.Controls.Add(this.optNu);
			this.groupBox1.Controls.Add(this.lView);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtCMND);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.txtDChi);
			this.groupBox1.Controls.Add(this.txtDThoai);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.chkVaiTro);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.txtTen);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(8, 176);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(528, 264);
			this.groupBox1.TabIndex = 17;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thông tin khách hàng";
			// 
			// grpFunction
			// 
			this.grpFunction.Controls.Add(this.cmdDeleteNV);
			this.grpFunction.Controls.Add(this.cmdEditNV);
			this.grpFunction.Controls.Add(this.cmdAddNV);
			this.grpFunction.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.grpFunction.Location = new System.Drawing.Point(432, 10);
			this.grpFunction.Name = "grpFunction";
			this.grpFunction.Size = new System.Drawing.Size(88, 104);
			this.grpFunction.TabIndex = 17;
			this.grpFunction.TabStop = false;
			// 
			// cmdDeleteNV
			// 
			this.cmdDeleteNV.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmdDeleteNV.Location = new System.Drawing.Point(8, 74);
			this.cmdDeleteNV.Name = "cmdDeleteNV";
			this.cmdDeleteNV.Size = new System.Drawing.Size(72, 23);
			this.cmdDeleteNV.TabIndex = 2;
			this.cmdDeleteNV.Text = "Xóa";
			this.cmdDeleteNV.Click += new System.EventHandler(this.cmdDeleteNV_Click);
			// 
			// cmdEditNV
			// 
			this.cmdEditNV.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmdEditNV.Location = new System.Drawing.Point(8, 45);
			this.cmdEditNV.Name = "cmdEditNV";
			this.cmdEditNV.Size = new System.Drawing.Size(72, 23);
			this.cmdEditNV.TabIndex = 1;
			this.cmdEditNV.Text = "Sửa";
			this.cmdEditNV.Click += new System.EventHandler(this.cmdEditNV_Click);
			// 
			// cmdAddNV
			// 
			this.cmdAddNV.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmdAddNV.Location = new System.Drawing.Point(8, 16);
			this.cmdAddNV.Name = "cmdAddNV";
			this.cmdAddNV.Size = new System.Drawing.Size(72, 23);
			this.cmdAddNV.TabIndex = 0;
			this.cmdAddNV.Text = "Thêm";
			this.cmdAddNV.Click += new System.EventHandler(this.cmdAddNV_Click);
			// 
			// optNam
			// 
			this.optNam.Checked = true;
			this.optNam.Location = new System.Drawing.Point(80, 88);
			this.optNam.Name = "optNam";
			this.optNam.Size = new System.Drawing.Size(64, 16);
			this.optNam.TabIndex = 15;
			this.optNam.TabStop = true;
			this.optNam.Text = "Nam";
			// 
			// optNu
			// 
			this.optNu.Location = new System.Drawing.Point(152, 88);
			this.optNu.Name = "optNu";
			this.optNu.Size = new System.Drawing.Size(56, 16);
			this.optNu.TabIndex = 16;
			this.optNu.Text = "Nữ";
			// 
			// lView
			// 
			this.lView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																					this.MSKH,
																					this.TENKH,
																					this.CMND,
																					this.GT,
																					this.DC,
																					this.DT,
																					this.VAITRO});
			this.lView.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lView.FullRowSelect = true;
			this.lView.GridLines = true;
			this.lView.Location = new System.Drawing.Point(8, 120);
			this.lView.Name = "lView";
			this.lView.Size = new System.Drawing.Size(512, 136);
			this.lView.TabIndex = 14;
			this.lView.View = System.Windows.Forms.View.Details;
			this.lView.SelectedIndexChanged += new System.EventHandler(this.lView_SelectedIndexChanged);
			// 
			// MSKH
			// 
			this.MSKH.Text = "MSKH";
			this.MSKH.Width = 0;
			// 
			// CMND
			// 
			this.CMND.Text = "CMND";
			this.CMND.Width = 50;
			// 
			// GT
			// 
			this.GT.Text = "Giới tính";
			// 
			// DC
			// 
			this.DC.Text = "Địa chỉ";
			this.DC.Width = 100;
			// 
			// DT
			// 
			this.DT.Text = "Điện thoại";
			this.DT.Width = 68;
			// 
			// VAITRO
			// 
			this.VAITRO.Text = "Trưởng nhóm";
			this.VAITRO.Width = 63;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(16, 24);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 24);
			this.label3.TabIndex = 8;
			this.label3.Text = "Họ tên:";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(256, 24);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(48, 24);
			this.label4.TabIndex = 8;
			this.label4.Text = "CMND:";
			// 
			// txtCMND
			// 
			this.txtCMND.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtCMND.Location = new System.Drawing.Point(320, 24);
			this.txtCMND.Name = "txtCMND";
			this.txtCMND.Size = new System.Drawing.Size(96, 20);
			this.txtCMND.TabIndex = 5;
			this.txtCMND.Text = "";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.Location = new System.Drawing.Point(16, 56);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(48, 24);
			this.label5.TabIndex = 8;
			this.label5.Text = "Địa chỉ:";
			// 
			// txtDChi
			// 
			this.txtDChi.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtDChi.Location = new System.Drawing.Point(80, 56);
			this.txtDChi.Name = "txtDChi";
			this.txtDChi.Size = new System.Drawing.Size(152, 20);
			this.txtDChi.TabIndex = 5;
			this.txtDChi.Text = "";
			// 
			// txtDThoai
			// 
			this.txtDThoai.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtDThoai.Location = new System.Drawing.Point(320, 56);
			this.txtDThoai.Name = "txtDThoai";
			this.txtDThoai.Size = new System.Drawing.Size(96, 20);
			this.txtDThoai.TabIndex = 5;
			this.txtDThoai.Text = "";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.Location = new System.Drawing.Point(256, 56);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(64, 24);
			this.label6.TabIndex = 8;
			this.label6.Text = "Điện thoại:";
			// 
			// chkVaiTro
			// 
			this.chkVaiTro.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.chkVaiTro.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.chkVaiTro.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.chkVaiTro.Location = new System.Drawing.Point(256, 88);
			this.chkVaiTro.Name = "chkVaiTro";
			this.chkVaiTro.Size = new System.Drawing.Size(160, 16);
			this.chkVaiTro.TabIndex = 12;
			this.chkVaiTro.Text = "Trưởng nhóm";
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label8.Location = new System.Drawing.Point(16, 88);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(56, 24);
			this.label8.TabIndex = 8;
			this.label8.Text = "Giới tính:";
			// 
			// txtTen
			// 
			this.txtTen.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtTen.Location = new System.Drawing.Point(80, 24);
			this.txtTen.Name = "txtTen";
			this.txtTen.Size = new System.Drawing.Size(152, 20);
			this.txtTen.TabIndex = 5;
			this.txtTen.Text = "";
			// 
			// cmdSave
			// 
			this.cmdSave.Enabled = false;
			this.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmdSave.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmdSave.Location = new System.Drawing.Point(200, 456);
			this.cmdSave.Name = "cmdSave";
			this.cmdSave.Size = new System.Drawing.Size(176, 40);
			this.cmdSave.TabIndex = 16;
			this.cmdSave.Text = "Đăng ký thuê";
			this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
			// 
			// cmdExit
			// 
			this.cmdExit.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmdExit.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmdExit.Location = new System.Drawing.Point(392, 456);
			this.cmdExit.Name = "cmdExit";
			this.cmdExit.Size = new System.Drawing.Size(136, 40);
			this.cmdExit.TabIndex = 15;
			this.cmdExit.Text = "Thoát";
			this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
			// 
			// cmdAdd
			// 
			this.cmdAdd.Enabled = false;
			this.cmdAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmdAdd.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmdAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdAdd.Location = new System.Drawing.Point(16, 456);
			this.cmdAdd.Name = "cmdAdd";
			this.cmdAdd.Size = new System.Drawing.Size(160, 40);
			this.cmdAdd.TabIndex = 14;
			this.cmdAdd.Text = "Thêm vào danh sách";
			this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label11.Location = new System.Drawing.Point(16, 40);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(104, 24);
			this.label11.TabIndex = 18;
			this.label11.Text = "Nhân viên lập:";
			// 
			// TENKH
			// 
			this.TENKH.Text = "Tên";
			// 
			// frmKH
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(562, 520);
			this.Controls.Add(this.groupBox2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "frmKH";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Nhận khách hàng";
			this.Load += new System.EventHandler(this.frmPhong_Load);
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.grpFunction.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion
		void Load_Phong()
		{
			DataTable dt=SqlHelper.ExecuteQuery("pr_list_Phong",
				CommandType.StoredProcedure);
			panP.Controls.Clear();
			int i=0;
			foreach (DataRow row in dt.Rows)
			{
				Label lb=new Label();
				lb.Location=new Point(i*49,0);
				lb.Click+=new EventHandler(lb_Click);
				lb.Height=panP.Height-20;
				lb.Width=50;
				lb.TextAlign=ContentAlignment.MiddleCenter;
				lb.BorderStyle=BorderStyle.FixedSingle;
				lb.Text=row["MSPHONG"].ToString().Trim();
				lb.Name="lb;"+row["MSPHONG"].ToString();
				panP.Controls.Add(lb);
				if (row["TINHTRANG"].ToString()=="1")
				{
					lb.BackColor= Color.Red;
				}
				else
				{
					lb.BackColor=Color.LightGreen;
				}
				lb.Tag=lb.BackColor.Name;
				i++;
			}
		}

		private void frmPhong_Load(object sender, System.EventArgs e)
		{
			Load_Phong();
			txtNV.Text=frmMain.tenNV;
		}

		private void cmdExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void cmdAdd_Click(object sender, System.EventArgs e)
		{
			for (int i=0;i<lView.Items.Count;i++)
			{
				ListViewItem item=lView.Items[i];

				if (item.SubItems[0].Text=="")
				{
					// Thêm khách hàng
					SqlHelper.ExecuteNonQuery(
						"pr_ins_KH",
						CommandType.StoredProcedure,
						"@option",1,
						"@MSKH",1,
						"@HOTENKH",item.SubItems[1].Text,
						"@CMND",item.SubItems[2].Text,
						"@GIOITINHKH",item.SubItems[3].Text=="Nam"?"1":"0",
						"@DIACHIKH",item.SubItems[4].Text,
						"@DIENTHOAIKH",item.SubItems[5].Text);		
					
					//Lấy mã số khách hàng mới thêm vào
					DataTable dtKH=SqlHelper.ExecuteQuery(
						"select top 1 MSKH from KHACHHANG order by MSKH desc",
						CommandType.Text);

					//Thêm chi tiết thuê phòng
					SqlHelper.ExecuteNonQuery(
						"pr_ins_CHITIETTHUEPHONG",
						CommandType.StoredProcedure,
						"@option",1,
						"@SOHDONGTHUEPHONG",maHDTPhong,
						"@MSKH",dtKH.Rows[0]["MSKH"],
						"@VAITRO",item.SubItems[6].Text);
				}
				else
				{
					SqlHelper.ExecuteNonQuery(
						"pr_ins_KH",
						CommandType.StoredProcedure,
						"@option",2,
						"@MSKH",item.SubItems[0].Text,
						"@HOTENKH",item.SubItems[1].Text,
						"@CMND",item.SubItems[2].Text,
						"@GIOITINHKH",item.SubItems[3].Text=="Nam"?"1":"0",
						"@DIACHIKH",item.SubItems[4].Text,
						"@DIENTHOAIKH",item.SubItems[5].Text);
				}
			}
		}

		private void lb_Click(object sender, System.EventArgs e)
		{
			for(int i=0;i<panP.Controls.Count;i++)
			{
				if (panP.Controls[i].Name.IndexOf("lb;")>=0)
				{
					
					if (panP.Controls[i].Tag=="Red")
						panP.Controls[i].BackColor=Color.Red;
					else
						panP.Controls[i].BackColor=Color.LightGreen;
				}
			}
			Label lb=sender as Label;
			msPhong=lb.Text;
			if (lb.Tag=="Red")
			{
				lb.BackColor= Color.Gray;
				trang_thai_trong=false;
				cmdAdd.Enabled=true;
				cmdSave.Enabled=false;
				lView.Items.Clear();
				//Lấy thông tin khách hàng hiện thuê phòng
				DataTable dtPhong_KH=SqlHelper.ExecuteQuery(
					"pr_Phong_KH",
					CommandType.StoredProcedure,
					"@msphong",msPhong);
				if (dtPhong_KH.Rows.Count>0)
				{
					foreach (DataRow row in dtPhong_KH.Rows)
					{
						ListViewItem item=new ListViewItem();
						item.Text=row["MSKH"].ToString();
						item.SubItems.Add(row["HOTENKH"].ToString());
						item.SubItems.Add(row["CMND"].ToString());
						item.SubItems.Add(row["GIOITINHKH"].ToString()=="1"?"Nam":"Nữ");
						item.SubItems.Add(row["DIACHIKH"].ToString());
						item.SubItems.Add(row["DIENTHOAIKH"].ToString());
						item.SubItems.Add(row["VAITRO"].ToString()=="1"?"Có":"Không");
						maHDTPhong=row["SOHDONGTHUEPHONG"].ToString();
						lView.Items.Add(item);
					}
					dTPicker_Thue.Text=dtPhong_KH.Rows[0]["NGAYTHUE"].ToString();
					dTPicker_Tra.Text=dtPhong_KH.Rows[0]["NGAYTRADK"].ToString();
					chkVaiTro.Enabled=false;
				}
			}
			else
			{
				lb.BackColor= Color.LightGray;
				if (trang_thai_trong==false)
					lView.Items.Clear();
				trang_thai_trong=true;
				cmdAdd.Enabled=false;
				cmdSave.Enabled=true;
			}
		}

		private void cmdSave_Click(object sender, System.EventArgs e)
		{
			if (msPhong=="")
			{
				MessageBox.Show("Chưa chọn phòng!.","Lỗi");
				return;
			}
			TimeSpan t=dTPicker_Tra.Value.Subtract(dTPicker_Thue.Value);
			if (t.TotalDays<=0)
			{
				MessageBox.Show("Ngày trả trước ngày thuê!","Lỗi");
				return;
			}
			try
			{
				//Đặt lại tình trạng phòng
				SqlHelper.ExecuteNonQuery(
					"Update DMPHONG set TINHTRANG='1' WHERE MSPHONG='"+msPhong+"'",
					CommandType.Text);

				//Thêm vào danh sách thuê phòng
				SqlHelper.ExecuteNonQuery(
					"pr_ins_THUEPHONG",
					CommandType.StoredProcedure,
					"@option",1,
					"@SOHDONGTHUEPHONG",1,
					"@MSNV",frmMain.msNV,
					"@MSPHONG",msPhong,
					"@NGAYTHUE",dTPicker_Thue.Value,
					"@NGAYTRADK",dTPicker_Tra.Value);
				//Lấy mã số hợp đồng thuê phòng mới thêm vào
				DataTable dtHD=SqlHelper.ExecuteQuery(
					"select top 1 SOHDONGTHUEPHONG from THUEPHONG order by SOHDONGTHUEPHONG desc",
					CommandType.Text);
				maHDTPhong=dtHD.Rows[0]["SOHDONGTHUEPHONG"].ToString();
				for (int i=0;i<lView.Items.Count;i++)
				{
					ListViewItem item=lView.Items[i];

					
					// Thêm khách hàng
					SqlHelper.ExecuteNonQuery(
						"pr_ins_KH",
						CommandType.StoredProcedure,
						"@option",1,
						"@MSKH",1,
						"@HOTENKH",item.SubItems[1].Text,
						"@CMND",item.SubItems[2].Text,
						"@GIOITINHKH",item.SubItems[3].Text=="Nam"?"1":"0",
						"@DIACHIKH",item.SubItems[4].Text,
						"@DIENTHOAIKH",item.SubItems[5].Text);		
					
					//Lấy mã số khách hàng mới thêm vào
					DataTable dtKH=SqlHelper.ExecuteQuery(
						"select top 1 MSKH from KHACHHANG order by MSKH desc",
						CommandType.Text);

					//Thêm chi tiết thuê phòng
					SqlHelper.ExecuteNonQuery(
						"pr_ins_CHITIETTHUEPHONG",
						CommandType.StoredProcedure,
						"@option",1,
						"@SOHDONGTHUEPHONG",maHDTPhong,
						"@MSKH",dtKH.Rows[0]["MSKH"],
						"@VAITRO",item.SubItems[6].Text=="Có"?"1":"0");
				}
				Load_Phong();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void cmdAddNV_Click(object sender, System.EventArgs e)
		{
			if (txtTen.Text=="" || txtCMND.Text=="")
				return;
			ListViewItem item=new ListViewItem();
			item.Text="";
			item.SubItems.Add(txtTen.Text);
			item.SubItems.Add(txtCMND.Text);
			item.SubItems.Add(optNam.Checked?"Nam":"Nữ");
			item.SubItems.Add(txtDChi.Text);
			item.SubItems.Add(txtDThoai.Text);
			item.SubItems.Add(chkVaiTro.Checked?"Có":"Không");

			lView.Items.Add(item);

			txtTen.Text="";
			txtDChi.Text="";
			txtDThoai.Text="";
			txtCMND.Text="";
			if (chkVaiTro.Checked)
				chkVaiTro.Enabled=false;
			chkVaiTro.Checked=false;
		}

		private void cmdEditNV_Click(object sender, System.EventArgs e)
		{
			if (lView.SelectedItems.Count==0)
				return;
			ListViewItem item=new ListViewItem();
			item.Text=lView.SelectedItems[0].Text;
			item.SubItems.Add(txtTen.Text);
			item.SubItems.Add(txtCMND.Text);
			item.SubItems.Add(optNam.Checked?"Nam":"Nữ");
			item.SubItems.Add(txtDChi.Text);
			item.SubItems.Add(txtDThoai.Text);
			item.SubItems.Add(chkVaiTro.Checked?"Có":"Không");
			
			lView.SelectedItems[0].Remove();
			
			lView.Items.Add(item);
		}

		private void lView_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (lView.SelectedItems.Count==0)
			{
				txtTen.Text="";
				txtDChi.Text="";
				txtDThoai.Text="";
				txtCMND.Text="";

				chkVaiTro.Checked=false;
				return;
			}
			
			ListViewItem item=lView.SelectedItems[0];
			pos=item.Index;
			txtTen.Text=item.SubItems[1].Text;
			txtCMND.Text=item.SubItems[2].Text;
			if (item.SubItems[3].Text=="Nam")
				optNam.Checked=true;
			else
				optNu.Checked=true;
			
			txtDChi.Text=item.SubItems[4].Text;
			txtDThoai.Text=item.SubItems[5].Text;
			if (item.SubItems[6].Text=="Có")
				chkVaiTro.Checked=true;
			else
				chkVaiTro.Checked=false;
		}

		private void cmdDeleteNV_Click(object sender, System.EventArgs e)
		{
			if (lView.SelectedItems.Count==0)
				return;
			lView.SelectedItems[0].Remove();
		}

		private void dTPicker_Thue_ValueChanged(object sender, System.EventArgs e)
		{
		
		}

		private void dTPicker_Tra_ValueChanged(object sender, System.EventArgs e)
		{
			TimeSpan t=dTPicker_Tra.Value.Subtract(dTPicker_Thue.Value);
			if (t.TotalDays<=0)
			{
				MessageBox.Show("Ngày trả trước ngày thuê!","Lỗi");
			}
		}
	}
}
