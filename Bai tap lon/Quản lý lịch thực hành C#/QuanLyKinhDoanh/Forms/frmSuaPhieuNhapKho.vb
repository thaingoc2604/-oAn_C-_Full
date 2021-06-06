Public Class frmSuaPhieuNhapKho
    Dim MaPNK_Cu As String = ""     'Mã phiếu nhập kho cũ
    Dim NSD_Xoa_Dong As String = "" 'Danh sách bản ghi bị người dùng xóa

    Private Sub frmSuaPhieuNhapKho_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub btnHuyBo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnHuyBo.Click
        Me.Close()
    End Sub
    'Phương thức load data dùng để lấy dữ liệu dựa vào mã phiếu nhập kho lấy từ form DMPhieuNhapKho
    Friend Sub LoadData(ByVal MaPNK As String)
        Dim tblPNK As New DataTable
        Dim tblCTPNK As New DataTable
        Dim strSQL_PNK As String = "Select tblPhieuNhapKho.MaPNK,tblPhieuNhapKho.NgayNK,tblPhieuNhapKho.MaNV,tblPhieuNhapKho.MaKho,tblPhieuNhapKho.MaNCC,tblPhieuNhapKho.NguoiGH,tblNhanVien.HoTen From tblPhieuNhapKho,tblNhanVien Where tblPhieuNhapKho.MaNV=tblNhanVien.MaNV And MaPNK=N'" & MaPNK & "'"
        Dim strSql_CTPNK As String = "Select MaH,DGNhap,SoLuong,[DGNhap]*[SoLuong] As ThanhTien,IDR,MaPNK From tblCTPhieuNhapKho Where MaPNK=N'" & MaPNK & "'"
        'đổ dữ liệu vào tblPNK
        tblPNK = objConnect.GetDataTable(strSQL_PNK)
        'Đổ dữ liệu vào tblCTPhieuNhapKho
        tblCTPNK = objConnect.GetDataTable(strSql_CTPNK)
        'Lưu giá trị cũ của phiếu nhập kho để làm điều kiện Update
        MaPNK_Cu = tblPNK.Rows(0).Item(0)
        'Đổ dữ liệu lên form phần master
        Me.txtMaPNK.Text = tblPNK.Rows(0).Item(0)           'Mã PNK
        Me.mskNgayNK.Text = tblPNK.Rows(0).Item(1)          'Ngày NK
        Me.txtNhanVien.Text = tblPNK.Rows(0).Item(6)                      'Tên NV
        Me.cboMaKho.SelectedValue = tblPNK.Rows(0).Item(3)  'Mã kho
        Me.cboNhaCC.SelectedValue = tblPNK.Rows(0).Item(4)  'Mã NCC
        Me.txtNguoiGH.Text = tblPNK.Rows(0).Item(5)         'Người GH
        'Đổ dữ liệu lên form phần chi tiết
        For i As Integer = 0 To tblCTPNK.Rows.Count - 1
            Me.DataGridView.Rows.Add()
            Me.DataGridView.Rows(i).Cells(colMaH.Index).Value = tblCTPNK(i)(0)
            Me.DataGridView.Rows(i).Cells(colDGNhap.Index).Value = tblCTPNK(i)(1)
            Me.DataGridView.Rows(i).Cells(colSoLuong.Index).Value = tblCTPNK(i)(2)
            Me.DataGridView.Rows(i).Cells(colThanhTien.Index).Value = tblCTPNK(i)(3)
            Me.DataGridView.Rows(i).Cells(colIDR.Index).Value = tblCTPNK(i)(4)
        Next
    End Sub

    Private Sub frmSuaPhieuNhapKho_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ''Tạo nguồn dữ liệu cho các combobox
        'objConnect.SetDataCombobox(Me.cboNhaCC, "Select MaNCC,TenNCC From tblNhaCC Order by TenNCC")
        'objConnect.SetDataCombobox(Me.cboMaKho, "Select MaKho,TenKho From tblKho Order by TenKho")
        ''phần chi tiết
        objConnect.SetDataComboboxInDataGridView(Me.colMaH, "Select MaH,TenH From tblHangHoa")

    End Sub

    Private Sub DataGridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView.CellClick
        If e.ColumnIndex = colXoa.Index And e.RowIndex <> Me.DataGridView.RowCount - 1 Then
            If frmMsgYesNo.HienThi("Bạn có chắc chắn muốn xóa bản ghi được  chọn không ?", "Thông báo", False) = Windows.Forms.DialogResult.Yes Then
                If Me.DataGridView.CurrentRow.Cells(colIDR.Index).Value > 0 Then
                    NSD_Xoa_Dong &= Me.DataGridView.CurrentRow.Cells(colIDR.Index).Value & ","
                End If
                Me.DataGridView.Rows.RemoveAt(e.RowIndex)
            End If
        End If
    End Sub

    'Phương thức này dùng để lưu giá trị vào CSDL
    Sub Save(ByVal MaPNK As String, ByVal MaH As String, ByVal DGNhap As Double, ByVal SoLuong As Long, ByVal IDR As Long, ByVal blnSua As Boolean)
        Dim strUpdate_PNK As String = "Update tblPhieuNhapKho Set MaPNK=N'" & Me.txtMaPNK.Text.Trim & "',"
        strUpdate_PNK &= "NgayNK='" & NhapLieu.CDateTime(Me.mskNgayNK) & "',"
        strUpdate_PNK &= "MaNV = N'" & pMaNV & "',MaKho=N'" & Me.cboMaKho.SelectedValue & "',"
        strUpdate_PNK &= "MaNCC=N'" & Me.cboNhaCC.SelectedValue & "',NguoiGH=N'" & Me.txtNguoiGH.Text.Trim & "' "
        strUpdate_PNK &= "Where MaPNK =N'" & MaPNK_Cu & "'"
        Dim strInsertCT_PNK As String = "Insert into tblCTPhieuNhapKho (MaPNK,MaH,DGNhap,SoLuong) Values(N'" & Me.txtMaPNK.Text.Trim & "',N'" & MaH & "',N'" & DGNhap & "',N'" & SoLuong & "')"
        Dim strUpdateCT_PNK As String = "Update tblCTPhieuNhapKho Set MaPNK=N'" & Me.txtMaPNK.Text.Trim & "',MaH=N'" & MaH & "',DGNhap=N'" & DGNhap & "',SoLuong=N'" & SoLuong & "' Where IDR=N'" & IDR & "'"
        objConnect.RunSQL(strUpdate_PNK)        'Cập nhật vào bảng tblPhieuNhapKho
        If blnSua = True Then
            objConnect.RunSQL(strUpdateCT_PNK)  'Cập nhật vào bảng tblCTPhieuNhapKho
        Else
            objConnect.RunSQL(strInsertCT_PNK)  'Thêm mới
        End If
    End Sub

    Private Sub btnLuu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLuu.Click
        Dim lngIDR As Long
        Dim strMaPNK As String
        Dim strMaH As String
        Dim dblDGNhap As Double
        Dim lngSoLuong As Long
        Dim blnAction As Boolean
        If NhapLieu.ChuaDuThongTin("NN", Me.ErrorProvider) = True Then
            frmMsgOK.HienThi("Thông tin bạn nhập vào chưa hợp lệ", "Thông báo")
        Else
            If BanGhiHopLe() = False Then
                frmMsgOK.HienThi("Bạn chưa nhập đủ thông tin cho phần chi tiết phiếu nhập kho", "Thông báo")
            Else
                For i As Integer = 0 To Me.DataGridView.RowCount - 2 'đếm từ 0 và trừ dòng trắng ở cuối
                    blnAction = IIf(Me.DataGridView.Rows(i).Cells(4).Value < 1, False, True)
                    strMaPNK = Me.txtMaPNK.Text.Trim
                    strMaH = Me.DataGridView.Rows(i).Cells(0).Value
                    dblDGNhap = Me.DataGridView.Rows(i).Cells(1).Value
                    lngSoLuong = Me.DataGridView.Rows(i).Cells(2).Value
                    lngIDR = Me.DataGridView.Rows(i).Cells(4).Value
                    Call Save(strMaPNK, strMaH, dblDGNhap, lngSoLuong, lngIDR, blnAction)
                Next

                If NSD_Xoa_Dong.Trim <> "" Then
                    'Thực hiện xóa các dòng trong do người dùng thực hiện xóa 
                    NSD_Xoa_Dong = Strings.Left(NSD_Xoa_Dong, Len(NSD_Xoa_Dong) - 1)
                    Dim strDelete As String = "Delete From tblCTPhieuNhapKho Where IDR in (" & NSD_Xoa_Dong & ")"
                    objConnect.RunSQL(strDelete)
                End If
                frmMainX.LoadData(3)
                'Đóng form sửa
                frmMsgOK.HienThi("Sửa thành công", "Thông báo")
                Me.Dispose()
            End If
        End If
    End Sub


    Private Sub cboNhaCC_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboNhaCC.GotFocus
        objConnect.SetDataCombobox(Me.cboNhaCC, "Select MaNCC,TenNCC From tblNhaCC Order by TenNCC")
    End Sub

    Private Sub cboMaKho_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboMaKho.GotFocus
        objConnect.SetDataCombobox(Me.cboMaKho, "Select MaKho,TenKho From tblKho Order by TenKho")
    End Sub
    ''-------------------------------------
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
                Me.DataGridView.Rows.Item(i).HeaderCell.Value = "Thông báo, bạn chưa nhập đủ thông tin cho bản ghi này"
                N = True
            End If
        Next
        If (d < 1 Or N = True) Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub DataGridView_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView.CellEndEdit
        Dim dg As Double
        Dim sl As Long
        If NhapLieu.DemChuoiCon(Me.DataGridView, 0, Me.DataGridView.CurrentRow.Cells(0).Value) > 1 Then
            Me.DataGridView.CurrentRow.Cells(0).Value = Nothing
        Else
            'Kiểm tra nhập đơn giá
            If Not IsNumeric(Me.DataGridView.CurrentRow.Cells(1).Value) Then
                Me.DataGridView.CurrentRow.Cells(1).Value = ""
            Else
                If Me.DataGridView.CurrentRow.Cells(1).Value <= 0 Then
                    Me.DataGridView.CurrentRow.Cells(1).Value = ""
                End If
            End If

            'Kiểm tra nhập số lượng
            If Not IsNumeric(Me.DataGridView.CurrentRow.Cells(2).Value) Then
                Me.DataGridView.CurrentRow.Cells(2).Value = ""
            Else
                If Me.DataGridView.CurrentRow.Cells(2).Value <= 0 Then
                    Me.DataGridView.CurrentRow.Cells(2).Value = ""
                Else
                    Me.DataGridView.CurrentRow.Cells(2).Value = Int(Me.DataGridView.CurrentRow.Cells(2).Value)
                End If
            End If

            dg = IIf(IsNumeric(Me.DataGridView.CurrentRow.Cells(1).Value), Me.DataGridView.CurrentRow.Cells(1).Value, 0)
            sl = IIf(IsNumeric(Me.DataGridView.CurrentRow.Cells(2).Value), Me.DataGridView.CurrentRow.Cells(2).Value, 0)
            Me.DataGridView.CurrentRow.Cells(3).Value = FormatNumber((dg * sl), 2)
        End If
    End Sub

    Private Sub btnThemKho_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnThemKho.Click
        pThem = True
        frmKho.ShowDialog()
        frmKhachHang.ShowInTaskbar = False
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

  
End Class