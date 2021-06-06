<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNhanVien
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNhanVien))
        Me.btnThoat = New System.Windows.Forms.Button
        Me.btnThemTinhTP = New System.Windows.Forms.Button
        Me.btnThemCV = New System.Windows.Forms.Button
        Me.btnThemBP = New System.Windows.Forms.Button
        Me.chkChua = New System.Windows.Forms.CheckBox
        Me.mskNgayThoiViec = New System.Windows.Forms.MaskedTextBox
        Me.mskNgayVaoCongTy = New System.Windows.Forms.MaskedTextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtNgoaiNgu = New System.Windows.Forms.TextBox
        Me.txtChuyenNganh = New System.Windows.Forms.TextBox
        Me.txtDanToc = New System.Windows.Forms.TextBox
        Me.txtTonGiao = New System.Windows.Forms.TextBox
        Me.txtTrinhDo = New System.Windows.Forms.TextBox
        Me.txtNoiCap = New System.Windows.Forms.TextBox
        Me.cboMaTinhTP = New System.Windows.Forms.ComboBox
        Me.cboMaCV = New System.Windows.Forms.ComboBox
        Me.cboMaBP = New System.Windows.Forms.ComboBox
        Me.chkNam = New System.Windows.Forms.CheckBox
        Me.mskNgaySinh = New System.Windows.Forms.MaskedTextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtCMND = New System.Windows.Forms.TextBox
        Me.txtDiaChi = New System.Windows.Forms.TextBox
        Me.txtHoTen = New System.Windows.Forms.TextBox
        Me.txtMaNV = New System.Windows.Forms.TextBox
        Me.picPhoto = New System.Windows.Forms.PictureBox
        Me.btnChonAnh = New System.Windows.Forms.Button
        Me.mskNgayCap = New System.Windows.Forms.MaskedTextBox
        Me.btnXoaAnh = New System.Windows.Forms.Button
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtDuongDan = New System.Windows.Forms.TextBox
        Me.mskDienThoai = New System.Windows.Forms.MaskedTextBox
        Me.btnCapNhat = New System.Windows.Forms.Button
        Me.Label21 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        CType(Me.picPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnThoat
        '
        Me.btnThoat.Image = CType(resources.GetObject("btnThoat.Image"), System.Drawing.Image)
        Me.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThoat.Location = New System.Drawing.Point(687, 397)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(75, 30)
        Me.btnThoat.TabIndex = 2
        Me.btnThoat.Text = " &Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'btnThemTinhTP
        '
        Me.btnThemTinhTP.Image = CType(resources.GetObject("btnThemTinhTP.Image"), System.Drawing.Image)
        Me.btnThemTinhTP.Location = New System.Drawing.Point(255, 231)
        Me.btnThemTinhTP.Name = "btnThemTinhTP"
        Me.btnThemTinhTP.Size = New System.Drawing.Size(32, 24)
        Me.btnThemTinhTP.TabIndex = 17
        Me.btnThemTinhTP.TabStop = False
        Me.btnThemTinhTP.UseVisualStyleBackColor = True
        '
        'btnThemCV
        '
        Me.btnThemCV.Image = CType(resources.GetObject("btnThemCV.Image"), System.Drawing.Image)
        Me.btnThemCV.Location = New System.Drawing.Point(255, 152)
        Me.btnThemCV.Name = "btnThemCV"
        Me.btnThemCV.Size = New System.Drawing.Size(32, 24)
        Me.btnThemCV.TabIndex = 12
        Me.btnThemCV.TabStop = False
        Me.btnThemCV.UseVisualStyleBackColor = True
        '
        'btnThemBP
        '
        Me.btnThemBP.Image = CType(resources.GetObject("btnThemBP.Image"), System.Drawing.Image)
        Me.btnThemBP.Location = New System.Drawing.Point(255, 124)
        Me.btnThemBP.Name = "btnThemBP"
        Me.btnThemBP.Size = New System.Drawing.Size(32, 24)
        Me.btnThemBP.TabIndex = 9
        Me.btnThemBP.TabStop = False
        Me.btnThemBP.UseVisualStyleBackColor = True
        '
        'chkChua
        '
        Me.chkChua.AutoSize = True
        Me.chkChua.Checked = True
        Me.chkChua.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkChua.Location = New System.Drawing.Point(420, 127)
        Me.chkChua.Name = "chkChua"
        Me.chkChua.Size = New System.Drawing.Size(57, 19)
        Me.chkChua.TabIndex = 10
        Me.chkChua.Text = "Chưa"
        Me.chkChua.UseVisualStyleBackColor = True
        '
        'mskNgayThoiViec
        '
        Me.mskNgayThoiViec.Location = New System.Drawing.Point(444, 100)
        Me.mskNgayThoiViec.Mask = "00/00/0000"
        Me.mskNgayThoiViec.Name = "mskNgayThoiViec"
        Me.mskNgayThoiViec.Size = New System.Drawing.Size(100, 21)
        Me.mskNgayThoiViec.TabIndex = 7
        Me.mskNgayThoiViec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.mskNgayThoiViec.ValidatingType = GetType(Date)
        '
        'mskNgayVaoCongTy
        '
        Me.mskNgayVaoCongTy.Location = New System.Drawing.Point(444, 75)
        Me.mskNgayVaoCongTy.Mask = "00/00/0000"
        Me.mskNgayVaoCongTy.Name = "mskNgayVaoCongTy"
        Me.mskNgayVaoCongTy.Size = New System.Drawing.Size(100, 21)
        Me.mskNgayVaoCongTy.TabIndex = 5
        Me.mskNgayVaoCongTy.Tag = "NN"
        Me.mskNgayVaoCongTy.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.mskNgayVaoCongTy.ValidatingType = GetType(Date)
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(306, 276)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(65, 15)
        Me.Label20.TabIndex = 79
        Me.Label20.Text = "Ngoại ngữ"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(306, 129)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(49, 15)
        Me.Label19.TabIndex = 78
        Me.Label19.Text = "Kết hôn"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(306, 248)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(87, 15)
        Me.Label18.TabIndex = 77
        Me.Label18.Text = "Chuyên ngành"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(306, 103)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(82, 15)
        Me.Label17.TabIndex = 80
        Me.Label17.Text = "Ngày thôi việc"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(306, 220)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(52, 15)
        Me.Label16.TabIndex = 83
        Me.Label16.Text = "Trình độ"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(306, 78)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(114, 15)
        Me.Label15.TabIndex = 82
        Me.Label15.Text = "Ngày vào công ty (*)"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(306, 189)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(55, 15)
        Me.Label14.TabIndex = 81
        Me.Label14.Text = "Tôn giáo"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(306, 51)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(66, 15)
        Me.Label13.TabIndex = 74
        Me.Label13.Text = "Nơi cấp (*)"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(306, 157)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 15)
        Me.Label12.TabIndex = 75
        Me.Label12.Text = "Dân tộc"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(306, 25)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 15)
        Me.Label11.TabIndex = 76
        Me.Label11.Text = "Ngày cấp (*)"
        '
        'txtNgoaiNgu
        '
        Me.txtNgoaiNgu.Location = New System.Drawing.Point(399, 273)
        Me.txtNgoaiNgu.MaxLength = 30
        Me.txtNgoaiNgu.Name = "txtNgoaiNgu"
        Me.txtNgoaiNgu.Size = New System.Drawing.Size(145, 21)
        Me.txtNgoaiNgu.TabIndex = 22
        '
        'txtChuyenNganh
        '
        Me.txtChuyenNganh.Location = New System.Drawing.Point(399, 245)
        Me.txtChuyenNganh.MaxLength = 50
        Me.txtChuyenNganh.Name = "txtChuyenNganh"
        Me.txtChuyenNganh.Size = New System.Drawing.Size(145, 21)
        Me.txtChuyenNganh.TabIndex = 20
        '
        'txtDanToc
        '
        Me.txtDanToc.Location = New System.Drawing.Point(399, 154)
        Me.txtDanToc.MaxLength = 30
        Me.txtDanToc.Name = "txtDanToc"
        Me.txtDanToc.Size = New System.Drawing.Size(145, 21)
        Me.txtDanToc.TabIndex = 13
        '
        'txtTonGiao
        '
        Me.txtTonGiao.Location = New System.Drawing.Point(399, 186)
        Me.txtTonGiao.MaxLength = 30
        Me.txtTonGiao.Name = "txtTonGiao"
        Me.txtTonGiao.Size = New System.Drawing.Size(145, 21)
        Me.txtTonGiao.TabIndex = 15
        '
        'txtTrinhDo
        '
        Me.txtTrinhDo.Location = New System.Drawing.Point(399, 217)
        Me.txtTrinhDo.MaxLength = 30
        Me.txtTrinhDo.Name = "txtTrinhDo"
        Me.txtTrinhDo.Size = New System.Drawing.Size(145, 21)
        Me.txtTrinhDo.TabIndex = 18
        '
        'txtNoiCap
        '
        Me.txtNoiCap.Location = New System.Drawing.Point(413, 48)
        Me.txtNoiCap.MaxLength = 50
        Me.txtNoiCap.Name = "txtNoiCap"
        Me.txtNoiCap.Size = New System.Drawing.Size(131, 21)
        Me.txtNoiCap.TabIndex = 3
        Me.txtNoiCap.Tag = "NN"
        '
        'cboMaTinhTP
        '
        Me.cboMaTinhTP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMaTinhTP.FormattingEnabled = True
        Me.cboMaTinhTP.Location = New System.Drawing.Point(102, 232)
        Me.cboMaTinhTP.Name = "cboMaTinhTP"
        Me.cboMaTinhTP.Size = New System.Drawing.Size(137, 23)
        Me.cboMaTinhTP.TabIndex = 16
        Me.cboMaTinhTP.Tag = "NN"
        '
        'cboMaCV
        '
        Me.cboMaCV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMaCV.FormattingEnabled = True
        Me.cboMaCV.Location = New System.Drawing.Point(102, 153)
        Me.cboMaCV.Name = "cboMaCV"
        Me.cboMaCV.Size = New System.Drawing.Size(137, 23)
        Me.cboMaCV.TabIndex = 11
        Me.cboMaCV.Tag = "NN"
        '
        'cboMaBP
        '
        Me.cboMaBP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMaBP.FormattingEnabled = True
        Me.cboMaBP.Location = New System.Drawing.Point(102, 125)
        Me.cboMaBP.Name = "cboMaBP"
        Me.cboMaBP.Size = New System.Drawing.Size(137, 23)
        Me.cboMaBP.TabIndex = 8
        Me.cboMaBP.Tag = "NN"
        '
        'chkNam
        '
        Me.chkNam.AutoSize = True
        Me.chkNam.Checked = True
        Me.chkNam.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkNam.Location = New System.Drawing.Point(102, 76)
        Me.chkNam.Name = "chkNam"
        Me.chkNam.Size = New System.Drawing.Size(53, 19)
        Me.chkNam.TabIndex = 4
        Me.chkNam.Text = "Nam"
        Me.chkNam.UseVisualStyleBackColor = True
        '
        'mskNgaySinh
        '
        Me.mskNgaySinh.Location = New System.Drawing.Point(102, 100)
        Me.mskNgaySinh.Mask = "00/00/0000"
        Me.mskNgaySinh.Name = "mskNgaySinh"
        Me.mskNgaySinh.Size = New System.Drawing.Size(185, 21)
        Me.mskNgaySinh.TabIndex = 6
        Me.mskNgaySinh.Tag = "NN"
        Me.mskNgaySinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.mskNgaySinh.ValidatingType = GetType(Date)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(10, 290)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 15)
        Me.Label10.TabIndex = 58
        Me.Label10.Text = "CMND (*)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 15)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "Bộ phận (*)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 263)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 15)
        Me.Label9.TabIndex = 59
        Me.Label9.Text = "Điện thoại"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 15)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "Ngày sinh (*)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 236)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 15)
        Me.Label8.TabIndex = 60
        Me.Label8.Text = "Tỉnh TP (*)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 15)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Giới tính"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 196)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 15)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "Địa chỉ (*)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 15)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Họ tên (*)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 157)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 15)
        Me.Label6.TabIndex = 56
        Me.Label6.Text = "Chức vụ (*)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 15)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Mã NV (*)"
        '
        'txtCMND
        '
        Me.txtCMND.Location = New System.Drawing.Point(102, 287)
        Me.txtCMND.MaxLength = 10
        Me.txtCMND.Name = "txtCMND"
        Me.txtCMND.Size = New System.Drawing.Size(185, 21)
        Me.txtCMND.TabIndex = 21
        Me.txtCMND.Tag = "NN"
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Location = New System.Drawing.Point(102, 182)
        Me.txtDiaChi.MaxLength = 50
        Me.txtDiaChi.Multiline = True
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(185, 44)
        Me.txtDiaChi.TabIndex = 14
        Me.txtDiaChi.Tag = "NN"
        '
        'txtHoTen
        '
        Me.txtHoTen.Location = New System.Drawing.Point(102, 48)
        Me.txtHoTen.MaxLength = 30
        Me.txtHoTen.Name = "txtHoTen"
        Me.txtHoTen.Size = New System.Drawing.Size(185, 21)
        Me.txtHoTen.TabIndex = 2
        Me.txtHoTen.Tag = "NN"
        '
        'txtMaNV
        '
        Me.txtMaNV.Location = New System.Drawing.Point(102, 22)
        Me.txtMaNV.MaxLength = 10
        Me.txtMaNV.Name = "txtMaNV"
        Me.txtMaNV.Size = New System.Drawing.Size(185, 21)
        Me.txtMaNV.TabIndex = 0
        Me.txtMaNV.Tag = "NN"
        '
        'picPhoto
        '
        Me.picPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPhoto.Location = New System.Drawing.Point(566, 24)
        Me.picPhoto.Name = "picPhoto"
        Me.picPhoto.Size = New System.Drawing.Size(168, 168)
        Me.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picPhoto.TabIndex = 91
        Me.picPhoto.TabStop = False
        '
        'btnChonAnh
        '
        Me.btnChonAnh.Location = New System.Drawing.Point(566, 210)
        Me.btnChonAnh.Name = "btnChonAnh"
        Me.btnChonAnh.Size = New System.Drawing.Size(92, 30)
        Me.btnChonAnh.TabIndex = 23
        Me.btnChonAnh.Text = "&Chọn ảnh"
        Me.btnChonAnh.UseVisualStyleBackColor = True
        '
        'mskNgayCap
        '
        Me.mskNgayCap.Location = New System.Drawing.Point(413, 22)
        Me.mskNgayCap.Mask = "00/00/0000"
        Me.mskNgayCap.Name = "mskNgayCap"
        Me.mskNgayCap.Size = New System.Drawing.Size(131, 21)
        Me.mskNgayCap.TabIndex = 1
        Me.mskNgayCap.Tag = "NN"
        Me.mskNgayCap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.mskNgayCap.ValidatingType = GetType(Date)
        '
        'btnXoaAnh
        '
        Me.btnXoaAnh.Location = New System.Drawing.Point(664, 210)
        Me.btnXoaAnh.Name = "btnXoaAnh"
        Me.btnXoaAnh.Size = New System.Drawing.Size(70, 30)
        Me.btnXoaAnh.TabIndex = 24
        Me.btnXoaAnh.TabStop = False
        Me.btnXoaAnh.Text = "&Xóa ảnh"
        Me.btnXoaAnh.UseVisualStyleBackColor = True
        '
        'ErrorProvider
        '
        Me.ErrorProvider.BlinkRate = 0
        Me.ErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider.ContainerControl = Me
        '
        'txtDuongDan
        '
        Me.txtDuongDan.Location = New System.Drawing.Point(566, 255)
        Me.txtDuongDan.Name = "txtDuongDan"
        Me.txtDuongDan.Size = New System.Drawing.Size(180, 21)
        Me.txtDuongDan.TabIndex = 25
        Me.txtDuongDan.TabStop = False
        Me.txtDuongDan.Visible = False
        '
        'mskDienThoai
        '
        Me.mskDienThoai.Location = New System.Drawing.Point(102, 260)
        Me.mskDienThoai.Mask = "(9999) 000-0000"
        Me.mskDienThoai.Name = "mskDienThoai"
        Me.mskDienThoai.Size = New System.Drawing.Size(185, 21)
        Me.mskDienThoai.TabIndex = 19
        Me.mskDienThoai.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Image = CType(resources.GetObject("btnCapNhat.Image"), System.Drawing.Image)
        Me.btnCapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCapNhat.Location = New System.Drawing.Point(593, 397)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(75, 30)
        Me.btnCapNhat.TabIndex = 1
        Me.btnCapNhat.Text = "&Ghi"
        Me.btnCapNhat.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(10, 10)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(111, 24)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "Nhân viên"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtMaNV)
        Me.GroupBox1.Controls.Add(Me.picPhoto)
        Me.GroupBox1.Controls.Add(Me.btnXoaAnh)
        Me.GroupBox1.Controls.Add(Me.mskDienThoai)
        Me.GroupBox1.Controls.Add(Me.btnChonAnh)
        Me.GroupBox1.Controls.Add(Me.txtHoTen)
        Me.GroupBox1.Controls.Add(Me.txtDuongDan)
        Me.GroupBox1.Controls.Add(Me.txtDiaChi)
        Me.GroupBox1.Controls.Add(Me.txtCMND)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.btnThemTinhTP)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnThemCV)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.btnThemBP)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.chkChua)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.mskNgayThoiViec)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.mskNgayCap)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.mskNgayVaoCongTy)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.mskNgaySinh)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.chkNam)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.cboMaBP)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.cboMaCV)
        Me.GroupBox1.Controls.Add(Me.cboMaTinhTP)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtNoiCap)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtTrinhDo)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtTonGiao)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtDanToc)
        Me.GroupBox1.Controls.Add(Me.txtNgoaiNgu)
        Me.GroupBox1.Controls.Add(Me.txtChuyenNganh)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(10, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(752, 328)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin chung"
        '
        'frmNhanVien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(785, 439)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnCapNhat)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNhanVien"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nhân viên"
        CType(Me.picPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnThoat As System.Windows.Forms.Button
    Friend WithEvents btnThemTinhTP As System.Windows.Forms.Button
    Friend WithEvents btnThemCV As System.Windows.Forms.Button
    Friend WithEvents btnThemBP As System.Windows.Forms.Button
    Friend WithEvents chkChua As System.Windows.Forms.CheckBox
    Friend WithEvents mskNgayThoiViec As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskNgayVaoCongTy As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtNgoaiNgu As System.Windows.Forms.TextBox
    Friend WithEvents txtChuyenNganh As System.Windows.Forms.TextBox
    Friend WithEvents txtDanToc As System.Windows.Forms.TextBox
    Friend WithEvents txtTonGiao As System.Windows.Forms.TextBox
    Friend WithEvents txtTrinhDo As System.Windows.Forms.TextBox
    Friend WithEvents txtNoiCap As System.Windows.Forms.TextBox
    Friend WithEvents cboMaTinhTP As System.Windows.Forms.ComboBox
    Friend WithEvents cboMaCV As System.Windows.Forms.ComboBox
    Friend WithEvents cboMaBP As System.Windows.Forms.ComboBox
    Friend WithEvents chkNam As System.Windows.Forms.CheckBox
    Friend WithEvents mskNgaySinh As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCMND As System.Windows.Forms.TextBox
    Friend WithEvents txtDiaChi As System.Windows.Forms.TextBox
    Friend WithEvents txtHoTen As System.Windows.Forms.TextBox
    Friend WithEvents txtMaNV As System.Windows.Forms.TextBox
    Friend WithEvents picPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents btnChonAnh As System.Windows.Forms.Button
    Friend WithEvents mskNgayCap As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnXoaAnh As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtDuongDan As System.Windows.Forms.TextBox
    Friend WithEvents mskDienThoai As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnCapNhat As System.Windows.Forms.Button
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
