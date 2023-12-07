Public Class Calendar
    Private Sub Calendar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        Label1.Text = MonthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd")
        Label2.Text = MonthCalendar1.SelectionRange.End.ToString("yyyy-MM-dd")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DisplayData.Show()
        dgvdate(Label2.Text, Label1.Text)
        DisplayData.txtCount.Text = DisplayData.Dgvtbl.Rows.Count
        Me.Hide()


    End Sub
End Class