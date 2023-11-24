
Public Class Start

    Private Sub Start_Load(sender As Object, e As EventArgs) Handles Me.Load

        connection()
        images()



    End Sub
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        End

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        LOGIN.Show()

    End Sub

    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Create.Show()
        Me.Hide()

    End Sub


End Class
