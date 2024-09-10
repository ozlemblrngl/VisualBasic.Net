Public Class Form1
    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        ListBox1.Items.Clear()

        Dim name(2, 2), str As String
        name(0, 0) = "Ankara"
        name(0, 1) = "istanbul"
        name(0, 2) = "izmir"
        name(1, 0) = "adana"
        name(1, 1) = "malatya"
        name(1, 2) = "samsun"
        name(2, 0) = "çorum"
        name(2, 1) = "antalya"
        name(2, 2) = "bilecik"

        For Each str In name
            ListBox1.Items.Add(str)
        Next
    End Sub

    Private Sub BtnTry_Click(sender As Object, e As EventArgs) Handles BtnTry.Click

        ListBox1.Items.Clear()
        Dim i, y(2) As Integer
        y = {2, 9, 7}

        For Each i In y
            ListBox1.Items.Add(i)
        Next
    End Sub
End Class
