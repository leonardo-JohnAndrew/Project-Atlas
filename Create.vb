Public Class Create

    Private Sub BtnExit2_Click(sender As Object, e As EventArgs) Handles BtnExit2.Click
        Start.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Register()
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

            MsgBox("Update successfull!")
        Else
            MsgBox("Update Cancelled! ")
        End If
    End Sub

    Private Sub Create_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub


End Class