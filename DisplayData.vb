
Public Class DisplayData
    Dim uid, type, ln, fn, m, add, con, fb, selc, dates, times, tbl As String

    Dim num, name, events As String


    Private Sub Button3_Click(sender As Object, e As EventArgs)

        Addevent.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If cborec.SelectedItem = "Accounts" Then
            print.Show()
        ElseIf cborec.SelectedItem = "Monitor User" Then
            PrintRecord.Show()
        ElseIf cborec.SelectedItem = "Building And Room" Then
            List.Show()
        Else
            MsgBox("Show Record First")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If cborec.SelectedItem = "Accounts" Then
            Create.Show()
            Create.BtnExit2.Visible = True
            Create.lblid.Text = ""
            clear()
        ElseIf cborec.SelectedItem = "Building And Room" Then
            Addevent.Show

        End If



    End Sub

    Private Sub S(sender As Object, e As EventArgs)

    End Sub



    Private Sub BtnExit2_Click(sender As Object, e As EventArgs) Handles BtnExit2.Click
        Me.Hide()
        DYCIMAP.Show()


    End Sub

    Dim index As Integer


    Private Sub btndel_Click(sender As Object, e As EventArgs) Handles btndel.Click
        If cborec.SelectedItem = "Accounts" Then
            tbl = "accounts"
            archiveacc(uid, type, ln, fn, m, add, con, fb)
            delteaccount(tbl, uid)
        ElseIf cborec.SelectedItem = "Monitor User" Then
            archivehistory(Calendar.Label1.Text, Calendar.Label2.Text, type, uid, ln, fn, m, selc, dates, times)
            delmonitor(num)

        ElseIf cborec.SelectedItem = "Building And Room" Then
            delbuilding(num)
        End If

    End Sub

    Private Sub DisplayData_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        connection()
        Btndate.Visible = False
        btndel.Visible = True

    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        If cborec.SelectedItem = "Accounts" Then
            Btndate.Visible = False
            Label2.Visible = True
            cbosel.Visible = True
            btndel.Location = New Point(690, 4)
            btnUpdate.Visible = True
            Button2.Visible = True
            Btndate.Visible = False
            Label5.Text = "*IN UPDATE AND DELETE ALWAYS SELECT THE USER ID CELL AFTER CLICK THE DATA GRID"


            dgv("accounts")
            If cbosel.SelectedItem = "Student" Then
                dgvtype("Student", "accounts")
            ElseIf cbosel.SelectedItem = "Teacher" Then
                dgvtype("Teacher", "accounts")
            ElseIf cbosel.SelectedItem = "Employee" Then
                dgvtype("Employee", "accounts")
            ElseIf cbosel.SelectedItem = "Administrator" Then
                dgvtype("Administrator", "accounts")
            ElseIf cbosel.SelectedItem = "Visitor" Then
                dgvtype("Visitor", "accounts")
            ElseIf cbosel.SelectedItem = "Professor" Then
                dgvtype("Professor", "accounts")
            ElseIf cbosel.SelectedItem = "All" Then
                dgv("accounts")

            End If


        ElseIf cborec.SelectedItem = "Monitor User" Then
            Label5.Text = "*IN DELETE ALWAYS SELECT THE NUMBER CELL AFTER CLICK THE DATA GRID"
            Btndate.Visible = True
            btnUpdate.Visible = False
            btndel.Location = New Point(498, 3)
            Label2.Visible = True
            Button2.Visible = False
            cbosel.Visible = True

            dgv("usermonitor")
            Dgvtbl.ClearSelection()

            If cbosel.SelectedItem = "Student" Then
                dgvtype("Student", "usermonitor")
            ElseIf cbosel.SelectedItem = "Teacher" Then
                dgvtype("Teacher", "usermonitor")
            ElseIf cbosel.SelectedItem = "Employee" Then
                dgvtype("Employee", "usermonitor")
            ElseIf cbosel.SelectedItem = "Administrator" Then
                dgvtype("Administrator", "usermonitor")
            ElseIf cbosel.SelectedItem = "Visitor" Then
                dgvtype("Visitor", "usermonitor")
            ElseIf cbosel.SelectedItem = "Professor" Then
                dgvtype("Professor", "usermonitor")
            ElseIf cbosel.SelectedItem = "All" Then
                dgv("usermonitor")
            End If

        ElseIf cborec.SelectedItem = "Building And Room" Then
            Label5.Text = "*IN UPDATE AND DELETE ALWAYS SELECT THE NUMBER CELL AFTER CLICK THE DATA GRID"
            Label2.Visible = False
            Btndate.Visible = False
            cbosel.Visible = False
            btndel.Location = New Point(690, 4)
            btnUpdate.Visible = True
            Button2.Visible = True
            dgv("room_building")
        ElseIf cborec.SelectedItem = "" Then
            MsgBox("Select Record")
        End If
        txtCount.Text = Dgvtbl.Rows.Count


    End Sub

    Private Sub Btndate_Click(sender As Object, e As EventArgs) Handles Btndate.Click
        Calendar.Show()
        If Calendar.Label1.Text = " " And Calendar.Label2.Text = " " Then

        Else
            dgvdate(Calendar.Label2.Text, Calendar.Label1.Text)
        End If
    End Sub


    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            If cborec.SelectedItem = "Accounts" Then
                updateaccount(uid, type, ln, fn, m, add, con, fb)
            ElseIf cborec.SelectedItem = "Building And Room" Then
                upbuilding(num, name, events)
            Else
                MsgBox("Select Record First")
            End If
        Catch S As Exception
            MsgBox(S.Message)
        End Try
    End Sub

    Private Sub Dgvtbl_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgvtbl.CellClick
        If cborec.SelectedItem = "Accounts" Then


            index = e.RowIndex
            Dim row As DataGridViewRow
            row = Dgvtbl.Rows(index)
            uid = row.Cells(0).Value
            type = row.Cells(1).Value
            ln = row.Cells(2).Value
            fn = row.Cells(3).Value
            m = row.Cells(4).Value
            add = row.Cells(5).Value
            con = row.Cells(6).Value
            fb = row.Cells(7).Value
        ElseIf cborec.Text = "Building And Room" Then


            index = e.RowIndex
            Dim row As DataGridViewRow
            row = Dgvtbl.Rows(index)
            num = row.Cells(0).Value
            name = row.Cells(1).Value
            events = row.Cells(2).Value.ToString

        ElseIf cborec.Text = "Monitor User" Then

            index = e.RowIndex
                Dim row As DataGridViewRow
                row = Dgvtbl.Rows(index)
                num = row.Cells(0).Value
                type = row.Cells(1).Value
                uid = row.Cells(2).Value
                ln = row.Cells(3).Value
                fn = row.Cells(4).Value
                m = row.Cells(5).Value
            selc = row.Cells(6).Value
            dates = row.Cells(7).Value.ToString
            times = row.Cells(8).Value.ToString


        End If

    End Sub

End Class