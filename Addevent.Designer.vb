<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Addevent
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(91, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(187, 25)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "ROOM/BUILDING NAME"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(120, 45)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(130, 20)
        Me.TextBox1.TabIndex = 13
        Me.TextBox1.Text = "None"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(91, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(259, 40)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Input Event /Warning" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(120, 121)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(130, 20)
        Me.TextBox2.TabIndex = 16
        Me.TextBox2.Text = "None"
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Bernard MT Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button8.Location = New System.Drawing.Point(12, 143)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(79, 23)
        Me.Button8.TabIndex = 14
        Me.Button8.Text = "Add"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Bernard MT Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(284, 143)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(79, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "&Exit"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Addevent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(375, 178)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Addevent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Addevent"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button8 As Button

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        adbuilding(TextBox1.Text, TextBox2.Text)
    End Sub

    Friend WithEvents Button1 As Button

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DisplayData.Show()
        Me.Hide()
    End Sub
End Class
