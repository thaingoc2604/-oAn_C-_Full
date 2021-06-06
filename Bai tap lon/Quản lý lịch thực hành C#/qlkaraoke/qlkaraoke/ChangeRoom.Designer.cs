namespace qlkaraoke
{
    partial class fChangeRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fChangeRoom));
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fChangeRoomCBoxFrom = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fChangeRoomCBoxTo = new System.Windows.Forms.ComboBox();
            this.fChangeRoomBtnAccept = new System.Windows.Forms.Button();
            this.fChangeRoomBtnClose = new System.Windows.Forms.Button();
            this.roomTableAdapter1 = new qlkaraoke.DataSet1TableAdapters.RoomTableAdapter();
            this.billsTableAdapter1 = new qlkaraoke.DataSet1TableAdapters.BillsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(516, 23);
            this.label3.TabIndex = 18;
            this.label3.Text = "CHANGE ROOM";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::qlkaraoke.Properties.Resources.karaoke2;
            this.pictureBox2.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BackgroundImage = global::qlkaraoke.Properties.Resources.karaoke3;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(572, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // fChangeRoomCBoxFrom
            // 
            this.fChangeRoomCBoxFrom.FormattingEnabled = true;
            this.fChangeRoomCBoxFrom.Location = new System.Drawing.Point(50, 79);
            this.fChangeRoomCBoxFrom.Name = "fChangeRoomCBoxFrom";
            this.fChangeRoomCBoxFrom.Size = new System.Drawing.Size(175, 21);
            this.fChangeRoomCBoxFrom.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(14, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "From";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(321, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "To";
            // 
            // fChangeRoomCBoxTo
            // 
            this.fChangeRoomCBoxTo.FormattingEnabled = true;
            this.fChangeRoomCBoxTo.Location = new System.Drawing.Point(347, 79);
            this.fChangeRoomCBoxTo.Name = "fChangeRoomCBoxTo";
            this.fChangeRoomCBoxTo.Size = new System.Drawing.Size(195, 21);
            this.fChangeRoomCBoxTo.TabIndex = 39;
            // 
            // fChangeRoomBtnAccept
            // 
            this.fChangeRoomBtnAccept.BackgroundImage = global::qlkaraoke.Properties.Resources.btn11;
            this.fChangeRoomBtnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fChangeRoomBtnAccept.Location = new System.Drawing.Point(197, 152);
            this.fChangeRoomBtnAccept.Name = "fChangeRoomBtnAccept";
            this.fChangeRoomBtnAccept.Size = new System.Drawing.Size(87, 39);
            this.fChangeRoomBtnAccept.TabIndex = 40;
            this.fChangeRoomBtnAccept.Text = "Accept";
            this.fChangeRoomBtnAccept.UseVisualStyleBackColor = true;
            this.fChangeRoomBtnAccept.MouseLeave += new System.EventHandler(this.fChangeRoomBtnAccept_MouseLeave);
            this.fChangeRoomBtnAccept.Click += new System.EventHandler(this.fChangeRoomBtnAccept_Click);
            this.fChangeRoomBtnAccept.MouseEnter += new System.EventHandler(this.fChangeRoomBtnAccept_MouseEnter);
            // 
            // fChangeRoomBtnClose
            // 
            this.fChangeRoomBtnClose.BackgroundImage = global::qlkaraoke.Properties.Resources.btn11;
            this.fChangeRoomBtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fChangeRoomBtnClose.Location = new System.Drawing.Point(290, 152);
            this.fChangeRoomBtnClose.Name = "fChangeRoomBtnClose";
            this.fChangeRoomBtnClose.Size = new System.Drawing.Size(87, 39);
            this.fChangeRoomBtnClose.TabIndex = 41;
            this.fChangeRoomBtnClose.Text = "Close";
            this.fChangeRoomBtnClose.UseVisualStyleBackColor = true;
            this.fChangeRoomBtnClose.MouseLeave += new System.EventHandler(this.fChangeRoomBtnClose_MouseLeave);
            this.fChangeRoomBtnClose.Click += new System.EventHandler(this.fChangeRoomBtnClose_Click);
            this.fChangeRoomBtnClose.MouseEnter += new System.EventHandler(this.fChangeRoomBtnClose_MouseEnter);
            // 
            // roomTableAdapter1
            // 
            this.roomTableAdapter1.ClearBeforeFill = true;
            // 
            // billsTableAdapter1
            // 
            this.billsTableAdapter1.ClearBeforeFill = true;
            // 
            // fChangeRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::qlkaraoke.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(572, 220);
            this.Controls.Add(this.fChangeRoomBtnClose);
            this.Controls.Add(this.fChangeRoomBtnAccept);
            this.Controls.Add(this.fChangeRoomCBoxTo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.fChangeRoomCBoxFrom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fChangeRoom";
            this.Text = "QL KARAOKE - Change Room";
            this.Load += new System.EventHandler(this.fChangeRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox fChangeRoomCBoxFrom;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox fChangeRoomCBoxTo;
        private System.Windows.Forms.Button fChangeRoomBtnAccept;
        private System.Windows.Forms.Button fChangeRoomBtnClose;
        private qlkaraoke.DataSet1TableAdapters.RoomTableAdapter roomTableAdapter1;
        private qlkaraoke.DataSet1TableAdapters.BillsTableAdapter billsTableAdapter1;
    }
}