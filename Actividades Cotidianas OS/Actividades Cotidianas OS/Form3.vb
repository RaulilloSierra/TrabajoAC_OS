Public Class Form3
    Dim acum As Integer
    Private Sub Contraseña_TextChanged(sender As Object, e As EventArgs) Handles Contraseña.TextChanged

    End Sub

    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        If Contraseña.Text = "1234" Then
            Me.Hide()
            Form1.Show()
        Else
            MsgBox("La contraseña es incorrecta,inténtelo nuevamente")
        End If
    End Sub

    Private Sub ReiniciarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReiniciarToolStripMenuItem.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub ApagarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApagarToolStripMenuItem.Click
        Me.Hide()
        Form5.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class