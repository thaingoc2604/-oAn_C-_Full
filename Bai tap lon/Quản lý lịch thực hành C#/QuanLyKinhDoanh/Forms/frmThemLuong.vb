Public Class frmThemLuong
    Dim strNgayXL_Cu, IDR As String
    'Phương thức đặt thuộc tính Enabled =False cho các điều khiển nhập liệu
    Private Sub VoHieuNangDieuKhien()
        Me.txtHeSo.Enabled = False
        Me.mskNgayXepLuong.Enabled = False
        Me.txtLuongCoBan.Enabled = False
        Me.txtPhuCap.Enabled = False
        Me.txtLyDoPhuCap.Enabled = False
    End Sub

    Private Sub HieuNangDieuKhien()
        Me.txtHeSo.Enabled = True
        Me.mskNgayXepLuong.Enabled = True
        Me.txtLuongCoBan.Enabled = True
        Me.txtPhuCap.Enabled = True
        Me.txtLyDoPhuCap.Enabled = True
    End Sub

    Private Sub ResetValues()
        Me.txtHeSo.Text = ""
        Me.mskNgayXepLuong.Text = ""
        Me.txtLuongCoBan.Text = ""
        Me.txtPhuCap.Text = ""
        Me.txtLyDoPhuCap.Text = ""
    End Sub

    Friend Sub LoadData()
        Dim strColumnsHeader As String = "Ngày xếp lương, Lương cơ bản, Hệ số,Phụ cấp, Lý do phụ cấp"
        Dim strSQL As String = "Select NgayXL,LuongCB,HeSo,PhuCap,LyDoPhuCap,IDR From tblHoSoLuong Where MaNV =N'" & Me.txtMaNV.Text & "'"

        'Tải dữ liệu vào DataGridView
        objConnect.Load_DataGridView(Me.DataGridView, strColumnsHeader, strSQL)
    End Sub

    Private Sub frmThemLuong_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmThemLuong_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call LoadData()
        If Me.DataGridView.RowCount > 0 Then
            Me.btnXoa.Enabled = True
        Else
            Me.btnXoa.Enabled = False
        End If
        Call VoHieuNangDieuKhien()
        Me.btnSua.Enabled = False
        Me.btnLuu.Enabled = False
        Me.btnHuyBo.Enabled = False
    End Sub

    Private Sub btnThem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnThem.Click
        Me.btnSua.Enabled = False
        Me.btnXoa.Enabled = False
        Me.btnHuyBo.Enabled = True
        Me.btnLuu.Enabled = True
        Me.btnThem.Enabled = False
        Call ResetValues()
        Call HieuNangDieuKhien()
    End Sub

    Private Sub btnSua_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSua.Click
        Dim strSQL As String
        If NhapLieu.ChuaDuThongTin("NN", ErrorProvider) = True Then
            frmMsgOK.HienThi("Thông tin bạn nhập vào chưa hợp lệ", "Thông báo")
        Else
            If objConnect.DaTonTai("Select * From tblHoSoLuong Where MaNV Like N'" & Me.txtMaNV.Text.Trim & "' And Left(NgayXL,8)= N'" & Strings.Left(strNgayXL_Cu, 8) & "' And IDR not like '" & IDR & "'") = True Then
                frmMsgOK.HienThi("Ngày xếp lương này đã tồn tại", "Thông báo")
                Me.mskNgayXepLuong.Focus()
            Else
               
                'Thực hiện sửa giá trị mới vào CSDL
                strSQL = "Update tblHoSoLuong Set NgayXL =N'" & NhapLieu.CDateTime(mskNgayXepLuong) & "',LuongCB = N'" & Me.txtLuongCoBan.Text.Trim & "',HeSo = N'" & Me.txtHeSo.Text.Trim & "',PhuCap = N'" & txtPhuCap.Text.Trim & "',LyDoPhuCap = N'" & txtLyDoPhuCap.Text.Trim & "' Where IDR like N'" & IDR & "'"
                objConnect.RunSQL(strSQL)
                'Làm mới dữ liệu trên DataGridView
                Call LoadData()
                Call ResetValues()
                Me.btnHuyBo.Enabled = False
                Me.btnSua.Enabled = False
                Me.btnThem.Enabled = True
                Call VoHieuNangDieuKhien()
            End If
        End If

    End Sub

    Private Sub btnLuu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLuu.Click
        Dim strSQL As String
        If NhapLieu.ChuaDuThongTin("NN", ErrorProvider) = True Then
            frmMsgOK.HienThi("Thông tin bạn nhập vào chưa hợp lệ", "Thông báo")
        Else
            If objConnect.DaTonTai("Select * From tblHoSoLuong Where MaNV Like N'" & Me.txtMaNV.Text.Trim & "' And Left(NgayXL,8)= N'" & mskNgayXepLuong.Text & "'") = True Then
                frmMsgOK.HienThi("Ngày xếp lương này đã tồn tại", "Thông báo")
                Me.mskNgayXepLuong.Focus()
            Else

                'Thực hiện sửa giá trị mới vào CSDL
                strSQL = "Insert into tblHoSoLuong(MaNV,NgayXL,LuongCB,HeSo,PhuCap,LyDoPhuCap) Values (N'" & Me.txtMaNV.Text.Trim & "',N'" & NhapLieu.CDateTime(Me.mskNgayXepLuong) & "',N'" & txtLuongCoBan.Text.Trim & "',N'" & txtHeSo.Text.Trim & "',N'" & txtPhuCap.Text.Trim & "',N'" & txtLyDoPhuCap.Text.Trim & "')"
                objConnect.RunSQL(strSQL)
                'Làm mới dữ liệu trên DataGridView
                Call LoadData()
                Call ResetValues()
                Me.btnHuyBo.Enabled = False
                Me.btnSua.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnThoat_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub

    Private Sub btnHuyBo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnHuyBo.Click
        Call ResetValues()
        Me.btnHuyBo.Enabled = False
        Me.btnThem.Enabled = True
        If DataGridView.RowCount > 0 Then
            Me.btnXoa.Enabled = True
        Else
            Me.btnXoa.Enabled = False
        End If
        Me.btnSua.Enabled = False
        Me.btnLuu.Enabled = False
        Call VoHieuNangDieuKhien()
        NhapLieu.RemoveErrorProvider("NN", ErrorProvider)   'Ẩn điều khiển Errprovider nếu vẫn xuất hiện trên điều khiển nhập liệu
    End Sub

    Private Sub btnXoa_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnXoa.Click
        If Me.DataGridView.RowCount > 0 Then
            Dim strSQL As String = "Delete From tblHoSoLuong Where IDR Like N'" & Me.DataGridView.CurrentRow.Cells("IDR").Value & "'"
            
            If frmMsgYesNo.HienThi("Bạn có chắc chắn muốn xóa không ?", "Thông báo", False) = Windows.Forms.DialogResult.Yes Then
                objConnect.RunSQL(strSQL)
                Call LoadData()
                Call ResetValues()
                Me.btnSua.Enabled = False
                Call VoHieuNangDieuKhien()
                If Me.DataGridView.RowCount < 1 Then
                    Me.btnXoa.Enabled = False
                End If
            End If
        End If

    End Sub

    Private Sub DataGridView_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView.Click
        NhapLieu.RemoveErrorProvider("NN", ErrorProvider)
        If ((btnThem.Enabled = True) And (Me.DataGridView.RowCount > 0)) Then
            strNgayXL_Cu = Me.DataGridView.CurrentRow.Cells("NgayXL").Value
            IDR = Me.DataGridView.CurrentRow.Cells("IDR").Value
            Me.mskNgayXepLuong.Text = Me.DataGridView.CurrentRow.Cells("NgayXL").Value.ToString
            Me.txtLuongCoBan.Text = Me.DataGridView.CurrentRow.Cells("LuongCB").Value.ToString
            Me.txtHeSo.Text = Me.DataGridView.CurrentRow.Cells("HeSo").Value.ToString
            Me.txtPhuCap.Text = Me.DataGridView.CurrentRow.Cells("PhuCap").Value.ToString
            Me.txtLyDoPhuCap.Text = Me.DataGridView.CurrentRow.Cells("LyDoPhuCap").Value.ToString
            Me.btnSua.Enabled = True
            Me.btnThem.Enabled = False
            Me.btnXoa.Enabled = True
            Me.btnHuyBo.Enabled = True
            Call HieuNangDieuKhien()
        End If
    End Sub

    Private Sub txtLuongCoBan_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLuongCoBan.KeyPress, txtPhuCap.KeyPress
        If InStr("0123456789" & Chr(8), e.KeyChar) < 1 Then
            e.Handled = True
        End If

    End Sub

   

    Private Sub txtHeSo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtHeSo.LostFocus
        If Not IsNumeric(sender.text) Then
            frmMsgOK.HienThi("Hệ số phải là số", "Thông báo")
        Else
            If sender.text <= 0 Then
                frmMsgOK.HienThi("Hệ số phải là số lớn hơn 0", "Thông báo")
            End If
        End If
    End Sub
End Class