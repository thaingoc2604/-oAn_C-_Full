<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTimKiemPhieuNhapKho
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTimKiemPhieuNhapKho))
        Me.grbTimKiemTheo = New System.Windows.Forms.GroupBox
        Me.cboGiaTriTimKiem = New System.Windows.Forms.ComboBox
        Me.rdoKho = New System.Windows.Forms.RadioButton
        Me.rdoNgayPNK = New System.Windows.Forms.RadioButton
        Me.rdoNhanVien = New System.Windows.Forms.RadioButton
        Me.rdoMaPNK = New System.Windows.Forms.RadioButton
        Me.btnTimKiem = New System.Windows.Forms.Button
        Me.btnHuyBo = New System.Windows.Forms.Button
        Me.grbTimKiemTheo.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbTimKiemTheo
        '
        Me.grbTimKiemTheo.Controls.Add(Me.cboGiaTriTimKiem)
        Me.grbTimKiemTheo.Controls.Add(Me.rdoKho)
        Me.grbTimKiemTheo.Controls.Add(Me.rdoNgayPNK)
        Me.grbTimKiemTheo.Controls.Add(Me.rdoNhanVien)
        Me.grbTimKiemTheo.Controls.Add(Me.rdoMaPNK)
        Me.grbTimKiemTheo.Location = New System.Drawing.Point(6, 3)
        Me.grbTimKiemTheo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grbTimKiemTheo.Name = "grbTimKiemTheo"
        Me.grbTimKiemTheo.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grbTimKiemTheo.Size = New System.Drawing.Size(336, 95)
        Me.grbTimKiemTheo.TabIndex = 11
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
        'rdoKho
        '
        Me.rdoKho.AutoSize = True
        Me.rdoKho.Location = New System.Drawing.Point(274, 22)
        Me.rdoKho.Name = "rdoKho"
        Me.rdoKho.Size = New System.Drawing.Size(49, 20)
        Me.rdoKho.TabIndex = 3
        Me.rdoKho.Text = "Kho"
        Me.rdoKho.UseVisualStyleBackColor = True
        '
        'rdoNgayPNK
        '
        Me.rdoNgayPNK.AutoSize = True
        Me.rdoNgayPNK.Location = New System.Drawing.Point(96, 22)
        Me.rdoNgayPNK.Name = "rdoNgayPNK"
        Me.rdoNgayPNK.Size = New System.Drawing.Size(87, 20)
        Me.rdoNgayPNK.TabIndex = 1
        Me.rdoNgayPNK.Text = "Ngày PNK"
        Me.rdoNgayPNK.UseVisualStyleBackColor = True
        '
        'rdoNhanVien
        '
        Me.rdoNhanVien.AutoSize = True
        Me.rdoNhanVien.Location = New System.Drawing.Point(186, 22)
        Me.rdoNhanVien.Name = "rdoNhanVien"
        Me.rdoNhanVien.Size = New System.Drawing.Size(82, 20)
        Me.rdoNhanVien.TabIndex = 2
        Me.rdoNhanVien.Text = "Nhân viên"
        Me.rdoNhanVien.UseVisualStyleBackColor = True
        '
        'rdoMaPNK
        '
        Me.rdoMaPNK.AutoSize = True
        Me.rdoMaPNK.Checked = True
        Me.rdoMaPNK.Location = New System.Drawing.Point(15, 22)
        Me.rdoMaPNK.Name = "rdoMaPNK"
        Me.rdoMaPNK.Size = New System.Drawing.Size(75, 20)
        Me.rdoMaPNK.TabIndex = 0
        Me.rdoMaPNK.TabStop = True
        Me.rdoMaPNK.Text = "Mã PNK"
        Me.rdoMaPNK.UseVisualStyleBackColor = True
        '
        'btnTimKiem
        '
        Me.btnTimKiem.Location = New System.Drawing.Point(348, 14)
        Me.btnTimKiem.Name = "btnTimKiem"
        Me.btnTimKiem.Size = New System.Drawing.Size(90, 29)
        Me.btnTimKiem.TabIndex = 12
        Me.btnTimKiem.Text = "&Tìm kiếm"
        Me.btnTimKiem.UseVisualStyleBackColor = True
        '
        'btnHuyBo
        '
        Me.btnHuyBo.Location = New System.Drawing.Point(348, 61)
        Me.btnHuyBo.Name = "btnHuyBo"
        Me.btnHuyBo.Size = New System.Drawing.Size(90, 29)
        Me.btnHuyBo.TabIndex = 13
        Me.btnHuyBo.Text = "&Hủy bỏ"
        Me.btnHuyBo.UseVisualStyleBackColor = True
        '
        'frmTimKiemPhieuNhapKho
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 102)
        Me.Controls.Add(Me.grbTimKiemTheo)
        Me.Controls.Add(Me.btnTimKiem)
        Me.Controls.Add(Me.btnHuyBo)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTimKiemPhieuNhapKho"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tìm kiếm PNK"
        Me.grbTimKiemTheo.ResumeLayout(False)
        Me.grbTimKiemTheo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grbTimKiemTheo As System.Windows.Forms.GroupBox
    Friend WithEvents cboGiaTriTimKiem As System.Windows.Forms.ComboBox
    Friend WithEvents rdoKho As System.Windows.Forms.RadioButton
    Friend WithEvents rdoNgayPNK As System.Windows.Forms.RadioButton
    Friend WithEvents rdoNhanVien As System.Windows.Forms.RadioButton
    Friend WithEvents rdoMaPNK As System.Windows.Forms.RadioButton
    Friend WithEvents btnTimKiem As System.Windows.Forms.Button
    Friend WithEvents btnHuyBo As System.Windows.Forms.Button
End Class
