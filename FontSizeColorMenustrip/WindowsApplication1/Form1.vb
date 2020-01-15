Public Class Form1
    Private Sub 紅色toolstripMenuItem_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 紅色ToolStripMenuItem.Click
        TextBox1.ForeColor = Color.Red
    End Sub

    Private Sub 藍色toolstripMenuItem_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 藍色ToolStripMenuItem.Click
        TextBox1.ForeColor = Color.Blue
    End Sub





    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        TextBox1.Font = New Font(TextBox1.Font.Name, 16)



    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        TextBox1.Font = New Font(TextBox1.Font.Name, 24)

    End Sub


End Class
