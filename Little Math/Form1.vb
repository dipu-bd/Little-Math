Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TreeView1.Sort()
        TreeView1.SelectedNode = TreeView1.Nodes(0)
    End Sub

    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        MainPanel.Controls.Clear()
        Try
            If TreeView1.SelectedNode.Nodes.Count > 0 Then  'if child contains
                TreeView1.SelectedNode.Expand()
            End If
            'exit
            Dim selected As String = TreeView1.SelectedNode.Text
            HeaderLabel.Text = selected
            selected = selected.ToLower
            Dim ctl As Control = Nothing
            Select Case selected        'determine ctl
                Case "base calculation" : ctl = New BinaryCalculation
                Case "equation" : ctl = New Equation
                Case "fraction and gcd-lcm" : ctl = New GcdLcmFraction
                Case "number theory" : ctl = New NumberTheory
            End Select
            ctl.Dock = DockStyle.Fill   'add ctl
            MainPanel.Controls.Add(ctl)
        Catch ex As Exception
            'MsgBox("Error occured when trying to add control." & vbCrLf & ex.Message)
            TreeView1.SelectedNode = TreeView1.SelectedNode.Nodes(0)
        End Try
    End Sub
End Class
