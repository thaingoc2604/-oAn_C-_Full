namespace QUANLYNHANSU
{
    partial class frmKiemTraKetNoi
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtSer = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDB = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.bntKiemTra = new DevComponents.DotNetBar.ButtonX();
            this.comboBoxEx1 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            this.labelX1.Location = new System.Drawing.Point(62, 29);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(45, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Server";
            // 
            // txtSer
            // 
            // 
            // 
            // 
            this.txtSer.Border.Class = "TextBoxBorder";
            this.txtSer.Location = new System.Drawing.Point(124, 29);
            this.txtSer.Name = "txtSer";
            this.txtSer.Size = new System.Drawing.Size(118, 20);
            this.txtSer.TabIndex = 1;
            // 
            // txtDB
            // 
            // 
            // 
            // 
            this.txtDB.Border.Class = "TextBoxBorder";
            this.txtDB.Location = new System.Drawing.Point(124, 69);
            this.txtDB.Name = "txtDB";
            this.txtDB.Size = new System.Drawing.Size(118, 20);
            this.txtDB.TabIndex = 3;
            // 
            // labelX2
            // 
            this.labelX2.Location = new System.Drawing.Point(62, 69);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(45, 23);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "CSDL";
            // 
            // bntKiemTra
            // 
            this.bntKiemTra.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bntKiemTra.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bntKiemTra.Location = new System.Drawing.Point(124, 218);
            this.bntKiemTra.Name = "bntKiemTra";
            this.bntKiemTra.Size = new System.Drawing.Size(75, 23);
            this.bntKiemTra.TabIndex = 4;
            this.bntKiemTra.Text = "Kiểm tra";
            this.bntKiemTra.Click += new System.EventHandler(this.bntKiemTra_Click);
            // 
            // comboBoxEx1
            // 
            this.comboBoxEx1.DisplayMember = "Text";
            this.comboBoxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEx1.FormattingEnabled = true;
            this.comboBoxEx1.ItemHeight = 14;
            this.comboBoxEx1.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2});
            this.comboBoxEx1.Location = new System.Drawing.Point(124, 101);
            this.comboBoxEx1.Name = "comboBoxEx1";
            this.comboBoxEx1.Size = new System.Drawing.Size(118, 20);
            this.comboBoxEx1.TabIndex = 5;
            // 
            // labelX3
            // 
            this.labelX3.Location = new System.Drawing.Point(30, 98);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(88, 23);
            this.labelX3.TabIndex = 6;
            this.labelX3.Text = "Phiên bản SQL";
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "2000";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "2005";
            // 
            // frmKiemTraKetNoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 265);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.comboBoxEx1);
            this.Controls.Add(this.bntKiemTra);
            this.Controls.Add(this.txtDB);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.txtSer);
            this.Controls.Add(this.labelX1);
            this.Name = "frmKiemTraKetNoi";
            this.Text = "frmKiemTraKetNoi";
            this.Load += new System.EventHandler(this.frmKiemTraKetNoi_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSer;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDB;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.ButtonX bntKiemTra;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx1;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
    }
}