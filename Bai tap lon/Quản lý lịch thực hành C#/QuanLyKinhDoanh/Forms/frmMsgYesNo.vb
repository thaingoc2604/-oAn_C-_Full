Public Class frmMsgYesNo
    Public Function HienThi(ByVal LoiNhac As String, ByVal TieuDe As String, Optional ByVal IconQuestion As Boolean = True) As System.Windows.Forms.DialogResult
        Me.lblLoiNhac.Text = LoiNhac
        If Me.lblLoiNhac.Text.Length > 40 Then
            Me.lblLoiNhac.Text = Me.lblLoiNhac.Text.Insert(40, Chr(10))
        End If
        Me.Text = TieuDe
        If IconQuestion = True Then
            Me.picQuestion.Visible = True
            Me.picWarning.Visible = False
        Else
            Me.picQuestion.Visible = False
            Me.picWarning.Visible = True
        End If
        Return Me.ShowDialog()
    End Function

    Private Sub btnKhong_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnKhong.Click
        Me.Dispose()
    End Sub
End Class