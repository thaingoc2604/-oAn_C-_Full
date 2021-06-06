Public Class frmLogin

    Private Sub frmLogin_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub btnThoat_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        Application.Exit()
    End Sub

    Private Sub btnDangNhap_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDangNhap.Click
        If NhapLieu.ChuaDuThongTin("NN", ErrorProvider) Then
            frmMsgOK.HienThi("Thông tin bạn nhập vào chưa đủ", "Thông báo", False)
        Else
            Dim blnOk As Boolean
            blnOk = objConnect.DaTonTai("Select * From Sys_NSD Where NSD =N'" & Me.txtUser.Text.Trim.ToLower & "' And MatKhau =N'" & Me.txtPass.Text.Trim & "'")
            If blnOk = False Then
                frmMsgOK.HienThi("Vui lòng kiểm tra lại tên người sử dụng  hoặc mật khẩu", "Thông báo")
            Else
                objConnect.RunSQL("Update Sys_NSD Set Active='0'")
                objConnect.RunSQL("Update Sys_NSD Set Active='1' Where NSD=N'" & Me.txtUser.Text.Trim & "'")
                pMaNV = Me.txtUser.Text
                Dim strSQL As String = "Select MaNV,HoTen From tblNhanVien Where MaNV=N'" & Me.txtUser.Text.Trim & "'"
                Dim DT As New DataTable
                If objConnect.DaTonTai(strSQL) = False Then
                    pTenNV = Me.txtUser.Text.Trim
                Else
                    DT = objConnect.GetDataTable(strSQL)
                    pTenNV = DT(0)(1).ToString
                End If
                Me.Hide()
                frmSplashScreen.Timer1.Start()
                frmSplashScreen.ShowDialog()
                frmSplashScreen.ShowInTaskbar = False
            End If
        End If
    End Sub

    Private Sub frmLogin_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyValue = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub frmLogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.KeyPreview = True
    End Sub
End Class