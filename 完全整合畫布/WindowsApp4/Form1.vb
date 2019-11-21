Public Class Form1
    Dim bmp As Bitmap = New Bitmap(280, 240)
    Dim pw As Integer = 1
    Dim pc As Color = Color.Black
    Dim p As Pen = New Pen(pc, pw)
    Dim x1, y1 As Integer


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Scr2.Maximum = 255

        Me.Scr3.Maximum = 255
        Me.Scr3.LargeChange = 1
        Me.Scr4.Maximum = 255
        Me.Scr4.LargeChange = 1
        Me.Scr5.Maximum = 255
        Me.Scr5.LargeChange = 1


    End Sub


    Private Sub Scr2_Scroll(sender As Object, e As ScrollEventArgs) Handles Scr2.Scroll
        '色調深淺度 八位元色彩值為(深淺,紅色,綠色,藍色) 最大值皆為255
        PictureBox2.BackColor = Color.FromArgb(Scr2.Value, Scr3.Value, Scr4.Value, Scr5.Value)
        pc = PictureBox2.BackColor
        p = New Pen(pc, pw)
    End Sub


    Private Sub Scr1_Scroll(sender As Object, e As ScrollEventArgs) Handles Scr1.Scroll
        pw = Scr1.Value
        p = New Pen(pc, pw)

    End Sub
    Private Sub scr3_Scroll(sender As Object, e As ScrollEventArgs) Handles Scr3.Scroll

        '紅色調色bar   FromArgb為Color中的八位元色彩值( Color.FromArgb )  函數Color.FromArgb(RED as integer,Green as integer,Blue as integer) 最大值為255 最小值為0
        PictureBox2.BackColor = Color.FromArgb(Scr2.Value, Scr3.Value, Scr4.Value, Scr5.Value)
        pc = PictureBox2.BackColor
        p = New Pen(pc, pw)


    End Sub

    Private Sub scr4_Scroll(sender As Object, e As ScrollEventArgs) Handles Scr4.Scroll
        '綠色調色Bar
        PictureBox2.BackColor = Color.FromArgb(Scr2.Value, Scr3.Value, Scr4.Value, Scr5.Value)
        pc = PictureBox2.BackColor
        p = New Pen(pc, pw)

    End Sub

    Private Sub scr5_Scroll(sender As Object, e As ScrollEventArgs) Handles Scr5.Scroll
        '藍色調色bar
        PictureBox2.BackColor = Color.FromArgb(Scr2.Value, Scr3.Value, Scr4.Value, Scr5.Value)
        pc = PictureBox2.BackColor
        p = New Pen(pc, pw)

    End Sub



    Private Sub PictureBox1_mousedown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        '定位 你滑鼠的座標
        x1 = e.X
        y1 = e.Y



    End Sub



    Private Sub PictureBox1_mousemove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove

        'image解析度設度
        Dim g As Graphics = Graphics.FromImage(bmp)

        '如果按下左鍵,則執行指令 1.drawline 2. 設定圖片解析度  3.x1與y1會不斷等於滑鼠在畫布上的座標位置 e.X :滑鼠當前x座標 e.Y :滑鼠當前y座標
        If e.Button = MouseButtons.Left Then
            g.DrawLine(p, x1, y1, e.X, e.Y)
            PictureBox1.Image = bmp
            x1 = e.X
            y1 = e.Y

        End If

        g.Dispose()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '重新將其設為原來的沒劃任何圖的 new bitmap 即可還原      Picturebox1.image = new bitmap(280,240)

        Dim g As Graphics = Graphics.FromImage(bmp)

        bmp = New Bitmap(280, 240)

        PictureBox1.Image = bmp


    End Sub


End Class
