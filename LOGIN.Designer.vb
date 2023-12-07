<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LOGIN
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Btnview = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.btnLOGIN = New System.Windows.Forms.Button()
        Me.BtnExit2 = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblfullname = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbltime = New System.Windows.Forms.Label()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Btnview)
        Me.Panel1.Controls.Add(Me.BtnEdit)
        Me.Panel1.Controls.Add(Me.btnLOGIN)
        Me.Panel1.Controls.Add(Me.BtnExit2)
        Me.Panel1.Location = New System.Drawing.Point(4, 174)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(533, 32)
        Me.Panel1.TabIndex = 0
        '
        'Btnview
        '
        Me.Btnview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btnview.FlatAppearance.BorderSize = 0
        Me.Btnview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnview.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnview.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btnview.Location = New System.Drawing.Point(216, 1)
        Me.Btnview.Name = "Btnview"
        Me.Btnview.Size = New System.Drawing.Size(109, 28)
        Me.Btnview.TabIndex = 6
        Me.Btnview.Text = "View Records"
        Me.Btnview.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnEdit.FlatAppearance.BorderSize = 0
        Me.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEdit.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnEdit.Location = New System.Drawing.Point(327, 1)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(109, 28)
        Me.BtnEdit.TabIndex = 5
        Me.BtnEdit.Text = "&Edit Profile"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'btnLOGIN
        '
        Me.btnLOGIN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnLOGIN.FlatAppearance.BorderSize = 0
        Me.btnLOGIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLOGIN.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLOGIN.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnLOGIN.Location = New System.Drawing.Point(400, -2)
        Me.btnLOGIN.Name = "btnLOGIN"
        Me.btnLOGIN.Size = New System.Drawing.Size(130, 33)
        Me.btnLOGIN.TabIndex = 3
        Me.btnLOGIN.Text = "&Login"
        Me.btnLOGIN.UseVisualStyleBackColor = True
        '
        'BtnExit2
        '
        Me.BtnExit2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnExit2.FlatAppearance.BorderSize = 0
        Me.BtnExit2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExit2.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnExit2.Location = New System.Drawing.Point(3, 0)
        Me.BtnExit2.Name = "BtnExit2"
        Me.BtnExit2.Size = New System.Drawing.Size(109, 28)
        Me.BtnExit2.TabIndex = 2
        Me.BtnExit2.Text = "&Exit"
        Me.BtnExit2.UseVisualStyleBackColor = True
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(162, 31)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(207, 20)
        Me.txtID.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(240, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 19)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "USER ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(295, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(240, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 19)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Name :"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(240, 140)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(0, 19)
        Me.lblName.TabIndex = 9
        '
        'lblfullname
        '
        Me.lblfullname.AutoSize = True
        Me.lblfullname.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfullname.Location = New System.Drawing.Point(181, 75)
        Me.lblfullname.Name = "lblfullname"
        Me.lblfullname.Size = New System.Drawing.Size(0, 19)
        Me.lblfullname.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(203, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 19)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(246, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 19)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "And"
        '
        'lbltime
        '
        Me.lbltime.AutoSize = True
        Me.lbltime.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltime.ForeColor = System.Drawing.Color.Black
        Me.lbltime.Location = New System.Drawing.Point(308, 140)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(0, 19)
        Me.lbltime.TabIndex = 17
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.ForeColor = System.Drawing.Color.Black
        Me.lbldate.Location = New System.Drawing.Point(181, 140)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(0, 19)
        Me.lbldate.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(289, 108)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 19)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Time"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'LOGIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(532, 205)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lbldate)
        Me.Controls.Add(Me.lbltime)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblfullname)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LOGIN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOGIN"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnExit2 As Button
    Friend WithEvents btnLOGIN As Button
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblfullname As Label
    Friend WithEvents BtnEdit As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbltime As Label
    Friend WithEvents lbldate As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Btnview As Button
End Class
