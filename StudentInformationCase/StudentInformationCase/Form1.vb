Public Class Form1
    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        ListBox1.Items.Clear()
        Dim x(3) As String
        Dim i As Integer
        x(0) = TxtId.Text
        x(1) = TxtName.Text
        x(2) = TxtYear.Text
        x(3) = TxtSemester.Text

        For i = 0 To 3
            ListBox1.Items.Add(x(i))
        Next

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Close()
    End Sub


End Class
