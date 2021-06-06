<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHangHoa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHangHoa))
        Me.Label21 = New System.Windows.Forms.Label
        Me.btnChonAnh = New System.Windows.Forms.Button
        Me.picPhoto = New System.Windows.Forms.PictureBox
        Me.btnThemNhomHang = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtXuatSu = New System.Windows.Forms.TextBox
        Me.txtTenHang = New System.Windows.Forms.TextBox
        Me.txtMaHang = New System.Windows.Forms.TextBox
        Me.btnThoat = New System.Windows.Forms.Button
        Me.btnLuu = New System.Windows.Forms.Button
        Me.btnXoaAnh = New System.Windows.Forms.Button
        Me.txtDuongDan = New System.Windows.Forms.TextBox
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.cboDVT = New System.Windows.Forms.ComboBox
        Me.cboMaNhom = New System.Windows.Forms.ComboBox
        Me.txtDGBan = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtThueVAT = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtSoLuongNhap = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtSoLuongBan = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtSoLuongTon = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        CType(Me.picPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label21.Size = New System.Drawing.Size(171, 24)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "Vật tư hàng hóa"
        '
        'btnChonAnh
        '
        Me.btnChonAnh.Location = New System.Drawing.Point(475, 198)
        Me.btnChonAnh.Name = "btnChonAnh"
        Me.btnChonAnh.Size = New System.Drawing.Size(70, 30)
        Me.btnChonAnh.TabIndex = 11
        Me.btnChonAnh.Text = "&Chọn"
        Me.btnChonAnh.UseVisualStyleBackColor = True
        '
        'picPhoto
        '
        Me.picPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPhoto.Location = New System.Drawing.Point(475, 22)
        Me.picPhoto.Name = "picPhoto"
        Me.picPhoto.Size = New System.Drawing.Size(168, 168)
        Me.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPhoto.TabIndex = 147
        Me.picPhoto.TabStop = False
        '
        'btnThemNhomHang
        '
        Me.btnThemNhomHang.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThemNhomHang.Image = CType(resources.GetObject("btnThemNhomHang.Image"), System.Drawing.Image)
        Me.btnThemNhomHang.Location = New System.Drawing.Point(415, 48)
        Me.btnThemNhomHang.Name = "btnThemNhomHang"
        Me.btnThemNhomHang.Size = New System.Drawing.Size(32, 24)
        Me.btnThemNhomHang.TabIndex = 3
        Me.btnThemNhomHang.TabStop = False
        Me.btnThemNhomHang.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 15)
        Me.Label5.TabIndex = 131
        Me.Label5.Text = "Nhóm hàng (*)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 15)
        Me.Label4.TabIndex = 135
        Me.Label4.Text = "ĐVT (*)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(10, 133)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 15)
        Me.Label7.TabIndex = 126
        Me.Label7.Text = "Xuất sứ (*)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(197, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 15)
        Me.Label2.TabIndex = 128
        Me.Label2.Text = "Tên hàng (*)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 15)
        Me.Label1.TabIndex = 129
        Me.Label1.Text = "Mã hàng(*)"
        '
        'txtXuatSu
        '
        Me.txtXuatSu.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtXuatSu.Location = New System.Drawing.Point(103, 128)
        Me.txtXuatSu.MaxLength = 50
        Me.txtXuatSu.Multiline = True
        Me.txtXuatSu.Name = "txtXuatSu"
        Me.txtXuatSu.Size = New System.Drawing.Size(344, 24)
        Me.txtXuatSu.TabIndex = 7
        Me.txtXuatSu.Tag = "NN"
        '
        'txtTenHang
        '
        Me.txtTenHang.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTenHang.Location = New System.Drawing.Point(278, 23)
        Me.txtTenHang.MaxLength = 50
        Me.txtTenHang.Name = "txtTenHang"
        Me.txtTenHang.Size = New System.Drawing.Size(169, 21)
        Me.txtTenHang.TabIndex = 1
        Me.txtTenHang.Tag = "NN"
        '
        'txtMaHang
        '
        Me.txtMaHang.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaHang.Location = New System.Drawing.Point(103, 23)
        Me.txtMaHang.MaxLength = 10
        Me.txtMaHang.Name = "txtMaHang"
        Me.txtMaHang.Size = New System.Drawing.Size(79, 21)
        Me.txtMaHang.TabIndex = 0
        Me.txtMaHang.Tag = "NN"
        '
        'btnThoat
        '
        Me.btnThoat.Image = CType(resources.GetObject("btnThoat.Image"), System.Drawing.Image)
        Me.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThoat.Location = New System.Drawing.Point(575, 312)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(75, 30)
        Me.btnThoat.TabIndex = 3
        Me.btnThoat.Text = "Th&oát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'btnLuu
        '
        Me.btnLuu.Image = CType(resources.GetObject("btnLuu.Image"), System.Drawing.Image)
        Me.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLuu.Location = New System.Drawing.Point(494, 312)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Size = New System.Drawing.Size(75, 30)
        Me.btnLuu.TabIndex = 2
        Me.btnLuu.Text = "&Ghi"
        Me.btnLuu.UseVisualStyleBackColor = True
        '
        'btnXoaAnh
        '
        Me.btnXoaAnh.Location = New System.Drawing.Point(573, 198)
        Me.btnXoaAnh.Name = "btnXoaAnh"
        Me.btnXoaAnh.Size = New System.Drawing.Size(70, 30)
        Me.btnXoaAnh.TabIndex = 12
        Me.btnXoaAnh.TabStop = False
        Me.btnXoaAnh.Text = "&Xóa"
        Me.btnXoaAnh.UseVisualStyleBackColor = True
        '
        'txtDuongDan
        '
        Me.txtDuongDan.Location = New System.Drawing.Point(551, 202)
        Me.txtDuongDan.Name = "txtDuongDan"
        Me.txtDuongDan.Size = New System.Drawing.Size(15, 22)
        Me.txtDuongDan.TabIndex = 8
        Me.txtDuongDan.TabStop = False
        Me.txtDuongDan.Tag = ""
        Me.txtDuongDan.Visible = False
        '
        'ErrorProvider
        '
        Me.ErrorProvider.BlinkRate = 0
        Me.ErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider.ContainerControl = Me
        '
        'cboDVT
        '
        Me.cboDVT.AllowDrop = True
        Me.cboDVT.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDVT.FormattingEnabled = True
        Me.cboDVT.Location = New System.Drawing.Point(103, 76)
        Me.cboDVT.Name = "cboDVT"
        Me.cboDVT.Size = New System.Drawing.Size(79, 23)
        Me.cboDVT.TabIndex = 4
        Me.cboDVT.Tag = "NN"
        '
        'cboMaNhom
        '
        Me.cboMaNhom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMaNhom.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMaNhom.FormattingEnabled = True
        Me.cboMaNhom.Location = New System.Drawing.Point(103, 48)
        Me.cboMaNhom.Name = "cboMaNhom"
        Me.cboMaNhom.Size = New System.Drawing.Size(292, 23)
        Me.cboMaNhom.TabIndex = 2
        Me.cboMaNhom.Tag = "NN"
        '
        'txtDGBan
        '
        Me.txtDGBan.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDGBan.Location = New System.Drawing.Point(278, 77)
        Me.txtDGBan.MaxLength = 10
        Me.txtDGBan.Name = "txtDGBan"
        Me.txtDGBan.Size = New System.Drawing.Size(169, 21)
        Me.txtDGBan.TabIndex = 5
        Me.txtDGBan.Tag = "NN"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(197, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 15)
        Me.Label3.TabIndex = 129
        Me.Label3.Text = "Đơn giá (*)"
        '
        'txtThueVAT
        '
        Me.txtThueVAT.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtThueVAT.Location = New System.Drawing.Point(103, 103)
        Me.txtThueVAT.MaxLength = 10
        Me.txtThueVAT.Name = "txtThueVAT"
        Me.txtThueVAT.Size = New System.Drawing.Size(344, 21)
        Me.txtThueVAT.TabIndex = 6
        Me.txtThueVAT.Tag = "NN"
        Me.txtThueVAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(10, 107)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 15)
        Me.Label6.TabIndex = 129
        Me.Label6.Text = "Thuế VAT(*)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(10, 159)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 15)
        Me.Label9.TabIndex = 126
        Me.Label9.Text = "Số lượng nhập"
        '
        'txtSoLuongNhap
        '
        Me.txtSoLuongNhap.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSoLuongNhap.Location = New System.Drawing.Point(103, 156)
        Me.txtSoLuongNhap.Name = "txtSoLuongNhap"
        Me.txtSoLuongNhap.ReadOnly = True
        Me.txtSoLuongNhap.Size = New System.Drawing.Size(344, 21)
        Me.txtSoLuongNhap.TabIndex = 8
        Me.txtSoLuongNhap.TabStop = False
        Me.txtSoLuongNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(10, 210)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 15)
        Me.Label10.TabIndex = 126
        Me.Label10.Text = "Số lượng bán"
        '
        'txtSoLuongBan
        '
        Me.txtSoLuongBan.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSoLuongBan.Location = New System.Drawing.Point(103, 205)
        Me.txtSoLuongBan.Name = "txtSoLuongBan"
        Me.txtSoLuongBan.ReadOnly = True
        Me.txtSoLuongBan.Size = New System.Drawing.Size(344, 21)
        Me.txtSoLuongBan.TabIndex = 10
        Me.txtSoLuongBan.TabStop = False
        Me.txtSoLuongBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(10, 184)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 15)
        Me.Label11.TabIndex = 126
        Me.Label11.Text = "Số lượng tồn"
        '
        'txtSoLuongTon
        '
        Me.txtSoLuongTon.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSoLuongTon.Location = New System.Drawing.Point(103, 181)
        Me.txtSoLuongTon.Name = "txtSoLuongTon"
        Me.txtSoLuongTon.ReadOnly = True
        Me.txtSoLuongTon.Size = New System.Drawing.Size(344, 21)
        Me.txtSoLuongTon.TabIndex = 9
        Me.txtSoLuongTon.TabStop = False
        Me.txtSoLuongTon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtMaHang)
        Me.GroupBox1.Controls.Add(Me.txtSoLuongTon)
        Me.GroupBox1.Controls.Add(Me.btnXoaAnh)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnChonAnh)
        Me.GroupBox1.Controls.Add(Me.txtSoLuongNhap)
        Me.GroupBox1.Controls.Add(Me.picPhoto)
        Me.GroupBox1.Controls.Add(Me.txtDuongDan)
        Me.GroupBox1.Controls.Add(Me.txtSoLuongBan)
        Me.GroupBox1.Controls.Add(Me.btnThemNhomHang)
        Me.GroupBox1.Controls.Add(Me.txtTenHang)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.cboMaNhom)
        Me.GroupBox1.Controls.Add(Me.txtDGBan)
        Me.GroupBox1.Controls.Add(Me.cboDVT)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtThueVAT)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtXuatSu)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(658, 252)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin chung"
        '
        'frmHangHoa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 361)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnLuu)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmHangHoa"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hàng hóa"
        CType(Me.picPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents btnChonAnh As System.Windows.Forms.Button
    Friend WithEvents picPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents btnThemNhomHang As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtXuatSu As System.Windows.Forms.TextBox
    Friend WithEvents txtTenHang As System.Windows.Forms.TextBox
    Friend WithEvents txtMaHang As System.Windows.Forms.TextBox
    Friend WithEvents btnThoat As System.Windows.Forms.Button
    Friend WithEvents btnLuu As System.Windows.Forms.Button
    Friend WithEvents btnXoaAnh As System.Windows.Forms.Button
    Friend WithEvents txtDuongDan As System.Windows.Forms.TextBox
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents cboDVT As System.Windows.Forms.ComboBox
    Friend WithEvents cboMaNhom As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtThueVAT As System.Windows.Forms.TextBox
    Friend WithEvents txtDGBan As System.Windows.Forms.TextBox
    Friend WithEvents txtSoLuongNhap As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtSoLuongTon As System.Windows.Forms.TextBox
    Friend WithEvents txtSoLuongBan As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
