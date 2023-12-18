Public Class Create

    Private Sub BtnExit2_Click(sender As Object, e As EventArgs) Handles BtnExit2.Click
        Button2.Visible = False
        btndelete.Visible = False
        btnUpdate.Visible = False
        BtnExit2.Visible = True
        DisplayData.Show()
        Me.Hide()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Register()
        LOGIN.Show()
        Me.Hide()


    End Sub



    Private Sub Btngen_Click(sender As Object, e As EventArgs) Handles Btngen.Click
        Dim num As New Random
        Dim id As Integer
        id = (num.Next(10000000))
        lblid.Text = id
    End Sub



    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        lblid.Enabled = False
        Dim ANS As DialogResult = MessageBox.Show("Do you want to save changes?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ANS = DialogResult.Yes Then
            Modify()

        Else
            MsgBox("Update Cancelled! ")
        End If
    End Sub

    Private Sub Create_Load(sender As Object, e As EventArgs) Handles Me.Load
        connection()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Dim ANS As DialogResult = MessageBox.Show("Do you want to delete records ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ANS = DialogResult.Yes Then
            delete()

        Else
            MsgBox("Delete Cancelled! ")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Register()
    End Sub
End Class