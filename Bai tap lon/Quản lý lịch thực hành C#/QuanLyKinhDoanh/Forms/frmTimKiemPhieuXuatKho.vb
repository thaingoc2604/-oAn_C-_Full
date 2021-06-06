Public Class frmTimKiemPhieuXuatKho
    Private Sub rdoMaPXK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdoMaPXK.Click
        'Xóa dữ liệu cũ trong combobox
        Me.cboGiaTriTimKiem.DataSource = Nothing
        'Tạo nguồn dữ liệu cho combobox
        objConnect.SetDataCombobox(Me.cboGiaTriTimKiem, "Select MaPXK From tblPhieuXuatKho Order by MaPXK")
        Me.cboGiaTriTimKiem.SelectedIndex = -1
    End Sub

    Private Sub rdoNhanVien_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdoNhanVien.Click
        'Xóa dữ liệu cũ trong combobox
        Me.cboGiaTriTimKiem.DataSource = Nothing
        'Tạo nguồn dữ liệu cho combobox
        objConnect.SetDataCombobox(Me.cboGiaTriTimKiem, "SELECT Distinct tblNhanVien.HoTen FROM tblNhanVien RIGHT JOIN tblPhieuXuatKho ON tblNhanVien.MaNV = tblPhieuXuatKho.MaNV ORDER BY tblNhanVien.HoTen;")
        Me.cboGiaTriTimKiem.SelectedIndex = -1
    End Sub

    Private Sub rdoNgayPXK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdoNgayPXK.Click
        'Xóa dữ liệu cũ trong combobox
        Me.cboGiaTriTimKiem.DataSource = Nothing
        'Tạo nguồn dữ liệu cho combobox
        objConnect.SetDataCombobox(Me.cboGiaTriTimKiem, "SELECT Distinct tblPhieuXuatKho.NgayXK FROM tblPhieuXuatKho Order by tblPhieuXuatKho.NgayXK DESC")
        Me.cboGiaTriTimKiem.SelectedIndex = -1
    End Sub

    Private Sub rdoKho_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdoKho.Click
        'Xóa dữ liệu cũ trong combobox
        Me.cboGiaTriTimKiem.DataSource = Nothing
        'Tạo nguồn dữ liệu cho combobox
        objConnect.SetDataCombobox(Me.cboGiaTriTimKiem, "SELECT Distinct tblKho.TenKho FROM tblKho RIGHT JOIN tblPhieuXuatKho ON tblKho.MaKho = tblPhieuXuatKho.MaKho ORDER BY tblKho.TenKho")
        Me.cboGiaTriTimKiem.SelectedIndex = -1
    End Sub

    Private Sub btnTimKiem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTimKiem.Click
        Dim strSQL As String
        strSQL = "SELECT tblPhieuXuatKho.MaPXK, tblPhieuXuatKho.NgayXK, tblKho.TenKho, tblNhanVien.HoTen, tblKhachHang.TenKH,tblKhachHang.DiaChi,tblKhachHang.DienThoai, tblPhieuXuatKho.MaKho, tblPhieuXuatKho.MaKH, tblPhieuXuatKho.MaNV,tblKhachHang.TenKH,tblKhachHang.DiaChi,tblKhachHang.CongTy "
        strSQL &= "FROM tblKhachHang RIGHT JOIN (tblNhanVien RIGHT JOIN (tblKho RIGHT JOIN tblPhieuXuatKho ON tblKho.MaKho = tblPhieuXuatKho.MaKho) ON tblNhanVien.MaNV = tblPhieuXuatKho.MaNV) ON tblKhachHang.MaKH = tblPhieuXuatKho.MaKH "
        If Me.rdoMaPXK.Checked = True Then
            strSQL &= "Where tblPhieuXuatKho.MaPXK like N'%" & Me.cboGiaTriTimKiem.Text & "%' Order by tblPhieuXuatKho.NgayXK DESC"
        End If

        If Me.rdoNhanVien.Checked = True Then

            strSQL &= "Where tblNhanVien.HoTen Like N'%" & Me.cboGiaTriTimKiem.Text.Trim & "%' Order by tblPhieuXuatKho.NgayXK DESC"
        End If
        Dim Date1, Date2 As Date
        Date1 = Date.FromOADate(1 / 1 / 1900)
        Date2 = Date.FromOADate(1 / 1 / 1900)
        Try
            Date2 = CDate(Me.cboGiaTriTimKiem.Text)
        Catch ex As Exception

        End Try
        If Me.rdoNgayPXK.Checked = True Then
            strSQL &= "Where DateDiff(d,'01/01/1900',tblPhieuXuatKho.NgayXK) Like N'%" & DateDiff(DateInterval.Day, Date1, Date2) - 1 & "%' Order by tblPhieuXuatKho.NgayXK DESC"
        End If

        If Me.rdoKho.Checked = True Then
            strSQL &= "Where tblKho.TenKho Like N'%" & Me.cboGiaTriTimKiem.Text & "%' Order by tblPhieuXuatKho.NgayXK DESC"
        End If
        If Me.cboGiaTriTimKiem.Text.Trim = "" Then
            frmMsgOK.HienThi("Bạn chưa nhập giá trị tìm kiếm", "Thông báo", False)
            Me.cboGiaTriTimKiem.Focus()
        Else
            frmMainX.LoadData(6, strSQL)
            Me.Close()
        End If
    End Sub

    Private Sub btnHuyBo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnHuyBo.Click
        Me.Close()
    End Sub

    Private Sub frmTimKiemPhieuXuatKho_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub
End Class