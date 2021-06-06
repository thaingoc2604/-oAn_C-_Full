namespace Accounting
{
    partial class Frm_PrintDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_PrintDialog));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioBttInRaMayIn = new System.Windows.Forms.RadioButton();
            this.radiobttInRaManhinh = new System.Windows.Forms.RadioButton();
            this.bttOk = new System.Windows.Forms.Button();
            this.BttCLose = new System.Windows.Forms.Button();
            this.bttPrintSetup = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBttInRaMayIn);
            this.groupBox1.Controls.Add(this.radiobttInRaManhinh);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(134, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đầu ra";
            // 
            // radioBttInRaMayIn
            // 
            this.radioBttInRaMayIn.AutoSize = true;
            this.radioBttInRaMayIn.ForeColor = System.Drawing.Color.Black;
            this.radioBttInRaMayIn.Location = new System.Drawing.Point(16, 48);
            this.radioBttInRaMayIn.Name = "radioBttInRaMayIn";
            this.radioBttInRaMayIn.Size = new System.Drawing.Size(100, 19);
            this.radioBttInRaMayIn.TabIndex = 1;
            this.radioBttInRaMayIn.TabStop = true;
            this.radioBttInRaMayIn.Text = "In ra máy in";
            this.radioBttInRaMayIn.UseVisualStyleBackColor = true;
            // 
            // radiobttInRaManhinh
            // 
            this.radiobttInRaManhinh.AutoSize = true;
            this.radiobttInRaManhinh.ForeColor = System.Drawing.Color.Black;
            this.radiobttInRaManhinh.Location = new System.Drawing.Point(16, 23);
            this.radiobttInRaManhinh.Name = "radiobttInRaManhinh";
            this.radiobttInRaManhinh.Size = new System.Drawing.Size(118, 19);
            this.radiobttInRaManhinh.TabIndex = 0;
            this.radiobttInRaManhinh.TabStop = true;
            this.radiobttInRaManhinh.Text = "In ra màn hình";
            this.radiobttInRaManhinh.UseVisualStyleBackColor = true;
            // 
            // bttOk
            // 
            this.bttOk.Location = new System.Drawing.Point(133, 98);
            this.bttOk.Name = "bttOk";
            this.bttOk.Size = new System.Drawing.Size(75, 23);
            this.bttOk.TabIndex = 2;
            this.bttOk.Text = "&OK";
            this.bttOk.UseVisualStyleBackColor = true;
            this.bttOk.Click += new System.EventHandler(this.bttOk_Click);
            // 
            // BttCLose
            // 
            this.BttCLose.Location = new System.Drawing.Point(214, 98);
            this.BttCLose.Name = "BttCLose";
            this.BttCLose.Size = new System.Drawing.Size(75, 23);
            this.BttCLose.TabIndex = 3;
            this.BttCLose.Text = "&Close";
            this.BttCLose.UseVisualStyleBackColor = true;
            this.BttCLose.Click += new System.EventHandler(this.BttCLose_Click);
            // 
            // bttPrintSetup
            // 
            this.bttPrintSetup.Location = new System.Drawing.Point(295, 98);
            this.bttPrintSetup.Name = "bttPrintSetup";
            this.bttPrintSetup.Size = new System.Drawing.Size(75, 23);
            this.bttPrintSetup.TabIndex = 4;
            this.bttPrintSetup.Text = "&Print Setup";
            this.bttPrintSetup.UseVisualStyleBackColor = true;
            this.bttPrintSetup.Click += new System.EventHandler(this.bttPrintSetup_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_PrintDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(377, 137);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bttPrintSetup);
            this.Controls.Add(this.BttCLose);
            this.Controls.Add(this.bttOk);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(420, 161);
            this.MinimumSize = new System.Drawing.Size(383, 161);
            this.Name = "Frm_PrintDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Printer";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frm_PrintDialog_KeyPress);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_PrintDialog_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioBttInRaMayIn;
        private System.Windows.Forms.RadioButton radiobttInRaManhinh;
        private System.Windows.Forms.Button bttOk;
        private System.Windows.Forms.Button BttCLose;
        private System.Windows.Forms.Button bttPrintSetup;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}