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
        Me.BtnTry2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnOk
        '
        Me.BtnOk.Location = New System.Drawing.Point(110, 248)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(176, 97)
        Me.BtnOk.TabIndex = 0
        Me.BtnOk.Text = "Ok"
        Me.BtnOk.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(201, 21)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(325, 173)
        Me.ListBox1.TabIndex = 1
        '
        'BtnTry
        '
        Me.BtnTry.Location = New System.Drawing.Point(340, 248)
        Me.BtnTry.Name = "BtnTry"
        Me.BtnTry.Size = New System.Drawing.Size(168, 97)
        Me.BtnTry.TabIndex = 2
        Me.BtnTry.Text = "Try"
        Me.BtnTry.UseVisualStyleBackColor = True
        '
        'BtnTry2
        '
        Me.BtnTry2.Location = New System.Drawing.Point(565, 253)
        Me.BtnTry2.Name = "BtnTry2"
        Me.BtnTry2.Size = New System.Drawing.Size(160, 91)
        Me.BtnTry2.TabIndex = 3
        Me.BtnTry2.Text = "New Try"
        Me.BtnTry2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnTry2)
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
    Friend WithEvents BtnTry2 As Button
End Class
