Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mychild1 As New child1
        Dim mychild2 As New child2


        '顯示第一個child
        mychild1.MdiParent = Me
        mychild1.Show()

        '顯示第二個child
        mychild2.MdiParent = Me
        mychild2.Show()
    End Sub
End Class
