Public Class Form1





    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        x1 = TextBox1.Text
        x2 = TextBox2.Text
        x3 = TextBox3.Text

        sumscore = x1 + x2 + x3
        students = TextBox4.Text


        Call average(sumscore, students)



        TextBox5.Text = average(sumscore, students)


    End Sub

    Private Sub Button2_MouseEnter(sender As Object, e As EventArgs) Handles Button2.MouseEnter
        MsgBox("hello")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.TextBox6.Focus()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.TextBox7.Focus()
    End Sub
End Class
