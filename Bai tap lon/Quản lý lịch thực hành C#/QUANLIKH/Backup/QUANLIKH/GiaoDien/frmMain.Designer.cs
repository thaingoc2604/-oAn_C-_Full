using System.Windows.Forms;
namespace QUANLIKH.GiaoDien
{
    partial class frmMain
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
            if (MessageBox.Show("Bạn có muốn thật sự thoát khỏi chương trình không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tTKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tTĐạiLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ấnChỉToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ấnChỉToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ấnChỉNhậpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ấnChỉXuấtToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mứcPhíBảoHiểmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hợpĐồngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quyểnSốToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nghiệpVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmĐạiLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmHợpĐồngĐạiLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmNVQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêBáoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêDoanhThuĐạiLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêTôToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngmKêHợpĐồngBHHếtHạnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêẤnChỉToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ấnChỉNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ấnChỉXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ấnChỉTồnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hiểnThịToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thanhCôngCụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thanhChứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.taskPane1 = new XPExplorerBar.TaskPane();
            this.expandoQuanLy = new XPExplorerBar.Expando();
            this.taskItem1 = new XPExplorerBar.TaskItem();
            this.taskItem2 = new XPExplorerBar.TaskItem();
            this.taskItem3 = new XPExplorerBar.TaskItem();
            this.taskItem9 = new XPExplorerBar.TaskItem();
            this.taskItem12 = new XPExplorerBar.TaskItem();
            this.expandoNghiepVu = new XPExplorerBar.Expando();
            this.taskItem10 = new XPExplorerBar.TaskItem();
            this.taskItem11 = new XPExplorerBar.TaskItem();
            this.taskItem13 = new XPExplorerBar.TaskItem();
            this.taskItem4 = new XPExplorerBar.TaskItem();
            this.expandoBaoCao = new XPExplorerBar.Expando();
            this.taskItem5 = new XPExplorerBar.TaskItem();
            this.taskItem6 = new XPExplorerBar.TaskItem();
            this.taskItem7 = new XPExplorerBar.TaskItem();
            this.taskItem8 = new XPExplorerBar.TaskItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskPane1)).BeginInit();
            this.taskPane1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expandoQuanLy)).BeginInit();
            this.expandoQuanLy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expandoNghiepVu)).BeginInit();
            this.expandoNghiepVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expandoBaoCao)).BeginInit();
            this.expandoBaoCao.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.quảnLýToolStripMenuItem,
            this.nghiệpVụToolStripMenuItem,
            this.thốngKêBáoCáoToolStripMenuItem,
            this.hiểnThịToolStripMenuItem,
            this.windowToolStripMenuItem,
            this.trợGiúpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(795, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngNhậpToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // đăngNhậpToolStripMenuItem
            // 
            this.đăngNhậpToolStripMenuItem.Image = global::QUANLIKH.Properties.Resources.Login;
            this.đăngNhậpToolStripMenuItem.Name = "đăngNhậpToolStripMenuItem";
            this.đăngNhậpToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.đăngNhậpToolStripMenuItem.Text = "Đăng Nhập";
            this.đăngNhậpToolStripMenuItem.Click += new System.EventHandler(this.đăngNhậpToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Image = global::QUANLIKH.Properties.Resources.Logout;
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Image = global::QUANLIKH.Properties.Resources.thoat;
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tTKháchHàngToolStripMenuItem,
            this.tTĐạiLýToolStripMenuItem,
            this.ấnChỉToolStripMenuItem,
            this.ấnChỉToolStripMenuItem1,
            this.hợpĐồngToolStripMenuItem,
            this.quyểnSốToolStripMenuItem});
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.quảnLýToolStripMenuItem.Text = "Quản Lý";
            this.quảnLýToolStripMenuItem.Click += new System.EventHandler(this.quảnLýToolStripMenuItem_Click);
            // 
            // tTKháchHàngToolStripMenuItem
            // 
            this.tTKháchHàngToolStripMenuItem.Image = global::QUANLIKH.Properties.Resources.khachhang32x32;
            this.tTKháchHàngToolStripMenuItem.Name = "tTKháchHàngToolStripMenuItem";
            this.tTKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.tTKháchHàngToolStripMenuItem.Text = "Thông Tin Khách Hàng";
            this.tTKháchHàngToolStripMenuItem.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tTĐạiLýToolStripMenuItem
            // 
            this.tTĐạiLýToolStripMenuItem.Image = global::QUANLIKH.Properties.Resources.nhacungcap32x32;
            this.tTĐạiLýToolStripMenuItem.Name = "tTĐạiLýToolStripMenuItem";
            this.tTĐạiLýToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.tTĐạiLýToolStripMenuItem.Text = "Thông Tin Đại Lý";
            this.tTĐạiLýToolStripMenuItem.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // ấnChỉToolStripMenuItem
            // 
            this.ấnChỉToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcVụToolStripMenuItem});
            this.ấnChỉToolStripMenuItem.Image = global::QUANLIKH.Properties.Resources.nhanvienquanly32x32;
            this.ấnChỉToolStripMenuItem.Name = "ấnChỉToolStripMenuItem";
            this.ấnChỉToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.ấnChỉToolStripMenuItem.Text = "Thông Tin Nhân Viên ";
            this.ấnChỉToolStripMenuItem.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // chứcVụToolStripMenuItem
            // 
            this.chứcVụToolStripMenuItem.Name = "chứcVụToolStripMenuItem";
            this.chứcVụToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.chứcVụToolStripMenuItem.Text = "Chức Vụ";
            this.chứcVụToolStripMenuItem.Click += new System.EventHandler(this.chứcVụToolStripMenuItem_Click);
            // 
            // ấnChỉToolStripMenuItem1
            // 
            this.ấnChỉToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ấnChỉNhậpToolStripMenuItem1,
            this.ấnChỉXuấtToolStripMenuItem1,
            this.mứcPhíBảoHiểmToolStripMenuItem});
            this.ấnChỉToolStripMenuItem1.Image = global::QUANLIKH.Properties.Resources.anchi;
            this.ấnChỉToolStripMenuItem1.Name = "ấnChỉToolStripMenuItem1";
            this.ấnChỉToolStripMenuItem1.Size = new System.Drawing.Size(192, 22);
            this.ấnChỉToolStripMenuItem1.Text = "Ấn Chỉ";
            this.ấnChỉToolStripMenuItem1.Click += new System.EventHandler(this.ấnChỉToolStripMenuItem1_Click);
            // 
            // ấnChỉNhậpToolStripMenuItem1
            // 
            this.ấnChỉNhậpToolStripMenuItem1.Image = global::QUANLIKH.Properties.Resources.xuatachi32;
            this.ấnChỉNhậpToolStripMenuItem1.Name = "ấnChỉNhậpToolStripMenuItem1";
            this.ấnChỉNhậpToolStripMenuItem1.Size = new System.Drawing.Size(169, 22);
            this.ấnChỉNhậpToolStripMenuItem1.Text = "Ấn Chỉ Xuất";
            this.ấnChỉNhậpToolStripMenuItem1.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // ấnChỉXuấtToolStripMenuItem1
            // 
            this.ấnChỉXuấtToolStripMenuItem1.Image = global::QUANLIKH.Properties.Resources.thuachi32;
            this.ấnChỉXuấtToolStripMenuItem1.Name = "ấnChỉXuấtToolStripMenuItem1";
            this.ấnChỉXuấtToolStripMenuItem1.Size = new System.Drawing.Size(169, 22);
            this.ấnChỉXuấtToolStripMenuItem1.Text = "Ấn Chỉ Sử Dụng";
            // 
            // mứcPhíBảoHiểmToolStripMenuItem
            // 
            this.mứcPhíBảoHiểmToolStripMenuItem.Image = global::QUANLIKH.Properties.Resources.mucbh;
            this.mứcPhíBảoHiểmToolStripMenuItem.Name = "mứcPhíBảoHiểmToolStripMenuItem";
            this.mứcPhíBảoHiểmToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.mứcPhíBảoHiểmToolStripMenuItem.Text = "Mức Phí Bảo Hiểm";
            this.mứcPhíBảoHiểmToolStripMenuItem.Click += new System.EventHandler(this.mứcPhíBảoHiểmToolStripMenuItem_Click);
            // 
            // hợpĐồngToolStripMenuItem
            // 
            this.hợpĐồngToolStripMenuItem.Image = global::QUANLIKH.Properties.Resources.hopdongdaily;
            this.hợpĐồngToolStripMenuItem.Name = "hợpĐồngToolStripMenuItem";
            this.hợpĐồngToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.hợpĐồngToolStripMenuItem.Text = "Hợp Đồng Đại Lý";
            this.hợpĐồngToolStripMenuItem.Click += new System.EventHandler(this.hợpĐồngToolStripMenuItem_Click);
            // 
            // quyểnSốToolStripMenuItem
            // 
            this.quyểnSốToolStripMenuItem.Image = global::QUANLIKH.Properties.Resources.quyenso32;
            this.quyểnSốToolStripMenuItem.Name = "quyểnSốToolStripMenuItem";
            this.quyểnSốToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.quyểnSốToolStripMenuItem.Text = "Quyển Số";
            this.quyểnSốToolStripMenuItem.Click += new System.EventHandler(this.quyểnSốToolStripMenuItem_Click);
            // 
            // nghiệpVụToolStripMenuItem
            // 
            this.nghiệpVụToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tìmKiếmKháchHàngToolStripMenuItem,
            this.tìmKiếmĐạiLýToolStripMenuItem,
            this.tìmKiếmHợpĐồngĐạiLýToolStripMenuItem,
            this.tìmKiếmNVQLToolStripMenuItem});
            this.nghiệpVụToolStripMenuItem.Name = "nghiệpVụToolStripMenuItem";
            this.nghiệpVụToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.nghiệpVụToolStripMenuItem.Text = "Nghiệp vụ";
            // 
            // tìmKiếmKháchHàngToolStripMenuItem
            // 
            this.tìmKiếmKháchHàngToolStripMenuItem.Image = global::QUANLIKH.Properties.Resources.timkiemkh32;
            this.tìmKiếmKháchHàngToolStripMenuItem.Name = "tìmKiếmKháchHàngToolStripMenuItem";
            this.tìmKiếmKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.tìmKiếmKháchHàngToolStripMenuItem.Text = "Tìm Kiếm Khách Hàng";
            this.tìmKiếmKháchHàngToolStripMenuItem.Click += new System.EventHandler(this.taskItem10_Click);
            // 
            // tìmKiếmĐạiLýToolStripMenuItem
            // 
            this.tìmKiếmĐạiLýToolStripMenuItem.Image = global::QUANLIKH.Properties.Resources.timkiemdaily;
            this.tìmKiếmĐạiLýToolStripMenuItem.Name = "tìmKiếmĐạiLýToolStripMenuItem";
            this.tìmKiếmĐạiLýToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.tìmKiếmĐạiLýToolStripMenuItem.Text = "Tìm Kiếm Đại Lý";
            this.tìmKiếmĐạiLýToolStripMenuItem.Click += new System.EventHandler(this.taskItem11_Click);
            // 
            // tìmKiếmHợpĐồngĐạiLýToolStripMenuItem
            // 
            this.tìmKiếmHợpĐồngĐạiLýToolStripMenuItem.Image = global::QUANLIKH.Properties.Resources.timkiemmoi;
            this.tìmKiếmHợpĐồngĐạiLýToolStripMenuItem.Name = "tìmKiếmHợpĐồngĐạiLýToolStripMenuItem";
            this.tìmKiếmHợpĐồngĐạiLýToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.tìmKiếmHợpĐồngĐạiLýToolStripMenuItem.Text = "Tìm Kiếm Hợp Đồng Đại Lý";
            this.tìmKiếmHợpĐồngĐạiLýToolStripMenuItem.Click += new System.EventHandler(this.taskItem13_Click);
            // 
            // tìmKiếmNVQLToolStripMenuItem
            // 
            this.tìmKiếmNVQLToolStripMenuItem.Image = global::QUANLIKH.Properties.Resources.timkiemmoi31;
            this.tìmKiếmNVQLToolStripMenuItem.Name = "tìmKiếmNVQLToolStripMenuItem";
            this.tìmKiếmNVQLToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.tìmKiếmNVQLToolStripMenuItem.Text = "Tìm Kiếm Nhân Viên Quản Lý";
            this.tìmKiếmNVQLToolStripMenuItem.Click += new System.EventHandler(this.taskItem4_Click);
            // 
            // thốngKêBáoCáoToolStripMenuItem
            // 
            this.thốngKêBáoCáoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thốngKêDoanhThuĐạiLýToolStripMenuItem,
            this.thốngKêTôToolStripMenuItem,
            this.thốngmKêHợpĐồngBHHếtHạnToolStripMenuItem,
            this.thốngKêẤnChỉToolStripMenuItem,
            this.thốngKêNhânViênToolStripMenuItem});
            this.thốngKêBáoCáoToolStripMenuItem.Name = "thốngKêBáoCáoToolStripMenuItem";
            this.thốngKêBáoCáoToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.thốngKêBáoCáoToolStripMenuItem.Text = "Thống Kê - Báo Cáo";
            // 
            // thốngKêDoanhThuĐạiLýToolStripMenuItem
            // 
            this.thốngKêDoanhThuĐạiLýToolStripMenuItem.Image = global::QUANLIKH.Properties.Resources.thongkedoanhthu32;
            this.thốngKêDoanhThuĐạiLýToolStripMenuItem.Name = "thốngKêDoanhThuĐạiLýToolStripMenuItem";
            this.thốngKêDoanhThuĐạiLýToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.thốngKêDoanhThuĐạiLýToolStripMenuItem.Text = "Thống kê Doanh Thu Đại Lý";
            // 
            // thốngKêTôToolStripMenuItem
            // 
            this.thốngKêTôToolStripMenuItem.Image = global::QUANLIKH.Properties.Resources.ttkhmuatheodvct32x32;
            this.thốngKêTôToolStripMenuItem.Name = "thốngKêTôToolStripMenuItem";
            this.thốngKêTôToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.thốngKêTôToolStripMenuItem.Text = "Thống Kê Khách Hàng Mua Bảo Hiểm";
            this.thốngKêTôToolStripMenuItem.Click += new System.EventHandler(this.taskItem6_Click);
            // 
            // thốngmKêHợpĐồngBHHếtHạnToolStripMenuItem
            // 
            this.thốngmKêHợpĐồngBHHếtHạnToolStripMenuItem.Image = global::QUANLIKH.Properties.Resources.hopdonghethan32x32;
            this.thốngmKêHợpĐồngBHHếtHạnToolStripMenuItem.Name = "thốngmKêHợpĐồngBHHếtHạnToolStripMenuItem";
            this.thốngmKêHợpĐồngBHHếtHạnToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.thốngmKêHợpĐồngBHHếtHạnToolStripMenuItem.Text = "TK Giấy Chứng Nhận Hết Hạn";
            // 
            // thốngKêẤnChỉToolStripMenuItem
            // 
            this.thốngKêẤnChỉToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ấnChỉNhậpToolStripMenuItem,
            this.ấnChỉXuấtToolStripMenuItem,
            this.ấnChỉTồnToolStripMenuItem});
            this.thốngKêẤnChỉToolStripMenuItem.Image = global::QUANLIKH.Properties.Resources.anchi32x32;
            this.thốngKêẤnChỉToolStripMenuItem.Name = "thốngKêẤnChỉToolStripMenuItem";
            this.thốngKêẤnChỉToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.thốngKêẤnChỉToolStripMenuItem.Text = "Thống Kê Ấn Chỉ";
            // 
            // ấnChỉNhậpToolStripMenuItem
            // 
            this.ấnChỉNhậpToolStripMenuItem.Name = "ấnChỉNhậpToolStripMenuItem";
            this.ấnChỉNhậpToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.ấnChỉNhậpToolStripMenuItem.Text = "Ấn Chỉ Xuất";
            // 
            // ấnChỉXuấtToolStripMenuItem
            // 
            this.ấnChỉXuấtToolStripMenuItem.Name = "ấnChỉXuấtToolStripMenuItem";
            this.ấnChỉXuấtToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.ấnChỉXuấtToolStripMenuItem.Text = "Ấn Chỉ Sử Dụng";
            // 
            // ấnChỉTồnToolStripMenuItem
            // 
            this.ấnChỉTồnToolStripMenuItem.Name = "ấnChỉTồnToolStripMenuItem";
            this.ấnChỉTồnToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.ấnChỉTồnToolStripMenuItem.Text = "Ấn Chỉ Tồn";
            // 
            // thốngKêNhânViênToolStripMenuItem
            // 
            this.thốngKêNhânViênToolStripMenuItem.Name = "thốngKêNhânViênToolStripMenuItem";
            this.thốngKêNhânViênToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.thốngKêNhânViênToolStripMenuItem.Text = "Thống Kê Nhân Viên";
            this.thốngKêNhânViênToolStripMenuItem.Click += new System.EventHandler(this.taskItem7_Click);
            // 
            // hiểnThịToolStripMenuItem
            // 
            this.hiểnThịToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thanhCôngCụToolStripMenuItem,
            this.thanhChứcNăngToolStripMenuItem});
            this.hiểnThịToolStripMenuItem.Name = "hiểnThịToolStripMenuItem";
            this.hiểnThịToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.hiểnThịToolStripMenuItem.Text = "Hiển Thị ";
            // 
            // thanhCôngCụToolStripMenuItem
            // 
            this.thanhCôngCụToolStripMenuItem.Name = "thanhCôngCụToolStripMenuItem";
            this.thanhCôngCụToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.thanhCôngCụToolStripMenuItem.Text = "Thanh Công Cụ";
            this.thanhCôngCụToolStripMenuItem.Click += new System.EventHandler(this.thanhCôngCụToolStripMenuItem_Click);
            // 
            // thanhChứcNăngToolStripMenuItem
            // 
            this.thanhChứcNăngToolStripMenuItem.Name = "thanhChứcNăngToolStripMenuItem";
            this.thanhChứcNăngToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.thanhChứcNăngToolStripMenuItem.Text = "Thanh Chức Năng";
            this.thanhChứcNăngToolStripMenuItem.Click += new System.EventHandler(this.thanhChứcNăngToolStripMenuItem_Click);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.herizontalToolStripMenuItem,
            this.verticalToolStripMenuItem});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // herizontalToolStripMenuItem
            // 
            this.herizontalToolStripMenuItem.Name = "herizontalToolStripMenuItem";
            this.herizontalToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.herizontalToolStripMenuItem.Text = "Horizontal";
            this.herizontalToolStripMenuItem.Click += new System.EventHandler(this.herizontalToolStripMenuItem_Click);
            // 
            // verticalToolStripMenuItem
            // 
            this.verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            this.verticalToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.verticalToolStripMenuItem.Text = "Vertical";
            this.verticalToolStripMenuItem.Click += new System.EventHandler(this.verticalToolStripMenuItem_Click);
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.trợGiúpToolStripMenuItem.Text = "Trợ Giúp";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton4,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripButton7});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(795, 52);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "Tìm Khách Hàng";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.ForeColor = System.Drawing.Color.Blue;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Thistle;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(71, 49);
            this.toolStripButton1.Text = " Khách Hàng";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.ForeColor = System.Drawing.Color.Blue;
            this.toolStripButton4.Image = global::QUANLIKH.Properties.Resources.nhanvienquanly32x32;
            this.toolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(71, 49);
            this.toolStripButton4.Text = "Nhân Viên QL";
            this.toolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.ForeColor = System.Drawing.Color.Blue;
            this.toolStripButton2.Image = global::QUANLIKH.Properties.Resources.nhacungcap32x32;
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(56, 49);
            this.toolStripButton2.Text = "TT Đại Lý";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.ForeColor = System.Drawing.Color.Blue;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(92, 49);
            this.toolStripButton3.Text = "Hợp Đồng Đại Lý";
            this.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton3.Click += new System.EventHandler(this.hợpĐồngToolStripMenuItem_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.ForeColor = System.Drawing.Color.Blue;
            this.toolStripButton5.Image = global::QUANLIKH.Properties.Resources.xuatachi32;
            this.toolStripButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(67, 49);
            this.toolStripButton5.Text = "Xuất Ấn Chỉ";
            this.toolStripButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.ForeColor = System.Drawing.Color.Blue;
            this.toolStripButton6.Image = global::QUANLIKH.Properties.Resources.thuachi32;
            this.toolStripButton6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(63, 49);
            this.toolStripButton6.Text = "Thu Ấn Chỉ";
            this.toolStripButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.ForeColor = System.Drawing.Color.Blue;
            this.toolStripButton7.Image = global::QUANLIKH.Properties.Resources.timkiemkh32;
            this.toolStripButton7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(87, 49);
            this.toolStripButton7.Text = "Tìm Khách Hàng";
            this.toolStripButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton7.Click += new System.EventHandler(this.taskItem10_Click);
            // 
            // taskPane1
            // 
            this.taskPane1.AutoScrollMargin = new System.Drawing.Size(12, 12);
            this.taskPane1.Dock = System.Windows.Forms.DockStyle.Left;
            this.taskPane1.Expandos.AddRange(new XPExplorerBar.Expando[] {
            this.expandoQuanLy,
            this.expandoNghiepVu,
            this.expandoBaoCao});
            this.taskPane1.Location = new System.Drawing.Point(0, 76);
            this.taskPane1.Name = "taskPane1";
            this.taskPane1.Size = new System.Drawing.Size(230, 564);
            this.taskPane1.TabIndex = 5;
            this.taskPane1.Text = "taskPane1";
            // 
            // expandoQuanLy
            // 
            this.expandoQuanLy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.expandoQuanLy.ExpandedHeight = 185;
            this.expandoQuanLy.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expandoQuanLy.Items.AddRange(new System.Windows.Forms.Control[] {
            this.taskItem1,
            this.taskItem2,
            this.taskItem3,
            this.taskItem9,
            this.taskItem12});
            this.expandoQuanLy.Location = new System.Drawing.Point(12, 12);
            this.expandoQuanLy.Name = "expandoQuanLy";
            this.expandoQuanLy.Size = new System.Drawing.Size(206, 185);
            this.expandoQuanLy.TabIndex = 2;
            this.expandoQuanLy.Text = "Quản Lý";
            // 
            // taskItem1
            // 
            this.taskItem1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.taskItem1.BackColor = System.Drawing.Color.Transparent;
            this.taskItem1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskItem1.Image = ((System.Drawing.Image)(resources.GetObject("taskItem1.Image")));
            this.taskItem1.Location = new System.Drawing.Point(12, 41);
            this.taskItem1.Name = "taskItem1";
            this.taskItem1.Size = new System.Drawing.Size(182, 16);
            this.taskItem1.TabIndex = 3;
            this.taskItem1.Text = "Thông Tin Khách Hàng";
            this.taskItem1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.taskItem1.UseVisualStyleBackColor = false;
            this.taskItem1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // taskItem2
            // 
            this.taskItem2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.taskItem2.BackColor = System.Drawing.Color.Transparent;
            this.taskItem2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskItem2.Image = ((System.Drawing.Image)(resources.GetObject("taskItem2.Image")));
            this.taskItem2.Location = new System.Drawing.Point(12, 69);
            this.taskItem2.Name = "taskItem2";
            this.taskItem2.Size = new System.Drawing.Size(182, 16);
            this.taskItem2.TabIndex = 3;
            this.taskItem2.Text = "Thông Tin Đại Lý";
            this.taskItem2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.taskItem2.UseVisualStyleBackColor = false;
            this.taskItem2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // taskItem3
            // 
            this.taskItem3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.taskItem3.BackColor = System.Drawing.Color.Transparent;
            this.taskItem3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskItem3.Image = ((System.Drawing.Image)(resources.GetObject("taskItem3.Image")));
            this.taskItem3.Location = new System.Drawing.Point(12, 98);
            this.taskItem3.Name = "taskItem3";
            this.taskItem3.Size = new System.Drawing.Size(182, 16);
            this.taskItem3.TabIndex = 4;
            this.taskItem3.Text = "Nhân Viên Quản Lý";
            this.taskItem3.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.taskItem3.UseVisualStyleBackColor = false;
            this.taskItem3.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // taskItem9
            // 
            this.taskItem9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.taskItem9.BackColor = System.Drawing.Color.Transparent;
            this.taskItem9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskItem9.Image = ((System.Drawing.Image)(resources.GetObject("taskItem9.Image")));
            this.taskItem9.Location = new System.Drawing.Point(12, 127);
            this.taskItem9.Name = "taskItem9";
            this.taskItem9.Size = new System.Drawing.Size(182, 16);
            this.taskItem9.TabIndex = 6;
            this.taskItem9.Text = "Hợp Đồng Đại Lý";
            this.taskItem9.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.taskItem9.UseVisualStyleBackColor = false;
            this.taskItem9.Click += new System.EventHandler(this.hợpĐồngToolStripMenuItem_Click);
            // 
            // taskItem12
            // 
            this.taskItem12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.taskItem12.BackColor = System.Drawing.Color.Transparent;
            this.taskItem12.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskItem12.Image = ((System.Drawing.Image)(resources.GetObject("taskItem12.Image")));
            this.taskItem12.Location = new System.Drawing.Point(12, 153);
            this.taskItem12.Name = "taskItem12";
            this.taskItem12.Size = new System.Drawing.Size(182, 16);
            this.taskItem12.TabIndex = 7;
            this.taskItem12.Text = "Quyển Số";
            this.taskItem12.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.taskItem12.UseVisualStyleBackColor = false;
            this.taskItem12.Click += new System.EventHandler(this.quyểnSốToolStripMenuItem_Click);
            // 
            // expandoNghiepVu
            // 
            this.expandoNghiepVu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.expandoNghiepVu.ExpandedHeight = 185;
            this.expandoNghiepVu.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.expandoNghiepVu.Items.AddRange(new System.Windows.Forms.Control[] {
            this.taskItem10,
            this.taskItem11,
            this.taskItem13,
            this.taskItem4});
            this.expandoNghiepVu.Location = new System.Drawing.Point(12, 209);
            this.expandoNghiepVu.Name = "expandoNghiepVu";
            this.expandoNghiepVu.Size = new System.Drawing.Size(206, 185);
            this.expandoNghiepVu.TabIndex = 3;
            this.expandoNghiepVu.Text = "Nghiệp Vụ";
            // 
            // taskItem10
            // 
            this.taskItem10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.taskItem10.BackColor = System.Drawing.Color.Transparent;
            this.taskItem10.Image = ((System.Drawing.Image)(resources.GetObject("taskItem10.Image")));
            this.taskItem10.Location = new System.Drawing.Point(12, 40);
            this.taskItem10.Name = "taskItem10";
            this.taskItem10.Size = new System.Drawing.Size(182, 16);
            this.taskItem10.TabIndex = 7;
            this.taskItem10.Text = "Tìm Kiếm Khách Hàng";
            this.taskItem10.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.taskItem10.UseVisualStyleBackColor = false;
            this.taskItem10.Click += new System.EventHandler(this.taskItem10_Click);
            // 
            // taskItem11
            // 
            this.taskItem11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.taskItem11.BackColor = System.Drawing.Color.Transparent;
            this.taskItem11.Image = ((System.Drawing.Image)(resources.GetObject("taskItem11.Image")));
            this.taskItem11.Location = new System.Drawing.Point(12, 68);
            this.taskItem11.Name = "taskItem11";
            this.taskItem11.Size = new System.Drawing.Size(182, 16);
            this.taskItem11.TabIndex = 8;
            this.taskItem11.Text = "Tìm Kiếm Đại Lý";
            this.taskItem11.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.taskItem11.UseVisualStyleBackColor = false;
            this.taskItem11.Click += new System.EventHandler(this.taskItem11_Click);
            // 
            // taskItem13
            // 
            this.taskItem13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.taskItem13.BackColor = System.Drawing.Color.Transparent;
            this.taskItem13.Image = ((System.Drawing.Image)(resources.GetObject("taskItem13.Image")));
            this.taskItem13.Location = new System.Drawing.Point(12, 99);
            this.taskItem13.Name = "taskItem13";
            this.taskItem13.Size = new System.Drawing.Size(182, 16);
            this.taskItem13.TabIndex = 10;
            this.taskItem13.Text = "Tìm Kiếm Hợp Đồng Đại Lý";
            this.taskItem13.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.taskItem13.UseVisualStyleBackColor = false;
            this.taskItem13.Click += new System.EventHandler(this.taskItem13_Click);
            // 
            // taskItem4
            // 
            this.taskItem4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.taskItem4.BackColor = System.Drawing.Color.Transparent;
            this.taskItem4.Image = ((System.Drawing.Image)(resources.GetObject("taskItem4.Image")));
            this.taskItem4.Location = new System.Drawing.Point(12, 131);
            this.taskItem4.Name = "taskItem4";
            this.taskItem4.Size = new System.Drawing.Size(182, 16);
            this.taskItem4.TabIndex = 11;
            this.taskItem4.Text = "Tìm Kiếm Nhân Viên Quản Lý";
            this.taskItem4.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.taskItem4.UseVisualStyleBackColor = false;
            this.taskItem4.Click += new System.EventHandler(this.taskItem4_Click);
            // 
            // expandoBaoCao
            // 
            this.expandoBaoCao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.expandoBaoCao.ExpandedHeight = 160;
            this.expandoBaoCao.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.expandoBaoCao.Items.AddRange(new System.Windows.Forms.Control[] {
            this.taskItem5,
            this.taskItem6,
            this.taskItem7,
            this.taskItem8});
            this.expandoBaoCao.Location = new System.Drawing.Point(12, 406);
            this.expandoBaoCao.Name = "expandoBaoCao";
            this.expandoBaoCao.Size = new System.Drawing.Size(206, 160);
            this.expandoBaoCao.TabIndex = 4;
            this.expandoBaoCao.Text = "Thống Kê - Báo Cáo";
            // 
            // taskItem5
            // 
            this.taskItem5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.taskItem5.BackColor = System.Drawing.Color.Transparent;
            this.taskItem5.Image = ((System.Drawing.Image)(resources.GetObject("taskItem5.Image")));
            this.taskItem5.Location = new System.Drawing.Point(12, 36);
            this.taskItem5.Name = "taskItem5";
            this.taskItem5.Size = new System.Drawing.Size(182, 16);
            this.taskItem5.TabIndex = 6;
            this.taskItem5.Text = "Thống Kê Doanh Thu Đại Lý";
            this.taskItem5.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.taskItem5.UseVisualStyleBackColor = false;
            // 
            // taskItem6
            // 
            this.taskItem6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.taskItem6.BackColor = System.Drawing.Color.Transparent;
            this.taskItem6.Image = ((System.Drawing.Image)(resources.GetObject("taskItem6.Image")));
            this.taskItem6.Location = new System.Drawing.Point(12, 68);
            this.taskItem6.Name = "taskItem6";
            this.taskItem6.Size = new System.Drawing.Size(203, 17);
            this.taskItem6.TabIndex = 7;
            this.taskItem6.Text = "Thống Kê KH Mua Bảo Hiểm";
            this.taskItem6.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.taskItem6.UseVisualStyleBackColor = false;
            this.taskItem6.Click += new System.EventHandler(this.taskItem6_Click);
            // 
            // taskItem7
            // 
            this.taskItem7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.taskItem7.BackColor = System.Drawing.Color.Transparent;
            this.taskItem7.Image = ((System.Drawing.Image)(resources.GetObject("taskItem7.Image")));
            this.taskItem7.Location = new System.Drawing.Point(12, 96);
            this.taskItem7.Name = "taskItem7";
            this.taskItem7.Size = new System.Drawing.Size(203, 17);
            this.taskItem7.TabIndex = 8;
            this.taskItem7.Text = "Thống Kê Nhân Viên";
            this.taskItem7.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.taskItem7.UseVisualStyleBackColor = false;
            this.taskItem7.Click += new System.EventHandler(this.taskItem7_Click);
            // 
            // taskItem8
            // 
            this.taskItem8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.taskItem8.BackColor = System.Drawing.Color.Transparent;
            this.taskItem8.Image = ((System.Drawing.Image)(resources.GetObject("taskItem8.Image")));
            this.taskItem8.Location = new System.Drawing.Point(12, 127);
            this.taskItem8.Name = "taskItem8";
            this.taskItem8.Size = new System.Drawing.Size(203, 19);
            this.taskItem8.TabIndex = 9;
            this.taskItem8.Text = "TK  Giấy Chứng Nhận Hết Hạn";
            this.taskItem8.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.taskItem8.UseVisualStyleBackColor = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QUANLIKH.Properties.Resources.logoVDong;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(795, 640);
            this.Controls.Add(this.taskPane1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "QUẢN LÝ KHÁCH HÀNG MUA BẢO HIỂM";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskPane1)).EndInit();
            this.taskPane1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.expandoQuanLy)).EndInit();
            this.expandoQuanLy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.expandoNghiepVu)).EndInit();
            this.expandoNghiepVu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.expandoBaoCao)).EndInit();
            this.expandoBaoCao.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nghiệpVụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêBáoCáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hiểnThịToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private XPExplorerBar.Expando expandoQuanLy;
        private XPExplorerBar.TaskItem taskItem1;
        private XPExplorerBar.TaskItem taskItem2;
        private XPExplorerBar.TaskItem taskItem3;
        private XPExplorerBar.Expando expandoNghiepVu;
        private XPExplorerBar.Expando expandoBaoCao;
        private XPExplorerBar.TaskPane taskPane1;
        private System.Windows.Forms.ToolStripMenuItem tTKháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tTĐạiLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ấnChỉToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmKháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmĐạiLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmHợpĐồngĐạiLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêDoanhThuĐạiLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêTôToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngmKêHợpĐồngBHHếtHạnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêẤnChỉToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ấnChỉNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ấnChỉXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ấnChỉTồnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ấnChỉToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ấnChỉNhậpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ấnChỉXuấtToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem hợpĐồngToolStripMenuItem;
        private XPExplorerBar.TaskItem taskItem5;
        private XPExplorerBar.TaskItem taskItem6;
        private XPExplorerBar.TaskItem taskItem7;
        private XPExplorerBar.TaskItem taskItem8;
        private XPExplorerBar.TaskItem taskItem9;
        private XPExplorerBar.TaskItem taskItem10;
        private XPExplorerBar.TaskItem taskItem11;
        private XPExplorerBar.TaskItem taskItem13;
        private System.Windows.Forms.ToolStripMenuItem thanhCôngCụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thanhChứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private XPExplorerBar.TaskItem taskItem4;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmNVQLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chứcVụToolStripMenuItem;
        private ToolStripMenuItem mứcPhíBảoHiểmToolStripMenuItem;
        private ToolStripMenuItem quyểnSốToolStripMenuItem;
        private ToolStripMenuItem thốngKêNhânViênToolStripMenuItem;
        private XPExplorerBar.TaskItem taskItem12;
    }
}