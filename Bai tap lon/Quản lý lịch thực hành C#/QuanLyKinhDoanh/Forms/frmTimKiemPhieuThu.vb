Public Class frmTimKiemPhieuThu

    Private Sub rdoMaPT_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdoMaPT.Click
        'Xóa dữ liệu cũ trong combobox
        Me.cboGiaTriTimKiem.DataSource = Nothing
        'Tạo nguồn dữ liệu cho combobox
        objConnect.SetDataCombobox(Me.cboGiaTriTimKiem, "Select MaPT From tblPhieuThu Order by MaPT")
        Me.cboGiaTriTimKiem.SelectedIndex = -1
    End Sub

    Private Sub rdoNgayPT_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdoNgayPT.Click
        'Xóa dữ liệu cũ trong combobox
        Me.cboGiaTriTimKiem.DataSource = Nothing
        'Tạo nguồn dữ liệu cho combobox
        objConnect.SetDataCombobox(Me.cboGiaTriTimKiem, "Select NgayPT From tblPhieuThu Order by NgayPT")
        Me.cboGiaTriTimKiem.SelectedIndex = -1
    End Sub

    Private Sub rdoNhanVien_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdoNhanVien.Click
        'Xóa dữ liệu cũ trong combobox
        Me.cboGiaTriTimKiem.DataSource = Nothing
        'Tạo nguồn dữ liệu cho combobox
        objConnect.SetDataCombobox(Me.cboGiaTriTimKiem, "Select MaNV From tblPhieuThu Order by MaNV")
        Me.cboGiaTriTimKiem.SelectedIndex = -1
    End Sub

    Private Sub rdoHDBH_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdoHDBH.Click
        'Xóa dữ liệu cũ trong combobox
        Me.cboGiaTriTimKiem.DataSource = Nothing
        'Tạo nguồn dữ liệu cho combobox
        objConnect.SetDataCombobox(Me.cboGiaTriTimKiem, "Select MaHDBH From tblPhieuThu Order by MaHDBH")
        Me.cboGiaTriTimKiem.SelectedIndex = -1
    End Sub

    Private Sub btnHuyBo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnHuyBo.Click
        Me.Close()
    End Sub

    Private Sub btnTimKiem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTimKiem.Click
        Dim strSQL As String
        strSQL = "Select MaPT,NgayPT,MaHDBH,SoTien,TenKH,HoTen,NguoiNop,LyDoThu,KemTheoChungTu,MaKH,MaNV From View_DS_PhieuThu "
        If Me.rdoMaPT.Checked = True Then
            strSQL &= "Where MaPT like N'%" & Me.cboGiaTriTimKiem.Text & "%' Order by NgayPT DESC"
        End If
        Dim Date1, Date2 As Date
        Date1 = Date.FromOADate(1 / 1 / 1900)
        Date2 = Date.FromOADate(1 / 1 / 1900)
        Try
            Date2 = CDate(Me.cboGiaTriTimKiem.Text)
        Catch ex As Exception

        End Try
        If Me.rdoNgayPT.Checked = True Then

            strSQL &= "Where DateDiff(d,'01/01/1900',NgayPT) Like N'%" & DateDiff(DateInterval.Day, Date1, Date2) - 1 & "%' Order by NgayPT DESC"
        End If
        If Me.rdoNhanVien.Checked = True Then
            strSQL &= "Where MaNV Like N'%" & Me.cboGiaTriTimKiem.Text & "%' Order by NgayPT DESC"
        End If

        If Me.rdoHDBH.Checked = True Then
            strSQL &= "Where MaHDBH Like N'%" & Me.cboGiaTriTimKiem.Text & "%' Order by NgayPT DESC"
        End If
        If Me.cboGiaTriTimKiem.Text.Trim = "" Then
            frmMsgOK.HienThi("Bạn chưa nhập giá trị tìm kiếm", "Thông báo", False)
            Me.cboGiaTriTimKiem.Focus()
        Else
            frmMainX.LoadData(7, strSQL)
            Me.Close()
        End If
    End Sub

    Private Sub frmTimKiemPhieuThu_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub
End Class