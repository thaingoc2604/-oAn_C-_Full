Public Class frmNhomHang
    Friend strMa_Cu As String
    Friend strTen_Cu As String
    'Phương thức đặt thuộc tính Enabled =True cho các điều khiển nhập liệu
    'Private Sub HieuNangDieuKhien()
    '    Me.txtTenNhom.Enabled = True
    '    Me.txtMoTa.Enabled = True
    '    Me.txtTenNhom.Focus()
    'End Sub
    'Phương thức đặt thuộc tính Enabled =False cho các điều khiển nhập liệu
    'Private Sub VoHieuNangDieuKhien()
    '    Me.txtTenNhom.Enabled = False
    '    Me.txtMoTa.Enabled = False
    'End Sub
    'Phương thức xóa dữ liệu trên điều khiển nhập liệu
    Private Sub ResetValues()
        Me.txtTenNhom.Text = ""
        Me.txtMoTa.Text = ""
    End Sub

    'Private Sub btnThem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnThem.Click
    '    Me.btnSua.Enabled = False
    '    Me.btnXoa.Enabled = False
    '    Me.btnHuyBo.Enabled = True
    '    Me.btnLuu.Enabled = True
    '    Me.btnThem.Enabled = False
    '    Call ResetValues()
    '    Call HieuNangDieuKhien()
    'End Sub

    'Private Sub btnSua_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSua.Click

    'End Sub

    'Private Sub frmNhomHang_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    '    objConnect.Load_DataGridView(Me.DataGridView, "Mã nhóm,Tên nhóm,Mô tả", "Select * From tblNhomHang Order by TenNhom")
    '    Call VoHieuNangDieuKhien()
    '    Me.btnSua.Enabled = False
    '    Me.btnLuu.Enabled = False
    '    Me.btnHuyBo.Enabled = False
    '    If Me.DataGridView.RowCount > 0 Then
    '        Me.btnXoa.Enabled = True
    '    Else
    '        Me.btnXoa.Enabled = False
    '    End If
    'End Sub

    'Private Sub btnXoa_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnXoa.Click
    '    If Me.DataGridView.RowCount > 0 Then
    '        Dim strSQL As String = "Delete From tblNhomHang Where MaNhom Like N'" & Me.DataGridView.CurrentRow.Cells("MaNhom").Value & "'"
    '        Dim blnHangHoa As Boolean
    '        blnHangHoa = objConnect.DaTonTai("Select * From tblHangHoa Where MaNhom Like N'" & Me.DataGridView.CurrentRow.Cells("MaNhom").Value & "'")
    '        If (blnHangHoa) = True Then
    '            frmMsgOK.HienThi("Tên nhóm này đang được sử dụng bạn không thể xóa nó", "Thông báo")
    '        Else
    '            If frmMsgYesNo.HienThi("Bạn có chắc chắn muốn xóa không ?", "Thông báo") = Windows.Forms.DialogResult.Yes Then
    '                objConnect.RunSQL(strSQL)
    '                objConnect.Load_DataGridView(Me.DataGridView, "Mã nhóm,Tên nhóm,Mô tả", "Select * From tblNhomHang Order by TenNhom")
    '                Call ResetValues()
    '                Me.btnSua.Enabled = False
    '                Me.btnHuyBo.Enabled = False
    '                Me.btnThem.Enabled = True
    '                Call VoHieuNangDieuKhien()
    '                If Me.DataGridView.RowCount < 1 Then
    '                    Me.btnXoa.Enabled = False
    '                End If
    '            End If
    '        End If
    '    End If
    'End Sub

    Private Sub btnLuu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLuu.Click
        Select Case pThem
            Case True
                Dim strSQL As String
                If NhapLieu.ChuaDuThongTin("NN", ErrorProvider) = True Then
                    frmMsgOK.HienThi("Thông tin bạn nhập vào chưa đủ", "Thông báo")
                Else
                    If objConnect.DaTonTai("Select * From tblNhomHang Where TenNhom =N'" & Me.txtTenNhom.Text.Trim & "'") = True Then
                        frmMsgOK.HienThi("Tên nhóm này đã tồn tại", "Thông báo")
                        Me.txtTenNhom.Focus()
                    Else
                        'Thực hiện thêm giá trị mới vào CSDL
                        strSQL = "Insert Into tblNhomHang (TenNhom,MoTa) Values(N'" & Me.txtTenNhom.Text.Trim & "',N'" & Me.txtMoTa.Text.Trim & "')"
                        objConnect.RunSQL(strSQL)
                        If (frmMsgYesNo.HienThi("Bạn có muốn nhập tiếp không ?", "Thông báo") = Windows.Forms.DialogResult.Yes) Then
                            Call ResetValues()
                        Else
                            Me.Dispose()
                        End If
                    End If
                End If
            Case False
                Dim strSQL As String
                If NhapLieu.ChuaDuThongTin("NN", ErrorProvider) = True Then
                    frmMsgOK.HienThi("Thông tin bạn nhập vào chưa hợp lệ", "Thông báo")
                Else
                    If objConnect.DaTonTai("Select * From tblNhomHang Where TenNhom =N'" & Me.txtTenNhom.Text.Trim & "' And TenNhom Not Like N'" & strTen_Cu & "'") = True Then
                        frmMsgOK.HienThi("Tên nhóm hàng này đã tồn tại", "Thông báo")
                        Me.txtTenNhom.Focus()
                    Else
                        'Thực hiện sửa giá trị mới vào CSDL
                        strSQL = "Update tblNhomHang Set TenNhom =N'" & Me.txtTenNhom.Text.Trim.ToString & "',MoTa = N'" & Me.txtMoTa.Text.Trim.ToString & "' Where MaNhom like N'" & strMa_Cu & "'"
                        objConnect.RunSQL(strSQL)
                        frmMsgOK.HienThi("Sửa thành công", "Thông báo")
                        Me.Dispose()
                    End If
                End If
        End Select
       
    End Sub

    'Private Sub btnHuyBo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnHuyBo.Click
    '    Call ResetValues()
    '    Me.btnHuyBo.Enabled = False
    '    Me.btnThem.Enabled = True
    '    If DataGridView.RowCount > 0 Then
    '        Me.btnXoa.Enabled = True
    '    Else
    '        Me.btnXoa.Enabled = False
    '    End If
    '    Me.btnSua.Enabled = False
    '    Me.btnLuu.Enabled = False
    '    Call VoHieuNangDieuKhien()
    '    NhapLieu.RemoveErrorProvider("NN", ErrorProvider)   'Ẩn điều khiển Errprovider nếu vẫn xuất hiện trên điều khiển nhập liệu
    'End Sub

    Private Sub btnThoat_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub

    'Private Sub DataGridView_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    '    NhapLieu.RemoveErrorProvider("NN", ErrorProvider)
    '    If ((btnThem.Enabled = True) And (Me.DataGridView.RowCount > 0)) Then
    '        strMa_Cu = Me.DataGridView.CurrentRow.Cells("MaNhom").Value.ToString
    '        Me.txtTenNhom.Text = Me.DataGridView.CurrentRow.Cells("TenNhom").Value.ToString
    '        Me.txtMoTa.Text = Me.DataGridView.CurrentRow.Cells("MoTa").Value.ToString
    '        Me.btnSua.Enabled = True
    '        Me.btnXoa.Enabled = True
    '        Me.btnHuyBo.Enabled = True
    '        Me.btnThem.Enabled = False
    '        Call HieuNangDieuKhien()
    '    End If
    'End Sub

    Private Sub frmNhomHang_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
        frmMainX.LoadData(23)
    End Sub

    Private Sub frmNhomHang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class