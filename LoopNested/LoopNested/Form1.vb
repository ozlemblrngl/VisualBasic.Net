Public Class Form1
    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        Dim name(2, 2) As String
        Dim i, j As Integer

        name(0, 0) = "Ankara"
        name(0, 1) = "İstanbul"
        name(0, 2) = "Malatya"
        name(1, 0) = "Samsun"
        name(1, 1) = "Adana"
        name(1, 2) = "Yozgat"
        name(2, 0) = "Mardin"
        name(2, 1) = "Konya"
        name(2, 2) = "Osmaniye"

        For i = 0 To 2
            For j = 0 To 2
                ListBox1.Items.Add(name(i, j))
            Next
        Next


    End Sub
End Class
