Public Class frmSuaPhieuXuatKho
    Dim MaPXK_Cu As String = "" 'Mã phiếu xuất kho cũ
    Dim NSD_Xoa_Dong As String = "" 'Danh sách bản ghi bị người dùng xóa
    Private Sub btnHuyBo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnHuyBo.Click
        Me.Close()
    End Sub

    Private Sub frmSuaPhieuXuatKho_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
        objConnect.RunSQL("Update tblCTPhieuXuatKho Set Dangxoa ='False'")

    End Sub

    'Phương thức load data dùng để lấy dữ liệu dựa vào mã phiếu nhập kho lấy từ form DMPhieuNhapKho
    Friend Sub LoadData(ByVal MaPXK As String)
        Dim tblPXK As New DataTable
        Dim tblCTPXK As New DataTable
        Dim strSQL_PXK As String = "Select tblPhieuXuatKho.MaPXK,tblPhieuXuatKho.NgayXK,tblNhanVien.HoTen,tblPhieuXuatKho.MaKho,tblPhieuXuatKho.MaKH From tblPhieuXuatKho,tblNhanVien Where tblPhieuXuatKho.MaNV=tblNhanVien.MaNV And tblPhieuXuatKho.MaPXK=N'" & MaPXK & "'"
        Dim strSQL_CTPXK As String = "SELECT tblCTPhieuXuatKho.MaH, tblHangHoa.DGBan, tblCTPhieuXuatKho.SoLuong,tblCTPhieuXuatKho.ChietKhau,tblHangHoa.ThueVAT,((tblHangHoa.DGBan * tblCTPhieuXuatKho.SoLuong)*(1+tblHangHoa.ThueVAT/100-tblCTPhieuXuatKho.ChietKhau/100)) AS ThanhTien, tblCTPhieuXuatKho.IDR "
        strSQL_CTPXK &= "FROM tblCTPhieuXuatKho, tblPhieuXuatKho, tblHangHoa "
        strSQL_CTPXK &= "Where tblCTPhieuXuatKho.MaPXK = tblPhieuXuatKho.MaPXK  And tblCTPhieuXuatKho.MaH = tblHangHoa.MaH And tblCTPhieuXuatKho.MaPXK=N'" & MaPXK & "'"
        'đổ dữ liệu vào tblPXK
        tblPXK = objConnect.GetDataTable(strSQL_PXK)
        'Đổ dữ liệu vào tblCTPhieuXuatKho
        tblCTPXK = objConnect.GetDataTable(strSQL_CTPXK)
        'Lưu giá trị cũ của phiếu xuất kho để làm điều kiện Update
        MaPXK_Cu = tblPXK.Rows(0).Item(0)
        'Đổ dữ liệu lên form phần master
        Me.txtMaPXK.Text = tblPXK.Rows(0).Item(0)               'Mã PXK
        Me.mskNgayXK.Text = tblPXK.Rows(0).Item(1)              'Ngày XK
        Me.txtNhanVien.Text = tblPXK.Rows(0).Item(2)            'Họ tên NV
        Me.cboMaKho.SelectedValue = tblPXK.Rows(0).Item(3)      'Mã kho
        Me.cboKhachHang.SelectedValue = tblPXK.Rows(0).Item(4)  'Mã khách hàng
        'Đổ dữ liệu lên form phần chi tiết
        For i As Integer = 0 To tblCTPXK.Rows.Count - 1
            Me.DataGridView.Rows.Add()                          'Thêm một dòng mới
            Me.DataGridView.Rows(i).Cells(0).Value = tblCTPXK.Rows(i).Item(0)
            Me.DataGridView.Rows(i).Cells(1).Value = tblCTPXK.Rows(i).Item(1)
            Me.DataGridView.Rows(i).Cells(2).Value = tblCTPXK.Rows(i).Item(2)
            Me.DataGridView.Rows(i).Cells(3).Value = tblCTPXK.Rows(i).Item(3)
            Me.DataGridView.Rows(i).Cells(4).Value = tblCTPXK.Rows(i).Item(4)
            Me.DataGridView.Rows(i).Cells(5).Value = tblCTPXK.Rows(i).Item(5)
            Me.DataGridView.Rows(i).Cells(6).Value = tblCTPXK.Rows(i).Item(6)
        Next
    End Sub

    Private Sub frmSuaPhieuNhapKho_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ''Tạo nguồn dữ liệu cho các combobox
        'objConnect.SetDataCombobox(Me.cboKhachHang, "Select MaKH,TenKH From tblKhachHang Order by TenKH")
        'objConnect.SetDataCombobox(Me.cboMaKho, "Select MaKho,TenKho From tblKho Order by TenKho")
        ''phần chi tiết
        ''        objConnect.SetDataComboboxInDataGridView(Me.colMaH, "SELECT MaH, TenH FROM View_HangTon")
        objConnect.SetDataComboboxInDataGridView(Me.colMaH, "SELECT MaH, TenH FROM tblHangHoa")
    End Sub

    Private Sub DataGridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView.CellClick
        If e.ColumnIndex = colXoa.Index And e.RowIndex <> Me.DataGridView.RowCount - 1 Then
            If frmMsgYesNo.HienThi("Bạn có chắc chắn muốn xóa không ?", "Thông báo", False) = Windows.Forms.DialogResult.Yes Then
                If Me.DataGridView.CurrentRow.Cells(6).Value > 0 Then
                    NSD_Xoa_Dong &= Me.DataGridView.CurrentRow.Cells(6).Value & ","
                    objConnect.RunSQL("Update tblCTPhieuXuatKho Set Dangxoa ='True'")
                End If
                Me.DataGridView.Rows.RemoveAt(e.RowIndex)
            End If
        End If
    End Sub

    'Phương thức này dùng để lưu giá trị vào CSDL
    Sub Save(ByVal MaPXK As String, ByVal MaH As String, ByVal ChietKhau As Double, ByVal SoLuong As Long, ByVal DonGia As Double, ByVal IDR As Long, ByVal blnSua As Boolean)
        Dim strUpdate_PXK As String = "Update tblPhieuXuatKho Set MaPXK=N'" & Me.txtMaPXK.Text.Trim & "',"
        strUpdate_PXK &= "NgayXK=N'" & NhapLieu.CDateTime(Me.mskNgayXK) & "',"
        strUpdate_PXK &= "MaNV = N'" & pMaNV & "',MaKho=N'" & Me.cboMaKho.SelectedValue & "',"
        strUpdate_PXK &= "MaKH=N'" & Me.cboKhachHang.SelectedValue & "' "
        strUpdate_PXK &= "Where MaPXK =N'" & MaPXK_Cu & "'"
        'cập nhật dữ liệu cho bảng có liên quan như Hóa đơn bán hàng
        Try
            objConnect.RunSQL("Update tblHDBanHang Set MaPXK=N'" & Me.txtMaPXK.Text.Trim & "' Where MaPXK =N'" & MaPXK_Cu & "'")
        Catch ex As Exception

        End Try

        Dim strInsertCT_PXK As String = "Insert into tblCTPhieuXuatKho (MaPXK,MaH,ChietKhau,DonGia,SoLuong) Values(N'" & Me.txtMaPXK.Text.Trim & "',N'" & MaH & "',N'" & ChietKhau & "',N'" & DonGia & "',N'" & SoLuong & "')"
        Dim strUpdateCT_PXK As String = "Update tblCTPhieuXuatKho Set MaPXK=N'" & Me.txtMaPXK.Text.Trim & "',MaH=N'" & MaH & "',ChietKhau=N'" & ChietKhau & "',SoLuong=N'" & SoLuong & "',DonGia=N'" & DonGia & "' Where IDR=N'" & IDR & "'"
        objConnect.RunSQL(strUpdate_PXK)        'Cập nhật vào bảng tblPhieuXuatKho
        If blnSua = True Then
            objConnect.RunSQL(strUpdateCT_PXK)  'Cập nhật vào bảng tblCTPhieuXuatKho
        Else
            objConnect.RunSQL(strInsertCT_PXK)  'Thêm mới
        End If
    End Sub

    Private Sub btnLuu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLuu.Click
        Dim IDR As Long
        Dim MaPXK As String
        Dim MaH As String
        Dim ChietKhau As Double
        Dim SoLuong As Long
        Dim DonGia As Double
        Dim blnSua As Boolean
        If NhapLieu.ChuaDuThongTin("NN", Me.ErrorProvider) = True Then
            frmMsgOK.HienThi("Thông tin bạn nhập vào chưa hợp lệ", "Thông báo")
        Else
            If BanGhiHopLe() = False Then
                frmMsgOK.HienThi("Bạn chưa nhập đủ thông tin cho phần chi tiết phiếu xuất kho", "Thông báo")
            Else
                For i As Integer = 0 To Me.DataGridView.RowCount - 2 'đếm từ 0 và trừ dòng trắng ở cuối
                    blnSua = IIf(Me.DataGridView.Rows(i).Cells(colIDR.Index).Value < 1, False, True)
                    MaPXK = Me.txtMaPXK.Text.Trim
                    MaH = Me.DataGridView.Rows(i).Cells(colMaH.Index).Value
                    SoLuong = Me.DataGridView.Rows(i).Cells(colSoLuong.Index).Value
                    DonGia = Me.DataGridView.Rows(i).Cells(colDGNhap.Index).Value
                    Try
                        ChietKhau = IIf(Me.DataGridView.Rows(i).Cells(colChietKhau.Index).Value = "", 0, Me.DataGridView.Rows(i).Cells(colChietKhau.Index).Value)
                    Catch ex As Exception
                    End Try
                    IDR = Me.DataGridView.Rows(i).Cells(colIDR.Index).Value
                    Call Save(MaPXK, MaH, ChietKhau, SoLuong, DonGia, IDR, blnSua)

                Next
                If NSD_Xoa_Dong.Trim <> "" Then
                    'Thực hiện xóa các dòng trong do người dùng thực hiện xóa 
                    NSD_Xoa_Dong = Strings.Left(NSD_Xoa_Dong, Len(NSD_Xoa_Dong) - 1)
                    Dim strDelete As String = "Delete From tblCTPhieuXuatKho Where IDR in (" & NSD_Xoa_Dong & ")"
                    objConnect.RunSQL(strDelete)
                End If
                frmMainX.LoadData(6)
                'Đóng form sửa
                frmMsgOK.HienThi("Sửa thành công", "Thông báo")
                Me.Dispose()
            End If
        End If
    End Sub

   

    Private Sub cboKhachHang_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboKhachHang.GotFocus
        objConnect.SetDataCombobox(Me.cboKhachHang, "Select MaKH,TenKH From tblKhachHang Order by TenKH")
    End Sub

    Private Sub cboMaKho_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboMaKho.GotFocus
        objConnect.SetDataCombobox(Me.cboMaKho, "Select MaKho,TenKho From tblKho Order by TenKho")
    End Sub
    ''-------------------------------------
    Private Function BanGhiHopLe() As Boolean
        Dim d, d1, SL_Ton As Integer
        Dim N As Boolean
        Dim C0, C1, C2, C4 As String
        Dim MaK, MaH, SoLuong, IDR As String
        MaK = Me.cboMaKho.SelectedValue
        For i As Integer = 0 To Me.DataGridView.RowCount - 2
            C0 = Trim(Me.DataGridView.Rows(i).Cells(colMaH.Index).Value)
            C1 = Trim(Me.DataGridView.Rows(i).Cells(colDGNhap.Index).Value)
            C2 = Trim(Me.DataGridView.Rows(i).Cells(colSoLuong.Index).Value)
            C4 = Trim(Me.DataGridView.Rows(i).Cells(colThueVAT.Index).Value)
            MaH = Me.DataGridView.Rows(i).Cells(colMaH.Index).Value
            SoLuong = Me.DataGridView.Rows(i).Cells(colSoLuong.Index).Value
            IDR = Me.DataGridView.Rows(i).Cells(colIDR.Index).Value
            If (C0 <> "" And C1 <> "" And C2 <> "" And C4 <> "") Then
                Me.DataGridView.Rows.Item(i).HeaderCell.Value = ""
                d += 1

                If (ConHang(MaK, MaH, SoLuong, SL_Ton, IDR) = False) Then
                    Me.DataGridView.Rows.Item(i).HeaderCell.Value = IIf(SL_Ton <= 0, "Thông báo hiện trong kho " & Me.cboMaKho.Text & " đã hết loại mặt hàng này", "Thông báo hiện trong kho " & Me.cboMaKho.Text & " chỉ còn: " & SL_Ton & " sản phẩm loại này")
                    d1 += 1
                Else
                    Me.DataGridView.Rows.Item(i).HeaderCell.Value = ""
                End If

            Else
                Me.DataGridView.Rows.Item(i).HeaderCell.Value = "Bạn chưa nhập đủ thông tin cho bản ghi này "
                N = True
            End If

        Next

        If (d < 1 Or N = True Or d1 > 0) Then
            Return False
        Else
            Return True
        End If
    End Function


    
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
                Me.DataGridView.CurrentRow.Cells(1).Value = objConnect.GetFieldValue("Select DGBan From tblHangHoa Where MaH = N'" & Me.DataGridView.CurrentRow.Cells(0).Value & "'")
            End If
            'Cập nhật thuế VAT tự động
            If Len(Me.DataGridView.CurrentRow.Cells(0).Value) > 0 Then
                Me.DataGridView.CurrentRow.Cells(4).Value = objConnect.GetFieldValue("Select ThueVAT From tblHangHoa Where MaH = N'" & Me.DataGridView.CurrentRow.Cells(0).Value & "'")
            End If
            'Tính cột thành tiền
            dg = IIf(IsNumeric(Me.DataGridView.CurrentRow.Cells(1).Value), Me.DataGridView.CurrentRow.Cells(1).Value, 0)
            sl = IIf(IsNumeric(Me.DataGridView.CurrentRow.Cells(2).Value), Me.DataGridView.CurrentRow.Cells(2).Value, 0)
            ck = IIf(IsNumeric(Me.DataGridView.CurrentRow.Cells(3).Value), Me.DataGridView.CurrentRow.Cells(3).Value, 0)
            thue = IIf(IsNumeric(Me.DataGridView.CurrentRow.Cells(4).Value), Me.DataGridView.CurrentRow.Cells(4).Value, 0)
            Me.DataGridView.CurrentRow.Cells(5).Value = FormatNumber(((dg * sl) * (1 + thue / 100 - ck / 100)), 2)
        End If
    End Sub

    Private Sub btnThemKho_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnThemKho.Click
        pThem = True
        frmKho.ShowDialog()
        frmKhachHang.ShowInTaskbar = False
    End Sub

    Private Sub btnThemKhachHang_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnThemKhachHang.Click
        pThem = True
        frmKhachHang.ShowDialog()
        frmKhachHang.ShowInTaskbar = False
    End Sub

    Private Sub btnThemNhanVien_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        frmNhanVien.ShowDialog()
        frmNhanVien.ShowInTaskbar = False
    End Sub
    'Phương thức tính hàng tồn
    Private Function ConHang(ByVal MaKho As String, ByVal MaH As String, ByVal SL_DinhBan As Long, ByRef SL_Ton As Integer, ByVal IDR As Long) As Boolean
        Dim SL_Nhap, SL_Ban As Long

        Dim strSQL_Nhap, strSQL_Ban As String
        strSQL_Nhap = "SELECT tblPhieuNhapKho.MaKho, tblCTPhieuNhapKho.MaH, tblCTPhieuNhapKho.SoLuong "
        strSQL_Nhap &= "FROM tblPhieuNhapKho RIGHT JOIN tblCTPhieuNhapKho ON tblPhieuNhapKho.MaPNK = tblCTPhieuNhapKho.MaPNK "
        strSQL_Nhap &= "WHERE tblPhieuNhapKho.MaKho=N'" & MaKho & "' And tblCTPhieuNhapKho.MaH=N'" & MaH & "'"
        'Tính tống số lượng nhập
        SL_Nhap = objConnect.getSum(strSQL_Nhap, 2)
        strSQL_Ban = "SELECT tblPhieuXuatKho.MaKho, tblCTPhieuXuatKho.MaH, tblCTPhieuXuatKho.SoLuong FROM tblPhieuXuatKho,tblCTPhieuXuatKho "
        strSQL_Ban &= "Where tblPhieuXuatKho.MaPXK=tblCTPhieuXuatKho.MaPXK  And tblPhieuXuatKho.MaKho=N'" & MaKho & "' And tblCTPhieuXuatKho.MaH =N'" & MaH & "' And tblCTPhieuXuatKho.IDR not like N'" & IDR & "'"
        'Tính tổng số lượng bán
        SL_Ban = objConnect.getSum(strSQL_Ban, 2)
        SL_Ton = 0
        SL_Ton = SL_Nhap - SL_Ban
        If SL_Nhap - SL_Ban >= SL_DinhBan Then
            Return True
        Else
            Return False
        End If
    End Function
End Class