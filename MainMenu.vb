Public Class DYCIMAP
    Dim Sel As String
    Dim path As String = "C:\\Users\\maure\\source\\repos\\Project-Atlas\\image.png"
    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            PictureBox2.ImageLocation = PATH
        Catch a As Exception
            MsgBox("Choose Vicinity Map")
        End Try
        connection()
        selection()
        Search()
        Info()

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


    Private Sub BtnExit_Click_1(sender As Object, e As EventArgs) Handles BtnExit.Click
        monitor()
        End

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        saveinfo()


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        saveinfo()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If String.IsNullOrEmpty(TextBox1.Text) = False Then
            ComboBox1.Text = ""
            Sel = TextBox1.Text
            Direction_guide.ComboBox1.Text = Sel
        ElseIf String.IsNullOrEmpty(ComboBox1.Text) = False Then
            TextBox1.Text = ""
            Sel = ComboBox1.Text
            Direction_guide.ComboBox1.Text = Sel
        Else
            Sel = TextBox1.Text
            Direction_guide.ComboBox1.Text = Sel
        End If
        display()
        eventdis()
        Direction_guide.Show()
        Me.Hide()

    End Sub


    Private Sub Btnview_Click(sender As Object, e As EventArgs) Handles Btnview.Click
        DisplayData.Show()
        Me.Hide()
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        dis()
        Create.Button2.Visible = False
        Create.btnUpdate.Visible = True
        Create.btndelete.Visible = True
        Create.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'add
        OpenFileDialog1.Filter = "Picture (* .jpg; * .png) | * .jpg; * .png"
        OpenFileDialog1.ShowDialog()
        PictureBox2.ImageLocation = OpenFileDialog1.FileName
        'save
        Dim ANS As DialogResult = MessageBox.Show("Do you want to Save? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ANS = DialogResult.Yes Then

            PictureBox2.Image.Save(PATH)
        Else
        End If
    End Sub
End Class