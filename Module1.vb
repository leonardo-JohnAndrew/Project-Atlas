Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Drawing


Module Module1
    Dim con As New MySqlConnection
    Dim cmd As New MySqlCommand
    ' Dim read As MySqlDataReader
    Dim adpter As New MySqlDataAdapter
    Dim host, uname, pwd, dbname, query As String
    Public Sub connection()
        host = "127.0.0.1"
        dbname = "atlas"
        uname = "root"
        pwd = ""
        If con IsNot Nothing Then
            con.Close() ' connection close 
            'connection signature
            con.ConnectionString = "server =" & host & ";userid=" & uname & ";password=" & pwd & ";database =" & dbname & ""
            Try
                con.Open() 'connection is open

            Catch ex As Exception

            End Try
        End If
    End Sub
    Public Sub Images()
        query = ("Select * from tblimage where num = 1")
        cmd = New MySqlCommand(query, con)
        adpter = New MySqlDataAdapter(cmd)

        Dim data As New DataTable()

        adpter.Fill(data)
        Dim img() As Byte
        img = data.Rows(0)(1)
        Dim ms As New System.IO.MemoryStream(img)
        Start.PictureBox1.Image = Image.FromStream(ms)
        con.Close()

    End Sub
End Module
