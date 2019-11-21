Public Class Form1



    Private Sub TextBox1_validating(sender As Object, e As EventArgs) Handles TextBox1.Validating
        If TextBox1.Text = "" Then
            ErrorProvider1.SetError(TextBox1, "不可以是空值")
        Else
            ErrorProvider1.SetError(TextBox1, "")
        End If


    End Sub

    Private Sub TextBox2_validating(sender As Object, e As EventArgs) Handles TextBox2.Validating

        If Not IsNumeric(TextBox2.Text) Then
            ErrorProvider1.SetError(TextBox2, "必須是數字")
        Else
            ErrorProvider1.SetError(TextBox2, "")

        End If

    End Sub
End Class
