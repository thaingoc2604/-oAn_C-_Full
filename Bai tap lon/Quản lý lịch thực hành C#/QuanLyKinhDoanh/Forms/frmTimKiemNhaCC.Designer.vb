<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTimKiemNhaCC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTimKiemNhaCC))
        Me.grbTimKiemTheo = New System.Windows.Forms.GroupBox
        Me.cboGiaTriTimKiem = New System.Windows.Forms.ComboBox
        Me.rdoTaiKhoan = New System.Windows.Forms.RadioButton
        Me.rdoMST = New System.Windows.Forms.RadioButton
        Me.rdoTenNCC = New System.Windows.Forms.RadioButton
        Me.rdoMaNCC = New System.Windows.Forms.RadioButton
        Me.btnTimKiem = New System.Windows.Forms.Button
        Me.btnHuyBo = New System.Windows.Forms.Button
        Me.grbTimKiemTheo.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbTimKiemTheo
        '
        Me.grbTimKiemTheo.Controls.Add(Me.cboGiaTriTimKiem)
        Me.grbTimKiemTheo.Controls.Add(Me.rdoTaiKhoan)
        Me.grbTimKiemTheo.Controls.Add(Me.rdoMST)
        Me.grbTimKiemTheo.Controls.Add(Me.rdoTenNCC)
        Me.grbTimKiemTheo.Controls.Add(Me.rdoMaNCC)
        Me.grbTimKiemTheo.Location = New System.Drawing.Point(9, 12)
        Me.grbTimKiemTheo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grbTimKiemTheo.Name = "grbTimKiemTheo"
        Me.grbTimKiemTheo.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grbTimKiemTheo.Size = New System.Drawing.Size(336, 95)
        Me.grbTimKiemTheo.TabIndex = 8
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
        'rdoTaiKhoan
        '
        Me.rdoTaiKhoan.AutoSize = True
        Me.rdoTaiKhoan.Location = New System.Drawing.Point(230, 22)
        Me.rdoTaiKhoan.Name = "rdoTaiKhoan"
        Me.rdoTaiKhoan.Size = New System.Drawing.Size(82, 20)
        Me.rdoTaiKhoan.TabIndex = 3
        Me.rdoTaiKhoan.Text = "Tài khoản"
        Me.rdoTaiKhoan.UseVisualStyleBackColor = True
        '
        'rdoMST
        '
        Me.rdoMST.AutoSize = True
        Me.rdoMST.Location = New System.Drawing.Point(175, 22)
        Me.rdoMST.Name = "rdoMST"
        Me.rdoMST.Size = New System.Drawing.Size(53, 20)
        Me.rdoMST.TabIndex = 2
        Me.rdoMST.Text = "MST"
        Me.rdoMST.UseVisualStyleBackColor = True
        '
        'rdoTenNCC
        '
        Me.rdoTenNCC.AutoSize = True
        Me.rdoTenNCC.Location = New System.Drawing.Point(95, 22)
        Me.rdoTenNCC.Name = "rdoTenNCC"
        Me.rdoTenNCC.Size = New System.Drawing.Size(78, 20)
        Me.rdoTenNCC.TabIndex = 1
        Me.rdoTenNCC.Text = "Tên NCC"
        Me.rdoTenNCC.UseVisualStyleBackColor = True
        '
        'rdoMaNCC
        '
        Me.rdoMaNCC.AutoSize = True
        Me.rdoMaNCC.Checked = True
        Me.rdoMaNCC.Location = New System.Drawing.Point(15, 22)
        Me.rdoMaNCC.Name = "rdoMaNCC"
        Me.rdoMaNCC.Size = New System.Drawing.Size(75, 20)
        Me.rdoMaNCC.TabIndex = 0
        Me.rdoMaNCC.TabStop = True
        Me.rdoMaNCC.Text = "Mã NCC"
        Me.rdoMaNCC.UseVisualStyleBackColor = True
        '
        'btnTimKiem
        '
        Me.btnTimKiem.Location = New System.Drawing.Point(351, 23)
        Me.btnTimKiem.Name = "btnTimKiem"
        Me.btnTimKiem.Size = New System.Drawing.Size(90, 29)
        Me.btnTimKiem.TabIndex = 9
        Me.btnTimKiem.Text = "&Tìm kiếm"
        Me.btnTimKiem.UseVisualStyleBackColor = True
        '
        'btnHuyBo
        '
        Me.btnHuyBo.Location = New System.Drawing.Point(351, 70)
        Me.btnHuyBo.Name = "btnHuyBo"
        Me.btnHuyBo.Size = New System.Drawing.Size(90, 29)
        Me.btnHuyBo.TabIndex = 10
        Me.btnHuyBo.Text = "&Hủy bỏ"
        Me.btnHuyBo.UseVisualStyleBackColor = True
        '
        'frmTimKiemNhaCC
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
        Me.Name = "frmTimKiemNhaCC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tìm kiếm nhà cung cấp"
        Me.grbTimKiemTheo.ResumeLayout(False)
        Me.grbTimKiemTheo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grbTimKiemTheo As System.Windows.Forms.GroupBox
    Friend WithEvents cboGiaTriTimKiem As System.Windows.Forms.ComboBox
    Friend WithEvents rdoMST As System.Windows.Forms.RadioButton
    Friend WithEvents rdoTenNCC As System.Windows.Forms.RadioButton
    Friend WithEvents rdoMaNCC As System.Windows.Forms.RadioButton
    Friend WithEvents btnTimKiem As System.Windows.Forms.Button
    Friend WithEvents btnHuyBo As System.Windows.Forms.Button
    Friend WithEvents rdoTaiKhoan As System.Windows.Forms.RadioButton
End Class
