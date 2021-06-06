Public Class frmPhieuNhapKho

    Private Sub frmPhieuNhapKho_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
        frmMainX.LoadData(3)
    End Sub

    Private Sub frmPhieuNhapKho_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.txtNhanVien.Text = pTenNV
        objConnect.SetDataCombobox(Me.cboNhaCC, "Select MaNCC,TenNCC From tblNhaCC Order by TenNCC")
        Me.cboNhaCC.SelectedIndex = -1
        objConnect.SetDataCombobox(Me.cboMaKho, "Select MaKho,TenKho From tblKho Order by TenKho")
        Me.cboMaKho.SelectedIndex = -1
        objConnect.SetDataComboboxInDataGridView(Me.colMaH, "Select MaH,TenH From tblHangHoa Order by TenH")
        Dim tg As Date = Now
        Me.txtMaPNK.Text = "PNK" & tg.Hour & tg.Minute & tg.Second
        Try
            Me.mskNgayNK.Text = Now
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnHuyBo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnHuyBo.Click
        Me.Close()
    End Sub

    Private Sub btnLuu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLuu.Click
        Dim strSQL_Main, strSQL_Sub As String
        If NhapLieu.ChuaDuThongTin("NN", Me.ErrorProvider) = True Then
            frmMsgOK.HienThi("Thông tin bạn nhập vào chưa hợp lệ", "Thông báo")
        Else
            If BanGhiHopLe() = False Then
                frmMsgOK.HienThi("Bạn chưa nhập đủ thông tin cho phần chi tiết phiếu nhập kho", "Thông báo")
            Else
                'Thực hiện thêm giá trị mới vào bảng Phiếu nhập kho
                strSQL_Main = "Insert into tblPhieuNhapKho (MaPNK,NgayNK,MaNV,MaKho,MaNCC,NguoiGH) "
                strSQL_Main &= "Values(N'" & Me.txtMaPNK.Text.Trim & "',N'" & NhapLieu.CDateTime(Me.mskNgayNK) & "',"
                strSQL_Main &= "N'" & pMaNV & "',N'" & Me.cboMaKho.SelectedValue & "',"
                strSQL_Main &= "N'" & Me.cboNhaCC.SelectedValue & "',N'" & Me.txtNguoiGH.Text.Trim & "')"
                objConnect.RunSQL(strSQL_Main)
                'Thực hiện lưu dữ liệu vào bảng chi tiết phiếu nhập kho
                For i As Integer = 0 To Me.DataGridView.RowCount - 2
                    strSQL_Sub = "Insert into tblCTPhieuNhapKho (MaPNK,MaH,DGNhap,SoLuong) "
                    strSQL_Sub &= "Values (N'" & Me.txtMaPNK.Text.Trim & "',"
                    strSQL_Sub &= "N'" & Me.DataGridView.Rows(i).Cells(0).Value & "',"
                    strSQL_Sub &= "N'" & Me.DataGridView.Rows(i).Cells(1).Value & "',"
                    strSQL_Sub &= "N'" & Me.DataGridView.Rows(i).Cells(2).Value & "')"
                    objConnect.RunSQL(strSQL_Sub)
                Next
                If (frmMsgYesNo.HienThi("Bạn có muốn nhập tiếp không ?", "Thông báo") = Windows.Forms.DialogResult.Yes) Then
                    'Xóa dữ liệu trên form
                    Call ResetValues()
                    Dim tg As Date = Now
                    Me.txtMaPNK.Text = "PNK" & tg.Hour & tg.Minute & tg.Second
                    Try
                        Me.mskNgayNK.Text = Now
                    Catch ex As Exception

                    End Try
                Else
                    Me.Dispose()
                End If
                
            End If
        End If

    End Sub

    Private Function BanGhiHopLe() As Boolean
        Dim d As Integer = 0
        Dim N As Boolean
        Dim C0, C1, C2 As String
        For i As Integer = 0 To Me.DataGridView.RowCount - 2
            C0 = Trim(Me.DataGridView.Rows(i).Cells(colMaH.Index).Value)
            C1 = Trim(Me.DataGridView.Rows(i).Cells(colDGNhap.Index).Value)
            C2 = Trim(Me.DataGridView.Rows(i).Cells(colSoLuong.Index).Value)
            If (C0 <> "" And C1 <> "" And C2 <> "") Then
                d += 1
                Me.DataGridView.Rows.Item(i).HeaderCell.Value = ""
            Else
                Me.DataGridView.Rows.Item(i).HeaderCell.Value = "Lỗi nhập liệu ! bạn phải nhập tên hàng, đơn giá và số lượng"
                N = True
            End If
        Next
        If (d < 1 Or N = True) Then
            Return False
        Else
            Return True
        End If
    End Function

    'Phương thức xóa dữ liệu trên form
    Private Sub ResetValues()
        Me.txtMaPNK.Text = ""
        Me.mskNgayNK.Text = ""
        Me.cboMaKho.SelectedIndex = -1
        Me.cboNhaCC.SelectedIndex = -1
        Me.txtNguoiGH.Text = ""
        'Xóa dữ liệu trên gridview
        Me.DataGridView.Rows.Clear()
        'Xóa báo lỗi nếu có
        NhapLieu.RemoveErrorProvider("NN", Me.ErrorProvider)
        Me.txtMaPNK.Focus()
    End Sub

    Private Sub DataGridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView.CellClick
        If e.ColumnIndex = colXoa.Index And e.RowIndex <> Me.DataGridView.RowCount - 1 Then
            If frmMsgYesNo.HienThi("Bạn có chắc chắn muốn xóa bản ghi được  chọn không ?", "Thông báo", False) = Windows.Forms.DialogResult.Yes Then
                Me.DataGridView.Rows.RemoveAt(e.RowIndex)
            End If
        End If
    End Sub

    Private Sub btnThemNhaCC_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnThemNhaCC.Click
        pThem = True
        frmNhaCC.ShowDialog()
        frmNhaCC.ShowInTaskbar = False
    End Sub

    Private Sub btnThemNhanVien_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        frmNhanVien.ShowDialog()
        frmNhanVien.ShowInTaskbar = False
    End Sub

    Private Sub btnThemKho_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnThemKho.Click
        pThem = True
        frmKho.ShowDialog()
        frmKho.ShowInTaskbar = False
    End Sub

    Private Sub DataGridView_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView.CellEndEdit
        Dim dg As Double
        Dim sl As Long
        If NhapLieu.DemChuoiCon(Me.DataGridView, 0, Me.DataGridView.CurrentRow.Cells(colMaH.Index).Value) > 1 Then
            Me.DataGridView.CurrentRow.Cells(colMaH.Index).Value = Nothing
        Else
            'Kiểm tra nhập đơn giá
            If Not IsNumeric(Me.DataGridView.CurrentRow.Cells(colDGNhap.Index).Value) Then
                Me.DataGridView.CurrentRow.Cells(colDGNhap.Index).Value = ""
            Else
                If Me.DataGridView.CurrentRow.Cells(colDGNhap.Index).Value <= 0 Then
                    Me.DataGridView.CurrentRow.Cells(colDGNhap.Index).Value = ""
                End If
            End If

            'Kiểm tra nhập số lượng
            If Not IsNumeric(Me.DataGridView.CurrentRow.Cells(colSoLuong.Index).Value) Then
                Me.DataGridView.CurrentRow.Cells(colSoLuong.Index).Value = ""
            Else
                If Me.DataGridView.CurrentRow.Cells(colSoLuong.Index).Value <= 0 Then
                    Me.DataGridView.CurrentRow.Cells(colSoLuong.Index).Value = ""
                Else
                    Me.DataGridView.CurrentRow.Cells(colSoLuong.Index).Value = Int(Me.DataGridView.CurrentRow.Cells(colSoLuong.Index).Value)
                End If
            End If

            dg = IIf(IsNumeric(Me.DataGridView.CurrentRow.Cells(colDGNhap.Index).Value), Me.DataGridView.CurrentRow.Cells(colDGNhap.Index).Value, 0)
            sl = IIf(IsNumeric(Me.DataGridView.CurrentRow.Cells(colSoLuong.Index).Value), Me.DataGridView.CurrentRow.Cells(colSoLuong.Index).Value, 0)
            Me.DataGridView.CurrentRow.Cells(colThanhTien.Index).Value = FormatNumber((dg * sl), 2)
        End If
        
    End Sub

    Private Sub cboNhaCC_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboNhaCC.GotFocus
        objConnect.SetDataCombobox(Me.cboNhaCC, "Select MaNCC,TenNCC From tblNhaCC Order by TenNCC")
    End Sub

    Private Sub cboMaKho_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboMaKho.GotFocus
        objConnect.SetDataCombobox(Me.cboMaKho, "Select MaKho,TenKho From tblKho Order by TenKho")
    End Sub

    
    Private Sub DataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView.CellContentClick

    End Sub
End Class