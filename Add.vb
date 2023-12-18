Public Class Add
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        adbuilding(TextBox1.Text, TextBox2.Text)
        DisplayData.Show()
        Me.Hide()
    End Sub

    Private Sub Add_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DisplayData.Show()
        Me.Hide()
    End Sub
End Class