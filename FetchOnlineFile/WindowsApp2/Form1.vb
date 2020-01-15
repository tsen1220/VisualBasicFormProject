Public Class Form1

    Public Shared Function create(
        requestUristring As String
        ) As Net.WebRequest

    End Function

    '取得使用者名稱
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox(My.User.Name)
        MsgBox(My.User.IsInRole("adminstratiors"))
    End Sub




    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        '需輸入網址
        If Me.TextBox2.Text = "" Then
            Exit Sub

        End If

        '取得網址聯繫
        Dim webreq As Net.WebRequest = Net.WebRequest.Create(Me.TextBox2.Text)
        Dim webres As Net.WebResponse = webreq.GetResponse

        '取得網頁原始碼
        Dim st As IO.Stream = webres.GetResponseStream
        Dim reader As New IO.StreamReader(st, System.Text.Encoding.Default)

        Dim html As String = reader.ReadToEnd

        '將原始碼放在richtextbox
        Me.RichTextBox1.Text = html



    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        '判斷是否有輸入圖片檔案位置
        If Me.TextBox1.Text = "" Then
            MsgBox("請輸入圖片資料夾位置!", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation)
            Exit Sub

        End If

        '檢查圖片資料夾是否存在
        Dim dirflag As Boolean
        dirflag = My.Computer.FileSystem.DirectoryExists(Me.TextBox1.Text)

        '如果不存在,新增資料夾
        If dirflag = False Then
            My.Computer.FileSystem.CreateDirectory(Me.TextBox1.Text)


        End If

        '分析網頁原始碼
        '記得add reference -> Microsoft HTML Object Library
        Dim doc As mshtml.IHTMLDocument2
        doc = New mshtml.HTMLDocumentClass
        doc.write(Me.RichTextBox1.Text)

        '下載圖片
        Dim load As New Net.WebClient

        '從原始碼尋找副檔名為 gif或jpg
        For Each img As mshtml.HTMLImg In doc.images
            If img.href.EndsWith("gif") Or img.href.EndsWith("jpg") Then
                '下載圖片
                load.DownloadFile(img.href, Me.TextBox1.Text & "\" & My.Computer.FileSystem.GetName(img.href))
            End If
        Next

        '下載完畢
        If MsgBox("下載完畢,是否開啟圖片資料夾",
            MsgBoxStyle.OkCancel Or MsgBoxStyle.Information = MsgBoxResult.Ok) Then
            Process.Start(Me.TextBox1.Text)

        End If


    End Sub
End Class
