Public Class LOGIN


    Private Sub BtnExit2_Click(sender As Object, e As EventArgs) Handles BtnExit2.Click
        Start.Show()
        Me.Hide()


    End Sub

    Private Sub LOGIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnEdit.Visible = False
        Btnview.Visible = False
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnLOGIN.Click
        Log_in()

    End Sub

    Private Sub BtnNext_Click_1(sender As Object, e As EventArgs)
        MainMenu.Show()
        btnLOGIN.Visible = True
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        dis()
        Create.Button2.Visible = False
        Create.btnUpdate.Visible = True
        Create.btndelete.Visible = True
        Create.Show()


    End Sub

    Private Sub Btnview_Click(sender As Object, e As EventArgs) Handles Btnview.Click
        DisplayData.Show
    End Sub


End Class