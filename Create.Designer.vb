﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Create
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BtnExit2 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtFB = New System.Windows.Forms.TextBox()
        Me.txtcon = New System.Windows.Forms.TextBox()
        Me.txtadd = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbotype = New System.Windows.Forms.ComboBox()
        Me.txtMiddle = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblid = New System.Windows.Forms.Label()
        Me.LABEL = New System.Windows.Forms.Button()
        Me.ofdup = New System.Windows.Forms.OpenFileDialog()
        Me.Btngen = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.btndelete)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.btnUpdate)
        Me.Panel1.Controls.Add(Me.BtnExit2)
        Me.Panel1.Location = New System.Drawing.Point(0, 455)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(849, 46)
        Me.Panel1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(61, 4)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(145, 34)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "&ADD"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btndelete.FlatAppearance.BorderSize = 0
        Me.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndelete.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btndelete.Location = New System.Drawing.Point(403, 0)
        Me.btndelete.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(145, 34)
        Me.btndelete.TabIndex = 18
        Me.btndelete.Text = "&DELETE"
        Me.btndelete.UseVisualStyleBackColor = True
        Me.btndelete.Visible = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnUpdate.Location = New System.Drawing.Point(563, 0)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(145, 34)
        Me.btnUpdate.TabIndex = 17
        Me.btnUpdate.Text = "&UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = True
        Me.btnUpdate.Visible = False
        '
        'Button2
        '
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(700, 0)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(145, 34)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "&SAVE"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'BtnExit2
        '
        Me.BtnExit2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnExit2.FlatAppearance.BorderSize = 0
        Me.BtnExit2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExit2.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnExit2.Location = New System.Drawing.Point(700, 0)
        Me.BtnExit2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnExit2.Name = "BtnExit2"
        Me.BtnExit2.Size = New System.Drawing.Size(145, 34)
        Me.BtnExit2.TabIndex = 2
        Me.BtnExit2.Text = "&EXIT"
        Me.BtnExit2.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.txtFB)
        Me.Panel3.Controls.Add(Me.txtcon)
        Me.Panel3.Controls.Add(Me.txtadd)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.cbotype)
        Me.Panel3.Controls.Add(Me.txtMiddle)
        Me.Panel3.Controls.Add(Me.txtFirstName)
        Me.Panel3.Controls.Add(Me.txtLastName)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Font = New System.Drawing.Font("Bernard MT Condensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(84, 87)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(673, 341)
        Me.Panel3.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(40, 201)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(111, 20)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Contact Number"
        '
        'txtFB
        '
        Me.txtFB.Location = New System.Drawing.Point(176, 250)
        Me.txtFB.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFB.Name = "txtFB"
        Me.txtFB.Size = New System.Drawing.Size(313, 27)
        Me.txtFB.TabIndex = 27
        '
        'txtcon
        '
        Me.txtcon.Location = New System.Drawing.Point(176, 197)
        Me.txtcon.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtcon.MaxLength = 11
        Me.txtcon.Name = "txtcon"
        Me.txtcon.Size = New System.Drawing.Size(313, 27)
        Me.txtcon.TabIndex = 26
        '
        'txtadd
        '
        Me.txtadd.Location = New System.Drawing.Point(176, 145)
        Me.txtadd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtadd.Name = "txtadd"
        Me.txtadd.Size = New System.Drawing.Size(313, 27)
        Me.txtadd.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(40, 254)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 20)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Facebook Account"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(40, 197)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 20)
        Me.Label6.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(40, 149)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 20)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Address"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 15)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 20)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "User type"
        '
        'cbotype
        '
        Me.cbotype.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox
        Me.cbotype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbotype.Items.AddRange(New Object() {"Student", "Employee", "Teacher", "Professor", "Administrator", "Visitor"})
        Me.cbotype.Location = New System.Drawing.Point(176, 15)
        Me.cbotype.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbotype.Name = "cbotype"
        Me.cbotype.Size = New System.Drawing.Size(160, 27)
        Me.cbotype.TabIndex = 20
        '
        'txtMiddle
        '
        Me.txtMiddle.Location = New System.Drawing.Point(513, 86)
        Me.txtMiddle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtMiddle.Multiline = True
        Me.txtMiddle.Name = "txtMiddle"
        Me.txtMiddle.Size = New System.Drawing.Size(120, 25)
        Me.txtMiddle.TabIndex = 19
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(260, 86)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFirstName.Multiline = True
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(184, 25)
        Me.txtFirstName.TabIndex = 18
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(21, 86)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtLastName.Multiline = True
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(184, 25)
        Me.txtLastName.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(279, 63)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 20)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "First Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(525, 63)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 20)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Middle Initial"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 63)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 20)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Last Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Bernard MT Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(549, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 24)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "User ID :"
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.BackColor = System.Drawing.Color.White
        Me.lblid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblid.Location = New System.Drawing.Point(636, 27)
        Me.lblid.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(2, 19)
        Me.lblid.TabIndex = 10
        '
        'LABEL
        '
        Me.LABEL.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.LABEL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.LABEL.FlatAppearance.BorderSize = 0
        Me.LABEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LABEL.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LABEL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.LABEL.Location = New System.Drawing.Point(9, 16)
        Me.LABEL.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LABEL.Name = "LABEL"
        Me.LABEL.Size = New System.Drawing.Size(393, 43)
        Me.LABEL.TabIndex = 11
        Me.LABEL.Text = "INPUT INFORMATION"
        Me.LABEL.UseVisualStyleBackColor = False
        '
        'ofdup
        '
        Me.ofdup.FileName = "Upload Picture"
        Me.ofdup.Filter = "Image FIles | *jpg; *png"
        '
        'Btngen
        '
        Me.Btngen.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Btngen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btngen.FlatAppearance.BorderSize = 0
        Me.Btngen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btngen.Font = New System.Drawing.Font("Bernard MT Condensed", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btngen.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btngen.Location = New System.Drawing.Point(636, 54)
        Me.Btngen.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Btngen.Name = "Btngen"
        Me.Btngen.Size = New System.Drawing.Size(123, 26)
        Me.Btngen.TabIndex = 17
        Me.Btngen.Text = "Generate"
        Me.Btngen.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Location = New System.Drawing.Point(700, 0)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(145, 34)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "&EXIT"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Create
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(847, 492)
        Me.Controls.Add(Me.Btngen)
        Me.Controls.Add(Me.LABEL)
        Me.Controls.Add(Me.lblid)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Create"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnExit2 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblid As Label
    Friend WithEvents txtMiddle As TextBox
    Friend WithEvents cbotype As ComboBox
    Friend WithEvents LABEL As Button
    Friend WithEvents txtFB As TextBox
    Friend WithEvents txtcon As TextBox
    Friend WithEvents txtadd As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents ofdup As OpenFileDialog
    Friend WithEvents Btngen As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
End Class
