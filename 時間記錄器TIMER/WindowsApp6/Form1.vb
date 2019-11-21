Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Label1.Text = Now.ToString("HH:mm:ss") & Now.Millisecond
    End Sub
End Class
