namespace GUI_Tier
{
    partial class XemDiem
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
            this.lblSoDiem = new System.Windows.Forms.Label();
            this.btnXemDiem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSoDiem
            // 
            this.lblSoDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoDiem.ForeColor = System.Drawing.Color.Red;
            this.lblSoDiem.Location = new System.Drawing.Point(12, 21);
            this.lblSoDiem.Name = "lblSoDiem";
            this.lblSoDiem.Size = new System.Drawing.Size(289, 26);
            this.lblSoDiem.TabIndex = 0;
            this.lblSoDiem.Text = "label1";
            this.lblSoDiem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnXemDiem
            // 
            this.btnXemDiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnXemDiem.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnXemDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemDiem.ForeColor = System.Drawing.Color.Cyan;
            this.btnXemDiem.Location = new System.Drawing.Point(45, 71);
            this.btnXemDiem.Name = "btnXemDiem";
            this.btnXemDiem.Size = new System.Drawing.Size(223, 35);
            this.btnXemDiem.TabIndex = 1;
            this.btnXemDiem.Text = "XEM ĐÁP ÁN";
            this.btnXemDiem.UseVisualStyleBackColor = false;
            this.btnXemDiem.Click += new System.EventHandler(this.btnXemDiem_Click);
            // 
            // XemDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(313, 126);
            this.ControlBox = false;
            this.Controls.Add(this.btnXemDiem);
            this.Controls.Add(this.lblSoDiem);
            this.Name = "XemDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.XemDiem_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSoDiem;
        private System.Windows.Forms.Button btnXemDiem;
    }
}