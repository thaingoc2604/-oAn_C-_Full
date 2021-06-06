<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSuaHoaDonMuaHang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSuaHoaDonMuaHang))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label6 = New System.Windows.Forms.Label
        Me.btnLuu = New System.Windows.Forms.Button
        Me.DataGridView = New System.Windows.Forms.DataGridView
        Me.colMaH = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.colDGNhap = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSoLuong = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colChietKhau = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colThue = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colThanhTien = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colXoa = New System.Windows.Forms.DataGridViewButtonColumn
        Me.colIDR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnHuyBo = New System.Windows.Forms.Button
        Me.btnThemNhaCC = New System.Windows.Forms.Button
        Me.cboNhaCC = New System.Windows.Forms.ComboBox
        Me.mskHanThanhToan = New System.Windows.Forms.MaskedTextBox
        Me.mskNgayGiaoHang = New System.Windows.Forms.MaskedTextBox
        Me.mskNgayHD = New System.Windows.Forms.MaskedTextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtPhiVanChuyen = New System.Windows.Forms.TextBox
        Me.txtNhanVien = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtMaHD = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.DataGridViewComboBoxColumn1 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.DataGridViewComboBoxColumn2 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 537)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(169, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Phần (*) bắt buộc phải nhập"
        '
        'btnLuu
        '
        Me.btnLuu.Image = CType(resources.GetObject("btnLuu.Image"), System.Drawing.Image)
        Me.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLuu.Location = New System.Drawing.Point(760, 530)
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
        Me.DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colMaH, Me.colDGNhap, Me.colSoLuong, Me.colChietKhau, Me.colThue, Me.colThanhTien, Me.colXoa, Me.colIDR})
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
        Me.DataGridView.Size = New System.Drawing.Size(935, 332)
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
        'colChietKhau
        '
        Me.colChietKhau.HeaderText = "Chiết khấu"
        Me.colChietKhau.Name = "colChietKhau"
        '
        'colThue
        '
        Me.colThue.HeaderText = "Thuế"
        Me.colThue.Name = "colThue"
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
        'colIDR
        '
        Me.colIDR.HeaderText = "IDR"
        Me.colIDR.Name = "colIDR"
        Me.colIDR.Visible = False
        '
        'btnHuyBo
        '
        Me.btnHuyBo.Image = CType(resources.GetObject("btnHuyBo.Image"), System.Drawing.Image)
        Me.btnHuyBo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHuyBo.Location = New System.Drawing.Point(870, 530)
        Me.btnHuyBo.Name = "btnHuyBo"
        Me.btnHuyBo.Size = New System.Drawing.Size(75, 30)
        Me.btnHuyBo.TabIndex = 4
        Me.btnHuyBo.Text = "    &Thoát"
        Me.btnHuyBo.UseVisualStyleBackColor = True
        '
        'btnThemNhaCC
        '
        Me.btnThemNhaCC.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThemNhaCC.Image = CType(resources.GetObject("btnThemNhaCC.Image"), System.Drawing.Image)
        Me.btnThemNhaCC.Location = New System.Drawing.Point(605, 21)
        Me.btnThemNhaCC.Name = "btnThemNhaCC"
        Me.btnThemNhaCC.Size = New System.Drawing.Size(32, 24)
        Me.btnThemNhaCC.TabIndex = 1
        Me.btnThemNhaCC.TabStop = False
        Me.btnThemNhaCC.UseVisualStyleBackColor = True
        '
        'cboNhaCC
        '
        Me.cboNhaCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNhaCC.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNhaCC.FormattingEnabled = True
        Me.cboNhaCC.Location = New System.Drawing.Point(127, 21)
        Me.cboNhaCC.Name = "cboNhaCC"
        Me.cboNhaCC.Size = New System.Drawing.Size(455, 24)
        Me.cboNhaCC.TabIndex = 0
        Me.cboNhaCC.Tag = "NN"
        '
        'mskHanThanhToan
        '
        Me.mskHanThanhToan.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskHanThanhToan.Location = New System.Drawing.Point(116, 77)
        Me.mskHanThanhToan.Mask = "00/00/0000"
        Me.mskHanThanhToan.Name = "mskHanThanhToan"
        Me.mskHanThanhToan.Size = New System.Drawing.Size(114, 22)
        Me.mskHanThanhToan.TabIndex = 2
        Me.mskHanThanhToan.Tag = "NN"
        Me.mskHanThanhToan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.mskHanThanhToan.ValidatingType = GetType(Date)
        '
        'mskNgayGiaoHang
        '
        Me.mskNgayGiaoHang.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskNgayGiaoHang.Location = New System.Drawing.Point(127, 51)
        Me.mskNgayGiaoHang.Mask = "00/00/0000"
        Me.mskNgayGiaoHang.Name = "mskNgayGiaoHang"
        Me.mskNgayGiaoHang.Size = New System.Drawing.Size(120, 22)
        Me.mskNgayGiaoHang.TabIndex = 2
        Me.mskNgayGiaoHang.Tag = "NN"
        Me.mskNgayGiaoHang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.mskNgayGiaoHang.ValidatingType = GetType(Date)
        '
        'mskNgayHD
        '
        Me.mskNgayHD.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskNgayHD.Location = New System.Drawing.Point(116, 49)
        Me.mskNgayHD.Mask = "00/00/0000"
        Me.mskNgayHD.Name = "mskNgayHD"
        Me.mskNgayHD.Size = New System.Drawing.Size(114, 22)
        Me.mskNgayHD.TabIndex = 1
        Me.mskNgayHD.Tag = "NN"
        Me.mskNgayHD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.mskNgayHD.ValidatingType = GetType(Date)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(10, 77)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 16)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "Hạn thanh toán(*)"
        '
        'txtPhiVanChuyen
        '
        Me.txtPhiVanChuyen.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhiVanChuyen.Location = New System.Drawing.Point(367, 51)
        Me.txtPhiVanChuyen.MaxLength = 10
        Me.txtPhiVanChuyen.Name = "txtPhiVanChuyen"
        Me.txtPhiVanChuyen.Size = New System.Drawing.Size(270, 22)
        Me.txtPhiVanChuyen.TabIndex = 3
        Me.txtPhiVanChuyen.TabStop = False
        Me.txtPhiVanChuyen.Tag = ""
        Me.txtPhiVanChuyen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNhanVien
        '
        Me.txtNhanVien.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNhanVien.Location = New System.Drawing.Point(129, 79)
        Me.txtNhanVien.MaxLength = 10
        Me.txtNhanVien.Name = "txtNhanVien"
        Me.txtNhanVien.ReadOnly = True
        Me.txtNhanVien.Size = New System.Drawing.Size(508, 22)
        Me.txtNhanVien.TabIndex = 4
        Me.txtNhanVien.TabStop = False
        Me.txtNhanVien.Tag = "NN"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(265, 54)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 16)
        Me.Label9.TabIndex = 55
        Me.Label9.Text = "Phí vận chuyển"
        '
        'ErrorProvider
        '
        Me.ErrorProvider.BlinkRate = 0
        Me.ErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider.ContainerControl = Me
        '
        'txtMaHD
        '
        Me.txtMaHD.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaHD.Location = New System.Drawing.Point(116, 22)
        Me.txtMaHD.MaxLength = 10
        Me.txtMaHD.Name = "txtMaHD"
        Me.txtMaHD.Size = New System.Drawing.Size(114, 22)
        Me.txtMaHD.TabIndex = 0
        Me.txtMaHD.Tag = "NN"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 16)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Nhân viên (*)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 16)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Ngày hóa đơn(*)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 16)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Ngày giao hàng (*)"
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 16)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Mã hóa đơn (*)"
        '
        'DataGridViewComboBoxColumn2
        '
        Me.DataGridViewComboBoxColumn2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.DataGridViewComboBoxColumn2.Frozen = True
        Me.DataGridViewComboBoxColumn2.HeaderText = "Kho"
        Me.DataGridViewComboBoxColumn2.Name = "DataGridViewComboBoxColumn2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 16)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Nhà cung cấp (*)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(10, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(203, 24)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "Hóa đơn mua hàng"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtMaHD)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.mskNgayHD)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.mskHanThanhToan)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(693, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(252, 119)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Chứng từ"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboNhaCC)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtNhanVien)
        Me.GroupBox2.Controls.Add(Me.btnThemNhaCC)
        Me.GroupBox2.Controls.Add(Me.txtPhiVanChuyen)
        Me.GroupBox2.Controls.Add(Me.mskNgayGiaoHang)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 45)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(660, 119)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Thông tin chung"
        '
        'frmSuaHoaDonMuaHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(964, 572)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnLuu)
        Me.Controls.Add(Me.DataGridView)
        Me.Controls.Add(Me.btnHuyBo)
        Me.Controls.Add(Me.Label7)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSuaHoaDonMuaHang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sửa hóa đơn mua hàng"
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnLuu As System.Windows.Forms.Button
    Friend WithEvents DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents btnHuyBo As System.Windows.Forms.Button
    Friend WithEvents btnThemNhaCC As System.Windows.Forms.Button
    Friend WithEvents cboNhaCC As System.Windows.Forms.ComboBox
    Friend WithEvents mskHanThanhToan As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskNgayGiaoHang As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskNgayHD As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtPhiVanChuyen As System.Windows.Forms.TextBox
    Friend WithEvents txtNhanVien As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtMaHD As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewComboBoxColumn1 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewComboBoxColumn2 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents colMaH As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents colDGNhap As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSoLuong As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colChietKhau As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colThue As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colThanhTien As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colXoa As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colIDR As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
