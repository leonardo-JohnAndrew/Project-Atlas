Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Drawing


Module Module1
    Dim fname, lname, mid, type, address, contact, fb As String
    Dim profile As New MemoryStream
    Dim uid As Integer
    Dim num As New Random
    Dim ms As New System.IO.MemoryStream
    Dim arry() As Byte
    Dim con As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim read As MySqlDataReader
    Dim adpter As New MySqlDataAdapter

    Dim host, uname, pwd, dbname, query As String
    Public Sub connection()
        host = "127.0.0.1"
        dbname = "atlas_system"
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
    Public Sub Log_in()
        uid = LOGIN.txtID.Text
        query = ("Select * from accounts where user_id  = @id")
        cmd = New MySqlCommand(query, con)
        cmd.Parameters.AddWithValue("@id", uid)

        Try
            read = cmd.ExecuteReader
            If read.Read() Then
                Dim last, first, m As String
                last = read("lastname")
                first = read("firstname")
                m = read("middle")
                LOGIN.lblfullname.Text = (last & ", " & first & ", " & m).ToString
                arry = read.Item("pic")
                Dim ms As New System.IO.MemoryStream(arry)
                LOGIN.pbpic.Image = System.Drawing.Image.FromStream(ms)
                MainMenu.pbpf.Image = System.Drawing.Image.FromStream(ms)
                MessageBox.Show("Success Login")
                LOGIN.btnLOGIN.Visible = False
                LOGIN.BtnNext.Visible = True

            Else
                MsgBox("INVALID ID")
            End If
        Catch x As Exception
            MsgBox(x.Message)
        Finally
            read.Close()
        End Try


    End Sub
    Public Sub Register()

        fname = Create.txtFirstName.Text
        lname = Create.txtLastName.Text
        mid = Create.txtMiddle.Text
        type = Create.cbotype.GetItemText(Create.cbotype)
        uid = Create.lblid.Text
        address = Create.txtadd.Text
        contact = Create.txtcon.Text
        fb = Create.txtFB.Text
        Create.pbpic.Image.Save(profile, Create.pbpic.Image.RawFormat)

        ' INSERT INPUTED DATA AND PERFORM QUERY USING CMD 
        query = "INSERT INTO accounts(usertype,user_id,lastname,firstname,middle,address,contact,fbaccount,pic ) values(@type,@id, @lname,@fname,@m,@add,@con,@fb,@pic)"
        cmd = New MySqlCommand(query, con)
        '   add the parameter value
        With cmd
            .Parameters.AddWithValue("@type", type)
            .Parameters.AddWithValue("@id", uid)
            .Parameters.AddWithValue("@lname", lname)
            .Parameters.AddWithValue("@fname", fname)
            .Parameters.AddWithValue("@m", mid)
            .Parameters.AddWithValue("@add", address)
            .Parameters.AddWithValue("@con", contact)
            .Parameters.AddWithValue("@fb", fb)
            .Parameters.AddWithValue("@pic", profile.ToArray)

        End With
        Try
            'execute query command
            cmd.ExecuteNonQuery()
            MsgBox("Record save  successfully!")
        Catch ex As Exception
            MessageBox.Show("Error" & ex.Message)
        End Try
    End Sub
    Public Sub Modify()
        fname = Create.txtFirstName.Text
        lname = Create.txtLastName.Text
        mid = Create.txtMiddle.Text
        type = Create.cbotype.GetItemText(Create.cbotype)
        address = Create.txtadd.Text
        contact = Create.txtcon.Text
        fb = Create.txtFB.Text

        query = "UPDATE accounts set usertype = @type, lastname = @lt, firstname = @ft, middle = @m , address = @add, contact = @con, fbaccount = @fb, pic = @pic where  user_id = @id"
        cmd = New MySqlCommand(query, con)
        Try
            With cmd
                .Parameters.AddWithValue("@type", type)
                .Parameters.AddWithValue("@lt", lname)
                .Parameters.AddWithValue("@ft", fname)
                .Parameters.AddWithValue("@m", mid)
                .Parameters.AddWithValue("@add", address)
                .Parameters.AddWithValue("@con", contact)
                .Parameters.AddWithValue("@fb", fb)
                .Parameters.AddWithValue("@id", uid)
                .Parameters.AddWithValue("@pic", profile.ToArray)
                .ExecuteNonQuery()
            End With

        Catch ex As Exception
            MsgBox("Error" & ex.Message)
        Finally

        End Try
    End Sub

    Public Sub dis()
        Create.LABEL.Text = "UPDATE PROFILE"
        Create.lblid.Text = uid
        Create.lblid.Enabled = False
    End Sub
    Public Sub clear()
        Create.cbotype.Items.Remove(Create.cbotype.SelectedItem)
        Create.txtFirstName.Text = ""
        Create.txtLastName.Text = ""
        Create.txtadd.Text = ""
        Create.txtcon.Text = ""
        Create.txtFB.Text = ""

    End Sub
End Module
