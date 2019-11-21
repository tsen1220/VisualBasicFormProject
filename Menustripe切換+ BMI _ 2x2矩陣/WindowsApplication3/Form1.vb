Public Class Form1
    Private Sub BMICalculationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BMICalculationsToolStripMenuItem.Click

        Dim NewForm As New Form3
        NewForm.Owner = Me
        NewForm.Show()


    End Sub

    Private Sub X2MatrixSolverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles X2MatrixSolverToolStripMenuItem.Click

        Dim NewForm As New Form2
        NewForm.Owner = Me
        NewForm.Show()

    End Sub
End Class
