<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.TxtYear = New System.Windows.Forms.TextBox()
        Me.TxtSemester = New System.Windows.Forms.TextBox()
        Me.BtnOk = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.stdInfo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(81, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(81, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(81, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Year"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(81, 213)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Semester"
        '
        'TxtId
        '
        Me.TxtId.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtId.Location = New System.Drawing.Point(181, 68)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(101, 24)
        Me.TxtId.TabIndex = 4
        '
        'TxtName
        '
        Me.TxtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtName.Location = New System.Drawing.Point(181, 117)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(101, 24)
        Me.TxtName.TabIndex = 5
        '
        'TxtYear
        '
        Me.TxtYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtYear.Location = New System.Drawing.Point(181, 163)
        Me.TxtYear.Name = "TxtYear"
        Me.TxtYear.Size = New System.Drawing.Size(101, 24)
        Me.TxtYear.TabIndex = 6
        '
        'TxtSemester
        '
        Me.TxtSemester.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSemester.Location = New System.Drawing.Point(181, 213)
        Me.TxtSemester.Name = "TxtSemester"
        Me.TxtSemester.Size = New System.Drawing.Size(101, 24)
        Me.TxtSemester.TabIndex = 7
        '
        'BtnOk
        '
        Me.BtnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOk.Location = New System.Drawing.Point(118, 303)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(148, 45)
        Me.BtnOk.TabIndex = 8
        Me.BtnOk.Text = "Ok"
        Me.BtnOk.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 18
        Me.ListBox1.Location = New System.Drawing.Point(413, 68)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(261, 166)
        Me.ListBox1.TabIndex = 10
        '
        'BtnClose
        '
        Me.BtnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.Location = New System.Drawing.Point(494, 303)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(180, 45)
        Me.BtnClose.TabIndex = 11
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'stdInfo
        '
        Me.stdInfo.AutoSize = True
        Me.stdInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stdInfo.Location = New System.Drawing.Point(291, 9)
        Me.stdInfo.Name = "stdInfo"
        Me.stdInfo.Size = New System.Drawing.Size(155, 18)
        Me.stdInfo.TabIndex = 12
        Me.stdInfo.Text = "Student Information"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.stdInfo)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.BtnOk)
        Me.Controls.Add(Me.TxtSemester)
        Me.Controls.Add(Me.TxtYear)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.TxtId)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtId As TextBox
    Friend WithEvents TxtName As TextBox
    Friend WithEvents TxtYear As TextBox
    Friend WithEvents TxtSemester As TextBox
    Friend WithEvents BtnOk As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents BtnClose As Button
    Friend WithEvents stdInfo As Label
End Class
