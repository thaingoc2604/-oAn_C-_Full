Public Class frmTimKiemNhaCC

    Private Sub rdoMaNCC_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdoMaNCC.Click
        'Xóa dữ liệu cũ trong combobox
        Me.cboGiaTriTimKiem.DataSource = Nothing
        'Tạo nguồn dữ liệu cho combobox
        objConnect.SetDataCombobox(Me.cboGiaTriTimKiem, "Select MaNCC From tblNhaCC Order by MaNCC")
        Me.cboGiaTriTimKiem.SelectedIndex = -1
    End Sub

    Private Sub rdoTenNCC_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdoTenNCC.Click
        'Xóa dữ liệu cũ trong combobox
        Me.cboGiaTriTimKiem.DataSource = Nothing
        'Tạo nguồn dữ liệu cho combobox
        objConnect.SetDataCombobox(Me.cboGiaTriTimKiem, "Select Distinct TenNCC From tblNhaCC Order by TenNCC")
        Me.cboGiaTriTimKiem.SelectedIndex = -1
    End Sub

    Private Sub rdoMST_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdoMST.Click
        'Xóa dữ liệu cũ trong combobox
        Me.cboGiaTriTimKiem.DataSource = Nothing
        'Tạo nguồn dữ liệu cho combobox
        objConnect.SetDataCombobox(Me.cboGiaTriTimKiem, "Select MST From tblNhaCC Order by MST")
        Me.cboGiaTriTimKiem.SelectedIndex = -1
    End Sub

    Private Sub rdoTaiKhoan_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdoTaiKhoan.Click
        'Xóa dữ liệu cũ trong combobox
        Me.cboGiaTriTimKiem.DataSource = Nothing
        'Tạo nguồn dữ liệu cho combobox
        objConnect.SetDataCombobox(Me.cboGiaTriTimKiem, "Select SoTaiKhoan From tblNhaCC Order by SoTaiKhoan")
        Me.cboGiaTriTimKiem.SelectedIndex = -1
    End Sub

    Private Sub btnTimKiem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTimKiem.Click
        Dim strSQL As String
        strSQL = "Select MaNCC,TenNCC,DaiDien,DiaChi,TenTinhTP,MST,SoTaiKhoan,"
        strSQL &= "NganHang,DienThoai,Email,Fax,Website,MoTa,tblNhaCC.MaTinhTP "
        strSQL &= "From tblTinhTP RIGHT JOIN tblNhaCC ON tblTinhTP.MaTinhTP=tblNhaCC.MaTinhTP "
        If Me.rdoMaNCC.Checked = True Then
            strSQL &= "Where tblNhaCC.MaNCC like N'%" & Me.cboGiaTriTimKiem.Text & "%' Order by TenNCC"
        End If

        If Me.rdoTenNCC.Checked = True Then
            strSQL &= "Where tblNhaCC.TenNCC Like N'%" & Me.cboGiaTriTimKiem.Text & "%' Order by TenNCC"
        End If
        If Me.rdoMST.Checked = True Then
            strSQL &= "Where tblNhaCC.MST Like N'%" & Me.cboGiaTriTimKiem.Text & "%' Order by TenNCC"
        End If

        If Me.rdoTaiKhoan.Checked = True Then
            strSQL &= "Where tblNhaCC.SoTaiKhoan Like N'%" & Me.cboGiaTriTimKiem.Text & "%' Order by TenNCC"
        End If
        If Me.cboGiaTriTimKiem.Text.Trim = "" Then
            frmMsgOK.HienThi("Bạn chưa nhập giá trị tìm kiếm", "Thông báo", False)
            Me.cboGiaTriTimKiem.Focus()
        Else
            frmMainX.LoadData(22, strSQL)
            Me.Close()
        End If
    End Sub

    Private Sub frmTimKiemNhaCC_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub btnHuyBo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnHuyBo.Click
        Me.Close()
    End Sub
End Class