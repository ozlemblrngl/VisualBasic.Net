Public Class Form1
    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        Dim totalNumber As String = "Sayıların Toplamı : "
        Dim x(2), total As Integer
        x(0) = 5
        x(1) = 9
        x(2) = 8
        total = x(0) + x(1) + x(2)

        Dim str(2) As String
        str(0) = "hello"
        str(1) = "world"
        str(2) = "!"
        ListBox1.Items.Add(x(0))
        ListBox1.Items.Add(x(1))
        ListBox1.Items.Add(x(2))
        ListBox1.Items.Add(totalNumber)
        ListBox1.Items.Add(total)
        ListBox1.Items.Add(str(0))
        ListBox1.Items.Add(str(1))
        ListBox1.Items.Add(str(2))

        'comment line

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
End Class
