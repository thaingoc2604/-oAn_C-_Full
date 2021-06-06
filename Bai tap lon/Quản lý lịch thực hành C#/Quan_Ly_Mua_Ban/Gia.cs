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
	/// Summary description for Gia.
	/// </summary>
	public class Form_Gia : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cmMaHang;
		private System.Windows.Forms.DateTimePicker cmDaTe;
		private System.Windows.Forms.TextBox txtGiaMua;
		private System.Windows.Forms.Button btDau;
		private System.Windows.Forms.Button btLui;
		private System.Windows.Forms.Button btToi;
		private System.Windows.Forms.Button btCuoi;
		private System.Windows.Forms.Button btThem;
		private System.Windows.Forms.Button btXoa;
		private System.Windows.Forms.Button btSua;
		private System.Windows.Forms.Button btLuu;
		private System.Windows.Forms.Button btHuy;
		private System.Windows.Forms.DataGrid dataGrid_Gia;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtThue;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtMaHang;
		private System.Windows.Forms.TextBox txtGiaBan;
		private System.Windows.Forms.Label label7;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form_Gia()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_Gia));
			this.label1 = new System.Windows.Forms.Label();
			this.cmMaHang = new System.Windows.Forms.ComboBox();
			this.cmDaTe = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btDau = new System.Windows.Forms.Button();
			this.btLui = new System.Windows.Forms.Button();
			this.btToi = new System.Windows.Forms.Button();
			this.btCuoi = new System.Windows.Forms.Button();
			this.btThem = new System.Windows.Forms.Button();
			this.btXoa = new System.Windows.Forms.Button();
			this.btSua = new System.Windows.Forms.Button();
			this.btLuu = new System.Windows.Forms.Button();
			this.btHuy = new System.Windows.Forms.Button();
			this.txtGiaMua = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtThue = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtMaHang = new System.Windows.Forms.TextBox();
			this.txtGiaBan = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.dataGrid_Gia = new System.Windows.Forms.DataGrid();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid_Gia)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 72);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mã Hàng:";
			// 
			// cmMaHang
			// 
			this.cmMaHang.Location = new System.Drawing.Point(96, 40);
			this.cmMaHang.Name = "cmMaHang";
			this.cmMaHang.Size = new System.Drawing.Size(136, 21);
			this.cmMaHang.TabIndex = 2;
			// 
			// cmDaTe
			// 
			this.cmDaTe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.cmDaTe.Location = new System.Drawing.Point(96, 8);
			this.cmDaTe.Name = "cmDaTe";
			this.cmDaTe.Size = new System.Drawing.Size(136, 20);
			this.cmDaTe.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(8, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(144, 23);
			this.label2.TabIndex = 0;
			this.label2.Text = "Giá Mặt Hàng";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btDau);
			this.panel1.Controls.Add(this.btLui);
			this.panel1.Controls.Add(this.btToi);
			this.panel1.Controls.Add(this.btCuoi);
			this.panel1.Controls.Add(this.btThem);
			this.panel1.Controls.Add(this.btXoa);
			this.panel1.Controls.Add(this.btSua);
			this.panel1.Controls.Add(this.btLuu);
			this.panel1.Controls.Add(this.btHuy);
			this.panel1.Controls.Add(this.txtGiaMua);
			this.panel1.Controls.Add(this.cmDaTe);
			this.panel1.Controls.Add(this.cmMaHang);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.txtThue);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.txtMaHang);
			this.panel1.Controls.Add(this.txtGiaBan);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Location = new System.Drawing.Point(8, 40);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(280, 296);
			this.panel1.TabIndex = 3;
			// 
			// btDau
			// 
			this.btDau.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btDau.Location = new System.Drawing.Point(48, 200);
			this.btDau.Name = "btDau";
			this.btDau.Size = new System.Drawing.Size(32, 23);
			this.btDau.TabIndex = 17;
			this.btDau.Text = "|<<";
			this.btDau.Click += new System.EventHandler(this.btDau_Click);
			// 
			// btLui
			// 
			this.btLui.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btLui.Location = new System.Drawing.Point(96, 200);
			this.btLui.Name = "btLui";
			this.btLui.Size = new System.Drawing.Size(32, 23);
			this.btLui.TabIndex = 25;
			this.btLui.Text = "<";
			this.btLui.Click += new System.EventHandler(this.btLui_Click);
			// 
			// btToi
			// 
			this.btToi.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btToi.Location = new System.Drawing.Point(144, 200);
			this.btToi.Name = "btToi";
			this.btToi.Size = new System.Drawing.Size(32, 23);
			this.btToi.TabIndex = 24;
			this.btToi.Text = ">";
			this.btToi.Click += new System.EventHandler(this.btToi_Click);
			// 
			// btCuoi
			// 
			this.btCuoi.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btCuoi.Location = new System.Drawing.Point(192, 200);
			this.btCuoi.Name = "btCuoi";
			this.btCuoi.Size = new System.Drawing.Size(32, 23);
			this.btCuoi.TabIndex = 23;
			this.btCuoi.Text = ">>|";
			this.btCuoi.Click += new System.EventHandler(this.btCuoi_Click);
			// 
			// btThem
			// 
			this.btThem.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btThem.Location = new System.Drawing.Point(16, 264);
			this.btThem.Name = "btThem";
			this.btThem.TabIndex = 5;
			this.btThem.Text = "&Thêm";
			this.btThem.Click += new System.EventHandler(this.btThem_Click);
			// 
			// btXoa
			// 
			this.btXoa.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btXoa.Image = ((System.Drawing.Image)(resources.GetObject("btXoa.Image")));
			this.btXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btXoa.Location = new System.Drawing.Point(192, 264);
			this.btXoa.Name = "btXoa";
			this.btXoa.TabIndex = 7;
			this.btXoa.Text = "&Xóa";
			this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
			// 
			// btSua
			// 
			this.btSua.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btSua.Location = new System.Drawing.Point(104, 264);
			this.btSua.Name = "btSua";
			this.btSua.TabIndex = 6;
			this.btSua.Text = "&Sửa";
			this.btSua.Click += new System.EventHandler(this.btSua_Click);
			// 
			// btLuu
			// 
			this.btLuu.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btLuu.Location = new System.Drawing.Point(56, 232);
			this.btLuu.Name = "btLuu";
			this.btLuu.TabIndex = 8;
			this.btLuu.Text = "&Lưu";
			this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
			// 
			// btHuy
			// 
			this.btHuy.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btHuy.Location = new System.Drawing.Point(144, 232);
			this.btHuy.Name = "btHuy";
			this.btHuy.TabIndex = 9;
			this.btHuy.Text = "&Hủy";
			this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
			// 
			// txtGiaMua
			// 
			this.txtGiaMua.Location = new System.Drawing.Point(96, 104);
			this.txtGiaMua.Name = "txtGiaMua";
			this.txtGiaMua.Size = new System.Drawing.Size(136, 20);
			this.txtGiaMua.TabIndex = 3;
			this.txtGiaMua.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 8);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(88, 23);
			this.label3.TabIndex = 0;
			this.label3.Text = "Ngày Cập Nhật:";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 104);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 23);
			this.label4.TabIndex = 0;
			this.label4.Text = "Giá Mua:";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(8, 168);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(56, 23);
			this.label5.TabIndex = 0;
			this.label5.Text = "Thuế:";
			// 
			// txtThue
			// 
			this.txtThue.Location = new System.Drawing.Point(96, 168);
			this.txtThue.Name = "txtThue";
			this.txtThue.Size = new System.Drawing.Size(136, 20);
			this.txtThue.TabIndex = 4;
			this.txtThue.Text = "";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.Location = new System.Drawing.Point(240, 168);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(24, 23);
			this.label6.TabIndex = 0;
			this.label6.Text = "%";
			// 
			// txtMaHang
			// 
			this.txtMaHang.Location = new System.Drawing.Point(96, 72);
			this.txtMaHang.Name = "txtMaHang";
			this.txtMaHang.Size = new System.Drawing.Size(136, 20);
			this.txtMaHang.TabIndex = 3;
			this.txtMaHang.Text = "";
			// 
			// txtGiaBan
			// 
			this.txtGiaBan.Location = new System.Drawing.Point(96, 136);
			this.txtGiaBan.Name = "txtGiaBan";
			this.txtGiaBan.ReadOnly = true;
			this.txtGiaBan.Size = new System.Drawing.Size(136, 20);
			this.txtGiaBan.TabIndex = 3;
			this.txtGiaBan.Text = "";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(8, 136);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(56, 23);
			this.label7.TabIndex = 0;
			this.label7.Text = "Giá Bán:";
			// 
			// dataGrid_Gia
			// 
			this.dataGrid_Gia.DataMember = "";
			this.dataGrid_Gia.Dock = System.Windows.Forms.DockStyle.Right;
			this.dataGrid_Gia.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid_Gia.Location = new System.Drawing.Point(296, 0);
			this.dataGrid_Gia.Name = "dataGrid_Gia";
			this.dataGrid_Gia.Size = new System.Drawing.Size(352, 344);
			this.dataGrid_Gia.TabIndex = 4;
			// 
			// Form_Gia
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(648, 344);
			this.Controls.Add(this.dataGrid_Gia);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form_Gia";
			this.Text = "Gia_Mat_Hang";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid_Gia)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion
		//Đổ Data vào DataGrid
		connet ket_noi = new connet();
		DataTable dtGia = new DataTable();
		DataTable dtMaHang = new DataTable();
		public int n=0;

		public void Load_Data_GiaHang()
		{		
			try
			{
				string sqlGia="select * from GiaHang";
				dtGia = ket_noi.getDataTable(sqlGia);	
				string sqlMaHang="select MaHang from HangHoa";
				dtMaHang = ket_noi.getDataTable(sqlMaHang);	

				dataGrid_Gia.DataSource=dtGia;//Dịnh vào Combo Box để đựa ra Text Box

				cmMaHang.DataSource=dtMaHang;
				cmMaHang.DisplayMember="MaHang";
				cmMaHang.ValueMember="MaHang";

				txtGiaMua.DataBindings.Clear();
				txtGiaMua.DataBindings.Add("Text",dtGia,"GiaMua");
				//txtTrigia.Text=Convert.ToString(float.Parse(txtSoluong.Text)*float.Parse(txtDongiaB.Text));
//				txtGiaBan.Text=Convert.ToString((float.Parse(txtGiaMua.Text)*0.1)+((float.Parse(txtGiaMua.Text)*0.1)*float.Parse(txtThue.Text)));

				txtGiaBan.DataBindings.Clear();
				txtGiaBan.DataBindings.Add("Text",dtGia,"GiaBan");
				

				txtMaHang.DataBindings.Clear();
				txtMaHang.DataBindings.Add("Text",dtGia,"Mahang");

				txtThue.DataBindings.Clear();
				txtThue.DataBindings.Add("Text",dtGia,"Thue");

				cmDaTe.DataBindings.Clear();
				cmDaTe.DataBindings.Add("Text",dtGia,"NgayCapNhat");	
//				txtThue.Text=Convert.ToString(float.Parse(txtGiaMua.Text)*float.Parse(txtThue.Text));
			}
			catch(Exception e)
			{
				MessageBox.Show(e.ToString());
			}
		}
		public void MoPhim()
		{			
			cmMaHang.Enabled=true;
			
			txtMaHang.Enabled=true;
			btThem.Enabled=true;
			btXoa.Enabled=true;
			btSua.Enabled=true;			
			btLuu.Enabled=false;
			btHuy.Enabled=false;
			
		}
		public void TatPhim()	
		{			
//			btDau.Enabled=false;
//			btLui.Enabled=false;
//			btToi.Enabled=false;
//			btCuoi.Enabled=false;
			txtMaHang.Enabled=false;
			btThem.Enabled=false;
			btXoa.Enabled=false;
			btSua.Enabled=false;			
			btLuu.Enabled=true;
			btHuy.Enabled=true;
			
		}
		public void Clear_FrGia()
		{		
			txtGiaMua.Clear();
			txtGiaBan.Clear();
			txtThue.Clear();
//			cmMaHang.Text="";		
		}

		public void GiaBan()
		{
			txtGiaBan.Text=Convert.ToString((float.Parse(txtGiaMua.Text)*1.1)+(float.Parse(txtGiaMua.Text)*1.1)*float.Parse(txtThue.Text));
		}
		public void Getinfor()
		{	
			GiaBan();
			ket_noi.GMaHang = cmMaHang.Text;
			ket_noi.GNgay = cmDaTe.Text;
			ket_noi.GGiaMua= txtGiaMua.Text;
			ket_noi.GGiaBan= txtGiaBan.Text;
			ket_noi.GThue = txtThue.Text;
		}
		private int Sqlcommand(int mode, string GMHang, string Gngay, string GMua, string GBan, string Gthue)
		{
			int i=0;
			try
			{						
				SqlCommand sqlcmd = new SqlCommand("Stor_Gia", ket_noi.getConnection);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sqlcmd.Parameters.Add("@mode",SqlDbType.NVarChar).Value= mode;				
				sqlcmd.Parameters.Add("@Ma",SqlDbType.NVarChar).Value=GMHang;
				sqlcmd.Parameters.Add("@ngay",SqlDbType.NVarChar).Value= Gngay;				
				sqlcmd.Parameters.Add("@GMua",SqlDbType.NVarChar).Value=GMua;
				sqlcmd.Parameters.Add("@GBan",SqlDbType.NVarChar).Value=GBan;
				sqlcmd.Parameters.Add("@Thue",SqlDbType.NVarChar).Value=Gthue;			
				
				i = sqlcmd.ExecuteNonQuery();			
			}
			catch(Exception e)
			{
				MessageBox.Show(e.ToString());
			}
			return i;
		}

		private void btThem_Click(object sender, System.EventArgs e)
		{
			n=1;
			TatPhim();
			Clear_FrGia();
		}

		private void btSua_Click(object sender, System.EventArgs e)
		{
			n=2;
			TatPhim();
			cmMaHang.Enabled=false;
			cmDaTe.Enabled=false;
			txtMaHang.Enabled=false;
		}

		private void btHuy_Click(object sender, System.EventArgs e)
		{
			MoPhim();
			Load_Data_GiaHang();
			
		}
		CheckError KiemTra = new CheckError();
		private void btLuu_Click(object sender, System.EventArgs e)
		{
			Getinfor();
//			GiaBan();
			if(n==1)
			{
				if(KiemTra.kiemtraRong_ComBo(cmMaHang,"Mã Hàng"))
				{
//					string str="select * from Giahang  where MaHang='"+cmMaHang.Text+"'" ;
									
					if(KiemTra.kiemtraSo(txtGiaMua,"Tiền "))
					{						
						if(KiemTra.KiemTraThue(txtThue,"Thuế "))
						{														
							if(Sqlcommand(1,ket_noi.GMaHang,ket_noi.GNgay,ket_noi.GGiaMua,ket_noi.GGiaBan, ket_noi.GThue)!=0)
							{						
								MessageBox.Show("Bạn Đã Thêm Thàng Công!", "Good", MessageBoxButtons.OK, MessageBoxIcon.Information);
							}			
									
						}
					}
					
				}
			}
			else
				if(n==2)
			{	
				if(KiemTra.kiemtraSo(txtGiaMua,"Tiền "))
				{
					if(KiemTra.KiemTraThue(txtThue,"Thuế "))
					{
						if(Sqlcommand(0,ket_noi.GMaHang,ket_noi.GNgay,ket_noi.GGiaMua,ket_noi.GGiaBan, ket_noi.GThue)!=0)
						{
							MessageBox.Show("Da cap nhat!!!! ", "Good", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
					}
				}
			}
//			Load_Data_GiaHang();
		}

		private void btXoa_Click(object sender, System.EventArgs e)
		{
			DialogResult dlr = new DialogResult();
			dlr=MessageBox.Show("Bạn có chắn là xóa mẫu tin này không?","Warning",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
			
			if(dlr==DialogResult.OK)
			{
				
					Getinfor();
//				try
//				{
					if(Sqlcommand(-1,ket_noi.GMaHang,ket_noi.GNgay,ket_noi.GGiaMua,ket_noi.GGiaBan, ket_noi.GThue)!=0)
					{		
						MessageBox.Show("Da xoa xong roi !!!! ", "Good", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
//				
//				}
//				catch
//				{
//					MessageBox.Show("Bạn xóa không đúng!!!! ", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Information);
//				}
			}			
			Load_Data_GiaHang();
		}
		public void FirstRecord()
		{
			this.BindingContext[dtGia].Position = 0;			
		}
		public void LastRecord()
		{
			this.BindingContext[dtGia].Position = dtGia.Rows.Count - 1;
	
		}
		public void NextRecord()
		{
			this.BindingContext[dtGia].Position += 1;			
		}
		public void PreviousRecord()
		{
			this.BindingContext[dtGia].Position -= 1;			
		}

		private void btDau_Click(object sender, System.EventArgs e)
		{
			FirstRecord();
		}

		private void btLui_Click(object sender, System.EventArgs e)
		{
			PreviousRecord();
		}

		private void btToi_Click(object sender, System.EventArgs e)
		{
			NextRecord();
		}

		private void btCuoi_Click(object sender, System.EventArgs e)
		{
			LastRecord();
		}

	}
}
