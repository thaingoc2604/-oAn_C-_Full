Public Class frmKho
    Friend strMa_Cu As String
    Friend strTen_Cu As String
    'Phương thức đặt thuộc tính Enabled =True cho các điều khiển nhập liệu
    'Private Sub HieuNangDieuKhien()
    '    Me.txtTenKho.Enabled = True
    '    Me.txtDiaChi.Enabled = True
    '    Me.mskDienThoai.Enabled = True
    '    Me.txtTenKho.Focus()
    'End Sub

    'Phương thức đặt thuộc tính Enabled =False cho các điều khiển nhập liệu
    'Private Sub VoHieuNangDieuKhien()
    '    Me.txtTenKho.Enabled = False
    '    Me.txtDiaChi.Enabled = False
    '    Me.mskDienThoai.Enabled = False
    'End Sub

    Private Sub ResetValues()
        Me.txtTenKho.Text = ""
        Me.txtDiaChi.Text = ""
        Me.mskDienThoai.Text = ""
    End Sub

    'Private Sub frmKho_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    '    objConnect.Load_DataGridView(Me.DataGridView, "Mã kho,Tên kho,Địa chỉ,Điện thoại", "Select MaKho,TenKho,DiaChi,DienThoai From tblKho Order by TenKho")
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
    '        Dim strSQL As String = "Delete From tblKho Where MaKho Like N'" & Me.DataGridView.CurrentRow.Cells("MaKho").Value & "'"
    '        Dim blnPhieuNhapKho, blnPhieuXuatKho As Boolean
    '        blnPhieuNhapKho = objConnect.DaTonTai("Select * From tblPhieuNhapKho Where MaKho Like N'" & Me.DataGridView.CurrentRow.Cells("MaKho").Value & "'")
    '        blnPhieuXuatKho = objConnect.DaTonTai("Select * From tblPhieuXuatKho Where MaKho Like N'" & Me.DataGridView.CurrentRow.Cells("MaKho").Value & "'")
    '        If (blnPhieuNhapKho Or blnPhieuXuatKho) = True Then
    '            frmMsgOK.HienThi("Kho này đang được sử dụng bạn không thể xóa nó", "Thông báo", False)
    '        Else
    '            If frmMsgYesNo.HienThi("Bạn có chắc chắn muốn xóa không ?", "Thông báo", False) = Windows.Forms.DialogResult.Yes Then
    '                objConnect.RunSQL(strSQL)
    '                objConnect.Load_DataGridView(Me.DataGridView, "Mã kho,Tên kho,Địa chỉ,Điện thoại", "Select MaKho,TenKho,DiaChi,DienThoai From tblKho Order by TenKho")
    '                Call ResetValues()
    '                Me.btnSua.Enabled = False
    '                Me.btnHuyBo.Enabled = False
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
                    If objConnect.DaTonTai("Select * From tblKho Where TenKho Like N'" & Me.txtTenKho.Text.Trim & "'") = True Then
                        frmMsgOK.HienThi("Kho này đã tồn tại", "Thông báo", False)
                        Me.txtTenKho.Focus()
                    Else
                        'Thực hiện thêm giá trị mới vào CSDL
                        strSQL = "Insert into tblKho (TenKho,DiaChi,DienThoai) Values(N'" & Me.txtTenKho.Text.Trim & "',N'" & Me.txtDiaChi.Text.Trim & "',N'" & NhapLieu.getPhoneNumber(Me.mskDienThoai) & "')"
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

                    If objConnect.DaTonTai("Select * From tblKho Where TenKho Like N'" & Me.txtTenKho.Text.Trim & "' And TenKho Not Like N'" & strTen_Cu & "'") = True Then
                        frmMsgOK.HienThi("Tên kho này đã tồn tại", "Thông báo", False)
                        Me.txtTenKho.Focus()
                    Else
                        'Thực hiện sửa giá trị mới vào CSDL
                        strSQL = "Update tblKho Set TenKho = N'" & Me.txtTenKho.Text.Trim.ToString & "',DiaChi = N'" & Me.txtDiaChi.Text.Trim.ToString & "',DienThoai = N'" & NhapLieu.getPhoneNumber(Me.mskDienThoai) & "' Where MaKho like N'" & strMa_Cu & "'"
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

    'Private Sub DataGridView_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView.Click
    '    NhapLieu.RemoveErrorProvider("NN", ErrorProvider)
    '    If ((btnThem.Enabled = True) And (Me.DataGridView.RowCount > 0)) Then
    '        strMa_Cu = Me.DataGridView.CurrentRow.Cells("MaKho").Value
    '        strTen_Cu = Me.DataGridView.CurrentRow.Cells("TenKho").Value.ToString
    '        Me.txtTenKho.Text = Me.DataGridView.CurrentRow.Cells("TenKho").Value.ToString
    '        Me.txtDiaChi.Text = Me.DataGridView.CurrentRow.Cells("DiaChi").Value.ToString
    '        Me.mskDienThoai.Text = Me.DataGridView.CurrentRow.Cells("DienThoai").Value.ToString
    '        Me.btnSua.Enabled = True
    '        Me.btnXoa.Enabled = True
    '        Me.btnHuyBo.Enabled = True
    '        Me.btnThem.Enabled = False
    '        Call HieuNangDieuKhien()
    '    End If
    'End Sub

    Private Sub frmKho_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
        frmMainX.LoadData(25)
    End Sub
End Class