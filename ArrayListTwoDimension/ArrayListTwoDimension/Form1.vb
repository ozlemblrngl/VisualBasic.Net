Public Class Form1
    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        Dim name(2, 2), str As String
        name(0, 0) = "ankara"
        name(0, 1) = "istanbul"
        name(0, 2) = "izmir"
        name(1, 0) = "adana"
        name(1, 1) = "çorum"
        name(1, 2) = "malatya"
        name(2, 0) = " samsun"
        name(2, 1) = "burdur"
        name(2, 2) = "erzurum"

        str = name(0, 0) + " ve " + name(0, 1)
        ListBox1.Items.Add(str)


        'first row, second columns, we have 9 elements

    End Sub
End Class
