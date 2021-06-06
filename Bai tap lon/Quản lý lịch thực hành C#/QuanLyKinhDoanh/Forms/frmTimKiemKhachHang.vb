Public Class frmTimKiemKhachHang

    Private Sub rdoMaKH_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdoMaKH.Click
        'Xóa dữ liệu cũ trong combobox
        Me.cboGiaTriTimKiem.DataSource = Nothing
        'Tạo nguồn dữ liệu cho combobox
        objConnect.SetDataCombobox(Me.cboGiaTriTimKiem, "Select MaKH From tblKhachHang Order by MaKH")
        Me.cboGiaTriTimKiem.SelectedIndex = -1
    End Sub

    Private Sub rdoTenKH_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdoTenKH.Click
        'Xóa dữ liệu cũ trong combobox
        Me.cboGiaTriTimKiem.DataSource = Nothing
        'Tạo nguồn dữ liệu cho combobox
        objConnect.SetDataCombobox(Me.cboGiaTriTimKiem, "Select Distinct TenKH From tblKhachHang Order by TenKH")
        Me.cboGiaTriTimKiem.SelectedIndex = -1
    End Sub

    Private Sub rdoCongTy_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdoCongTy.Click
        'Xóa dữ liệu cũ trong combobox
        Me.cboGiaTriTimKiem.DataSource = Nothing
        'Tạo nguồn dữ liệu cho combobox
        objConnect.SetDataCombobox(Me.cboGiaTriTimKiem, "Select Distinct CongTy From tblKhachHang Order by CongTy")
        Me.cboGiaTriTimKiem.SelectedIndex = -1
    End Sub

    Private Sub rdoMST_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdoMST.Click
        'Xóa dữ liệu cũ trong combobox
        Me.cboGiaTriTimKiem.DataSource = Nothing
        'Tạo nguồn dữ liệu cho combobox
        objConnect.SetDataCombobox(Me.cboGiaTriTimKiem, "Select MST From tblKhachHang Order by MST")
        Me.cboGiaTriTimKiem.SelectedIndex = -1
    End Sub

    Private Sub btnTimKiem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTimKiem.Click
        Dim strSQL As String
        strSQL = "Select MaKH,TenKH,CongTy,DaiDien,DiaChi,TenTinhTP,MST,SoTaiKhoan,"
        strSQL &= "NganHang,DienThoai,Email,Fax,Website,KhachLe,tblKhachHang.MaTinhTP "
        strSQL &= ("From tblTinhTP RIGHT JOIN tblKhachHang ON tblTinhTP.MaTinhTP=tblKhachHang.MaTinhTP ")
        If Me.rdoMaKH.Checked = True Then
            strSQL &= "Where tblKhachHang.MaKH like N'%" & Me.cboGiaTriTimKiem.Text & "%' Order by TenKH"
        End If

        If Me.rdoTenKH.Checked = True Then
            strSQL &= "Where tblKhachHang.TenKH like N'%" & Me.cboGiaTriTimKiem.Text & "%' Order by TenKH"
        End If
        If Me.rdoCongTy.Checked = True Then
            strSQL &= "Where tblKhachHang.CongTy like N'%" & Me.cboGiaTriTimKiem.Text & "%' Order by TenKH"
        End If

        If Me.rdoMST.Checked = True Then
            strSQL &= "Where tblKhachHang.MST like N'%" & Me.cboGiaTriTimKiem.Text & "%' Order by TenKH"
        End If
        If Me.cboGiaTriTimKiem.Text.Trim = "" Then
            frmMsgOK.HienThi("Bạn chưa nhập giá trị tìm kiếm", "Thông báo", False)
            Me.cboGiaTriTimKiem.Focus()
        Else
            frmMainX.LoadData(24, strSQL)
            Me.Close()
        End If
    End Sub

    Private Sub frmTimKiemKhachHang_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmTimKiemKhachHang_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Xóa dữ liệu cũ trong combobox
        Me.cboGiaTriTimKiem.DataSource = Nothing
        'Tạo nguồn dữ liệu cho combobox
        objConnect.SetDataCombobox(Me.cboGiaTriTimKiem, "Select MaKH From tblKhachHang Order by MaKH")
        Me.cboGiaTriTimKiem.SelectedIndex = -1
    End Sub

    Private Sub btnHuyBo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnHuyBo.Click
        Me.Close()
    End Sub
End Class