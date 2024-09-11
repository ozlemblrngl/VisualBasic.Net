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
        Me.BtnOk = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.BtnTry = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnOk
        '
        Me.BtnOk.Location = New System.Drawing.Point(55, 249)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(296, 94)
        Me.BtnOk.TabIndex = 0
        Me.BtnOk.Text = "Ok"
        Me.BtnOk.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(55, 26)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(524, 186)
        Me.ListBox1.TabIndex = 1
        '
        'BtnTry
        '
        Me.BtnTry.Location = New System.Drawing.Point(457, 250)
        Me.BtnTry.Name = "BtnTry"
        Me.BtnTry.Size = New System.Drawing.Size(237, 92)
        Me.BtnTry.TabIndex = 2
        Me.BtnTry.Text = "Try"
        Me.BtnTry.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnTry)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.BtnOk)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnOk As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents BtnTry As Button
End Class
