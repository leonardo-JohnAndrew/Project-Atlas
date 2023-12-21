Public Class Add
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        adbuilding(TextBox1.Text, TextBox2.Text)
        DisplayData.Show()
        Me.Hide()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DisplayData.Show()
        Me.Hide()
    End Sub
End Class