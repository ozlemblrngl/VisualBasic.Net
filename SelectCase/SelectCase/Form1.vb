Public Class Form1
    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click


        'Select Case Option
        '  Case Option_1
        '    Statement_1
        '  Case Option_2
        '    Statement_2
        '  Case Option_3
        '    Statement_3
        'End Select


        Dim days(6), str As String
        days = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"}

        str = TxtDay.Text

        Select Case str
            Case "Monday"
                MessageBox.Show("Your Favorite Day is " & days(0))
            Case "Tuesday"
                MessageBox.Show("Your Favorite Day is " & days(1))
            Case "Wednesday"
                MessageBox.Show("Your Favorite Day is " & days(2))
        End Select
    End Sub
End Class
