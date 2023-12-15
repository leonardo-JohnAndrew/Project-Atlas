Public Class LOGIN


    Private Sub BtnExit2_Click(sender As Object, e As EventArgs) Handles BtnExit2.Click
        Start.Show()
        Me.Hide()


    End Sub

    Private Sub LOGIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection()

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnLOGIN.Click
        Log_in()

    End Sub


End Class