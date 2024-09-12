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
        Me.Nmb1 = New System.Windows.Forms.Label()
        Me.Nmb2 = New System.Windows.Forms.Label()
        Me.TxtNmb1 = New System.Windows.Forms.TextBox()
        Me.TxtNmb2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BtnOk
        '
        Me.BtnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOk.Location = New System.Drawing.Point(215, 204)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(170, 68)
        Me.BtnOk.TabIndex = 0
        Me.BtnOk.Text = "Ok"
        Me.BtnOk.UseVisualStyleBackColor = True
        '
        'Nmb1
        '
        Me.Nmb1.AutoSize = True
        Me.Nmb1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nmb1.Location = New System.Drawing.Point(75, 50)
        Me.Nmb1.Name = "Nmb1"
        Me.Nmb1.Size = New System.Drawing.Size(81, 18)
        Me.Nmb1.TabIndex = 1
        Me.Nmb1.Text = "Number 1"
        '
        'Nmb2
        '
        Me.Nmb2.AutoSize = True
        Me.Nmb2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nmb2.Location = New System.Drawing.Point(75, 99)
        Me.Nmb2.Name = "Nmb2"
        Me.Nmb2.Size = New System.Drawing.Size(81, 18)
        Me.Nmb2.TabIndex = 2
        Me.Nmb2.Text = "Number 2"
        '
        'TxtNmb1
        '
        Me.TxtNmb1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNmb1.Location = New System.Drawing.Point(215, 49)
        Me.TxtNmb1.Name = "TxtNmb1"
        Me.TxtNmb1.Size = New System.Drawing.Size(170, 24)
        Me.TxtNmb1.TabIndex = 3
        '
        'TxtNmb2
        '
        Me.TxtNmb2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNmb2.Location = New System.Drawing.Point(215, 97)
        Me.TxtNmb2.Name = "TxtNmb2"
        Me.TxtNmb2.Size = New System.Drawing.Size(170, 24)
        Me.TxtNmb2.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(468, 344)
        Me.Controls.Add(Me.TxtNmb2)
        Me.Controls.Add(Me.TxtNmb1)
        Me.Controls.Add(Me.Nmb2)
        Me.Controls.Add(Me.Nmb1)
        Me.Controls.Add(Me.BtnOk)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnOk As Button
    Friend WithEvents Nmb1 As Label
    Friend WithEvents Nmb2 As Label
    Friend WithEvents TxtNmb1 As TextBox
    Friend WithEvents TxtNmb2 As TextBox
End Class
