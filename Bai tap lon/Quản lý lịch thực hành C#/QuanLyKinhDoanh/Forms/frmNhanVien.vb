Imports System.Windows.Forms
Imports System.Globalization

Public Class frmNhanVien
   
    Private Sub frmNhanVien_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
        frmMainX.LoadData(1)
    End Sub

    Private Sub frmNhanVien_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If (pThem = True) Then
            'tạo nguồn dữ liệu cho combobox tỉnh thành phố
            objConnect.SetDataCombobox(Me.cboMaTinhTP, "Select MaTinhTP,TenTinhTP From tblTinhTP Order by TenTinhTP")
            Me.cboMaTinhTP.SelectedIndex = -1
            'tạo nguồn dữ liệu cho combobox bộ phận
            objConnect.SetDataCombobox(Me.cboMaBP, "Select MaBP,TenBP From tblBoPhan Order by TenBP")
            Me.cboMaBP.SelectedIndex = -1
            'Tạo nguồn dữ liệu cho combobox chức vụ
            objConnect.SetDataCombobox(Me.cboMaCV, "Select MaCV,TenCV From tblChucVu Order by TenCV")
            Me.cboMaCV.SelectedIndex = -1
        End If
    End Sub

    'Phương thức xóa dữ liệu trên điều khiển nhập liệu
    Private Sub ResetValues()
        Me.txtMaNV.Text = ""
        Me.txtHoTen.Text = ""
        Me.chkNam.Checked = True
        Me.mskNgaySinh.Text = ""
        Me.cboMaBP.SelectedIndex = -1
        Me.cboMaCV.SelectedIndex = -1
        Me.txtDiaChi.Text = ""
        Me.cboMaTinhTP.SelectedIndex = -1
        Me.mskDienThoai.Text = ""
        Me.txtCMND.Text = ""
        Me.mskNgayCap.Text = ""
        Me.txtNoiCap.Text = ""
        Me.mskNgayVaoCongTy.Text = ""
        Me.mskNgayThoiViec.Text = ""
        Me.chkChua.Checked = True
        Me.txtDanToc.Text = ""
        Me.txtTonGiao.Text = ""
        Me.txtTrinhDo.Text = ""
        Me.txtChuyenNganh.Text = ""
        Me.txtNgoaiNgu.Text = ""
        Me.txtDuongDan.Text = ""
        Me.picPhoto.Image = Nothing
    End Sub
    'Mở form bộ phận
    Private Sub btnThemBP_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnThemBP.Click
        frmBoPhan.Show()
    End Sub
    'Mở form chức vụ
    Private Sub btnThemCV_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnThemCV.Click
        frmChucVu.Show()
    End Sub
    'Mở form tỉnh thành phố
    Private Sub btnThemTinhTP_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnThemTinhTP.Click
        frmTinhTP.Show()
    End Sub
    'Làm mới dữ liệu trong combobox cboMaBP khi người dùng mở form bộ phận
    Private Sub cboMaBP_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboMaBP.GotFocus
        'tạo nguồn dữ liệu cho combobox bộ phận
        objConnect.SetDataCombobox(Me.cboMaBP, "Select MaBP,TenBP From tblBoPhan Order by TenBP")
    End Sub
    'Làm mới dữ liệu trong combobox cboMaCV khi người dùng mở form chức vụ
    Private Sub cboMaCV_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboMaCV.GotFocus
        'Tạo nguồn dữ liệu cho combobox chức vụ
        objConnect.SetDataCombobox(Me.cboMaCV, "Select MaCV,TenCV From tblChucVu Order by TenCV")
    End Sub
    'Làm mới dữ liệu trong combobox cboMaTinhTP khi người dùng mở form tỉnh thành phố
    Private Sub cboMaTinhTP_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboMaTinhTP.GotFocus
        'tạo nguồn dữ liệu cho combobox tỉnh thành phố
        objConnect.SetDataCombobox(Me.cboMaTinhTP, "Select MaTinhTP,TenTinhTP From tblTinhTP Order by TenTinhTP")
    End Sub

    Private Sub btnCapNhat_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCapNhat.Click
        Select Case pThem
            Case True
                Dim strSQL As String
                If NhapLieu.ChuaDuThongTin("NN", ErrorProvider) = True Then
                    frmMsgOK.HienThi("Thông tin bạn nhập vào chưa hợp lệ", "Thông báo")
                Else
                    If objConnect.DaTonTai("Select * From tblNhanVien Where MaNV Like N'" & Me.txtMaNV.Text.Trim & "'") = True Then
                        frmMsgOK.HienThi("Mã nhân viên này đã tồn tại", "Thông báo", False)
                        Me.txtMaNV.Focus()
                    Else
                        '18 tuổi công dân mới được cấp CMND
                        If DateDiff(DateInterval.Year, CDate(Me.mskNgaySinh.Text), CDate(Me.mskNgayCap.Text), FirstDayOfWeek.Monday) < 18 Then
                            frmMsgOK.HienThi("Thông tin bạn nhập vào chưa hợp lệ", "Thông báo")
                            Me.ErrorProvider.SetError(Me.mskNgayCap, "Nhân viên này chưa đủ tuổi cấp CMND")
                            Me.mskNgayCap.Focus()
                        Else
                            If DateDiff(DateInterval.Year, CDate(Me.mskNgaySinh.Text), CDate(Me.mskNgayVaoCongTy.Text), FirstDayOfWeek.Monday) < 18 Then
                                frmMsgOK.HienThi("Thông tin bạn nhập vào chưa hợp lệ", "Thông báo")
                                Me.ErrorProvider.SetError(Me.mskNgayVaoCongTy, "Nhân viên này chưa đủ tuổi lao động")
                                Me.mskNgayVaoCongTy.Focus()
                            Else
                                If IsDate(Me.mskNgayThoiViec.Text) Then
                                    If CDate(Me.mskNgayThoiViec.Text) < CDate(Me.mskNgayVaoCongTy.Text) Then
                                        frmMsgOK.HienThi("Ngày thôi việc phải lớn hơn ngày vào    công ty", "Thông báo", False)
                                        Me.mskNgayThoiViec.Focus()
                                        Exit Sub
                                    End If
                                Else
                                    Me.mskNgayThoiViec.Text = ""
                                End If
                                'Thực hiện thêm giá trị mới vào CSDL
                                strSQL = "Insert into tblNhanVien (MaNV,HoTen,GioiTinh,NgaySinh,MaBP,MaCV,DiaChi,"
                                strSQL &= "MaTinhTP,DienThoai,CMND,NgayCap,NoiCap,NgayVaoCongTy,NgayThoiViec,KetHon,"
                                strSQL &= "DanToc,TonGiao,TrinhDo,ChuyenNganh,NgoaiNgu,PhoTo) "
                                strSQL &= "Values (N'" & Me.txtMaNV.Text.Trim & "',"
                                strSQL &= "N'" & Me.txtHoTen.Text.Trim & "',"
                                strSQL &= "N'" & IIf(Me.chkNam.Checked = True, "Nam", "Nữ") & "',"
                                strSQL &= "N'" & IIf(Me.mskNgaySinh.MaskFull = True, CDate(Me.mskNgaySinh.Text), "") & "',"
                                strSQL &= "N'" & Me.cboMaBP.SelectedValue & "',"
                                strSQL &= "N'" & Me.cboMaCV.SelectedValue & "',"
                                strSQL &= "N'" & Me.txtDiaChi.Text.Trim & "',"
                                strSQL &= "N'" & Me.cboMaTinhTP.SelectedValue & "',"
                                strSQL &= "N'" & NhapLieu.getPhoneNumber(Me.mskDienThoai) & "',"
                                strSQL &= "N'" & Me.txtCMND.Text.Trim & "',"
                                strSQL &= "N'" & IIf(Me.mskNgayCap.MaskFull = True, CDate(Me.mskNgayCap.Text), "") & "',"
                                strSQL &= "N'" & Me.txtNoiCap.Text.Trim & "',"
                                strSQL &= "N'" & IIf(Me.mskNgayVaoCongTy.MaskFull = True, CDate(Me.mskNgayVaoCongTy.Text), "") & "',"
                                If IsDate(Me.mskNgayThoiViec.Text) Then
                                    strSQL &= "'" & NhapLieu.CDateTime(Me.mskNgayThoiViec) & "',"
                                Else
                                    strSQL &= "NULL,"
                                End If
                                strSQL &= "N'" & IIf(Me.chkChua.Checked = True, "Chưa", "Rồi") & "',"
                                strSQL &= "N'" & Me.txtDanToc.Text.Trim & "',"
                                strSQL &= "N'" & Me.txtTonGiao.Text.Trim & "',"
                                strSQL &= "N'" & Me.txtTrinhDo.Text.Trim & "',"
                                strSQL &= "N'" & Me.txtChuyenNganh.Text.Trim & "',"
                                strSQL &= "N'" & Me.txtNgoaiNgu.Text.Trim & "',"
                                strSQL &= "N'" & Me.txtDuongDan.Text.Trim & "')"
                                objConnect.RunSQL(strSQL)
                                If (frmMsgYesNo.HienThi("Bạn có muốn thêm nữa không ?", "Thông báo") = Windows.Forms.DialogResult.Yes) Then
                                    Call ResetValues()
                                Else
                                    Me.Dispose()
                                End If
                            End If
                        End If
                    End If
                End If
            Case False  'Lenh cap nhat la sua
                Dim strSQL As String
                If NhapLieu.ChuaDuThongTin("NN", ErrorProvider) = True Then
                    frmMsgOK.HienThi("Thông tin bạn nhập vào chưa hợp lệ", "Thông báo")
                Else
                    If objConnect.DaTonTai("Select * From tblNhanVien Where MaNV Like N'" & Me.txtMaNV.Text.Trim & "' And MaNV Not Like N'" & pstrMa_Cu & "'") = True Then
                        frmMsgOK.HienThi("Mã nhân viên này đã tồn tại", "Thông báo", False)
                        Me.txtMaNV.Focus()
                    Else
                        '18 tuổi công dân mới được cấp CMND
                        If DateDiff(DateInterval.Year, CDate(Me.mskNgaySinh.Text), CDate(Me.mskNgayCap.Text), FirstDayOfWeek.Monday) < 18 Then
                            frmMsgOK.HienThi("Thông tin bạn nhập vào chưa hợp lệ", "Thông báo")
                            Me.ErrorProvider.SetError(Me.mskNgayCap, "Nhân viên này chưa đủ tuổi cấp CMND")
                            Me.mskNgayCap.Focus()
                        Else
                            If DateDiff(DateInterval.Year, CDate(Me.mskNgaySinh.Text), CDate(Me.mskNgayVaoCongTy.Text), FirstDayOfWeek.Monday) < 18 Then
                                frmMsgOK.HienThi("Thông tin bạn nhập vào chưa hợp lệ", "Thông báo")
                                Me.ErrorProvider.SetError(Me.mskNgayVaoCongTy, "Nhân viên này chưa đủ tuổi lao động")
                                Me.mskNgayVaoCongTy.Focus()
                            Else
                                If IsDate(Me.mskNgayThoiViec.Text) Then
                                    If CDate(Me.mskNgayThoiViec.Text) < CDate(Me.mskNgayVaoCongTy.Text) Then
                                        frmMsgOK.HienThi("Ngày thôi việc phải lớn hơn ngày vào    công ty", "Thông báo", False)
                                        Me.mskNgayThoiViec.Focus()
                                        Exit Sub
                                    End If
                                Else
                                    Me.mskNgayThoiViec.Text = ""
                                End If
                                'Thực hiện sửa giá trị mới vào CSDL
                                strSQL = "Update tblNhanVien Set MaNV =N'" & Me.txtMaNV.Text.Trim.ToString & "',"
                                strSQL &= "HoTen = N'" & Me.txtHoTen.Text.Trim.ToString & "',"
                                strSQL &= "GioiTinh = N'" & IIf(Me.chkNam.Checked = True, "Nam", "Nữ") & "',"
                                strSQL &= "NgaySinh = '" & NhapLieu.CDateTime(Me.mskNgaySinh) & "',"
                                strSQL &= "MaBP = N'" & Me.cboMaBP.SelectedValue & "',"
                                strSQL &= "MaCV=N'" & Me.cboMaCV.SelectedValue & "',"
                                strSQL &= "DiaChi=N'" & Me.txtDiaChi.Text.Trim & "',"
                                strSQL &= "MaTinhTP=N'" & Me.cboMaTinhTP.SelectedValue & "',"
                                strSQL &= "CMND=N'" & Me.txtCMND.Text.Trim & "',"
                                strSQL &= "NgayCap=N'" & NhapLieu.CDateTime(Me.mskNgayCap) & "',"
                                strSQL &= "NoiCap=N'" & Me.txtNoiCap.Text.Trim & "',"
                                strSQL &= "NgayVaoCongTy=N'" & NhapLieu.CDateTime(Me.mskNgayVaoCongTy) & "',"
                                If IsDate(Me.mskNgayThoiViec.Text) Then
                                    strSQL &= "NgayThoiViec='" & NhapLieu.CDateTime(Me.mskNgayThoiViec) & "',"
                                Else
                                    strSQL &= "NgayThoiViec=NULL,"
                                End If
                                strSQL &= "KetHon=N'" & IIf(Me.chkChua.Checked = True, "Chưa", "Rồi") & "',"
                                strSQL &= "DanToc=N'" & Me.txtDanToc.Text.Trim & "',"
                                strSQL &= "TonGiao=N'" & Me.txtTonGiao.Text.Trim & "',"
                                strSQL &= "TrinhDo=N'" & Me.txtTrinhDo.Text.Trim & "',"
                                strSQL &= "ChuyenNganh=N'" & Me.txtChuyenNganh.Text.Trim & "',"
                                strSQL &= "NgoaiNgu=N'" & Me.txtNgoaiNgu.Text.Trim & "',"
                                strSQL &= "PhoTo=N'" & Me.txtDuongDan.Text.Trim & "' "
                                strSQL &= "Where MaNV Like N'" & pstrMa_Cu & "'"
                                'strSQL &= "NgayThoiViec=N'" & NhapLieu.CDateTime(Me.mskNgayThoiViec) & "',"
                                objConnect.RunSQL(strSQL)
                                'Cập nhật dữ liệu có liên quan tới các bảng sử dụng khóa MaNV
                                Try
                                    objConnect.RunSQL("Update tblPhieuNhapKho Set MaNV=N'" & Me.txtMaNV.Text.Trim & "' Where MaNV=N'" & pstrMa_Cu & "'")
                                    objConnect.RunSQL("Update tblPhieuXuatKho Set MaNV=N'" & Me.txtMaNV.Text.Trim & "' Where MaNV=N'" & pstrMa_Cu & "'")
                                    objConnect.RunSQL("Update tblPhieuThu Set MaNV=N'" & Me.txtMaNV.Text.Trim & "' Where MaNV=N'" & pstrMa_Cu & "'")
                                    objConnect.RunSQL("Update tblPhieuChi Set MaNV=N'" & Me.txtMaNV.Text.Trim & "' Where MaNV=N'" & pstrMa_Cu & "'")
                                    objConnect.RunSQL("Update tblHDBanHang Set MaNV=N'" & Me.txtMaNV.Text.Trim & "' Where MaNV=N'" & pstrMa_Cu & "'")
                                    objConnect.RunSQL("Update Sys_NSD Set NSD=N'" & Me.txtMaNV.Text.Trim & "' Where NSD=N'" & pstrMa_Cu & "'")
                                Catch ex As Exception

                                End Try
                                frmMsgOK.HienThi("Sửa thành công", "Thông báo")
                                Me.Dispose()
                            End If
                        End If
                    End If
                End If
        End Select


    End Sub

   

    

    

    Private Sub btnXoaAnh_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnXoaAnh.Click
        Me.txtDuongDan.Text = ""
        Me.picPhoto.Image = Nothing
    End Sub

    Private Sub btnChonAnh_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnChonAnh.Click
        Me.txtDuongDan.Text = NhapLieu.ChonAnh(Me.picPhoto)
    End Sub

   

    Private Sub btnThoat_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub

    Private Sub btnTimKiem_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        frmTimKiemNhanVien.ShowDialog()
        frmTimKiemNhanVien.ShowInTaskbar = False
    End Sub

End Class