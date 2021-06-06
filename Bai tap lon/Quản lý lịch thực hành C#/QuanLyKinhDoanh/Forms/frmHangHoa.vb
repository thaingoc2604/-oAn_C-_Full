Public Class frmHangHoa
    Friend strMa_Cu As String
    Friend strTen_Cu As String
    Private Sub frmHangHoa_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
        frmMainX.LoadData(27)
    End Sub

    Private Sub frmHangHoa_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load       
        Call SetData_cboDVT()
        If pThem = True Then
            'tạo nguồn dữ liệu cho combobox Mã nhóm hàng
            objConnect.SetDataCombobox(Me.cboMaNhom, "Select MaNhom,TenNhom From tblNhomHang Order by TenNhom")
            cboMaNhom.SelectedIndex = -1
        End If
    End Sub

    
    'Phương thức tạo nguồn dữ liệu cho cboDVT
    Private Sub SetData_cboDVT()
        Me.cboDVT.Items.Add("Cái")
        Me.cboDVT.Items.Add("Cuộn")
        Me.cboDVT.Items.Add("Hộp")
        Me.cboDVT.Items.Add("Bao")
        Me.cboDVT.Items.Add("Kg")
        Me.cboDVT.Items.Add("m")
        Me.cboDVT.Items.Add("m2")
        Me.cboDVT.Items.Add("m3")
        Me.cboDVT.Items.Add("Lít")
        Me.cboDVT.Items.Add("Bó")
        Me.cboDVT.Sorted = True
    End Sub

    

    'Phương thức xóa dữ liệu trên điều khiển nhập liệu
    Private Sub ResetValues()
        Me.txtMaHang.Text = ""
        Me.txtTenHang.Text = ""
        Me.cboDVT.SelectedIndex = -1
        Me.txtDGBan.Text = ""
        Me.txtThueVAT.Text = ""
        Me.cboMaNhom.SelectedIndex = -1
        Me.txtXuatSu.Text = ""
        Me.txtDuongDan.Text = ""
        Me.btnChonAnh.Enabled = False
        Me.btnXoaAnh.Enabled = False
        Me.picPhoto.Image = Nothing
    End Sub

    'Private Sub btnThem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnThem.Click
    '    Me.btnSua.Enabled = False
    '    Me.btnXoa.Enabled = False
    '    Me.btnHuyBo.Enabled = True
    '    Me.btnLuu.Enabled = True
    '    Me.btnThem.Enabled = False
    '    Call ResetValues()
    '    Call HieuNangDieuKhien()
    '    Me.btnTimKiem.Enabled = False
    '    Me.btnNap.Enabled = False
    '    Me.btnIn.Enabled = False
    'End Sub

    'Phương thức sửa dữ liệu 
    'Private Sub btnSua_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSua.Click

    'End Sub

    'Phương thức xóa bản ghi
    ''Private Sub btnXoa_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnXoa.Click
    ''    If Me.DataGridView.RowCount > 0 Then
    ''        Dim strSQL As String = "Delete From tblHangHoa Where MaH Like N'" & Me.DataGridView.CurrentRow.Cells("MaH").Value & "'"
    ''        Dim blnCTPhieuNhapKho, blnCTPhieuXuatKho As Boolean
    ''        blnCTPhieuNhapKho = objConnect.DaTonTai("Select * From tblCTPhieuNhapKho Where MaH Like N'" & Me.DataGridView.CurrentRow.Cells("MaH").Value & "'")
    ''        blnCTPhieuXuatKho = objConnect.DaTonTai("Select * From tblCTPhieuXuatKho Where MaH Like N'" & Me.DataGridView.CurrentRow.Cells("MaH").Value & "'")
    ''        If (blnCTPhieuNhapKho Or blnCTPhieuXuatKho) = True Then
    ''            frmMsgOK.HienThi("Mã hàng này đang được sử dụng bạn không thể xóa nó", "Thông báo", False)
    ''        Else
    ''            If frmMsgYesNo.HienThi("Bạn có chắc chắn muốn xóa không ?", "Thông báo", False) = Windows.Forms.DialogResult.Yes Then
    ''                objConnect.RunSQL(strSQL)
    ''                Call LoadData()
    ''                Call ResetValues()
    ''                Me.btnSua.Enabled = False
    ''                Call VoHieuNangDieuKhien()
    ''                Me.btnThem.Enabled = True
    ''                Me.btnLuu.Enabled = False
    ''                Me.btnHuyBo.Enabled = False
    ''                If Me.DataGridView.RowCount < 1 Then
    ''                    Me.btnXoa.Enabled = False
    ''                    Me.btnTimKiem.Enabled = False
    ''                    Me.btnNap.Enabled = False
    ''                    Me.btnIn.Enabled = False
    ''                Else
    ''                    Me.btnXoa.Enabled = True
    ''                    Me.btnTimKiem.Enabled = True
    ''                    Me.btnNap.Enabled = True
    ''                    Me.btnIn.Enabled = True
    ''                End If
    ''            End If
    ''        End If
    ''    End If
    ''End Sub

    'Phương thức Lưu dùng để thêm mới 1 bản ghi vào CSDL
    Private Sub btnLuu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLuu.Click
        Select Case pThem
            Case True
                Dim strSQL As String
                If NhapLieu.ChuaDuThongTin("NN", ErrorProvider) = True Then
                    frmMsgOK.HienThi("Thông tin bạn nhập vào chưa hợp lệ", "Thông báo")
                Else
                    If objConnect.DaTonTai("Select * From tblHangHoa Where MaH Like N'" & Me.txtMaHang.Text.Trim & "'") = True Then
                        frmMsgOK.HienThi("Mã hàng này đã tồn tại", "Thông báo", False)
                        Me.txtMaHang.Focus()
                    Else
                        If objConnect.DaTonTai("Select * From tblHangHoa Where TenH Like N'" & Me.txtTenHang.Text.Trim & "'") = True Then
                            frmMsgOK.HienThi("Tên hàng hóa này đã tồn tại", "Thông báo", False)
                            Me.txtTenHang.Focus()
                        Else
                            'Thực hiện thêm giá trị mới vào CSDL
                            strSQL = "Insert into tblHangHoa (MaH,TenH,DVT,DGBan,ThueVAT,MaNhom,XuatSu,PhoTo) "
                            strSQL &= "Values (N'" & Me.txtMaHang.Text.Trim & "',"
                            strSQL &= "N'" & Me.txtTenHang.Text.Trim & "',"
                            strSQL &= "N'" & Me.cboDVT.Text.Trim & "',"
                            strSQL &= "N'" & Me.txtDGBan.Text.Trim & "',"
                            strSQL &= "N'" & Me.txtThueVAT.Text.Trim & "',"
                            strSQL &= "N'" & Convert.ToInt64((Me.cboMaNhom.SelectedValue)) & "',"
                            strSQL &= "N'" & Me.txtXuatSu.Text.Trim & "',"
                            strSQL &= "N'" & Me.txtDuongDan.Text.Trim & "')"
                            objConnect.RunSQL(strSQL)
                            If (frmMsgYesNo.HienThi("Bạn có muốn nhập tiếp không ?", "Thông báo") = Windows.Forms.DialogResult.Yes) Then
                                Call ResetValues()
                            Else
                                Me.Dispose()
                            End If
                        End If
                    End If
                End If
            Case False
                Dim strSQL As String
                If NhapLieu.ChuaDuThongTin("NN", ErrorProvider) = True Then
                    frmMsgOK.HienThi("Thông tin bạn nhập vào chưa hợp lệ", "Thông báo")
                Else
                    If objConnect.DaTonTai("Select * From tblHangHoa Where MaH Like N'" & Me.txtMaHang.Text.Trim & "' And MaH Not Like N'" & strMa_Cu & "'") = True Then
                        frmMsgOK.HienThi("Mã hàng này đã tồn tại", "Thông báo", False)
                        Me.txtMaHang.Focus()
                    Else
                        If objConnect.DaTonTai("Select * From tblHangHoa Where TenH Like N'" & Me.txtTenHang.Text.Trim & "' And TenH Not Like N'" & strTen_Cu & "'") = True Then
                            frmMsgOK.HienThi("Tên hàng này đã tồn tại", "Thông báo", False)
                            Me.txtTenHang.Focus()
                        Else
                            'Thực hiện sửa giá trị mới vào CSDL
                            strSQL = "Update tblHangHoa Set MaH =N'" & Me.txtMaHang.Text.Trim.ToString & "',"
                            strSQL &= "TenH = N'" & Me.txtTenHang.Text.Trim.ToString & "',"
                            strSQL &= "DVT = N'" & Me.cboDVT.Text.Trim.ToString & "',"
                            strSQL &= "DGBan=N'" & Me.txtDGBan.Text.Trim & "',"
                            strSQL &= "ThueVAT=N'" & Me.txtThueVAT.Text.Trim & "',"
                            strSQL &= "MaNhom = N'" & Me.cboMaNhom.SelectedValue & "',"
                            strSQL &= "XuatSu = N'" & Me.txtXuatSu.Text.Trim & "',"
                            strSQL &= "PhoTo=N'" & Me.txtDuongDan.Text.Trim & "'"
                            strSQL &= "Where MaH Like N'" & strMa_Cu & "'"
                            objConnect.RunSQL(strSQL)

                            'cập nhật dữ liệu cho các bảng có liên quan
                            objConnect.RunSQL("Update tblCTPhieuNhapKho Set MaH=N'" & Me.txtMaHang.Text.Trim & "' Where MaH=N'" & strMa_Cu & "'")
                            objConnect.RunSQL("Update tblCTPhieuXuatKho Set MaH=N'" & Me.txtMaHang.Text.Trim & "' Where MaH=N'" & strMa_Cu & "'")
                            frmMsgOK.HienThi("Sửa thành công", "Thông báo")
                            Me.Dispose()
                        End If
                    End If
                End If
        End Select
        
    End Sub

    'Phương thức hủy bỏ chế độ thêm mới, sửa
    'Private Sub btnHuyBo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnHuyBo.Click
    '    Call ResetValues()
    '    Me.btnHuyBo.Enabled = False
    '    Me.btnThem.Enabled = True

    '    If DataGridView.RowCount > 0 Then
    '        Me.btnXoa.Enabled = True
    '        Me.btnTimKiem.Enabled = True
    '        Me.btnNap.Enabled = True
    '        Me.btnIn.Enabled = True
    '    Else
    '        Me.btnXoa.Enabled = False
    '        Me.btnTimKiem.Enabled = False
    '        Me.btnNap.Enabled = False
    '        Me.btnIn.Enabled = False
    '    End If
    '    Me.btnSua.Enabled = False
    '    Me.btnLuu.Enabled = False
    '    Call VoHieuNangDieuKhien()
    '    NhapLieu.RemoveErrorProvider("NN", ErrorProvider)   'Ẩn điều khiển Errprovider nếu vẫn xuất hiện trên điều khiển nhập liệu
    'End Sub

    Private Sub btnThoat_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub

    Private Sub btnChonAnh_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnChonAnh.Click
        Me.txtDuongDan.Text = NhapLieu.ChonAnh(Me.picPhoto)
    End Sub

    'Private Sub DataGridView_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView.Click
    '    NhapLieu.RemoveErrorProvider("NN", ErrorProvider)
    '    If ((btnThem.Enabled = True) And (Me.DataGridView.RowCount > 0)) Then
    '        strMa_Cu = Me.DataGridView.CurrentRow.Cells("MaH").Value.ToString
    '        strTen_Cu = Me.DataGridView.CurrentRow.Cells("TenH").Value.ToString

    '        Me.txtMaHang.Text = Me.DataGridView.CurrentRow.Cells("MaH").Value.ToString
    '        Me.txtTenHang.Text = Me.DataGridView.CurrentRow.Cells("TenH").Value.ToString
    '        Me.cboDVT.Text = Me.DataGridView.CurrentRow.Cells("DVT").Value.ToString
    '        Me.txtSoLuongNhap.Text = Me.DataGridView.CurrentRow.Cells("SL_Nhap").Value.ToString
    '        Me.txtSoLuongBan.Text = Me.DataGridView.CurrentRow.Cells("SL_Xuat").Value.ToString
    '        Me.txtSoLuongTon.Text = Me.DataGridView.CurrentRow.Cells("SL_Ton").Value.ToString
    '        Me.txtDGBan.Text = Me.DataGridView.CurrentRow.Cells("DGBan").Value.ToString
    '        Me.txtThueVAT.Text = Me.DataGridView.CurrentRow.Cells("ThueVAT").Value.ToString
    '        Me.txtXuatSu.Text = Me.DataGridView.CurrentRow.Cells("XuatSu").Value.ToString
    '        Me.txtDuongDan.Text = Me.DataGridView.CurrentRow.Cells("PhoTo").Value.ToString
    '        Me.cboMaNhom.SelectedValue = Me.DataGridView.CurrentRow.Cells("MaNhom").Value.ToString

    '        'Hiển thị ảnh
    '        If Len(Me.txtDuongDan.Text.Trim) > 0 Then
    '            Try
    '                Me.picPhoto.Image = Image.FromFile(txtDuongDan.Text)
    '            Catch ex As Exception
    '                frmMsgOK.HienThi("Không tìm thấy file ảnh theo đường đường dẫn đã lưu, vui lòng chọn lại đường dẫn", "Thông báo")
    '            End Try
    '        Else
    '            Me.picPhoto.Image = Nothing
    '        End If
    '        Me.btnSua.Enabled = True
    '        Me.btnXoa.Enabled = True
    '        Me.btnThem.Enabled = False
    '        Me.btnTimKiem.Enabled = False
    '        Me.btnNap.Enabled = False
    '        Me.btnIn.Enabled = False
    '        Me.btnHuyBo.Enabled = True
    '        Call HieuNangDieuKhien()
    '    End If
    'End Sub

    'Phương thức nạp dữ liệu hủy chế độ tìm kiếm
   

    Private Sub btnXoaAnh_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnXoaAnh.Click
        Me.txtDuongDan.Text = ""
        Me.picPhoto.Image = Nothing
    End Sub

    Private Sub btnThemNhomHang_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnThemNhomHang.Click
        pThem = True
        frmNhomHang.Show()
    End Sub

    Private Sub cboMaNhom_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboMaNhom.GotFocus
        'tạo nguồn dữ liệu cho combobox Mã nhóm hàng
        objConnect.SetDataCombobox(Me.cboMaNhom, "Select MaNhom,TenNhom From tblNhomHang Order by TenNhom")
    End Sub

    'Private Sub btnTimKiem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTimKiem.Click
    '    frmTimKiemHangHoa.ShowDialog()
    'End Sub

    'Private Sub btnIn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnIn.Click
    '    Dim strSQL As String
    '    Dim strMaH As String
    '    strMaH = NhapLieu.LayMa(Me.DataGridView, 0)
    '    strSQL = "Select * From view_HangHoa Where MaH in (" & strMaH & ")"
    '    frmBaoCao.PreviewReport(strSQL, 6)
    '    frmBaoCao.ShowDialog 
    'End Sub

    Private Sub txtDGBan_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDGBan.KeyPress, txtThueVAT.KeyPress
        If InStr("0123456789" & Chr(8), e.KeyChar) < 1 Then
            e.Handled = True
        End If
    End Sub

End Class