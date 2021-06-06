<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPhieuChi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPhieuChi))
        Me.Label7 = New System.Windows.Forms.Label
        Me.btnThoat = New System.Windows.Forms.Button
        Me.mskNgayPC = New System.Windows.Forms.MaskedTextBox
        Me.txtSoTien = New System.Windows.Forms.TextBox
        Me.txtLyDoChi = New System.Windows.Forms.TextBox
        Me.txtNguoiNhan = New System.Windows.Forms.TextBox
        Me.txtNhanVien = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtMaPhieuChi = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cboMaHD = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtKemTheo = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.btnLuu = New System.Windows.Forms.Button
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(10, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 24)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Phiếu chi"
        '
        'btnThoat
        '
        Me.btnThoat.Image = CType(resources.GetObject("btnThoat.Image"), System.Drawing.Image)
        Me.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThoat.Location = New System.Drawing.Point(552, 279)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(75, 30)
        Me.btnThoat.TabIndex = 3
        Me.btnThoat.Text = "&Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'mskNgayPC
        '
        Me.mskNgayPC.Location = New System.Drawing.Point(419, 22)
        Me.mskNgayPC.Mask = "00/00/0000"
        Me.mskNgayPC.Name = "mskNgayPC"
        Me.mskNgayPC.Size = New System.Drawing.Size(174, 22)
        Me.mskNgayPC.TabIndex = 1
        Me.mskNgayPC.Tag = "NN"
        Me.mskNgayPC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.mskNgayPC.ValidatingType = GetType(Date)
        '
        'txtSoTien
        '
        Me.txtSoTien.Location = New System.Drawing.Point(378, 107)
        Me.txtSoTien.MaxLength = 19
        Me.txtSoTien.Name = "txtSoTien"
        Me.txtSoTien.Size = New System.Drawing.Size(215, 22)
        Me.txtSoTien.TabIndex = 6
        Me.txtSoTien.Tag = "NN"
        Me.txtSoTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtLyDoChi
        '
        Me.txtLyDoChi.Location = New System.Drawing.Point(124, 78)
        Me.txtLyDoChi.MaxLength = 50
        Me.txtLyDoChi.Name = "txtLyDoChi"
        Me.txtLyDoChi.Size = New System.Drawing.Size(469, 22)
        Me.txtLyDoChi.TabIndex = 4
        Me.txtLyDoChi.Tag = "NN"
        '
        'txtNguoiNhan
        '
        Me.txtNguoiNhan.Location = New System.Drawing.Point(124, 107)
        Me.txtNguoiNhan.MaxLength = 30
        Me.txtNguoiNhan.Name = "txtNguoiNhan"
        Me.txtNguoiNhan.Size = New System.Drawing.Size(150, 22)
        Me.txtNguoiNhan.TabIndex = 5
        Me.txtNguoiNhan.Tag = "NN"
        '
        'txtNhanVien
        '
        Me.txtNhanVien.Location = New System.Drawing.Point(124, 50)
        Me.txtNhanVien.MaxLength = 50
        Me.txtNhanVien.Name = "txtNhanVien"
        Me.txtNhanVien.ReadOnly = True
        Me.txtNhanVien.Size = New System.Drawing.Size(150, 22)
        Me.txtNhanVien.TabIndex = 2
        Me.txtNhanVien.TabStop = False
        Me.txtNhanVien.Tag = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(299, 110)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 16)
        Me.Label9.TabIndex = 146
        Me.Label9.Text = "Số tiền (*)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(10, 81)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 16)
        Me.Label10.TabIndex = 147
        Me.Label10.Text = "Lý do chi (*)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 110)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 16)
        Me.Label6.TabIndex = 148
        Me.Label6.Text = "Người nhận (*)"
        '
        'txtMaPhieuChi
        '
        Me.txtMaPhieuChi.Location = New System.Drawing.Point(124, 22)
        Me.txtMaPhieuChi.MaxLength = 10
        Me.txtMaPhieuChi.Name = "txtMaPhieuChi"
        Me.txtMaPhieuChi.Size = New System.Drawing.Size(150, 22)
        Me.txtMaPhieuChi.TabIndex = 0
        Me.txtMaPhieuChi.Tag = "NN"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 16)
        Me.Label4.TabIndex = 145
        Me.Label4.Text = "Nhân viên "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(306, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 144
        Me.Label2.Text = "Ngày chi(*)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(306, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 16)
        Me.Label3.TabIndex = 150
        Me.Label3.Text = "Mã HĐ (*)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 16)
        Me.Label1.TabIndex = 149
        Me.Label1.Text = "Mã phiếu chi (*)"
        '
        'cboMaHD
        '
        Me.cboMaHD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMaHD.FormattingEnabled = True
        Me.cboMaHD.Location = New System.Drawing.Point(419, 49)
        Me.cboMaHD.Name = "cboMaHD"
        Me.cboMaHD.Size = New System.Drawing.Size(174, 24)
        Me.cboMaHD.TabIndex = 3
        Me.cboMaHD.Tag = "NN"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 16)
        Me.Label5.TabIndex = 147
        Me.Label5.Text = "Kèm theo chứng từ"
        '
        'txtKemTheo
        '
        Me.txtKemTheo.Location = New System.Drawing.Point(141, 135)
        Me.txtKemTheo.MaxLength = 50
        Me.txtKemTheo.Multiline = True
        Me.txtKemTheo.Name = "txtKemTheo"
        Me.txtKemTheo.Size = New System.Drawing.Size(452, 64)
        Me.txtKemTheo.TabIndex = 7
        Me.txtKemTheo.Tag = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(21, 286)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(206, 16)
        Me.Label11.TabIndex = 147
        Me.Label11.Text = "Chú ý phần (*) bắt buộc phải nhập"
        '
        'btnLuu
        '
        Me.btnLuu.Image = CType(resources.GetObject("btnLuu.Image"), System.Drawing.Image)
        Me.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLuu.Location = New System.Drawing.Point(454, 279)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Size = New System.Drawing.Size(75, 30)
        Me.btnLuu.TabIndex = 2
        Me.btnLuu.Text = "&Ghi"
        Me.btnLuu.UseVisualStyleBackColor = True
        '
        'ErrorProvider
        '
        Me.ErrorProvider.BlinkRate = 0
        Me.ErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider.ContainerControl = Me
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.mskNgayPC)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cboMaHD)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtSoTien)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtKemTheo)
        Me.GroupBox1.Controls.Add(Me.txtMaPhieuChi)
        Me.GroupBox1.Controls.Add(Me.txtLyDoChi)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtNguoiNhan)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtNhanVien)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(617, 220)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin chung"
        '
        'frmPhieuChi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 322)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnLuu)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.Label7)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPhieuChi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Trả tiền nhà cung cấp"
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnThoat As System.Windows.Forms.Button
    Friend WithEvents mskNgayPC As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtSoTien As System.Windows.Forms.TextBox
    Friend WithEvents txtLyDoChi As System.Windows.Forms.TextBox
    Friend WithEvents txtNguoiNhan As System.Windows.Forms.TextBox
    Friend WithEvents txtNhanVien As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtMaPhieuChi As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboMaHD As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtKemTheo As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnLuu As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
