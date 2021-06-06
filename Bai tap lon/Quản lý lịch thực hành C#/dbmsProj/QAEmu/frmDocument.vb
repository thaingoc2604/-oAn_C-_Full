Imports System.Data.SqlClient
Imports System.IO
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls

Public Enum ScriptStatus
    Running = False
    Ready = True
End Enum

Public Class frmDocument
    Dim iDatabase As String
    Dim iStatus As ScriptStatus

    Public Property Database() As String
        Get
            Return iDatabase
        End Get
        Set(ByVal value As String)
            iDatabase = value
            Me.Text = "Query - " & iDatabase
        End Set
    End Property

    Public ReadOnly Property Status() As ScriptStatus
        Get
            Return iStatus
        End Get
    End Property

    Public Sub New(ByVal nParent As frmMain, ByVal nDatabase As String)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.MdiParent = nParent
        Me.Database = nDatabase
        iStatus = ScriptStatus.Ready
    End Sub

    Private Sub frmDocument_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        CountCn(1)
        EnDisControls(1)
        ClearDBs()
    End Sub

    Private Sub frmDocument_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CountCn()
        EnDisControls()
    End Sub

#Region "Code"
    Private Sub CountCn(Optional ByVal close As Integer = 0)
        Dim f As frmMain = TryCast(Me.MdiParent, frmMain)
        Dim n As Integer = f.MdiChildren.Length - close
        f.lbiConnections.Text = n & " connections"
    End Sub

    Private Sub EnDisControls(Optional ByVal close As Integer = 0)
        Dim state As Boolean = False
        Dim f As frmMain = TryCast(Me.MdiParent, frmMain)
        If f.MdiChildren.Length - close > 0 Then state = True
        f.biConnect.Enabled = Not state
        f.biDisconnect.Enabled = state
        f.biNewScript.Enabled = state
        f.biOpen.Enabled = state
        f.biClose.Enabled = state
        f.biCloseAll.Enabled = state
        f.biRun.Enabled = state
        f.biShowRS.Enabled = state
        f.cboDatabases.Enabled = state
    End Sub

    Private Sub ClearDBs()
        Dim f As frmMain = TryCast(Me.MdiParent, frmMain)
        If f.MdiChildren.Length - 1 = 0 Then
            f.cboDatabases.Items.Clear()
        End If
    End Sub

    Public Sub RunScript()
        iStatus = ScriptStatus.Running

        tcGrids.Tabs.Clear()

        Dim CnStr As String = BuildCnStr()
        Dim cmdText As String = txtScript.SelectedText
        If cmdText = "" Then cmdText = txtScript.Text
        Dim ds As New DataSet
        Try
            Dim Cn As New SqlConnection(CnStr)
            Dim da As New SqlDataAdapter(cmdText, Cn)
            da.Fill(ds)
        Catch ex As Exception
            tcBottom.SelectedTabIndex = 0
            txtMessages.Text = ex.Message
            iStatus = ScriptStatus.Ready
            Return
        End Try

        tcBottom.SelectedTabIndex = 0
        txtMessages.Text = "Command(s) complete successfully"
        If ds.Tables.Count > 0 Then
            tabGrids.Visible = True
            tcBottom.SelectedTabIndex = 1
            For Each dt As DataTable In ds.Tables
                Dim grid As New DataGridViewX
                grid.AllowUserToAddRows = False
                grid.AllowUserToDeleteRows = False
                grid.AllowUserToResizeRows = False
                grid.ReadOnly = True
                grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                grid.RowHeadersWidth = 25
                grid.Dock = DockStyle.Fill
                grid.DataSource = dt

                Dim tab As TabItem = tcGrids.CreateTab(dt.TableName)
                tab.AttachedControl.Controls.Add(grid)
            Next
        End If

        txtScript.Focus()
        iStatus = ScriptStatus.Ready
    End Sub

    Private Function BuildCnStr() As String
        Dim f As frmMain = Me.MdiParent
        Dim CnStr As String = f.CnStr
        CnStr &= "Database=" & iDatabase & ";"
        Return CnStr
    End Function

    Public Sub OpenScript(ByVal SQLScriptPath As String)
        Dim fs As New StreamReader(SQLScriptPath, System.Text.Encoding.Unicode)
        While Not fs.EndOfStream
            Dim ln As String = fs.ReadLine
            If ln.Trim.ToLower() = "go" Then ln = "--GO"
            ln &= vbCrLf
            txtScript.AppendText(ln)
        End While
        fs.Close()
        fs.Dispose()
    End Sub
#End Region

End Class