Public Class frmTinhTP
    Friend strMa_Cu As String
    Friend strTen_Cu As String
    Private Sub frmTinhTP_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Dispose()
        frmMainX.LoadData(26)
    End Sub

    'Private Sub frmTinhTP_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    '    objConnect.Load_DataGridView(Me.DataGridView, "Mã Tỉnh,Tên tỉnh,Quốc gia", "Select * From tblTinhTP Order by TenTinhTP")
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

    Private Sub btnLuu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLuu.Click
        Select Case pThem
            Case True
                Dim strSQL As String
                If NhapLieu.ChuaDuThongTin("NN", ErrorProvider) = True Then
                    frmMsgOK.HienThi("Thông tin bạn nhập vào chưa hợp lệ", "Thông báo")
                Else
                    If objConnect.DaTonTai("Select * From tblTinhTP Where TenTinhTP =N'" & Me.txtTenTinhTP.Text.Trim & "'") = True Then
                        frmMsgOK.HienThi("Tên tỉnh thành phố này đã tồn tại", "Thông báo", False)
                        Me.txtTenTinhTP.Focus()
                    Else
                        'Thực hiện thêm giá trị mới vào CSDL
                        strSQL = "Insert into tblTinhTP (TenTinhTP,QuocGia) Values(N'" & Me.txtTenTinhTP.Text.Trim & "',N'" & Me.txtQuocGia.Text.Trim & "')"
                        objConnect.RunSQL(strSQL)
                        'Làm mới dữ liệu trên DataGridView
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
                    If objConnect.DaTonTai("Select * From tblTinhTP Where TenTinhTP =N'" & Me.txtTenTinhTP.Text.Trim & "' And TenTinhTP Not Like N'" & strTen_Cu & "'") = True Then
                        frmMsgOK.HienThi("Tên tỉnh thành phố này đã tồn tại", "Thông báo", False)
                        Me.txtTenTinhTP.Focus()
                    Else
                        'Thực hiện sửa giá trị mới vào CSDL
                        strSQL = "Update tblTinhTP Set TenTinhTP =N'" & Me.txtTenTinhTP.Text.Trim.ToString & "',QuocGia = N'" & Me.txtQuocGia.Text.Trim.ToString & "' Where MaTinhTP like N'" & strMa_Cu & "'"
                        objConnect.RunSQL(strSQL)
                        'Làm mới dữ liệu trên DataGridView
                        frmMsgOK.HienThi("Sửa thành công", "Thông báo")
                        Me.Dispose()
                    End If
                End If
        End Select
        
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

    Private Sub ResetValues()
        Me.txtTenTinhTP.Text = ""
        Me.txtQuocGia.Text = ""
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
    '        strMa_Cu = Me.DataGridView.CurrentRow.Cells("MaTinhTP").Value
    '        strTen_Cu = Me.DataGridView.CurrentRow.Cells("TenTinhTP").Value.ToString
    '        Me.txtTenTinhTP.Text = Me.DataGridView.CurrentRow.Cells("TenTinhTP").Value.ToString
    '        Me.txtQuocGia.Text = Me.DataGridView.CurrentRow.Cells("QuocGia").Value.ToString
    '        Me.btnSua.Enabled = True
    '        Me.btnXoa.Enabled = True
    '        Me.btnHuyBo.Enabled = True
    '        Me.btnThem.Enabled = False
    '        Call HieuNangDieuKhien()
    '    End If
    'End Sub

    'Private Sub btnSua_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    'End Sub

    'Private Sub btnXoa_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    '    If Me.DataGridView.RowCount > 0 Then
    '        Dim strSQL As String = "Delete From tblTinhTP Where MaTinhTP Like N'" & Me.DataGridView.CurrentRow.Cells("MaTinhTP").Value & "'"
    '        Dim blnNhanVien, blnKhachHang, blnNhaCC As Boolean
    '        blnNhanVien = objConnect.DaTonTai("Select * From tblNhanVien Where MaTinhTP Like N'" & Me.DataGridView.CurrentRow.Cells("MaTinhTP").Value & "'")
    '        blnKhachHang = objConnect.DaTonTai("Select * From tblKhachHang Where MaTinhTP Like N'" & Me.DataGridView.CurrentRow.Cells("MaTinhTP").Value & "'")
    '        blnNhaCC = objConnect.DaTonTai("Select * From tblNhaCC Where MaTinhTP Like N'" & Me.DataGridView.CurrentRow.Cells("MaTinhTP").Value & "'")
    '        If (blnNhanVien Or blnKhachHang Or blnNhaCC) = True Then
    '            frmMsgOK.HienThi("Tên tỉnh thành phố này đang được sử dụng bạn không thể xóa nó", "Thông báo", False)
    '        Else
    '            If frmMsgYesNo.HienThi("Bạn có chắc chắn muốn xóa không ?", "Thông báo", False) = Windows.Forms.DialogResult.Yes Then
    '                objConnect.RunSQL(strSQL)
    '                objConnect.Load_DataGridView(Me.DataGridView, "Mã Tỉnh,Tên tỉnh,Quốc gia", "Select * From tblTinhTP Order by TenTinhTP")
    '                Call ResetValues()
    '                Me.btnSua.Enabled = False
    '                Me.btnThem.Enabled = True
    '                Call VoHieuNangDieuKhien()
    '                If Me.DataGridView.RowCount < 1 Then
    '                    Me.btnXoa.Enabled = False
    '                End If
    '            End If
    '        End If
    '    End If
    'End Sub
    'Phương thức đặt thuộc tính Enabled =True cho các điều khiển nhập liệu
    'Private Sub HieuNangDieuKhien()
    '    Me.txtTenTinhTP.Enabled = True
    '    Me.txtQuocGia.Enabled = True
    '    Me.txtTenTinhTP.Focus()
    'End Sub
    'Phương thức đặt thuộc tính Enabled =False cho các điều khiển nhập liệu
    'Private Sub VoHieuNangDieuKhien()
    '    Me.txtTenTinhTP.Enabled = False
    '    Me.txtQuocGia.Enabled = False
    'End Sub
End Class