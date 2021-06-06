namespace qlkaraoke
{
    partial class uaGoodsKind
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uaGoodsKindDGList = new System.Windows.Forms.DataGridView();
            this.uaGoodsKindBtnDelete = new System.Windows.Forms.Button();
            this.uaGoodsKindBtnUpdate = new System.Windows.Forms.Button();
            this.uaGoodsKindBtnInsert = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.uaGoodsKindDGList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uaGoodsKindDGList
            // 
            this.uaGoodsKindDGList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.uaGoodsKindDGList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uaGoodsKindDGList.Location = new System.Drawing.Point(3, 16);
            this.uaGoodsKindDGList.Name = "uaGoodsKindDGList";
            this.uaGoodsKindDGList.Size = new System.Drawing.Size(552, 181);
            this.uaGoodsKindDGList.TabIndex = 0;
            // 
            // uaGoodsKindBtnDelete
            // 
            this.uaGoodsKindBtnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.uaGoodsKindBtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uaGoodsKindBtnDelete.Location = new System.Drawing.Point(358, 349);
            this.uaGoodsKindBtnDelete.Name = "uaGoodsKindBtnDelete";
            this.uaGoodsKindBtnDelete.Size = new System.Drawing.Size(80, 33);
            this.uaGoodsKindBtnDelete.TabIndex = 57;
            this.uaGoodsKindBtnDelete.Text = "Delete";
            this.uaGoodsKindBtnDelete.UseVisualStyleBackColor = true;
            // 
            // uaGoodsKindBtnUpdate
            // 
            this.uaGoodsKindBtnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.uaGoodsKindBtnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uaGoodsKindBtnUpdate.Location = new System.Drawing.Point(272, 349);
            this.uaGoodsKindBtnUpdate.Name = "uaGoodsKindBtnUpdate";
            this.uaGoodsKindBtnUpdate.Size = new System.Drawing.Size(80, 33);
            this.uaGoodsKindBtnUpdate.TabIndex = 56;
            this.uaGoodsKindBtnUpdate.Text = "Update";
            this.uaGoodsKindBtnUpdate.UseVisualStyleBackColor = true;
            // 
            // uaGoodsKindBtnInsert
            // 
            this.uaGoodsKindBtnInsert.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.uaGoodsKindBtnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uaGoodsKindBtnInsert.Location = new System.Drawing.Point(186, 349);
            this.uaGoodsKindBtnInsert.Name = "uaGoodsKindBtnInsert";
            this.uaGoodsKindBtnInsert.Size = new System.Drawing.Size(80, 33);
            this.uaGoodsKindBtnInsert.TabIndex = 55;
            this.uaGoodsKindBtnInsert.Text = "Insert";
            this.uaGoodsKindBtnInsert.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.uaGoodsKindDGList);
            this.groupBox1.Location = new System.Drawing.Point(26, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(558, 200);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List";
            // 
            // uaGoodsKind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uaGoodsKindBtnDelete);
            this.Controls.Add(this.uaGoodsKindBtnUpdate);
            this.Controls.Add(this.uaGoodsKindBtnInsert);
            this.Controls.Add(this.groupBox1);
            this.Name = "uaGoodsKind";
            this.Size = new System.Drawing.Size(611, 399);
            ((System.ComponentModel.ISupportInitialize)(this.uaGoodsKindDGList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView uaGoodsKindDGList;
        private System.Windows.Forms.Button uaGoodsKindBtnDelete;
        private System.Windows.Forms.Button uaGoodsKindBtnUpdate;
        private System.Windows.Forms.Button uaGoodsKindBtnInsert;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
