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
	public class frmTBTrangTB : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button cmdCancel;
		private System.Windows.Forms.Button cmdSave;
		#region User Varibles
		public static string _connectString="data source=vanlang;database=demo;uid=sa;password=";
		int _option=0;
		#endregion
		private System.Windows.Forms.ComboBox cboLoaiP;
		private System.Windows.Forms.ListView lView;
		private System.Windows.Forms.ColumnHeader LP;
		private System.Windows.Forms.ColumnHeader TB;
		private System.Windows.Forms.ColumnHeader SL;
		private System.Windows.Forms.Panel panTrangBi;


		private System.ComponentModel.Container components = null;

		public frmTBTrangTB()
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
	
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lView = new System.Windows.Forms.ListView();
			this.LP = new System.Windows.Forms.ColumnHeader();
			this.TB = new System.Windows.Forms.ColumnHeader();
			this.SL = new System.Windows.Forms.ColumnHeader();
			this.cboLoaiP = new System.Windows.Forms.ComboBox();
			this.cmdCancel = new System.Windows.Forms.Button();
			this.cmdSave = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.panTrangBi = new System.Windows.Forms.Panel();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lView);
			this.groupBox1.Controls.Add(this.cboLoaiP);
			this.groupBox1.Controls.Add(this.cmdCancel);
			this.groupBox1.Controls.Add(this.cmdSave);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Location = new System.Drawing.Point(5, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(411, 352);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			// 
			// lView
			// 
			this.lView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																					this.LP,
																					this.TB,
																					this.SL});
			this.lView.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lView.FullRowSelect = true;
			this.lView.GridLines = true;
			this.lView.Location = new System.Drawing.Point(8, 48);
			this.lView.Name = "lView";
			this.lView.Size = new System.Drawing.Size(400, 296);
			this.lView.TabIndex = 13;
			this.lView.View = System.Windows.Forms.View.Details;
			// 
			// LP
			// 
			this.LP.Text = "Loại phòng";
			this.LP.Width = 100;
			// 
			// TB
			// 
			this.TB.Text = "Thiết bị";
			this.TB.Width = 200;
			// 
			// SL
			// 
			this.SL.Text = "Số lượng";
			this.SL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.SL.Width = 100;
			// 
			// cboLoaiP
			// 
			this.cboLoaiP.Location = new System.Drawing.Point(80, 16);
			this.cboLoaiP.Name = "cboLoaiP";
			this.cboLoaiP.Size = new System.Drawing.Size(168, 21);
			this.cboLoaiP.TabIndex = 12;
			this.cboLoaiP.Text = "comboBox1";
			this.cboLoaiP.SelectedIndexChanged += new System.EventHandler(this.cboLoaiP_SelectedIndexChanged);
			// 
			// cmdCancel
			// 
			this.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmdCancel.Location = new System.Drawing.Point(344, 16);
			this.cmdCancel.Name = "cmdCancel";
			this.cmdCancel.Size = new System.Drawing.Size(64, 23);
			this.cmdCancel.TabIndex = 11;
			this.cmdCancel.Text = "Thoát";
			this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
			// 
			// cmdSave
			// 
			this.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmdSave.Location = new System.Drawing.Point(272, 16);
			this.cmdSave.Name = "cmdSave";
			this.cmdSave.Size = new System.Drawing.Size(64, 23);
			this.cmdSave.TabIndex = 10;
			this.cmdSave.Text = "Lưu";
			this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(8, 17);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 24);
			this.label2.TabIndex = 9;
			this.label2.Text = "Loại phòng:";
			// 
			// panTrangBi
			// 
			this.panTrangBi.AutoScroll = true;
			this.panTrangBi.Location = new System.Drawing.Point(416, 0);
			this.panTrangBi.Name = "panTrangBi";
			this.panTrangBi.Size = new System.Drawing.Size(248, 352);
			this.panTrangBi.TabIndex = 15;
			// 
			// frmTBTrangTB
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(672, 358);
			this.Controls.Add(this.panTrangBi);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "frmTBTrangTB";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Trang bị trang thiết bị cho loại phòng";
			this.Resize += new System.EventHandler(this.frmTBTrangTB_Resize);
			this.Load += new System.EventHandler(this.frmPhong_Load);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion
		void Load_TrangThietBi()
		{
			DataTable dt=SqlHelper.ExecuteQuery("pr_list_ThietBi",
				CommandType.StoredProcedure,"@option","1");
			panTrangBi.Controls.Clear();
			int i=0;
			foreach (DataRow row in dt.Rows)
			{
				CheckBox chk=new CheckBox();
				chk.Checked=false;
				chk.Location=new Point(5,i*25+3);
				chk.CheckedChanged+=new EventHandler(chk_CheckedChanged);
				chk.Width=10;
				chk.FlatStyle=FlatStyle.System;
				chk.Name="chk;"+row["MSTB"].ToString();
				panTrangBi.Controls.Add(chk);
				
				Label lbl=new Label();
				lbl.Text=row["TENTHIETBI"].ToString();
				lbl.BorderStyle=BorderStyle.None;
				lbl.Location=new Point(5+10+5,i*25+5);
				lbl.Width=150;
				panTrangBi.Controls.Add(lbl);

				NumericUpDown num=new NumericUpDown();
				num.Value=0;
				num.Minimum=0;
				num.Maximum=10;
				num.Location=new Point(5+10+5+150+5,i*25+5);
				num.Visible=true;
				num.Enabled=false;
				num.Width=50;
				panTrangBi.Controls.Add(num);

				chk.Tag=num;
				i++;
				DataTable dtTB=SqlHelper.ExecuteQuery(
				"select * from TRANGBITRANGTB where MSTB='"+row["MSTB"].ToString()+"' and MSLOAIPHONG='"+ cboLoaiP.SelectedValue +"'",
				CommandType.Text);
				if (dtTB.Rows.Count>0)
				{
					chk.Checked=true;
					num.Value=int.Parse(dtTB.Rows[0]["SOLUONG"].ToString());
				}
			}
		}
		void Load_LoaiP()
		{
			try
			{
				DataTable dtLoaiP=SqlHelper.ExecuteQuery(
					"pr_list_LoaiPhong",
					CommandType.StoredProcedure);
				cboLoaiP.DataSource=dtLoaiP;
				cboLoaiP.DisplayMember="LOAIPHONG";
				cboLoaiP.ValueMember="MSLOAIPHONG";
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		void Load_TBTrangThietBi()
		{
			try
			{
				DataTable dtLP=SqlHelper.ExecuteQuery(
					"pr_list_TBTrangThietBi",
					CommandType.StoredProcedure);
				lView.Items.Clear();
				if (dtLP.Rows.Count>0)
				{
					foreach (DataRow row in dtLP.Rows)
					{
						ListViewItem item=new ListViewItem();
						item.Text=row["LOAIPHONG"].ToString();
						item.SubItems.Add(row["TENTHIETBI"].ToString());
						item.SubItems.Add(row["SOLUONG"].ToString());
						
						lView.Items.Add(item);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void frmPhong_Load(object sender, System.EventArgs e)
		{
			Load_LoaiP();
			Load_TBTrangThietBi();
			Load_TrangThietBi();
		}

		private void cmdExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void chk_CheckedChanged(object sender, System.EventArgs e)
		{
			CheckBox chk=sender as CheckBox;
			NumericUpDown num=chk.Tag as NumericUpDown;
			num.Enabled=chk.Checked;
			cmdSave.Enabled=true;
		}

		private void cboLoaiP_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			Load_TrangThietBi();
		}

		private void cmdSave_Click(object sender, System.EventArgs e)
		{
			cmdSave.Enabled=false;

			for(int i=0;i<panTrangBi.Controls.Count;i++)
			{
				if (panTrangBi.Controls[i].Name.IndexOf("chk;")>=0)
				{
					CheckBox chk=panTrangBi.Controls[i] as CheckBox;
					if (chk.Checked)
					{
						string mstb=chk.Name.Replace("chk;","");
						NumericUpDown num=chk.Tag as NumericUpDown;
						string soluong=num.Value.ToString();

						DataTable dtTB=SqlHelper.ExecuteQuery(
							"select * from TRANGBITRANGTB where MSTB='"+mstb+"' and MSLOAIPHONG='"+ cboLoaiP.SelectedValue +"'",
							CommandType.Text);
						if (dtTB.Rows.Count>0)
						{
							_option=2;
							if (soluong=="0")
								_option=3;
						}
						else
						{
							_option=1;				
							if (soluong=="0")
								_option=0;				
						}
						if (_option!=0)
							SqlHelper.ExecuteNonQuery("pr_ins_TBTrangTB",
								CommandType.StoredProcedure,
								"@option",_option,
								"@MSLOAIPHONG",cboLoaiP.SelectedValue,
								"@MSTB",mstb,
								"@SOLUONG",soluong);
					}
				}
			}
			Load_TBTrangThietBi();
			Load_TrangThietBi();
		}

		private void cmdCancel_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void frmTBTrangTB_Resize(object sender, System.EventArgs e)
		{
			panTrangBi.Width=this.Width-groupBox1.Width-20;
		}
	}
}
