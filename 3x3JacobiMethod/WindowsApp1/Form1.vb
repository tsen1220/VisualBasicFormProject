Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim a(2, 3), x(2) As Single
        Dim C, D, F, err, tol As Single
        Dim i As Integer
        Dim tempa(0, 3), tempb(0, 3) As Single

        a(0, 0) = TextBox1.Text
        a(0, 1) = TextBox2.Text

        a(0, 2) = TextBox3.Text
        a(1, 0) = TextBox4.Text
        a(1, 1) = TextBox5.Text
        a(1, 2) = TextBox6.Text
        a(2, 0) = TextBox7.Text
        a(2, 1) = TextBox8.Text
        a(2, 2) = TextBox9.Text
        a(0, 3) = TextBox10.Text
        a(1, 3) = TextBox11.Text
        a(2, 3) = TextBox12.Text

        C = TextBox13.Text
        D = TextBox14.Text
        F = TextBox15.Text

        x(0) = C + 1.0
        x(1) = D + 1.0
        x(2) = F + 1.0

        err = (((C - x(0)) ^ 2 + (D - x(1)) ^ 2 + (F - x(2)) ^ 2) / 3) ^ 0.5
        tol = 0.000001


        If Math.Abs(a(1, 0)) > Math.Abs(a(0, 0)) And Math.Abs(a(1, 0)) > Math.Abs(a(2, 0)) Then
            For j As Integer = 0 To 3
                tempa(0, 3) = a(0, j)
                a(0, j) = a(1, j)
                a(1, j) = tempa(0, 3)
            Next
        ElseIf Math.Abs(a(2, 0)) > Math.Abs(a(1, 0)) And Math.Abs(a(2, 0)) > Math.Abs(a(0, 0)) Then
            For j As Integer = 0 To 3
                tempa(0, 3) = a(0, j)
                a(0, j) = a(2, j)
                a(2, j) = tempa(0, 3)
            Next
        End If
        If Math.Abs(a(2, 1)) > Math.Abs(a(1, 1)) Then
            For k As Integer = 0 To 3
                tempb(0, 3) = a(1, k)
                a(1, k) = a(2, k)
                a(2, k) = tempb(0, 3)
            Next
        End If

        Do
            C = x(0)
            D = x(1)
            F = x(2)
            x(0) = (a(0, 3) - a(0, 1) * D - a(0, 2) * F) / a(0, 0)
            x(1) = (a(1, 3) - a(1, 0) * C - a(1, 2) * F) / a(1, 1)
            x(2) = (a(2, 3) - a(2, 0) * C - a(2, 1) * D) / a(2, 2)
            err = (((C - x(0)) ^ 2 + (D - x(1)) ^ 2 + (F - x(2)) ^ 2) / 3) ^ 0.5
            i = i + 1
        Loop While err > tol

        TextBox16.Text = x(0)
        TextBox17.Text = x(1)
        TextBox18.Text = x(2)
        TextBox19.Text = i
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
