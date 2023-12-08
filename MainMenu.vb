Public Class DYCIMAP
    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection()
        selection()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtTime.Text = Date.Now.ToLongTimeString
        txtDate.Text = Date.Now.ToString("yyyy-MM-dd")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        Create.Show()
        dis()
        Me.Hide()
        LOGIN.Hide()
        Start.Hide()
        Create.btnUpdate.Visible = True
        Create.Button2.Visible = False
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnExit_Click_1(sender As Object, e As EventArgs) Handles BtnExit.Click

    End Sub


End Class