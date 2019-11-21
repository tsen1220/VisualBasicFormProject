Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Integer
        Dim b As Integer
        Dim c As Integer
        Dim result As String


        a = TextBox1.Text
        b = TextBox2.Text

        c = b / ((a / 100) ^ 2)
        TextBox3.Text = c
    End Sub
End Class