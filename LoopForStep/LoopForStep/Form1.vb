Public Class Form1
    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        ListBox1.Items.Clear()

        Dim i As Integer
        For i = 0 To 20 Step 2
            ListBox1.Items.Add(i)
        Next
    End Sub

    Private Sub BtnTry_Click(sender As Object, e As EventArgs) Handles BtnTry.Click
        ListBox1.Items.Clear()

        Dim i As Integer
        For i = 20 To 0 Step -2
            ListBox1.Items.Add(i)
        Next
    End Sub

    Private Sub BtnTry2_Click(sender As Object, e As EventArgs) Handles BtnTry2.Click
        ListBox1.Items.Clear()

        Dim y(3) As Integer
        y = {5, 8, 4, 6}
        For i = 0 To 3
            ListBox1.Items.Add(y(i))
        Next

        ListBox1.Items.Add(" ")

        Dim str(3) As String
        str = {"A", "B", "C", "D"}
        For i = 0 To 3
            ListBox1.Items.Add(str(i))
        Next
    End Sub
End Class
