Public Class Direction_guide


    Private Sub Direction_guide_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        connection()
    
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button5.Click
        OFD.Filter = "Picture (* .jpg; * .png *.pdf) | * .jpg; * .png ; * .pdf "
        OFD.ShowDialog()
        PictureBox1.ImageLocation = OFD.FileName

        Dim ANS As DialogResult = MessageBox.Show("Do you want to Save? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ANS = DialogResult.Yes Then
            saveimage()
            MsgBox("Add Success")
            PictureBox1.Image = Nothing
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
        PictureBox1.Image = Nothing
        TextBox2.Text = ""
        DYCIMAP.Show()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim ANS As DialogResult = MessageBox.Show("Do you want to Delete? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ANS = DialogResult.Yes Then
            PictureBox1.Image = Nothing
            deletimage()
            MsgBox("Delete Success")

        Else
        End If

    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        deletimage()
        OFD.Filter = "Picture (* .jpg; * .png) | * .jpg; * .png"
        OFD.ShowDialog()
        PictureBox1.ImageLocation = OFD.FileName
        Dim ANS As DialogResult = MessageBox.Show("Do you want to Update? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ANS = DialogResult.Yes Then
            saveimage()
            MsgBox("Update Success")
            PictureBox1.Image = Nothing
        Else
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtTime.Text = Date.Now.ToLongTimeString
        txtDate.Text = Date.Now.ToString("yyyy-MM-dd")
    End Sub


End Class