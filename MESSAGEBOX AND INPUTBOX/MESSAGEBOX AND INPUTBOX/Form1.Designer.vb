<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.B_MESSAGE = New System.Windows.Forms.Button
        Me.B_INPUTBOX = New System.Windows.Forms.Button
        Me.B_EXIT = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'B_MESSAGE
        '
        Me.B_MESSAGE.AutoSize = True
        Me.B_MESSAGE.Location = New System.Drawing.Point(186, 68)
        Me.B_MESSAGE.Name = "B_MESSAGE"
        Me.B_MESSAGE.Size = New System.Drawing.Size(91, 23)
        Me.B_MESSAGE.TabIndex = 0
        Me.B_MESSAGE.Text = "MESSAGEBOX"
        Me.B_MESSAGE.UseVisualStyleBackColor = True
        '
        'B_INPUTBOX
        '
        Me.B_INPUTBOX.AutoSize = True
        Me.B_INPUTBOX.Location = New System.Drawing.Point(186, 117)
        Me.B_INPUTBOX.Name = "B_INPUTBOX"
        Me.B_INPUTBOX.Size = New System.Drawing.Size(75, 23)
        Me.B_INPUTBOX.TabIndex = 1
        Me.B_INPUTBOX.Text = "INPUTBOX"
        Me.B_INPUTBOX.UseVisualStyleBackColor = True
        '
        'B_EXIT
        '
        Me.B_EXIT.AutoSize = True
        Me.B_EXIT.Location = New System.Drawing.Point(186, 180)
        Me.B_EXIT.Name = "B_EXIT"
        Me.B_EXIT.Size = New System.Drawing.Size(75, 23)
        Me.B_EXIT.TabIndex = 2
        Me.B_EXIT.Text = "EXIT"
        Me.B_EXIT.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(30, 68)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.B_EXIT)
        Me.Controls.Add(Me.B_INPUTBOX)
        Me.Controls.Add(Me.B_MESSAGE)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents B_MESSAGE As System.Windows.Forms.Button
    Friend WithEvents B_INPUTBOX As System.Windows.Forms.Button
    Friend WithEvents B_EXIT As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox

End Class
