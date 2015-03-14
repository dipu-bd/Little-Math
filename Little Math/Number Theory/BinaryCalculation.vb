Public Class BinaryCalculation

#Region "UserSubs"

    ''
    ''Decimal to Others
    ''
    Const symbol As String = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ "
    Function deciToOther(ByVal number As Decimal, ByVal base As Integer) As String
        Dim ex As Decimal
        Dim result As String = ""
        Do
            Dim num As Decimal = number / base
            num = Decimal.Floor(num)
            ex = number Mod base
            number = num
            result = symbol(ex) & result
        Loop Until number = 0
        Return result
    End Function

    Function deciToOther_Point(ByVal number As Decimal, Optional ByVal base As Integer = 2)
        Dim ex, p As Decimal
        Dim result As String = "."
        Do
            Dim num As Decimal = number * base
            ex = num
            number = num - ex
            result &= symbol(ex)
            p += 1
        Loop Until ((number = 0) Or p >= 20)
        Return result
    End Function

    Function OtherToDeci(ByVal number As String, ByVal fromBase As Integer) As Decimal
        Dim result As Decimal
        For i = 0 To number.Length - 1
            Dim nw As String = number(i).ToString
            Dim p As Decimal = Power(fromBase, number.Length - 1 - i)
            result += symbol.IndexOf(nw) * p
        Next
        Return result
    End Function

    Function Power(ByVal number As Decimal, ByVal pow As Integer)
        Dim res As Decimal = 1
        For i = 1 To pow
            res *= number
        Next
        Return res
    End Function

    ''
    '' Binary to Others
    ''
    Function binToOther(ByVal number As String, ByVal base As Integer) As String
        Dim result As String = ""
        Dim deci As Decimal = OtherToDeci(number, 2)
        If base = 10 Then Return deci
        result = deciToOther(deci, base)
        Return result
    End Function

    ''
    '' Octal to Others
    ''
    Function OctToOther(ByVal number As String, ByVal base As Integer) As String
        Dim result As String = ""
        Dim deci As Decimal = OtherToDeci(number.ToString(), 8)
        If base = 10 Then Return deci
        result = deciToOther(deci, base)
        Return result
    End Function
    ''
    '' Hexa to Others
    ''
    Function HexToOther(ByVal number As String, ByVal base As Integer) As String
        Dim result As String = ""
        Dim deci As Decimal = OtherToDeci(number, 16)
        If base = 10 Then Return deci
        result = deciToOther(deci, base)
        Return result
    End Function
    ''
    '' Others to Others
    ''
    Function OtherToOther(ByVal number As String, ByVal fromBase As Integer, ByVal base As Integer) As String
        Dim result As String = ""
        Dim deci As Decimal = OtherToDeci(number, fromBase)
        If base = fromBase Then Return deci
        result = deciToOther(deci, base)
        Return result
    End Function
    ''
    '' Number check
    ''
    Function CheckNumber(ByVal number As String, ByVal base As Integer) As Boolean
        For i = 0 To number.Length - 1
            Dim nw As String = number(i).ToString
            If symbol.IndexOf(nw) >= base Then Return False
        Next
        Return True
    End Function

#End Region

#Region "Decimal To Others"

    Private Sub TextBox5_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles DecimalValue2.GotFocus
        Me.ParentForm.AcceptButton = ResultButton
    End Sub

    Private Sub TextBox5_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles DecimalValue2.LostFocus
        Me.ParentForm.AcceptButton = Nothing
    End Sub

    Dim exp As Exception = New Exception("This number is incorrect")
    Private Sub DecimalValue1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecimalValue1.TextChanged
        Try
            Dim number As Decimal = CDec(DecimalValue1.Text)
            'number before decimalPoint
            OctalValue.Text = deciToOther(number, 8)
            BinaryValue1.Text = deciToOther(number, 2)
            HexalValue1.Text = deciToOther(number, 16)
            'number after decimalPoint......
            If DecimalValue1.Text.Contains(".") Then
                Dim indx As Integer = DecimalValue1.Text.IndexOf(".")
                Dim value As String = DecimalValue1.Text.Remove(0, indx)
                OctalValue.Text &= deciToOther_Point(CDec(value), 8)
                BinaryValue1.Text &= deciToOther_Point(CDec(value), 2)
                HexalValue1.Text &= deciToOther_Point(CDec(value), 16)
            End If

            'other works
            ErrorProvider1.Clear()
            DecimalValue2.Text = CDec(DecimalValue1.Text)
            ResultValue.Text = ""
        Catch ex As Exception
            ErrorProvider1.SetError(DecimalValue1, "Error: " & ex.Message)
            OctalValue.Text = ""
            BinaryValue1.Text = ""
            HexalValue1.Text = ""
        End Try
    End Sub

    Private Sub ResultButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResultButton.Click
        Try
            Dim number As Decimal = CDec(DecimalValue2.Text)
            Dim base As Integer = BaseValue.Value
            ResultValue.Text = deciToOther(number, base)
            ErrorProvider1.Clear()
        Catch ex As Exception
            ErrorProvider1.SetError(DecimalValue2, "Inser numeric value. " _
                                    & vbCrLf & "Error: " & ex.Message)
        End Try
    End Sub
#End Region

#Region "Binary to Others"

    Private Sub BinValue2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BinaryValue2.TextChanged
        Try
            Dim number As String = BinaryValue2.Text
            If Not CheckNumber(number, 2) Then Throw exp
            DecimalValue3.Text = binToOther(number, 10)
            OctalValue2.Text = binToOther(number, 8)
            HexaValue2.Text = binToOther(number, 16)
            'other works
            ErrorProvider1.Clear()
            BinaryValue3.Text = BinaryValue2.Text
            ResultValue2.Text = ""
        Catch ex As Exception
            ErrorProvider1.SetError(BinaryValue2, "Error: " & ex.Message)
            DecimalValue3.Text = ""
            OctalValue2.Text = ""
            HexaValue2.Text = ""
        End Try
    End Sub

    Private Sub ResultButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResultButton2.Click
        Try
            Dim number As String = BinaryValue3.Text
            If Not CheckNumber(number, 2) Then Throw exp
            Dim base As Integer = BaseValue2.Value
            ResultValue2.Text = binToOther(number, base)
            ErrorProvider1.Clear()
        Catch ex As Exception
            ErrorProvider1.SetError(BinaryValue3, "Inser numeric value. " _
                                    & vbCrLf & "Error: " & ex.Message)
        End Try
    End Sub

    Private Sub bin3focus(ByVal sender As Object, ByVal e As System.EventArgs) Handles BinaryValue3.GotFocus
        Me.ParentForm.AcceptButton = ResultButton
    End Sub

    Private Sub bin3LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles BinaryValue3.LostFocus
        Me.ParentForm.AcceptButton = Nothing
    End Sub
#End Region

#Region "Octal to Others"

    Private Sub OctalValue3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OctalValue3.TextChanged
        Try
            Dim number As String = OctalValue3.Text.Trim
            If Not CheckNumber(number, 8) Then Throw exp
            DecimalValue4.Text = OctToOther(number, 10)
            BinaryValue4.Text = OctToOther(number, 2)
            HexaValue3.Text = OctToOther(number, 16)
            'other works
            ErrorProvider1.Clear()
            OctalValue4.Text = number
            ResultValue3.Text = ""
        Catch ex As Exception
            ErrorProvider1.SetError(OctalValue3, "Error: " & ex.Message)
            DecimalValue4.Text = ""
            BinaryValue4.Text = ""
            HexaValue3.Text = ""
        End Try
    End Sub

    Private Sub ResultButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResultButton3.Click
        Try
            Dim number As String = OctalValue4.Text
            If Not CheckNumber(number, 8) Then Throw exp
            Dim base As Integer = BaseValue3.Value
            ResultValue3.Text = OctToOther(number, base)
            ErrorProvider1.Clear()
        Catch ex As Exception
            ErrorProvider1.SetError(OctalValue4, "Inser numeric value. " _
                                    & vbCrLf & "Error: " & ex.Message)
        End Try
    End Sub

    Private Sub OctalValue4_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles OctalValue4.GotFocus
        Me.ParentForm.AcceptButton = ResultButton
    End Sub

    Private Sub OctalValue4_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles OctalValue4.LostFocus
        Me.ParentForm.AcceptButton = Nothing
    End Sub
#End Region

#Region "Hexadecimal to Others"
    Private Sub HexaValue4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HexaValue4.TextChanged
        Try
            Dim number As String = HexaValue4.Text
            If Not CheckNumber(number, 16) Then Throw exp
            DecimalValue5.Text = HexToOther(number, 10)
            BinaryValue5.Text = HexToOther(number, 2)
            OctalValue5.Text = HexToOther(number, 8)
            'other works
            ErrorProvider1.Clear()
            HexaValue5.Text = HexaValue4.Text
            ResultValue3.Text = ""
        Catch ex As Exception
            ErrorProvider1.SetError(HexaValue4, "Error: " & ex.Message)
            DecimalValue5.Text = ""
            BinaryValue5.Text = ""
            OctalValue5.Text = ""
        End Try
    End Sub

    Private Sub ResultButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResultButton4.Click
        Try
            Dim number As String = HexaValue5.Text
            If Not CheckNumber(number, 16) Then Throw exp
            Dim base As Integer = BaseValue4.Value
            ResultValue4.Text = HexToOther(number, base)
            ErrorProvider1.Clear()
        Catch ex As Exception
            ErrorProvider1.SetError(HexaValue5, "Inser numeric value. " _
                                    & vbCrLf & "Error: " & ex.Message)
        End Try
    End Sub

    Private Sub HexaValue5_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles HexaValue5.GotFocus
        Me.ParentForm.AcceptButton = ResultButton4
    End Sub

    Private Sub HexaValue5_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles HexaValue5.LostFocus
        Me.ParentForm.AcceptButton = Nothing
    End Sub
#End Region

#Region "Others to Others"

    Private Sub OtherValue_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles OtherValue.GotFocus
        Me.ParentForm.AcceptButton = ResultButton5
    End Sub

    Private Sub OtherValue_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles OtherValue.LostFocus
        Me.ParentForm.AcceptButton = Nothing
    End Sub

    Private Sub ResultButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResultButton5.Click
        Try
            Dim number As String = OtherValue.Text
            Dim fromBase As Integer = BaseValue5.Value
            If Not CheckNumber(number, fromBase) Then Throw exp
            DecimalValue6.Text = OtherToOther(number, fromBase, 10)
            BinaryValue6.Text = OtherToOther(number, fromBase, 2)
            HexaValue6.Text = OtherToOther(number, fromBase, 16)
            OctalValue6.Text = OtherToOther(number, fromBase, 8)
            ErrorProvider1.Clear()
        Catch ex As Exception
            ErrorProvider1.SetError(OtherValue, "Error: " & ex.Message)
            DecimalValue6.Text = ""
            BinaryValue6.Text = ""
            OctalValue6.Text = ""
            HexaValue6.Text = ""
        End Try
    End Sub
#End Region

End Class