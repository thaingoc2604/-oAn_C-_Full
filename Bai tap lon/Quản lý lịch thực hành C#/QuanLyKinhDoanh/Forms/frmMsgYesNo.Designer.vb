<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMsgYesNo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMsgYesNo))
        Me.picQuestion = New System.Windows.Forms.PictureBox
        Me.lblLoiNhac = New System.Windows.Forms.Label
        Me.btnCo = New System.Windows.Forms.Button
        Me.btnKhong = New System.Windows.Forms.Button
        Me.picWarning = New System.Windows.Forms.PictureBox
        CType(Me.picQuestion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picWarning, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picQuestion
        '
        Me.picQuestion.Image = CType(resources.GetObject("picQuestion.Image"), System.Drawing.Image)
        Me.picQuestion.Location = New System.Drawing.Point(15, 15)
        Me.picQuestion.Name = "picQuestion"
        Me.picQuestion.Size = New System.Drawing.Size(32, 32)
        Me.picQuestion.TabIndex = 0
        Me.picQuestion.TabStop = False
        '
        'lblLoiNhac
        '
        Me.lblLoiNhac.AutoSize = True
        Me.lblLoiNhac.Location = New System.Drawing.Point(66, 15)
        Me.lblLoiNhac.Name = "lblLoiNhac"
        Me.lblLoiNhac.Size = New System.Drawing.Size(59, 16)
        Me.lblLoiNhac.TabIndex = 1
        Me.lblLoiNhac.Text = "Lời nhắc"
        '
        'btnCo
        '
        Me.btnCo.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.btnCo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCo.Location = New System.Drawing.Point(93, 62)
        Me.btnCo.Name = "btnCo"
        Me.btnCo.Size = New System.Drawing.Size(72, 30)
        Me.btnCo.TabIndex = 2
        Me.btnCo.Text = "&Có"
        Me.btnCo.UseVisualStyleBackColor = True
        '
        'btnKhong
        '
        Me.btnKhong.DialogResult = System.Windows.Forms.DialogResult.No
        Me.btnKhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnKhong.Location = New System.Drawing.Point(197, 62)
        Me.btnKhong.Name = "btnKhong"
        Me.btnKhong.Size = New System.Drawing.Size(72, 30)
        Me.btnKhong.TabIndex = 3
        Me.btnKhong.Text = "&Không"
        Me.btnKhong.UseVisualStyleBackColor = True
        '
        'picWarning
        '
        Me.picWarning.Image = CType(resources.GetObject("picWarning.Image"), System.Drawing.Image)
        Me.picWarning.Location = New System.Drawing.Point(15, 15)
        Me.picWarning.Name = "picWarning"
        Me.picWarning.Size = New System.Drawing.Size(32, 32)
        Me.picWarning.TabIndex = 0
        Me.picWarning.TabStop = False
        '
        'frmMsgYesNo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 103)
        Me.Controls.Add(Me.btnKhong)
        Me.Controls.Add(Me.btnCo)
        Me.Controls.Add(Me.lblLoiNhac)
        Me.Controls.Add(Me.picQuestion)
        Me.Controls.Add(Me.picWarning)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmMsgYesNo"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tiêu đề"
        CType(Me.picQuestion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picWarning, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picQuestion As System.Windows.Forms.PictureBox
    Friend WithEvents lblLoiNhac As System.Windows.Forms.Label
    Friend WithEvents btnCo As System.Windows.Forms.Button
    Friend WithEvents btnKhong As System.Windows.Forms.Button
    Friend WithEvents picWarning As System.Windows.Forms.PictureBox
End Class
