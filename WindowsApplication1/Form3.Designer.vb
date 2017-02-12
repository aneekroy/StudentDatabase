<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(40, 35)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(171, 34)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Add Student to Database"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(40, 75)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(171, 34)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Update/Modify Student Database"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(40, 115)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(171, 34)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "Display All Records"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(77, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Student Database"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(40, 155)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(171, 34)
        Me.Button6.TabIndex = 0
        Me.Button6.Text = "Display Single Record"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(40, 277)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(171, 34)
        Me.Button7.TabIndex = 0
        Me.Button7.Text = "Exit"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(40, 195)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(171, 35)
        Me.Button8.TabIndex = 2
        Me.Button8.Text = "Display Partial Records"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(40, 236)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(171, 35)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "Delete Single Record"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(256, 333)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form3"
        Me.Text = "Student Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button4 As Button
End Class
