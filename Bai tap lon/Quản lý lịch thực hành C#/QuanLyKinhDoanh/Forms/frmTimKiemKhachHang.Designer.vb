<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTimKiemKhachHang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTimKiemKhachHang))
        Me.grbTimKiemTheo = New System.Windows.Forms.GroupBox
        Me.cboGiaTriTimKiem = New System.Windows.Forms.ComboBox
        Me.rdoMST = New System.Windows.Forms.RadioButton
        Me.rdoCongTy = New System.Windows.Forms.RadioButton
        Me.rdoTenKH = New System.Windows.Forms.RadioButton
        Me.rdoMaKH = New System.Windows.Forms.RadioButton
        Me.btnTimKiem = New System.Windows.Forms.Button
        Me.btnHuyBo = New System.Windows.Forms.Button
        Me.grbTimKiemTheo.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbTimKiemTheo
        '
        Me.grbTimKiemTheo.Controls.Add(Me.cboGiaTriTimKiem)
        Me.grbTimKiemTheo.Controls.Add(Me.rdoMST)
        Me.grbTimKiemTheo.Controls.Add(Me.rdoCongTy)
        Me.grbTimKiemTheo.Controls.Add(Me.rdoTenKH)
        Me.grbTimKiemTheo.Controls.Add(Me.rdoMaKH)
        Me.grbTimKiemTheo.Location = New System.Drawing.Point(8, 12)
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
        Me.cboGiaTriTimKiem.Location = New System.Drawing.Point(15, 46)
        Me.cboGiaTriTimKiem.Name = "cboGiaTriTimKiem"
        Me.cboGiaTriTimKiem.Size = New System.Drawing.Size(296, 24)
        Me.cboGiaTriTimKiem.TabIndex = 1
        '
        'rdoMST
        '
        Me.rdoMST.AutoSize = True
        Me.rdoMST.Location = New System.Drawing.Point(237, 17)
        Me.rdoMST.Name = "rdoMST"
        Me.rdoMST.Size = New System.Drawing.Size(53, 20)
        Me.rdoMST.TabIndex = 3
        Me.rdoMST.Text = "MST"
        Me.rdoMST.UseVisualStyleBackColor = True
        '
        'rdoCongTy
        '
        Me.rdoCongTy.AutoSize = True
        Me.rdoCongTy.Location = New System.Drawing.Point(157, 17)
        Me.rdoCongTy.Name = "rdoCongTy"
        Me.rdoCongTy.Size = New System.Drawing.Size(71, 20)
        Me.rdoCongTy.TabIndex = 2
        Me.rdoCongTy.Text = "Công ty"
        Me.rdoCongTy.UseVisualStyleBackColor = True
        '
        'rdoTenKH
        '
        Me.rdoTenKH.AutoSize = True
        Me.rdoTenKH.Location = New System.Drawing.Point(87, 17)
        Me.rdoTenKH.Name = "rdoTenKH"
        Me.rdoTenKH.Size = New System.Drawing.Size(69, 20)
        Me.rdoTenKH.TabIndex = 1
        Me.rdoTenKH.Text = "Tên KH"
        Me.rdoTenKH.UseVisualStyleBackColor = True
        '
        'rdoMaKH
        '
        Me.rdoMaKH.AutoSize = True
        Me.rdoMaKH.Checked = True
        Me.rdoMaKH.Location = New System.Drawing.Point(15, 17)
        Me.rdoMaKH.Name = "rdoMaKH"
        Me.rdoMaKH.Size = New System.Drawing.Size(66, 20)
        Me.rdoMaKH.TabIndex = 0
        Me.rdoMaKH.TabStop = True
        Me.rdoMaKH.Text = "Mã KH"
        Me.rdoMaKH.UseVisualStyleBackColor = True
        '
        'btnTimKiem
        '
        Me.btnTimKiem.Location = New System.Drawing.Point(350, 23)
        Me.btnTimKiem.Name = "btnTimKiem"
        Me.btnTimKiem.Size = New System.Drawing.Size(90, 29)
        Me.btnTimKiem.TabIndex = 6
        Me.btnTimKiem.Text = "&Tìm kiếm"
        Me.btnTimKiem.UseVisualStyleBackColor = True
        '
        'btnHuyBo
        '
        Me.btnHuyBo.Location = New System.Drawing.Point(350, 72)
        Me.btnHuyBo.Name = "btnHuyBo"
        Me.btnHuyBo.Size = New System.Drawing.Size(90, 29)
        Me.btnHuyBo.TabIndex = 7
        Me.btnHuyBo.Text = "&Hủy bỏ"
        Me.btnHuyBo.UseVisualStyleBackColor = True
        '
        'frmTimKiemKhachHang
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
        Me.Name = "frmTimKiemKhachHang"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tìm kiếm khách hàng"
        Me.grbTimKiemTheo.ResumeLayout(False)
        Me.grbTimKiemTheo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grbTimKiemTheo As System.Windows.Forms.GroupBox
    Friend WithEvents cboGiaTriTimKiem As System.Windows.Forms.ComboBox
    Friend WithEvents rdoMST As System.Windows.Forms.RadioButton
    Friend WithEvents rdoCongTy As System.Windows.Forms.RadioButton
    Friend WithEvents rdoTenKH As System.Windows.Forms.RadioButton
    Friend WithEvents rdoMaKH As System.Windows.Forms.RadioButton
    Friend WithEvents btnTimKiem As System.Windows.Forms.Button
    Friend WithEvents btnHuyBo As System.Windows.Forms.Button
End Class
