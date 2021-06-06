Imports System.IO
Imports System.Threading
Public Class frmSplashScreen

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Me.picProgress.Width <= Me.picLen.Width Then
            Me.picProgress.Width = Me.picProgress.Width + Int(picLen.Width / 500)
            Me.lblPhanTran.Text = Int((Me.picProgress.Width / Me.picLen.Width) * 100) & " %"
        Else
            Me.Timer1.Stop()
            Me.Close()
            frmMainX.Show()
        End If
    End Sub

    
End Class