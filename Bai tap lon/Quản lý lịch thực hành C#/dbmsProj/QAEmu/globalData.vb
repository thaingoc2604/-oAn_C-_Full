Imports DevComponents.DotNetBar

Module globalData
    Public Sub ShowMsg(ByVal msg As String, Optional ByVal err As Boolean = False)
        Dim icon As MessageBoxIcon = MessageBoxIcon.Information
        If err Then icon = MessageBoxIcon.Exclamation
        MessageBoxEx.Show(msg, "Query Analyzer Emulator", MessageBoxButtons.OK, icon)
    End Sub
End Module
