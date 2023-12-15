Public Class DYCIMAP
    Dim Sel As String

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Button2.Visible = True
        TextBox2.ReadOnly = False
        Button3.Visible = True
        Button5.Visible = True
        Button4.Visible = True
        TextBox2.Visible = True
        MsgBox("Search First On Search box before update name ")
        ComboBox1.Visible = False
        Label3.Visible = False
        txtadd.Visible = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        saveinfo()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox2.Text = "" Then
            MsgBox("Input Name First ")
        Else
            addname()
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        nameupdate()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        deletename()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If String.IsNullOrEmpty(TextBox1.Text) = False Then
            ComboBox1.Text = ""
            Sel = TextBox1.Text
            Direction_guide.TextBox1.Text = Sel
        ElseIf String.IsNullOrEmpty(ComboBox1.Text) = False Then
            TextBox1.Text = ""
            Sel = ComboBox1.Text
            Direction_guide.TextBox1.Text = Sel
        Else
            Sel = TextBox1.Text
            Direction_guide.TextBox1.Text = Sel
        End If
        Direction_guide.Show()
        Me.Hide()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

    End Sub
End Class