Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Drawing


Module Module1
    Dim fname, lname, mid, type, address, contact, fb As String
    Dim profile As New System.IO.MemoryStream
    Dim uid, sort, sel, events As String
    Dim ms As New System.IO.MemoryStream
    Dim con As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim read As MySqlDataReader
    Dim adpter As New MySqlDataAdapter
    Dim table, table2 As New DataTable
    Dim data As New AutoCompleteStringCollection
    Dim host, uname, pwd, dbname, query As String
    Dim ans As DialogResult
    Dim filepath As String = "C:\\Users\\maure\\source\\repos\\Project-Atlas\\info.txt"

    Public Sub connection()
        host = "127.0.0.1"
        dbname = "atlas_system"
        uname = "root"
        pwd = ""
        If con IsNot Nothing Then
            con.Close()

            con.ConnectionString = "server =" & host & ";userid=" & uname & ";password=" & pwd & ";database =" & dbname & ";Convert Zero Datetime = true"
            Try
                con.Open()

            Catch ex As Exception

            End Try
        End If
    End Sub
    Public Sub Log_in()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        uid = LOGIN.txtID.Text
        query = ("Select * from accounts where user_id  = @id")
        cmd = New MySqlCommand(query, con)
        cmd.Parameters.AddWithValue("@id", uid)

        Try
            read = cmd.ExecuteReader
            If read.Read() Then
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
                With LOGIN
                    .lblfullname.Text = (lname & ", " & fname & ", " & mid).ToString
                End With

                If type = "Administrator" Then
                    Create.Button1.Visible = True
                    Create.Button3.Visible = False
                    DYCIMAP.Button1.Visible = True
                    Direction_guide.Button23.Visible = True
                    DYCIMAP.Btnview.Visible = True
                    DYCIMAP.Button7.Visible = True
                    Direction_guide.ComboBox1.Enabled = True
                    DYCIMAP.Btnview.Visible = True
                    DYCIMAP.BtnEdit.Visible = False
                    DYCIMAP.Button1.Visible = True
                    DYCIMAP.TextBox2.Enabled = True
                    DYCIMAP.Button3.Visible = True
                Else
                    DYCIMAP.Button7.Visible = False
                    Create.Button3.Visible = True
                    Create.Button1.Visible = False
                    DYCIMAP.BtnEdit.Visible = True
                    DYCIMAP.Btnview.Visible = False
                    DYCIMAP.Button1.Visible = False
                    DYCIMAP.TextBox2.Enabled = False
                    DYCIMAP.Button3.Visible = False
                End If
                Dim ANS As DialogResult = MessageBox.Show("Do you want to go next ? " & LOGIN.lblfullname.Text, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If ANS = DialogResult.Yes Then
                    DYCIMAP.Show()

                    LOGIN.Hide()
                Else

                End If
                With LOGIN
                    .lblfullname.Text = ""
                End With


            Else
                MsgBox("INVALID ID")
            End If
        Catch x As Exception
            MsgBox(x.Message)
        Finally
            read.Close()
            con.Close()

        End Try



    End Sub
    Public Sub monitor()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        read.Close()
        query = "Insert Into usermonitor (usertype,user_id, lastname, firstname, middle,selc,date,time)VALUES(@type,@uid,@ln,@fn,@m,@sel,@date,@time)"
        cmd = New MySqlCommand(query, con)


        With cmd
            .Parameters.AddWithValue("@type", type)
            .Parameters.AddWithValue("@uid", uid)
            .Parameters.AddWithValue("@ln", lname)
            .Parameters.AddWithValue("@fn", fname)
            .Parameters.AddWithValue("@m", mid)
            .Parameters.AddWithValue("@date", Date.Now.ToString("yyyy-MM-dd"))
            .Parameters.AddWithValue("@time", Date.Now.ToLongTimeString)
            .Parameters.AddWithValue("@sel", Direction_guide.ComboBox1.Text)
            .ExecuteNonQuery()
        End With
        con.Close()

    End Sub
    Public Sub Register()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        fname = Create.txtFirstName.Text
        lname = Create.txtLastName.Text
        mid = Create.txtMiddle.Text
        type = Create.cbotype.Text
        uid = Create.lblid.Text
        address = Create.txtadd.Text
        contact = Create.txtcon.Text
        fb = Create.txtFB.Text
        query = "INSERT INTO accounts(usertype,user_id,lastname,firstname,middle,address,contact,fbaccount ) values(@type,@id, @lname,@fname,@m,@add,@con,@fb)"
        cmd = New MySqlCommand(query, con)



        With cmd
            .Parameters.AddWithValue("@type", type)
            .Parameters.AddWithValue("@id", Convert.ToDecimal(uid))
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
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
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

                .ExecuteNonQuery()
                MsgBox("Update success")
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
        Create.txtMiddle.Text = ""
        Create.txtadd.Text = ""
        Create.txtcon.Text = ""
        Create.txtFB.Text = ""

    End Sub
    Public Sub delete()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
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
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
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


        End With
    End Sub
    Public Sub dgv(tbl As String)
        Try
            query = "Select * from " & tbl
            adpter = New MySqlDataAdapter(query, con)

            table = New DataTable
            adpter.Fill(table)
            DisplayData.Dgvtbl.Rows.GetRowsHeight(100)
            DisplayData.Dgvtbl.DataSource = table
            DisplayData.Dgvtbl.AutoResizeColumns()
            If tbl = "accounts " Then
                PrintRecord.CrystalReportViewer1.ReportSource = Nothing
                Dim rp As New AllAccounts
                rp.SetDataSource(table)
                With PrintRecord
                    .CrystalReportViewer1.ReportSource = rp
                    .CrystalReportViewer1.Refresh()
                End With
            ElseIf tbl = "usermonitor" Then
                print.CrystalReportViewer1.ReportSource = Nothing
                Dim rp As New AllMonitoring
                rp.SetDataSource(table)
                With print
                    .CrystalReportViewer1.ReportSource = rp
                    .CrystalReportViewer1.Refresh()
                End With
            ElseIf tbl = "room_building" Then
                Building.CrystalReportViewer1.ReportSource = Nothing
                Dim rp As New Building_name
                rp.SetDataSource(table)
                With Building
                    .CrystalReportViewer1.ReportSource = rp
                    .CrystalReportViewer1.Refresh()
                End With
            Else

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()

        End Try

    End Sub
    Public Sub dgvtype(types As String, tbl As String)
        query = "Select * from " & tbl & " Where usertype = " & "'" & types & "'"
        adpter = New MySqlDataAdapter(query, con)
        Try

            table = New DataTable
            adpter.Fill(table)
            DisplayData.Dgvtbl.DataSource = table
            DisplayData.Dgvtbl.AutoResizeColumns()
            If tbl = "accounts" Then
                Dim rp As New AllAccounts
                PrintRecord.CrystalReportViewer1.ReportSource = Nothing
                rp.SetDataSource(table)
                With PrintRecord
                    .CrystalReportViewer1.Refresh()
                    .CrystalReportViewer1.ReportSource = rp

                End With
            ElseIf tbl = "usermonitor" Then
                Dim rp As New AllMonitoring
                print.CrystalReportViewer1.ReportSource = Nothing
                rp.SetDataSource(table)
                With print
                    .CrystalReportViewer1.Refresh()
                    .CrystalReportViewer1.ReportSource = rp

                End With
            Else
                MsgBox("Records Accounts and Monitor ")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Public Sub dgvdate(enddate As String, startdate As String)
        query = "Select * from usermonitor where date between '" & startdate & "' And '" & enddate & "'"
        adpter = New MySqlDataAdapter(query, con)
        Try
            table = New DataTable
            adpter.Fill(table)
            DisplayData.Dgvtbl.DataSource = table
            DisplayData.Dgvtbl.AllowUserToResizeRows = False
            Dim rp As New AllMonitoring
            print.CrystalReportViewer1.ReportSource = Nothing
            rp.SetDataSource(table)
            With print
                .CrystalReportViewer1.Refresh()
                .CrystalReportViewer1.ReportSource = rp

            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub updateaccount(id As String, usertype As String, ln As String, fn As String, m As String, ad As String, cot As String, FB As String)
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        query = "UPDATE accounts SET usertype = @type, lastname = @ln , Firstname = @fn , middle = @m , address = @add , contact = @con , fbaccount = @fb where (user_id = @id)"
        cmd = New MySqlCommand(query, con)
        Try
            With cmd
                .Parameters.AddWithValue("@id", id)
                .Parameters.AddWithValue("@type", usertype)
                .Parameters.AddWithValue("@ln", ln)
                .Parameters.AddWithValue("@fn", fn)
                .Parameters.AddWithValue("@m", m)
                .Parameters.AddWithValue("@add", ad)
                .Parameters.AddWithValue("@con", cot)
                .Parameters.AddWithValue("@fb", FB)
                .ExecuteNonQuery()
                MsgBox("Update success")
            End With

        Catch ex As Exception
            MsgBox("Error" & ex.Message)
        Finally
            clear()

        End Try
    End Sub
    Public Sub delteaccount(tbl As String, id As String)
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        query = "DELETE from accounts where user_id = @id"
        Try
            Using CMD As New MySqlCommand(query, con)
                CMD.Parameters.AddWithValue("@id", id)
                CMD.ExecuteNonQuery()

            End Using
            MsgBox("DELETION Successfull!", vbInformation, "DELETE MESSAGE")
        Catch ex As Exception
            MsgBox("Select ID Cell " & ex.Message, vbInformation, "ERROR MESSAGE")
        Finally
            clear()
        End Try
    End Sub
    Public Sub delmonitor(num As String)
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        query = "DELETE from usermonitor where Number = @num"
        Try
            Using CMD As New MySqlCommand(query, con)
                CMD.Parameters.AddWithValue("@num", num)
                CMD.ExecuteNonQuery()

            End Using
            MsgBox("DELETION Successfull!", vbInformation, "DELETE MESSAGE")
        Catch ex As Exception
            MsgBox("Select Number Cell " & ex.Message, vbInformation, "ERROR MESSAGE")
        Finally
            clear()
        End Try
    End Sub

    Public Sub archiveacc(id As String, usertype As String, ln As String, fn As String, m As String, ad As String, cot As String, FB As String)
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        query = "Insert Into archiveaccount (usertype,user_id, lastname, firstname, middle,address,contact,fbaccount)VALUES(@type,@uid,@ln,@fn,@m,@add,@con,@fb)"
        cmd = New MySqlCommand(query, con)
        With cmd
            .Parameters.AddWithValue("@type", usertype)
            .Parameters.AddWithValue("@uid", id)
            .Parameters.AddWithValue("@ln", ln)
            .Parameters.AddWithValue("@fn", fn)
            .Parameters.AddWithValue("@m", m)
            .Parameters.AddWithValue("@add", ad)
            .Parameters.AddWithValue("@con", cot)
            .Parameters.AddWithValue("@fb", FB)
            .ExecuteNonQuery()

        End With
    End Sub
    Public Sub archivehistory(startdate As String, enddate As String, type As String, id As String, ln As String, ft As String, M As String, sel As String, dates As String, times As String)
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        query = "Insert Into archiveusermonitor (usertype,user_id, lastname, firstname, middle,selc,date,time)VALUES(@type,@uid,@ln,@fn,@m,@sel,@date,@time)"
        cmd = New MySqlCommand(query, con)
        With cmd
            .Parameters.AddWithValue("@type", type)
            .Parameters.AddWithValue("@uid", id)
            .Parameters.AddWithValue("@ln", ln)
            .Parameters.AddWithValue("@fn", ft)
            .Parameters.AddWithValue("@m", M)
            .Parameters.AddWithValue("@sel", sel)
            .Parameters.AddWithValue("@date", dates)
            .Parameters.AddWithValue("@time", times)
            .ExecuteNonQuery()
        End With
        query = "Delete from usermonitor where date between '" & startdate & "' And '" & enddate & "'"
        Try
            Using CMD As New MySqlCommand(query, con)
                CMD.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbInformation, "ERROR MESSAGE")
        Finally

        End Try
    End Sub
    Public Sub selection()
        query = "Select * From room_building order by room_building asc "
        cmd = New MySqlCommand(query, con)
        adpter = New MySqlDataAdapter(cmd)
        table = New DataTable
        adpter.Fill(table)
        With DYCIMAP.ComboBox1
            .DataSource = table
            .DisplayMember = "room_building"

        End With
        Direction_guide.ComboBox1.DataSource = table
        Direction_guide.ComboBox1.DisplayMember = "room_building"
    End Sub

    Public Sub Search()
        query = "Select room_building from room_building "
        cmd = New MySqlCommand(query, con)
        read = cmd.ExecuteReader()
        data = New AutoCompleteStringCollection()
        Try
            While read.Read()
                data.Add(read.GetString(0))
                DYCIMAP.TextBox1.AutoCompleteCustomSource = data

            End While
        Catch e As Exception

        Finally
            read.Close()
            con.Close()
        End Try
    End Sub
    Public Sub Info()
        Dim file As String
        Using reader As StreamReader = New StreamReader(filepath)
            file = reader.ReadToEnd()
        End Using
        DYCIMAP.TextBox2.Text = file
    End Sub
    Public Sub saveinfo()
        'Write filE
        System.IO.File.WriteAllText(filepath, "")
        Dim write As System.IO.StreamWriter = New System.IO.StreamWriter(filepath)
        write.Write(DYCIMAP.TextBox2.Text)
        write.Close()

    End Sub


    Public Sub eventdis()
        '  con.Open()

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        query = "Select event_warning from room_building where room_building = '" & Direction_guide.ComboBox1.Text & "'"
        cmd = New MySqlCommand(query, con)
        Try
            read = cmd.ExecuteReader
            If read.Read Then
                events = read("event_warning")
                Direction_guide.TextBox2.Text = events
                read.Close()
            End If
        Catch ex As Exception
            Direction_guide.TextBox2.Text = "None"
        End Try
    End Sub
    Public Sub adbuilding(name As String, events As String)
        '  con.Open()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Try
            query = "INSERT INTO room_building (room_building,event_warning) values (@name,@event)"
            cmd = New MySqlCommand(query, con)

            cmd.Parameters.AddWithValue("@name", name)
            cmd.Parameters.AddWithValue("@event", events)
            cmd.ExecuteNonQuery()
            MsgBox("Add Success")
        Catch e As Exception

        End Try

    End Sub
    Public Sub upbuilding(num As String, name As String, events As String)
        ' con.Open()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Try
            query = "Update room_building Set num = @num , room_building = @name, event_warning = @events WHERE (num = @num)"
            cmd = New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@num", num)
            cmd.Parameters.AddWithValue("@name", name)
            cmd.Parameters.AddWithValue("@events", events)
            cmd.ExecuteNonQuery()
            MsgBox("Update Success")
        Catch e As Exception
            MsgBox("Select Number Cell")
        End Try

    End Sub
    Public Sub delbuilding(num As String)
        '  con.Open()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Try
            query = "Delete event_warning  room_building WHere num  = " & num & ""
            cmd = New MySqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("Delete Success")
        Catch e As Exception
            MsgBox("Select Number Cell")
        End Try
    End Sub
    Public Sub saveimage()
        read.Close()

        query = "Insert into images  (image,NAME) values(@image , @name)"
        ms = New System.IO.MemoryStream()
        Direction_guide.PictureBox1.Image.Save(ms, Direction_guide.PictureBox1.Image.RawFormat)
        ms.Close()
        Try
            cmd = New MySqlCommand(query, con)
            cmd.Parameters.Add("@image", MySqlDbType.LongBlob).Value = ms.ToArray()
            cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = Direction_guide.ComboBox1.Text
            cmd.ExecuteNonQuery()
            MsgBox("Add Success ")
        Catch EX As Exception
            MsgBox(EX.Message)

        End Try



    End Sub
    Public Sub deletimage()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        read.Close()
        query = "Delete from images where NAME = '" & Direction_guide.ComboBox1.Text & "'"

        Try
            cmd = New MySqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("Delete Success ")
        Catch EX As Exception
            MsgBox(EX.Message)

        End Try

    End Sub


    Public Sub upimage()
        '   con.Open()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        read.Close()

        query = "Update images set @images where NAME = '" & Direction_guide.ComboBox1.Text & "'"
        ms = New System.IO.MemoryStream()
        Direction_guide.PictureBox1.Image.Save(ms, Direction_guide.PictureBox1.Image.RawFormat)
        Try
            cmd = New MySqlCommand(query, con)
            cmd.Parameters.Add("@image", MySqlDbType.LongBlob).Value = ms.ToArray()

            cmd.ExecuteNonQuery()
            MsgBox("Update Success ")
        Catch EX As Exception
            MsgBox(EX.Message)

        End Try
    End Sub
    Public Sub display()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        read.Close()

        Try
            query = "Select image from images where NAME = '" & Direction_guide.ComboBox1.Text & "'"
            cmd = New MySqlCommand(query, con)
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            read = cmd.ExecuteReader
            read.Read()
            Dim arry() As Byte = read.Item("image")
            Dim ms As New System.IO.MemoryStream(arry)
            Direction_guide.PictureBox1.Image = Image.FromStream(ms)

        Catch e As Exception
            MsgBox("Direction not Available")
        Finally
            read.Close()
            con.Close()

        End Try
    End Sub
End Module

