Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    '設定表單畫布的底色
    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim g As Graphics = e.Graphics

        '清除所有東西 並以指定顏色塗滿他
        g.Clear(Color.Green) '''畫布顏色

        '設定筆的顏色與寬度
        Dim pen As Pen = New Pen(Color.Red, 1)
        Dim pen2 As Pen = New Pen(Color.Black, 2)
        Dim pen3 As Pen = New Pen(Color.Brown, 5)

        '在底色以設定的pen 作圖 設定為起始畫至終點(想用的筆,起始x,起始y,終點x,終點y)
        g.DrawLine(pen2, 0, 0, 1000, 1000) '''(x1,y1,x2,y2)


        '設定筆刷顏色 ps.筆刷為想塗顏色的範圍

        Dim brush1 As SolidBrush = New SolidBrush(Color.Blue)
        Dim brush2 As SolidBrush = New SolidBrush(Color.White)

        '此以橢圓為例 設定為(想用的筆刷,中心x座標,y座標,橢圓寬度,橢圓高度)
        g.FillEllipse(brush1, 100, 50, 100, 200) '''(x,y,width,height)


        'Exercise1 繪出文字與線條
        Dim a As String = "你好"
        '(想寫出的文字,文字字型,想用的筆刷,位置x,位置y)
        g.DrawString(a, Font, brush1, 20, 30)

        'Exercise2 繪出四邊形 (想使用的畫筆,起始x,起始y,長,寬)
        g.DrawRectangle(pen2, 3, 4, 200, 200)

        'Exercise3 繪出多邊形 
        '先設定哪幾個點要連接(按照給定順序)
        Dim apoint() As Point = {New Point(50, 100), New Point(30, 60), New Point(200, 250)}

        '使用drawpolygon將其連接起來 (想用的畫筆,連接的點的參數)
        g.DrawPolygon(pen2, apoint)

        'Exercise4 劃出橢圓,弧線,扇形,貝茲曲線      VB的角度以順時針計算
        g.DrawEllipse(pen, 5, 10, 30, 40) '''(想用的筆,中心x,中心y,橢圓寬度,橢圓高度)
        g.DrawArc(pen2, 100, 200, 50, 60, 0, 180) '''(想用的筆,中心x,中心y,橢圓寬度,橢圓高度,起始角度,終點角度) 注意:其以橢圓為基礎畫弧線
        g.DrawPie(pen, 50, 100, 100, 200, 0, 270) '''(想用的筆,中心x,中心y,橢圓寬度,橢圓高度,起始角度,終點角度) 注意:其以橢圓為基礎畫扇形
        g.DrawBezier(pen3, 120, 140, 160, 180, 200, 220, 240, 260) '''(想用的筆,x1,y1,x2,y2,x3,y3,x4,y4)

        'Exercise5 做出塗滿 圖形面積
        g.FillEllipse(brush2, 200, 200, 300, 100) '''(想用的筆刷,中心x,中心y,橢圓寬度,橢圓高度)
        g.FillPie(brush1, 50, 200, 150, 200, 0, 200) '''(想用的筆刷,中心x,中心y,橢圓寬度,橢圓高度,起始角度,終點角度) 注意:其以橢圓為基礎畫扇形

    End Sub


End Class
