Public Class GcdLcmFraction

#Region "Other functions"
    ''
    '' Get all values
    ''
    Function getValues() As String
        Dim p As String = ""
        For Each item In ListOfValues.Items
            p &= ", " & item
        Next
        p = p.Remove(0, 2)
        Return p
    End Function
    ''
    '' Determine GCD
    ''
    Function GCD(ByVal num() As String) As String
        Dim A As Int64 = CType(num(0), Int64)
        For i = 1 To num.Length - 1
            Dim B As Int64 = CType(num(i), Int64)
            Dim t As Int64 = B
            Do
                B = A Mod t
                A = t
                t = B
            Loop While B > 0
        Next
        Return A
    End Function
    ''
    '' Determine LCM
    ''
    Function LCM(ByVal num()) As String
        Dim A As Int64 = CType(num(0), Int64)
        For i = 1 To num.Length - 1
            Dim B As Int64 = CType(num(i), Int64)
            A = Math.Abs(A * B) / GCD(New String() {A, B})
        Next
        Return A
    End Function
#End Region

#Region "Event Subs"
    ''
    '' Add Numbers
    '' value got focus
    Private Sub Value1_GotFocus(ByVal sender As TextBox, ByVal e As System.EventArgs) Handles Value1.GotFocus
        Me.ParentForm.AcceptButton = AddButton
        Dim txt As String = sender.Text
        If txt = "Insert number separated by comma(,). Like- 232, 42, 6, 54" Then
            sender.Text = ""
            sender.Font = New Font(sender.Font, FontStyle.Regular)
        End If
        sender.ForeColor = Color.Black
    End Sub
    '' value lost focus
    Private Sub Value1_LostFocus(ByVal sender As TextBox, ByVal e As System.EventArgs) Handles Value1.LostFocus
        Me.ParentForm.AcceptButton = CalcButton
        Dim txt As String = sender.Text.Trim
        If txt = "" Then
            sender.Text = "Insert number separated by comma(,). Like- 232, 42, 6, 54"
            sender.Font = New Font(sender.Font, FontStyle.Italic)
        End If
        sender.ForeColor = Color.Gray
    End Sub
    '' add value to list
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddButton.Click
        Dim p As String = ""
        If CheckBox1.Checked Then ListOfValues.Items.Clear()
        For Each value In Split(Value1.Text.Trim, ",")
            If IsNumeric(value) Then : ListOfValues.Items.Add(value)
            Else : p = value & "; " : End If
        Next
        If Not p = "" Then MsgBox(p & " wasn't added.")
        CalcButton.PerformClick()
    End Sub
    ''
    '' ContextMenus
    '' remove
    Private Sub RemoveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveToolStripMenuItem.Click
        Try : ListOfValues.Items.Remove(ListOfValues.SelectedItem)
        Catch ex As Exception : MsgBox(ex.Message) : End Try
    End Sub
    '' clear all
    Private Sub ClearAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearAllToolStripMenuItem.Click
        If MsgBox("Are youo sure to clear all numbers?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            ListOfValues.Items.Clear()
        End If
    End Sub
    '' copy all
    Private Sub CopyAllNumbersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyAllNumbersToolStripMenuItem.Click
        My.Computer.Clipboard.SetText(getValues)
    End Sub
    ''
    '' Calculate GCD and LCM
    ''
    Private Sub CalcButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalcButton.Click
        Dim num() = Split(getValues, ",")
        GCDResult.Text = GCD(num)
        LCMResult.Text = LCM(num)
    End Sub
#End Region

End Class
