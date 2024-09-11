Public Class Form1
    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click

        'Do While (condition)
        '    Code Is here
        '    Counter Is here
        'Loop
        ListBox1.Items.Clear()

        Dim i, num(3) As Integer

        num(0) = 5
        num(1) = 8
        num(2) = 4
        num(3) = 3
        i = 0

        Do While (i < 4)
            ListBox1.Items.Add(num(i))
            i += 1
        Loop

    End Sub

    Private Sub BtnTry_Click(sender As Object, e As EventArgs) Handles BtnTry.Click
        ListBox1.Items.Clear()

        Dim i As Integer

        i = 0
        Do While (i < 3)
            ListBox1.Items.Add("Hello World")
            i += 1
        Loop
    End Sub
End Class
