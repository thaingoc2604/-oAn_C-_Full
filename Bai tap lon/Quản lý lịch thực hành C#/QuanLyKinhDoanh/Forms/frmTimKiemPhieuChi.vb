Public Class frmTimKiemPhieuChi

    Private Sub rdoMaPC_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdoMaPC.Click
        'Xóa dữ liệu cũ trong combobox
        Me.cboGiaTriTimKiem.DataSource = Nothing
        'Tạo nguồn dữ liệu cho combobox
        objConnect.SetDataCombobox(Me.cboGiaTriTimKiem, "Select MaPC From tblPhieuChi Order by MaPC")
        Me.cboGiaTriTimKiem.SelectedIndex = -1
    End Sub

    Private Sub rdoNgayPC_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdoNgayPC.Click
        'Xóa dữ liệu cũ trong combobox
        Me.cboGiaTriTimKiem.DataSource = Nothing
        'Tạo nguồn dữ liệu cho combobox
        objConnect.SetDataCombobox(Me.cboGiaTriTimKiem, "Select NgayPC From tblPhieuChi Order by MaPC")
        Me.cboGiaTriTimKiem.SelectedIndex = -1
    End Sub

    Private Sub rdoNhanVien_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdoNhanVien.Click
        'Xóa dữ liệu cũ trong combobox
        Me.cboGiaTriTimKiem.DataSource = Nothing
        'Tạo nguồn dữ liệu cho combobox
        objConnect.SetDataCombobox(Me.cboGiaTriTimKiem, "Select MaNV From tblPhieuChi Order by MaNV")
        Me.cboGiaTriTimKiem.SelectedIndex = -1
    End Sub

    Private Sub rdoHDMH_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdoHDMH.Click
        'Xóa dữ liệu cũ trong combobox
        Me.cboGiaTriTimKiem.DataSource = Nothing
        'Tạo nguồn dữ liệu cho combobox
        objConnect.SetDataCombobox(Me.cboGiaTriTimKiem, "Select MaHDMH From tblPhieuChi Order by MaHDMH")
        Me.cboGiaTriTimKiem.SelectedIndex = -1
    End Sub

    Private Sub btnHuyBo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnHuyBo.Click
        Me.Close()
    End Sub

    Private Sub frmTimKiemPhieuChi_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub btnTimKiem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTimKiem.Click
        Dim strSQL As String
        strSQL = "Select MaPC,NgayPC,MaHDMH,SoTien,TenNCC,HoTen,NguoiNhan,LyDoChi,KemTheoChungTu,MaNCC,MaNV From View_DS_PhieuChi "
        If Me.rdoMaPC.Checked = True Then
            strSQL &= "Where MaPC like N'%" & Me.cboGiaTriTimKiem.Text & "%' Order by NgayPC DESC"
        End If
        Dim Date1, Date2 As Date
        Date1 = Date.FromOADate(1 / 1 / 1900)
        Date2 = Date.FromOADate(1 / 1 / 1900)
        Try
            Date2 = CDate(Me.cboGiaTriTimKiem.Text)
        Catch ex As Exception

        End Try
        If Me.rdoNgayPC.Checked = True Then

            strSQL &= "Where DateDiff(d,'01/01/1900',NgayPC) Like N'%" & DateDiff(DateInterval.Day, Date1, Date2) - 1 & "%' Order by NgayPC DESC"
        End If
        If Me.rdoNhanVien.Checked = True Then
            strSQL &= "Where MaNV Like N'%" & Me.cboGiaTriTimKiem.Text & "%' Order by NgayPC DESC"
        End If

        If Me.rdoHDMH.Checked = True Then
            strSQL &= "Where MaHDMH Like N'%" & Me.cboGiaTriTimKiem.Text & "%' Order by NgayPC DESC"
        End If
        If Me.cboGiaTriTimKiem.Text.Trim = "" Then
            frmMsgOK.HienThi("Bạn chưa nhập giá trị tìm kiếm", "Thông báo", False)
            Me.cboGiaTriTimKiem.Focus()
        Else
            frmMainX.LoadData(7, strSQL)
            Me.Close()
        End If
    End Sub

    
End Class