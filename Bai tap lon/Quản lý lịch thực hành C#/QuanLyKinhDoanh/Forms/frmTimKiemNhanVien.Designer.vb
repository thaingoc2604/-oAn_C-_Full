<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTimKiemNhanVien
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTimKiemNhanVien))
        Me.grbTimKiemTheo = New System.Windows.Forms.GroupBox
        Me.cboGiaTriTimKiem = New System.Windows.Forms.ComboBox
        Me.rdoChucVu = New System.Windows.Forms.RadioButton
        Me.rdoBoPhan = New System.Windows.Forms.RadioButton
        Me.rdoHoTen = New System.Windows.Forms.RadioButton
        Me.rdoMaNV = New System.Windows.Forms.RadioButton
        Me.btnTimKiem = New System.Windows.Forms.Button
        Me.btnHuyBo = New System.Windows.Forms.Button
        Me.grbTimKiemTheo.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbTimKiemTheo
        '
        Me.grbTimKiemTheo.Controls.Add(Me.cboGiaTriTimKiem)
        Me.grbTimKiemTheo.Controls.Add(Me.rdoChucVu)
        Me.grbTimKiemTheo.Controls.Add(Me.rdoBoPhan)
        Me.grbTimKiemTheo.Controls.Add(Me.rdoHoTen)
        Me.grbTimKiemTheo.Controls.Add(Me.rdoMaNV)
        Me.grbTimKiemTheo.Location = New System.Drawing.Point(13, 13)
        Me.grbTimKiemTheo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grbTimKiemTheo.Name = "grbTimKiemTheo"
        Me.grbTimKiemTheo.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grbTimKiemTheo.Size = New System.Drawing.Size(336, 95)
        Me.grbTimKiemTheo.TabIndex = 0
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
        'rdoChucVu
        '
        Me.rdoChucVu.AutoSize = True
        Me.rdoChucVu.Location = New System.Drawing.Point(237, 22)
        Me.rdoChucVu.Name = "rdoChucVu"
        Me.rdoChucVu.Size = New System.Drawing.Size(74, 20)
        Me.rdoChucVu.TabIndex = 3
        Me.rdoChucVu.Text = "Chức vụ"
        Me.rdoChucVu.UseVisualStyleBackColor = True
        '
        'rdoBoPhan
        '
        Me.rdoBoPhan.AutoSize = True
        Me.rdoBoPhan.Location = New System.Drawing.Point(157, 22)
        Me.rdoBoPhan.Name = "rdoBoPhan"
        Me.rdoBoPhan.Size = New System.Drawing.Size(74, 20)
        Me.rdoBoPhan.TabIndex = 2
        Me.rdoBoPhan.Text = "Bộ phận"
        Me.rdoBoPhan.UseVisualStyleBackColor = True
        '
        'rdoHoTen
        '
        Me.rdoHoTen.AutoSize = True
        Me.rdoHoTen.Location = New System.Drawing.Point(87, 22)
        Me.rdoHoTen.Name = "rdoHoTen"
        Me.rdoHoTen.Size = New System.Drawing.Size(64, 20)
        Me.rdoHoTen.TabIndex = 1
        Me.rdoHoTen.Text = "Họ tên"
        Me.rdoHoTen.UseVisualStyleBackColor = True
        '
        'rdoMaNV
        '
        Me.rdoMaNV.AutoSize = True
        Me.rdoMaNV.Checked = True
        Me.rdoMaNV.Location = New System.Drawing.Point(15, 22)
        Me.rdoMaNV.Name = "rdoMaNV"
        Me.rdoMaNV.Size = New System.Drawing.Size(66, 20)
        Me.rdoMaNV.TabIndex = 0
        Me.rdoMaNV.TabStop = True
        Me.rdoMaNV.Text = "Mã NV"
        Me.rdoMaNV.UseVisualStyleBackColor = True
        '
        'btnTimKiem
        '
        Me.btnTimKiem.Location = New System.Drawing.Point(355, 24)
        Me.btnTimKiem.Name = "btnTimKiem"
        Me.btnTimKiem.Size = New System.Drawing.Size(90, 29)
        Me.btnTimKiem.TabIndex = 3
        Me.btnTimKiem.Text = "&Tìm kiếm"
        Me.btnTimKiem.UseVisualStyleBackColor = True
        '
        'btnHuyBo
        '
        Me.btnHuyBo.Location = New System.Drawing.Point(355, 79)
        Me.btnHuyBo.Name = "btnHuyBo"
        Me.btnHuyBo.Size = New System.Drawing.Size(90, 29)
        Me.btnHuyBo.TabIndex = 4
        Me.btnHuyBo.Text = "&Hủy bỏ"
        Me.btnHuyBo.UseVisualStyleBackColor = True
        '
        'frmTimKiemNhanVien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 122)
        Me.Controls.Add(Me.btnHuyBo)
        Me.Controls.Add(Me.btnTimKiem)
        Me.Controls.Add(Me.grbTimKiemTheo)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTimKiemNhanVien"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tìm kiếm nhân viên"
        Me.grbTimKiemTheo.ResumeLayout(False)
        Me.grbTimKiemTheo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grbTimKiemTheo As System.Windows.Forms.GroupBox
    Friend WithEvents cboGiaTriTimKiem As System.Windows.Forms.ComboBox
    Friend WithEvents rdoBoPhan As System.Windows.Forms.RadioButton
    Friend WithEvents rdoHoTen As System.Windows.Forms.RadioButton
    Friend WithEvents rdoMaNV As System.Windows.Forms.RadioButton
    Friend WithEvents rdoChucVu As System.Windows.Forms.RadioButton
    Friend WithEvents btnTimKiem As System.Windows.Forms.Button
    Friend WithEvents btnHuyBo As System.Windows.Forms.Button
End Class
