Public Class Form1
    Public doc As String
    Structure student
        Public id As Integer
        Public name As String
        Public mathscore As Integer
        Public englishscore As Integer
    End Structure

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim std1 As student
        std1.id = 1
        std1.name = "陳會安"
        std1.mathscore = 78
        std1.englishscore = 65






    End Sub

    Private Sub 開啟ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 開啟ToolStripMenuItem.Click
        '過濾附檔名         "text(*.txt)<---------------------- 為標示的檔案形式(會顯示在檔案類型)   | *.txt <--------為過濾的副檔名 
        Me.OpenFileDialog1.Filter = "text(*.txt)|*.txt"
        '在儲存對話方塊按下ok後 執行if下的指令
        If Me.OpenFileDialog1.ShowDialog = DialogResult.OK Then

            Dim filename As String = Me.OpenFileDialog1.FileName
            Me.RichTextBox1.Text = My.Computer.FileSystem.
                ReadAllText(filename)

        End If
    End Sub

    Private Sub 儲存ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 儲存ToolStripMenuItem.Click
        Me.SaveFileDialog1.Filter = "text(*.txt)|*.txt"
        '在儲存對話方塊按下ok後 執行if下的指令
        If Me.SaveFileDialog1.ShowDialog = DialogResult.OK Then
            Dim filename As String = Me.SaveFileDialog1.FileName

            My.Computer.FileSystem.WriteAllText(filename, Me.RichTextBox1.Text, False)
        End If

    End Sub

    Private Sub 字型ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 字型ToolStripMenuItem.Click
        '在字型對話方塊按下ok後 執行if下的指令
        If Me.FontDialog1.ShowDialog - DialogResult.OK Then
            RichTextBox1.SelectionFont = FontDialog1.Font

        End If
    End Sub

    Private Sub 顏色ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 顏色ToolStripMenuItem.Click
        '在顏色對話方塊按下ok後 執行if下的指令
        If Me.ColorDialog1.ShowDialog = DialogResult.OK Then
            RichTextBox1.SelectionColor = ColorDialog1.Color
        End If

    End Sub

    Private Sub 關閉ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 關閉ToolStripMenuItem.Click
        End
    End Sub


    Private Sub 列印格式ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 列印格式ToolStripMenuItem.Click
        '設定列印格式的文件

        'printdocument 為 文件列印形式設定 
        'pagesetupdialog 為 頁面的設定
        '此處我理解為 頁面的文件 將其設定為  哪一種列印形式
        Me.PageSetupDialog1.Document = Me.PrintDocument1

        '頁面文件設定對話方塊
        Me.PageSetupDialog1.ShowDialog()

    End Sub


    Private Sub 列印ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles 列印ToolStripMenuItem1.Click

        '設定doc取得文字
        doc = Me.RichTextBox1.Text

        '列印格式
        Me.PrintDialog1.Document = Me.PrintDocument1

        '點下列印進入列印對話方塊 (並按下對話方塊OK確認後) 執行if的指令
        If Me.PrintDialog1.ShowDialog = DialogResult.OK Then
            PrintDocument1.Print()

        End If


    End Sub

    Private Sub 列印預覽ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 列印預覽ToolStripMenuItem.Click
        '取得文字
        doc = Me.RichTextBox1.Text
        '設定列印格式
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        '呼叫對話方塊
        Me.PrintPreviewDialog1.ShowDialog()
    End Sub


End Class
