Public Class frmTimKiemNhanVien
    Private Sub rdoMaNV_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdoMaNV.Click
        'Xóa dữ liệu cũ trong combobox
        Me.cboGiaTriTimKiem.DataSource = Nothing
        'Tạo nguồn dữ liệu cho combobox
        objConnect.SetDataCombobox(Me.cboGiaTriTimKiem, "Select MaNV From tblNhanVien Order by MaNV")
        Me.cboGiaTriTimKiem.SelectedIndex = -1
    End Sub

    Private Sub rdoHoTen_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdoHoTen.Click
        'Xóa dữ liệu cũ trong combobox
        Me.cboGiaTriTimKiem.DataSource = Nothing
        'Tạo nguồn dữ liệu cho combobox
        objConnect.SetDataCombobox(Me.cboGiaTriTimKiem, "Select Distinct HoTen From tblNhanVien Order by HoTen")
        Me.cboGiaTriTimKiem.SelectedIndex = -1
    End Sub

    Private Sub rdoBoPhan_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdoBoPhan.Click
        'Xóa dữ liệu cũ trong combobox
        Me.cboGiaTriTimKiem.DataSource = Nothing
        'Tạo nguồn dữ liệu cho combobox
        objConnect.SetDataCombobox(Me.cboGiaTriTimKiem, "SELECT Distinct tblBoPhan.TenBP FROM tblBoPhan INNER JOIN tblNhanVien ON tblBoPhan.MaBP = tblNhanVien.MaBP ORDER BY tblBoPhan.TenBP;")
        Me.cboGiaTriTimKiem.SelectedIndex = -1
    End Sub

    Private Sub rdoChucVu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdoChucVu.Click
        'Xóa dữ liệu cũ trong combobox
        Me.cboGiaTriTimKiem.DataSource = Nothing
        'Tạo nguồn dữ liệu cho combobox
        objConnect.SetDataCombobox(Me.cboGiaTriTimKiem, "SELECT Distinct tblChucVu.TenCV FROM tblNhanVien INNER JOIN tblChucVu ON tblNhanVien.MaCV = tblChucVu.MaCV ORDER BY tblChucVu.TenCV;")
        Me.cboGiaTriTimKiem.SelectedIndex = -1
    End Sub

    Private Sub btnTimKiem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTimKiem.Click
        Dim strSQL As String
        strSQL = "SELECT tblNhanVien.MaNV, tblNhanVien.HoTen, tblNhanVien.GioiTinh, tblNhanVien.NgaySinh,"
        strSQL &= "tblBoPhan.TenBP, tblChucVu.TenCV, tblNhanVien.DiaChi, tblTinhTP.TenTinhTP,"
        strSQL &= "tblNhanVien.DienThoai, tblNhanVien.CMND, tblNhanVien.NgayCap, tblNhanVien.NoiCap,"
        strSQL &= "tblNhanVien.NgayVaoCongTy, tblNhanVien.NgayThoiViec, tblNhanVien.KetHon, tblNhanVien.DanToc,"
        strSQL &= "tblNhanVien.TonGiao, tblNhanVien.TrinhDo, tblNhanVien.ChuyenNganh, tblNhanVien.NgoaiNgu,tblNhanVien.PhoTo,"
        strSQL &= "tblNhanVien.MaBP, tblNhanVien.MaCV, tblNhanVien.MaTinhTP "
        strSQL &= "FROM (tblChucVu RIGHT JOIN (tblBoPhan RIGHT JOIN tblNhanVien ON tblBoPhan.MaBP = tblNhanVien.MaBP) ON tblChucVu.MaCV = tblNhanVien.MaCV) LEFT JOIN tblTinhTP ON tblNhanVien.MaTinhTP = tblTinhTP.MaTinhTP "
        If Me.rdoMaNV.Checked = True Then
            strSQL &= "Where tblNhanVien.MaNV like N'%" & Me.cboGiaTriTimKiem.Text & "%'"
        End If

        If Me.rdoHoTen.Checked = True Then
            strSQL &= "Where tblNhanVien.HoTen Like N'%" & Me.cboGiaTriTimKiem.Text & "%'"
        End If
        If Me.rdoBoPhan.Checked = True Then
            strSQL &= "Where tblBoPhan.TenBP Like N'%" & Me.cboGiaTriTimKiem.Text & "%'"
        End If

        If Me.rdoChucVu.Checked = True Then
            strSQL &= "Where tblChucVu.TenCV Like N'%" & Me.cboGiaTriTimKiem.Text & "%'"
        End If
        If Me.cboGiaTriTimKiem.Text.Trim = "" Then
            frmMsgOK.HienThi("Bạn chưa nhập giá trị tìm kiếm", "Thông báo", False)
            Me.cboGiaTriTimKiem.Focus()
        Else
            frmMainX.LoadData(frmMainX.FormID, strSQL)
            Me.Close()
        End If
    End Sub

    Private Sub frmTimKiemNhanVien_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmTimKiemNhanVien_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Xóa dữ liệu cũ trong combobox
        Me.cboGiaTriTimKiem.DataSource = Nothing
        'Tạo nguồn dữ liệu cho combobox
        objConnect.SetDataCombobox(Me.cboGiaTriTimKiem, "Select MaNV From tblNhanVien Order by MaNV")
        Me.cboGiaTriTimKiem.SelectedIndex = -1
    End Sub

    Private Sub btnHuyBo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnHuyBo.Click
        Me.Close()
    End Sub
End Class