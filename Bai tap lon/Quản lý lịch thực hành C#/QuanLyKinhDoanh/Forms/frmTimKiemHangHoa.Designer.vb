<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTimKiemHangHoa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTimKiemHangHoa))
        Me.grbTimKiemTheo = New System.Windows.Forms.GroupBox
        Me.cboGiaTriTimKiem = New System.Windows.Forms.ComboBox
        Me.rdoXuatSu = New System.Windows.Forms.RadioButton
        Me.rdoNhomHang = New System.Windows.Forms.RadioButton
        Me.rdoTenH = New System.Windows.Forms.RadioButton
        Me.rdoMaH = New System.Windows.Forms.RadioButton
        Me.btnTimKiem = New System.Windows.Forms.Button
        Me.btnHuyBo = New System.Windows.Forms.Button
        Me.grbTimKiemTheo.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbTimKiemTheo
        '
        Me.grbTimKiemTheo.Controls.Add(Me.cboGiaTriTimKiem)
        Me.grbTimKiemTheo.Controls.Add(Me.rdoXuatSu)
        Me.grbTimKiemTheo.Controls.Add(Me.rdoNhomHang)
        Me.grbTimKiemTheo.Controls.Add(Me.rdoTenH)
        Me.grbTimKiemTheo.Controls.Add(Me.rdoMaH)
        Me.grbTimKiemTheo.Location = New System.Drawing.Point(10, 11)
        Me.grbTimKiemTheo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grbTimKiemTheo.Name = "grbTimKiemTheo"
        Me.grbTimKiemTheo.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grbTimKiemTheo.Size = New System.Drawing.Size(336, 95)
        Me.grbTimKiemTheo.TabIndex = 5
        Me.grbTimKiemTheo.TabStop = False
        Me.grbTimKiemTheo.Text = "Theo"
        '
        'cboGiaTriTimKiem
        '
        Me.cboGiaTriTimKiem.FormattingEnabled = True
        Me.cboGiaTriTimKiem.Location = New System.Drawing.Point(15, 51)
        Me.cboGiaTriTimKiem.Name = "cboGiaTriTimKiem"
        Me.cboGiaTriTimKiem.Size = New System.Drawing.Size(296, 24)
        Me.cboGiaTriTimKiem.TabIndex = 1
        '
        'rdoXuatSu
        '
        Me.rdoXuatSu.AutoSize = True
        Me.rdoXuatSu.Location = New System.Drawing.Point(260, 22)
        Me.rdoXuatSu.Name = "rdoXuatSu"
        Me.rdoXuatSu.Size = New System.Drawing.Size(71, 20)
        Me.rdoXuatSu.TabIndex = 3
        Me.rdoXuatSu.Text = "Xuất sứ"
        Me.rdoXuatSu.UseVisualStyleBackColor = True
        '
        'rdoNhomHang
        '
        Me.rdoNhomHang.AutoSize = True
        Me.rdoNhomHang.Location = New System.Drawing.Point(169, 22)
        Me.rdoNhomHang.Name = "rdoNhomHang"
        Me.rdoNhomHang.Size = New System.Drawing.Size(92, 20)
        Me.rdoNhomHang.TabIndex = 2
        Me.rdoNhomHang.Text = "Nhóm hàng"
        Me.rdoNhomHang.UseVisualStyleBackColor = True
        '
        'rdoTenH
        '
        Me.rdoTenH.AutoSize = True
        Me.rdoTenH.Location = New System.Drawing.Point(93, 22)
        Me.rdoTenH.Name = "rdoTenH"
        Me.rdoTenH.Size = New System.Drawing.Size(79, 20)
        Me.rdoTenH.TabIndex = 1
        Me.rdoTenH.Text = "Tên hàng"
        Me.rdoTenH.UseVisualStyleBackColor = True
        '
        'rdoMaH
        '
        Me.rdoMaH.AutoSize = True
        Me.rdoMaH.Checked = True
        Me.rdoMaH.Location = New System.Drawing.Point(15, 22)
        Me.rdoMaH.Name = "rdoMaH"
        Me.rdoMaH.Size = New System.Drawing.Size(76, 20)
        Me.rdoMaH.TabIndex = 0
        Me.rdoMaH.TabStop = True
        Me.rdoMaH.Text = "Mã hàng"
        Me.rdoMaH.UseVisualStyleBackColor = True
        '
        'btnTimKiem
        '
        Me.btnTimKiem.Location = New System.Drawing.Point(352, 22)
        Me.btnTimKiem.Name = "btnTimKiem"
        Me.btnTimKiem.Size = New System.Drawing.Size(90, 29)
        Me.btnTimKiem.TabIndex = 6
        Me.btnTimKiem.Text = "&Tìm kiếm"
        Me.btnTimKiem.UseVisualStyleBackColor = True
        '
        'btnHuyBo
        '
        Me.btnHuyBo.Location = New System.Drawing.Point(352, 69)
        Me.btnHuyBo.Name = "btnHuyBo"
        Me.btnHuyBo.Size = New System.Drawing.Size(90, 29)
        Me.btnHuyBo.TabIndex = 7
        Me.btnHuyBo.Text = "&Hủy bỏ"
        Me.btnHuyBo.UseVisualStyleBackColor = True
        '
        'frmTimKiemHangHoa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 112)
        Me.Controls.Add(Me.grbTimKiemTheo)
        Me.Controls.Add(Me.btnTimKiem)
        Me.Controls.Add(Me.btnHuyBo)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTimKiemHangHoa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tìm kiếm hàng hóa"
        Me.grbTimKiemTheo.ResumeLayout(False)
        Me.grbTimKiemTheo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grbTimKiemTheo As System.Windows.Forms.GroupBox
    Friend WithEvents cboGiaTriTimKiem As System.Windows.Forms.ComboBox
    Friend WithEvents rdoXuatSu As System.Windows.Forms.RadioButton
    Friend WithEvents rdoNhomHang As System.Windows.Forms.RadioButton
    Friend WithEvents rdoTenH As System.Windows.Forms.RadioButton
    Friend WithEvents rdoMaH As System.Windows.Forms.RadioButton
    Friend WithEvents btnTimKiem As System.Windows.Forms.Button
    Friend WithEvents btnHuyBo As System.Windows.Forms.Button
End Class
