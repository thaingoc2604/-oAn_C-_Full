<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPhieuNhapKho
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPhieuNhapKho))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.btnHuyBo = New System.Windows.Forms.Button
        Me.btnLuu = New System.Windows.Forms.Button
        Me.DataGridView = New System.Windows.Forms.DataGridView
        Me.colMaH = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.colDGNhap = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSoLuong = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colThanhTien = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colXoa = New System.Windows.Forms.DataGridViewButtonColumn
        Me.btnThemNhaCC = New System.Windows.Forms.Button
        Me.cboNhaCC = New System.Windows.Forms.ComboBox
        Me.mskNgayNK = New System.Windows.Forms.MaskedTextBox
        Me.txtNguoiGH = New System.Windows.Forms.TextBox
        Me.txtMaPNK = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.cboMaKho = New System.Windows.Forms.ComboBox
        Me.btnThemKho = New System.Windows.Forms.Button
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.DataGridViewComboBoxColumn1 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.DataGridViewComboBoxColumn2 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.txtNhanVien = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnHuyBo
        '
        Me.btnHuyBo.Image = CType(resources.GetObject("btnHuyBo.Image"), System.Drawing.Image)
        Me.btnHuyBo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHuyBo.Location = New System.Drawing.Point(867, 530)
        Me.btnHuyBo.Name = "btnHuyBo"
        Me.btnHuyBo.Size = New System.Drawing.Size(75, 30)
        Me.btnHuyBo.TabIndex = 4
        Me.btnHuyBo.Text = "   &Thoát"
        Me.btnHuyBo.UseVisualStyleBackColor = True
        '
        'btnLuu
        '
        Me.btnLuu.Image = CType(resources.GetObject("btnLuu.Image"), System.Drawing.Image)
        Me.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLuu.Location = New System.Drawing.Point(757, 530)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Size = New System.Drawing.Size(75, 30)
        Me.btnLuu.TabIndex = 3
        Me.btnLuu.Text = "&Ghi"
        Me.btnLuu.UseVisualStyleBackColor = True
        '
        'DataGridView
        '
        Me.DataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colMaH, Me.colDGNhap, Me.colSoLuong, Me.colThanhTien, Me.colXoa})
        Me.DataGridView.Location = New System.Drawing.Point(10, 180)
        Me.DataGridView.Name = "DataGridView"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView.RowHeadersWidth = 50
        Me.DataGridView.Size = New System.Drawing.Size(932, 329)
        Me.DataGridView.TabIndex = 2
        '
        'colMaH
        '
        Me.colMaH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colMaH.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.colMaH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.colMaH.HeaderText = "Tên hàng"
        Me.colMaH.Name = "colMaH"
        Me.colMaH.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'colDGNhap
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.colDGNhap.DefaultCellStyle = DataGridViewCellStyle2
        Me.colDGNhap.HeaderText = "Đơn giá"
        Me.colDGNhap.MaxInputLength = 19
        Me.colDGNhap.Name = "colDGNhap"
        Me.colDGNhap.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colDGNhap.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colSoLuong
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N0"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.colSoLuong.DefaultCellStyle = DataGridViewCellStyle3
        Me.colSoLuong.HeaderText = "Số lượng"
        Me.colSoLuong.MaxInputLength = 19
        Me.colSoLuong.Name = "colSoLuong"
        Me.colSoLuong.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colSoLuong.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colThanhTien
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colThanhTien.DefaultCellStyle = DataGridViewCellStyle4
        Me.colThanhTien.HeaderText = "Thành tiền"
        Me.colThanhTien.Name = "colThanhTien"
        Me.colThanhTien.ReadOnly = True
        Me.colThanhTien.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colThanhTien.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colXoa
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.NullValue = "Xóa"
        Me.colXoa.DefaultCellStyle = DataGridViewCellStyle5
        Me.colXoa.HeaderText = ""
        Me.colXoa.Name = "colXoa"
        Me.colXoa.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'btnThemNhaCC
        '
        Me.btnThemNhaCC.Image = CType(resources.GetObject("btnThemNhaCC.Image"), System.Drawing.Image)
        Me.btnThemNhaCC.Location = New System.Drawing.Point(604, 20)
        Me.btnThemNhaCC.Name = "btnThemNhaCC"
        Me.btnThemNhaCC.Size = New System.Drawing.Size(32, 24)
        Me.btnThemNhaCC.TabIndex = 1
        Me.btnThemNhaCC.TabStop = False
        Me.btnThemNhaCC.UseVisualStyleBackColor = True
        '
        'cboNhaCC
        '
        Me.cboNhaCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNhaCC.FormattingEnabled = True
        Me.cboNhaCC.Location = New System.Drawing.Point(126, 21)
        Me.cboNhaCC.Name = "cboNhaCC"
        Me.cboNhaCC.Size = New System.Drawing.Size(456, 23)
        Me.cboNhaCC.TabIndex = 0
        Me.cboNhaCC.Tag = "NN"
        '
        'mskNgayNK
        '
        Me.mskNgayNK.Location = New System.Drawing.Point(109, 49)
        Me.mskNgayNK.Mask = "00/00/0000"
        Me.mskNgayNK.Name = "mskNgayNK"
        Me.mskNgayNK.Size = New System.Drawing.Size(135, 21)
        Me.mskNgayNK.TabIndex = 1
        Me.mskNgayNK.Tag = "NN"
        Me.mskNgayNK.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.mskNgayNK.ValidatingType = GetType(Date)
        '
        'txtNguoiGH
        '
        Me.txtNguoiGH.Location = New System.Drawing.Point(126, 79)
        Me.txtNguoiGH.MaxLength = 30
        Me.txtNguoiGH.Name = "txtNguoiGH"
        Me.txtNguoiGH.Size = New System.Drawing.Size(193, 21)
        Me.txtNguoiGH.TabIndex = 4
        '
        'txtMaPNK
        '
        Me.txtMaPNK.Location = New System.Drawing.Point(109, 22)
        Me.txtMaPNK.MaxLength = 10
        Me.txtMaPNK.Name = "txtMaPNK"
        Me.txtMaPNK.Size = New System.Drawing.Size(135, 21)
        Me.txtMaPNK.TabIndex = 0
        Me.txtMaPNK.Tag = "NN"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(349, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 15)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Nhân viên (*)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 15)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Ngày NK(*)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 15)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Người giao hàng"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 15)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Nhà cung cấp (*)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(10, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(168, 24)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Phiếu nhập kho"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 15)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Mã PNK (*)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 54)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 15)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = " Kho(*)"
        '
        'cboMaKho
        '
        Me.cboMaKho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMaKho.FormattingEnabled = True
        Me.cboMaKho.Location = New System.Drawing.Point(126, 50)
        Me.cboMaKho.Name = "cboMaKho"
        Me.cboMaKho.Size = New System.Drawing.Size(456, 23)
        Me.cboMaKho.TabIndex = 2
        Me.cboMaKho.Tag = "NN"
        '
        'btnThemKho
        '
        Me.btnThemKho.Image = CType(resources.GetObject("btnThemKho.Image"), System.Drawing.Image)
        Me.btnThemKho.Location = New System.Drawing.Point(604, 49)
        Me.btnThemKho.Name = "btnThemKho"
        Me.btnThemKho.Size = New System.Drawing.Size(32, 24)
        Me.btnThemKho.TabIndex = 3
        Me.btnThemKho.TabStop = False
        Me.btnThemKho.UseVisualStyleBackColor = True
        '
        'ErrorProvider
        '
        Me.ErrorProvider.BlinkRate = 0
        Me.ErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider.ContainerControl = Me
        '
        'DataGridViewComboBoxColumn1
        '
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.Yellow
        Me.DataGridViewComboBoxColumn1.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewComboBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.DataGridViewComboBoxColumn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.DataGridViewComboBoxColumn1.Frozen = True
        Me.DataGridViewComboBoxColumn1.HeaderText = "Tên hàng"
        Me.DataGridViewComboBoxColumn1.Name = "DataGridViewComboBoxColumn1"
        Me.DataGridViewComboBoxColumn1.ReadOnly = True
        Me.DataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewComboBoxColumn1.Width = 250
        '
        'DataGridViewComboBoxColumn2
        '
        Me.DataGridViewComboBoxColumn2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.DataGridViewComboBoxColumn2.Frozen = True
        Me.DataGridViewComboBoxColumn2.HeaderText = "Kho"
        Me.DataGridViewComboBoxColumn2.Name = "DataGridViewComboBoxColumn2"
        '
        'txtNhanVien
        '
        Me.txtNhanVien.Location = New System.Drawing.Point(443, 79)
        Me.txtNhanVien.MaxLength = 10
        Me.txtNhanVien.Name = "txtNhanVien"
        Me.txtNhanVien.ReadOnly = True
        Me.txtNhanVien.Size = New System.Drawing.Size(193, 21)
        Me.txtNhanVien.TabIndex = 5
        Me.txtNhanVien.TabStop = False
        Me.txtNhanVien.Tag = "NN"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 530)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(169, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Phần (*) bắt buộc phải nhập"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.btnThemKho)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btnThemNhaCC)
        Me.GroupBox1.Controls.Add(Me.txtNhanVien)
        Me.GroupBox1.Controls.Add(Me.cboMaKho)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cboNhaCC)
        Me.GroupBox1.Controls.Add(Me.txtNguoiGH)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(10, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(662, 119)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin chung"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.mskNgayNK)
        Me.GroupBox2.Controls.Add(Me.txtMaPNK)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(690, 45)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(252, 119)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Chứng từ"
        '
        'frmPhieuNhapKho
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(964, 572)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnHuyBo)
        Me.Controls.Add(Me.btnLuu)
        Me.Controls.Add(Me.DataGridView)
        Me.Controls.Add(Me.Label7)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPhieuNhapKho"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thêm mới phiếu nhập kho"
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnHuyBo As System.Windows.Forms.Button
    Friend WithEvents DataGridViewComboBoxColumn1 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents btnLuu As System.Windows.Forms.Button
    Friend WithEvents DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents btnThemNhaCC As System.Windows.Forms.Button
    Friend WithEvents cboNhaCC As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridViewComboBoxColumn2 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents mskNgayNK As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtNguoiGH As System.Windows.Forms.TextBox
    Friend WithEvents txtMaPNK As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cboMaKho As System.Windows.Forms.ComboBox
    Friend WithEvents btnThemKho As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtNhanVien As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents colMaH As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents colDGNhap As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSoLuong As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colThanhTien As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colXoa As System.Windows.Forms.DataGridViewButtonColumn
End Class
