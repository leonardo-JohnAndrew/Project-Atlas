
Public Class DisplayData
    Dim uid, type, ln, fn, m, add, con, fb, sel, dates, times, tbl As String
    Dim index As Integer


    Private Sub btndel_Click(sender As Object, e As EventArgs) Handles btndel.Click
        connection()
        If cborec.SelectedItem = "Monitor Use" Then
            archivehistory(Calendar.Label1.Text, Calendar.Label2.Text, type, uid, ln, fn, m, sel, dates, times)

        End If
        archiveacc(uid, type, ln, fn, m, add, con, fb)
        If cborec.SelectedItem = "Accounts" Then
            tbl = "accounts"
        ElseIf cborec.SelectedItem = "Monitor Use" Then
            tbl = "usermonitor"
        End If
        delteaccount(tbl, uid)

    End Sub

    Private Sub DisplayData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection()
        Btndate.Visible = False

    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click

        If cborec.SelectedItem = "Accounts" Then
            Btndate.Visible = False
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
            ElseIf cbosel.SelectedItem = "" Then
                dgv("accounts")
            End If


        ElseIf cborec.SelectedItem = "Monitor Use" Then
            Btndate.Visible = True
            btnadd.Visible = False
            btnUpdate.Visible = False
            btndel.Location = New Point(498, 3)
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
            ElseIf cbosel.SelectedItem = "" Then
                dgv("usermonitor")
            End If

        Else
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

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Create.Show()
        Create.LABEL.Text = "REGISTRATION"
        clear()
        Create.lblid.Text = ""
        Create.Button2.Visible = True
        Create.btndelete.Visible = False
        Create.btnUpdate.Visible = False
        Me.Hide()


    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        connection()
        updateaccount(uid, type, ln, fn, m, add, con, fb)
        '   Modify()

    End Sub

    Private Sub Dgvtbl_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgvtbl.CellClick
        If cborec.SelectedItem = "Accounts" Then
            Try

                Index = e.RowIndex
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

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If

    End Sub

End Class