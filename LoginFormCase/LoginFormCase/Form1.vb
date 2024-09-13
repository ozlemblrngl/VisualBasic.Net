Public Class Form1
    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        Dim userName, password As String

        userName = "ozlem"
        password = "1234"

        If TxtUserName.Text.Trim() = "ozlem" And TxtPassword.Text.Trim() = "1234" Then
            Form2.Show()
        Else
            MessageBox.Show("You enter invalid User Name or Password")
        End If

    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        TxtUserName.Text = ""
        TxtPassword.Text = ""


    End Sub
End Class
