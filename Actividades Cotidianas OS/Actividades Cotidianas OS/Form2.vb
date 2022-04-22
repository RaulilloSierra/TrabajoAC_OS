Public Class Form2
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub BotonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BotonToolStripMenuItem.Click

    End Sub

    Private Sub ReiniciarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReiniciarToolStripMenuItem.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub ApagarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApagarToolStripMenuItem.Click
        Me.Hide()
        Form5.Show()
    End Sub
End Class