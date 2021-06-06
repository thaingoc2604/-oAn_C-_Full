namespace Accounting
{
    partial class Frm_MangSang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_MangSang));
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.buttonX3 = new DevComponents.DotNetBar.ButtonX();
            this.Them_btt = new DevComponents.DotNetBar.ButtonX();
            this.Grid_MangSang = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.NgayThang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOTHU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intSoDu = new DevComponents.Editors.IntegerInput();
            this.calendarCombo1 = new Janus.Windows.CalendarCombo.CalendarCombo();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.bttBaoCao = new System.Windows.Forms.Button();
            this.mtxtThang = new DevComponents.DotNetBar.Controls.MaskedTextBoxAdv();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_MangSang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intSoDu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX1.Location = new System.Drawing.Point(237, 300);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(60, 22);
            this.buttonX1.TabIndex = 19;
            this.buttonX1.Text = "Thoát";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // labelX2
            // 
            this.labelX2.Location = new System.Drawing.Point(60, 269);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(35, 20);
            this.labelX2.TabIndex = 18;
            this.labelX2.Text = "Số dư";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // buttonX3
            // 
            this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX3.Location = new System.Drawing.Point(165, 300);
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.Size = new System.Drawing.Size(60, 22);
            this.buttonX3.TabIndex = 17;
            this.buttonX3.Text = "Cập nhật";
            this.buttonX3.Click += new System.EventHandler(this.buttonX3_Click);
            // 
            // Them_btt
            // 
            this.Them_btt.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Them_btt.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Them_btt.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Them_btt.Location = new System.Drawing.Point(82, 300);
            this.Them_btt.Name = "Them_btt";
            this.Them_btt.Size = new System.Drawing.Size(71, 22);
            this.Them_btt.TabIndex = 16;
            this.Them_btt.Text = "Tạo mới ";
            this.Them_btt.Click += new System.EventHandler(this.Them_btt_Click);
            // 
            // Grid_MangSang
            // 
            this.Grid_MangSang.AllowUserToAddRows = false;
            this.Grid_MangSang.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid_MangSang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Grid_MangSang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_MangSang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NgayThang,
            this.SoTon,
            this.ID,
            this.SOTHU,
            this.SOChi});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid_MangSang.DefaultCellStyle = dataGridViewCellStyle6;
            this.Grid_MangSang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.Grid_MangSang.Location = new System.Drawing.Point(1, 43);
            this.Grid_MangSang.Name = "Grid_MangSang";
            this.Grid_MangSang.Size = new System.Drawing.Size(377, 215);
            this.Grid_MangSang.TabIndex = 15;
            this.Grid_MangSang.Click += new System.EventHandler(this.Grid_MangSang_Click);
            // 
            // NgayThang
            // 
            this.NgayThang.DataPropertyName = "NgayThang";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font(".VnTime", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = "dd/mm/yyyy";
            this.NgayThang.DefaultCellStyle = dataGridViewCellStyle2;
            this.NgayThang.HeaderText = "Ngày tháng";
            this.NgayThang.Name = "NgayThang";
            // 
            // SoTon
            // 
            this.SoTon.DataPropertyName = "SoTon";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font(".VnTime", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.Format = "0,0";
            dataGridViewCellStyle3.NullValue = "0";
            this.SoTon.DefaultCellStyle = dataGridViewCellStyle3;
            this.SoTon.HeaderText = "Số dư";
            this.SoTon.Name = "SoTon";
            this.SoTon.Width = 220;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // SOTHU
            // 
            this.SOTHU.DataPropertyName = "SoTHu";
            dataGridViewCellStyle4.Format = "C1";
            dataGridViewCellStyle4.NullValue = null;
            this.SOTHU.DefaultCellStyle = dataGridViewCellStyle4;
            this.SOTHU.HeaderText = "SOTHU";
            this.SOTHU.Name = "SOTHU";
            this.SOTHU.Visible = false;
            // 
            // SOChi
            // 
            this.SOChi.DataPropertyName = "SOChi";
            dataGridViewCellStyle5.Format = "C0";
            dataGridViewCellStyle5.NullValue = null;
            this.SOChi.DefaultCellStyle = dataGridViewCellStyle5;
            this.SOChi.HeaderText = "SoChi";
            this.SOChi.Name = "SOChi";
            this.SOChi.Visible = false;
            // 
            // intSoDu
            // 
            // 
            // 
            // 
            this.intSoDu.BackgroundStyle.Class = "DateTimeInputBackground";
            this.intSoDu.DisplayFormat = "0,0";
            this.intSoDu.Location = new System.Drawing.Point(101, 269);
            this.intSoDu.MinValue = -2147483647;
            this.intSoDu.Name = "intSoDu";
            this.intSoDu.Size = new System.Drawing.Size(112, 20);
            this.intSoDu.TabIndex = 22;
            // 
            // calendarCombo1
            // 
            // 
            // 
            // 
            this.calendarCombo1.DropDownCalendar.Office2007ColorScheme = Janus.Windows.CalendarCombo.Office2007ColorScheme.Silver;
            this.calendarCombo1.Location = new System.Drawing.Point(230, 269);
            this.calendarCombo1.Name = "calendarCombo1";
            this.calendarCombo1.Office2007ColorScheme = Janus.Windows.CalendarCombo.Office2007ColorScheme.Silver;
            this.calendarCombo1.Size = new System.Drawing.Size(88, 20);
            this.calendarCombo1.TabIndex = 23;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // bttBaoCao
            // 
            this.bttBaoCao.Location = new System.Drawing.Point(116, 12);
            this.bttBaoCao.Name = "bttBaoCao";
            this.bttBaoCao.Size = new System.Drawing.Size(41, 23);
            this.bttBaoCao.TabIndex = 42;
            this.bttBaoCao.Text = "OK";
            this.bttBaoCao.UseVisualStyleBackColor = true;
            this.bttBaoCao.Click += new System.EventHandler(this.bttBaoCao_Click);
            // 
            // mtxtThang
            // 
            // 
            // 
            // 
            this.mtxtThang.BackgroundStyle.Class = "TextBoxBorder";
            this.mtxtThang.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mtxtThang.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.mtxtThang.Location = new System.Drawing.Point(47, 14);
            this.mtxtThang.Mask = "00/0000";
            this.mtxtThang.Name = "mtxtThang";
            this.mtxtThang.Size = new System.Drawing.Size(53, 20);
            this.mtxtThang.TabIndex = 41;
            this.mtxtThang.Text = "";
            this.mtxtThang.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mtxtThang.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mtxtThang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtxtThang_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Tháng";
            // 
            // Frm_MangSang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 329);
            this.Controls.Add(this.bttBaoCao);
            this.Controls.Add(this.mtxtThang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calendarCombo1);
            this.Controls.Add(this.intSoDu);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.buttonX3);
            this.Controls.Add(this.Them_btt);
            this.Controls.Add(this.Grid_MangSang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(388, 363);
            this.MinimumSize = new System.Drawing.Size(388, 363);
            this.Name = "Frm_MangSang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Số tồn";
            this.Load += new System.EventHandler(this.Frm_MangSang_Load);
            this.Activated += new System.EventHandler(this.Frm_MangSang_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_MangSang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intSoDu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.ButtonX buttonX3;
        private DevComponents.DotNetBar.ButtonX Them_btt;
        private DevComponents.DotNetBar.Controls.DataGridViewX Grid_MangSang;
        private DevComponents.Editors.IntegerInput intSoDu;
        private Janus.Windows.CalendarCombo.CalendarCombo calendarCombo1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button bttBaoCao;
        private DevComponents.DotNetBar.Controls.MaskedTextBoxAdv mtxtThang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayThang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOTHU;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOChi;

    }
}