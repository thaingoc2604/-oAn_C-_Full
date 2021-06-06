Public Class frmBoPhan
    Friend strMa_Cu As String
    Friend strTen_Cu As String
    Private Sub btnThoat_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub
    

    Private Sub ResetValues()
        Me.txtMaBP.Text = ""
        Me.txtTenBP.Text = ""
        Me.txtDiaChi.Text = ""
        Me.mskDienThoai.Text = ""
        Me.mskFax.Text = ""
    End Sub

    Private Sub frmBoPhan_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
        frmMainX.LoadData(20)
    End Sub

    

    Private Sub btnLuu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLuu.Click
        Select Case pThem
            Case True
                Dim strSQL As String
                If NhapLieu.ChuaDuThongTin("NN", ErrorProvider) = True Then
                    frmMsgOK.HienThi("Thông tin bạn nhập vào chưa hợp lệ", "Thông báo")
                Else
                    If objConnect.DaTonTai("Select * From tblBoPhan Where MaBP Like N'" & Me.txtMaBP.Text.Trim & "'") = True Then
                        frmMsgOK.HienThi("Mã bộ phận này đã tồn tại", "Thông báo", False)
                        Me.txtMaBP.Focus()
                    Else
                        If objConnect.DaTonTai("Select * From tblBoPhan Where TenBP Like N'" & Me.txtTenBP.Text.Trim & "'") = True Then
                            frmMsgOK.HienThi("Tên bộ phận này đã tồn tại", "Thông báo", False)
                            Me.txtTenBP.Focus()
                        Else
                            'Thực hiện thêm giá trị mới vào CSDL
                            strSQL = "Insert into tblBoPhan (MaBP,TenBP,DiaChi,DienThoai,Fax) Values(N'" & Me.txtMaBP.Text.Trim & "',N'" & Me.txtTenBP.Text.Trim & "',N'" & Me.txtDiaChi.Text.Trim & "',N'" & NhapLieu.getPhoneNumber(Me.mskDienThoai) & "',N'" & NhapLieu.getPhoneNumber(Me.mskFax) & "')"
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
                    If objConnect.DaTonTai("Select * From tblBoPhan Where MaBP Like N'" & Me.txtMaBP.Text.Trim & "' And MaBP Not Like N'" & strMa_Cu & "'") = True Then
                        frmMsgOK.HienThi("Mã bộ phận này đã tồn tại", "Thông báo")
                        Me.txtMaBP.Focus()
                    Else
                        If objConnect.DaTonTai("Select * From tblBoPhan Where TenBP Like N'" & Me.txtTenBP.Text.Trim & "' And TenBP Not Like N'" & strTen_Cu & "'") = True Then
                            frmMsgOK.HienThi("Tên bộ phận này đã tồn tại", "Thông báo")
                            Me.txtTenBP.Focus()
                        Else
                            'Thực hiện sửa giá trị mới vào CSDL
                            strSQL = "Update tblBoPhan Set MaBP =N'" & Me.txtMaBP.Text.Trim.ToString & "',TenBP = N'" & Me.txtTenBP.Text.Trim.ToString & "',DiaChi = N'" & Me.txtDiaChi.Text.Trim.ToString & "',DienThoai = N'" & NhapLieu.getPhoneNumber(Me.mskDienThoai) & "',Fax = N'" & NhapLieu.getPhoneNumber(Me.mskFax) & "' Where MaBP like N'" & strMa_Cu & "'"
                            objConnect.RunSQL(strSQL)

                            'Thực hiện cập nhật giá trị cho các bảng có liên quan như tblNhanVien
                            Try
                                objConnect.RunSQL("Update tblNhanVien Set MaBP=N'" & Me.txtMaBP.Text.Trim & "' Where MaBP=N'" & strMa_Cu & "'")
                            Catch ex As Exception
                            End Try
                            Me.Dispose()
                        End If
                    End If
                End If
        End Select
        
    End Sub

   

   
End Class