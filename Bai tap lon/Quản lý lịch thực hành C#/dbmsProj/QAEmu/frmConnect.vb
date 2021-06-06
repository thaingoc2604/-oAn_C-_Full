Imports System.ServiceProcess
Imports System.Data.SqlClient
Imports System.IO
Imports DevComponents.DotNetBar

Public Class frmConnect
    Dim iOpener As frmMain

    Public Sub New(ByVal nOpener As frmMain)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        iOpener = nOpener
    End Sub

    Private Sub frmConnect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadConfig()
    End Sub

    Private Sub chkIntegrated_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkIntegrated.CheckedChanged
        txtUID.Enabled = Not chkIntegrated.Checked
        txtPassword.Enabled = Not chkIntegrated.Checked
    End Sub

    Private Sub btnConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnect.Click
        Me.Cursor = Cursors.WaitCursor

        Dim CnStr As String = ""
        Dim server As String = cboServer.Text
        If chkStartService.Checked AndAlso (server = "." Or server = "(local)") Then
            Dim ServiceName As String = "MSSQLSERVER"
            Try
                Dim controller As New ServiceController(ServiceName)
                If controller.Status = ServiceControllerStatus.Stopped Then
                    controller.Start()
                    controller.WaitForStatus(ServiceControllerStatus.Running)
                End If
            Catch ex As Exception
                globalData.ShowMsg(ex.Message)
                Me.Cursor = Cursors.Default
                Return
            End Try
        End If

        Dim uid As String = txtUID.Text
        Dim pwd As String = txtPassword.Text
        Dim integrated As Boolean = chkIntegrated.Checked
        CnStr &= "Server=" & server & ";"
        If Not integrated Then
            CnStr &= "UID=" & uid & ";"
            CnStr &= "PWD=" & pwd & ";"
        Else
            CnStr &= "Integrated Security=SSPI;"
        End If

        Dim Cn As New SqlConnection(CnStr)
        Try
            Cn.Open()
        Catch ex As Exception
            globalData.ShowMsg(ex.Message, True)
            Me.Cursor = Cursors.Default
            Return
        End Try

        Cn.Close()
        Cn.Dispose()

        iOpener.CnStr = CnStr
        SaveConfig(server, uid, integrated)

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub cboServer_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboServer.KeyDown, txtUID.KeyDown, txtPassword.KeyDown
        If e.KeyData = Keys.Enter Then btnConnect_Click(sender, e)
    End Sub

#Region "Code"
    Private Sub LoadConfig()
        Dim configPath As String = Application.StartupPath & "\ConfigInfo.xml"
        If File.Exists(configPath) Then
            Dim dt As New DataTable
            Try
                dt.ReadXml(configPath)
                If dt Is Nothing OrElse dt.Rows.Count = 0 Then Throw New Exception("Load config file failed")
                cboServer.Text = dt.Rows(0)("Server")
                chkIntegrated.Checked = dt.Rows(0)("Integrated")
                txtUID.Text = dt.Rows(0)("UID")
            Catch ex As Exception
                globalData.ShowMsg(ex.Message, True)
            End Try
        End If
    End Sub

    Private Sub SaveConfig(ByVal server As String, ByVal uid As String, ByVal integrated As Boolean)
        Dim configPath As String = Application.StartupPath & "\ConfigInfo.xml"
        If File.Exists(configPath) Then File.Delete(configPath)
        Dim dt As New DataTable("LoginInfo")
        dt.Columns.Add("Server")
        dt.Columns.Add("UID")
        dt.Columns.Add("Integrated")
        Dim row As DataRow = dt.NewRow
        row("Server") = server
        row("UID") = uid
        row("Integrated") = integrated
        dt.Rows.Add(row)
        Try            
            dt.WriteXml(configPath, XmlWriteMode.WriteSchema)
        Catch ex As Exception
            globalData.ShowMsg(ex.Message, True)
        End Try
    End Sub
#End Region

End Class