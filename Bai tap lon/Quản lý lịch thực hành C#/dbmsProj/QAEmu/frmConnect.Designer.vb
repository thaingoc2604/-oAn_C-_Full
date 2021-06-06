<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConnect
    Inherits DevComponents.DotNetBar.Office2007Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConnect))
        Me.cboServer = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.chkStartService = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.txtUID = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtPassword = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.chkIntegrated = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX
        Me.btnConnect = New DevComponents.DotNetBar.ButtonX
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX
        Me.PanelEx4 = New DevComponents.DotNetBar.PanelEx
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboServer
        '
        Me.cboServer.DisplayMember = "Text"
        Me.cboServer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboServer.FormattingEnabled = True
        Me.cboServer.ItemHeight = 14
        Me.cboServer.Location = New System.Drawing.Point(161, 68)
        Me.cboServer.Name = "cboServer"
        Me.cboServer.Size = New System.Drawing.Size(170, 20)
        Me.cboServer.TabIndex = 0
        Me.cboServer.WatermarkText = "(Select Server)"
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        Me.LabelX1.Location = New System.Drawing.Point(95, 71)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(60, 14)
        Me.LabelX1.TabIndex = 7
        Me.LabelX1.Text = "SQL Server:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 59)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'chkStartService
        '
        Me.chkStartService.AutoSize = True
        Me.chkStartService.Location = New System.Drawing.Point(157, 97)
        Me.chkStartService.Name = "chkStartService"
        Me.chkStartService.Size = New System.Drawing.Size(174, 16)
        Me.chkStartService.TabIndex = 5
        Me.chkStartService.Text = "Start SQL Server if it is stopped"
        '
        'txtUID
        '
        '
        '
        '
        Me.txtUID.Border.Class = "TextBoxBorder"
        Me.txtUID.Location = New System.Drawing.Point(161, 161)
        Me.txtUID.Name = "txtUID"
        Me.txtUID.Size = New System.Drawing.Size(170, 21)
        Me.txtUID.TabIndex = 1
        Me.txtUID.WatermarkText = "Login name"
        '
        'txtPassword
        '
        '
        '
        '
        Me.txtPassword.Border.Class = "TextBoxBorder"
        Me.txtPassword.Location = New System.Drawing.Point(161, 188)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(170, 21)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.UseSystemPasswordChar = True
        Me.txtPassword.WatermarkText = "Password"
        '
        'chkIntegrated
        '
        Me.chkIntegrated.AutoSize = True
        Me.chkIntegrated.Location = New System.Drawing.Point(158, 221)
        Me.chkIntegrated.Name = "chkIntegrated"
        Me.chkIntegrated.Size = New System.Drawing.Size(115, 16)
        Me.chkIntegrated.TabIndex = 4
        Me.chkIntegrated.Text = "Integrated Security"
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        Me.LabelX2.Location = New System.Drawing.Point(73, 164)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(63, 14)
        Me.LabelX2.TabIndex = 9
        Me.LabelX2.Text = "Login name:"
        '
        'LabelX3
        '
        Me.LabelX3.AutoSize = True
        Me.LabelX3.Location = New System.Drawing.Point(73, 191)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(52, 14)
        Me.LabelX3.TabIndex = 10
        Me.LabelX3.Text = "Password:"
        '
        'btnConnect
        '
        Me.btnConnect.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnConnect.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnConnect.Image = CType(resources.GetObject("btnConnect.Image"), System.Drawing.Image)
        Me.btnConnect.Location = New System.Drawing.Point(161, 253)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(75, 28)
        Me.btnConnect.TabIndex = 3
        Me.btnConnect.Text = "Connect"
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(256, 253)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 28)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "Cancel"
        '
        'PanelEx4
        '
        Me.PanelEx4.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx4.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelEx4.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx4.Name = "PanelEx4"
        Me.PanelEx4.Size = New System.Drawing.Size(350, 42)
        Me.PanelEx4.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.PanelEx4.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.PanelEx4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx4.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx4.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx4.Style.GradientAngle = 90
        Me.PanelEx4.Style.MarginLeft = 10
        Me.PanelEx4.TabIndex = 0
        Me.PanelEx4.Text = "Connection Info"
        '
        'LabelX4
        '
        Me.LabelX4.AutoSize = True
        Me.LabelX4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.Location = New System.Drawing.Point(12, 138)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(99, 16)
        Me.LabelX4.TabIndex = 8
        Me.LabelX4.Text = "Authentication"
        '
        'frmConnect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 298)
        Me.Controls.Add(Me.PanelEx4)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUID)
        Me.Controls.Add(Me.chkIntegrated)
        Me.Controls.Add(Me.chkStartService)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LabelX3)
        Me.Controls.Add(Me.LabelX4)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.cboServer)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConnect"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Connect to SQL Server"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboServer As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents chkStartService As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents txtUID As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtPassword As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents chkIntegrated As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnConnect As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PanelEx4 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
End Class
