Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Hide()
        Form2.Show()
    End Sub
End Class