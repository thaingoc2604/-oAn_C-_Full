namespace QUANLYNHANSU
{
    partial class frmrptChamCong
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.bntXuat = new DevComponents.DotNetBar.ButtonX();
            this.cmbNam = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.reflectionLabel2 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.cmbThang = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.progressBarX1 = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.cmbPhongBan = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.reflectionLabel3 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.DisplayGroupTree = false;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 83);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.SelectionFormula = "";
            this.crystalReportViewer1.Size = new System.Drawing.Size(974, 649);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ViewTimeSelectionFormula = "";
            // 
            // bntXuat
            // 
            this.bntXuat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bntXuat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bntXuat.Location = new System.Drawing.Point(694, 30);
            this.bntXuat.Name = "bntXuat";
            this.bntXuat.Size = new System.Drawing.Size(75, 23);
            this.bntXuat.TabIndex = 13;
            this.bntXuat.Text = "Xuất báo cáo";
            this.bntXuat.Click += new System.EventHandler(this.bntXuat_Click);
            // 
            // cmbNam
            // 
            this.cmbNam.DisplayMember = "Text";
            this.cmbNam.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbNam.FormattingEnabled = true;
            this.cmbNam.ItemHeight = 14;
            this.cmbNam.Location = new System.Drawing.Point(301, 30);
            this.cmbNam.Name = "cmbNam";
            this.cmbNam.Size = new System.Drawing.Size(93, 20);
            this.cmbNam.TabIndex = 12;
            // 
            // reflectionLabel2
            // 
            this.reflectionLabel2.Location = new System.Drawing.Point(232, 30);
            this.reflectionLabel2.Name = "reflectionLabel2";
            this.reflectionLabel2.Size = new System.Drawing.Size(63, 20);
            this.reflectionLabel2.TabIndex = 11;
            this.reflectionLabel2.Text = "Chọn năm";
            // 
            // cmbThang
            // 
            this.cmbThang.DisplayMember = "Text";
            this.cmbThang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbThang.FormattingEnabled = true;
            this.cmbThang.ItemHeight = 14;
            this.cmbThang.Location = new System.Drawing.Point(138, 30);
            this.cmbThang.Name = "cmbThang";
            this.cmbThang.Size = new System.Drawing.Size(75, 20);
            this.cmbThang.TabIndex = 10;
            // 
            // reflectionLabel1
            // 
            this.reflectionLabel1.Location = new System.Drawing.Point(69, 30);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(63, 20);
            this.reflectionLabel1.TabIndex = 9;
            this.reflectionLabel1.Text = "Chọn tháng";
            // 
            // progressBarX1
            // 
            this.progressBarX1.Location = new System.Drawing.Point(246, 330);
            this.progressBarX1.Name = "progressBarX1";
            this.progressBarX1.Size = new System.Drawing.Size(456, 23);
            this.progressBarX1.TabIndex = 14;
            this.progressBarX1.Text = "progressBarX1";
            this.progressBarX1.TextVisible = true;
            // 
            // cmbPhongBan
            // 
            this.cmbPhongBan.DisplayMember = "Text";
            this.cmbPhongBan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPhongBan.FormattingEnabled = true;
            this.cmbPhongBan.ItemHeight = 14;
            this.cmbPhongBan.Items.AddRange(new object[] {
            this.comboItem1});
            this.cmbPhongBan.Location = new System.Drawing.Point(524, 30);
            this.cmbPhongBan.Name = "cmbPhongBan";
            this.cmbPhongBan.Size = new System.Drawing.Size(93, 20);
            this.cmbPhongBan.TabIndex = 16;
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "Tất cả";
            // 
            // reflectionLabel3
            // 
            this.reflectionLabel3.Location = new System.Drawing.Point(424, 30);
            this.reflectionLabel3.Name = "reflectionLabel3";
            this.reflectionLabel3.Size = new System.Drawing.Size(85, 20);
            this.reflectionLabel3.TabIndex = 15;
            this.reflectionLabel3.Text = "Chọn phòng ban";
            // 
            // frmrptChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 732);
            this.Controls.Add(this.cmbPhongBan);
            this.Controls.Add(this.reflectionLabel3);
            this.Controls.Add(this.progressBarX1);
            this.Controls.Add(this.bntXuat);
            this.Controls.Add(this.cmbNam);
            this.Controls.Add(this.reflectionLabel2);
            this.Controls.Add(this.cmbThang);
            this.Controls.Add(this.reflectionLabel1);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "frmrptChamCong";
            this.Text = "Bảng chấm công";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmrptChamCong_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private DevComponents.DotNetBar.ButtonX bntXuat;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbNam;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbThang;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
        private DevComponents.DotNetBar.Controls.ProgressBarX progressBarX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbPhongBan;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel3;
        private DevComponents.Editors.ComboItem comboItem1;

    }
}