Public Class frmPhieuXuatKho

    Private Sub frmPhieuXuatKho_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmPhieuXuatKho_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Tạo nguồn dữ liệu cho các combobox
        Me.txtNhanVien.Text = pTenNV
        objConnect.SetDataCombobox(Me.cboKhachHang, "Select MaKH,TenKH From tblKhachHang Order by TenKH")
        Me.cboKhachHang.SelectedIndex = -1
        objConnect.SetDataCombobox(Me.cboMaKho, "Select MaKho,TenKho From tblKho Order by TenKho")
        Me.cboMaKho.SelectedIndex = -1
        objConnect.SetDataComboboxInDataGridView(Me.colMaH, "SELECT MaH, TenH FROM View_HangTon ORDER BY TenH;")
        Dim tg As Date = Now
        Me.txtMaPXK.Text = "PXK" & tg.Hour & tg.Minute & tg.Second
        Try
            Me.mskNgayXK.Text = Now
        Catch ex As Exception

        End Try
    End Sub
    'Phương thức dùng để kiểm tra nhập liệu trên datagridview
    Private Function BanGhiHopLe() As Boolean
        Dim d, d1, SL_Ton As Integer
        Dim N As Boolean
        Dim C0, C1, C2, C3 As String
        'Dim ConHang As Boolean
        Dim MaK, MaH, SoLuong As String
        MaK = Me.cboMaKho.SelectedValue
        For i As Integer = 0 To Me.DataGridView.RowCount - 2
            C0 = Trim(Me.DataGridView.Rows(i).Cells(colMaH.Index).Value)        'Mã hàng
            C1 = Trim(Me.DataGridView.Rows(i).Cells(colDGXuat.Index).Value)     'Đơn giá
            C2 = Trim(Me.DataGridView.Rows(i).Cells(colSoLuong.Index).Value)    'Số lượng
            C3 = Trim(Me.DataGridView.Rows(i).Cells(4).Value)
            MaH = Me.DataGridView.CurrentRow.Cells(colMaH.Index).Value
            SoLuong = Me.DataGridView.Rows(i).Cells(colSoLuong.Index).Value
            If (C0 <> "" And C1 <> "" And C2 <> "" And C3 <> "") Then
                Me.DataGridView.Rows.Item(i).HeaderCell.Value = ""
                d += 1
                If (ConHang(MaK, MaH, SoLuong, SL_Ton) = False) Then
                    Me.DataGridView.Rows.Item(i).HeaderCell.Value = IIf(SL_Ton <= 0, "Thông báo hiện trong kho " & Me.cboMaKho.Text & " đã hết loại mặt hàng này", "Thông báo hiện trong kho " & Me.cboMaKho.Text & " chỉ còn: " & SL_Ton & " sản phẩm loại này")
                    d1 += 1
                Else
                    Me.DataGridView.Rows.Item(i).HeaderCell.Value = ""
                End If
            Else
                Me.DataGridView.Rows.Item(i).HeaderCell.Value = "Bạn chưa nhập đủ thông tin "
                N = True
            End If

        Next

        If (d < 1 Or N = True Or d1 > 0) Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub DataGridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView.CellClick
        'Khi kích vào nút xóa
        If e.ColumnIndex = 6 And e.RowIndex <> Me.DataGridView.RowCount - 1 Then
            If frmMsgYesNo.HienThi("Bạn có chắc chắn muốn xóa bản ghi được  chọn không ?", "Thông báo", False) = Windows.Forms.DialogResult.Yes Then
                Me.DataGridView.Rows.RemoveAt(e.RowIndex)
            End If
        End If

    End Sub
   
    'Phương thức xóa dữ liệu trên form
    Private Sub ResetValues()
        Me.txtMaPXK.Text = ""
        Me.mskNgayXK.Text = ""
        Me.cboMaKho.SelectedIndex = -1
        Me.cboKhachHang.SelectedIndex = -1
        'Xóa dữ liệu trên gridview
        Me.DataGridView.Rows.Clear()
        'Xóa báo lỗi nếu có
        NhapLieu.RemoveErrorProvider("NN", Me.ErrorProvider)
        Me.txtMaPXK.Focus()
    End Sub

    Private Sub DataGridView_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView.CellEndEdit

        Dim dg, ck, thue As Double
        Dim sl As Long
        If NhapLieu.DemChuoiCon(Me.DataGridView, 0, Me.DataGridView.CurrentRow.Cells(0).Value) > 1 Then
            Me.DataGridView.CurrentRow.Cells(0).Value = Nothing
            Me.DataGridView.CurrentRow.Cells(1).Value = Nothing
            Me.DataGridView.CurrentRow.Cells(4).Value = Nothing
        Else
            'Kiểm tra giá trị tại cột số lượng
            If Not IsNumeric(Me.DataGridView.CurrentRow.Cells(2).Value) Then
                Me.DataGridView.CurrentRow.Cells(2).Value = ""
            Else
                If Me.DataGridView.CurrentRow.Cells(2).Value <= 0 Then
                    Me.DataGridView.CurrentRow.Cells(2).Value = ""
                Else
                    Me.DataGridView.CurrentRow.Cells(2).Value = Int(Me.DataGridView.CurrentRow.Cells(2).Value)
                End If
            End If
            'Kiểm tra giá trị tại cột chiết khấu
            If Not IsNumeric(Me.DataGridView.CurrentRow.Cells(3).Value) Then
                Me.DataGridView.CurrentRow.Cells(3).Value = ""
            Else
                If Me.DataGridView.CurrentRow.Cells(3).Value > 100 Or Me.DataGridView.CurrentRow.Cells(3).Value < 0 Then
                    Me.DataGridView.CurrentRow.Cells(3).Value = ""
                End If
            End If

            'Cập nhật đơn giá bán tự động
            If Len(Me.DataGridView.CurrentRow.Cells(0).Value) > 0 Then
                Me.DataGridView.CurrentRow.Cells(1).Value = objConnect.GetFieldValue("Select tblHangHoa.DGBan From tblHangHoa Where MaH = N'" & Me.DataGridView.CurrentRow.Cells(0).Value & "'")
            End If
            'Cập nhật thuế VAT tự động
            If Len(Me.DataGridView.CurrentRow.Cells(0).Value) > 0 Then
                Me.DataGridView.CurrentRow.Cells(4).Value = objConnect.GetFieldValue("Select tblHangHoa.ThueVAT From tblHangHoa Where MaH = N'" & Me.DataGridView.CurrentRow.Cells(0).Value & "'")
            End If
            'Tính cột thành tiền
            dg = IIf(IsNumeric(Me.DataGridView.CurrentRow.Cells(1).Value), Me.DataGridView.CurrentRow.Cells(1).Value, 0)
            sl = IIf(IsNumeric(Me.DataGridView.CurrentRow.Cells(2).Value), Me.DataGridView.CurrentRow.Cells(2).Value, 0)
            ck = IIf(IsNumeric(Me.DataGridView.CurrentRow.Cells(3).Value), Me.DataGridView.CurrentRow.Cells(3).Value, 0)
            thue = IIf(IsNumeric(Me.DataGridView.CurrentRow.Cells(4).Value), Me.DataGridView.CurrentRow.Cells(4).Value, 0)
            Me.DataGridView.CurrentRow.Cells(5).Value = FormatNumber(((dg * sl) * (1 + thue / 100 - ck / 100)), 2)
        End If
    End Sub

    Private Sub btnHuyBo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnHuyBo.Click
        Me.Close()
    End Sub

    Private Sub btnLuu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLuu.Click
        Dim strSQL_Main As String = ""
        Dim strSQL_Sub As String = ""
        If NhapLieu.ChuaDuThongTin("NN", Me.ErrorProvider) = True Then
            frmMsgOK.HienThi("Thông tin bạn nhập vào chưa hợp lệ", "Thông báo")
        Else
            If BanGhiHopLe() = False Then
                frmMsgOK.HienThi("Thông tin phần chi tiết phiếu xuất kho  chưa hợp lệ", "Thông báo")
            Else
                If objConnect.DaTonTai("Select * From tblPhieuXuatKho Where MaPXK =N'" & Me.txtMaPXK.Text.Trim & "'") = True Then
                    frmMsgOK.HienThi("Mã phiếu xuất kho này đã tồn tại", "Thông báo")
                    Me.txtMaPXK.Focus()
                Else
                    'Thực hiện thêm giá trị mới vào bảng Phiếu nhập kho
                    strSQL_Main = "Insert into tblPhieuXuatKho (MaPXK,NgayXK,MaNV,MaKho,MaKH) "
                    strSQL_Main &= "Values(N'" & Me.txtMaPXK.Text.Trim & "',N'" & NhapLieu.CDateTime(Me.mskNgayXK) & "',"
                    strSQL_Main &= "N'" & pMaNV & "',N'" & Me.cboMaKho.SelectedValue & "',"
                    strSQL_Main &= "N'" & Me.cboKhachHang.SelectedValue & "')"
                    objConnect.RunSQL(strSQL_Main)
                    'Thực hiện lưu dữ liệu vào bảng chi tiết phiếu nhập kho
                    For i As Integer = 0 To Me.DataGridView.RowCount - 2
                        strSQL_Sub = "Insert into tblCTPhieuXuatKho (MaPXK,MaH,SoLuong,DonGia,ChietKhau) "
                        strSQL_Sub &= "Values (N'" & Me.txtMaPXK.Text.Trim & "',"
                        strSQL_Sub &= "N'" & Me.DataGridView.Rows(i).Cells(0).Value & "',"
                        strSQL_Sub &= "N'" & Me.DataGridView.Rows(i).Cells(2).Value & "',"
                        strSQL_Sub &= "N'" & Me.DataGridView.Rows(i).Cells(colDGXuat.Index).Value & "',"
                        strSQL_Sub &= "N'" & IIf(Me.DataGridView.Rows(i).Cells(colChietKhau.Index).Value = "", 0, Me.DataGridView.Rows(i).Cells(colChietKhau.Index).Value) & "')"
                        objConnect.RunSQL(strSQL_Sub)
                    Next
                    If (frmMsgYesNo.HienThi("Bạn có muốn nhập tiếp không ?", "Thông báo") = Windows.Forms.DialogResult.Yes) Then
                        'Xóa dữ liệu trên form
                        Call ResetValues()
                        Dim tg As Date = Now
                        Me.txtMaPXK.Text = "PXK" & tg.Hour & tg.Minute & tg.Second
                        Try
                            Me.mskNgayXK.Text = Now
                        Catch ex As Exception

                        End Try
                    Else
                        Me.Dispose()
                    End If
                    
                End If
            End If
        End If
    End Sub

    
    'Phương thức tính hàng tồn
    Private Function ConHang(ByVal MaKho As String, ByVal MaH As String, ByVal SL_DinhBan As Long, ByRef SL_Ton As Integer) As Boolean
        Dim SL_Nhap, SL_Ban As Long
        Dim strSQL_Nhap, strSQL_Ban As String
        strSQL_Nhap = "SELECT tblPhieuNhapKho.MaKho, tblCTPhieuNhapKho.MaH, tblCTPhieuNhapKho.SoLuong "
        strSQL_Nhap &= "FROM tblPhieuNhapKho RIGHT JOIN tblCTPhieuNhapKho ON tblPhieuNhapKho.MaPNK = tblCTPhieuNhapKho.MaPNK "
        strSQL_Nhap &= "WHERE tblPhieuNhapKho.MaKho=N'" & MaKho & "' And tblCTPhieuNhapKho.MaH=N'" & MaH & "'"
        'Tính tống số lượng nhập
        SL_Nhap = objConnect.getSum(strSQL_Nhap, 2)

        strSQL_Ban = "SELECT tblPhieuXuatKho.MaKho, tblHangHoa.MaH, tblCTPhieuXuatKho.SoLuong FROM tblPhieuXuatKho,tblCTPhieuXuatKho,tblHangHoa "
        strSQL_Ban &= "Where tblPhieuXuatKho.MaPXK=tblCTPhieuXuatKho.MaPXK And tblHangHoa.MaH=tblCTPhieuXuatKho.MaH And tblPhieuXuatKho.MaKho=N'" & MaKho & "' And  tblHangHoa.MaH =N'" & MaH & "'"
        'Tính tổng số lượng bán
        SL_Ban = objConnect.getSum(strSQL_Ban, 2)
        SL_Ton = SL_Nhap - SL_Ban
        If SL_Nhap - SL_Ban >= SL_DinhBan Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub btnThemKhachHang_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnThemKhachHang.Click
        pThem = True
        frmKhachHang.ShowDialog()
        frmKhachHang.ShowInTaskbar = False
    End Sub

    Private Sub btnThemKho_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnThemKho.Click
        pThem = True
        frmKho.ShowDialog()
        frmKho.ShowInTaskbar = False
    End Sub

    Private Sub cboKhachHang_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboKhachHang.GotFocus
        objConnect.SetDataCombobox(Me.cboKhachHang, "Select MaKH,TenKH From tblKhachHang Order by TenKH")
    End Sub

    Private Sub cboMaKho_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboMaKho.GotFocus
        objConnect.SetDataCombobox(Me.cboMaKho, "Select MaKho,TenKho From tblKho Order by TenKho")
    End Sub
End Class