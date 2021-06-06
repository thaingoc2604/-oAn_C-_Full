Public Class frmTimKiemHoaDonMuaHang
    Private Sub rdoMaHD_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdoMaHD.Click
        'Xóa dữ liệu cũ trong combobox
        Me.cboGiaTriTimKiem.DataSource = Nothing
        'Tạo nguồn dữ liệu cho combobox
        objConnect.SetDataCombobox(Me.cboGiaTriTimKiem, "Select MaHDMH From tblHoaDonMuaHang Order by MaHDMH")
        Me.cboGiaTriTimKiem.SelectedIndex = -1
    End Sub


    Private Sub rdoNgayHD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoNgayHD.Click
        'Xóa dữ liệu cũ trong combobox
        Me.cboGiaTriTimKiem.DataSource = Nothing
        'Tạo nguồn dữ liệu cho combobox
        objConnect.SetDataCombobox(Me.cboGiaTriTimKiem, "Select NgayHDMH From tblHoaDonMuaHang Order by NgayHDMH")
        Me.cboGiaTriTimKiem.SelectedIndex = -1
    End Sub

    Private Sub rdoNhanVien_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoNhanVien.CheckedChanged
        'Xóa dữ liệu cũ trong combobox
        Me.cboGiaTriTimKiem.DataSource = Nothing
        'Tạo nguồn dữ liệu cho combobox
        objConnect.SetDataCombobox(Me.cboGiaTriTimKiem, "Select HoTen From tblNhanVien Order by HoTen")
        Me.cboGiaTriTimKiem.SelectedIndex = -1
    End Sub


    Private Sub rdoNCC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoNCC.Click
        'Xóa dữ liệu cũ trong combobox
        Me.cboGiaTriTimKiem.DataSource = Nothing
        'Tạo nguồn dữ liệu cho combobox
        objConnect.SetDataCombobox(Me.cboGiaTriTimKiem, "Select TenNCC From tblNhaCC Order by TenNCC")
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
        strSQL = "SELECT MaHDMH,NgayHDMH,TenNCC,HoTen,NgayGiaoHang,HanThanhToan,PhiVanChuyen,TienThue,TienGiamGia,TongTien,TienDaTra,TienConNo,MaNCC,MaNV From View_DS_HDMH "
        If Me.rdoMaHD.Checked = True Then
            strSQL &= "Where MaHDMH like N'%" & Me.cboGiaTriTimKiem.Text & "%' Order by NgayHDMH DESC"
        End If
        Dim Date1, Date2 As Date
        Date1 = Date.FromOADate(1 / 1 / 1900)
        Date2 = Date.FromOADate(1 / 1 / 1900)
        Try
            Date2 = CDate(Me.cboGiaTriTimKiem.Text)
        Catch ex As Exception

        End Try
        If Me.rdoNgayHD.Checked = True Then

            strSQL &= "Where DateDiff(d,'01/01/1900',NgayHDMH) Like N'%" & DateDiff(DateInterval.Day, Date1, Date2) - 1 & "%' Order by NgayHDMH DESC"
        End If
        If Me.rdoNhanVien.Checked = True Then
            strSQL &= "Where HoTen Like N'%" & Me.cboGiaTriTimKiem.Text & "%' Order by NgayHDMH DESC"
        End If

        If Me.rdoNCC.Checked = True Then
            strSQL &= "Where TenNCC Like N'%" & Me.cboGiaTriTimKiem.Text & "%' Order by NgayHDMH DESC"
        End If
        If Me.cboGiaTriTimKiem.Text.Trim = "" Then
            frmMsgOK.HienThi("Bạn chưa nhập giá trị tìm kiếm", "Thông báo", False)
            Me.cboGiaTriTimKiem.Focus()
        Else
            frmMainX.LoadData(2, strSQL)
            Me.Close()
        End If
    End Sub
End Class