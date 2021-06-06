Imports System.Windows.Forms
Imports System.Globalization
Imports DevComponents.DotNetBar.Controls

''=================================================''
'' Copyright Trương Hữu Quyền Đại học Giao Thông Vận Tải''
''=================================================''
Public Class NhapLieu       ''Lớp này dùng để kiểm tra nhập liệu    

    Public Shared Function ChuaDuThongTin(ByVal DieuKienKiemTra As String, ByVal TenErrorProvider As ErrorProvider) As Boolean
        Dim blnResult As Boolean = True
        Try

            Dim ListControl As New List(Of Control) 'Danh sách chứa các điều khiển của form
            Dim ctlC As Control
            Dim currentForm As Form         ' Dùng để xác định form hiện thời đang hoạt động
            currentForm = Form.ActiveForm   ' Xác định form nhận focus
            Dim intTemp As Integer
            Dim intMinIndex As Integer
            'Dim strDateFormat As String = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern()
            'Lấy các điều khiển trên form và trên vật chứa khác lưu vào ListControl         
            For Each ctlC In currentForm.Controls
                ListControl.Add(ctlC)
                AddControl(ctlC, ListControl)
            Next

            'Tìm các điều khiển chưa nhập liệu            
            For Each ctlC In ListControl
                If Strings.UCase(ctlC.Tag) = Strings.UCase(DieuKienKiemTra) Then
                    If (ctlC.Text.Trim = "" And ctlC.Visible = True) Then
                        TenErrorProvider.SetError(ctlC, "(*) Bắt buộc phải nhập liệu")
                        intTemp = ctlC.TabIndex
                        blnResult = True
                    Else
                        TenErrorProvider.SetError(ctlC, "")
                        blnResult = False
                    End If
                End If
            Next
            'Tìm phần tử trong nhóm có TabIndex nhỏ nhất
            intMinIndex = intTemp
            'For Each ctlC In currentForm.Controls
            For Each ctlC In ListControl
                If ctlC.Tag = DieuKienKiemTra Then
                    'Điều khiển có dạng TextBox
                    If ((TypeOf ctlC Is TextBox) Or (TypeOf ctlC Is ComboBox) Or (TypeOf ctlC Is ComboBoxEx) Or (TypeOf ctlC Is TextBoxX)) Then
                        If ((ctlC.Text.Trim = "") And (intMinIndex > ctlC.TabIndex)) Then
                            intMinIndex = ctlC.TabIndex
                        End If
                    End If
                End If
            Next

            ' Đặt côn trỏ vào điều khiển có TabIndex nhỏ nhất trong nhóm chưa nhập liệu            
            For Each ctlC In ListControl
                If (ctlC.TabIndex = intMinIndex) Then
                    ctlC.Focus()
                    Exit For
                End If
            Next


        Catch ex As Exception
            MessageBox.Show("Nội dung: " & ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return blnResult
    End Function
    ''' <summary>
    ''' Them cac dieu khien vao danh sach cac dieu khien
    ''' </summary>
    ''' <param name="control">Dieu khien</param>
    ''' <param name="List">Danh sach chua cac dieu khien</param>
    ''' <remarks></remarks>
    Private Shared Sub AddControl(ByVal control As Control, ByRef List As List(Of Control))
        For Each c As Control In control.Controls
            List.Add(c)
            AddControl(c, List)
        Next
    End Sub

    Public Shared Sub RemoveErrorProvider(ByVal strDieuKienKiemTra As String, ByVal ctlErr As System.Windows.Forms.ErrorProvider)
        Try
            Dim ctlC As Control
            Dim currentForm As Form         REM Dùng để xác định form hiện thời đang hoạt động
            currentForm = Form.ActiveForm   REM gán cho form hiện thời đang hoạt động
            Dim mskT As MaskedTextBox
            REM Tìm các điều khiển chưa nhập liệu
            For Each ctlC In currentForm.Controls
                If Strings.UCase(ctlC.Tag) = Strings.UCase(strDieuKienKiemTra) Then
                    If ((TypeOf ctlC Is TextBox) Or (TypeOf ctlC Is ComboBox)) Then
                        If (ctlC.Text.Trim = "") Then
                            ctlErr.SetError(ctlC, "")
                        End If
                    End If

                    ''Điều khiển là Mask Textbox
                    If (TypeOf ctlC Is MaskedTextBox) Then
                        mskT = ctlC
                        If (mskT.MaskFull = False) Then
                            ctlErr.SetError(ctlC, "")
                        End If
                    End If
                End If
            Next

        Catch ex As Exception
            MessageBox.Show("Nội dung: " & ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Phương thức lấy số điện thoại hoặc Fax nếu không nhập trả về ""
    Public Shared Function getPhoneNumber(ByVal ctlMaskTextBox As System.Windows.Forms.MaskedTextBox) As String
        Dim strS As String = ""
        If (ctlMaskTextBox.Text.Trim = "(    )    -") Then
            strS = ""
        Else
            strS = ctlMaskTextBox.Text
        End If
        Return strS
    End Function

    'Phương thức chuyển định dạng ngày tháng
    Public Shared Function CDateTime(ByVal ctlMaskTextbox As MaskedTextBox) As String
        Dim strKQ As String
        Dim DauNganCach As String = DateTimeFormatInfo.CurrentInfo.DateSeparator
        Dim P() As String = ctlMaskTextbox.Text.Split("/")
        If ctlMaskTextbox.MaskFull = True Then
            strKQ = P(1) & DauNganCach & P(0) & DauNganCach & P(2)
        Else
            strKQ = Nothing
        End If
        Return strKQ
    End Function

    'Phương thức này dùng để kiểm tra địa chỉ Email
    Public Shared Function isAddEmail(ByVal strAdd As String) As Boolean
        Return strAdd Like "*@[A-Z,a-z,0-9]*.*"
    End Function

    'Phương thức Chọn ảnh, phương thức trả về đường dẫn file ảnh
    Public Shared Function ChonAnh(ByVal ctlPictureBox As System.Windows.Forms.PictureBox) As String
        Dim strDuongDan As String = ""
        Dim dlgOpen As New OpenFileDialog
        dlgOpen.Filter = "Bimap(*.BMP)|*.BMP|JPG(*.JPG, *.JPEG)|*.JPG|PNG(*.PNG)|*.PNG|Gif(*.Gif)|*.Gif|Tất cả(*.*)|*.*"
        dlgOpen.FilterIndex = 1
        dlgOpen.Title = "Chọn ảnh"
        dlgOpen.Multiselect = False
        If dlgOpen.ShowDialog = DialogResult.OK Then
            Try
                ctlPictureBox.Image = Image.FromFile(dlgOpen.FileName)
                strDuongDan = dlgOpen.FileName
            Catch ex As Exception
                frmMsgOK.HienThi("File được chọn không hợp lệ", "Thông báo", False)
            End Try
        End If
        Return strDuongDan
    End Function

    'Phương thức chỉ cho nhập số được sử lý trong sự kiện KeyPress
    Public Shared Sub PhaiNhapSo(ByVal e As KeyPressEventArgs)
        If InStr("0123456789" & Chr(8), e.KeyChar) < 1 Then
            e.Handled = True
        End If
    End Sub
    'Phương thức kiểm tra 1 form đã được mở
    Public Shared Function isLoadedForm(ByVal frmF As Form) As Boolean
        If frmF Is Nothing Or frmF.IsDisposed = True Then
            Return False
        Else
            Return True
        End If
    End Function
    'Phương thức so sánh ngày 
    Public Shared Sub NgayThoaMan(ByVal NgayDau As MaskedTextBox, ByVal NgaySau As MaskedTextBox, ByVal GiaTriSoSanh As Long, ByVal LoiNhac As String)
        Dim _NgayDau As New Date
        Dim _NgaySau As New Date
        _NgayDau = IIf(IsDate(NgayDau.Text.Trim), NgayDau.Text.Trim, IIf(IsDate(NgaySau.Text), NgaySau.Text, #10/10/2010#))
        _NgaySau = IIf(IsDate(NgaySau.Text.Trim), NgaySau.Text.Trim, #10/10/2010#)

        If (IsDate(NgayDau.Text) And IsDate(NgaySau.Text)) Then
            If DateDiff(DateInterval.Year, _NgayDau, _NgaySau, FirstDayOfWeek.Monday) < GiaTriSoSanh Then

                frmMsgOK.HienThi(LoiNhac, "Thông báo", False)
                NgaySau.Text = ""
            End If
        End If



    End Sub
    'Phương thức này dùng để đếm chuỗi giá trị nhập liệu trong DatagridView, dùng để làm điều kiện kiểm tra nhập liệu trong trường hợp không cho nhập 2 giá trị trùng nhau trên datagridview
    Public Shared Function DemChuoiCon(ByVal DataGridView As DataGridView, ByVal intCot As Integer, ByVal Giatri As String) As Integer
        Dim d As Integer = 0
        For i As Integer = 0 To DataGridView.RowCount - 2
            If Giatri <> "" And DataGridView.Rows(i).Cells(intCot).Value = Giatri Then
                d += 1
            End If
        Next
        Return d
    End Function



    'Phương thức này thường dùng để lấy nhóm mã trong datagridview phục vụ cho câu lệnh truy vấn có toán tử in
    Public Shared Function LayMa(ByVal DataGridView As DataGridView, ByVal intCot As Integer) As String
        Dim strKQ As String = ""
        For i As Integer = 0 To DataGridView.RowCount - 1
            strKQ &= "N'" & DataGridView.Rows(i).Cells(intCot).Value & "',"
        Next
        If Len(strKQ) > 0 Then
            strKQ = Strings.Left(strKQ, Len(strKQ) - 1)
        Else
            strKQ = "''"
        End If
        Return strKQ
    End Function


End Class



