﻿namespace Quanlydoanvien
{
    partial class frmChonMADVtimkiem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChonMADVtimkiem));
            this.dgchon = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtmadv = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnchon = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dgchon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgchon
            // 
            this.dgchon.AllowUserToAddRows = false;
            this.dgchon.AllowUserToDeleteRows = false;
            this.dgchon.BackgroundColor = System.Drawing.Color.LightYellow;
            this.dgchon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgchon.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgchon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgchon.Location = new System.Drawing.Point(75, 92);
            this.dgchon.Name = "dgchon";
            this.dgchon.ReadOnly = true;
            this.dgchon.Size = new System.Drawing.Size(143, 150);
            this.dgchon.TabIndex = 11;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.Location = new System.Drawing.Point(24, 25);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(122, 22);
            this.labelX1.TabIndex = 10;
            this.labelX1.Text = "Mã đoàn viên được chọn";
            // 
            // txtmadv
            // 
            // 
            // 
            // 
            this.txtmadv.Border.Class = "TextBoxBorder";
            this.txtmadv.Location = new System.Drawing.Point(148, 27);
            this.txtmadv.Name = "txtmadv";
            this.txtmadv.ReadOnly = true;
            this.txtmadv.Size = new System.Drawing.Size(100, 20);
            this.txtmadv.TabIndex = 9;
            // 
            // btnchon
            // 
            this.btnchon.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnchon.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnchon.Location = new System.Drawing.Point(63, 54);
            this.btnchon.Name = "btnchon";
            this.btnchon.Size = new System.Drawing.Size(166, 23);
            this.btnchon.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnchon.TabIndex = 8;
            this.btnchon.Text = "Chọn mã đoàn viên này này!";
            this.btnchon.Click += new System.EventHandler(this.btnchon_Click);
            // 
            // frmChonMADVtimkiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 267);
            this.Controls.Add(this.dgchon);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.txtmadv);
            this.Controls.Add(this.btnchon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmChonMADVtimkiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn mã đoàn viên";
            this.Load += new System.EventHandler(this.frmChonMADVtimkiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgchon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgchon;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtmadv;
        private DevComponents.DotNetBar.ButtonX btnchon;
    }
}