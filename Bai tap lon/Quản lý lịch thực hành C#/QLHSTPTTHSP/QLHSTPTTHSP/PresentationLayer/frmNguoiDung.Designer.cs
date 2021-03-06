namespace QLHSTPTTHSP.PresentationLayer
{
    partial class frmNguoiDung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNguoiDung));
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.buttonItemThem = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemXoa = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemSua = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemLuuNguoiDung = new DevComponents.DotNetBar.ButtonItem();
            this.SuspendLayout();
            // 
            // ribbonBar1
            // 
            this.ribbonBar1.AutoOverflowEnabled = true;
            this.ribbonBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ribbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItemThem,
            this.buttonItemXoa,
            this.buttonItemSua,
            this.buttonItemLuuNguoiDung});
            this.ribbonBar1.Location = new System.Drawing.Point(0, 359);
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.Size = new System.Drawing.Size(732, 55);
            this.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar1.TabIndex = 8;
            // 
            // buttonItemThem
            // 
            this.buttonItemThem.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemThem.Icon = ((System.Drawing.Icon)(resources.GetObject("buttonItemThem.Icon")));
            this.buttonItemThem.ImagePaddingHorizontal = 8;
            this.buttonItemThem.Name = "buttonItemThem";
            this.buttonItemThem.SubItemsExpandWidth = 14;
            this.buttonItemThem.Text = "Thêm";
            this.buttonItemThem.Tooltip = "Thêm niên học mới";
            // 
            // buttonItemXoa
            // 
            this.buttonItemXoa.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemXoa.Icon = ((System.Drawing.Icon)(resources.GetObject("buttonItemXoa.Icon")));
            this.buttonItemXoa.ImagePaddingHorizontal = 8;
            this.buttonItemXoa.Name = "buttonItemXoa";
            this.buttonItemXoa.SubItemsExpandWidth = 14;
            this.buttonItemXoa.Text = "Xóa";
            this.buttonItemXoa.Tooltip = "Xóa niên học";
            // 
            // buttonItemSua
            // 
            this.buttonItemSua.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemSua.Icon = ((System.Drawing.Icon)(resources.GetObject("buttonItemSua.Icon")));
            this.buttonItemSua.ImagePaddingHorizontal = 8;
            this.buttonItemSua.Name = "buttonItemSua";
            this.buttonItemSua.SubItemsExpandWidth = 14;
            this.buttonItemSua.Text = "Sửa";
            this.buttonItemSua.Tooltip = "Sửa thông tin niên học";
            // 
            // buttonItemLuuNguoiDung
            // 
            this.buttonItemLuuNguoiDung.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemLuuNguoiDung.Icon = ((System.Drawing.Icon)(resources.GetObject("buttonItemLuuNguoiDung.Icon")));
            this.buttonItemLuuNguoiDung.ImagePaddingHorizontal = 8;
            this.buttonItemLuuNguoiDung.Name = "buttonItemLuuNguoiDung";
            this.buttonItemLuuNguoiDung.SubItemsExpandWidth = 14;
            this.buttonItemLuuNguoiDung.Text = "Lưu";
            this.buttonItemLuuNguoiDung.Tooltip = "Lưu lại những thay đổi";
            // 
            // frmNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 414);
            this.Controls.Add(this.ribbonBar1);
            this.Name = "frmNguoiDung";
            this.Text = "frmNguoiDung";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.RibbonBar ribbonBar1;
        private DevComponents.DotNetBar.ButtonItem buttonItemThem;
        private DevComponents.DotNetBar.ButtonItem buttonItemXoa;
        private DevComponents.DotNetBar.ButtonItem buttonItemSua;
        private DevComponents.DotNetBar.ButtonItem buttonItemLuuNguoiDung;
    }
}