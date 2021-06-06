Public Class frmChucVu
    Friend strMa_Cu As String
    Friend strTen_Cu As String
    Private Sub ResetValues()
        Me.txtMaCV.Text = ""
        Me.txtTenCV.Text = ""
        Me.txtTenCVBHXH.Text = ""
        Me.txtPhuCap.Text = ""
    End Sub

    Private Sub frmChucVu_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
        frmMainX.LoadData(21)
    End Sub

    'Private Sub VoHieuNangDieuKhien()
    '    Me.txtMaCV.Enabled = False
    '    Me.txtTenCV.Enabled = False
    '    Me.txtTenCVBHXH.Enabled = False
    '    Me.txtPhuCap.Enabled = False
    'End Sub

    'Private Sub HieuNangDieuKhien()
    '    Me.txtMaCV.Enabled = True
    '    Me.txtTenCV.Enabled = True
    '    Me.txtTenCVBHXH.Enabled = True
    '    Me.txtPhuCap.Enabled = True
    '    Me.txtMaCV.Focus()
    'End Sub

    'Private Sub frmChucVu_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    '    objConnect.Load_DataGridView(Me.DataGridView, "Mã chức vụ,Tên chức vụ,Tên chức vụ trong sổ BHXH,Phụ cấp", "Select MaCV,TenCV,TenCVBH,PhuCap From tblChucVu Order by TenCV")
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

    'Private Sub btnXoa_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnXoa.Click
    '    If Me.DataGridView.RowCount > 0 Then
    '        Dim strSQL As String = "Delete From tblChucVu Where MaCV Like N'" & Me.DataGridView.CurrentRow.Cells("MaCV").Value & "'"
    '        Dim blnNhanVien As Boolean
    '        blnNhanVien = objConnect.DaTonTai("Select * From tblNhanVien Where MaCV Like N'" & Me.DataGridView.CurrentRow.Cells("MaCV").Value & "'")
    '        If (blnNhanVien) = True Then
    '            frmMsgOK.HienThi("Bộ phận này đang được sử dụng bạn không thể xóa nó", "Thông báo", False)
    '        Else
    '            If frmMsgYesNo.HienThi("Bạn có chắc chắn muốn xóa không ?", "Thông báo", False) = Windows.Forms.DialogResult.Yes Then
    '                objConnect.RunSQL(strSQL)
    '                objConnect.Load_DataGridView(Me.DataGridView, "Mã chức vụ,Tên chức vụ,Tên chức vụ trong sổ BHXH,Phụ cấp", "Select MaCV,TenCV,TenCVBH,PhuCap From tblChucVu Order by TenCV")
    '                Call ResetValues()
    '                Me.btnSua.Enabled = False
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
                    If objConnect.DaTonTai("Select * From tblChucVu Where MaCV Like N'" & Me.txtMaCV.Text.Trim & "'") = True Then
                        frmMsgOK.HienThi("Mã chức vụ này đã tồn tại", "Thông báo", False)
                        Me.txtMaCV.Focus()
                    Else
                        If objConnect.DaTonTai("Select * From tblChucVu Where TenCV Like N'" & Me.txtTenCV.Text.Trim & "'") = True Then
                            frmMsgOK.HienThi("Tên chức vụ này đã tồn tại", "Thông báo", False)
                            Me.txtTenCV.Focus()
                        Else
                            'Thực hiện thêm giá trị mới vào CSDL
                            strSQL = "Insert into tblChucVu (MaCV,TenCV,TenCVBH,PhuCap) Values(N'" & Me.txtMaCV.Text.Trim & "',N'" & Me.txtTenCV.Text.Trim & "',N'" & Me.txtTenCVBHXH.Text.Trim & "',N'" & Me.txtPhuCap.Text.Trim & "')"
                            objConnect.RunSQL(strSQL)
                            If (frmMsgYesNo.HienThi("Bạn có muốn nhập tiếp không ?", "Thông báo") = Windows.Forms.DialogResult.Yes) Then
                                Call ResetValues()
                            Else
                                Me.Dispose()
                            End If
                        End If
                    End If
                End If
            Case False 'Sua
                Dim strSQL As String
                If NhapLieu.ChuaDuThongTin("NN", ErrorProvider) = True Then
                    frmMsgOK.HienThi("Thông tin bạn nhập vào chưa hợp lệ", "Thông báo")
                Else
                    If objConnect.DaTonTai("Select * From tblChucVu Where MaCV Like N'" & Me.txtMaCV.Text.Trim & "' And MaCV Not Like N'" & strMa_Cu & "'") = True Then
                        frmMsgOK.HienThi("Mã chức vụ này đã tồn tại", "Thông báo", False)
                        Me.txtMaCV.Focus()
                    Else
                        If objConnect.DaTonTai("Select * From tblChucVu Where TenCV Like N'" & Me.txtTenCV.Text.Trim & "' And TenCV Not Like N'" & strTen_Cu & "'") = True Then
                            frmMsgOK.HienThi("Tên chức vụ này đã tồn tại", "Thông báo", False)
                            Me.txtTenCV.Focus()
                        Else
                            'Thực hiện sửa giá trị mới vào CSDL
                            strSQL = "Update tblChucVu Set MaCV =N'" & Me.txtMaCV.Text.Trim.ToString & "',TenCV = N'" & Me.txtTenCV.Text.Trim.ToString & "',TenCVBH = N'" & Me.txtTenCVBHXH.Text.Trim.ToString & "',PhuCap = N'" & Convert.ToInt64(Me.txtPhuCap.Text.Trim) & "' Where MaCV like N'" & strMa_Cu & "'"
                            objConnect.RunSQL(strSQL)
                            'Thực hiện cập nhật giá trị cho các bảng có liên quan như tblNhanVien
                            Try
                                objConnect.RunSQL("Update tblNhanVien Set MaCV=N'" & Me.txtMaCV.Text.Trim & "' Where MaCV=N'" & strMa_Cu & "'")
                            Catch ex As Exception

                            End Try
                            Me.Dispose()
                        End If
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

    'Private Sub DataGridView_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView.Click
    '    NhapLieu.RemoveErrorProvider("NN", ErrorProvider)
    '    If ((btnThem.Enabled = True) And (Me.DataGridView.RowCount > 0)) Then
    '        'Lưu dữ liệu cũ
    '        strMa_Cu = Me.DataGridView.CurrentRow.Cells("MaCV").Value
    '        strTen_Cu = Me.DataGridView.CurrentRow.Cells("TenCV").Value
    '        Me.txtMaCV.Text = Me.DataGridView.CurrentRow.Cells("MaCV").Value.ToString
    '        Me.txtTenCV.Text = Me.DataGridView.CurrentRow.Cells("TenCV").Value.ToString
    '        Me.txtTenCVBHXH.Text = Me.DataGridView.CurrentRow.Cells("TenCVBH").Value.ToString
    '        Me.txtPhuCap.Text = Me.DataGridView.CurrentRow.Cells("PhuCap").Value.ToString
    '        Me.btnSua.Enabled = True
    '        Me.btnXoa.Enabled = True
    '        Me.btnHuyBo.Enabled = True
    '        Me.btnThem.Enabled = False
    '        Call HieuNangDieuKhien()
    '    End If
    'End Sub

    Private Sub txtPhuCap_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPhuCap.KeyPress
        If InStr("0123456789" & Chr(8), e.KeyChar) < 1 Then
            e.Handled = True
        End If
    End Sub

    
End Class