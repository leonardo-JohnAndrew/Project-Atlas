
Public Class Start

    Private Sub Start_Load(sender As Object, e As EventArgs) Handles Me.Load

        connection()


    End Sub
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        End

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        LOGIN.Show()


    End Sub

    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Create.Show()
        Create.LABEL.Text = "REGISTRATION"
        Create.lblid.Text = " "
        Create.Button2.Visible = True
        Create.btndelete.Visible = False
        Create.btnUpdate.Visible = False
        Me.Hide()

    End Sub


End Class
