Public Class frmThemNhanVien

    Private Sub btnThemTinhTP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThemTinhTP.Click
        pThem = True
        frmTinhTP.ShowDialog()
        frmTinhTP.ShowInTaskbar = False
    End Sub

    Private Sub btnThemBP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThemBP.Click
        pThem = True
        frmBoPhan.ShowDialog()
        frmBoPhan.ShowInTaskbar = False
    End Sub

    Private Sub btnThemCV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThemCV.Click
        pThem = True
        frmChucVu.ShowDialog()
        frmChucVu.ShowInTaskbar = False
    End Sub
End Class