Public Class Direction_guide


    Private Sub Direction_guide_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection()
        eventdis()
        display()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button5.Click
        OFD.Filter = "Picture (* .jpg; * .png) | * .jpg; * .png"
        OFD.ShowDialog()
        PictureBox1.ImageLocation = OFD.FileName

        Dim ANS As DialogResult = MessageBox.Show("Do you want to Save? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ANS = DialogResult.Yes Then
            saveimage()
        Else
        End If

    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        Button5.Visible = True
        Button6.Visible = True
        Button7.Visible = True
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Hide()
        DYCIMAP.Show()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim ANS As DialogResult = MessageBox.Show("Do you want to Delete? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ANS = DialogResult.Yes Then
            deletimage()
        Else
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Addevent.Show()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)

    End Sub

End Class