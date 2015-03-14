Public Class NumberTheory

#Region "Factorial"

#Region "Extra Subs"
    ''
    '' Factorial of Number
    ''
    Function Factorial(ByVal value As Long)
        If value = 0 Or value = 1 Then
            Return 1
        Else
            Dim saved() As String = getSaved(value \ 100)
            Dim len As Long = CLng(saved(2)) - 1
            Dim str As Long = CLng(saved(0))
            Dim res As String = saved(1)
            For i = str To value
                res = multiply(res, i)
                BackgroundWorker1.ReportProgress(i, New String() {str, value, res})
                If BackgroundWorker1.CancellationPending Then Return "Cancelled by user."
                If (i \ 100) > len Then
                    My.Computer.FileSystem.WriteAllText("Data\factorial.save", ";" & res, True)
                End If
            Next
            Return res
        End If
    End Function
    '' check for save number and get it
    Function getSaved(ByVal index As Long) As String()
        With My.Computer.FileSystem
            Dim file = "Data\factorial.save"
            If Not .FileExists(file) Then
                .CreateDirectory("Data\")
                .WriteAllText(file, "1", True)
            End If
            Dim txt() As String = Split(.ReadAllText(file), ";")
            Dim res As String = ""
            Dim i As Long = 0
            If index > txt.LongLength - 1 Then
                res = txt(txt.LongLength - 1)
                i = (txt.LongLength - 1) * 100 + 1
            Else
                res = txt(index)
                i = index * 100 + 1
            End If
            If i = 0 Then i = 1
            Return New String() {i, res, txt.LongLength}
        End With
    End Function
    ''
    '' Mathmatical function for large numbers
    '' Additon of two large numbers 
    Function add(ByVal num1 As String, ByVal num2 As String) As String
        num2 = addZero(num2, num1.Length - num2.Length)
        num1 = addZero(num1, num2.Length - num1.Length)
        'add numbers
        Try     'if num2 = 0
            If CInt(num2) = 0 Then
                Return num1
            Else
                Throw New Exception()
            End If
        Catch   'if num2 > 0
            Dim res As String = ""
            Dim tmp As Integer = 0
            For i = num1.Length - 1 To 0 Step -1
                Dim a, b, r As Integer
                a = num1(i).ToString()
                b = num2(i).ToString()
                r = a + b + tmp
                If r > 9 Then
                    tmp = 1
                    r -= 10
                Else
                    tmp = 0
                End If
                res = r & res
            Next
            If tmp > 0 Then res = tmp & res
            Return res
        End Try
    End Function
    '' multiplication of two large number
    Function multiply(ByVal num1 As String, ByVal num2 As String) As String
        'sort
        num2 = addZero(num2, num1.Length - num2.Length)
        num1 = addZero(num1, num2.Length - num1.Length)
        Try     'if num2 = 0 or 1
            If CInt(num2) = 0 Then : Return 0
            ElseIf CInt(num2) = 1 Then : Return num1
            Else : Throw New Exception() : End If
        Catch   'if num2 > 1
            Dim res As String = "0"
            Dim t0 As String = ""
            For i = num2.Length - 1 To 0 Step -1
                Dim a As Integer = num2(i).ToString()
                Dim r As String = cross(num1, a)
                res = add(res, r & t0)
                t0 &= "0"
            Next
            Return res
        End Try
    End Function
    '' cross between one large and another decimal number
    Function cross(ByVal num As String, ByVal p As Byte)
        If p = 0 Then
            Return 0
        ElseIf p = 1 Then
            Return num
        Else
            Dim res As String = ""
            Dim tmp As Byte = 0
            For i = num.Length - 1 To 0 Step -1
                Dim a, r As Byte
                a = num(i).ToString()
                r = a * p + tmp
                If r > 9 Then
                    tmp = r \ 10
                    r = r Mod 10
                Else
                    tmp = 0
                End If
                res = r & res
            Next
            If tmp > 0 Then res = tmp & res
            Return res
        End If
    End Function
    '' add zero after od before a number
    Function addZero(ByVal num As String, ByVal count As Integer, Optional ByVal place As String = "before")
        If count < 1 Then Return num
        Dim p As String = StrDup(count, "0")
        If place.ToLower = "before" Then
            num = p & num
        Else
            num &= p
        End If
        Return num
    End Function
    '' remove zero before a number
    Function IsNumber(ByVal num As String) As Boolean
        For i = 0 To num.Length - 1
            If Not IsNumeric(num(i).ToString()) Then Return False
        Next
        Return True
    End Function

#End Region

#Region "Event Subs"
    '' input focus
    Private Sub Value1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Value.GotFocus
        Me.ParentForm.AcceptButton = FactorialButton
        If Value.Text = "Insert an integer and Click OK" Then Value.Text = ""
        Value.ForeColor = Color.Black
    End Sub
    '' input lost focus
    Private Sub Value1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Value.LostFocus
        Me.ParentForm.AcceptButton = Nothing
        If Not IsNumeric(Value.Text) Then
            Value.Text = "Insert an integer and Click OK"
        End If
        Value.ForeColor = Color.Gray
    End Sub
    ''
    '' Factorial Button Clicked
    ''
    Private Sub FactorialButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FactorialButton.Click
        If FactorialButton.Text = "OK" Then
            Try
                BackgroundWorker1.RunWorkerAsync(CLng(Value.Text.Trim))
            Catch ex As Exception
                MsgBox("Error occured" & vbCrLf & ex.Message)
                BackgroundWorker1.CancelAsync()
            End Try
            FactorialButton.Text = "Cancel"
            prev = 0
            FactorialResult.Text = ""
            ProgPanel.Visible = True
        Else
            BackgroundWorker1.CancelAsync()
            FactorialButton.Text = "OK"
            FactorialResult.Text = ""
            ProgPanel.Visible = False
        End If
    End Sub
    ''
    '' back worker for factorial
    ''
    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim p As String = Factorial(e.Argument)
        e.Result = p
    End Sub
    '' back prog change
    Dim prev As Integer = 0
    Private Sub BackgroundWorker1_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        Dim str As Long = e.UserState(0)
        Dim val As Long = e.UserState(1)
        Dim res As String = e.UserState(2)
        Dim per As Integer = ((e.ProgressPercentage - str) / (val - str)) * 100
        ProgressBar1.Value = per
        Label1.Text = per & "%"
        If CLng(per) > prev Then
            prev = CLng(per)
            FactorialResult.Text = "Calculating result... " & Label1.Text & vbCrLf & _
                        "Current result (at " & e.ProgressPercentage & "!) : " & res
        End If
    End Sub
    '' back result
    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        FactorialResult.Text = e.Result
        FactorialButton.Text = "OK"
        Dim p = FactorialResult.Text
        If IsNumber(p) Then
            FactorialResult.Text = p & " = " & p.Length & " numbers."
        End If
        ProgPanel.Visible = False
    End Sub
#End Region

#End Region

#Region "Factors and Divisors"

#Region "Extra subs"
    ''
    '' Get Factors
    ''
    Function Factor(ByVal value As Long) As String
        If checkPrime(value) Then Return value
        Dim p, q As Long : p = value : q = 2
        Do Until p Mod q = 0 Or q > p
            q += 1
        Loop
        If q > p Then q = p
        Dim res As String = ""
        If p \ q > 1 Then
            res = q & Chr(215) & Factor(p \ q)
        Else
            res = q & Chr(215) & Factor(p \ q)
        End If
        Return res
    End Function
    ''
    '' Get Divisors
    ''
    Function Divisors(ByVal value As Long) As String
        Dim res As String = ""
        Dim len As String = StrDup(value.ToString().Length + 3, " ")
        For i As Long = 1 To value ^ 0.5
            If value Mod i = 0 Then
                res &= i & " " & Chr(215) & " " & CDec(value / i) & vbCrLf & len
            End If
        Next
        Return res
    End Function
#End Region

#Region "Event Subs"
    Private Sub TextBox1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles FactDivVAL.GotFocus
        Me.ParentForm.AcceptButton = FactDivButton
        If FactDivVAL.Text = "Insert an integer and Click OK" Then
            FactDivVAL.Text = ""
        End If
        FactDivVAL.ForeColor = Color.Black
    End Sub

    Private Sub TextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles FactDivVAL.LostFocus
        Me.ParentForm.AcceptButton = Nothing
        If Not IsNumeric(FactDivVAL.Text) Then
            FactDivVAL.Text = "Insert an integer and Click OK"
        End If
        FactDivVAL.ForeColor = Color.Gray
    End Sub

    Private Sub FactDivButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FactDivButton.Click
        Try
            Dim value As Long = CLng(FactDivVAL.Text)
            FactorRes.Text = value & " = " & Factor(value)
            DivisorRes.Text = value & " = " & Divisors(value)
        Catch ex As Exception
            MsgBox("Insert a numeric value.(max-29 numbers)" & vbCrLf & ex.Message)
        End Try
    End Sub
#End Region

#End Region

#Region "Prime Number"

#Region "Extra Subs"
    ''
    '' check a number if prime
    ''
    Function checkPrime(ByVal number As Decimal) As Boolean
        If number = 2 Then Return True
        If number Mod 2 = 0 Or number = 1 Then Return False
        For i = 3 To number ^ 0.5 Step 2
            If number Mod i = 0 Then Return False
        Next
        Return True
    End Function
    ''
    '' get a list of primes
    ''
    Function retrieveList(ByVal up As Integer, ByVal low As Integer) As String
        Dim res As String = ""
        For i = up To low
            If checkPrime(i) Then res &= i & ", "
        Next
        res = res.Remove(res.Length - 2, 1)
        Return res
    End Function

#End Region

#Region "Event Subs"
    Private Sub PNumValue_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles PNumValue.GotFocus
        Me.ParentForm.AcceptButton = CheckPrimeButton
        If PNumValue.Text = "Insert a number to check" Then
            PNumValue.Text = ""
        End If
        PNumValue.ForeColor = Color.Black
    End Sub

    Private Sub PNumValue_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles PNumValue.LostFocus
        Me.ParentForm.AcceptButton = Nothing
        If Not IsNumeric(PNumValue.Text) Then
            PNumValue.Text = "Insert a number to check"
        End If
        PNumValue.ForeColor = Color.Gray
    End Sub

    Private Sub TextBox5_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles PrimeListLimit.GotFocus
        Me.ParentForm.AcceptButton = ShowListButton
        If PrimeListLimit.Text = "Insert limits. Like 1 to 100, 300-500,1023 to 1055" Then
            PrimeListLimit.Text = ""
        End If
        PrimeListLimit.ForeColor = Color.Black
    End Sub

    Private Sub TextBox5_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles PrimeListLimit.LostFocus
        Me.ParentForm.AcceptButton = Nothing
        If PrimeListLimit.Text.Trim = "" Then
            PrimeListLimit.Text = "Insert limits. Like 1 to 100, 300-500,1023 to 1055"
        End If
        PrimeListLimit.ForeColor = Color.Gray
    End Sub
    ''
    '' Show List Button
    ''
    Private Sub ShowListButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowListButton.Click
        Try
            Dim txt As String = PrimeListLimit.Text.Trim
            Dim txts() As String = txt.Split(New String() {",", ";"}, 1)
            Dim res As String = ""
            For Each itm In txts
                Dim lim As String() = itm.Split(New String() {"to", "-"}, StringSplitOptions.RemoveEmptyEntries)
                Dim up As Integer = CInt(lim(0))
                Dim low As Integer = CInt(lim(1))
                If up > low Then : up = up + low : low = up - low : up = up - low : End If
                Dim getList As String = retrieveList(up, low)
                Dim count As Integer = Split(getList, ",").Length
                If count = 0 Then Continue For
                Dim header As String = "From " & up & " to " & low & " (" & count & ") : "
                res &= header & getList & "." & vbCrLf & vbCrLf
            Next
            PrimeListRes.Text = res
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    ''
    '' Check button clicked
    ''
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckPrimeButton.Click
        Try
            Dim num As Decimal = CDec(PNumValue.Text.Trim)
            Dim p As Boolean = checkPrime(num)
            If p Then
                CheckPrimeRes.Text = num & " is a prime"
            Else
                CheckPrimeRes.Text = num & " is not a prime"
            End If
        Catch ex As Exception
            ErrorProvider1.SetError(PNumValue, ex.Message)
        End Try
    End Sub
#End Region

#End Region

    Private Sub PrimeListRes_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrimeListRes.TextChanged

    End Sub
End Class
