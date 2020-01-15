Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        TextBox4.Text = DateTime.Now
        TextBox1.Text = DateTime.Now.Year()
        TextBox2.Text = DateTime.Now.Month()
        TextBox3.Text = DateTime.Now.Day()
        TextBox5.Text = DateTime.Now.Hour
        TextBox6.Text = DateTime.Now.Minute
        TextBox7.Text = DateTime.Now.Second
        TextBox8.Text = Today
        TextBox9.Text = DateTime.Now.DayOfWeek
        TextBox10.Text = DateTime.Now.DayOfYear
        TextBox11.Text = Date.Now.AddHours(2)
        TextBox12.Text = Date.Now.AddMonths(5)


    End Sub
End Class
