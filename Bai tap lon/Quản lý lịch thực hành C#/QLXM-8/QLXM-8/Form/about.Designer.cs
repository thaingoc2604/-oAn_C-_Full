namespace QLXM_8
{
    partial class about
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(about));
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.reflectionImage1 = new DevComponents.DotNetBar.Controls.ReflectionImage();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            this.labelX1.Location = new System.Drawing.Point(228, 26);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(261, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Tên Phần Mềm : Quản Lý Cửa Hàng Bán Xe Máy";
            // 
            // labelX2
            // 
            this.labelX2.Location = new System.Drawing.Point(228, 69);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(135, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Phiên Bản : 1.0.0";
            // 
            // labelX3
            // 
            this.labelX3.Location = new System.Drawing.Point(228, 108);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(200, 23);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "Giáo Viên hướng dẫn : ...............";
            // 
            // labelX4
            // 
            this.labelX4.Location = new System.Drawing.Point(228, 150);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(182, 23);
            this.labelX4.TabIndex = 3;
            this.labelX4.Text = "Tác Giả : Nhóm 8 - Lớp TIN16AGT :";
            // 
            // labelX5
            // 
            this.labelX5.Location = new System.Drawing.Point(408, 150);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(103, 48);
            this.labelX5.TabIndex = 4;
            this.labelX5.Text = "Ngô Thị Lan\r\nNguyễn Văn Hòa\r\nNguyễn Sơn Tùng";
            // 
            // reflectionImage1
            // 
            // 
            // 
            // 
            this.reflectionImage1.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.reflectionImage1.Image = ((System.Drawing.Image)(resources.GetObject("reflectionImage1.Image")));
            this.reflectionImage1.Location = new System.Drawing.Point(16, 13);
            this.reflectionImage1.Name = "reflectionImage1";
            this.reflectionImage1.Size = new System.Drawing.Size(188, 199);
            this.reflectionImage1.TabIndex = 5;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(353, 218);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(120, 23);
            this.buttonX1.TabIndex = 6;
            this.buttonX1.Text = "0k";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // about
            // 
            this.ClientSize = new System.Drawing.Size(521, 255);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.reflectionImage1);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Name = "about";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.ReflectionImage reflectionImage1;
        private DevComponents.DotNetBar.ButtonX buttonX1;
    }
}