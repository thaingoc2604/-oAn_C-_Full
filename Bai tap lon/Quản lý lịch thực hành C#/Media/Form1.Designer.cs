namespace Media
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.trackWave = new System.Windows.Forms.TrackBar();
            this.button_stopfile = new System.Windows.Forms.Button();
            this.button_palyfile = new System.Windows.Forms.Button();
            this.button_openfile = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.trackWave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // trackWave
            // 
            this.trackWave.Location = new System.Drawing.Point(372, 49);
            this.trackWave.Name = "trackWave";
            this.trackWave.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackWave.Size = new System.Drawing.Size(45, 245);
            this.trackWave.TabIndex = 1;
            this.trackWave.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackWave.Scroll += new System.EventHandler(this.trackWave_Scroll);
            // 
            // button_stopfile
            // 
            this.button_stopfile.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_stopfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_stopfile.Image = global::Media.Properties.Resources._7978;
            this.button_stopfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_stopfile.Location = new System.Drawing.Point(187, 289);
            this.button_stopfile.Name = "button_stopfile";
            this.button_stopfile.Size = new System.Drawing.Size(75, 23);
            this.button_stopfile.TabIndex = 5;
            this.button_stopfile.Text = "Stop";
            this.button_stopfile.UseVisualStyleBackColor = true;
            this.button_stopfile.Click += new System.EventHandler(this.button_stopfile_Click);
            // 
            // button_palyfile
            // 
            this.button_palyfile.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_palyfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_palyfile.Image = global::Media.Properties.Resources._7978;
            this.button_palyfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_palyfile.Location = new System.Drawing.Point(94, 289);
            this.button_palyfile.Name = "button_palyfile";
            this.button_palyfile.Size = new System.Drawing.Size(75, 23);
            this.button_palyfile.TabIndex = 4;
            this.button_palyfile.Text = "Play";
            this.button_palyfile.UseVisualStyleBackColor = true;
            this.button_palyfile.Click += new System.EventHandler(this.button_palyfile_Click);
            // 
            // button_openfile
            // 
            this.button_openfile.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_openfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_openfile.Image = global::Media.Properties.Resources._7978;
            this.button_openfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_openfile.Location = new System.Drawing.Point(2, 290);
            this.button_openfile.Name = "button_openfile";
            this.button_openfile.Size = new System.Drawing.Size(75, 23);
            this.button_openfile.TabIndex = 3;
            this.button_openfile.Text = "Open";
            this.button_openfile.UseVisualStyleBackColor = true;
            this.button_openfile.Click += new System.EventHandler(this.button_openfile_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Media.Properties.Resources._7139;
            this.pictureBox2.Location = new System.Drawing.Point(369, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::Media.Properties.Resources._79781;
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(364, 282);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(420, 320);
            this.Controls.Add(this.button_stopfile);
            this.Controls.Add(this.button_palyfile);
            this.Controls.Add(this.button_openfile);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.trackWave);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Media";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackWave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar trackWave;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button_openfile;
        private System.Windows.Forms.Button button_palyfile;
        private System.Windows.Forms.Button button_stopfile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

