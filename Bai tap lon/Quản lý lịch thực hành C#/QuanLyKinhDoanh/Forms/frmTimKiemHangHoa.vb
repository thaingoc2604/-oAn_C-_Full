Public Class frmTimKiemHangHoa

    Private Sub rdoMaH_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdoMaH.Click
        'Xóa dữ liệu cũ trong combobox
        Me.cboGiaTriTimKiem.DataSource = Nothing
        'Tạo nguồn dữ liệu cho combobox
        objConnect.SetDataCombobox(Me.cboGiaTriTimKiem, "Select MaH From tblHangHoa Order by MaH")
        Me.cboGiaTriTimKiem.SelectedIndex = -1
    End Sub

    Private Sub rdoTenH_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdoTenH.Click
        'Xóa dữ liệu cũ trong combobox
        Me.cboGiaTriTimKiem.DataSource = Nothing
        'Tạo nguồn dữ liệu cho combobox
        objConnect.SetDataCombobox(Me.cboGiaTriTimKiem, "Select Distinct TenH From tblHangHoa Order by TenH")
        Me.cboGiaTriTimKiem.SelectedIndex = -1
    End Sub

    Private Sub rdoNhomHang_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdoNhomHang.Click
        'Xóa dữ liệu cũ trong combobox
        Me.cboGiaTriTimKiem.DataSource = Nothing
        'Tạo nguồn dữ liệu cho combobox
        objConnect.SetDataCombobox(Me.cboGiaTriTimKiem, " Select Distinct tblNhomHang.TenNhom FROM tblHangHoa INNER JOIN tblNhomHang ON tblHangHoa.MaNhom = tblNhomHang.MaNhom ORDER BY tblNhomHang.TenNhom;")
        Me.cboGiaTriTimKiem.SelectedIndex = -1
    End Sub

    Private Sub rdoXuatSu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdoXuatSu.Click
        'Xóa dữ liệu cũ trong combobox
        Me.cboGiaTriTimKiem.DataSource = Nothing
        'Tạo nguồn dữ liệu cho combobox
        objConnect.SetDataCombobox(Me.cboGiaTriTimKiem, "Select Distinct XuatSu From tblHangHoa Order by XuatSu")
        Me.cboGiaTriTimKiem.SelectedIndex = -1
    End Sub

    Private Sub frmTimKiemHangHoa_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub btnHuyBo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnHuyBo.Click
        Me.Close()
    End Sub

    Private Sub btnTimKiem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTimKiem.Click
        Dim strSQL As String = "Select MaH,TenH,DVT,TenNhom,SL_Nhap,SL_Xuat,SL_Ton,DGBan,ThueVAT,XuatSu,PhoTo,MaNhom From View_frmHangHoa "
        Dim strColumnsHeader As String = "Mã hàng,Tên hàng,ĐVT,Nhóm hàng,Số lượng nhập,Số lượng bán,Số lượng tồn,Đơn giá bán,Thuế VAT(%),Xuất sứ,Đường dẫn ảnh"
        If Me.rdoMaH.Checked = True Then
            strSQL &= "Where MaH like N'%" & Me.cboGiaTriTimKiem.Text & "%' Order by MaH"
        End If

        If Me.rdoTenH.Checked = True Then
            strSQL &= "Where TenH Like N'%" & Me.cboGiaTriTimKiem.Text & "%' Order by TenH"
        End If
        If Me.rdoNhomHang.Checked = True Then
            strSQL &= "Where TenNhom Like N'%" & Me.cboGiaTriTimKiem.Text & "%' Order by TenNhom"
        End If

        If Me.rdoXuatSu.Checked = True Then
            strSQL &= "Where XuatSu Like N'%" & Me.cboGiaTriTimKiem.Text & "%' Order by XuatSu"
        End If
        If Me.cboGiaTriTimKiem.Text.Trim = "" Then
            frmMsgOK.HienThi("Bạn chưa nhập giá trị tìm kiếm", "Thông báo", False)
            Me.cboGiaTriTimKiem.Focus()
        Else
            frmMainX.LoadData(27, strSQL)
            Me.Close()
        End If
    End Sub
End Class