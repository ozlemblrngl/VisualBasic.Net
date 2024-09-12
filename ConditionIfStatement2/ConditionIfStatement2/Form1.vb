Public Class Form1
    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        Dim x, y As Integer

        x = Val(TextNmb1.Text)
        y = Val(TextNmb2.Text)


        If (x > y) Then
            MessageBox.Show($"{x} greater than {y}")
        ElseIf (y > x) Then
            MessageBox.Show($"{y} greater than {x}")
        Else
            MessageBox.Show("Wrong Number")
        End If


    End Sub
End Class
