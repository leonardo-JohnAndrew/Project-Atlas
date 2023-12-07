Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Drawing


Module Module1
    Dim fname, lname, mid, type, address, contact, fb As String
    Dim profile As New System.IO.MemoryStream
    Dim uid, sort, sel As String
    Dim ms As New System.IO.MemoryStream
    Dim arry() As Byte
    Dim con As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim read As MySqlDataReader
    Dim adpter As New MySqlDataAdapter
    Dim table As New DataTable
    Dim host, uname, pwd, dbname, query As String
    Public Sub connection()
        host = "127.0.0.1"
        dbname = "atlas_system"
        uname = "root"
        pwd = ""
        If con IsNot Nothing Then
            con.Close() ' connection close 
            'connection signature
            con.ConnectionString = "server =" & host & ";userid=" & uname & ";password=" & pwd & ";database =" & dbname & ";Convert Zero Datetime = true"
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
                '   Dim last, first, m As String
                lname = read("lastname")
                fname = read("firstname")
                mid = read("middle")
                address = read("address")
                fb = read("fbaccount")
                type = read("usertype")
                Dim ty = type
                contact = read("contact")
                Create.lblid.Text = LOGIN.txtID.Text
                Create.txtFirstName.Text = fname
                Create.txtLastName.Text = lname
                Create.txtMiddle.Text = mid
                Create.cbotype.Text = type
                Create.txtadd.Text = address
                Create.txtcon.Text = contact
                Create.txtFB.Text = fb
                LOGIN.lblfullname.Text = (lname & ", " & fname & ", " & mid).ToString
                LOGIN.lbltime.Text = Date.Now.ToLongTimeString
                LOGIN.lbldate.Text = Date.Now.ToString("yyyy-MM-dd")
                If type = "Administrator" Then
                    LOGIN.Btnview.Visible = True
                End If
                LOGIN.BtnEdit.Visible = True

            Else
                MsgBox("INVALID ID")
            End If
        Catch x As Exception
            MsgBox(x.Message)
        Finally
            read.Close()
        End Try
        query = "Insert Into usermonitor (usertype,user_id, lastname, firstname, middle,selc,date,time)VALUES(@type,@uid,@ln,@fn,@m,@sel,@date,@time)"
        cmd = New MySqlCommand(query, con)
        With cmd
            .Parameters.AddWithValue("@type", type)
            .Parameters.AddWithValue("@uid", uid)
            .Parameters.AddWithValue("@ln", lname)
            .Parameters.AddWithValue("@fn", fname)
            .Parameters.AddWithValue("@m", mid)
            .Parameters.AddWithValue("@time", LOGIN.lbltime.Text)
            .Parameters.AddWithValue("@date", LOGIN.lbldate.Text)
            .Parameters.AddWithValue("@sel", "None")
            .ExecuteNonQuery()
            '.Parameters.AddWithValue("@pic", profile.ToArray)

        End With



    End Sub
    Public Sub Register()
        fname = Create.txtFirstName.Text
        lname = Create.txtLastName.Text
        mid = Create.txtMiddle.Text
        type = Create.cbotype.Text
        uid = Create.lblid.Text
        address = Create.txtadd.Text
        contact = Create.txtcon.Text
        fb = Create.txtFB.Text
        'Dim profile As New MemoryStream

        ' INSERT INPUTED DATA AND PERFORM QUERY USING CMD 
        query = "INSERT INTO accounts(usertype,user_id,lastname,firstname,middle,address,contact,fbaccount ) values(@type,@id, @lname,@fname,@m,@add,@con,@fb)"
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
            '.Parameters.AddWithValue("@pic", profile.ToArray)

        End With
        Try
            'execute query command
            If Create.txtFirstName.Text = " " Or Create.txtLastName.Text = "" Or Create.txtMiddle.Text = " " Or
           Create.txtadd.Text = " " Or Create.txtcon.Text = " " Or String.IsNullOrEmpty(Create.cbotype.SelectedItem) Or Create.lblid.Text = "" Or
           Create.txtFB.Text = " " Then
                Dim dialogResult = MessageBox.Show("Input all information ")
            Else

                cmd.ExecuteNonQuery()

                MsgBox("Record save  successfully!")
            End If
        Catch ex As Exception
            MessageBox.Show("Error" & ex.Message)

        End Try
    End Sub
    Public Sub Modify()
        fname = Create.txtFirstName.Text
        lname = Create.txtLastName.Text
        mid = Create.txtMiddle.Text
        type = Create.cbotype.Text
        address = Create.txtadd.Text
        contact = Create.txtcon.Text
        fb = Create.txtFB.Text
        query = "UPDATE accounts set usertype = @type, lastname = @lt, firstname = @ft, middle = @m , address = @add, contact = @con, fbaccount = @fb where  user_id = @id"

        cmd = New MySqlCommand(query, con)
        Try
            'execute query command
            If Create.txtFirstName.Text = " " Or Create.txtLastName.Text = "" Or Create.txtMiddle.Text = " " Or
           Create.txtadd.Text = " " Or Create.txtcon.Text = " " Or String.IsNullOrEmpty(Create.cbotype.SelectedItem) Or
           Create.txtFB.Text = " " Then
                Dim dialogResult = MessageBox.Show("Input all information ")
            Else

            End If
            With cmd
                .Parameters.AddWithValue("@type", type)
                .Parameters.AddWithValue("@lt", lname)
                .Parameters.AddWithValue("@ft", fname)
                .Parameters.AddWithValue("@m", mid)
                .Parameters.AddWithValue("@add", address)
                .Parameters.AddWithValue("@con", contact)
                .Parameters.AddWithValue("@fb", fb)
                .Parameters.AddWithValue("@id", uid)
                ' .Parameters.AddWithValue("@pic", profile.ToArray)
                .ExecuteNonQuery()
                'MsgBox("Update success")
            End With

        Catch ex As Exception
            MsgBox("Error" & ex.Message)
        Finally
            clear()

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
    Public Sub delete()
        archive()
        query = "DELETE from accounts where user_id = @id "
        Try
            Using CMD As New MySqlCommand(query, con)
                CMD.Parameters.AddWithValue("@id", uid)
                CMD.ExecuteNonQuery()

            End Using
            MsgBox("DELETION Successfull!", vbInformation, "DELETE MESSAGE")
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbInformation, "ERROR MESSAGE")
        Finally
            clear()
        End Try

    End Sub
    Public Sub archive()
        query = "Insert Into archiveaccount (usertype,user_id, lastname, firstname, middle,address,contact,fbaccount)VALUES(@type,@uid,@ln,@fn,@m,@add,@con,@fb)"
        cmd = New MySqlCommand(query, con)
        With cmd
            .Parameters.AddWithValue("@type", type)
            .Parameters.AddWithValue("@uid", uid)
            .Parameters.AddWithValue("@ln", lname)
            .Parameters.AddWithValue("@fn", fname)
            .Parameters.AddWithValue("@m", mid)
            .Parameters.AddWithValue("@add", address)
            .Parameters.AddWithValue("@con", contact)
            .Parameters.AddWithValue("@fb", fb)
            .ExecuteNonQuery()
            '.Parameters.AddWithValue("@pic", profile.ToArray)

        End With
    End Sub
    Public Sub dgv(tbl As String)

        query = "Select *from " & tbl
        adpter = New MySqlDataAdapter(query, con) 'dISPLAY ALL Data in data grid
        Try
            table.Clear()
            adpter.Fill(table) ' pass the record from mysql to table
            DisplayData.Dgvtbl.DataSource = table
            DisplayData.Dgvtbl.AllowUserToResizeRows = False
            DisplayData.Dgvtbl.AutoResizeColumns()
            ' DisplayData.txtCount.Text = DisplayData.Dgvtbl.Rows.Count
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Public Sub dgvtype(types As String, tbl As String)
        query = "Select * from " & tbl & " Where usertype = " & "'" & types & "'"
        adpter = New MySqlDataAdapter(query, con) 'dISPLAY ALL Data in data grid
        Try
            table.Clear()
            adpter.Fill(table) ' pass the record from mysql to table
            DisplayData.Dgvtbl.DataSource = table
            DisplayData.Dgvtbl.AllowUserToResizeRows = False
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Public Sub dgvdate(enddate As String, startdate As String)
        query = "Select * from usermonitor where date between '" & startdate & "' And '" & enddate & "'"
        adpter = New MySqlDataAdapter(query, con) 'dISPLAY ALL Data in data grid
        Try
            table.Clear()
            adpter.Fill(table) ' pass the record from mysql to table
            DisplayData.Dgvtbl.DataSource = table
            DisplayData.Dgvtbl.AllowUserToResizeRows = False
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

End Module
