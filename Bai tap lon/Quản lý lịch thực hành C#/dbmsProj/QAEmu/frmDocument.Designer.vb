<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDocument
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDocument))
        Me.pnResult = New System.Windows.Forms.Panel
        Me.tcBottom = New DevComponents.DotNetBar.TabControl
        Me.TabControlPanel2 = New DevComponents.DotNetBar.TabControlPanel
        Me.tcGrids = New DevComponents.DotNetBar.TabControl
        Me.tabGrids = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel
        Me.txtMessages = New System.Windows.Forms.RichTextBox
        Me.tabMessage = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.splBottom = New DevComponents.DotNetBar.ExpandableSplitter
        Me.pnMain = New System.Windows.Forms.Panel
        Me.txtScript = New System.Windows.Forms.RichTextBox
        Me.pnResult.SuspendLayout()
        CType(Me.tcBottom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcBottom.SuspendLayout()
        Me.TabControlPanel2.SuspendLayout()
        CType(Me.tcGrids, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlPanel1.SuspendLayout()
        Me.pnMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnResult
        '
        Me.pnResult.Controls.Add(Me.tcBottom)
        Me.pnResult.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnResult.Location = New System.Drawing.Point(0, 298)
        Me.pnResult.Name = "pnResult"
        Me.pnResult.Size = New System.Drawing.Size(719, 198)
        Me.pnResult.TabIndex = 1
        '
        'tcBottom
        '
        Me.tcBottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.tcBottom.CanReorderTabs = True
        Me.tcBottom.Controls.Add(Me.TabControlPanel2)
        Me.tcBottom.Controls.Add(Me.TabControlPanel1)
        Me.tcBottom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcBottom.FixedTabSize = New System.Drawing.Size(100, 0)
        Me.tcBottom.Location = New System.Drawing.Point(0, 0)
        Me.tcBottom.Name = "tcBottom"
        Me.tcBottom.SelectedTabFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tcBottom.SelectedTabIndex = 0
        Me.tcBottom.Size = New System.Drawing.Size(719, 198)
        Me.tcBottom.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Dock
        Me.tcBottom.TabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Bottom
        Me.tcBottom.TabIndex = 0
        Me.tcBottom.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.tcBottom.Tabs.Add(Me.tabMessage)
        Me.tcBottom.Tabs.Add(Me.tabGrids)
        Me.tcBottom.Text = "TabControl1"
        '
        'TabControlPanel2
        '
        Me.TabControlPanel2.Controls.Add(Me.tcGrids)
        Me.TabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TabControlPanel2.Name = "TabControlPanel2"
        Me.TabControlPanel2.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel2.Size = New System.Drawing.Size(719, 173)
        Me.TabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel2.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Top), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel2.Style.GradientAngle = -90
        Me.TabControlPanel2.TabIndex = 2
        Me.TabControlPanel2.TabItem = Me.tabGrids
        '
        'tcGrids
        '
        Me.tcGrids.CanReorderTabs = True
        Me.tcGrids.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcGrids.FixedTabSize = New System.Drawing.Size(100, 0)
        Me.tcGrids.Location = New System.Drawing.Point(1, 1)
        Me.tcGrids.Name = "tcGrids"
        Me.tcGrids.SelectedTabFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tcGrids.SelectedTabIndex = -1
        Me.tcGrids.Size = New System.Drawing.Size(717, 171)
        Me.tcGrids.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Dock
        Me.tcGrids.TabIndex = 0
        Me.tcGrids.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.tcGrids.Text = "TabControl1"
        '
        'tabGrids
        '
        Me.tabGrids.AttachedControl = Me.TabControlPanel2
        Me.tabGrids.Image = CType(resources.GetObject("tabGrids.Image"), System.Drawing.Image)
        Me.tabGrids.Name = "tabGrids"
        Me.tabGrids.Text = "Grids"
        Me.tabGrids.Visible = False
        '
        'TabControlPanel1
        '
        Me.TabControlPanel1.Controls.Add(Me.txtMessages)
        Me.TabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TabControlPanel1.Name = "TabControlPanel1"
        Me.TabControlPanel1.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel1.Size = New System.Drawing.Size(719, 173)
        Me.TabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel1.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Top), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel1.Style.GradientAngle = -90
        Me.TabControlPanel1.TabIndex = 1
        Me.TabControlPanel1.TabItem = Me.tabMessage
        '
        'txtMessages
        '
        Me.txtMessages.AcceptsTab = True
        Me.txtMessages.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtMessages.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMessages.Location = New System.Drawing.Point(1, 1)
        Me.txtMessages.Name = "txtMessages"
        Me.txtMessages.Size = New System.Drawing.Size(717, 171)
        Me.txtMessages.TabIndex = 1
        Me.txtMessages.Text = ""
        '
        'tabMessage
        '
        Me.tabMessage.AttachedControl = Me.TabControlPanel1
        Me.tabMessage.Image = CType(resources.GetObject("tabMessage.Image"), System.Drawing.Image)
        Me.tabMessage.Name = "tabMessage"
        Me.tabMessage.Text = "Messages"
        '
        'splBottom
        '
        Me.splBottom.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.splBottom.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.splBottom.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.splBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.splBottom.Expandable = False
        Me.splBottom.ExpandableControl = Me.pnResult
        Me.splBottom.ExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.splBottom.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.splBottom.ExpandLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.splBottom.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.splBottom.GripDarkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.splBottom.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.splBottom.GripLightColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.splBottom.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.splBottom.HotBackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.splBottom.HotBackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.splBottom.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2
        Me.splBottom.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground
        Me.splBottom.HotExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.splBottom.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.splBottom.HotExpandLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.splBottom.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.splBottom.HotGripDarkColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.splBottom.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.splBottom.HotGripLightColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.splBottom.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.splBottom.Location = New System.Drawing.Point(0, 295)
        Me.splBottom.Name = "splBottom"
        Me.splBottom.Size = New System.Drawing.Size(719, 3)
        Me.splBottom.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007
        Me.splBottom.TabIndex = 2
        Me.splBottom.TabStop = False
        '
        'pnMain
        '
        Me.pnMain.Controls.Add(Me.txtScript)
        Me.pnMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnMain.Location = New System.Drawing.Point(0, 0)
        Me.pnMain.Name = "pnMain"
        Me.pnMain.Size = New System.Drawing.Size(719, 295)
        Me.pnMain.TabIndex = 0
        '
        'txtScript
        '
        Me.txtScript.AcceptsTab = True
        Me.txtScript.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtScript.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtScript.Location = New System.Drawing.Point(0, 0)
        Me.txtScript.Name = "txtScript"
        Me.txtScript.Size = New System.Drawing.Size(719, 295)
        Me.txtScript.TabIndex = 0
        Me.txtScript.Text = ""
        '
        'frmDocument
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 496)
        Me.Controls.Add(Me.pnMain)
        Me.Controls.Add(Me.splBottom)
        Me.Controls.Add(Me.pnResult)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDocument"
        Me.Text = "Query"
        Me.pnResult.ResumeLayout(False)
        CType(Me.tcBottom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcBottom.ResumeLayout(False)
        Me.TabControlPanel2.ResumeLayout(False)
        CType(Me.tcGrids, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlPanel1.ResumeLayout(False)
        Me.pnMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnResult As System.Windows.Forms.Panel
    Friend WithEvents splBottom As DevComponents.DotNetBar.ExpandableSplitter
    Friend WithEvents pnMain As System.Windows.Forms.Panel
    Friend WithEvents tcBottom As DevComponents.DotNetBar.TabControl
    Friend WithEvents TabControlPanel1 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents tabMessage As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel2 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents tabGrids As DevComponents.DotNetBar.TabItem
    Friend WithEvents tcGrids As DevComponents.DotNetBar.TabControl
    Friend WithEvents txtScript As System.Windows.Forms.RichTextBox
    Friend WithEvents txtMessages As System.Windows.Forms.RichTextBox
End Class
