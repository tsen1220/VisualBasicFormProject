Public Class Form1



    Dim g As Graphics
    Dim p As New Pen(Color.Blue)

    '將form重置的副程式
    Sub reset()
        g = Me.CreateGraphics
        Me.Refresh()
        g.ResetTransform()
    End Sub

    '將多邊形與文字放置的form上 的副程式
    Sub show_pic()
        Dim rec As New Rectangle(50, 20, 40, 60)
        g.DrawRectangle(p, rec)
        Dim brush As SolidBrush = New SolidBrush(Color.Red)
        Dim f As New Font("標楷體", 20, FontStyle.Bold)
        g.DrawString(“你好", f, brush, 120, 10)
    End Sub

    '文字圖形的平移縮放變化都是以上一個點為基準 去做變化與調整

    '文字及圖形平移
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call Reset()
        Dim i As Integer
        For i = 1 To 4
            Call show_pic()
            g.TranslateTransform(60, 40) '''(x位移距離,y位移距離)
        Next
    End Sub

    '文字及圖形縮放
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call reset()
        Dim i As Integer
        For i = 1 To 4
            Call show_pic()
            g.TranslateTransform(10, 10)
            g.ScaleTransform(1.5, 1.5)  '''(x軸縮放倍率,y軸縮放倍率)
        Next
    End Sub

    '文字及圖形的旋轉
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call reset()
        For i = 1 To 4
            Call show_pic()
            g.RotateTransform(15)
        Next
    End Sub



End Class
