Public Class Form1
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DateTimePicker3_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox8_TextChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
        Label2.Text = DateString
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label3.Text = DateTime.Now.ToShortTimeString
        Label2.Text = DateTime.Now.ToLongDateString

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ACOSToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ReiniciarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReiniciarToolStripMenuItem.Click
        Me.Hide()
        Form4.Show()

    End Sub

    Private Sub ApagarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApagarToolStripMenuItem.Click
        Me.Hide()
        Form5.Show()
    End Sub

    Private Sub ACOSToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ACOSToolStripMenuItem.Click

    End Sub
End Class
