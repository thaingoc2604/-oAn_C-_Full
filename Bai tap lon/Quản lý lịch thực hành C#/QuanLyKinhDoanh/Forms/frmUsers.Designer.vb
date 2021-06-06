<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsers
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsers))
        Me.btnThoat = New System.Windows.Forms.Button
        Me.btnHuyBo = New System.Windows.Forms.Button
        Me.btnLuu = New System.Windows.Forms.Button
        Me.btnXoa = New System.Windows.Forms.Button
        Me.btnSua = New System.Windows.Forms.Button
        Me.btnThem = New System.Windows.Forms.Button
        Me.grbCongViec = New System.Windows.Forms.GroupBox
        Me.chkPhanQuyen = New System.Windows.Forms.CheckBox
        Me.chkBanHang = New System.Windows.Forms.CheckBox
        Me.chkMuaHang = New System.Windows.Forms.CheckBox
        Me.chkKho = New System.Windows.Forms.CheckBox
        Me.chkNhanSu = New System.Windows.Forms.CheckBox
        Me.DataGridView = New System.Windows.Forms.DataGridView
        Me.colMaNV = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colNhanSu = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.colKho = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.colMuaHang = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.colBanHang = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.colPhanQuyen = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.colMatKhau = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtMaNV = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtMatKhau = New System.Windows.Forms.TextBox
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.grbCongViec.SuspendLayout()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnThoat
        '
        Me.btnThoat.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoat.Image = CType(resources.GetObject("btnThoat.Image"), System.Drawing.Image)
        Me.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThoat.Location = New System.Drawing.Point(470, 407)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(83, 32)
        Me.btnThoat.TabIndex = 9
        Me.btnThoat.Text = "Th&oát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'btnHuyBo
        '
        Me.btnHuyBo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHuyBo.Image = CType(resources.GetObject("btnHuyBo.Image"), System.Drawing.Image)
        Me.btnHuyBo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHuyBo.Location = New System.Drawing.Point(380, 407)
        Me.btnHuyBo.Name = "btnHuyBo"
        Me.btnHuyBo.Size = New System.Drawing.Size(83, 32)
        Me.btnHuyBo.TabIndex = 8
        Me.btnHuyBo.Text = "    Hủy &bỏ"
        Me.btnHuyBo.UseVisualStyleBackColor = True
        '
        'btnLuu
        '
        Me.btnLuu.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLuu.Image = CType(resources.GetObject("btnLuu.Image"), System.Drawing.Image)
        Me.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLuu.Location = New System.Drawing.Point(289, 407)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Size = New System.Drawing.Size(83, 32)
        Me.btnLuu.TabIndex = 7
        Me.btnLuu.Text = "&Ghi"
        Me.btnLuu.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoa.Image = CType(resources.GetObject("btnXoa.Image"), System.Drawing.Image)
        Me.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnXoa.Location = New System.Drawing.Point(198, 407)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(83, 32)
        Me.btnXoa.TabIndex = 6
        Me.btnXoa.Text = "&Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSua.Image = CType(resources.GetObject("btnSua.Image"), System.Drawing.Image)
        Me.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSua.Location = New System.Drawing.Point(107, 407)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(83, 32)
        Me.btnSua.TabIndex = 5
        Me.btnSua.Text = "&Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThem.Image = CType(resources.GetObject("btnThem.Image"), System.Drawing.Image)
        Me.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThem.Location = New System.Drawing.Point(16, 407)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(83, 32)
        Me.btnThem.TabIndex = 4
        Me.btnThem.Text = "&Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'grbCongViec
        '
        Me.grbCongViec.Controls.Add(Me.chkPhanQuyen)
        Me.grbCongViec.Controls.Add(Me.chkBanHang)
        Me.grbCongViec.Controls.Add(Me.chkMuaHang)
        Me.grbCongViec.Controls.Add(Me.chkKho)
        Me.grbCongViec.Controls.Add(Me.chkNhanSu)
        Me.grbCongViec.Location = New System.Drawing.Point(16, 56)
        Me.grbCongViec.Name = "grbCongViec"
        Me.grbCongViec.Size = New System.Drawing.Size(536, 73)
        Me.grbCongViec.TabIndex = 2
        Me.grbCongViec.TabStop = False
        Me.grbCongViec.Text = "Công việc"
        '
        'chkPhanQuyen
        '
        Me.chkPhanQuyen.AutoSize = True
        Me.chkPhanQuyen.Location = New System.Drawing.Point(393, 28)
        Me.chkPhanQuyen.Name = "chkPhanQuyen"
        Me.chkPhanQuyen.Size = New System.Drawing.Size(96, 20)
        Me.chkPhanQuyen.TabIndex = 4
        Me.chkPhanQuyen.Text = "Phân quyền"
        Me.chkPhanQuyen.UseVisualStyleBackColor = True
        '
        'chkBanHang
        '
        Me.chkBanHang.AutoSize = True
        Me.chkBanHang.Location = New System.Drawing.Point(292, 28)
        Me.chkBanHang.Name = "chkBanHang"
        Me.chkBanHang.Size = New System.Drawing.Size(82, 20)
        Me.chkBanHang.TabIndex = 3
        Me.chkBanHang.Text = "Bán hàng"
        Me.chkBanHang.UseVisualStyleBackColor = True
        '
        'chkMuaHang
        '
        Me.chkMuaHang.AutoSize = True
        Me.chkMuaHang.Location = New System.Drawing.Point(182, 28)
        Me.chkMuaHang.Name = "chkMuaHang"
        Me.chkMuaHang.Size = New System.Drawing.Size(84, 20)
        Me.chkMuaHang.TabIndex = 2
        Me.chkMuaHang.Text = "Mua hàng"
        Me.chkMuaHang.UseVisualStyleBackColor = True
        '
        'chkKho
        '
        Me.chkKho.AutoSize = True
        Me.chkKho.Location = New System.Drawing.Point(97, 28)
        Me.chkKho.Name = "chkKho"
        Me.chkKho.Size = New System.Drawing.Size(50, 20)
        Me.chkKho.TabIndex = 1
        Me.chkKho.Text = "Kho"
        Me.chkKho.UseVisualStyleBackColor = True
        '
        'chkNhanSu
        '
        Me.chkNhanSu.AutoSize = True
        Me.chkNhanSu.Location = New System.Drawing.Point(13, 28)
        Me.chkNhanSu.Name = "chkNhanSu"
        Me.chkNhanSu.Size = New System.Drawing.Size(77, 20)
        Me.chkNhanSu.TabIndex = 0
        Me.chkNhanSu.Text = "Nhân sự"
        Me.chkNhanSu.UseVisualStyleBackColor = True
        '
        'DataGridView
        '
        Me.DataGridView.AllowUserToAddRows = False
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colMaNV, Me.colNhanSu, Me.colKho, Me.colMuaHang, Me.colBanHang, Me.colPhanQuyen, Me.colMatKhau})
        Me.DataGridView.Location = New System.Drawing.Point(16, 143)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.Size = New System.Drawing.Size(536, 241)
        Me.DataGridView.TabIndex = 3
        '
        'colMaNV
        '
        Me.colMaNV.HeaderText = "Mã NV"
        Me.colMaNV.Name = "colMaNV"
        '
        'colNhanSu
        '
        Me.colNhanSu.HeaderText = "Nhân sự"
        Me.colNhanSu.Name = "colNhanSu"
        Me.colNhanSu.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colNhanSu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'colKho
        '
        Me.colKho.HeaderText = "Kho"
        Me.colKho.Name = "colKho"
        Me.colKho.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colKho.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'colMuaHang
        '
        Me.colMuaHang.HeaderText = "Mua hàng"
        Me.colMuaHang.Name = "colMuaHang"
        Me.colMuaHang.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colMuaHang.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'colBanHang
        '
        Me.colBanHang.HeaderText = "Bán hàng"
        Me.colBanHang.Name = "colBanHang"
        '
        'colPhanQuyen
        '
        Me.colPhanQuyen.HeaderText = "Phân quyền"
        Me.colPhanQuyen.Name = "colPhanQuyen"
        '
        'colMatKhau
        '
        Me.colMatKhau.HeaderText = "Mật khẩu"
        Me.colMatKhau.Name = "colMatKhau"
        Me.colMatKhau.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 16)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Mã NV (*)"
        '
        'txtMaNV
        '
        Me.txtMaNV.Location = New System.Drawing.Point(103, 13)
        Me.txtMaNV.Name = "txtMaNV"
        Me.txtMaNV.Size = New System.Drawing.Size(102, 22)
        Me.txtMaNV.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(240, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 16)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Mật khẩu (*)"
        '
        'txtMatKhau
        '
        Me.txtMatKhau.Location = New System.Drawing.Point(325, 12)
        Me.txtMatKhau.Name = "txtMatKhau"
        Me.txtMatKhau.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtMatKhau.Size = New System.Drawing.Size(208, 22)
        Me.txtMatKhau.TabIndex = 1
        '
        'ErrorProvider
        '
        Me.ErrorProvider.BlinkRate = 0
        Me.ErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider.ContainerControl = Me
        '
        'frmUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 453)
        Me.Controls.Add(Me.txtMatKhau)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtMaNV)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView)
        Me.Controls.Add(Me.grbCongViec)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnHuyBo)
        Me.Controls.Add(Me.btnLuu)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThem)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUsers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Người sử dụng"
        Me.grbCongViec.ResumeLayout(False)
        Me.grbCongViec.PerformLayout()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnThoat As System.Windows.Forms.Button
    Friend WithEvents btnHuyBo As System.Windows.Forms.Button
    Friend WithEvents btnLuu As System.Windows.Forms.Button
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents btnSua As System.Windows.Forms.Button
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents grbCongViec As System.Windows.Forms.GroupBox
    Friend WithEvents chkBanHang As System.Windows.Forms.CheckBox
    Friend WithEvents chkMuaHang As System.Windows.Forms.CheckBox
    Friend WithEvents chkNhanSu As System.Windows.Forms.CheckBox
    Friend WithEvents chkPhanQuyen As System.Windows.Forms.CheckBox
    Friend WithEvents DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMaNV As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMatKhau As System.Windows.Forms.TextBox
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents chkKho As System.Windows.Forms.CheckBox
    Friend WithEvents colMaNV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNhanSu As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents colKho As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents colMuaHang As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents colBanHang As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents colPhanQuyen As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents colMatKhau As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
