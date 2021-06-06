<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits DevComponents.DotNetBar.Office2007RibbonForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.RibbonControl1 = New DevComponents.DotNetBar.RibbonControl
        Me.RibbonPanel1 = New DevComponents.DotNetBar.RibbonPanel
        Me.RibbonBar4 = New DevComponents.DotNetBar.RibbonBar
        Me.biCascade = New DevComponents.DotNetBar.ButtonItem
        Me.biHorizontal = New DevComponents.DotNetBar.ButtonItem
        Me.biVertical = New DevComponents.DotNetBar.ButtonItem
        Me.RibbonBar3 = New DevComponents.DotNetBar.RibbonBar
        Me.ItemContainer4 = New DevComponents.DotNetBar.ItemContainer
        Me.biShowRS = New DevComponents.DotNetBar.ButtonItem
        Me.cboDatabases = New DevComponents.DotNetBar.ComboBoxItem
        Me.RibbonBar2 = New DevComponents.DotNetBar.RibbonBar
        Me.biNewScript = New DevComponents.DotNetBar.ButtonItem
        Me.ItemContainer3 = New DevComponents.DotNetBar.ItemContainer
        Me.biOpen = New DevComponents.DotNetBar.ButtonItem
        Me.biClose = New DevComponents.DotNetBar.ButtonItem
        Me.biCloseAll = New DevComponents.DotNetBar.ButtonItem
        Me.biRun = New DevComponents.DotNetBar.ButtonItem
        Me.RibbonBar1 = New DevComponents.DotNetBar.RibbonBar
        Me.biConnect = New DevComponents.DotNetBar.ButtonItem
        Me.biDisconnect = New DevComponents.DotNetBar.ButtonItem
        Me.RibbonTabItem1 = New DevComponents.DotNetBar.RibbonTabItem
        Me.Office2007StartButton1 = New DevComponents.DotNetBar.Office2007StartButton
        Me.ItemContainer1 = New DevComponents.DotNetBar.ItemContainer
        Me.ItemContainer2 = New DevComponents.DotNetBar.ItemContainer
        Me.biAbout = New DevComponents.DotNetBar.ButtonItem
        Me.biHelp = New DevComponents.DotNetBar.ButtonItem
        Me.biRestart = New DevComponents.DotNetBar.ButtonItem
        Me.biExit = New DevComponents.DotNetBar.ButtonItem
        Me.Bar1 = New DevComponents.DotNetBar.Bar
        Me.lbiConnections = New DevComponents.DotNetBar.LabelItem
        Me.RibbonControl1.SuspendLayout()
        Me.RibbonPanel1.SuspendLayout()
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl1
        '
        Me.RibbonControl1.CaptionVisible = True
        Me.RibbonControl1.Controls.Add(Me.RibbonPanel1)
        Me.RibbonControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RibbonControl1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.RibbonTabItem1})
        Me.RibbonControl1.KeyTipsFont = New System.Drawing.Font("Tahoma", 7.0!)
        Me.RibbonControl1.Location = New System.Drawing.Point(4, 1)
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.RibbonControl1.QuickToolbarItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.Office2007StartButton1})
        Me.RibbonControl1.Size = New System.Drawing.Size(736, 154)
        Me.RibbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.RibbonControl1.TabGroupHeight = 14
        Me.RibbonControl1.TabIndex = 0
        Me.RibbonControl1.Text = "RibbonControl1"
        '
        'RibbonPanel1
        '
        Me.RibbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.RibbonPanel1.Controls.Add(Me.RibbonBar4)
        Me.RibbonPanel1.Controls.Add(Me.RibbonBar3)
        Me.RibbonPanel1.Controls.Add(Me.RibbonBar2)
        Me.RibbonPanel1.Controls.Add(Me.RibbonBar1)
        Me.RibbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanel1.Location = New System.Drawing.Point(0, 55)
        Me.RibbonPanel1.Name = "RibbonPanel1"
        Me.RibbonPanel1.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.RibbonPanel1.Size = New System.Drawing.Size(736, 97)
        Me.RibbonPanel1.TabIndex = 1
        '
        'RibbonBar4
        '
        Me.RibbonBar4.AutoOverflowEnabled = True
        Me.RibbonBar4.Dock = System.Windows.Forms.DockStyle.Left
        Me.RibbonBar4.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.biCascade, Me.biHorizontal, Me.biVertical})
        Me.RibbonBar4.Location = New System.Drawing.Point(439, 0)
        Me.RibbonBar4.Name = "RibbonBar4"
        Me.RibbonBar4.Size = New System.Drawing.Size(162, 94)
        Me.RibbonBar4.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.RibbonBar4.TabIndex = 5
        Me.RibbonBar4.Text = "Windows"
        '
        'biCascade
        '
        Me.biCascade.Checked = True
        Me.biCascade.Image = CType(resources.GetObject("biCascade.Image"), System.Drawing.Image)
        Me.biCascade.ImagePaddingHorizontal = 8
        Me.biCascade.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.biCascade.Name = "biCascade"
        Me.biCascade.OptionGroup = "Windows"
        Me.biCascade.SubItemsExpandWidth = 14
        Me.biCascade.Text = "Cascade"
        '
        'biHorizontal
        '
        Me.biHorizontal.Image = CType(resources.GetObject("biHorizontal.Image"), System.Drawing.Image)
        Me.biHorizontal.ImagePaddingHorizontal = 8
        Me.biHorizontal.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.biHorizontal.Name = "biHorizontal"
        Me.biHorizontal.OptionGroup = "Windows"
        Me.biHorizontal.SubItemsExpandWidth = 14
        Me.biHorizontal.Text = "Horizontal"
        '
        'biVertical
        '
        Me.biVertical.Image = CType(resources.GetObject("biVertical.Image"), System.Drawing.Image)
        Me.biVertical.ImagePaddingHorizontal = 8
        Me.biVertical.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.biVertical.Name = "biVertical"
        Me.biVertical.OptionGroup = "Windows"
        Me.biVertical.SubItemsExpandWidth = 14
        Me.biVertical.Text = "Vertical"
        '
        'RibbonBar3
        '
        Me.RibbonBar3.AutoOverflowEnabled = True
        Me.RibbonBar3.Dock = System.Windows.Forms.DockStyle.Left
        Me.RibbonBar3.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ItemContainer4})
        Me.RibbonBar3.Location = New System.Drawing.Point(314, 0)
        Me.RibbonBar3.Name = "RibbonBar3"
        Me.RibbonBar3.Size = New System.Drawing.Size(125, 94)
        Me.RibbonBar3.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.RibbonBar3.TabIndex = 4
        Me.RibbonBar3.Text = "View"
        '
        'ItemContainer4
        '
        Me.ItemContainer4.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.ItemContainer4.MinimumSize = New System.Drawing.Size(120, 0)
        Me.ItemContainer4.Name = "ItemContainer4"
        Me.ItemContainer4.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.biShowRS, Me.cboDatabases})
        Me.ItemContainer4.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle
        '
        'biShowRS
        '
        Me.biShowRS.AutoCheckOnClick = True
        Me.biShowRS.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.biShowRS.Enabled = False
        Me.biShowRS.Image = CType(resources.GetObject("biShowRS.Image"), System.Drawing.Image)
        Me.biShowRS.ImagePaddingHorizontal = 8
        Me.biShowRS.KeyTips = "G"
        Me.biShowRS.Name = "biShowRS"
        Me.biShowRS.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlR)
        Me.biShowRS.SubItemsExpandWidth = 14
        Me.biShowRS.Text = "Result"
        Me.biShowRS.Tooltip = "Ctrl + R"
        '
        'cboDatabases
        '
        Me.cboDatabases.DropDownHeight = 106
        Me.cboDatabases.Enabled = False
        Me.cboDatabases.Name = "cboDatabases"
        '
        'RibbonBar2
        '
        Me.RibbonBar2.AutoOverflowEnabled = True
        Me.RibbonBar2.Dock = System.Windows.Forms.DockStyle.Left
        Me.RibbonBar2.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.biNewScript, Me.ItemContainer3, Me.biRun})
        Me.RibbonBar2.Location = New System.Drawing.Point(121, 0)
        Me.RibbonBar2.Name = "RibbonBar2"
        Me.RibbonBar2.Size = New System.Drawing.Size(193, 94)
        Me.RibbonBar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.RibbonBar2.TabIndex = 1
        Me.RibbonBar2.Text = "Script"
        '
        'biNewScript
        '
        Me.biNewScript.Enabled = False
        Me.biNewScript.Image = CType(resources.GetObject("biNewScript.Image"), System.Drawing.Image)
        Me.biNewScript.ImagePaddingHorizontal = 8
        Me.biNewScript.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.biNewScript.Name = "biNewScript"
        Me.biNewScript.RibbonWordWrap = False
        Me.biNewScript.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlN)
        Me.biNewScript.SubItemsExpandWidth = 14
        Me.biNewScript.Text = "&New Script"
        Me.biNewScript.Tooltip = "Ctrl + N"
        '
        'ItemContainer3
        '
        Me.ItemContainer3.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.ItemContainer3.MinimumSize = New System.Drawing.Size(0, 0)
        Me.ItemContainer3.Name = "ItemContainer3"
        Me.ItemContainer3.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.biOpen, Me.biClose, Me.biCloseAll})
        '
        'biOpen
        '
        Me.biOpen.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.biOpen.Enabled = False
        Me.biOpen.Image = CType(resources.GetObject("biOpen.Image"), System.Drawing.Image)
        Me.biOpen.ImagePaddingHorizontal = 8
        Me.biOpen.Name = "biOpen"
        Me.biOpen.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlO)
        Me.biOpen.Text = "&Open Script"
        Me.biOpen.Tooltip = "Ctrl + O"
        '
        'biClose
        '
        Me.biClose.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.biClose.Enabled = False
        Me.biClose.Image = CType(resources.GetObject("biClose.Image"), System.Drawing.Image)
        Me.biClose.ImagePaddingHorizontal = 8
        Me.biClose.Name = "biClose"
        Me.biClose.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlF4)
        Me.biClose.Text = "Clo&se"
        Me.biClose.Tooltip = "Ctrl + F4"
        '
        'biCloseAll
        '
        Me.biCloseAll.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.biCloseAll.Enabled = False
        Me.biCloseAll.Image = CType(resources.GetObject("biCloseAll.Image"), System.Drawing.Image)
        Me.biCloseAll.ImagePaddingHorizontal = 8
        Me.biCloseAll.Name = "biCloseAll"
        Me.biCloseAll.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlShiftF4)
        Me.biCloseAll.Text = "Close &All"
        Me.biCloseAll.Tooltip = "Ctrl + Shift + F4"
        '
        'biRun
        '
        Me.biRun.Enabled = False
        Me.biRun.Image = CType(resources.GetObject("biRun.Image"), System.Drawing.Image)
        Me.biRun.ImagePaddingHorizontal = 8
        Me.biRun.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.biRun.Name = "biRun"
        Me.biRun.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F5)
        Me.biRun.SubItemsExpandWidth = 14
        Me.biRun.Text = "&Run"
        Me.biRun.Tooltip = "F5"
        '
        'RibbonBar1
        '
        Me.RibbonBar1.AutoOverflowEnabled = True
        Me.RibbonBar1.Dock = System.Windows.Forms.DockStyle.Left
        Me.RibbonBar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.biConnect, Me.biDisconnect})
        Me.RibbonBar1.Location = New System.Drawing.Point(3, 0)
        Me.RibbonBar1.Name = "RibbonBar1"
        Me.RibbonBar1.Size = New System.Drawing.Size(118, 94)
        Me.RibbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.RibbonBar1.TabIndex = 0
        Me.RibbonBar1.Text = "Connection"
        '
        'biConnect
        '
        Me.biConnect.Image = CType(resources.GetObject("biConnect.Image"), System.Drawing.Image)
        Me.biConnect.ImagePaddingHorizontal = 8
        Me.biConnect.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.biConnect.Name = "biConnect"
        Me.biConnect.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlShiftO)
        Me.biConnect.SubItemsExpandWidth = 14
        Me.biConnect.Text = "&Connect"
        Me.biConnect.Tooltip = "Ctrl + Shift + O"
        '
        'biDisconnect
        '
        Me.biDisconnect.Enabled = False
        Me.biDisconnect.Image = CType(resources.GetObject("biDisconnect.Image"), System.Drawing.Image)
        Me.biDisconnect.ImagePaddingHorizontal = 8
        Me.biDisconnect.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.biDisconnect.Name = "biDisconnect"
        Me.biDisconnect.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlShiftD)
        Me.biDisconnect.SubItemsExpandWidth = 14
        Me.biDisconnect.Text = "&Disconnect"
        Me.biDisconnect.Tooltip = "Ctrl + Shift + D"
        '
        'RibbonTabItem1
        '
        Me.RibbonTabItem1.Checked = True
        Me.RibbonTabItem1.ImagePaddingHorizontal = 8
        Me.RibbonTabItem1.Name = "RibbonTabItem1"
        Me.RibbonTabItem1.Panel = Me.RibbonPanel1
        Me.RibbonTabItem1.Text = "&Home"
        '
        'Office2007StartButton1
        '
        Me.Office2007StartButton1.AutoExpandOnClick = True
        Me.Office2007StartButton1.CanCustomize = False
        Me.Office2007StartButton1.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image
        Me.Office2007StartButton1.Image = CType(resources.GetObject("Office2007StartButton1.Image"), System.Drawing.Image)
        Me.Office2007StartButton1.ImagePaddingHorizontal = 2
        Me.Office2007StartButton1.ImagePaddingVertical = 2
        Me.Office2007StartButton1.Name = "Office2007StartButton1"
        Me.Office2007StartButton1.ShowSubItems = False
        Me.Office2007StartButton1.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ItemContainer1})
        Me.Office2007StartButton1.Text = "&File"
        '
        'ItemContainer1
        '
        '
        '
        '
        Me.ItemContainer1.BackgroundStyle.Class = "RibbonFileMenuContainer"
        Me.ItemContainer1.MinimumSize = New System.Drawing.Size(0, 0)
        Me.ItemContainer1.Name = "ItemContainer1"
        Me.ItemContainer1.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ItemContainer2})
        '
        'ItemContainer2
        '
        '
        '
        '
        Me.ItemContainer2.BackgroundStyle.Class = "RibbonFileMenuColumnOneContainer"
        Me.ItemContainer2.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.ItemContainer2.MinimumSize = New System.Drawing.Size(180, 0)
        Me.ItemContainer2.Name = "ItemContainer2"
        Me.ItemContainer2.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.biAbout, Me.biHelp, Me.biRestart, Me.biExit})
        '
        'biAbout
        '
        Me.biAbout.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.biAbout.Image = CType(resources.GetObject("biAbout.Image"), System.Drawing.Image)
        Me.biAbout.ImagePaddingHorizontal = 15
        Me.biAbout.Name = "biAbout"
        Me.biAbout.Text = "&About"
        '
        'biHelp
        '
        Me.biHelp.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.biHelp.Image = CType(resources.GetObject("biHelp.Image"), System.Drawing.Image)
        Me.biHelp.ImagePaddingHorizontal = 15
        Me.biHelp.Name = "biHelp"
        Me.biHelp.Text = "&Help"
        '
        'biRestart
        '
        Me.biRestart.BeginGroup = True
        Me.biRestart.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.biRestart.Image = CType(resources.GetObject("biRestart.Image"), System.Drawing.Image)
        Me.biRestart.ImagePaddingHorizontal = 15
        Me.biRestart.Name = "biRestart"
        Me.biRestart.Text = "&Restart"
        '
        'biExit
        '
        Me.biExit.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.biExit.Image = CType(resources.GetObject("biExit.Image"), System.Drawing.Image)
        Me.biExit.ImagePaddingHorizontal = 15
        Me.biExit.Name = "biExit"
        Me.biExit.Text = "E&xit"
        '
        'Bar1
        '
        Me.Bar1.BarType = DevComponents.DotNetBar.eBarType.StatusBar
        Me.Bar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Bar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.lbiConnections})
        Me.Bar1.Location = New System.Drawing.Point(4, 474)
        Me.Bar1.Name = "Bar1"
        Me.Bar1.RoundCorners = False
        Me.Bar1.Size = New System.Drawing.Size(736, 26)
        Me.Bar1.Stretch = True
        Me.Bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Bar1.TabIndex = 2
        Me.Bar1.TabStop = False
        Me.Bar1.Text = "Bar1"
        '
        'lbiConnections
        '
        Me.lbiConnections.Name = "lbiConnections"
        Me.lbiConnections.PaddingBottom = 3
        Me.lbiConnections.PaddingLeft = 3
        Me.lbiConnections.PaddingTop = 6
        Me.lbiConnections.Text = "0 connections"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(744, 502)
        Me.Controls.Add(Me.Bar1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "frmMain"
        Me.Text = "Query Analyzer Emulator"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.RibbonControl1.ResumeLayout(False)
        Me.RibbonControl1.PerformLayout()
        Me.RibbonPanel1.ResumeLayout(False)
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RibbonControl1 As DevComponents.DotNetBar.RibbonControl
    Friend WithEvents RibbonPanel1 As DevComponents.DotNetBar.RibbonPanel
    Friend WithEvents RibbonBar1 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents RibbonTabItem1 As DevComponents.DotNetBar.RibbonTabItem
    Friend WithEvents Office2007StartButton1 As DevComponents.DotNetBar.Office2007StartButton
    Friend WithEvents ItemContainer1 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents ItemContainer2 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents biAbout As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents biHelp As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents biRestart As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents biExit As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents biConnect As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents biDisconnect As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents RibbonBar2 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents biNewScript As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ItemContainer3 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents biOpen As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents biClose As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents biCloseAll As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents biRun As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Bar1 As DevComponents.DotNetBar.Bar
    Friend WithEvents lbiConnections As DevComponents.DotNetBar.LabelItem
    Friend WithEvents RibbonBar3 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents ItemContainer4 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents biShowRS As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cboDatabases As DevComponents.DotNetBar.ComboBoxItem
    Friend WithEvents RibbonBar4 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents biCascade As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents biHorizontal As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents biVertical As DevComponents.DotNetBar.ButtonItem

End Class
