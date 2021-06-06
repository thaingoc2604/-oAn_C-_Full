namespace QuanLyTV
{
    partial class ThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongKe));
            this.toolBar = new System.Windows.Forms.ToolBar();
            this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton3 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton4 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton5 = new System.Windows.Forms.ToolBarButton();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // toolBar
            // 
            this.toolBar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.toolBarButton2,
            this.toolBarButton3,
            this.toolBarButton4,
            this.toolBarButton5});
            this.toolBar.ButtonSize = new System.Drawing.Size(96, 50);
            this.toolBar.DropDownArrows = true;
            this.toolBar.ImageList = this.imageList2;
            this.toolBar.Location = new System.Drawing.Point(0, 0);
            this.toolBar.Name = "toolBar";
            this.toolBar.ShowToolTips = true;
            this.toolBar.Size = new System.Drawing.Size(1008, 56);
            this.toolBar.TabIndex = 6;
            this.toolBar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar_ButtonClick);
            // 
            // toolBarButton2
            // 
            this.toolBarButton2.ImageIndex = 7;
            this.toolBarButton2.Name = "toolBarButton2";
            this.toolBarButton2.Text = "Độc Giả";
            // 
            // toolBarButton3
            // 
            this.toolBarButton3.ImageKey = "Net 10.ico";
            this.toolBarButton3.Name = "toolBarButton3";
            this.toolBarButton3.Text = "Nhân Viên";
            // 
            // toolBarButton4
            // 
            this.toolBarButton4.ImageKey = "Net 51.ico";
            this.toolBarButton4.Name = "toolBarButton4";
            this.toolBarButton4.Text = "Các Đầu Sách";
            // 
            // toolBarButton5
            // 
            this.toolBarButton5.ImageKey = "Net 49.ico";
            this.toolBarButton5.Name = "toolBarButton5";
            this.toolBarButton5.Text = "Mượn Sách";
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "Net 10.ico");
            this.imageList2.Images.SetKeyName(1, "Net 14.ico");
            this.imageList2.Images.SetKeyName(2, "Net 20.ico");
            this.imageList2.Images.SetKeyName(3, "Net 24.ico");
            this.imageList2.Images.SetKeyName(4, "Net 25.ico");
            this.imageList2.Images.SetKeyName(5, "Net 26.ico");
            this.imageList2.Images.SetKeyName(6, "Net 27.ico");
            this.imageList2.Images.SetKeyName(7, "Net 34.ico");
            this.imageList2.Images.SetKeyName(8, "Net 36.ico");
            this.imageList2.Images.SetKeyName(9, "Net 43.ico");
            this.imageList2.Images.SetKeyName(10, "Net 49.ico");
            this.imageList2.Images.SetKeyName(11, "Net 50.ico");
            this.imageList2.Images.SetKeyName(12, "Net 51.ico");
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.toolBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "ThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống Kê";
            this.Load += new System.EventHandler(this.ThongKe_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ThongKe_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolBar toolBar;
        private System.Windows.Forms.ToolBarButton toolBarButton2;
        private System.Windows.Forms.ToolBarButton toolBarButton3;
        private System.Windows.Forms.ToolBarButton toolBarButton4;
        private System.Windows.Forms.ToolBarButton toolBarButton5;
        public System.Windows.Forms.ImageList imageList1;
        public System.Windows.Forms.ImageList imageList2;
    }
}