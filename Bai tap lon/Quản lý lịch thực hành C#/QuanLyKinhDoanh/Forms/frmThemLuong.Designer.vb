<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThemLuong
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmThemLuong))
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtHoTen = New System.Windows.Forms.TextBox
        Me.txtMaNV = New System.Windows.Forms.TextBox
        Me.txtLuongCoBan = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.mskNgayXepLuong = New System.Windows.Forms.MaskedTextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtPhuCap = New System.Windows.Forms.TextBox
        Me.txtLyDoPhuCap = New System.Windows.Forms.TextBox
        Me.DataGridView = New System.Windows.Forms.DataGridView
        Me.btnThoat = New System.Windows.Forms.Button
        Me.btnHuyBo = New System.Windows.Forms.Button
        Me.btnLuu = New System.Windows.Forms.Button
        Me.btnXoa = New System.Windows.Forms.Button
        Me.btnSua = New System.Windows.Forms.Button
        Me.btnThem = New System.Windows.Forms.Button
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtHeSo = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(289, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 16)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Họ tên "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 16)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Mã NV (*)"
        '
        'txtHoTen
        '
        Me.txtHoTen.Enabled = False
        Me.txtHoTen.Location = New System.Drawing.Point(406, 19)
        Me.txtHoTen.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtHoTen.MaxLength = 30
        Me.txtHoTen.Name = "txtHoTen"
        Me.txtHoTen.Size = New System.Drawing.Size(175, 22)
        Me.txtHoTen.TabIndex = 1
        Me.txtHoTen.Tag = "NN"
        '
        'txtMaNV
        '
        Me.txtMaNV.Enabled = False
        Me.txtMaNV.Location = New System.Drawing.Point(130, 22)
        Me.txtMaNV.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtMaNV.MaxLength = 10
        Me.txtMaNV.Name = "txtMaNV"
        Me.txtMaNV.Size = New System.Drawing.Size(139, 22)
        Me.txtMaNV.TabIndex = 0
        Me.txtMaNV.Tag = "NN"
        '
        'txtLuongCoBan
        '
        Me.txtLuongCoBan.Location = New System.Drawing.Point(406, 49)
        Me.txtLuongCoBan.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtLuongCoBan.MaxLength = 30
        Me.txtLuongCoBan.Name = "txtLuongCoBan"
        Me.txtLuongCoBan.Size = New System.Drawing.Size(175, 22)
        Me.txtLuongCoBan.TabIndex = 3
        Me.txtLuongCoBan.Tag = "NN"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(289, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 16)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Lương cơ bản (*)"
        '
        'mskNgayXepLuong
        '
        Me.mskNgayXepLuong.Location = New System.Drawing.Point(130, 49)
        Me.mskNgayXepLuong.Mask = "00/00/0000"
        Me.mskNgayXepLuong.Name = "mskNgayXepLuong"
        Me.mskNgayXepLuong.Size = New System.Drawing.Size(139, 22)
        Me.mskNgayXepLuong.TabIndex = 2
        Me.mskNgayXepLuong.Tag = "NN"
        Me.mskNgayXepLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.mskNgayXepLuong.ValidatingType = GetType(Date)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(13, 52)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(119, 16)
        Me.Label11.TabIndex = 78
        Me.Label11.Text = "Ngày xếp lương (*)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(289, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 16)
        Me.Label6.TabIndex = 83
        Me.Label6.Text = "Phụ cấp"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 112)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 16)
        Me.Label7.TabIndex = 86
        Me.Label7.Text = "Lý do phụ cấp "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 82)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 16)
        Me.Label8.TabIndex = 85
        Me.Label8.Text = "Hệ số (*)"
        '
        'txtPhuCap
        '
        Me.txtPhuCap.Location = New System.Drawing.Point(406, 79)
        Me.txtPhuCap.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPhuCap.MaxLength = 30
        Me.txtPhuCap.Name = "txtPhuCap"
        Me.txtPhuCap.Size = New System.Drawing.Size(175, 22)
        Me.txtPhuCap.TabIndex = 5
        Me.txtPhuCap.Tag = ""
        '
        'txtLyDoPhuCap
        '
        Me.txtLyDoPhuCap.Location = New System.Drawing.Point(130, 112)
        Me.txtLyDoPhuCap.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtLyDoPhuCap.MaxLength = 50
        Me.txtLyDoPhuCap.Name = "txtLyDoPhuCap"
        Me.txtLyDoPhuCap.Size = New System.Drawing.Size(451, 22)
        Me.txtLyDoPhuCap.TabIndex = 6
        Me.txtLyDoPhuCap.Tag = ""
        '
        'DataGridView
        '
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Location = New System.Drawing.Point(10, 205)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.Size = New System.Drawing.Size(607, 149)
        Me.DataGridView.TabIndex = 1
        '
        'btnThoat
        '
        Me.btnThoat.Image = CType(resources.GetObject("btnThoat.Image"), System.Drawing.Image)
        Me.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThoat.Location = New System.Drawing.Point(497, 374)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(83, 32)
        Me.btnThoat.TabIndex = 7
        Me.btnThoat.Text = "Th&oát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'btnHuyBo
        '
        Me.btnHuyBo.Image = CType(resources.GetObject("btnHuyBo.Image"), System.Drawing.Image)
        Me.btnHuyBo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHuyBo.Location = New System.Drawing.Point(404, 374)
        Me.btnHuyBo.Name = "btnHuyBo"
        Me.btnHuyBo.Size = New System.Drawing.Size(83, 32)
        Me.btnHuyBo.TabIndex = 6
        Me.btnHuyBo.Text = "    Hủy &bỏ"
        Me.btnHuyBo.UseVisualStyleBackColor = True
        '
        'btnLuu
        '
        Me.btnLuu.Image = CType(resources.GetObject("btnLuu.Image"), System.Drawing.Image)
        Me.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLuu.Location = New System.Drawing.Point(313, 374)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Size = New System.Drawing.Size(83, 32)
        Me.btnLuu.TabIndex = 5
        Me.btnLuu.Text = "&Ghi"
        Me.btnLuu.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Image = CType(resources.GetObject("btnXoa.Image"), System.Drawing.Image)
        Me.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnXoa.Location = New System.Drawing.Point(222, 374)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(83, 32)
        Me.btnXoa.TabIndex = 4
        Me.btnXoa.Text = "&Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Image = CType(resources.GetObject("btnSua.Image"), System.Drawing.Image)
        Me.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSua.Location = New System.Drawing.Point(131, 374)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(83, 32)
        Me.btnSua.TabIndex = 3
        Me.btnSua.Text = "&Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Image = CType(resources.GetObject("btnThem.Image"), System.Drawing.Image)
        Me.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThem.Location = New System.Drawing.Point(40, 374)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(83, 32)
        Me.btnThem.TabIndex = 2
        Me.btnThem.Text = "&Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'ErrorProvider
        '
        Me.ErrorProvider.BlinkRate = 0
        Me.ErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider.ContainerControl = Me
        '
        'txtHeSo
        '
        Me.txtHeSo.Location = New System.Drawing.Point(130, 79)
        Me.txtHeSo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtHeSo.MaxLength = 10
        Me.txtHeSo.Name = "txtHeSo"
        Me.txtHeSo.Size = New System.Drawing.Size(139, 22)
        Me.txtHeSo.TabIndex = 4
        Me.txtHeSo.Tag = "NN"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtMaNV)
        Me.GroupBox1.Controls.Add(Me.txtHeSo)
        Me.GroupBox1.Controls.Add(Me.txtHoTen)
        Me.GroupBox1.Controls.Add(Me.txtLuongCoBan)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.mskNgayXepLuong)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtLyDoPhuCap)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtPhuCap)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(607, 154)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin chung"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 24)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Xếp lương"
        '
        'frmThemLuong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(633, 418)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnHuyBo)
        Me.Controls.Add(Me.btnLuu)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.DataGridView)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmThemLuong"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Xếp lương"
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtHoTen As System.Windows.Forms.TextBox
    Friend WithEvents txtMaNV As System.Windows.Forms.TextBox
    Friend WithEvents txtLuongCoBan As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents mskNgayXepLuong As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtPhuCap As System.Windows.Forms.TextBox
    Friend WithEvents txtLyDoPhuCap As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents btnThoat As System.Windows.Forms.Button
    Friend WithEvents btnHuyBo As System.Windows.Forms.Button
    Friend WithEvents btnLuu As System.Windows.Forms.Button
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents btnSua As System.Windows.Forms.Button
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtHeSo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
