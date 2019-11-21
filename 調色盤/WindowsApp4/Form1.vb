Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '設定調色盤初始顏色
        PictureBox1.BackColor = Color.FromArgb(0, 0, 0)

        '設定調色盤 紅、黃、藍 的調色bar (最大值為255,最小為1)  
        '                              以(Maximum, LargeChange)設定
        Me.hsbR.Maximum = 255
        Me.hsbR.LargeChange = 1
        Me.hsbG.Maximum = 255
        Me.hsbG.LargeChange = 1
        Me.hsbB.Maximum = 255
        Me.hsbB.LargeChange = 1
    End Sub

    Private Sub hsbR_Scroll(sender As Object, e As ScrollEventArgs) Handles hsbR.Scroll

        '紅色調色bar   FromArgb為Color中的八位元色彩值( Color.FromArgb )  函數Color.FromArgb(RED as integer,Green as integer,Blue as integer) 最大值為255 最小值為0
        PictureBox1.BackColor = Color.FromArgb(hsbR.Value, hsbG.Value, hsbB.Value)

        Me.Label1.Text = "R=" & Str(hsbR.Value)
        Me.Label2.Text = "G=" & Str(hsbG.Value)
        Me.Label3.Text = "B=" & Str(hsbB.Value)


    End Sub

    Private Sub hsbG_Scroll(sender As Object, e As ScrollEventArgs) Handles hsbG.Scroll
        '綠色調色Bar
        PictureBox1.BackColor = Color.FromArgb(hsbR.Value, hsbG.Value, hsbB.Value)

        Me.Label1.Text = "R=" & Str(hsbR.Value)
        Me.Label2.Text = "G=" & Str(hsbG.Value)
        Me.Label3.Text = "B=" & Str(hsbB.Value)
    End Sub

    Private Sub hsbB_Scroll(sender As Object, e As ScrollEventArgs) Handles hsbB.Scroll
        '藍色調色bar
        PictureBox1.BackColor = Color.FromArgb(hsbR.Value, hsbG.Value, hsbB.Value)

        Me.Label1.Text = "R=" & Str(hsbR.Value)
        Me.Label2.Text = "G=" & Str(hsbG.Value)
        Me.Label3.Text = "B=" & Str(hsbB.Value)
    End Sub
End Class
