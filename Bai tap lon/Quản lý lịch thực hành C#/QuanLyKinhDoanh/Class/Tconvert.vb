Public Class Tconvert
    Public Shared Function ReadNumber(ByVal Number As Object, Optional ByVal blnDong As Boolean = True) As String
        Dim pNumber As String = ""
        Dim Rslt As String, Rslt1 As String, Rslt2 As String
        Dim Number1 As String, Number2 As String
        Dim K As Integer

        If IsArray(Number) Then
            ReadNumber = "Đối số của hàm không hợp lệ"
            Exit Function
        ElseIf Number = vbNullString Then
            ReadNumber = "Không có giá trị"
            Exit Function
        ElseIf Not IsNumeric(Number) Or VarType(Number) = vbBoolean Then
            ReadNumber = "Đối số không phải là một con số"
            Exit Function
        ElseIf Len(Format(Number, "0#")) > 15 Then
            ReadNumber = "Số quá lớn"
            Exit Function
        End If
        If Left(Number, 1) = "-" Then
            pNumber = Number
            Number = Mid(Number, 2)
        End If
        If InStr(1, Number, ",") <> 0 And InStr(1, Number, ".") <> 0 Then
            ReadNumber = "Đối số của hàm không hợp lệ"
            Exit Function
        End If
        If InStr(1, Number, ",") <> 0 Then K = InStr(1, Number, ",")
        If InStr(1, Number, ".") <> 0 Then K = InStr(1, Number, ".")
        If K <> 0 Then GoTo ThapPhan
        Rslt = vnNum2Text(nonPreZero(Number))
        If blnDong Then
            If Rslt = "" Then
                ReadNumber = "Không đồng."
            ElseIf Left(pNumber, 1) = "-" Then
                ReadNumber = "Âm " & Trim(Rslt) & " Đồng."
                pNumber = vbNull
            Else
                ReadNumber = Trim(UCase(Left(Rslt, 1)) & Mid(Rslt, 2)) & " Đồng."
            End If
        Else
            If Rslt = "" Then
                ReadNumber = UCase(Left("Không", 1)) & Mid("Không", 2) & "."
            ElseIf Left(pNumber, 1) = "-" Then
                ReadNumber = "Âm" & " " & Trim(Rslt) & "."
                pNumber = vbNull
            Else
                ReadNumber = Trim(UCase(Left(Rslt, 1)) & Mid(Rslt, 2)) & "."
            End If
        End If
        On Error GoTo 0
        Exit Function
ThapPhan:
        Number1 = Mid(Number, 1, K - 1)
        Number2 = Mid(Number, K + 1, 2)
        Rslt1 = vnNum2Text(nonPreZero(Number1))
        Rslt2 = vnNum2Text(numDec(Number2))
        If Rslt1 = "" Then Rslt1 = UCase(Left("không", 1)) & Mid("không", 2)
        If Rslt2 = "" Then Rslt2 = "Không"
        If blnDong = True Then
            If Left(pNumber, 1) = "-" Then
                ReadNumber = "Âm " & Trim(Rslt1) & " đồng " & Trim(Rslt2) & " xu"
                pNumber = vbNull
            Else
                Rslt = Trim(Rslt1) & " đồng " & Trim(Rslt2) & " xu"
                ReadNumber = Trim(UCase(Left(Rslt, 1)) & Mid(Rslt, 2))
            End If
        Else
            If Left(pNumber, 1) = "-" Then
                ReadNumber = "âm " & Trim(Rslt1) & " phẩy " & Trim(Rslt2) & "."
                pNumber = vbNull
            Else
                Rslt = Trim(Rslt1) & " phẩy " & Trim(Rslt2)
                ReadNumber = Trim(UCase(Left(Rslt, 1)) & Mid(Rslt, 2)) & "."
            End If
        End If

    End Function

    Private Shared Function vnNum2Text(ByVal num As String) As String

        Dim So() As String = {"không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín"}
        Dim Hang() As String = {"", "ngàn", "triệu", "tỷ"}
        Dim str As String
        Dim i As Integer, J As Integer, donvi As Integer, chuc As Integer, tram As Integer
        str = vbNullString
        i = Len(num)
        If i = 0 Then
            str = "không" & str
        Else
            J = 0
            Do While i > 0
                donvi = Int(Mid(num, i, 1))
                i = i - 1
                If i > 0 Then
                    chuc = Int(Mid(num, i, 1))
                Else
                    chuc = -1
                End If
                i = i - 1
                If i > 0 Then
                    tram = Int(Mid(num, i, 1))
                Else
                    tram = -1
                End If
                i = i - 1
                If donvi > 0 Or chuc > 0 Or tram > 0 Or J = 3 Then
                    str = Hang(J) & " " & str
                End If
                J = J + 1
                If J > 3 Then J = 1
                If donvi = 1 And chuc > 1 And tram >= 0 Then
                    str = So(tram) & " trăm " & So(chuc) & " mươi mốt " & str
                ElseIf donvi = 1 And chuc > 1 Then
                    str = So(chuc) & " mươi mốt " & str
                Else
                    If donvi = 5 And chuc > 0 Then
                        str = "lăm " & str
                    ElseIf donvi > 0 Then
                        str = So(donvi) & " " & str
                    End If
                    If chuc < 0 Then
                        Exit Do
                    Else
                        If chuc = 0 And donvi > 0 Then
                            str = "lẻ " & str
                        ElseIf chuc = 1 Then
                            str = "mười " & str
                        ElseIf chuc > 1 Then
                            str = So(chuc) & " mươi " & str
                        End If
                    End If
                    If tram < 0 Then
                        Exit Do
                    Else
                        If tram > 0 Or chuc > 0 Or donvi > 0 Then
                            str = So(tram) & " trăm " & str
                        End If
                    End If
                End If
            Loop
        End If
        Return str
    End Function

    Private Shared Function nonPreZero(ByVal num As String) As String
        If Len(num) > 1 And Left(num, 1) = 0 Then
            Dim Z As Integer, Y As Integer
            Y = 1
            Do While Z = 0
                Z = Mid(num, Y, 1)
                Y = Y + 1
            Loop
            num = Mid(num, Y - 1)
        End If
        nonPreZero = num
    End Function

    Private Shared Function numDec(ByVal num As String) As String
        If InStr(1, num, ",") <> 0 Then
            num = Mid(num, InStr(1, num, ",") + 1, 2)
        End If
        If Len(num) < 2 Then
            numDec = num & "0"
        Else
            numDec = num
        End If
    End Function
End Class
