Imports System.Data
Imports System.Data.SqlClient
Imports DevComponents.DotNetBar.Controls
Public Class Connect
    Private Conn As SqlConnection
    Public Sub New()
        Dim Server As String = "VTEL-PC"
        Dim Database As String = "QuanLyKinhDoanh"
        Dim UID As String = "sa"
        Dim PWD As String = "sa"
        Dim strConn As String = "Server=" & Server & ";Database=" & Database & ";UID=" & UID & ";PWD=" & PWD
        'Kết nối CSDL
        Conn = New SqlConnection(strConn)
        Try
            Conn.Open()
        Catch ex As Exception
            MsgBox("Không kết nối được với cơ sở dữ liệu !", MsgBoxStyle.Exclamation, "Thông báo")
        End Try
    End Sub

    'Phương thức này dùng để lấy dữ liệu từ CSDL đổ vào DataTable
    Public Function GetDataTable(ByVal strSQL As String) As DataTable
        Dim da As New SqlDataAdapter(strSQL, Conn)
        Dim DT As New DataTable
        da.Fill(DT)
        Return DT
    End Function

    'Phương thức này dùng để lấy dữ liệu từ CSDL đổ vào DataTable
    Public Function GetName(ByVal strSQL As String) As String
        Dim da As New SqlDataAdapter(strSQL, Conn)
        Dim DT As New DataTable
        da.Fill(DT)
        Return DT.Rows(0).Item(0)
    End Function
    'Phương thức này dùng để lấy dữ liệu từ CSDL đổ vào DataSet
    Public Function GetDataSet(ByVal strSQL As String) As DataSet
        Dim da As New SqlDataAdapter(strSQL, Conn)
        Dim DS As New DataSet
        da.Fill(DS)
        Return DS
    End Function

    'Phương thức này dùng để nạp dữ liệu cho điều khiển DataGridView
    Public Sub Load_DataGridView(ByVal DataGridView As DataGridView, ByVal DisplayHeaderText As String, ByVal strSQL As String)
        Dim H() As String = DisplayHeaderText.Split(",")
        Dim DT As New DataTable
        Dim i As Integer
        DT = GetDataTable(strSQL)
        DataGridView.DataSource = DT
        DataGridView.AutoResizeColumns()
        DataGridView.AllowUserToAddRows = False
        DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically
        DataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'Thay đổi tiêu đề cho các cột
        For i = 0 To H.Length - 1
            DataGridView.Columns(i).HeaderText = H(i)
        Next
        ' Ẩn cột liên kết khóa ngoại, nếu tổng số cột trong datatable lớn hơn tổng số cột được tạo headertext mới
        If DT.Columns.Count > H.Length Then
            For i = H.Length To DT.Columns.Count - 1
                DataGridView.Columns(i).Visible = False
            Next
        End If
    End Sub

    'Phương thức thực hiện câu lệnh Insert, Update, Delete
    Public Sub RunSQL(ByVal strSQL As String)
        Dim cmd As New SqlCommand
        cmd.Connection = Me.Conn
        cmd.CommandText = strSQL
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        cmd.Dispose()
        cmd = Nothing
    End Sub
    'Phương thức lấy giá trị trong bảng dựa vào mã
    Public Function GetFieldValue(ByVal strSQL As String) As String
        Dim strKQ As String = ""
        Dim cmd As New SqlCommand(strSQL, Conn)
        Dim reader As SqlDataReader = cmd.ExecuteReader
        While reader.Read()
            strKQ = reader.GetValue(0)
        End While
        reader.Close()
        Return strKQ
    End Function
    Public Function getSum(ByVal strSQL As String, ByVal intColumn As Integer) As Long
        Dim cmd As New SqlCommand(strSQL, Conn)
        Dim reader As SqlDataReader
        Dim lngKQ As Long
        reader = cmd.ExecuteReader
        While reader.Read
            lngKQ += reader.GetValue(intColumn)
        End While
        reader.Close()
        Return lngKQ
    End Function

    'Phương thức kiểm tra giá trị trong CSDL
    Public Function DaTonTai(ByVal strSQL As String) As Boolean
        Dim DT As New DataTable
        DT = GetDataTable(strSQL)
        If DT.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    'Phương thức tạo nguồn dữ liệu cho combobox, buộc dữ liệu vào cột 0, hiển thị dữ liệu cột thứ 1
    Public Sub SetDataCombobox(ByVal ctlCombobox As ComboBox, ByVal strSQL As String)
        Dim DT As New DataTable
        Dim strOldValue As String
        strOldValue = ctlCombobox.SelectedValue
        DT = GetDataTable(strSQL)
        ctlCombobox.DataSource = DT
        If DT.Columns.Count > 1 Then
            ctlCombobox.ValueMember = DT.Columns(0).ColumnName
            ctlCombobox.DisplayMember = DT.Columns(1).ColumnName
            'gán lại giá trị cũ cho combobox sau khi đã làm mới datasource
            If strOldValue <> "" Then
                ctlCombobox.SelectedValue = strOldValue
            End If
        Else
            ctlCombobox.DisplayMember = DT.Columns(0).ColumnName
            ctlCombobox.ValueMember = DT.Columns(0).ColumnName
        End If
    End Sub
    'Phương thức tạo nguồn dữ liệu cho cột combobox của datagridview
    Public Sub SetDataComboboxInDataGridView(ByVal ctlCombobox As DataGridViewComboBoxColumn, ByVal strSQL As String)
        Dim DT As New DataTable
        DT = GetDataTable(strSQL)
        ctlCombobox.DataSource = DT
        If DT.Columns.Count > 1 Then
            ctlCombobox.ValueMember = DT.Columns(0).ColumnName
            ctlCombobox.DisplayMember = DT.Columns(1).ColumnName
        Else
            ctlCombobox.DisplayMember = DT.Columns(0).ColumnName
            ctlCombobox.ValueMember = DT.Columns(0).ColumnName
        End If
    End Sub
   

End Class






