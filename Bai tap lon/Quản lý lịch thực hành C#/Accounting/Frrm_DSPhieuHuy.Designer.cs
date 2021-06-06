namespace Accounting
{
    partial class Frrm_DSPhieuHuy
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
            Janus.Windows.GridEX.GridEXLayout TKThuChiGrid_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frrm_DSPhieuHuy));
            this.TKThuChiGrid = new Janus.Windows.GridEX.GridEX();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.TKThuChiGrid)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TKThuChiGrid
            // 
            this.TKThuChiGrid.AllowColumnDrag = false;
            this.TKThuChiGrid.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.TKThuChiGrid.AutomaticSort = false;
            TKThuChiGrid_DesignTimeLayout.LayoutString = resources.GetString("TKThuChiGrid_DesignTimeLayout.LayoutString");
            this.TKThuChiGrid.DesignTimeLayout = TKThuChiGrid_DesignTimeLayout;
            this.TKThuChiGrid.Font = new System.Drawing.Font(".VnTime", 9F);
            this.TKThuChiGrid.GroupByBoxVisible = false;
            this.TKThuChiGrid.Location = new System.Drawing.Point(0, 2);
            this.TKThuChiGrid.Name = "TKThuChiGrid";
            this.TKThuChiGrid.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver;
            this.TKThuChiGrid.Size = new System.Drawing.Size(925, 390);
            this.TKThuChiGrid.TabIndex = 7;
            this.TKThuChiGrid.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TKThuChiGrid_KeyUp);
            this.TKThuChiGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TKThuChiGrid_KeyDown);
            this.TKThuChiGrid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TKThuChiGrid_KeyPress);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 395);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(925, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(92, 17);
            this.toolStripStatusLabel1.Text = "Ctrl+G: Khôi phục";
            // 
            // Frrm_DSPhieuHuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 417);
            this.Controls.Add(this.TKThuChiGrid);
            this.Controls.Add(this.statusStrip1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(933, 509);
            this.Name = "Frrm_DSPhieuHuy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách phiếu đã hủy";
            this.Load += new System.EventHandler(this.Frrm_DSPhieuHuy_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frrm_DSPhieuHuy_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.TKThuChiGrid)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Janus.Windows.GridEX.GridEX TKThuChiGrid;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}