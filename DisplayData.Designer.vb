﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DisplayData
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.BtnExit2 = New System.Windows.Forms.Button()
        Me.cborec = New System.Windows.Forms.ComboBox()
        Me.cbosel = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Dgvtbl = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCount = New System.Windows.Forms.TextBox()
        Me.Btndate = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.Dgvtbl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnadd)
        Me.Panel1.Controls.Add(Me.btnShow)
        Me.Panel1.Controls.Add(Me.btnUpdate)
        Me.Panel1.Controls.Add(Me.BtnExit2)
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel1.Location = New System.Drawing.Point(1, 311)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 38)
        Me.Panel1.TabIndex = 2
        '
        'btnadd
        '
        Me.btnadd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnadd.FlatAppearance.BorderSize = 0
        Me.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnadd.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnadd.Location = New System.Drawing.Point(674, 3)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(109, 28)
        Me.btnadd.TabIndex = 19
        Me.btnadd.Text = "&ADD"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'btnShow
        '
        Me.btnShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnShow.FlatAppearance.BorderSize = 0
        Me.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShow.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShow.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnShow.Location = New System.Drawing.Point(488, 3)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(109, 28)
        Me.btnShow.TabIndex = 18
        Me.btnShow.Text = "&SHOW"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnUpdate.Location = New System.Drawing.Point(582, 3)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(109, 28)
        Me.btnUpdate.TabIndex = 17
        Me.btnUpdate.Text = "&UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'BtnExit2
        '
        Me.BtnExit2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnExit2.FlatAppearance.BorderSize = 0
        Me.BtnExit2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExit2.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnExit2.Location = New System.Drawing.Point(0, 3)
        Me.BtnExit2.Name = "BtnExit2"
        Me.BtnExit2.Size = New System.Drawing.Size(109, 28)
        Me.BtnExit2.TabIndex = 2
        Me.BtnExit2.Text = "&EXIT"
        Me.BtnExit2.UseVisualStyleBackColor = True
        '
        'cborec
        '
        Me.cborec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cborec.Font = New System.Drawing.Font("Bernard MT Condensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cborec.FormattingEnabled = True
        Me.cborec.Items.AddRange(New Object() {"Accounts", "Monitor User"})
        Me.cborec.Location = New System.Drawing.Point(148, 34)
        Me.cborec.Name = "cborec"
        Me.cborec.Size = New System.Drawing.Size(110, 24)
        Me.cborec.TabIndex = 4
        '
        'cbosel
        '
        Me.cbosel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbosel.Font = New System.Drawing.Font("Bernard MT Condensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbosel.FormattingEnabled = True
        Me.cbosel.Items.AddRange(New Object() {"Student", "Employee", "Teacher", "Professor", "Administrator", "Visitor"})
        Me.cbosel.Location = New System.Drawing.Point(408, 34)
        Me.cbosel.Name = "cbosel"
        Me.cbosel.Size = New System.Drawing.Size(107, 24)
        Me.cbosel.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bernard MT Condensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(63, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Choose Record"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bernard MT Condensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(320, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Select Usertype"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bernard MT Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 22)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "DISPLAY RECORD"
        '
        'Dgvtbl
        '
        Me.Dgvtbl.AllowUserToAddRows = False
        Me.Dgvtbl.AllowUserToDeleteRows = False
        Me.Dgvtbl.AllowUserToOrderColumns = True
        Me.Dgvtbl.AllowUserToResizeColumns = False
        Me.Dgvtbl.AllowUserToResizeRows = False
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(97, Byte), Integer))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        Me.Dgvtbl.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.Dgvtbl.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(49, Byte), Integer))
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgvtbl.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.Dgvtbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgvtbl.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Dgvtbl.Location = New System.Drawing.Point(66, 68)
        Me.Dgvtbl.Name = "Dgvtbl"
        Me.Dgvtbl.Size = New System.Drawing.Size(673, 222)
        Me.Dgvtbl.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bernard MT Condensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(596, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "No of Data"
        '
        'txtCount
        '
        Me.txtCount.Font = New System.Drawing.Font("Bernard MT Condensed", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCount.Location = New System.Drawing.Point(660, 36)
        Me.txtCount.Name = "txtCount"
        Me.txtCount.Size = New System.Drawing.Size(112, 21)
        Me.txtCount.TabIndex = 10
        '
        'Btndate
        '
        Me.Btndate.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Btndate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btndate.FlatAppearance.BorderSize = 0
        Me.Btndate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btndate.Font = New System.Drawing.Font("Bernard MT Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btndate.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btndate.Location = New System.Drawing.Point(660, 2)
        Me.Btndate.Name = "Btndate"
        Me.Btndate.Size = New System.Drawing.Size(109, 28)
        Me.Btndate.TabIndex = 20
        Me.Btndate.Text = "&Show  Calendar"
        Me.Btndate.UseVisualStyleBackColor = False
        '
        'DisplayData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(784, 348)
        Me.Controls.Add(Me.Btndate)
        Me.Controls.Add(Me.txtCount)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbosel)
        Me.Controls.Add(Me.cborec)
        Me.Controls.Add(Me.Dgvtbl)
        Me.Controls.Add(Me.Panel1)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DisplayData"
        Me.Text = "DisplayData"
        Me.Panel1.ResumeLayout(False)
        CType(Me.Dgvtbl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnUpdate As Button
    Friend WithEvents BtnExit2 As Button
    Friend WithEvents cborec As ComboBox
    Friend WithEvents cbosel As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnShow As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btnadd As Button
    Friend WithEvents Dgvtbl As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCount As TextBox
    Friend WithEvents Btndate As Button
End Class