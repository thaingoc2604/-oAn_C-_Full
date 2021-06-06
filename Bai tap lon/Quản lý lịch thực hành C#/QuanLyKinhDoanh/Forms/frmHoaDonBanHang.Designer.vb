<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHoaDonBanHang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHoaDonBanHang))
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
        Me.colDonGia = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSoLuong = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colChietKhau = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colThue = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colThanhTien = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colXoa = New System.Windows.Forms.DataGridViewButtonColumn
        Me.btnHuyBo = New System.Windows.Forms.Button
        Me.btnThemKhachHang = New System.Windows.Forms.Button
        Me.cboKhachHang = New System.Windows.Forms.ComboBox
        Me.mskHanThanhToan = New System.Windows.Forms.MaskedTextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.DataGridViewComboBoxColumn2 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.DataGridViewComboBoxColumn1 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.mskNgayGiaoHang = New System.Windows.Forms.MaskedTextBox
        Me.mskNgayHD = New System.Windows.Forms.MaskedTextBox
        Me.txtPhiVanChuyen = New System.Windows.Forms.TextBox
        Me.txtNhanVien = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtMaHD = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
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
        Me.Label6.Location = New System.Drawing.Point(32, 525)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(169, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Phần (*) bắt buộc phải nhập"
        '
        'btnLuu
        '
        Me.btnLuu.Image = CType(resources.GetObject("btnLuu.Image"), System.Drawing.Image)
        Me.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLuu.Location = New System.Drawing.Point(761, 518)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Size = New System.Drawing.Size(75, 30)
        Me.btnLuu.TabIndex = 4
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
        Me.DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colMaH, Me.colDonGia, Me.colSoLuong, Me.colChietKhau, Me.colThue, Me.colThanhTien, Me.colXoa})
        Me.DataGridView.Location = New System.Drawing.Point(10, 182)
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
        Me.DataGridView.Size = New System.Drawing.Size(923, 317)
        Me.DataGridView.TabIndex = 3
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
        'colDonGia
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.colDonGia.DefaultCellStyle = DataGridViewCellStyle2
        Me.colDonGia.HeaderText = "Đơn giá"
        Me.colDonGia.MaxInputLength = 19
        Me.colDonGia.Name = "colDonGia"
        Me.colDonGia.ReadOnly = True
        Me.colDonGia.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colDonGia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
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
        Me.colThue.ReadOnly = True
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
        'btnHuyBo
        '
        Me.btnHuyBo.Image = CType(resources.GetObject("btnHuyBo.Image"), System.Drawing.Image)
        Me.btnHuyBo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHuyBo.Location = New System.Drawing.Point(858, 518)
        Me.btnHuyBo.Name = "btnHuyBo"
        Me.btnHuyBo.Size = New System.Drawing.Size(75, 30)
        Me.btnHuyBo.TabIndex = 5
        Me.btnHuyBo.Text = "    &Thoát"
        Me.btnHuyBo.UseVisualStyleBackColor = True
        '
        'btnThemKhachHang
        '
        Me.btnThemKhachHang.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThemKhachHang.Image = CType(resources.GetObject("btnThemKhachHang.Image"), System.Drawing.Image)
        Me.btnThemKhachHang.Location = New System.Drawing.Point(607, 20)
        Me.btnThemKhachHang.Name = "btnThemKhachHang"
        Me.btnThemKhachHang.Size = New System.Drawing.Size(32, 24)
        Me.btnThemKhachHang.TabIndex = 1
        Me.btnThemKhachHang.TabStop = False
        Me.btnThemKhachHang.UseVisualStyleBackColor = True
        '
        'cboKhachHang
        '
        Me.cboKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKhachHang.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboKhachHang.FormattingEnabled = True
        Me.cboKhachHang.Location = New System.Drawing.Point(129, 21)
        Me.cboKhachHang.Name = "cboKhachHang"
        Me.cboKhachHang.Size = New System.Drawing.Size(451, 24)
        Me.cboKhachHang.TabIndex = 0
        Me.cboKhachHang.Tag = "NN"
        '
        'mskHanThanhToan
        '
        Me.mskHanThanhToan.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskHanThanhToan.Location = New System.Drawing.Point(129, 78)
        Me.mskHanThanhToan.Mask = "00/00/0000"
        Me.mskHanThanhToan.Name = "mskHanThanhToan"
        Me.mskHanThanhToan.Size = New System.Drawing.Size(94, 21)
        Me.mskHanThanhToan.TabIndex = 2
        Me.mskHanThanhToan.Tag = "NN"
        Me.mskHanThanhToan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.mskHanThanhToan.ValidatingType = GetType(Date)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(14, 78)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 15)
        Me.Label8.TabIndex = 82
        Me.Label8.Text = "Hạn thanh toán(*)"
        '
        'DataGridViewComboBoxColumn2
        '
        Me.DataGridViewComboBoxColumn2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.DataGridViewComboBoxColumn2.Frozen = True
        Me.DataGridViewComboBoxColumn2.HeaderText = "Kho"
        Me.DataGridViewComboBoxColumn2.Name = "DataGridViewComboBoxColumn2"
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
        'ErrorProvider
        '
        Me.ErrorProvider.BlinkRate = 0
        Me.ErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider.ContainerControl = Me
        '
        'mskNgayGiaoHang
        '
        Me.mskNgayGiaoHang.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskNgayGiaoHang.Location = New System.Drawing.Point(129, 51)
        Me.mskNgayGiaoHang.Mask = "00/00/0000"
        Me.mskNgayGiaoHang.Name = "mskNgayGiaoHang"
        Me.mskNgayGiaoHang.Size = New System.Drawing.Size(188, 22)
        Me.mskNgayGiaoHang.TabIndex = 2
        Me.mskNgayGiaoHang.Tag = "NN"
        Me.mskNgayGiaoHang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.mskNgayGiaoHang.ValidatingType = GetType(Date)
        '
        'mskNgayHD
        '
        Me.mskNgayHD.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskNgayHD.Location = New System.Drawing.Point(129, 48)
        Me.mskNgayHD.Mask = "00/00/0000"
        Me.mskNgayHD.Name = "mskNgayHD"
        Me.mskNgayHD.Size = New System.Drawing.Size(94, 21)
        Me.mskNgayHD.TabIndex = 1
        Me.mskNgayHD.Tag = "NN"
        Me.mskNgayHD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.mskNgayHD.ValidatingType = GetType(Date)
        '
        'txtPhiVanChuyen
        '
        Me.txtPhiVanChuyen.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhiVanChuyen.Location = New System.Drawing.Point(430, 51)
        Me.txtPhiVanChuyen.MaxLength = 10
        Me.txtPhiVanChuyen.Name = "txtPhiVanChuyen"
        Me.txtPhiVanChuyen.Size = New System.Drawing.Size(209, 22)
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
        Me.txtNhanVien.Size = New System.Drawing.Size(510, 22)
        Me.txtNhanVien.TabIndex = 4
        Me.txtNhanVien.TabStop = False
        Me.txtNhanVien.Tag = "NN"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(329, 54)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 16)
        Me.Label9.TabIndex = 81
        Me.Label9.Text = "Phí vận chuyển"
        '
        'txtMaHD
        '
        Me.txtMaHD.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaHD.Location = New System.Drawing.Point(129, 21)
        Me.txtMaHD.MaxLength = 10
        Me.txtMaHD.Name = "txtMaHD"
        Me.txtMaHD.Size = New System.Drawing.Size(94, 21)
        Me.txtMaHD.TabIndex = 0
        Me.txtMaHD.Tag = "NN"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 16)
        Me.Label4.TabIndex = 80
        Me.Label4.Text = "Nhân viên (*)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 15)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "Ngày hóa đơn(*)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 16)
        Me.Label5.TabIndex = 88
        Me.Label5.Text = "Ngày giao hàng (*)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 15)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "Mã hóa đơn (*)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 16)
        Me.Label3.TabIndex = 89
        Me.Label3.Text = "Khách hàng (*)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(10, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(197, 24)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Hóa đơn bán hàng"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtMaHD)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.mskNgayHD)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.mskHanThanhToan)
        Me.GroupBox1.Location = New System.Drawing.Point(690, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(252, 119)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Chứng từ"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboKhachHang)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.btnThemKhachHang)
        Me.GroupBox2.Controls.Add(Me.mskNgayGiaoHang)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtPhiVanChuyen)
        Me.GroupBox2.Controls.Add(Me.txtNhanVien)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(10, 45)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(662, 119)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Thông tin chung"
        '
        'frmHoaDonBanHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(954, 562)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnLuu)
        Me.Controls.Add(Me.DataGridView)
        Me.Controls.Add(Me.btnHuyBo)
        Me.Controls.Add(Me.Label7)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmHoaDonBanHang"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lập hóa đơn"
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
    Friend WithEvents btnThemKhachHang As System.Windows.Forms.Button
    Friend WithEvents cboKhachHang As System.Windows.Forms.ComboBox
    Friend WithEvents mskHanThanhToan As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewComboBoxColumn2 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewComboBoxColumn1 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents mskNgayGiaoHang As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskNgayHD As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtPhiVanChuyen As System.Windows.Forms.TextBox
    Friend WithEvents txtNhanVien As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtMaHD As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents colMaH As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents colDonGia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSoLuong As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colChietKhau As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colThue As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colThanhTien As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colXoa As System.Windows.Forms.DataGridViewButtonColumn
End Class
