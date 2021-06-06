namespace DeTai_QuanLySinhVien
{
    partial class frmTroGiup
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
            this.pnThongTin = new DevComponents.DotNetBar.PanelEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.pnThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnThongTin
            // 
            this.pnThongTin.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnThongTin.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnThongTin.Controls.Add(this.labelX1);
            this.pnThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnThongTin.Location = new System.Drawing.Point(0, 0);
            this.pnThongTin.Name = "pnThongTin";
            this.pnThongTin.Size = new System.Drawing.Size(751, 447);
            this.pnThongTin.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnThongTin.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnThongTin.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnThongTin.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnThongTin.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnThongTin.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnThongTin.Style.GradientAngle = 90;
            this.pnThongTin.TabIndex = 0;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelX1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(0, 0);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(751, 447);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = " Thông tin liên hệ: Lớp ICTV4 Nhóm 4 Topica_Elearning_TVU";
            this.labelX1.TextLineAlignment = System.Drawing.StringAlignment.Near;
            // 
            // frmTroGiup
            // 
            this.ClientSize = new System.Drawing.Size(751, 447);
            this.Controls.Add(this.pnThongTin);
            this.DoubleBuffered = true;
            this.Name = "frmTroGiup";
            this.Text = "Trợ Giúp";
            this.Load += new System.EventHandler(this.frmTroGiup_Load);
            this.pnThongTin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx pnThongTin;
        private DevComponents.DotNetBar.LabelX labelX1;

    }
}