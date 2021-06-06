<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPhieuThu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPhieuThu))
        Me.cboMaHD = New System.Windows.Forms.ComboBox
        Me.mskNgayPT = New System.Windows.Forms.MaskedTextBox
        Me.txtSoTien = New System.Windows.Forms.TextBox
        Me.txtKemTheo = New System.Windows.Forms.TextBox
        Me.txtLyDoThu = New System.Windows.Forms.TextBox
        Me.txtNguoiNop = New System.Windows.Forms.TextBox
        Me.txtNhanVien = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtMaPhieuThu = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnThoat = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.btnLuu = New System.Windows.Forms.Button
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboMaHD
        '
        Me.cboMaHD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMaHD.FormattingEnabled = True
        Me.cboMaHD.Location = New System.Drawing.Point(424, 50)
        Me.cboMaHD.Name = "cboMaHD"
        Me.cboMaHD.Size = New System.Drawing.Size(181, 23)
        Me.cboMaHD.TabIndex = 3
        Me.cboMaHD.Tag = "NN"
        '
        'mskNgayPT
        '
        Me.mskNgayPT.Location = New System.Drawing.Point(424, 22)
        Me.mskNgayPT.Mask = "00/00/0000"
        Me.mskNgayPT.Name = "mskNgayPT"
        Me.mskNgayPT.Size = New System.Drawing.Size(181, 21)
        Me.mskNgayPT.TabIndex = 1
        Me.mskNgayPT.Tag = "NN"
        Me.mskNgayPT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.mskNgayPT.ValidatingType = GetType(Date)
        '
        'txtSoTien
        '
        Me.txtSoTien.Location = New System.Drawing.Point(424, 104)
        Me.txtSoTien.MaxLength = 19
        Me.txtSoTien.Name = "txtSoTien"
        Me.txtSoTien.Size = New System.Drawing.Size(181, 21)
        Me.txtSoTien.TabIndex = 6
        Me.txtSoTien.Tag = "NN"
        Me.txtSoTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtKemTheo
        '
        Me.txtKemTheo.Location = New System.Drawing.Point(129, 130)
        Me.txtKemTheo.MaxLength = 50
        Me.txtKemTheo.Multiline = True
        Me.txtKemTheo.Name = "txtKemTheo"
        Me.txtKemTheo.Size = New System.Drawing.Size(476, 42)
        Me.txtKemTheo.TabIndex = 7
        Me.txtKemTheo.Tag = ""
        '
        'txtLyDoThu
        '
        Me.txtLyDoThu.Location = New System.Drawing.Point(129, 78)
        Me.txtLyDoThu.MaxLength = 50
        Me.txtLyDoThu.Name = "txtLyDoThu"
        Me.txtLyDoThu.Size = New System.Drawing.Size(476, 21)
        Me.txtLyDoThu.TabIndex = 4
        Me.txtLyDoThu.Tag = "NN"
        '
        'txtNguoiNop
        '
        Me.txtNguoiNop.Location = New System.Drawing.Point(129, 104)
        Me.txtNguoiNop.MaxLength = 30
        Me.txtNguoiNop.Name = "txtNguoiNop"
        Me.txtNguoiNop.Size = New System.Drawing.Size(150, 21)
        Me.txtNguoiNop.TabIndex = 5
        Me.txtNguoiNop.Tag = "NN"
        '
        'txtNhanVien
        '
        Me.txtNhanVien.Location = New System.Drawing.Point(129, 51)
        Me.txtNhanVien.MaxLength = 50
        Me.txtNhanVien.Name = "txtNhanVien"
        Me.txtNhanVien.ReadOnly = True
        Me.txtNhanVien.Size = New System.Drawing.Size(150, 21)
        Me.txtNhanVien.TabIndex = 2
        Me.txtNhanVien.TabStop = False
        Me.txtNhanVien.Tag = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(8, 256)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(206, 16)
        Me.Label11.TabIndex = 177
        Me.Label11.Text = "Chú ý phần (*) bắt buộc phải nhập"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 15)
        Me.Label5.TabIndex = 174
        Me.Label5.Text = "Kèm theo chứng từ"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(311, 107)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 15)
        Me.Label9.TabIndex = 172
        Me.Label9.Text = "Số tiền (*)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(10, 81)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 15)
        Me.Label10.TabIndex = 176
        Me.Label10.Text = "Lý do thu (*)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 107)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 15)
        Me.Label6.TabIndex = 178
        Me.Label6.Text = "Người nộp (*)"
        '
        'txtMaPhieuThu
        '
        Me.txtMaPhieuThu.Location = New System.Drawing.Point(129, 22)
        Me.txtMaPhieuThu.MaxLength = 10
        Me.txtMaPhieuThu.Name = "txtMaPhieuThu"
        Me.txtMaPhieuThu.Size = New System.Drawing.Size(150, 21)
        Me.txtMaPhieuThu.TabIndex = 0
        Me.txtMaPhieuThu.Tag = "NN"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 15)
        Me.Label4.TabIndex = 171
        Me.Label4.Text = "Nhân viên "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(311, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 15)
        Me.Label2.TabIndex = 170
        Me.Label2.Text = "Ngày thu*)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(311, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 15)
        Me.Label3.TabIndex = 180
        Me.Label3.Text = "Mã HĐ (*)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 15)
        Me.Label1.TabIndex = 179
        Me.Label1.Text = "Mã phiếu thu (*)"
        '
        'btnThoat
        '
        Me.btnThoat.Image = CType(resources.GetObject("btnThoat.Image"), System.Drawing.Image)
        Me.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThoat.Location = New System.Drawing.Point(572, 249)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(75, 30)
        Me.btnThoat.TabIndex = 3
        Me.btnThoat.Text = "  &Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(10, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 24)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Phiếu thu"
        '
        'btnLuu
        '
        Me.btnLuu.Image = CType(resources.GetObject("btnLuu.Image"), System.Drawing.Image)
        Me.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLuu.Location = New System.Drawing.Point(470, 249)
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
        Me.GroupBox1.Controls.Add(Me.mskNgayPT)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cboMaHD)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtSoTien)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtKemTheo)
        Me.GroupBox1.Controls.Add(Me.txtMaPhieuThu)
        Me.GroupBox1.Controls.Add(Me.txtLyDoThu)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtNguoiNop)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtNhanVien)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(10, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(636, 186)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin chung"
        '
        'frmPhieuThu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 297)
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
        Me.Name = "frmPhieuThu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thu tiền khách hàng"
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboMaHD As System.Windows.Forms.ComboBox
    Friend WithEvents mskNgayPT As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtSoTien As System.Windows.Forms.TextBox
    Friend WithEvents txtKemTheo As System.Windows.Forms.TextBox
    Friend WithEvents txtLyDoThu As System.Windows.Forms.TextBox
    Friend WithEvents txtNguoiNop As System.Windows.Forms.TextBox
    Friend WithEvents txtNhanVien As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtMaPhieuThu As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnThoat As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnLuu As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
