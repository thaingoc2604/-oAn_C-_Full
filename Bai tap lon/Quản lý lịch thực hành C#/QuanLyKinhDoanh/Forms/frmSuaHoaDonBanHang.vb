Public Class frmSuaHoaDonBanHang
    Dim MaHDB_Cu As String = ""
    Dim NSD_Xoa_Dong As String = "" 'Danh sách bản ghi bị người dùng xóa
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
            If frmMsgYesNo.HienThi("Bạn có chắc chắn muốn xóa không ?", "Thông báo", False) = Windows.Forms.DialogResult.Yes Then
                If Me.DataGridView.CurrentRow.Cells(colIDR.Index).Value > 0 Then
                    NSD_Xoa_Dong &= Me.DataGridView.CurrentRow.Cells(colIDR.Index).Value & ","
                    objConnect.RunSQL("Update tblChiTietHoaDonBanHang Set Dangxoa ='True'")
                End If
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

    Private Sub frmSuaHoaDonBanHang_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmMainX.LoadData(5)
        objConnect.RunSQL("Update tblChiTietHoaDonBanHang Set Dangxoa ='False'")
    End Sub

    Private Sub frmSuaHoaDonBanHang_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'objConnect.SetDataCombobox(Me.cboKhachHang, "Select MaKH,TenKH From tblKhachHang Order by TenKH")
        objConnect.SetDataComboboxInDataGridView(Me.colMaH, "Select MaH,TenH From tblHangHoa Order by TenH")
    End Sub


    Private Sub btnHuyBo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnHuyBo.Click
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
        Dim IDR As Long
        Dim MaHDB As String
        Dim MaH As String
        Dim ChietKhau As Double
        Dim SoLuong As Long
        Dim DonGia, ThueVAT As Double
        Dim blnSua As Boolean
        If NhapLieu.ChuaDuThongTin("NN", Me.ErrorProvider) = True Then
            frmMsgOK.HienThi("Thông tin bạn nhập vào chưa hợp lệ", "Thông báo")
        Else
            If BanGhiHopLe() = False Then
                frmMsgOK.HienThi("Bạn chưa nhập đủ thông tin cho phần chi tiết hóa đơn bán", "Thông báo")
            Else
                For i As Integer = 0 To Me.DataGridView.RowCount - 2 'đếm từ 0 và trừ dòng trắng ở cuối
                    blnSua = IIf(Me.DataGridView.Rows(i).Cells(colIDR.Index).Value < 1, False, True)
                    MaHDB = Me.txtMaHD.Text.Trim
                    MaH = Me.DataGridView.Rows(i).Cells(colMaH.Index).Value
                    SoLuong = Me.DataGridView.Rows(i).Cells(colSoLuong.Index).Value
                    DonGia = Me.DataGridView.Rows(i).Cells(colDonGia.Index).Value
                    ThueVAT = Me.DataGridView.Rows(i).Cells(colThue.Index).Value
                    Try
                        ChietKhau = IIf(Me.DataGridView.Rows(i).Cells(colChietKhau.Index).Value = "", 0, Me.DataGridView.Rows(i).Cells(colChietKhau.Index).Value)
                    Catch ex As Exception
                    End Try
                    IDR = Me.DataGridView.Rows(i).Cells(colIDR.Index).Value
                    Call Save(MaHDB, MaH, ChietKhau, SoLuong, DonGia, ThueVAT, IDR, blnSua)

                Next
                If NSD_Xoa_Dong.Trim <> "" Then
                    'Thực hiện xóa các dòng trong do người dùng thực hiện xóa 
                    NSD_Xoa_Dong = Strings.Left(NSD_Xoa_Dong, Len(NSD_Xoa_Dong) - 1)
                    Dim strDelete As String = "Delete From tblChiTietHoaDonBanHang Where IDR in (" & NSD_Xoa_Dong & ")"
                    objConnect.RunSQL(strDelete)
                End If
                frmMainX.LoadData(5)
                'Đóng form sửa
                frmMsgOK.HienThi("Sửa thành công", "Thông báo")
                Me.Dispose()
            End If
        End If
    End Sub

    'Phương thức này dùng để lưu giá trị vào CSDL
    Sub Save(ByVal MaHDB As String, ByVal MaH As String, ByVal ChietKhau As Double, ByVal SoLuong As Long, ByVal DonGia As Double, ByVal ThueVAT As Double, ByVal IDR As Long, ByVal blnSua As Boolean)
        Dim strUpdate_HDB As String = "Update tblHoaDonBanHang Set MaHDBH=N'" & Me.txtMaHD.Text.Trim & "',"
        strUpdate_HDB &= "NgayHDBH=N'" & NhapLieu.CDateTime(Me.mskNgayHD) & "',"
        strUpdate_HDB &= "MaNV = N'" & pMaNV & "',MaKH=N'" & Me.cboKhachHang.SelectedValue & "',"
        strUpdate_HDB &= "NgayGiaoHang=N'" & NhapLieu.CDateTime(mskNgayGiaoHang) & "',"
        strUpdate_HDB &= "PhiVanChuyen=N'" & Me.txtPhiVanChuyen.Text & "' "
        strUpdate_HDB &= "Where MaHDBH =N'" & MaHDB_Cu & "'"

        Dim strInsertCT_HDB As String = "Insert into tblChiTietHoaDonBanHang(MaHDBH,MaH,GiamGia,DonGia,SoLuong,ThueVAT) Values(N'" & Me.txtMaHD.Text.Trim & "',N'" & MaH & "',N'" & ChietKhau & "',N'" & DonGia & "',N'" & SoLuong & "',N'" & ThueVAT & "')"
        Dim strUpdateCT_HDB As String = "Update tblChiTietHoaDonBanHang Set MaHDBH=N'" & Me.txtMaHD.Text.Trim & "',MaH=N'" & MaH & "',GiamGia=N'" & ChietKhau & "',SoLuong=N'" & SoLuong & "',DonGia=N'" & DonGia & "',ThueVAT=N'" & ThueVAT & "'  Where IDR=N'" & IDR & "'"
        objConnect.RunSQL(strUpdate_HDB)        'Cập nhật vào bảng tblChiTietHoaDonBan
        If blnSua = True Then
            objConnect.RunSQL(strUpdateCT_HDB)  'Cập nhật vào bảng tblChiTietHoaDonBan
        Else
            objConnect.RunSQL(strInsertCT_HDB)  'Thêm mới
        End If
    End Sub

    Private Function BanGhiHopLe() As Boolean
        Dim d, d1, SL_Ton As Integer
        Dim N As Boolean
        Dim C0, C1, C2 As String
        Dim MaH, SoLuong, IDR As String       
        For i As Integer = 0 To Me.DataGridView.RowCount - 2
            C0 = Trim(Me.DataGridView.Rows(i).Cells(colMaH.Index).Value)
            C1 = Trim(Me.DataGridView.Rows(i).Cells(colDonGia.Index).Value)
            C2 = Trim(Me.DataGridView.Rows(i).Cells(colSoLuong.Index).Value)            
            MaH = Me.DataGridView.Rows(i).Cells(colMaH.Index).Value
            SoLuong = Me.DataGridView.Rows(i).Cells(colSoLuong.Index).Value
            IDR = Me.DataGridView.Rows(i).Cells(colIDR.Index).Value
            If (C0 <> "" And C1 <> "" And C2 <> "") Then
                Me.DataGridView.Rows.Item(i).HeaderCell.Value = ""
                d += 1

                If (ConHang(MaH, SoLuong, SL_Ton, IDR) = False) Then
                    Me.DataGridView.Rows.Item(i).HeaderCell.Value = IIf(SL_Ton <= 0, "Thông báo hiện trong kho đã hết loại mặt hàng này", "Thông báo hiện trong kho chỉ còn: " & SL_Ton & " sản phẩm loại này")
                    d1 += 1
                Else
                    Me.DataGridView.Rows.Item(i).HeaderCell.Value = ""
                End If

            Else
                Me.DataGridView.Rows.Item(i).HeaderCell.Value = "Bạn phải nhập tên hàng, số lượng, đơn giá bán "
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
    Private Function ConHang(ByVal MaH As String, ByVal SL_DinhBan As Long, ByRef SL_Ton As Integer, ByVal IDR As Long) As Boolean
        

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

    Friend Sub LoadData(ByVal MaHDB As String)
        Dim tblHDB As New DataTable
        Dim tblCTHDB As New DataTable
        Dim strSQL_HDB As String = "Select HD.MaHDBH,HD.NgayHDBH,HD.MaKH,NV.HoTen,HD.NgayGiaoHang,HD.HanThanhToan,HD.PhiVanChuyen From tblHoaDonBanHang AS HD,tblNhanVien as NV Where HD.MaNV=NV.MaNV And MaHDBH=N'" & MaHDB & "'"
        Dim strSql_CTHDB As String = "Select MaH,DonGia,SoLuong,GiamGia,ThueVAT,([DonGia]*[SoLuong])*(1+ThueVAT*0.01-GiamGia*0.01) As ThanhTien,IDR From tblChiTietHoaDonBanHang Where MaHDBH=N'" & MaHDB & "'"
        'đổ dữ liệu vào tblPNK
        tblHDB = objConnect.GetDataTable(strSQL_HDB)
        'Đổ dữ liệu vào tblChiTietHoaDonMua
        tblCTHDB = objConnect.GetDataTable(strSql_CTHDB)
        'Lưu giá trị cũ của phiếu nhập kho để làm điều kiện Update
        MaHDB_Cu = tblHDB.Rows(0).Item(0)
        'Đổ dữ liệu lên form phần master
        Me.txtMaHD.Text = tblHDB.Rows(0).Item(0)           'Mã HDMH
        Me.mskNgayHD.Text = tblHDB.Rows(0).Item(1)
        Me.cboKhachHang.SelectedValue = tblHDB.Rows(0).Item(2)
        Me.txtNhanVien.Text = tblHDB.Rows(0).Item(3)
        Me.mskNgayGiaoHang.Text = tblHDB.Rows(0).Item(4)
        Me.mskHanThanhToan.Text = tblHDB.Rows(0).Item(5)
        Me.txtPhiVanChuyen.Text = tblHDB.Rows(0).Item(6)
        'Đổ dữ liệu lên form phần chi tiết
        For i As Integer = 0 To tblCTHDB.Rows.Count - 1
            Me.DataGridView.Rows.Add()
            Me.DataGridView.Rows(i).Cells(colMaH.Index).Value = tblCTHDB(i)(0)
            Me.DataGridView.Rows(i).Cells(colDonGia.Index).Value = tblCTHDB(i)(1)
            Me.DataGridView.Rows(i).Cells(colSoLuong.Index).Value = tblCTHDB(i)(2)
            Me.DataGridView.Rows(i).Cells(colChietKhau.Index).Value = tblCTHDB(i)(3)
            Me.DataGridView.Rows(i).Cells(colThue.Index).Value = tblCTHDB(i)(4)
            Me.DataGridView.Rows(i).Cells(colThanhTien.Index).Value = tblCTHDB(i)(5)
            Me.DataGridView.Rows(i).Cells(colIDR.Index).Value = tblCTHDB(i)(6)
        Next
    End Sub

End Class