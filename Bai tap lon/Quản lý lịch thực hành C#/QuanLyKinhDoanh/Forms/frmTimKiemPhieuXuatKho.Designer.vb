<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTimKiemPhieuXuatKho
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTimKiemPhieuXuatKho))
        Me.grbTimKiemTheo = New System.Windows.Forms.GroupBox
        Me.cboGiaTriTimKiem = New System.Windows.Forms.ComboBox
        Me.rdoKho = New System.Windows.Forms.RadioButton
        Me.rdoNgayPXK = New System.Windows.Forms.RadioButton
        Me.rdoNhanVien = New System.Windows.Forms.RadioButton
        Me.rdoMaPXK = New System.Windows.Forms.RadioButton
        Me.btnTimKiem = New System.Windows.Forms.Button
        Me.btnHuyBo = New System.Windows.Forms.Button
        Me.grbTimKiemTheo.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbTimKiemTheo
        '
        Me.grbTimKiemTheo.Controls.Add(Me.cboGiaTriTimKiem)
        Me.grbTimKiemTheo.Controls.Add(Me.rdoKho)
        Me.grbTimKiemTheo.Controls.Add(Me.rdoNgayPXK)
        Me.grbTimKiemTheo.Controls.Add(Me.rdoNhanVien)
        Me.grbTimKiemTheo.Controls.Add(Me.rdoMaPXK)
        Me.grbTimKiemTheo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbTimKiemTheo.Location = New System.Drawing.Point(6, 4)
        Me.grbTimKiemTheo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grbTimKiemTheo.Name = "grbTimKiemTheo"
        Me.grbTimKiemTheo.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grbTimKiemTheo.Size = New System.Drawing.Size(336, 95)
        Me.grbTimKiemTheo.TabIndex = 14
        Me.grbTimKiemTheo.TabStop = False
        Me.grbTimKiemTheo.Text = "Theo"
        '
        'cboGiaTriTimKiem
        '
        Me.cboGiaTriTimKiem.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGiaTriTimKiem.FormattingEnabled = True
        Me.cboGiaTriTimKiem.Location = New System.Drawing.Point(15, 51)
        Me.cboGiaTriTimKiem.Name = "cboGiaTriTimKiem"
        Me.cboGiaTriTimKiem.Size = New System.Drawing.Size(296, 24)
        Me.cboGiaTriTimKiem.TabIndex = 1
        '
        'rdoKho
        '
        Me.rdoKho.AutoSize = True
        Me.rdoKho.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoKho.Location = New System.Drawing.Point(271, 22)
        Me.rdoKho.Name = "rdoKho"
        Me.rdoKho.Size = New System.Drawing.Size(49, 20)
        Me.rdoKho.TabIndex = 3
        Me.rdoKho.Text = "Kho"
        Me.rdoKho.UseVisualStyleBackColor = True
        '
        'rdoNgayPXK
        '
        Me.rdoNgayPXK.AutoSize = True
        Me.rdoNgayPXK.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoNgayPXK.Location = New System.Drawing.Point(94, 22)
        Me.rdoNgayPXK.Name = "rdoNgayPXK"
        Me.rdoNgayPXK.Size = New System.Drawing.Size(85, 20)
        Me.rdoNgayPXK.TabIndex = 1
        Me.rdoNgayPXK.Text = "Ngày PXK"
        Me.rdoNgayPXK.UseVisualStyleBackColor = True
        '
        'rdoNhanVien
        '
        Me.rdoNhanVien.AutoSize = True
        Me.rdoNhanVien.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoNhanVien.Location = New System.Drawing.Point(183, 22)
        Me.rdoNhanVien.Name = "rdoNhanVien"
        Me.rdoNhanVien.Size = New System.Drawing.Size(82, 20)
        Me.rdoNhanVien.TabIndex = 2
        Me.rdoNhanVien.Text = "Nhân viên"
        Me.rdoNhanVien.UseVisualStyleBackColor = True
        '
        'rdoMaPXK
        '
        Me.rdoMaPXK.AutoSize = True
        Me.rdoMaPXK.Checked = True
        Me.rdoMaPXK.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoMaPXK.Location = New System.Drawing.Point(15, 22)
        Me.rdoMaPXK.Name = "rdoMaPXK"
        Me.rdoMaPXK.Size = New System.Drawing.Size(73, 20)
        Me.rdoMaPXK.TabIndex = 0
        Me.rdoMaPXK.TabStop = True
        Me.rdoMaPXK.Text = "Mã PXK"
        Me.rdoMaPXK.UseVisualStyleBackColor = True
        '
        'btnTimKiem
        '
        Me.btnTimKiem.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimKiem.Location = New System.Drawing.Point(348, 15)
        Me.btnTimKiem.Name = "btnTimKiem"
        Me.btnTimKiem.Size = New System.Drawing.Size(90, 29)
        Me.btnTimKiem.TabIndex = 15
        Me.btnTimKiem.Text = "&Tìm kiếm"
        Me.btnTimKiem.UseVisualStyleBackColor = True
        '
        'btnHuyBo
        '
        Me.btnHuyBo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHuyBo.Location = New System.Drawing.Point(348, 62)
        Me.btnHuyBo.Name = "btnHuyBo"
        Me.btnHuyBo.Size = New System.Drawing.Size(90, 29)
        Me.btnHuyBo.TabIndex = 16
        Me.btnHuyBo.Text = "&Hủy bỏ"
        Me.btnHuyBo.UseVisualStyleBackColor = True
        '
        'frmTimKiemPhieuXuatKho
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 102)
        Me.Controls.Add(Me.grbTimKiemTheo)
        Me.Controls.Add(Me.btnTimKiem)
        Me.Controls.Add(Me.btnHuyBo)
        Me.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTimKiemPhieuXuatKho"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tìm kiếm PXK"
        Me.grbTimKiemTheo.ResumeLayout(False)
        Me.grbTimKiemTheo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grbTimKiemTheo As System.Windows.Forms.GroupBox
    Friend WithEvents cboGiaTriTimKiem As System.Windows.Forms.ComboBox
    Friend WithEvents rdoKho As System.Windows.Forms.RadioButton
    Friend WithEvents rdoNgayPXK As System.Windows.Forms.RadioButton
    Friend WithEvents rdoNhanVien As System.Windows.Forms.RadioButton
    Friend WithEvents rdoMaPXK As System.Windows.Forms.RadioButton
    Friend WithEvents btnTimKiem As System.Windows.Forms.Button
    Friend WithEvents btnHuyBo As System.Windows.Forms.Button
End Class
