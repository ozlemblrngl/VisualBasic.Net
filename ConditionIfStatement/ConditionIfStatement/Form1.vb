Public Class Form1
    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click

        'If (Condition) Then
        '...
        'ElseIf (Condition) Then
        '....
        'Else 
        '....
        'End If


        'Val() --> bir dizeyi (String) sayısal bir değere dönüştürmek için kullanılır. 
        'Dim sayi As Double
        'sayi = Val("123.45")    ' Sonuç: 123.45
        'sayi = Val("123abc")     ' Sonuç: 123 (abc kısmını görmezden gelir)
        'sayi = Val("abc123")     ' Sonuç: 0 (ilk karakter sayısal olmadığı için 0 döner)

        Dim x, y As Integer
        x = Val(TxtNmb1.Text)
        y = Val(TxtNmb2.Text)

        If (x > y) Then
            MessageBox.Show($"{x} greater than {y}")
        Else
            MessageBox.Show($"{y} greater than {x}")
        End If

    End Sub


End Class
