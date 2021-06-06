Public Class frmHoaDonBanHang
    
    Private Sub btnThemKhachHang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThemKhachHang.Click
        pThem = True
        frmKhachHang.ShowDialog()
        frmKhachHang.ShowInTaskbar = False
    End Sub

    Private Sub txtPhiVanChuyen_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPhiVanChuyen.KeyPress
        If InStr("0123456789" & Chr(8), e.KeyChar) < 1 Then
            e.Handled = True
        End If
    End Sub

   

    Private Sub DataGridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView.CellClick
        If e.ColumnIndex = colXoa.Index And e.RowIndex <> Me.DataGridView.RowCount - 1 Then
            If frmMsgYesNo.HienThi("Bạn có chắc chắn muốn xóa bản ghi được  chọn không ?", "Thông báo", False) = Windows.Forms.DialogResult.Yes Then
                Me.DataGridView.Rows.RemoveAt(e.RowIndex)
            End If
        End If
    End Sub

    Private Sub DataGridView_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView.CellEndEdit
        Dim dg, ck, thue As Double
        Dim sl As Long
        If NhapLieu.DemChuoiCon(Me.DataGridView, 0, Me.DataGridView.CurrentRow.Cells(0).Value) > 1 Then
            Me.DataGridView.CurrentRow.Cells(colMaH.Index).Value = Nothing
            Me.DataGridView.CurrentRow.Cells(colDonGia.Index).Value = Nothing

        Else
            'Kiểm tra giá trị tại cột số lượng
            If Not IsNumeric(Me.DataGridView.CurrentRow.Cells(colSoLuong.Index).Value) Then
                Me.DataGridView.CurrentRow.Cells(colSoLuong.Index).Value = ""
            Else
                If Me.DataGridView.CurrentRow.Cells(colSoLuong.Index).Value <= 0 Then
                    Me.DataGridView.CurrentRow.Cells(colSoLuong.Index).Value = ""
                Else
                    Me.DataGridView.CurrentRow.Cells(colSoLuong.Index).Value = Int(Me.DataGridView.CurrentRow.Cells(colSoLuong.Index).Value)
                End If
            End If
            'Kiểm tra giá trị tại cột chiết khấu
            If Not IsNumeric(Me.DataGridView.CurrentRow.Cells(colChietKhau.Index).Value) Then
                Me.DataGridView.CurrentRow.Cells(colChietKhau.Index).Value = ""
            Else
                If Me.DataGridView.CurrentRow.Cells(colChietKhau.Index).Value > 100 Or Me.DataGridView.CurrentRow.Cells(colChietKhau.Index).Value < 0 Then
                    Me.DataGridView.CurrentRow.Cells(colChietKhau.Index).Value = ""
                End If
            End If

            'Cập nhật đơn giá bán tự động
            If Len(Me.DataGridView.CurrentRow.Cells(colMaH.Index).Value) > 0 Then
                Me.DataGridView.CurrentRow.Cells(colDonGia.Index).Value = objConnect.GetFieldValue("Select tblHangHoa.DGBan From tblHangHoa Where MaH = N'" & Me.DataGridView.CurrentRow.Cells(colMaH.Index).Value & "'")
            End If
            'Cập nhật thuế VAT
            If Len(Me.DataGridView.CurrentRow.Cells(colMaH.Index).Value) > 0 Then
                Me.DataGridView.CurrentRow.Cells(colThue.Index).Value = objConnect.GetFieldValue("Select tblHangHoa.ThueVAT From tblHangHoa Where MaH = N'" & Me.DataGridView.CurrentRow.Cells(colMaH.Index).Value & "'")
            End If
            'Tính cột thành tiền
            dg = IIf(IsNumeric(Me.DataGridView.CurrentRow.Cells(colDonGia.Index).Value), Me.DataGridView.CurrentRow.Cells(colDonGia.Index).Value, 0)
            sl = IIf(IsNumeric(Me.DataGridView.CurrentRow.Cells(colSoLuong.Index).Value), Me.DataGridView.CurrentRow.Cells(colSoLuong.Index).Value, 0)
            ck = IIf(IsNumeric(Me.DataGridView.CurrentRow.Cells(colChietKhau.Index).Value), Me.DataGridView.CurrentRow.Cells(colChietKhau.Index).Value, 0)
            thue = IIf(IsNumeric(Me.DataGridView.CurrentRow.Cells(colThue.Index).Value), Me.DataGridView.CurrentRow.Cells(colThue.Index).Value, 0)
            Me.DataGridView.CurrentRow.Cells(colThanhTien.Index).Value = FormatNumber(((dg * sl) * (1 + thue / 100 - ck / 100)), 2)
        End If
    End Sub

    Private Sub frmHoaDonBanHang_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmMainX.LoadData(5)
    End Sub

    Private Sub frmHoaDonBanHang_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.txtNhanVien.Text = pTenNV
        objConnect.SetDataCombobox(Me.cboKhachHang, "Select MaKH,TenKH From tblKhachHang Order by TenKH")
        Me.cboKhachHang.SelectedIndex = -1
        objConnect.SetDataComboboxInDataGridView(Me.colMaH, "Select MaH,TenH From tblHangHoa Order by TenH")
        Dim tg As Date = Now
        Me.txtMaHD.Text = "HDB" & tg.Hour & tg.Minute & tg.Second
        Try
            Me.mskNgayHD.Text = Now
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnHuyBo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHuyBo.Click
        Me.Dispose()
    End Sub

    'Phương thức xóa dữ liệu trên form
    Private Sub ResetValues()
        Me.txtMaHD.Text = ""
        Me.mskNgayHD.Text = ""
        Me.cboKhachHang.SelectedIndex = -1
        Me.mskNgayGiaoHang.Text = ""
        Me.mskHanThanhToan.Text = ""
        Me.txtPhiVanChuyen.Text = ""
        'Xóa dữ liệu trên gridview
        Me.DataGridView.Rows.Clear()
        'Xóa báo lỗi nếu có
        NhapLieu.RemoveErrorProvider("NN", Me.ErrorProvider)
        Me.mskNgayHD.Focus()
    End Sub

    

    Private Sub btnLuu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLuu.Click
        Dim strSQL_Main As String = ""
        Dim strSQL_Sub As String = ""
        If NhapLieu.ChuaDuThongTin("NN", Me.ErrorProvider) = True Then
            frmMsgOK.HienThi("Thông tin bạn nhập vào chưa hợp lệ", "Thông báo")
        Else
            If BanGhiHopLe() = False Then
                frmMsgOK.HienThi("Thông tin phần chi tiết hóa đơn bán chưa hợp lệ", "Thông báo")
            Else
                If objConnect.DaTonTai("Select * From tblHoaDonBanHang Where MaHDBH =N'" & Me.txtMaHD.Text.Trim & "'") = True Then
                    frmMsgOK.HienThi("Mã hóa đơn bán này đã tồn tại", "Thông báo")
                    Me.txtMaHD.Focus()
                Else
                    'Thực hiện thêm giá trị mới vào bảng Phiếu nhập kho
                    strSQL_Main = "Insert into tblHoaDonBanHang (MaHDBH,NgayHDBH,MaNV,MaKH,NgayGiaoHang,HanThanhToan,PhiVanChuyen) "
                    strSQL_Main &= "Values(N'" & Me.txtMaHD.Text.Trim & "',N'" & NhapLieu.CDateTime(Me.mskNgayHD) & "',"
                    strSQL_Main &= "N'" & pMaNV & "',"
                    strSQL_Main &= "N'" & Me.cboKhachHang.SelectedValue & "',N'" & IIf(Me.mskNgayGiaoHang.MaskFull = True, CDate(Me.mskNgayGiaoHang.Text), "NULL") & "',"
                    strSQL_Main &= "N'" & NhapLieu.CDateTime(Me.mskHanThanhToan) & "',N'" & Me.txtPhiVanChuyen.Text & "')"
                    objConnect.RunSQL(strSQL_Main)
                    'Thực hiện lưu dữ liệu vào bảng chi tiết phiếu nhập kho
                    For i As Integer = 0 To Me.DataGridView.RowCount - 2
                        strSQL_Sub = "Insert into tblChiTietHoaDonBanHang (MaHDBH,MaH,DonGia,SoLuong,GiamGia,ThueVAT) "
                        strSQL_Sub &= "Values (N'" & Me.txtMaHD.Text.Trim & "',"
                        strSQL_Sub &= "N'" & Me.DataGridView.Rows(i).Cells(colMaH.Index).Value & "',"
                        strSQL_Sub &= "N'" & Me.DataGridView.Rows(i).Cells(colDonGia.Index).Value & "',"
                        strSQL_Sub &= "N'" & Me.DataGridView.Rows(i).Cells(colSoLuong.Index).Value & "',"
                        strSQL_Sub &= "N'" & Me.DataGridView.Rows(i).Cells(colChietKhau.Index).Value & "',"
                        strSQL_Sub &= "N'" & Me.DataGridView.Rows(i).Cells(colThue.Index).Value & "')"
                        objConnect.RunSQL(strSQL_Sub)
                    Next
                    If (frmMsgYesNo.HienThi("Bạn có muốn nhập tiếp không ?", "Thông báo") = Windows.Forms.DialogResult.Yes) Then
                        'Xóa dữ liệu trên form
                        Call ResetValues()
                        Dim tg As Date = Now
                        Me.txtMaHD.Text = "HDB" & tg.Hour & tg.Minute & tg.Second
                        Try
                            Me.mskNgayHD.Text = Now
                        Catch ex As Exception

                        End Try
                    Else
                        Me.Dispose()
                    End If

                End If
            End If
        End If
    End Sub

    'Phương thức dùng để kiểm tra nhập liệu trên datagridview
    Private Function BanGhiHopLe() As Boolean
        Dim d, d1, SL_Ton As Integer
        Dim N As Boolean
        Dim C0, C1, C2 As String
        'Dim ConHang As Boolean
        Dim MaK, MaH, SoLuong As String
        MaK = Me.cboKhachHang.SelectedValue
        For i As Integer = 0 To Me.DataGridView.RowCount - 2
            C0 = Trim(Me.DataGridView.Rows(i).Cells(colMaH.Index).Value)        'Mã hàng
            C1 = Trim(Me.DataGridView.Rows(i).Cells(colDonGia.Index).Value)     'Đơn giá
            C2 = Trim(Me.DataGridView.Rows(i).Cells(colSoLuong.Index).Value)    'Số lượng        
            MaH = Me.DataGridView.CurrentRow.Cells(colMaH.Index).Value
            SoLuong = Me.DataGridView.Rows(i).Cells(colSoLuong.Index).Value
            If (C0 <> "" And C1 <> "" And C2 <> "") Then
                Me.DataGridView.Rows.Item(i).HeaderCell.Value = ""
                d += 1
                If (ConHang(MaH, SoLuong, SL_Ton) = False) Then
                    Me.DataGridView.Rows.Item(i).HeaderCell.Value = IIf(SL_Ton <= 0, "Thông báo hiện trong kho " & Me.cboKhachHang.Text & " đã hết loại mặt hàng này", "Thông báo hiện trong kho " & Me.cboKhachHang.Text & " chỉ còn: " & SL_Ton & " sản phẩm loại này")
                    d1 += 1
                Else
                    Me.DataGridView.Rows.Item(i).HeaderCell.Value = ""
                End If
            Else
                Me.DataGridView.Rows.Item(i).HeaderCell.Value = "Bạn phải nhập tên hàng, số lượng, đơn giá "
                N = True
            End If

        Next

        If (d < 1 Or N = True Or d1 > 0) Then
            Return False
        Else
            Return True
        End If
    End Function


    'Phương thức tính hàng tồn
    Private Function ConHang(ByVal MaH As String, ByVal SL_DinhBan As Long, ByRef SL_Ton As Integer) As Boolean
        Dim SoLuong As Long
        Dim strSQL As String
        strSQL = "Select MaH,SL_Ton From View_HangTon Where MaH='" & MaH & "'"
        'Tính tống số lượng nhập
        SoLuong = objConnect.getSum(strSQL, 1)
        SL_Ton = SoLuong
        If SoLuong >= SL_DinhBan Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub txtPhiVanChuyen_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPhiVanChuyen.TextChanged

    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click

    End Sub
End Class