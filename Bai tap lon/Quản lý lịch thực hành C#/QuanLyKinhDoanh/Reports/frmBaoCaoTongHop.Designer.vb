<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBaoCaoTongHop
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBaoCaoTongHop))
        Me.Label1 = New System.Windows.Forms.Label
        Me.mskTuNgay = New System.Windows.Forms.MaskedTextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnInBC = New System.Windows.Forms.Button
        Me.btnThoat = New System.Windows.Forms.Button
        Me.mskDenNgay = New System.Windows.Forms.MaskedTextBox
        Me.lstBaoCao = New System.Windows.Forms.ListBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(287, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Từ ngày"
        '
        'mskTuNgay
        '
        Me.mskTuNgay.Location = New System.Drawing.Point(287, 45)
        Me.mskTuNgay.Mask = "00/00/0000"
        Me.mskTuNgay.Name = "mskTuNgay"
        Me.mskTuNgay.Size = New System.Drawing.Size(100, 22)
        Me.mskTuNgay.TabIndex = 1
        Me.mskTuNgay.Tag = "NN"
        Me.mskTuNgay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.mskTuNgay.ValidatingType = GetType(Date)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(290, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Đến ngày"
        '
        'btnInBC
        '
        Me.btnInBC.Image = CType(resources.GetObject("btnInBC.Image"), System.Drawing.Image)
        Me.btnInBC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInBC.Location = New System.Drawing.Point(290, 181)
        Me.btnInBC.Name = "btnInBC"
        Me.btnInBC.Size = New System.Drawing.Size(100, 31)
        Me.btnInBC.TabIndex = 3
        Me.btnInBC.Text = "&In BC"
        Me.btnInBC.UseVisualStyleBackColor = True
        '
        'btnThoat
        '
        Me.btnThoat.Image = CType(resources.GetObject("btnThoat.Image"), System.Drawing.Image)
        Me.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThoat.Location = New System.Drawing.Point(290, 226)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(100, 31)
        Me.btnThoat.TabIndex = 4
        Me.btnThoat.Text = "     &Thoát"
        Me.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'mskDenNgay
        '
        Me.mskDenNgay.Location = New System.Drawing.Point(290, 93)
        Me.mskDenNgay.Mask = "00/00/0000"
        Me.mskDenNgay.Name = "mskDenNgay"
        Me.mskDenNgay.Size = New System.Drawing.Size(100, 22)
        Me.mskDenNgay.TabIndex = 2
        Me.mskDenNgay.Tag = "NN"
        Me.mskDenNgay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.mskDenNgay.ValidatingType = GetType(Date)
        '
        'lstBaoCao
        '
        Me.lstBaoCao.FormattingEnabled = True
        Me.lstBaoCao.ItemHeight = 16
        Me.lstBaoCao.Location = New System.Drawing.Point(23, 45)
        Me.lstBaoCao.Name = "lstBaoCao"
        Me.lstBaoCao.Size = New System.Drawing.Size(241, 212)
        Me.lstBaoCao.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Chọn báo cáo"
        '
        'ErrorProvider
        '
        Me.ErrorProvider.BlinkRate = 0
        Me.ErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider.ContainerControl = Me
        '
        'frmBaoCaoTongHop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 280)
        Me.Controls.Add(Me.lstBaoCao)
        Me.Controls.Add(Me.mskDenNgay)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.mskTuNgay)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnInBC)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBaoCaoTongHop"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Báo cáo"
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents mskTuNgay As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnInBC As System.Windows.Forms.Button
    Friend WithEvents btnThoat As System.Windows.Forms.Button
    Friend WithEvents mskDenNgay As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lstBaoCao As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
End Class
