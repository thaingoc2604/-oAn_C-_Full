<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNhaCC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNhaCC))
        Me.Label21 = New System.Windows.Forms.Label
        Me.txtWebsite = New System.Windows.Forms.TextBox
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.txtTaiKhoan = New System.Windows.Forms.TextBox
        Me.txtMST = New System.Windows.Forms.TextBox
        Me.txtDiaChi = New System.Windows.Forms.TextBox
        Me.txtDaiDien = New System.Windows.Forms.TextBox
        Me.btnThoat = New System.Windows.Forms.Button
        Me.btnLuu = New System.Windows.Forms.Button
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtNganHang = New System.Windows.Forms.TextBox
        Me.txtTenNCC = New System.Windows.Forms.TextBox
        Me.mskDienThoai = New System.Windows.Forms.MaskedTextBox
        Me.mskFax = New System.Windows.Forms.MaskedTextBox
        Me.cboMaTinhTP = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtMoTa = New System.Windows.Forms.TextBox
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnThemTinhTP = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(10, 10)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(149, 24)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "Nhà cung cấp"
        '
        'txtWebsite
        '
        Me.txtWebsite.Location = New System.Drawing.Point(112, 261)
        Me.txtWebsite.MaxLength = 50
        Me.txtWebsite.Name = "txtWebsite"
        Me.txtWebsite.Size = New System.Drawing.Size(548, 21)
        Me.txtWebsite.TabIndex = 11
        Me.txtWebsite.Tag = ""
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(112, 234)
        Me.txtEmail.MaxLength = 50
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(548, 21)
        Me.txtEmail.TabIndex = 10
        Me.txtEmail.Tag = ""
        '
        'txtTaiKhoan
        '
        Me.txtTaiKhoan.Location = New System.Drawing.Point(449, 155)
        Me.txtTaiKhoan.MaxLength = 15
        Me.txtTaiKhoan.Name = "txtTaiKhoan"
        Me.txtTaiKhoan.Size = New System.Drawing.Size(211, 21)
        Me.txtTaiKhoan.TabIndex = 6
        Me.txtTaiKhoan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMST
        '
        Me.txtMST.Location = New System.Drawing.Point(112, 155)
        Me.txtMST.MaxLength = 10
        Me.txtMST.Name = "txtMST"
        Me.txtMST.Size = New System.Drawing.Size(206, 21)
        Me.txtMST.TabIndex = 5
        Me.txtMST.Tag = ""
        Me.txtMST.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Location = New System.Drawing.Point(112, 77)
        Me.txtDiaChi.MaxLength = 50
        Me.txtDiaChi.Multiline = True
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(548, 44)
        Me.txtDiaChi.TabIndex = 2
        Me.txtDiaChi.Tag = ""
        '
        'txtDaiDien
        '
        Me.txtDaiDien.Location = New System.Drawing.Point(112, 49)
        Me.txtDaiDien.MaxLength = 30
        Me.txtDaiDien.Name = "txtDaiDien"
        Me.txtDaiDien.Size = New System.Drawing.Size(548, 21)
        Me.txtDaiDien.TabIndex = 1
        Me.txtDaiDien.Tag = ""
        '
        'btnThoat
        '
        Me.btnThoat.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoat.Image = CType(resources.GetObject("btnThoat.Image"), System.Drawing.Image)
        Me.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThoat.Location = New System.Drawing.Point(625, 380)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(75, 30)
        Me.btnThoat.TabIndex = 3
        Me.btnThoat.Text = "Th&oát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'btnLuu
        '
        Me.btnLuu.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLuu.Image = CType(resources.GetObject("btnLuu.Image"), System.Drawing.Image)
        Me.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLuu.Location = New System.Drawing.Point(531, 380)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Size = New System.Drawing.Size(75, 30)
        Me.btnLuu.TabIndex = 2
        Me.btnLuu.Text = "&Ghi"
        Me.btnLuu.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(10, 264)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(52, 15)
        Me.Label15.TabIndex = 180
        Me.Label15.Text = "Website"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(351, 211)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(26, 15)
        Me.Label13.TabIndex = 178
        Me.Label13.Text = "Fax"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 237)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 15)
        Me.Label11.TabIndex = 179
        Me.Label11.Text = "Email"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 211)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 15)
        Me.Label10.TabIndex = 174
        Me.Label10.Text = "Điện thoại"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 91)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 15)
        Me.Label5.TabIndex = 173
        Me.Label5.Text = "Địa chỉ"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 188)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 15)
        Me.Label9.TabIndex = 175
        Me.Label9.Text = "Mở tại"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 15)
        Me.Label4.TabIndex = 177
        Me.Label4.Text = "Người đại diện"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(351, 158)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 15)
        Me.Label8.TabIndex = 176
        Me.Label8.Text = "Số tài khoản"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 158)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 15)
        Me.Label7.TabIndex = 169
        Me.Label7.Text = "Mã số thuế"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 15)
        Me.Label6.TabIndex = 172
        Me.Label6.Text = "Tỉnh TP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 15)
        Me.Label2.TabIndex = 171
        Me.Label2.Text = "Tên NCC(*)"
        '
        'txtNganHang
        '
        Me.txtNganHang.Location = New System.Drawing.Point(112, 182)
        Me.txtNganHang.MaxLength = 50
        Me.txtNganHang.Name = "txtNganHang"
        Me.txtNganHang.Size = New System.Drawing.Size(548, 21)
        Me.txtNganHang.TabIndex = 7
        '
        'txtTenNCC
        '
        Me.txtTenNCC.Location = New System.Drawing.Point(112, 22)
        Me.txtTenNCC.MaxLength = 50
        Me.txtTenNCC.Name = "txtTenNCC"
        Me.txtTenNCC.Size = New System.Drawing.Size(548, 21)
        Me.txtTenNCC.TabIndex = 0
        Me.txtTenNCC.Tag = "NN"
        '
        'mskDienThoai
        '
        Me.mskDienThoai.Location = New System.Drawing.Point(112, 208)
        Me.mskDienThoai.Mask = "(9999) 000-0000"
        Me.mskDienThoai.Name = "mskDienThoai"
        Me.mskDienThoai.Size = New System.Drawing.Size(206, 21)
        Me.mskDienThoai.TabIndex = 8
        Me.mskDienThoai.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'mskFax
        '
        Me.mskFax.Location = New System.Drawing.Point(449, 208)
        Me.mskFax.Mask = "(9999) 000-0000"
        Me.mskFax.Name = "mskFax"
        Me.mskFax.Size = New System.Drawing.Size(211, 21)
        Me.mskFax.TabIndex = 9
        Me.mskFax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cboMaTinhTP
        '
        Me.cboMaTinhTP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMaTinhTP.FormattingEnabled = True
        Me.cboMaTinhTP.Location = New System.Drawing.Point(112, 126)
        Me.cboMaTinhTP.Name = "cboMaTinhTP"
        Me.cboMaTinhTP.Size = New System.Drawing.Size(497, 23)
        Me.cboMaTinhTP.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 291)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 15)
        Me.Label1.TabIndex = 180
        Me.Label1.Text = "Mô tả"
        '
        'txtMoTa
        '
        Me.txtMoTa.Location = New System.Drawing.Point(112, 288)
        Me.txtMoTa.MaxLength = 200
        Me.txtMoTa.Name = "txtMoTa"
        Me.txtMoTa.Size = New System.Drawing.Size(548, 21)
        Me.txtMoTa.TabIndex = 12
        Me.txtMoTa.Tag = ""
        '
        'ErrorProvider
        '
        Me.ErrorProvider.BlinkRate = 0
        Me.ErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider.ContainerControl = Me
        '
        'btnThemTinhTP
        '
        Me.btnThemTinhTP.Image = CType(resources.GetObject("btnThemTinhTP.Image"), System.Drawing.Image)
        Me.btnThemTinhTP.Location = New System.Drawing.Point(628, 126)
        Me.btnThemTinhTP.Name = "btnThemTinhTP"
        Me.btnThemTinhTP.Size = New System.Drawing.Size(32, 24)
        Me.btnThemTinhTP.TabIndex = 4
        Me.btnThemTinhTP.TabStop = False
        Me.btnThemTinhTP.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtTenNCC)
        Me.GroupBox1.Controls.Add(Me.mskFax)
        Me.GroupBox1.Controls.Add(Me.btnThemTinhTP)
        Me.GroupBox1.Controls.Add(Me.mskDienThoai)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtMoTa)
        Me.GroupBox1.Controls.Add(Me.cboMaTinhTP)
        Me.GroupBox1.Controls.Add(Me.txtWebsite)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtDaiDien)
        Me.GroupBox1.Controls.Add(Me.txtDiaChi)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtTaiKhoan)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtMST)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtNganHang)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(10, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(690, 322)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin chung"
        '
        'frmNhaCC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(714, 422)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnLuu)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNhaCC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nhà cung cấp"
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtWebsite As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtTaiKhoan As System.Windows.Forms.TextBox
    Friend WithEvents txtMST As System.Windows.Forms.TextBox
    Friend WithEvents txtDiaChi As System.Windows.Forms.TextBox
    Friend WithEvents txtDaiDien As System.Windows.Forms.TextBox
    Friend WithEvents btnThoat As System.Windows.Forms.Button
    Friend WithEvents btnLuu As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNganHang As System.Windows.Forms.TextBox
    Friend WithEvents txtTenNCC As System.Windows.Forms.TextBox
    Friend WithEvents mskDienThoai As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskFax As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cboMaTinhTP As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMoTa As System.Windows.Forms.TextBox
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnThemTinhTP As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
