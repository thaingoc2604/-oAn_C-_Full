<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPhieuXuatKho
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPhieuXuatKho))
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnHuyBo = New System.Windows.Forms.Button
        Me.btnLuu = New System.Windows.Forms.Button
        Me.DataGridView = New System.Windows.Forms.DataGridView
        Me.colMaH = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.colDGXuat = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSoLuong = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colChietKhau = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colThueVAT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colThanhTien = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colXoa = New System.Windows.Forms.DataGridViewButtonColumn
        Me.btnThemKho = New System.Windows.Forms.Button
        Me.btnThemKhachHang = New System.Windows.Forms.Button
        Me.cboMaKho = New System.Windows.Forms.ComboBox
        Me.cboKhachHang = New System.Windows.Forms.ComboBox
        Me.mskNgayXK = New System.Windows.Forms.MaskedTextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtMaPXK = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.DataGridViewComboBoxColumn1 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.DataGridViewComboBoxColumn2 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.txtNhanVien = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ErrorProvider
        '
        Me.ErrorProvider.BlinkRate = 0
        Me.ErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider.ContainerControl = Me
        '
        'btnHuyBo
        '
        Me.btnHuyBo.Image = CType(resources.GetObject("btnHuyBo.Image"), System.Drawing.Image)
        Me.btnHuyBo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHuyBo.Location = New System.Drawing.Point(867, 530)
        Me.btnHuyBo.Name = "btnHuyBo"
        Me.btnHuyBo.Size = New System.Drawing.Size(75, 30)
        Me.btnHuyBo.TabIndex = 4
        Me.btnHuyBo.Text = "    &Thoát"
        Me.btnHuyBo.UseVisualStyleBackColor = True
        '
        'btnLuu
        '
        Me.btnLuu.Image = CType(resources.GetObject("btnLuu.Image"), System.Drawing.Image)
        Me.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLuu.Location = New System.Drawing.Point(761, 530)
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
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colMaH, Me.colDGXuat, Me.colSoLuong, Me.colChietKhau, Me.colThueVAT, Me.colThanhTien, Me.colXoa})
        Me.DataGridView.Location = New System.Drawing.Point(10, 174)
        Me.DataGridView.Name = "DataGridView"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridView.RowHeadersWidth = 60
        Me.DataGridView.Size = New System.Drawing.Size(932, 335)
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
        'colDGXuat
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.colDGXuat.DefaultCellStyle = DataGridViewCellStyle2
        Me.colDGXuat.HeaderText = "Đơn giá"
        Me.colDGXuat.MaxInputLength = 19
        Me.colDGXuat.Name = "colDGXuat"
        Me.colDGXuat.ReadOnly = True
        Me.colDGXuat.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colDGXuat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
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
        'colChietKhau
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N0"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.colChietKhau.DefaultCellStyle = DataGridViewCellStyle4
        Me.colChietKhau.HeaderText = "Chiết khấu"
        Me.colChietKhau.Name = "colChietKhau"
        '
        'colThueVAT
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N0"
        Me.colThueVAT.DefaultCellStyle = DataGridViewCellStyle5
        Me.colThueVAT.HeaderText = "Thuế VAT (%)"
        Me.colThueVAT.Name = "colThueVAT"
        Me.colThueVAT.ReadOnly = True
        Me.colThueVAT.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colThueVAT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colThanhTien
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.colThanhTien.DefaultCellStyle = DataGridViewCellStyle6
        Me.colThanhTien.HeaderText = "Thành tiền"
        Me.colThanhTien.Name = "colThanhTien"
        Me.colThanhTien.ReadOnly = True
        Me.colThanhTien.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colThanhTien.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colXoa
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.NullValue = "Xóa"
        Me.colXoa.DefaultCellStyle = DataGridViewCellStyle7
        Me.colXoa.HeaderText = ""
        Me.colXoa.Name = "colXoa"
        Me.colXoa.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'btnThemKho
        '
        Me.btnThemKho.Image = CType(resources.GetObject("btnThemKho.Image"), System.Drawing.Image)
        Me.btnThemKho.Location = New System.Drawing.Point(609, 49)
        Me.btnThemKho.Name = "btnThemKho"
        Me.btnThemKho.Size = New System.Drawing.Size(31, 22)
        Me.btnThemKho.TabIndex = 3
        Me.btnThemKho.TabStop = False
        Me.btnThemKho.UseVisualStyleBackColor = True
        '
        'btnThemKhachHang
        '
        Me.btnThemKhachHang.Image = CType(resources.GetObject("btnThemKhachHang.Image"), System.Drawing.Image)
        Me.btnThemKhachHang.Location = New System.Drawing.Point(609, 21)
        Me.btnThemKhachHang.Name = "btnThemKhachHang"
        Me.btnThemKhachHang.Size = New System.Drawing.Size(31, 22)
        Me.btnThemKhachHang.TabIndex = 1
        Me.btnThemKhachHang.TabStop = False
        Me.btnThemKhachHang.UseVisualStyleBackColor = True
        '
        'cboMaKho
        '
        Me.cboMaKho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMaKho.FormattingEnabled = True
        Me.cboMaKho.Location = New System.Drawing.Point(132, 50)
        Me.cboMaKho.Name = "cboMaKho"
        Me.cboMaKho.Size = New System.Drawing.Size(459, 23)
        Me.cboMaKho.TabIndex = 2
        Me.cboMaKho.Tag = "NN"
        '
        'cboKhachHang
        '
        Me.cboKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKhachHang.FormattingEnabled = True
        Me.cboKhachHang.Location = New System.Drawing.Point(132, 21)
        Me.cboKhachHang.Name = "cboKhachHang"
        Me.cboKhachHang.Size = New System.Drawing.Size(459, 23)
        Me.cboKhachHang.TabIndex = 0
        Me.cboKhachHang.Tag = "NN"
        '
        'mskNgayXK
        '
        Me.mskNgayXK.Location = New System.Drawing.Point(84, 49)
        Me.mskNgayXK.Mask = "00/00/0000"
        Me.mskNgayXK.Name = "mskNgayXK"
        Me.mskNgayXK.Size = New System.Drawing.Size(144, 21)
        Me.mskNgayXK.TabIndex = 1
        Me.mskNgayXK.Tag = "NN"
        Me.mskNgayXK.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.mskNgayXK.ValidatingType = GetType(Date)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 54)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 15)
        Me.Label8.TabIndex = 115
        Me.Label8.Text = " Kho(*)"
        '
        'txtMaPXK
        '
        Me.txtMaPXK.Location = New System.Drawing.Point(84, 22)
        Me.txtMaPXK.MaxLength = 10
        Me.txtMaPXK.Name = "txtMaPXK"
        Me.txtMaPXK.Size = New System.Drawing.Size(144, 21)
        Me.txtMaPXK.TabIndex = 0
        Me.txtMaPXK.Tag = "NN"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 15)
        Me.Label4.TabIndex = 114
        Me.Label4.Text = "Nhân viên (*)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 15)
        Me.Label2.TabIndex = 110
        Me.Label2.Text = "Ngày XK(*)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 15)
        Me.Label3.TabIndex = 119
        Me.Label3.Text = "Khách hàng (*)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(10, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(161, 24)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Phiếu xuất kho"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 15)
        Me.Label1.TabIndex = 117
        Me.Label1.Text = "Mã PXK (*)"
        '
        'DataGridViewComboBoxColumn1
        '
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.Yellow
        Me.DataGridViewComboBoxColumn1.DefaultCellStyle = DataGridViewCellStyle9
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
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "N0"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.DataGridViewComboBoxColumn2.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewComboBoxColumn2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.DataGridViewComboBoxColumn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DataGridViewComboBoxColumn2.Frozen = True
        Me.DataGridViewComboBoxColumn2.HeaderText = "Kho"
        Me.DataGridViewComboBoxColumn2.Name = "DataGridViewComboBoxColumn2"
        Me.DataGridViewComboBoxColumn2.ReadOnly = True
        '
        'txtNhanVien
        '
        Me.txtNhanVien.Location = New System.Drawing.Point(132, 79)
        Me.txtNhanVien.MaxLength = 10
        Me.txtNhanVien.Name = "txtNhanVien"
        Me.txtNhanVien.ReadOnly = True
        Me.txtNhanVien.Size = New System.Drawing.Size(508, 21)
        Me.txtNhanVien.TabIndex = 4
        Me.txtNhanVien.TabStop = False
        Me.txtNhanVien.Tag = "NN"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(36, 538)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(160, 15)
        Me.Label6.TabIndex = 120
        Me.Label6.Text = "Phần (*) bắt buộc phải nhập"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtMaPXK)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.mskNgayXK)
        Me.GroupBox1.Location = New System.Drawing.Point(690, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(252, 119)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Chứng từ"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboKhachHang)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtNhanVien)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.cboMaKho)
        Me.GroupBox2.Controls.Add(Me.btnThemKho)
        Me.GroupBox2.Controls.Add(Me.btnThemKhachHang)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 45)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(662, 119)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Thông tin chung"
        '
        'frmPhieuXuatKho
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(964, 572)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnHuyBo)
        Me.Controls.Add(Me.btnLuu)
        Me.Controls.Add(Me.DataGridView)
        Me.Controls.Add(Me.Label7)
        Me.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPhieuXuatKho"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thêm mới phiếu xuất kho"
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnHuyBo As System.Windows.Forms.Button
    Friend WithEvents btnLuu As System.Windows.Forms.Button
    Friend WithEvents DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents btnThemKho As System.Windows.Forms.Button
    Friend WithEvents btnThemKhachHang As System.Windows.Forms.Button
    Friend WithEvents cboMaKho As System.Windows.Forms.ComboBox
    Friend WithEvents cboKhachHang As System.Windows.Forms.ComboBox
    Friend WithEvents mskNgayXK As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtMaPXK As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewComboBoxColumn1 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewComboBoxColumn2 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents txtNhanVien As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents colMaH As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents colDGXuat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSoLuong As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colChietKhau As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colThueVAT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colThanhTien As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colXoa As System.Windows.Forms.DataGridViewButtonColumn
End Class
