Public Class Equation

#Region "User Subs"
    ''
    '' solve general equation
    '' x = -b/a
    Function SolveGeneral(ByVal a As Decimal, ByVal b As Decimal) As String
        Dim res As Object
        If a = 0 Then
            res = "Invalid equation."
        Else
            res = -b / a
        End If
        Return res
    End Function
    ''
    '' solve quadratic equation
    '' x1 = (-b + (b^2 - 4ac)^0.5)/(2a)    x2 = (-b - (b^2 - 4ac)^0.5)/(2a)
    Function SolveQuad(ByVal A As Decimal, ByVal B As Decimal, ByVal C As Decimal) As String()
        Dim res() As String = {"", ""}
        If A = 0 Then
            res(0) = SolveGeneral(B, C)
            res(1) = "Equation became Linear."
        Else
            Dim p, q, r As Decimal
            p = B ^ 2 - 4 * A * C
            q = (2 * A)
            r = -B / q
            If p >= 0 Then
                Dim s As Decimal = Math.Sqrt(p) / q
                res(0) = r + s       'this section will return
                res(1) = r - s         'value as fraction later.
            Else
                Dim s As Decimal = Math.Sqrt(-p) / q
                res(0) = Complex(r, s)       'this section will return
                res(1) = Complex(r, -s)   'value as fraction later.
            End If
        End If
        Return res
    End Function
    ''
    '' solve cubic equation
    '' a1=b/a, a2=c/a, a3=d/a, p=(3*a2 - a1^2)/9, q = (9*a1*a2 - 27*a3 - 2*(a1^3))/54
    '' s = sqrt(q + sqrt(p^3 + q^2)), t = sqrt(q - sqrt(p^3 + q^2))
    '' x1 = s + t - (1/3)*a1, x2 = -(1/2)*(s+t) - (1/3)*a1 + (1/2)*sqrt(3)*(s-t) & i, x2 = -(1/2)*(s+t) - (1/3)*a1 + (1/2)*sqrt(3)*(s-t) & i
    Function SolveCube(ByVal A As Decimal, ByVal B As Decimal, ByVal C As Decimal, ByVal D As Decimal) As String()
        Dim res() As String = {"", "", ""}
        If A = 0 Then
            Dim p() As String = SolveQuad(B, C, D)
            res(0) = p(0)
            res(1) = p(1)
            res(2) = "Equation became Quadratic."
        Else
            'general calculation
            Dim P As Decimal = 2 * B * B * B - 9 * A * B * C + 27 * D * A * A
            Dim Q As Decimal = P * P - 4 * ((B * B - 3 * A * C) ^ 3)
            Dim X, Xr, Xi, C1, C2, C1a, C2a As Decimal

            If Q < 0 Then                                               'if equation is quadratic
                res(0) = "No root."
                res(1) = "No root."
                res(2) = "No root."
            Else                                                        'if equation is cubic
                C1a = (P + Math.Sqrt(Q)) / 2
                C2a = (P - Math.Sqrt(Q)) / 2

                'direct cube root of "-" numbers appears error, so calling MathE.Cbrt()
                C1 = Cbrt(C1a)(0)
                C2 = Cbrt(C2a)(0)

                'if it appears that C1 and C2 have no real value
                If CStr(C1) = "Infinity" Or CStr(C2) = "Infinity" Then      'final result calculation
                    res(0) = "Infinity."
                    res(1) = "Infinity."
                    res(2) = "Infinity."
                ElseIf CStr(C1) = "NaN" Or CStr(C2) = "NaN" Then
                    res(0) = "Unknown."
                    res(1) = "Unknown."
                    res(2) = "Unknown."
                Else
                    X = -(B / (3 * A)) - (C1 / (3 * A)) - (C2 / (3 * A))
                    Xr = (C1 + C2 - (2 * B)) / (6 * A)
                    Xi = (Math.Sqrt(3) * (C1 - C2)) / (6 * A)

                    res(0) = X
                    res(1) = Complex(Xr, Xi)
                    res(2) = Complex(Xr, -Xi)
                End If
            End If
        End If
        Return res
    End Function
    ''
    '' Others Subs
    '' make complex Number
    Function Complex(ByVal real As Decimal, ByVal imag As Decimal) As String
        Dim res As String = "", op As String = ""
        If imag > 0 Then : op = "+" : res = imag & "i"  'first place imag number
        ElseIf imag < 0 Then : op = "-" : res = -imag & "i" : End If
        If res = "1i" Then res = "i" 'replace 1i to i
        If real = 0 Then 'if real is 0 then send just imag part
            If op = "-" Then res = op & res
            Return res
        End If
        Return real & " " & op & " " & res
    End Function
    ''
    '' Cube Root's Function (Cbrt)
    Function Cbrt(ByVal num As Decimal)
        Dim p = "", q = "", res() = {0, "", ""}
        If num >= 0 Then
            res(0) = num ^ (1 / 3)
        ElseIf num < 0 Then
            res(0) = -((-num) ^ (1 / 3))
        End If
        'x^2 - xy + y^2
        p = -res(0) / 2
        q = (res(0) * Math.Sqrt(3)) / 2
        res(1) = Complex(p, q)
        res(2) = Complex(p, -q)
        Return res
    End Function
#End Region

#Region "Event Subs"
    ''
    '' Got or lost textbox focus
    '' Got Focus
    Private Sub ABCD_GotFocus(ByVal sender As TextBox, ByVal e As System.EventArgs) Handles QuadA.GotFocus, QuadB.GotFocus, QuadC.GotFocus, CubeA.GotFocus, CubeB.GotFocus, CubeC.GotFocus, CubeD.GotFocus
        If IsNumeric(sender.Text) Then
            If CDec(sender.Text) = 0 Then sender.Text = ""
        End If
        If sender.Name.Contains("Quad") Then
            Me.ParentForm.AcceptButton = QuadSolve
        ElseIf sender.Name.Contains("Cube") Then
            Me.ParentForm.AcceptButton = CubeSolve
        End If
    End Sub
    '  Lost Focus
    Private Sub ABCD_LostFocus(ByVal sender As TextBox, ByVal e As System.EventArgs) Handles QuadA.LostFocus, QuadB.LostFocus, QuadC.LostFocus, CubeA.LostFocus, CubeB.LostFocus, CubeC.LostFocus, CubeD.LostFocus
        If Not IsNumeric(sender.Text) Then
            If sender.Text.Trim = "" Then : sender.Text = 0
            Else : sender.Focus() : End If
        Else : sender.Text = CDec(sender.Text)
        End If
        Me.ParentForm.AcceptButton = Nothing
    End Sub
    ''
    '' Solve Quadratic
    '' a.X^2 + b.X + c = 0
    Private Sub QuadSolve_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuadSolve.Click
        Try
            Dim A As Decimal = CDec(QuadA.Text)
            Dim B As Decimal = CDec(QuadB.Text)
            Dim C As Decimal = CDec(QuadC.Text)
            Dim res() = SolveQuad(A, B, C)
            QuadRes1.Text = res(0)
            QuadRes2.Text = res(1)
            QuadGiven.Text = "Equation: " & A & ".X² + " & B & ".X + " & C & " = 0"
        Catch ex As Exception
            QuadRes1.Text = ex.Message
            QuadA.Focus()
        End Try
    End Sub
    ''
    '' Solve Cubic
    '' X^3 + a.X^2 + b.X + c = 0
    Private Sub CubeSolve_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CubeSolve.Click
        Try
            Dim A As Decimal = CDec(CubeA.Text)
            Dim B As Decimal = CDec(CubeB.Text)
            Dim C As Decimal = CDec(CubeC.Text)
            Dim D As Decimal = CDec(CubeD.Text)
            Dim res() = SolveCube(A, B, C, D)
            CubeRes1.Text = res(0)
            CubeRes2.Text = res(1)
            CubeRes3.Text = res(2)
            CubeGiven.Text = "Equation: " & A & ".X³ + " & B & ".X² + " & C & ".X + " & D & " = 0"
        Catch ex As Exception
            MsgBox(ex.Message)
            CubeRes1.Text = ex.Message
            CubeA.Focus()
        End Try
    End Sub
#End Region

End Class
