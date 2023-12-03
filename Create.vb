Public Class Create
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtFirstName.TextChanged

    End Sub

    Private Sub BtnExit2_Click(sender As Object, e As EventArgs) Handles BtnExit2.Click
        Start.Show()
        Me.Hide()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Register()

    End Sub

    Private Sub btnup_Click(sender As Object, e As EventArgs) Handles btnup.Click
        

        ofdup.ShowDialog()
        pbpic.ImageLocation = ofdup.FileName

    End Sub

    Private Sub Btngen_Click(sender As Object, e As EventArgs) Handles Btngen.Click
        Dim num As New Random
        Dim id As Integer
        id = (num.Next(10000000))
        lblid.Text = id
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        Log_in()


    End Sub
End Class