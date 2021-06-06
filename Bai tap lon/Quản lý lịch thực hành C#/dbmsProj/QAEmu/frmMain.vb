Imports System.Data.SqlClient

Public Class frmMain
    Dim iCnStr As String

    Public Property CnStr() As String
        Get
            Return iCnStr
        End Get
        Set(ByVal value As String)
            iCnStr = value
        End Set
    End Property

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim f As New frmConnect(Me)
        If f.ShowDialog() = Windows.Forms.DialogResult.OK Then
            GetDatabases()
            biNewScript_Click(sender, e)
        End If
    End Sub

    Private Sub biNewScript_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles biNewScript.Click
        Me.Cursor = Cursors.WaitCursor
        Dim f As New frmDocument(Me, cboDatabases.SelectedItem)
        f.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub biShowRS_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles biShowRS.Click
        Me.Cursor = Cursors.WaitCursor
        Dim child As frmDocument = Me.ActiveMdiChild
        child.splBottom.Expanded = biShowRS.Checked
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub frmMain_MdiChildActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MdiChildActivate
        Me.Cursor = Cursors.WaitCursor
        Dim child As frmDocument = Me.ActiveMdiChild
        If child IsNot Nothing Then            
            'Result item status
            biShowRS.Checked = child.splBottom.Expanded
            'Selected database
            cboDatabases.SelectedItem = child.Database
            'Run item status
            biRun.Enabled = child.Status
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub biConnect_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles biConnect.Click
        Me.Cursor = Cursors.WaitCursor
        Dim f As New frmConnect(Me)
        If f.ShowDialog() = Windows.Forms.DialogResult.OK Then
            GetDatabases()
            biNewScript_Click(sender, e)
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub biClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles biClose.Click
        Me.Cursor = Cursors.WaitCursor
        Me.ActiveMdiChild.Close()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub biCloseAll_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles biCloseAll.Click, biDisconnect.Click
        Me.Cursor = Cursors.WaitCursor
        For Each f As Form In Me.MdiChildren
            f.Close()
        Next
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub biCascade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles biCascade.Click
        Me.Cursor = Cursors.WaitCursor
        Me.LayoutMdi(MdiLayout.Cascade)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub biHorizontal_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles biHorizontal.Click
        Me.Cursor = Cursors.WaitCursor
        Me.LayoutMdi(MdiLayout.TileHorizontal)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub biVertical_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles biVertical.Click
        Me.Cursor = Cursors.WaitCursor
        Me.LayoutMdi(MdiLayout.TileVertical)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub cboDatabases_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDatabases.Click
        Me.Cursor = Cursors.WaitCursor
        Dim f As frmDocument = Me.ActiveMdiChild
        If f IsNot Nothing Then f.Database = cboDatabases.SelectedItem
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub cboDatabases_ExpandChange(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDatabases.ExpandChange
        If cboDatabases.Expanded Then
            Me.Cursor = Cursors.WaitCursor
            cboDatabases.Items.Clear()
            Dim f As frmDocument = Me.ActiveMdiChild
            If f IsNot Nothing Then GetDatabases(f.Database)
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub biRun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles biRun.Click
        Dim child As frmDocument = Me.ActiveMdiChild        
        child.RunScript()
    End Sub

    Private Sub biHelp_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles biHelp.Click
        Me.Cursor = Cursors.WaitCursor
        globalData.ShowMsg("Comming soon...")
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub biExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles biExit.Click
        Application.Exit()
    End Sub

    Private Sub biRestart_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles biRestart.Click
        Application.Restart()
    End Sub

    Private Sub biOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles biOpen.Click
        Me.Cursor = Cursors.WaitCursor
        Dim dlg As New OpenFileDialog
        dlg.Filter = "Script files (*.sql)|*.sql|All files|*.*"
        dlg.FilterIndex = 0
        dlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim child As frmDocument = Me.ActiveMdiChild
            child.OpenScript(dlg.FileName)
        End If
        Me.Cursor = Cursors.Default
    End Sub


#Region "Code"
    Private Sub GetDatabases(Optional ByVal selected As String = "")
        Dim Cn As New SqlConnection(iCnStr)
        Cn.Open()
        Dim dt As DataTable = Cn.GetSchema("Databases")
        For Each row As DataRow In dt.Rows
            cboDatabases.Items.Add(row("DATABASE_NAME"))
        Next
        Cn.Close()
        Cn.Dispose()

        If selected = "" Then
            cboDatabases.SelectedIndex = 0
        Else
            cboDatabases.SelectedItem = selected
        End If
    End Sub
#End Region
            
End Class
