namespace Accounting
{
    partial class Form_DienGiai
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_DienGiai));
            this.DienGiai_Grid = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.buttonX3 = new DevComponents.DotNetBar.ButtonX();
            this.Them_btt = new DevComponents.DotNetBar.ButtonX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtdiengiai = new System.Windows.Forms.TextBox();
            this.MaDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienGiai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtmaDG = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DienGiai_Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // DienGiai_Grid
            // 
            this.DienGiai_Grid.AllowUserToAddRows = false;
            this.DienGiai_Grid.AllowUserToDeleteRows = false;
            this.DienGiai_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DienGiai_Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDG,
            this.DienGiai});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DienGiai_Grid.DefaultCellStyle = dataGridViewCellStyle3;
            this.DienGiai_Grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.DienGiai_Grid.Location = new System.Drawing.Point(0, 5);
            this.DienGiai_Grid.Name = "DienGiai_Grid";
            this.DienGiai_Grid.Size = new System.Drawing.Size(454, 156);
            this.DienGiai_Grid.TabIndex = 0;
            this.DienGiai_Grid.Click += new System.EventHandler(this.DienGiai_Grid_Click);
            // 
            // buttonX3
            // 
            this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX3.Location = new System.Drawing.Point(210, 211);
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.Size = new System.Drawing.Size(60, 22);
            this.buttonX3.TabIndex = 7;
            this.buttonX3.Text = "Sửa DG";
            this.buttonX3.Click += new System.EventHandler(this.buttonX3_Click);
            // 
            // Them_btt
            // 
            this.Them_btt.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Them_btt.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Them_btt.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Them_btt.Location = new System.Drawing.Point(127, 211);
            this.Them_btt.Name = "Them_btt";
            this.Them_btt.Size = new System.Drawing.Size(71, 22);
            this.Them_btt.TabIndex = 5;
            this.Them_btt.Text = "Thêm mã";
            this.Them_btt.Click += new System.EventHandler(this.THEM_Click);
            // 
            // labelX2
            // 
            this.labelX2.Location = new System.Drawing.Point(10, 175);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(70, 23);
            this.labelX2.TabIndex = 11;
            this.labelX2.Text = "Tên diễn giải";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX1.Location = new System.Drawing.Point(282, 211);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(60, 22);
            this.buttonX1.TabIndex = 12;
            this.buttonX1.Text = "Thoát";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // txtdiengiai
            // 
            this.txtdiengiai.Font = new System.Drawing.Font(".VnTime", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiengiai.Location = new System.Drawing.Point(86, 174);
            this.txtdiengiai.Name = "txtdiengiai";
            this.txtdiengiai.Size = new System.Drawing.Size(356, 24);
            this.txtdiengiai.TabIndex = 13;
            // 
            // MaDG
            // 
            this.MaDG.DataPropertyName = "MaDG";
            dataGridViewCellStyle1.Font = new System.Drawing.Font(".VnTime", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaDG.DefaultCellStyle = dataGridViewCellStyle1;
            this.MaDG.HeaderText = "Mã số";
            this.MaDG.Name = "MaDG";
            this.MaDG.Visible = false;
            // 
            // DienGiai
            // 
            this.DienGiai.DataPropertyName = "DienGiai";
            dataGridViewCellStyle2.Font = new System.Drawing.Font(".VnTime", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DienGiai.DefaultCellStyle = dataGridViewCellStyle2;
            this.DienGiai.HeaderText = "Lý do";
            this.DienGiai.Name = "DienGiai";
            this.DienGiai.Width = 400;
            // 
            // txtmaDG
            // 
            this.txtmaDG.Font = new System.Drawing.Font(".VnTime", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmaDG.Location = new System.Drawing.Point(12, 211);
            this.txtmaDG.Name = "txtmaDG";
            this.txtmaDG.Size = new System.Drawing.Size(72, 24);
            this.txtmaDG.TabIndex = 14;
            this.txtmaDG.Visible = false;
            // 
            // Form_DienGiai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 244);
            this.Controls.Add(this.txtmaDG);
            this.Controls.Add(this.txtdiengiai);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.buttonX3);
            this.Controls.Add(this.Them_btt);
            this.Controls.Add(this.DienGiai_Grid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(462, 300);
            this.Name = "Form_DienGiai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục lý do";
            this.Load += new System.EventHandler(this.Form_DienGiai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DienGiai_Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX DienGiai_Grid;
        private DevComponents.DotNetBar.ButtonX buttonX3;
        private DevComponents.DotNetBar.ButtonX Them_btt;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.TextBox txtdiengiai;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienGiai;
        private System.Windows.Forms.TextBox txtmaDG;
    }
}