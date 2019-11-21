Public Class Form1
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.OpenFiledialog1.filter = "文字檔案(*.txt)|*.txt"
        If Me.openfiledialog1.showdialog = DialogResult.OK Then
            Dim filename As String = Me.openfiledialog1.filename
            Me.richtextbox1.text = My.Computer.FileSystem.
                ReadAllText(filename)
        End If
    End Sub



    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.SaveFileDialog1.Filter = "文字檔案(*.txt)|*.txt"
        If Me.SaveFileDialog1.ShowDialog = DialogResult.OK Then
            Dim filename As String = Me.SaveFileDialog1.FileName

            My.Computer.FileSystem.WriteAllText(filename, Me.RichTextBox1.Text, False)



        End If
    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click
        If Me.ColorDialog1.ShowDialog = DialogResult.OK Then
            RichTextBox1.SelectionColor = ColorDialog1.Color
        End If


    End Sub

    Private Sub ToolStripLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripLabel2.Click
        If Me.FontDialog1.ShowDialog - DialogResult.OK Then
            RichTextBox1.SelectionFont = FontDialog1.Font

        End If
    End Sub
End Class
