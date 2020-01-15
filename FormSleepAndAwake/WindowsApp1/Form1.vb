Public Class Form1
    Private Sub Form1_stylechange(sender As Object, e As EventArgs) Handles Me.StyleChanged
        '最小化
        If Me.WindowState = FormWindowState.Minimized Then
            Me.Hide()
        End If



    End Sub


    ' awake
    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Show()
        Me.WindowState = FormWindowState.Maximized
    End Sub



    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        '最小化
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        '離開
        Application.Exit()
    End Sub
End Class
