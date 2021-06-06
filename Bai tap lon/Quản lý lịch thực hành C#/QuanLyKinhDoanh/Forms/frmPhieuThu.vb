Public Class frmPhieuThu
    Friend strMa_Cu As String
    Private Sub btnThoat_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub

    Private Sub frmPhieuThu_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
        'Làm mới dữ liệu trên DataGridView
        frmMainX.LoadData(7)
    End Sub

    Private Sub btnThemKH_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        frmKhachHang.ShowDialog()
        frmKhachHang.ShowInTaskbar = False
    End Sub

    

    'Phương thức xóa dữ liệu trên điều khiển nhập liệu
    Private Sub ResetValues()
        Me.txtMaPhieuThu.Text = ""
        Me.mskNgayPT.Text = Text = ""
        Me.cboMaHD.SelectedIndex = -1
        Me.txtNhanVien.Text = ""
        Me.txtNguoiNop.Text = ""
        Me.txtLyDoThu.Text = ""
        Me.txtKemTheo.Text = ""
        Me.txtSoTien.Text = ""
    End Sub

    

    Private Sub txtSoTien_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSoTien.KeyPress
        If InStr("0123456789" & Chr(8), e.KeyChar) < 1 Then
            e.Handled = True
        End If
    End Sub

    Private Sub frmPhieuThu_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
       
        If pThem = True Then
            'tạo nguồn dữ liệu cho combobox Mã khách hàng
            objConnect.SetDataCombobox(Me.cboMaHD, "Select MaHDBH,MaHDBH as M From tblHoaDonBanhang")
            Me.cboMaHD.SelectedIndex = -1
            Me.txtNhanVien.Text = pTenNV
            Dim tg As Date = Now
            Me.txtMaPhieuThu.Text = "PT" & tg.Hour & tg.Minute & tg.Second
            Try
                Me.mskNgayPT.Text = Now
            Catch ex As Exception

            End Try
        End If        
    End Sub


    Private Sub btnLuu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLuu.Click
        Select Case pThem
            Case True
                Dim strSQL As String
                If NhapLieu.ChuaDuThongTin("NN", ErrorProvider) = True Then
                    frmMsgOK.HienThi("Thông tin bạn nhập vào chưa hợp lệ", "Thông báo")
                Else
                    If objConnect.DaTonTai("Select * From tblPhieuThu Where MaPT Like N'" & Me.txtMaPhieuThu.Text.Trim & "'") = True Then
                        frmMsgOK.HienThi("Phiếu thu này đã tồn tại", "Thông báo", False)
                        Me.txtMaPhieuThu.Focus()
                    Else
                        'Thực hiện thêm giá trị mới vào CSDL
                        strSQL = "Insert into tblPhieuThu (MaPT,NgayPT,MaHDBH,MaNV,NguoiNop,LyDoThu,KemTheoChungTu,SoTien) "
                        strSQL &= "Values (N'" & Me.txtMaPhieuThu.Text.Trim & "',"
                        strSQL &= "N'" & NhapLieu.CDateTime(mskNgayPT) & "',"
                        strSQL &= "N'" & cboMaHD.SelectedValue & "',"
                        strSQL &= "N'" & pMaNV & "',"
                        strSQL &= "N'" & Me.txtNguoiNop.Text.Trim & "',"
                        strSQL &= "N'" & Me.txtLyDoThu.Text.Trim & "',"
                        strSQL &= "N'" & Me.txtKemTheo.Text.Trim & "',"
                        strSQL &= "N'" & Me.txtSoTien.Text.Trim & "')"
                        objConnect.RunSQL(strSQL)
                        frmMainX.LoadData(7)
                        If (frmMsgYesNo.HienThi("Bạn có muốn nhập tiếp không ?", "Thông báo") = Windows.Forms.DialogResult.Yes) Then
                            Call ResetValues()
                            Try
                                Me.txtMaPhieuThu.Text = "PT" & Now.Hour & Now.Minute & Now.Second
                                Me.mskNgayPT.Text = Now
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
                    If objConnect.DaTonTai("Select * From tblPhieuThu Where MaPT Like N'" & Me.txtMaPhieuThu.Text.Trim & "' And MaPT Not Like N'" & strMa_Cu & "'") = True Then
                        frmMsgOK.HienThi("Mã phiếu thu này đã tồn tại", "Thông báo", False)
                        Me.txtMaPhieuThu.Focus()
                    Else
                        'Thực hiện sửa giá trị mới vào CSDL
                        strSQL = "Update tblPhieuThu Set MaPT =N'" & Me.txtMaPhieuThu.Text.Trim.ToString & "',"
                        strSQL &= "NgayPT = N'" & NhapLieu.CDateTime(mskNgayPT) & "',"
                        strSQL &= "MaHDBH = N'" & Me.cboMaHD.SelectedValue & "',"
                        strSQL &= "MaNV=N'" & pMaNV & "',"
                        strSQL &= "NguoiNop=N'" & Me.txtNguoiNop.Text.Trim & "',"
                        strSQL &= "LyDoThu = N'" & Me.txtLyDoThu.Text & "',"
                        strSQL &= "KemTheoChungTu = N'" & Me.txtKemTheo.Text.Trim & "',"
                        strSQL &= "SoTien=N'" & Me.txtSoTien.Text.Trim & "'"
                        strSQL &= "Where MaPT Like N'" & strMa_Cu & "'"
                        objConnect.RunSQL(strSQL)
                        
                        frmMsgOK.HienThi("Sửa thành công", "Thông báo")
                        Me.Dispose()
                    End If
                End If
        End Select
        
    End Sub

   
End Class