<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMsgOK
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMsgOK))
        Me.lblloiNhac = New System.Windows.Forms.Label
        Me.picInfomation = New System.Windows.Forms.PictureBox
        Me.btnOK = New System.Windows.Forms.Button
        Me.picStop = New System.Windows.Forms.PictureBox
        CType(Me.picInfomation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picStop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblloiNhac
        '
        Me.lblloiNhac.AutoSize = True
        Me.lblloiNhac.Location = New System.Drawing.Point(59, 19)
        Me.lblloiNhac.Name = "lblloiNhac"
        Me.lblloiNhac.Size = New System.Drawing.Size(59, 16)
        Me.lblloiNhac.TabIndex = 0
        Me.lblloiNhac.Text = "Lời nhắc"
        '
        'picInfomation
        '
        Me.picInfomation.Image = CType(resources.GetObject("picInfomation.Image"), System.Drawing.Image)
        Me.picInfomation.Location = New System.Drawing.Point(14, 21)
        Me.picInfomation.Name = "picInfomation"
        Me.picInfomation.Size = New System.Drawing.Size(32, 32)
        Me.picInfomation.TabIndex = 1
        Me.picInfomation.TabStop = False
        '
        'btnOK
        '
        Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOK.Location = New System.Drawing.Point(138, 69)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(70, 30)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "  Đóng"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'picStop
        '
        Me.picStop.Image = CType(resources.GetObject("picStop.Image"), System.Drawing.Image)
        Me.picStop.Location = New System.Drawing.Point(14, 21)
        Me.picStop.Name = "picStop"
        Me.picStop.Size = New System.Drawing.Size(32, 32)
        Me.picStop.TabIndex = 1
        Me.picStop.TabStop = False
        '
        'frmMsgOK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 108)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.lblloiNhac)
        Me.Controls.Add(Me.picInfomation)
        Me.Controls.Add(Me.picStop)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmMsgOK"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tiêu đề"
        CType(Me.picInfomation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picStop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblloiNhac As System.Windows.Forms.Label
    Friend WithEvents picInfomation As System.Windows.Forms.PictureBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents picStop As System.Windows.Forms.PictureBox

End Class
