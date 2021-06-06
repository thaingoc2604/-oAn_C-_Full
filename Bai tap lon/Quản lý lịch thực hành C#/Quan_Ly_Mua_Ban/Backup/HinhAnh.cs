using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.IO;
using System.Drawing;
using System.Text.RegularExpressions;

namespace Quan_Ly_Mua_Ban
{
	/// <summary>
	/// Summary description for HinhAnh.
	/// </summary>
	public class HinhAnh : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox txtMaHinh;
		private System.Windows.Forms.Label lbDiaChi;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ListBox listBox1;
		internal System.Windows.Forms.Button btnDelete;
		internal System.Windows.Forms.Button btnDisplay;
		internal System.Windows.Forms.Button btnSave;
		internal System.Windows.Forms.Button btnBrowse;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public HinhAnh()
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
			this.txtMaHinh = new System.Windows.Forms.TextBox();
			this.lbDiaChi = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnDisplay = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.SuspendLayout();
			// 
			// txtMaHinh
			// 
			this.txtMaHinh.Location = new System.Drawing.Point(568, 8);
			this.txtMaHinh.Name = "txtMaHinh";
			this.txtMaHinh.Size = new System.Drawing.Size(104, 20);
			this.txtMaHinh.TabIndex = 20;
			this.txtMaHinh.Text = "";
			// 
			// lbDiaChi
			// 
			this.lbDiaChi.Location = new System.Drawing.Point(8, 264);
			this.lbDiaChi.Name = "lbDiaChi";
			this.lbDiaChi.Size = new System.Drawing.Size(656, 23);
			this.lbDiaChi.TabIndex = 19;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox1.Location = new System.Drawing.Point(8, 8);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(456, 248);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 18;
			this.pictureBox1.TabStop = false;
			// 
			// listBox1
			// 
			this.listBox1.Location = new System.Drawing.Point(468, 32);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(96, 225);
			this.listBox1.TabIndex = 17;
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btnDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btnDelete.Location = new System.Drawing.Point(576, 144);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(64, 23);
			this.btnDelete.TabIndex = 16;
			this.btnDelete.Text = "D&elete";
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnDisplay
			// 
			this.btnDisplay.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btnDisplay.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btnDisplay.Location = new System.Drawing.Point(576, 112);
			this.btnDisplay.Name = "btnDisplay";
			this.btnDisplay.Size = new System.Drawing.Size(64, 23);
			this.btnDisplay.TabIndex = 15;
			this.btnDisplay.Text = "&Display";
			this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btnSave.Location = new System.Drawing.Point(576, 72);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(64, 23);
			this.btnSave.TabIndex = 14;
			this.btnSave.Text = "&Save";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnBrowse
			// 
			this.btnBrowse.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btnBrowse.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btnBrowse.Location = new System.Drawing.Point(576, 40);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(64, 23);
			this.btnBrowse.TabIndex = 13;
			this.btnBrowse.Text = "&Browse...";
			this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(472, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 23);
			this.label1.TabIndex = 21;
			this.label1.Text = "Tên Hàng";
			// 
			// HinhAnh
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(680, 294);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtMaHinh);
			this.Controls.Add(this.lbDiaChi);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnDisplay);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnBrowse);
			this.MaximizeBox = false;
			this.Name = "HinhAnh";
			this.Text = "Hinh_Anh";
			this.Load += new System.EventHandler(this.HinhAnh_Load);
			this.ResumeLayout(false);

		}
		#endregion
 
		connet ket_noi = new connet();		
		
		protected DataSet dsPictures;
		public SqlDataAdapter da;
		public SqlCommandBuilder cbd;

		
		private void btnBrowse_Click(object sender, System.EventArgs e)
		{
			openFileDialog1.InitialDirectory = "C:/";
			openFileDialog1.Filter = "All Files|*.*|Bitmaps|*.bmp|GIFs|*.gif|JPEGs|*.jpg";
			openFileDialog1.FilterIndex = 2;

			// When the user clicks the Open button (DialogResult.OK is the only option;
			// there is not DialogResult.Open), display the image centered in the 
			// PictureBox and display the full path of the image.

			if (openFileDialog1.ShowDialog() == DialogResult.OK )
			{
				pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
				pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
				pictureBox1.BorderStyle = BorderStyle.Fixed3D;
				lbDiaChi.Text = openFileDialog1.FileName;
			}
		}
		CheckError KiemTra = new CheckError();
		private void btnSave_Click(object sender, System.EventArgs e)
		{
			//Save Hình
			if(KiemTra.kiemtraRong(txtMaHinh,"Tên hàng"))
			{
				try
				{
					string[] arrFilename = Regex.Split(lbDiaChi.Text, "/");
					Array.Reverse(arrFilename);
				

					MemoryStream ms = new MemoryStream();

					pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);

					byte[] arrImage = ms.GetBuffer();

					// Close the stream object to release the resource.
					ms.Close();

					bool isConnecting  = true;

					while (isConnecting)
					{
						try 
						{					
							//						SqlConnection Connect = new SqlConnection(con);

							string strSQL = "INSERT INTO Hinh (TenHang, Hinh)" + 
								"VALUES (@TenHang, @Hinh)";

							// A SqlCommand object is used to execute the SQL statement.
							SqlCommand cmd = new SqlCommand(strSQL, ket_noi.con);

							cmd.Parameters.Add(new SqlParameter("@TenHang", SqlDbType.NVarChar, 50)).Value = txtMaHinh.Text;
							cmd.Parameters.Add(new SqlParameter("@Hinh", SqlDbType.Image)).Value = arrImage;

							// Open the connection, execute the command, and close the 
							// connection. It is more efficient to ExecuteNonQuery when data 
							// is not being returned.

							//						con.Open();
							cmd.ExecuteNonQuery();
					

							// Data has been successfully submitted, so break out of the loop
							// and close the status form.

							isConnecting = false;
											

							MessageBox.Show(arrFilename[0] + "Đã ghi vào database.", "Image Save Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

						} 
						catch( SqlException sqlExc)
						{
							MessageBox.Show(Convert.ToString(sqlExc), "SQL Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);						
							break;
						} 
					}
				}
			
				catch
				{
					MessageBox.Show(this, "Không Save hình vào DataBase đươc!!!","SQL Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			DoHinhVaoListBox();
		}
	

		private void btnDisplay_Click(object sender, System.EventArgs e)
		{
			// When nothing is selected in the ListBox, the SelectedIndex = -1.

			if (listBox1.SelectedIndex < 0) 
			{
				MessageBox.Show("Không còn hình trong  database!!!", "Empty Database!", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else 
			{
				byte[] arrPicture = ((byte[]) (dsPictures.Tables[0].Rows[listBox1.SelectedIndex]["Hinh"]));

				MemoryStream ms = new MemoryStream(arrPicture);
				pictureBox1.Image = Image.FromStream(ms);
				pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
				pictureBox1.BorderStyle = BorderStyle.Fixed3D;
				// Close the stream object to release the resource.
				ms.Close();
			}
		}
		public void DoHinhVaoListBox()
		{
			bool KiemConnecting  = true;

			while (KiemConnecting)
			{
				try 
				{
					// The SqlConnection class allows you to communicate with SQL 
					// Server. The constructor accepts a connection string an 
					// argument.This connection string uses Integrated Security, 
					// which means that you must have a login in SQL Server, or be 
					// part of the Administrators group for this to work.

					//					SqlConnection northwindConnection = new SqlConnection(connectionstring);

					// A SqlCommand object is used to execute the SQL commands.

					SqlCommand cmd = new SqlCommand("SELECT * FROM Hinh", ket_noi.con);

					// The SqlDataAdapter is responsible for filling a DataSet.
					da = new SqlDataAdapter(cmd);

					// TheSqlCommandBuilder will be used for deleting pictures from 
					// the database in the btnDelete click event handler.

					cbd = new SqlCommandBuilder(da);
					dsPictures = new DataSet();
					da.Fill(dsPictures);

					// Data has been successfully retrieved, so break out of the loop
					// and close the status form.

					KiemConnecting = false;
					//					didPreviouslyConnect = true;
					

					// Display the filenames of the pictures in the DataSet.
					listBox1.DataSource = dsPictures.Tables[0];
					listBox1.DisplayMember = "TenHang";
					
					//					listBox1.ValueMember="MaHinh";

				} 
				catch( SqlException sqlExc)
				{
					MessageBox.Show(Convert.ToString(sqlExc), "SQL Exception Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
					break;
				} 
			}
		}

		private void btnDelete_Click(object sender, System.EventArgs e)
		{
				// When nothing is selected in the ListBox, the SelectedIndex = -1.
			if (listBox1.SelectedIndex < 0) 
			{

				MessageBox.Show("Không còn hình nào trong DataBase.", "Empty Database!", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else 
			{
				
				dsPictures.Tables[0].Rows[listBox1.SelectedIndex].Delete();
				da.UpdateCommand = cbd.GetDeleteCommand();
				da.Update(dsPictures);

				// Clear the image and filename
				listBox1.Text = string.Empty;
				pictureBox1.Image = null;
			
			}
			
		}

		private void HinhAnh_Load(object sender, System.EventArgs e)
		{
			DoHinhVaoListBox();
		}
	}
}
