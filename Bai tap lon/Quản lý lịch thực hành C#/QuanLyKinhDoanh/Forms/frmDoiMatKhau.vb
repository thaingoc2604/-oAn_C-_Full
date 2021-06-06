Public Class frmDoiMatKhau

    Private Sub frmDoiMatKhau_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmDoiMatKhau_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.txtMaNV.Text = pMaNV
    End Sub

    Private Sub btnDoi_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDoi.Click
        If NhapLieu.ChuaDuThongTin("NN", ErrorProvider) = True Then
            frmMsgOK.HienThi("Thông tin bạn nhập vào chưa hợp lệ", "Thông báo")
        Else
            If objConnect.DaTonTai("Select * From sys_NSD Where NSD=N'" & Me.txtMaNV.Text.Trim & "' And MatKhau=N'" & Me.txtMatKhau.Text.Trim & "'") = True Then
                If Me.txtMatKhauMoi.Text.Trim = Me.txtNhacLai.Text.Trim Then
                    objConnect.RunSQL("Update sys_NSD Set MatKhau=N'" & Me.txtMatKhauMoi.Text.Trim & "'")
                    Me.Close()
                Else
                    frmMsgOK.HienThi("Mật khẩu mới không hợp lệ", "Thông báo", False)
                    Me.txtNhacLai.Focus()

                End If
            Else
                frmMsgOK.HienThi("không đúng mật khẩu", "Thông báo", False)
                Me.txtMatKhau.Focus()
            End If
        End If
    End Sub

    Private Sub btnThoat_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub
End Class