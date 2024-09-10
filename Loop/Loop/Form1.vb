Public Class Form1
    Private Sub BtnTry_Click(sender As Object, e As EventArgs) Handles BtnTry.Click

        ListBox1.Items.Clear()

        Dim i, w1 As Integer

        For i = 0 To 5
            w1 = i + 2
            ListBox1.Items.Add(w1)

        Next

        ' including 5
    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click

        ListBox1.Items.Clear()

        Dim i As Integer
        Dim w1 As String

        For i = 1 To 7
            w1 = " Hello World "
            ListBox1.Items.Add(w1)


        Next

    End Sub
End Class
