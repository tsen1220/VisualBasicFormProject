Public Class Form1

    Public doc As String

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        '過濾附檔名         "text(*.txt)<---------------------- 為標示的檔案形式(會顯示在檔案類型)   | *.txt <--------為過濾的副檔名 
        Me.OpenFileDialog1.Filter = "text(*.txt)|*.txt"
        '在儲存對話方塊按下ok後 執行if下的指令
        If Me.OpenFileDialog1.ShowDialog = DialogResult.OK Then

            Dim filename As String = Me.OpenFileDialog1.FileName
            Me.RichTextBox1.Text = My.Computer.FileSystem.
                ReadAllText(filename)

        End If

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.SaveFileDialog1.Filter = "text(*.txt)|*.txt"
        '在儲存對話方塊按下ok後 執行if下的指令
        If Me.SaveFileDialog1.ShowDialog = DialogResult.OK Then
            Dim filename As String = Me.SaveFileDialog1.FileName

            My.Computer.FileSystem.WriteAllText(filename, Me.RichTextBox1.Text, False)
        End If

    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        '設定列印格式的文件

        'printdocument 為 文件列印形式設定 
        'pagesetupdialog 為 頁面的設定
        '此處我理解為 頁面的文件 將其設定為  哪一種列印形式
        Me.PageSetupDialog1.Document = Me.PrintDocument1

        '頁面文件設定對話方塊
        Me.PageSetupDialog1.ShowDialog()
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        '取得文字
        doc = Me.RichTextBox1.Text
        '設定列印格式
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        '呼叫對話方塊
        Me.PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click

        '設定doc取得文字
        doc = Me.RichTextBox1.Text

        '列印格式
        Me.PrintDialog1.Document = Me.PrintDocument1

        '點下列印進入列印對話方塊 (並按下對話方塊OK確認後) 執行if的指令
        If Me.PrintDialog1.ShowDialog = DialogResult.OK Then
            PrintDocument1.Print()

        End If
    End Sub
End Class
