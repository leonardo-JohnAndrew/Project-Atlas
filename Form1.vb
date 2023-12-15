
Public Class Start

    Private Sub Start_Load(sender As Object, e As EventArgs) Handles Me.Load

        connection()
        DYCIMAP.Button1.Visible = False
        Direction_guide.Button23.Visible = False
        DYCIMAP.Button7.Visible = False

    End Sub
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        End

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        LOGIN.Show()


    End Sub

    Private Sub BtnCreate_Click(sender As Object, e As EventArgs)
        clear()
        Create.Show()
        Create.lblid.Text = " "
        Create.Button2.Visible = True
        Create.btndelete.Visible = True
        Create.btnUpdate.Visible = True
        Create.BtnExit2.Visible = True
        Create.Button1.Visible = False
        Me.Hide()

    End Sub


End Class
