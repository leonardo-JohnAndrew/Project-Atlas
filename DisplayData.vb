
Public Class DisplayData
    Dim tbl As String
    Private Sub DisplayData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection()
        Btndate.Visible = False

    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        If cborec.SelectedItem = "Accounts" Then
            dgv("accounts")
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

        ElseIf cborec.SelectedItem = "Monitor User" Then
            dgv("usermonitor")
            Btndate.Visible = True

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
        If Calendar.Label1.Text = " " And Calendar.Label3.Text = " " Then
            dgv("usermonitor")
        Else
            dgvdate(Calendar.Label3.Text, Calendar.Label1.Text)
        End If
    End Sub
End Class