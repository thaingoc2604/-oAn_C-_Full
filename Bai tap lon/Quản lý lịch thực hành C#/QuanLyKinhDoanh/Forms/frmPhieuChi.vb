Public Class frmPhieuChi
    Friend strMa_Cu As String
    Private Sub btnThoat_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        Me.Dispose()
    End Sub

    Private Sub frmPhieuChi_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed        
        Me.Dispose()
        frmMainX.LoadData(4)
    End Sub

    'Private Sub btnTimKiem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTimKiem.Click
    '    frmTimKiemPhieuChi.ShowDialog()
    '    frmTimKiemPhieuChi.ShowInTaskbar = False
    'End Sub

    'Private Sub btnNap_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNap.Click
    '    Call LoadData()
    'End Sub

    'Private Sub btnThemNCC_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    '    frmNhaCC.ShowDialog()
    '    frmNhaCC.ShowInTaskbar = False
    'End Sub

    'Phương thức đặt thuộc tính Enabled =True cho các điều khiển nhập liệu
    'Private Sub HieuNangDieuKhien()
    '    Me.txtMaPhieuChi.Enabled = True
    '    Me.mskNgayPC.Enabled = True
    '    Me.cboMaHD.Enabled = True
    '    Me.txtNhanVien.Enabled = True
    '    Me.txtNguoiNhan.Enabled = True
    '    Me.txtLyDoChi.Enabled = True
    '    Me.txtKemTheo.Enabled = True
    '    Me.txtSoTien.Enabled = True
    '    Me.btnThemNCC.Enabled = True
    '    Me.cboMaHD.Focus()
    'End Sub

    'Phương thức đặt thuộc tính Enabled =False cho các điều khiển nhập liệu
    'Private Sub VoHieuNangDieuKhien()
    '    Me.txtMaPhieuChi.Enabled = False
    '    Me.mskNgayPC.Enabled = False
    '    Me.cboMaHD.Enabled = False
    '    Me.txtNhanVien.Enabled = False
    '    Me.txtNguoiNhan.Enabled = False
    '    Me.txtLyDoChi.Enabled = False
    '    Me.txtKemTheo.Enabled = False
    '    Me.txtSoTien.Enabled = False
    '    Me.btnThemNCC.Enabled = False
    '    Me.txtMaPhieuChi.Focus()
    'End Sub

    'Phương thức xóa dữ liệu trên điều khiển nhập liệu
    Private Sub ResetValues()
        Me.txtMaPhieuChi.Text = ""
        Me.mskNgayPC.Text = Text = ""
        Me.cboMaHD.SelectedIndex = -1
        Me.txtNhanVien.Text = ""
        Me.txtNguoiNhan.Text = ""
        Me.txtLyDoChi.Text = ""
        Me.txtKemTheo.Text = ""
        Me.txtSoTien.Text = ""
    End Sub

    'Friend Sub LoadData(Optional ByVal strTimKiem As String = "")
    '    Dim strSQL As String
    '    Dim strColumnsHeader As String = "Mã PC,Ngày PC,Mã NCC,Mã NV,Người nhận tiền,Lý do chi,Kèm theo chứng từ,Số tiền"
    '    strSQL = "Select MaPC,NgayPC,MaNCC,MaNV,NguoiNhan,LyDoChi,KemTheoChungTu,SoTien From tblPhieuChi"

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
    '    Call TinhTong()
    'End Sub

    Private Sub frmPhieuChi_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
       
        If pThem = True Then
            'tạo nguồn dữ liệu cho combobox Mã nhà cung cấp
            objConnect.SetDataCombobox(Me.cboMaHD, "Select MaHDMH,MaHDMH From tblHoaDonMuaHang")
            Me.cboMaHD.SelectedIndex = -1
        End If
        'Nạp dữ liệu lên DataGridView
        '    Call LoadData()
        '    If Me.DataGridView.RowCount > 0 Then
        '        Me.btnTimKiem.Enabled = True
        '        Me.btnNap.Enabled = True
        '        Me.btnXoa.Enabled = True
        '        Me.btnIn.Enabled = True
        '    Else
        '        Me.btnTimKiem.Enabled = False
        '        Me.btnNap.Enabled = False
        '        Me.btnXoa.Enabled = False
        '        Me.btnIn.Enabled = False
        '    End If

        '    Call VoHieuNangDieuKhien()
        '    Me.btnSua.Enabled = False
        '    Me.btnLuu.Enabled = False
        '    Me.btnHuyBo.Enabled = False
        'End Sub

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
        '    Try
        '        Me.txtMaPhieuChi.Text = "PC" & Now.Hour & Now.Minute & Now.Second
        '        Me.mskNgayPC.Text = Now
        '        Me.txtNhanVien.Text = pTenNV
        '    Catch ex As Exception
        '    End Try

    End Sub

    'Private Sub btnSua_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSua.Click

    'End Sub

    'Private Sub btnXoa_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnXoa.Click
    '    If Me.DataGridView.RowCount > 0 Then
    '        Dim strSQL As String = "Delete From tblPhieuChi Where MaPC Like N'" & Me.DataGridView.CurrentRow.Cells("MaPC").Value & "'"
    '        If frmMsgYesNo.HienThi("Bạn có chắc chắn muốn xóa không ?", "Thông báo", False) = Windows.Forms.DialogResult.Yes Then
    '            objConnect.RunSQL(strSQL)
    '            Call LoadData()
    '            Call ResetValues()
    '            Me.btnSua.Enabled = False
    '            Call VoHieuNangDieuKhien()
    '            Me.btnThem.Enabled = True
    '            Me.btnLuu.Enabled = False
    '            Me.btnHuyBo.Enabled = False
    '            If Me.DataGridView.RowCount < 1 Then
    '                Me.btnXoa.Enabled = False
    '                Me.btnTimKiem.Enabled = False
    '                Me.btnNap.Enabled = False
    '                Me.btnIn.Enabled = False
    '            Else
    '                Me.btnXoa.Enabled = True
    '                Me.btnTimKiem.Enabled = True
    '                Me.btnNap.Enabled = True
    '                Me.btnIn.Enabled = True
    '            End If
    '        End If
    '    Else
    '        frmMsgOK.HienThi("Không có bản ghi nào được chọn", "Thông báo", False)
    '    End If
    'End Sub

    Private Sub btnLuu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLuu.Click
        Select Case pThem
            Case True
                Dim strSQL As String
                If NhapLieu.ChuaDuThongTin("NN", ErrorProvider) = True Then
                    frmMsgOK.HienThi("Thông tin bạn nhập vào chưa hợp lệ", "Thông báo")
                Else
                    If objConnect.DaTonTai("Select * From tblPhieuChi Where MaPC Like N'" & Me.txtMaPhieuChi.Text.Trim & "'") = True Then
                        frmMsgOK.HienThi("Phiếu chi này đã tồn tại", "Thông báo", False)
                        Me.txtMaPhieuChi.Focus()
                    Else
                        'Thực hiện thêm giá trị mới vào CSDL
                        strSQL = "Insert into tblPhieuChi (MaPC,NgayPC,MaHDMH,MaNV,NguoiNhan,LyDoChi,KemTheoChungTu,SoTien) "
                        strSQL &= "Values (N'" & Me.txtMaPhieuChi.Text.Trim & "',"
                        strSQL &= "N'" & NhapLieu.CDateTime(mskNgayPC) & "',"
                        strSQL &= "N'" & cboMaHD.SelectedValue & "',"
                        strSQL &= "N'" & pMaNV & "',"
                        strSQL &= "N'" & Me.txtNguoiNhan.Text.Trim & "',"
                        strSQL &= "N'" & Me.txtLyDoChi.Text.Trim & "',"
                        strSQL &= "N'" & Me.txtKemTheo.Text.Trim & "',"
                        strSQL &= "N'" & Me.txtSoTien.Text.Trim & "')"
                        objConnect.RunSQL(strSQL)
                        If (frmMsgYesNo.HienThi("Bạn có muốn nhập tiếp không ?", "Thông báo") = Windows.Forms.DialogResult.Yes) Then
                            Call ResetValues()
                            Try
                                Me.txtMaPhieuChi.Text = "PC" & Now.Hour & Now.Minute & Now.Second
                                Me.mskNgayPC.Text = Now
                                Me.txtNhanVien.Text = pTenNV
                            Catch ex As Exception
                            End Try
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
                    If objConnect.DaTonTai("Select * From tblPhieuChi Where MaPC Like N'" & Me.txtMaPhieuChi.Text.Trim & "' And MaPC Not Like N'" & strMa_Cu & "'") = True Then
                        frmMsgOK.HienThi("Mã phiếu chi này đã tồn tại", "Thông báo", False)
                        Me.txtMaPhieuChi.Focus()
                    Else
                        'Thực hiện sửa giá trị mới vào CSDL
                        strSQL = "Update tblPhieuChi Set MaPC =N'" & Me.txtMaPhieuChi.Text.Trim.ToString & "',"
                        strSQL &= "NgayPC = N'" & NhapLieu.CDateTime(mskNgayPC) & "',"
                        strSQL &= "MaHDMH = N'" & Me.cboMaHD.SelectedValue & "',"
                        strSQL &= "MaNV=N'" & pMaNV & "',"
                        strSQL &= "NguoiNhan=N'" & Me.txtNguoiNhan.Text.Trim & "',"
                        strSQL &= "LyDoChi = N'" & Me.txtLyDoChi.Text & "',"
                        strSQL &= "KemTheoChungTu = N'" & Me.txtKemTheo.Text.Trim & "',"
                        strSQL &= "SoTien=N'" & Me.txtSoTien.Text.Trim & "'"
                        strSQL &= "Where MaPC = N'" & strMa_Cu & "'"
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


    'Private Sub DataGridView_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView.Click
    '    NhapLieu.RemoveErrorProvider("NN", ErrorProvider)
    '    If ((btnThem.Enabled = True) And (Me.DataGridView.RowCount > 0)) Then
    '        strMa_Cu = Me.DataGridView.CurrentRow.Cells("MaPC").Value
    '        Me.txtMaPhieuChi.Text = Me.DataGridView.CurrentRow.Cells("MaPC").Value.ToString
    '        Me.mskNgayPC.Text = Me.DataGridView.CurrentRow.Cells("NgayPC").Value.ToString
    '        Me.cboMaHD.SelectedValue = Me.DataGridView.CurrentRow.Cells("MaNCC").Value.ToString
    '        Me.txtNhanVien.Text = pTenNV
    '        Me.txtNguoiNhan.Text = Me.DataGridView.CurrentRow.Cells("NguoiNhan").Value.ToString
    '        Me.txtLyDoChi.Text = Me.DataGridView.CurrentRow.Cells("LyDoChi").Value.ToString
    '        Me.txtKemTheo.Text = Me.DataGridView.CurrentRow.Cells("KemTheoChungTu").Value.ToString
    '        Me.txtSoTien.Text = Me.DataGridView.CurrentRow.Cells("SoTien").Value.ToString

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

    

    'Friend Sub TinhTong()
    '    Dim Tong_Tien As Double
    '    For i As Integer = 0 To Me.DataGridView.RowCount - 1
    '        Tong_Tien += Me.DataGridView.Rows(i).Cells("SoTien").Value
    '    Next
    '    Me.txtTongTien.Text = FormatNumber(Tong_Tien, 0)
    'End Sub

    Private Sub txtSoTien_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSoTien.KeyPress
        If InStr("0123456789" & Chr(8), e.KeyChar) < 1 Then
            e.Handled = True
        End If
    End Sub

    'Private Sub btnIn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnIn.Click
    '    If Me.DataGridView.RowCount > 0 Then
    '        Dim strSQL As String
    '        strSQL = "Select * From View_PhieuChi Where MaPC=N'" & Me.DataGridView.CurrentRow.Cells("MaPC").Value & "'"
    '        frmBaoCao.PreviewReport(strSQL, 8) '8 = phiếu chi
    '        frmBaoCao.ShowDialog()
    '    Else
    '        frmMsgOK.HienThi("Không có bản ghi nào được chọn", "Thông báo", False)
    '    End If
    'End Sub
End Class