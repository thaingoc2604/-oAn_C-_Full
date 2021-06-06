Public Class frmMsgOK
    Public Function HienThi(ByVal LoiNhac As String, ByVal TieuDe As String, Optional ByVal IconInfomation As Boolean = True) As System.Windows.Forms.DialogResult
        Me.lblloiNhac.Text = LoiNhac
        If Me.lblloiNhac.Text.Length > 40 Then
            Me.lblloiNhac.Text = Me.lblloiNhac.Text.Insert(40, Chr(10))
        End If
        Me.Text = TieuDe
        If IconInfomation = False Then
            picInfomation.Visible = False
            picStop.Visible = True
        Else
            picInfomation.Visible = True
            picStop.Visible = False
        End If
        Return Me.ShowDialog()
    End Function
End Class
