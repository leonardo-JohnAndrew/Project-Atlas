Public Class LOGIN


    Private Sub BtnExit2_Click(sender As Object, e As EventArgs) Handles BtnExit2.Click
        Start.Show()
        Me.Hide()


    End Sub

    Private Sub LOGIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnNext.Visible = False
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnLOGIN.Click
        Log_in()

    End Sub


    Private Sub BtnNext_Click_1(sender As Object, e As EventArgs) Handles BtnNext.Click

    End Sub
End Class