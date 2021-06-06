Public Class frmTimKiemHoaDonBanHang
    Private Sub rdoMaHD_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdoMaHD.Click
        'Xóa dữ liệu cũ trong combobox
        Me.cboGiaTriTimKiem.DataSource = Nothing
        'Tạo nguồn dữ liệu cho combobox
        objConnect.SetDataCombobox(Me.cboGiaTriTimKiem, "Select MaHDBH From tblHoaDonBanHang Order by MaHDBH")
        Me.cboGiaTriTimKiem.SelectedIndex = -1
    End Sub


    Private Sub rdoNgayHD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoNgayHD.Click
        'Xóa dữ liệu cũ trong combobox
        Me.cboGiaTriTimKiem.DataSource = Nothing
        'Tạo nguồn dữ liệu cho combobox
        objConnect.SetDataCombobox(Me.cboGiaTriTimKiem, "Select NgayHDBH From tblHoaDonBanHang Order by NgayHDBH")
        Me.cboGiaTriTimKiem.SelectedIndex = -1
    End Sub

    Private Sub rdoNhanVien_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoNhanVien.CheckedChanged
        'Xóa dữ liệu cũ trong combobox
        Me.cboGiaTriTimKiem.DataSource = Nothing
        'Tạo nguồn dữ liệu cho combobox
        objConnect.SetDataCombobox(Me.cboGiaTriTimKiem, "Select HoTen From tblNhanVien Order by HoTen")
        Me.cboGiaTriTimKiem.SelectedIndex = -1
    End Sub


    Private Sub rdoKhachHang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoKhachHang.Click
        'Xóa dữ liệu cũ trong combobox
        Me.cboGiaTriTimKiem.DataSource = Nothing
        'Tạo nguồn dữ liệu cho combobox
        objConnect.SetDataCombobox(Me.cboGiaTriTimKiem, "Select TenKH From tblKhachHang Order by TenKH")
        Me.cboGiaTriTimKiem.SelectedIndex = -1
    End Sub

    Private Sub btnHuyBo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHuyBo.Click
        Me.Close()
    End Sub

    Private Sub frmTimKiemHoaDonMuaHang_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub btnTimKiem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTimKiem.Click
        Dim strSQL As String
        strSQL = "SELECT MaHDBH,NgayHDBH,TenKH,HoTen,NgayGiaoHang,HanThanhToan,PhiVanChuyen,TienThue,TienGiamGia,TongTien,TienDaThu,TienConNo,MaKH,MaNV From View_DS_HDBH "
        If Me.rdoMaHD.Checked = True Then
            strSQL &= "Where MaHDBH like N'%" & Me.cboGiaTriTimKiem.Text & "%' Order by NgayHDBH DESC"
        End If
        Dim Date1, Date2 As Date
        Date1 = Date.FromOADate(1 / 1 / 1900)
        Date2 = Date.FromOADate(1 / 1 / 1900)
        Try
            Date2 = CDate(Me.cboGiaTriTimKiem.Text)
        Catch ex As Exception

        End Try
        If Me.rdoNgayHD.Checked = True Then

            strSQL &= "Where DateDiff(d,'01/01/1900',NgayHDBH) Like N'%" & DateDiff(DateInterval.Day, Date1, Date2) - 1 & "%' Order by NgayHDBH DESC"
        End If
        If Me.rdoNhanVien.Checked = True Then
            strSQL &= "Where HoTen Like N'%" & Me.cboGiaTriTimKiem.Text & "%' Order by NgayHDBH DESC"
        End If

        If Me.rdoKhachHang.Checked = True Then
            strSQL &= "Where TenKH Like N'%" & Me.cboGiaTriTimKiem.Text & "%' Order by NgayHDBH DESC"
        End If
        If Me.cboGiaTriTimKiem.Text.Trim = "" Then
            frmMsgOK.HienThi("Bạn chưa nhập giá trị tìm kiếm", "Thông báo", False)
            Me.cboGiaTriTimKiem.Focus()
        Else
            frmMainX.LoadData(5, strSQL)
            Me.Close()
        End If
    End Sub
End Class