Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer
        Dim g(1, 1) As Integer
        Dim f(1) As Integer
        Dim x1, y1 As Single

        g(0, 0) = TextBox1.Text
        g(1, 0) = TextBox2.Text
        g(0, 1) = TextBox3.Text
        g(1, 1) = TextBox4.Text
        f(0) = TextBox5.Text
        f(1) = TextBox6.Text

        For i = 1 To 100
            If g(0, 0) = 0 Then
                y1 = f(0) / g(0, 1)
                x1 = "none"
            ElseIf g(1, 1) = 0 Then

                x1 = f(1) / g(1, 0)
                y1 = "none"
            Else

                x1 = (f(0) - g(0, 1) * y1) / g(0, 0)
                y1 = (f(1)) - g(1, 0 * x1) / g(1, 1)

            End If

            TextBox7.Text = x1
            TextBox8.Text = y1
        Next

    End Sub
End Class