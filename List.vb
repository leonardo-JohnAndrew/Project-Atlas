Public Class List
    Private Sub List_Load(sender As Object, e As EventArgs) Handles Me.Load
        print.CrystalReportViewer1.ReportSource = Nothing
        Dim rp As New NameList
        CrystalReportViewer1.Refresh()
        PrintRecord.CrystalReportViewer1.ReportSource = Nothing
        CrystalReportViewer1.ReportSource = Nothing
        CrystalReportViewer1.ReportSource = rp


    End Sub
End Class