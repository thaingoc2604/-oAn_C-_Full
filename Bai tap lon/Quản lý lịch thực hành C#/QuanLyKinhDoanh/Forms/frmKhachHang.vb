Public Class frmKhachHang
    Friend strMa_Cu As String
    Private Sub frmKhachHang_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
        frmMainX.LoadData(24)
    End Sub

    Private Sub frmKhachHang_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If pThem = True Then
            'tạo nguồn dữ liệu cho combobox tỉnh thành phố
            objConnect.SetDataCombobox(Me.cboMaTinhTP, "Select MaTinhTP,TenTinhTP From tblTinhTP Order by TenTinhTP")
        End If                
    End Sub
    'Friend Sub LoadData(Optional ByVal strTimKiem As String = "")
    '    Dim strSQL As String
    '    Dim strColumnsHeader As String = "Mã KH,Tên KH,Công ty,Người đại diện,Địa chỉ,Tỉnh TP,MST,Số tài khoản,Mở tại,Điện thoại,Email,Fax,Website"
    '    strSQL = "Select MaKH,TenKH,CongTy,DaiDien,DiaChi,TenTinhTP,MST,SoTaiKhoan,"
    '    strSQL &= "NganHang,DienThoai,Email,Fax,Website,KhachLe,tblKhachHang.MaTinhTP "
    '    strSQL &= ("From tblTinhTP RIGHT JOIN tblKhachHang ON tblTinhTP.MaTinhTP=tblKhachHang.MaTinhTP ")
    '    strSQL &= ("Order by TenKH")
    '    If strTimKiem = "" Then 'Ở chế độ load thông thường
    '        'Tải dữ liệu vào DataGridView
    '        objConnect.Load_DataGridView(Me.DataGridView, strColumnsHeader, strSQL)
    '        'Đếm số bản ghi
    '        lblTongSoBanGhi.Text = "Tổng số bản ghi: " & Me.DataGridView.RowCount
    '    Else
    '        objConnect.Load_DataGridView(Me.DataGridView, strColumnsHeader, strTimKiem)
    '        'Đếm số bản ghi
    '        lblTongSoBanGhi.Text = "Kết quả tìm kiếm: " & Me.DataGridView.RowCount
    '    End If
    'End Sub

    'Phương thức đặt thuộc tính Enabled =True cho các điều khiển nhập liệu
    'Private Sub HieuNangDieuKhien()
    '    Me.txtTenKH.Enabled = True
    '    Me.txtCongTy.Enabled = True
    '    Me.txtDaiDien.Enabled = True
    '    Me.txtDiaChi.Enabled = True
    '    Me.cboMaTinhTP.Enabled = True
    '    Me.txtMST.Enabled = True
    '    Me.txtTaiKhoan.Enabled = True
    '    Me.txtNganHang.Enabled = True
    '    Me.mskDienThoai.Enabled = True
    '    Me.mskFax.Enabled = True
    '    Me.txtEmail.Enabled = True
    '    Me.txtWebsite.Enabled = True
    '    Me.chkKhachLe.Enabled = True
    '    Me.btnThemTinhTP.Enabled = True
    '    Me.txtTenKH.Focus()
    'End Sub
    'Phương thức đặt thuộc tính Enabled =False cho các điều khiển nhập liệu
    'Private Sub VoHieuNangDieuKhien()
    '    Me.txtTenKH.Enabled = False
    '    Me.txtCongTy.Enabled = False
    '    Me.txtDaiDien.Enabled = False
    '    Me.txtDiaChi.Enabled = False
    '    Me.cboMaTinhTP.Enabled = False
    '    Me.txtMST.Enabled = False
    '    Me.txtTaiKhoan.Enabled = False
    '    Me.txtNganHang.Enabled = False
    '    Me.mskDienThoai.Enabled = False
    '    Me.mskFax.Enabled = False
    '    Me.txtEmail.Enabled = False
    '    Me.txtWebsite.Enabled = False
    '    Me.chkKhachLe.Enabled = False
    '    Me.chkKhachLe.Checked = True
    '    Me.btnThemTinhTP.Enabled = False
    '    Me.cboMaTinhTP.SelectedIndex = -1
    'End Sub
    'Phương thức xóa dữ liệu trên điều khiển nhập liệu
    Private Sub ResetValues()
        Me.txtTenKH.Text = ""
        Me.txtCongTy.Text = ""
        Me.txtDaiDien.Text = ""
        Me.txtDiaChi.Text = ""
        Me.cboMaTinhTP.SelectedIndex = -1
        Me.txtMST.Text = ""
        Me.txtTaiKhoan.Text = ""
        Me.txtNganHang.Text = ""
        Me.mskDienThoai.Text = ""
        Me.mskFax.Text = ""
        Me.txtEmail.Text = ""
        Me.txtWebsite.Text = ""
        Me.chkKhachLe.Checked = True
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
    '    Me.txtTenKH.Focus()
    'End Sub

    'Private Sub btnSua_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSua.Click

    'End Sub
    'Phương thức xóa dữ liệu trong CSDL được chọn từ Datagridview 
    'Private Sub btnXoa_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnXoa.Click
    '    If Me.DataGridView.RowCount > 0 Then
    '        Dim strSQL As String = "Delete From tblKhachHang Where MaKH Like N'" & Me.DataGridView.CurrentRow.Cells("MaKH").Value & "'"
    '        Dim blnPhieuXuatKho As Boolean
    '        blnPhieuXuatKho = objConnect.DaTonTai("Select * From tblPhieuXuatKho Where MaKH Like N'" & Me.DataGridView.CurrentRow.Cells("MaKH").Value & "'")
    '        If (blnPhieuXuatKho) = True Then
    '            frmMsgOK.HienThi("Mã khách hàng này đang được sử dụng bạn không thể xóa nó", "Thông báo", False)
    '        Else
    '            If frmMsgYesNo.HienThi("Bạn có chắc chắn muốn xóa không ?", "Thông báo", False) = Windows.Forms.DialogResult.Yes Then
    '                objConnect.RunSQL(strSQL)
    '                Call LoadData()
    '                Call ResetValues()
    '                Me.btnSua.Enabled = False
    '                Call VoHieuNangDieuKhien()
    '                Me.btnThem.Enabled = True
    '                Me.btnLuu.Enabled = False
    '                Me.btnHuyBo.Enabled = False
    '                If Me.DataGridView.RowCount < 1 Then
    '                    Me.btnXoa.Enabled = False
    '                    Me.btnTimKiem.Enabled = False
    '                    Me.btnNap.Enabled = False
    '                    Me.btnIn.Enabled = False
    '                Else
    '                    Me.btnXoa.Enabled = True
    '                    Me.btnTimKiem.Enabled = True
    '                    Me.btnNap.Enabled = True
    '                    Me.btnIn.Enabled = True
    '                End If
    '            End If
    '        End If
    '    End If
    'End Sub

    'Phương thức lưu giá trị mới vào CSDL
    Private Sub btnLuu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLuu.Click
        Select Case pThem
            Case True
                Dim strSQL As String
                If NhapLieu.ChuaDuThongTin("NN", ErrorProvider) = True Then
                    frmMsgOK.HienThi("Thông tin bạn nhập vào chưa đủ", "Thông báo")
                Else
                    'Thực hiện thêm giá trị mới vào CSDL
                    strSQL = "Insert into tblKhachHang (TenKH,CongTy,DaiDien,DiaChi,MaTinhTP,MST,SoTaiKhoan,NganHang,DienThoai,Email,Fax,Website,KhachLe) " _
                           & "Values (N'" & Me.txtTenKH.Text.Trim & "'," _
                           & "N'" & Me.txtCongTy.Text.Trim & "'," _
                           & "N'" & Me.txtDaiDien.Text.Trim & "'," _
                           & "N'" & Me.txtDiaChi.Text.Trim & "'," _
                           & "N'" & Me.cboMaTinhTP.SelectedValue & "'," _
                           & "N'" & Me.txtMST.Text.Trim & "'," _
                           & "N'" & Me.txtTaiKhoan.Text.Trim & "'," _
                           & "N'" & Me.txtNganHang.Text.Trim & "'," _
                           & "N'" & NhapLieu.getPhoneNumber(Me.mskDienThoai) & "'," _
                           & "N'" & Me.txtEmail.Text.Trim & "'," _
                           & "N'" & NhapLieu.getPhoneNumber(Me.mskFax) & "'," _
                           & "N'" & Me.txtWebsite.Text.Trim & "'," _
                           & "N'" & IIf(Me.chkKhachLe.Checked = True, True, False) & "')"
                    objConnect.RunSQL(strSQL)  'Thực hiện thêm mới bản ghi
                    If (frmMsgYesNo.HienThi("Bạn có muốn nhập tiếp không ?", "Thông báo") = Windows.Forms.DialogResult.Yes) Then
                        Call ResetValues()
                    Else
                        Me.Dispose()
                    End If
                End If
            Case False
                Dim strSQL As String
                If NhapLieu.ChuaDuThongTin("NN", ErrorProvider) = True Then
                    frmMsgOK.HienThi("Thông tin bạn nhập vào chưa hợp lệ", "Thông báo")
                Else
                    'Thực hiện sửa giá trị mới vào CSDL
                    strSQL = "Update tblKhachHang Set TenKH =N'" & Me.txtTenKH.Text.Trim.ToString & "',"
                    strSQL &= "CongTy = N'" & Me.txtCongTy.Text.Trim.ToString & "',"
                    strSQL &= "DaiDien = N'" & Me.txtDaiDien.Text.Trim.ToString & "',"
                    strSQL &= "DiaChi = N'" & Me.txtDiaChi.Text.Trim.ToString & "',"
                    strSQL &= "MaTinhTP = N'" & Me.cboMaTinhTP.SelectedValue & "',"
                    strSQL &= "MST=N'" & Me.txtMST.Text.Trim & "',"
                    strSQL &= "SoTaiKhoan=N'" & Me.txtTaiKhoan.Text.Trim & "',"
                    strSQL &= "NganHang=N'" & Me.txtNganHang.Text.Trim & "',"
                    strSQL &= "DienThoai=N'" & NhapLieu.getPhoneNumber(Me.mskDienThoai) & "',"
                    strSQL &= "Email=N'" & Me.txtEmail.Text.Trim.ToString & "',"
                    strSQL &= "Fax=N'" & NhapLieu.getPhoneNumber(Me.mskFax) & "',"
                    strSQL &= "Website=N'" & Me.txtWebsite.Text.Trim & "',"
                    strSQL &= "KhachLe=N'" & IIf(Me.chkKhachLe.Checked = True, True, False) & "' "
                    strSQL &= "Where MaKH Like N'" & strMa_Cu & "'"
                    objConnect.RunSQL(strSQL)
                    'Làm mới dữ liệu trên DataGridView
                    frmMsgOK.HienThi("Sửa thành công", "Thông báo")
                    Me.Dispose()
                End If
        End Select
        
    End Sub

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

    'Private Sub DataGridView_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView.Click
    '    NhapLieu.RemoveErrorProvider("NN", ErrorProvider)
    '    If ((btnThem.Enabled = True) And (Me.DataGridView.RowCount > 0)) Then
    '        strMa_Cu = Me.DataGridView.CurrentRow.Cells("MaKH").Value.ToString
    '        Me.txtTenKH.Text = Me.DataGridView.CurrentRow.Cells("TenKH").Value.ToString
    '        Me.txtCongTy.Text = Me.DataGridView.CurrentRow.Cells("CongTy").Value.ToString
    '        Me.txtDaiDien.Text = Me.DataGridView.CurrentRow.Cells("DaiDien").Value.ToString
    '        Me.txtDiaChi.Text = Me.DataGridView.CurrentRow.Cells("DiaChi").Value.ToString
    '        Me.cboMaTinhTP.SelectedValue = Me.DataGridView.CurrentRow.Cells("MaTinhTP").Value.ToString
    '        Me.txtMST.Text = Me.DataGridView.CurrentRow.Cells("MST").Value.ToString
    '        Me.txtTaiKhoan.Text = Me.DataGridView.CurrentRow.Cells("SoTaiKhoan").Value.ToString
    '        Me.txtNganHang.Text = Me.DataGridView.CurrentRow.Cells("NganHang").Value.ToString
    '        Me.mskDienThoai.Text = Me.DataGridView.CurrentRow.Cells("DienThoai").Value.ToString
    '        Me.txtEmail.Text = Me.DataGridView.CurrentRow.Cells("Email").Value.ToString
    '        Me.mskFax.Text = Me.DataGridView.CurrentRow.Cells("Fax").Value.ToString
    '        Me.txtWebsite.Text = Me.DataGridView.CurrentRow.Cells("Website").Value.ToString
    '        Me.chkKhachLe.Checked = Me.DataGridView.CurrentRow.Cells("KhachLe").Value.ToString
    '        Me.btnSua.Enabled = True
    '        Me.btnXoa.Enabled = True
    '        Me.btnThem.Enabled = False
    '        Me.btnHuyBo.Enabled = True
    '        Me.btnTimKiem.Enabled = False
    '        Me.btnNap.Enabled = False
    '        Me.btnIn.Enabled = False
    '        Call HieuNangDieuKhien()
    '    End If
    'End Sub

    Private Sub txtMST_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMST.KeyPress, txtTaiKhoan.KeyPress
        NhapLieu.PhaiNhapSo(e)
    End Sub

    

    Private Sub cboMaTinhTP_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboMaTinhTP.GotFocus
        objConnect.SetDataCombobox(Me.cboMaTinhTP, "Select MaTinhTP,TenTinhTP From tblTinhTP Order by TenTinhTP")
    End Sub

    Private Sub btnThemTinhTP_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnThemTinhTP.Click
        pThem = True
        frmTinhTP.Show()
    End Sub

    Private Sub btnTimKiem_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        frmTimKiemKhachHang.ShowDialog()
    End Sub

    'Private Sub btnNap_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNap.Click
    '    Call LoadData()
    'End Sub

    'Private Sub btnIn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnIn.Click
    '   If Me.DataGridView.RowCount > 0 Then
    '        Dim strSQL As String
    '        Dim strMaNV As String
    '        strMaNV = NhapLieu.LayMa(Me.DataGridView, 0)
    '        strSQL = "Select * From view_KhachHang Where MaKH in (" & strMaNV & ")"
    '        frmBaoCao.PreviewReport(strSQL, 10) '12=in danh sách nhân viên
    '        frmBaoCao.ShowDialog()
    '    Else
    '        frmMsgOK.HienThi("Không có bản ghi nào được chọn", "Thông báo", False)
    '    End If
    'End Sub
End Class