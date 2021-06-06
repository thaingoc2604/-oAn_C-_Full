Public Class frmTimKiemPhieuNhapKho

    Private Sub rdoMaPNK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdoMaPNK.Click
        'Xóa dữ liệu cũ trong combobox
        Me.cboGiaTriTimKiem.DataSource = Nothing
        'Tạo nguồn dữ liệu cho combobox
        objConnect.SetDataCombobox(Me.cboGiaTriTimKiem, "Select MaPNK From tblPhieuNhapKho Order by MaPNK")
        Me.cboGiaTriTimKiem.SelectedIndex = -1
    End Sub

    Private Sub rdoNhanVien_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdoNhanVien.Click
        'Xóa dữ liệu cũ trong combobox
        Me.cboGiaTriTimKiem.DataSource = Nothing
        'Tạo nguồn dữ liệu cho combobox
        objConnect.SetDataCombobox(Me.cboGiaTriTimKiem, "SELECT Distinct tblNhanVien.HoTen FROM tblNhanVien RIGHT JOIN tblPhieuNhapKho ON tblNhanVien.MaNV = tblPhieuNhapKho.MaNV ORDER BY tblNhanVien.HoTen;")
        Me.cboGiaTriTimKiem.SelectedIndex = -1
    End Sub

    Private Sub rdoNgayPNK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdoNgayPNK.Click
        'Xóa dữ liệu cũ trong combobox
        Me.cboGiaTriTimKiem.DataSource = Nothing
        'Tạo nguồn dữ liệu cho combobox
        objConnect.SetDataCombobox(Me.cboGiaTriTimKiem, "SELECT Distinct tblPhieuNhapKho.NgayNK FROM tblPhieuNhapKho order by tblPhieuNhapKho.NgayNK ")
        Me.cboGiaTriTimKiem.SelectedIndex = -1
    End Sub

    Private Sub rdoKho_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdoKho.Click
        'Xóa dữ liệu cũ trong combobox
        Me.cboGiaTriTimKiem.DataSource = Nothing
        'Tạo nguồn dữ liệu cho combobox
        objConnect.SetDataCombobox(Me.cboGiaTriTimKiem, "SELECT Distinct tblKho.TenKho FROM tblKho RIGHT JOIN tblPhieuNhapKho ON tblKho.MaKho = tblPhieuNhapKho.MaKho ORDER BY tblKho.TenKho")
        Me.cboGiaTriTimKiem.SelectedIndex = -1
    End Sub

    Private Sub btnTimKiem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTimKiem.Click
        Dim strSQL As String
        'strSQL = "SELECT tblPhieuNhapKho.MaPNK, tblPhieuNhapKho.NgayNK, tblKho.TenKho, tblNhanVien.HoTen, tblNhaCC.TenNCC, tblPhieuNhapKho.NguoiGH, tblPhieuNhapKho.MaKho, tblPhieuNhapKho.MaNV, tblPhieuNhapKho.MaNCC "
        'strSQL &= "FROM tblNhaCC RIGHT JOIN (tblNhanVien RIGHT JOIN (tblKho RIGHT JOIN tblPhieuNhapKho ON tblKho.MaKho = tblPhieuNhapKho.MaKho) ON tblNhanVien.MaNV = tblPhieuNhapKho.MaNV) ON tblNhaCC.MaNCC = tblPhieuNhapKho.MaNCC "
        strSQL = "SELECT tblPhieuNhapKho.MaPNK, tblPhieuNhapKho.NgayNK, tblKho.TenKho, tblNhanVien.HoTen, tblNhaCC.TenNCC,tblNhaCC.DiaChi, tblPhieuNhapKho.NguoiGH,tblNhaCC.DienThoai, tblPhieuNhapKho.MaKho, tblPhieuNhapKho.MaNV, tblPhieuNhapKho.MaNCC "
        strSQL &= "FROM tblNhaCC RIGHT JOIN (tblNhanVien RIGHT JOIN (tblKho RIGHT JOIN tblPhieuNhapKho ON tblKho.MaKho = tblPhieuNhapKho.MaKho) ON tblNhanVien.MaNV = tblPhieuNhapKho.MaNV) ON tblNhaCC.MaNCC = tblPhieuNhapKho.MaNCC "
        If Me.rdoMaPNK.Checked = True Then
            strSQL &= "Where tblPhieuNhapKho.MaPNK like N'%" & Me.cboGiaTriTimKiem.Text & "%' Order by tblPhieuNhapKho.MaPNK"
        End If

        If Me.rdoNhanVien.Checked = True Then

            strSQL &= "Where tblNhanVien.HoTen Like N'%" & Me.cboGiaTriTimKiem.Text.Trim & "%' Order by tblPhieuNhapKho.NgayNK DESC"
        End If

        Dim Date1, Date2 As Date
        Date1 = Date.FromOADate(1 / 1 / 1900)
        Date2 = Date.FromOADate(1 / 1 / 1900)
        Try
            Date2 = CDate(Me.cboGiaTriTimKiem.Text)
        Catch ex As Exception

        End Try
        If Me.rdoNgayPNK.Checked = True Then            
            strSQL &= "Where DateDiff(d,'01/01/1900',tblPhieuNhapKho.NgayNK) Like N'%" & DateDiff(DateInterval.Day, Date1, Date2) - 1 & "%' Order by tblPhieuNhapKho.NgayNK DESC"
        End If

        If Me.rdoKho.Checked = True Then
            strSQL &= "Where tblKho.TenKho Like N'%" & Me.cboGiaTriTimKiem.Text & "%' Order by tblPhieuNhapKho.NgayNK DESC"
        End If
        If Me.cboGiaTriTimKiem.Text.Trim = "" Then
            frmMsgOK.HienThi("Bạn chưa nhập giá trị tìm kiếm", "Thông báo", False)
            Me.cboGiaTriTimKiem.Focus()
        Else
            frmMainX.LoadData(3, strSQL)
            Me.Close()
        End If
    End Sub

    Private Sub btnHuyBo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnHuyBo.Click
        Me.Close()
    End Sub

    Private Sub frmTimKiemPhieuNhapKho_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub
End Class